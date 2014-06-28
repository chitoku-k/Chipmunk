using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace Chipmunk
{
    /// <summary>
    /// <see cref="System.Windows.Controls.PasswordBox"/> への添付ビヘイビアを提供します。
    /// </summary>
    public class PasswordBoxBehavior
    {
        #region BindsPassword 添付プロパティ

        /// <summary>
        /// 指定された <see cref="System.Windows.Controls.PasswordBox"/> から Chipmunk.PasswordBoxBehavior.BindsPassword 添付プロパティの値を取得します。
        /// </summary>
        /// <param name="element">プロパティ値の読み取り元の要素。</param>
        /// <returns>Chipmunk.PasswordBoxBehavior.BindsPassword 添付プロパティの値。</returns>
        [AttachedPropertyBrowsableForType(typeof(PasswordBox))]
        public static bool GetBindsPassword(PasswordBox element)
        {
            return (bool)element.GetValue(BindsPasswordProperty);
        }

        /// <summary>
        /// Chipmunk.PasswordBoxBehavior.BindsPassword 添付プロパティの値を、指定された <see cref="System.Windows.Controls.PasswordBox"/> に設定します。
        /// </summary>
        /// <param name="element">Chipmunk.PasswordBoxBehavior.BindsPassword 添付プロパティを設定する要素。</param>
        /// <param name="value">設定するプロパティ値。</param>
        [AttachedPropertyBrowsableForType(typeof(PasswordBox))]
        public static void SetBindsPassword(PasswordBox element, bool value)
        {
            element.SetValue(BindsPasswordProperty, value);
        }

        /// <summary>
        /// Chipmunk.PasswordBoxBehavior.BindsPassword 添付プロパティを識別します。
        /// </summary>
        public static readonly DependencyProperty BindsPasswordProperty =
            DependencyProperty.RegisterAttached("BindsPassword", typeof(bool), typeof(PasswordBoxBehavior), new PropertyMetadata(false, BindsPassword_Changed));

        #endregion

        #region Password 添付プロパティ

        /// <summary>
        /// 指定された <see cref="System.Windows.Controls.PasswordBox"/> から Chipmunk.PasswordBoxBehavior.Password 添付プロパティの値を取得します。
        /// </summary>
        /// <param name="element">プロパティ値の読み取り元の要素。</param>
        /// <returns>Chipmunk.PasswordBoxBehavior.Password 添付プロパティの値。</returns>
        [AttachedPropertyBrowsableForType(typeof(PasswordBox))]
        public static string GetPassword(PasswordBox element)
        {
            return (string)element.GetValue(PasswordProperty);
        }

        /// <summary>
        /// Chipmunk.PasswordBoxBehavior.Password 添付プロパティの値を、指定された <see cref="System.Windows.Controls.PasswordBox"/> に設定します。
        /// </summary>
        /// <param name="element">Chipmunk.PasswordBoxBehavior.Password 添付プロパティを設定する要素。</param>
        /// <param name="value">設定するプロパティ値。</param>
        [AttachedPropertyBrowsableForType(typeof(PasswordBox))]
        public static void SetPassword(PasswordBox element, string value)
        {
            element.SetValue(PasswordProperty, value);
        }

        /// <summary>
        /// Chipmunk.PasswordBoxBehavior.Password 添付プロパティを識別します。
        /// </summary>
        public static readonly DependencyProperty PasswordProperty =
            DependencyProperty.RegisterAttached("Password", typeof(string), typeof(PasswordBoxBehavior), new FrameworkPropertyMetadata("", FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));

        #endregion

        private static void BindsPassword_Changed(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            var element = sender as PasswordBox;
            if (element == null)
                return;

            if (!(bool)e.OldValue && (bool)e.NewValue)
                element.PasswordChanged += Password_Changed;

            if ((bool)e.OldValue && !(bool)e.NewValue)
                element.PasswordChanged -= Password_Changed;
        }

        private static void Password_Changed(object sender, RoutedEventArgs e)
        {
            var element = sender as PasswordBox;
            if (element == null)
                return;

            SetPassword(element, element.Password);
        }
    }
}
