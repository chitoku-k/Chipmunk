using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Chipmunk
{
    /// <summary>
    /// <see cref="System.Windows.Controls.TextBox"/> への添付ビヘイビアを提供します。
    /// </summary>
    public class TextBoxBehavior
    {
        #region ValidationType 添付プロパティ

        /// <summary>
        /// 指定された <see cref="System.Windows.Controls.TextBox"/> から Chipmunk.TextBoxBehavior.ValidationType 添付プロパティの値を取得します。
        /// </summary>
        /// <param name="element">プロパティ値の読み取り元の要素。</param>
        /// <returns><see cref="Chipmunk.TextBoxValidationType"/> 添付プロパティの値。</returns>
        [AttachedPropertyBrowsableForType(typeof(TextBox))]
        public static TextBoxValidationType GetValidationType(TextBox element)
        {
            return (TextBoxValidationType)element.GetValue(ValidationTypeProperty);
        }

        /// <summary>
        /// Chipmunk.TextBoxBehavior.ValidationType 添付プロパティの値を、指定された <see cref="System.Windows.Controls.TextBox"/> に設定します。
        /// </summary>
        /// <param name="element">Chipmunk.TextBoxBehavior.ValidationType 添付プロパティを設定する要素。</param>
        /// <param name="value">設定するプロパティ値。</param>
        [AttachedPropertyBrowsableForType(typeof(TextBox))]
        public static void SetValidationType(TextBox element, TextBoxValidationType value)
        {
            element.SetValue(ValidationTypeProperty, value);
        }

        /// <summary>
        /// Chipmunk.TextBoxBehavior.ValidationType 添付プロパティを識別します。
        /// </summary>
        public static readonly DependencyProperty ValidationTypeProperty =
            DependencyProperty.RegisterAttached("ValidationType", typeof(TextBoxValidationType), typeof(TextBoxBehavior), new PropertyMetadata(TextBoxValidationType.None, ValidationType_Changed));

        #endregion

        private static Dictionary<TextBox, TextBoxValidationInfo> _textBoxDictionary = new Dictionary<TextBox, TextBoxValidationInfo>();
        private const string NegativeDecimalPattern = @"^-?(?:\d*\.\d+|\d+\.?)$";
        private const string NegativeIntegerPattern = @"^-?\d+$";
        private const string DecimalPattern = @"^(?:\d*\.\d+|\d+\.?)$";
        private const string IntegerPattern = @"^\d+$";
        private const string FullWidthPattern = @"[０-９]";

        private static string ToHalfWidth(string s)
        {
            return Regex.Replace(s, FullWidthPattern, x => string.Concat(x.Value.Select(y => (char)((int)y - 0xFEE0))));
        }

        private static void ValidationType_Changed(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            var element = sender as TextBox;
            if (element == null)
                return;
            
            element.GotFocus -= OnGotFocus;
            element.TextChanged -= OnTextChanged;
            element.SelectionChanged -= OnSelectionChanged;
            _textBoxDictionary.Remove(element);

            if ((TextBoxValidationType)e.NewValue != TextBoxValidationType.None)
            {
                element.GotFocus += OnGotFocus;
                element.TextChanged += OnTextChanged;
                element.SelectionChanged += OnSelectionChanged;
                _textBoxDictionary.Add(element, new TextBoxValidationInfo((TextBoxValidationType)e.NewValue, element.Text));
            }
        }

        private static void OnGotFocus(object sender, RoutedEventArgs e)
        {
            var element = sender as TextBox;
            if (element == null)
                return;

            InputMethod.Current.ImeState = InputMethodState.Off;
        }

        private static void OnSelectionChanged(object sender, RoutedEventArgs e)
        {
            var element = sender as TextBox;
            if (!_textBoxDictionary.ContainsKey(element))
                return;
            else
                _textBoxDictionary[element].CaretIndex = element.CaretIndex;
        }

        private static void OnTextChanged(object sender, TextChangedEventArgs e)
        {
            var element = sender as TextBox;
            if (!_textBoxDictionary.ContainsKey(element))
                return;

            var option = _textBoxDictionary[element].Type;
            string pattern = null;
            if (option.HasFlag(TextBoxValidationType.Integer))
                pattern = IntegerPattern;
            if (option.HasFlag(TextBoxValidationType.Decimal))
                pattern = DecimalPattern;
            if (option.HasFlag(TextBoxValidationType.Negative | TextBoxValidationType.Integer))
                pattern = NegativeIntegerPattern;
            if (option.HasFlag(TextBoxValidationType.Negative | TextBoxValidationType.Decimal))
                pattern = NegativeDecimalPattern;

            if (pattern == null)
                return;

            int index = element.CaretIndex;
            element.Text = element.Text == "" ? "0" : ToHalfWidth(element.Text.Replace(",", ""));
            element.CaretIndex = index;

            if (Regex.IsMatch(element.Text, pattern))
            {
                _textBoxDictionary[element].Text = element.Text;
            }
            else if (option.HasFlag(TextBoxValidationType.Negative) && (element.Text == "-" || element.Text == "0-"))
            {
                element.Text = _textBoxDictionary[element].Text = "-0";
                element.CaretIndex = 2;
            }
            else
            {
                SystemSounds.Beep.Play();
                element.Text = _textBoxDictionary[element].Text;
                element.CaretIndex = _textBoxDictionary[element].CaretIndex;
                e.Handled = true;
                return;
            }

            if (option.HasFlag(TextBoxValidationType.Decimal) && element.Text.EndsWith("."))
                return;

            string d = decimal.Parse(element.Text).ToString();
            if (element.Text != d && element.Text != "-0")
            {
                element.Text = d;
                element.CaretIndex = _textBoxDictionary[element].CaretIndex;
            }
        }

        private class TextBoxValidationInfo
        {
            public TextBoxValidationType Type { get; set; }
            public string Text { get; set; }
            public int CaretIndex { get; set; }

            public TextBoxValidationInfo(TextBoxValidationType type, string text)
            {
                this.Type = type;
                this.Text = text;
            }
        }
    }

    /// <summary>
    /// テキストボックスの値の検証方法を指定します。
    /// </summary>
    [Flags]
    public enum TextBoxValidationType
    {
        /// <summary>
        /// 値を検証しません。
        /// </summary>
        None = 0x00,
        /// <summary>
        /// 値がゼロまたは正の整数であるかどうかを検証します。
        /// </summary>
        Integer = 0x01,
        /// <summary>
        /// 値がゼロまたは正の数であるかどうかを検証します。
        /// </summary>
        Decimal = 0x02,
        /// <summary>
        /// 値がゼロ、正の数または負の数であるかどうかを検証します。
        /// </summary>
        Negative = 0x04
    }
}
