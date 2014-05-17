using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Input;

namespace Chipmunk
{
    /// <summary>
    /// 数値を表示するスピン ボックス (アップダウン コントロール) を表します。
    /// </summary>
    public class NumericUpDown : RangeBase
    {
        /// <summary>
        /// <see cref="System.Windows.Controls.Primitives.RangeBase.LargeChange"/> のプロパティと同じ量コントロールの値を減らすコマンドを取得します。
        /// </summary>
        public static ICommand Decrease = new RoutedCommand("DecreaseCommand", typeof(NumericUpDown), new InputGestureCollection { new KeyGesture(Key.Down) });
        /// <summary>
        /// <see cref="System.Windows.Controls.Primitives.RangeBase.LargeChange"/> のプロパティと同じ量コントロールの値を増加するコマンドを取得します。
        /// </summary>
        public static ICommand Increase = new RoutedCommand("IncreaseCommand", typeof(NumericUpDown), new InputGestureCollection { new KeyGesture(Key.Up) });

        static NumericUpDown()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(NumericUpDown), new FrameworkPropertyMetadata(typeof(NumericUpDown)));
            CommandManager.RegisterClassCommandBinding(typeof(NumericUpDown), new CommandBinding(Decrease, OnDecreaseCommand));
            CommandManager.RegisterClassCommandBinding(typeof(NumericUpDown), new CommandBinding(Increase, OnIncreaseCommand));
        }

        private static void OnDecreaseCommand(object sender, ExecutedRoutedEventArgs e)
        {
            ((NumericUpDown)sender).OnDecreaseCommand();
        }

        private static void OnIncreaseCommand(object sender, ExecutedRoutedEventArgs e)
        {
            ((NumericUpDown)sender).OnIncreaseCommand();
        }

        /// <summary>
        /// <see cref="Chipmunk.NumericUpDown.Decrease"/> コマンドに応答します。
        /// </summary>
        public void OnDecreaseCommand()
        {
            this.Value -= this.LargeChange;
        }

        /// <summary>
        /// <see cref="Chipmunk.NumericUpDown.Increase"/> コマンドに応答します。
        /// </summary>
        public void OnIncreaseCommand()
        {
            this.Value += this.LargeChange;
        }
    }
}
