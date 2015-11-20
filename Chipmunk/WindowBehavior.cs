using Chipmunk.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;

namespace Chipmunk
{
    /// <summary>
    /// <see cref="System.Windows.Window"/> への添付ビヘイビアを提供します。
    /// </summary>
    public class WindowBehavior
    {
        #region IsMinimizeButtonEnabled 添付プロパティ

        /// <summary>
        /// 指定された <see cref="System.Windows.Window"/> から Chipmunk.WindowBehavior.IsMinimizedButtonEnabled 添付プロパティの値を取得します。
        /// </summary>
        /// <param name="element">プロパティ値の読み取り元の要素。</param>
        /// <returns>IsMinimizedButtonEnabled 添付プロパティの値。</returns>
        [AttachedPropertyBrowsableForType(typeof(Window))]
        public static bool GetIsMinimizeButtonEnabled(Window element) => (bool)element.GetValue(IsMinimizeButtonEnabledProperty);

        /// <summary>
        /// Chipmunk.WindowBehavior.IsMinimizedButtonEnabled 添付プロパティの値を、指定された <see cref="System.Windows.Window"/> に設定します。
        /// </summary>
        /// <param name="element">Chipmunk.WindowBehavior.IsMinimizedButtonEnabled 添付プロパティを設定する要素。</param>
        /// <param name="value">設定するプロパティ値。</param>
        [AttachedPropertyBrowsableForType(typeof(Window))]
        public static void SetIsMinimizeButtonEnabled(Window element, bool value) => element.SetValue(IsMinimizeButtonEnabledProperty, value);

        /// <summary>
        /// Chipmunk.WindowBehavior.IsMinimizedButtonEnabled 添付プロパティを識別します。
        /// </summary>
        public static readonly DependencyProperty IsMinimizeButtonEnabledProperty =
            DependencyProperty.RegisterAttached("IsMinimizeButtonEnabled", typeof(bool), typeof(WindowBehavior), new PropertyMetadata(true, IsMinimizeButtonEnabled_Changed));

        #endregion

        #region IsMaximizeButtonEnabled 添付プロパティ

        /// <summary>
        /// 指定された <see cref="System.Windows.Window"/> から Chipmunk.WindowBehavior.IsMaximizeButtonEnabled 添付プロパティの値を取得します。
        /// </summary>
        /// <param name="element">プロパティ値の読み取り元の要素。</param>
        /// <returns>Chipmunk.IsMaximizeButtonEnabled 添付プロパティの値。</returns>
        [AttachedPropertyBrowsableForType(typeof(Window))]
        public static bool GetIsMaximizeButtonEnabled(Window element) => (bool)element.GetValue(IsMaximizeButtonEnabledProperty);

        /// <summary>
        /// Chipmunk.WindowBehavior.IsMaximizeButtonEnabled 添付プロパティの値を、指定された <see cref="System.Windows.Window"/> に設定します。
        /// </summary>
        /// <param name="element">Chipmunk.WindowBehavior.IsMaximizeButtonEnabled 添付プロパティを設定する要素。</param>
        /// <param name="value">設定するプロパティ値。</param>
        [AttachedPropertyBrowsableForType(typeof(Window))]
        public static void SetIsMaximizeButtonEnabled(Window element, bool value) => element.SetValue(IsMaximizeButtonEnabledProperty, value);

        /// <summary>
        /// Chipmunk.WindowBehavior.IsMaximizeButtonEnabled 添付プロパティを識別します。
        /// </summary>
        public static readonly DependencyProperty IsMaximizeButtonEnabledProperty =
            DependencyProperty.RegisterAttached("IsMaximizeButtonEnabled", typeof(bool), typeof(WindowBehavior), new PropertyMetadata(true, IsMaximizeButtonEnabled_Changed));

        #endregion

        #region IsHelpButtonEnabled 添付プロパティ

        /// <summary>
        /// 指定された <see cref="System.Windows.Window"/> から Chipmunk.WindowBehavior.IsHelpButtonEnabled 添付プロパティの値を取得します。
        /// </summary>
        /// <param name="element">プロパティ値の読み取り元の要素。</param>
        /// <returns>Chipmunk.WimdowBehavior.IsHelpButtonEnabled 添付プロパティの値。</returns>
        [AttachedPropertyBrowsableForType(typeof(Window))]
        public static bool GetIsHelpButtonEnabled(Window element) => (bool)element.GetValue(IsHelpButtonEnabledProperty);

        /// <summary>
        /// Chipmunk.WindowBehavior.IsHelpButtonEnabled 添付プロパティの値を、指定された <see cref="System.Windows.Window"/> に設定します。
        /// </summary>
        /// <param name="element">Chipmunk.WindowBehavior.IsHelpButtonEnabled 添付プロパティを設定する要素。</param>
        /// <param name="value">設定するプロパティ値。</param>
        [AttachedPropertyBrowsableForType(typeof(Window))]
        public static void SetIsHelpButtonEnabled(Window element, bool value) => element.SetValue(IsHelpButtonEnabledProperty, value);

        /// <summary>
        /// Chipmunk.WindowBehavior.IsHelpButtonEnabled 添付プロパティを識別します。
        /// </summary>
        public static readonly DependencyProperty IsHelpButtonEnabledProperty =
            DependencyProperty.RegisterAttached("IsHelpButtonEnabled", typeof(bool), typeof(WindowBehavior), new PropertyMetadata(false, IsHelpButtonEnabled_Changed));

        #endregion

        #region IsControlButtonVisible 添付プロパティ

        /// <summary>
        /// 指定された <see cref="System.Windows.Window"/> から Chipmunk.WindowBehavior.IsControlButtonVisible 添付プロパティの値を取得します。
        /// </summary>
        /// <param name="element">プロパティ値の読み取り元の要素。</param>
        /// <returns>Chipmunk.IsControlButtonVisible 添付プロパティの値。</returns>
        [AttachedPropertyBrowsableForType(typeof(Window))]
        public static bool GetIsControlButtonVisible(Window element) => (bool)element.GetValue(IsControlButtonVisibleProperty);

        /// <summary>
        /// Chipmunk.WindowBehavior.IsControlButtonVisible 添付プロパティの値を、指定された <see cref="System.Windows.Window"/> に設定します。
        /// </summary>
        /// <param name="element">Chipmunk.WindowBehavior.IsControlButtonVisible 添付プロパティを設定する要素。</param>
        /// <param name="value">設定するプロパティ値。</param>
        [AttachedPropertyBrowsableForType(typeof(Window))]
        public static void SetIsControlButtonVisible(Window element, bool value) => element.SetValue(IsControlButtonVisibleProperty, value);

        /// <summary>
        /// Chipmunk.WindowBehavior.IsControlButtonVisible 添付プロパティを識別します。
        /// </summary>
        public static readonly DependencyProperty IsControlButtonVisibleProperty =
            DependencyProperty.RegisterAttached("IsControlButtonVisible", typeof(bool), typeof(WindowBehavior), new PropertyMetadata(true, IsControlButtonVisible_Changed));

        #endregion

        #region IsCloseButtonEnabled 添付プロパティ

        /// <summary>
        /// 指定された <see cref="System.Windows.Window"/> から Chipmunk.WindowBehavior.IsCloseButtonEnabled 添付プロパティの値を取得します。
        /// </summary>
        /// <param name="element">プロパティ値の読み取り元の要素。</param>
        /// <returns>Chipmunk.IsCloseButtonEnabled 添付プロパティの値。</returns>
        [AttachedPropertyBrowsableForType(typeof(Window))]
        public static bool GetIsCloseButtonEnabled(Window element) => (bool)element.GetValue(IsCloseButtonEnabledProperty);

        /// <summary>
        /// Chipmunk.WindowBehavior.IsCloseButtonEnabled 添付プロパティの値を、指定された <see cref="System.Windows.Window"/> に設定します。
        /// </summary>
        /// <param name="element">Chipmunk.WindowBehavior.IsCloseButtonEnabled 添付プロパティを設定する要素。</param>
        /// <param name="value">設定するプロパティ値。</param>
        [AttachedPropertyBrowsableForType(typeof(Window))]
        public static void SetIsCloseButtonEnabled(Window element, bool value) => element.SetValue(IsCloseButtonEnabledProperty, value);

        /// <summary>
        /// Chipmunk.WindowBehavior.IsCloseButtonEnabled 添付プロパティを識別します。
        /// </summary>
        public static readonly DependencyProperty IsCloseButtonEnabledProperty =
            DependencyProperty.RegisterAttached("IsCloseButtonEnabled", typeof(bool), typeof(WindowBehavior), new PropertyMetadata(true, IsCloseButtonEnabled_Changed));

        #endregion

        #region IsIconVisible 添付プロパティ

        /// <summary>
        /// 指定された <see cref="System.Windows.Window"/> から Chipmunk.WindowBehavior.IsIconVisible 添付プロパティの値を取得します。
        /// </summary>
        /// <param name="element">プロパティ値の読み取り元の要素。</param>
        /// <returns>Chipmunk.IsIconVisible 添付プロパティの値。</returns>
        [AttachedPropertyBrowsableForType(typeof(Window))]
        public static bool GetIsIconVisible(Window element) => (bool)element.GetValue(IsIconVisibleProperty);

        /// <summary>
        /// Chipmunk.WindowBehavior.IsIconVisible 添付プロパティの値を、指定された <see cref="System.Windows.Window"/> に設定します。
        /// </summary>
        /// <param name="element">Chipmunk.WindowBehavior.IsIconVisible 添付プロパティを設定する要素。</param>
        /// <param name="value">設定するプロパティ値。</param>
        [AttachedPropertyBrowsableForType(typeof(Window))]
        public static void SetIsIconVisible(Window element, bool value) => element.SetValue(IsIconVisibleProperty, value);

        /// <summary>
        /// Chipmunk.WindowBehavior.IsIconVisible 添付プロパティを識別します。
        /// </summary>
        public static readonly DependencyProperty IsIconVisibleProperty =
            DependencyProperty.RegisterAttached("IsIconVisible", typeof(bool), typeof(WindowBehavior), new PropertyMetadata(true, IsIconVisible_Changed));

        #endregion

        #region DwmComposition 添付プロパティ

        /// <summary>
        /// 指定された <see cref="System.Windows.Window"/> から Chipmunk.WindowBehavior.DwmComposition 添付プロパティの値を取得します。
        /// </summary>
        /// <param name="element">プロパティ値の読み取り元の要素。</param>
        /// <returns>Chipmunk.DwmComposition 添付プロパティの値。</returns>
        [AttachedPropertyBrowsableForType(typeof(Window))]
        public static DwmCompositionOption GetDwmComposition(Window element) => (DwmCompositionOption)element.GetValue(DwmCompositionProperty);

        /// <summary>
        /// Chipmunk.WindowBehavior.DwmComposition 添付プロパティの値を、指定された <see cref="System.Windows.Window"/> に設定します。
        /// </summary>
        /// <param name="element">Chipmunk.WindowBehavior.DwmComposition 添付プロパティを設定する要素。</param>
        /// <param name="value">設定するプロパティ値。</param>
        [AttachedPropertyBrowsableForType(typeof(Window))]
        public static void SetDwmComposition(Window element, DwmCompositionOption value) => element.SetValue(DwmCompositionProperty, value);

        /// <summary>
        /// Chipmunk.WindowBehavior.DwmComposition 添付プロパティを識別します。
        /// </summary>
        public static readonly DependencyProperty DwmCompositionProperty =
            DependencyProperty.RegisterAttached("DwmComposition", typeof(DwmCompositionOption), typeof(WindowBehavior), new PropertyMetadata(null, DwmComposition_Changed));

        #endregion

        #region NonClientArea 添付プロパティ

        /// <summary>
        /// 指定された <see cref="System.Windows.UIElement"/> から Chipmunk.WindowBehavior.NonClientArea 添付プロパティの値を取得します。
        /// </summary>
        /// <param name="element">プロパティ値の読み取り元の要素。</param>
        /// <returns>Chipmunk.WindowBehavior.NonClientArea 添付プロパティの値。</returns>
        [AttachedPropertyBrowsableForType(typeof(UIElement))]
        public static Window GetNonClientArea(UIElement element) => (Window)element.GetValue(NonClientAreaProperty);

        /// <summary>
        /// Chipmunk.WindowBehavior.NonClientArea 添付プロパティの値を、指定された <see cref="System.Windows.UIElement"/> に設定します。
        /// </summary>
        /// <param name="element">Chipmunk.WindowBehavior.NonClientArea 添付プロパティを設定する要素。</param>
        /// <param name="value">設定するプロパティ値。</param>
        [AttachedPropertyBrowsableForType(typeof(UIElement))]
        public static void SetNonClientArea(UIElement element, Window value) => element.SetValue(NonClientAreaProperty, value);

        /// <summary>
        /// Chipmunk.WindowBehavior.NonClientArea 添付プロパティを識別します。
        /// </summary>
        public static readonly DependencyProperty NonClientAreaProperty =
            DependencyProperty.RegisterAttached("NonClientArea", typeof(Window), typeof(WindowBehavior), new PropertyMetadata(null, NonClientArea_Changed));

        #endregion

        #region HelpCommand 添付プロパティ

        /// <summary>
        /// 指定された <see cref="System.Windows.Window"/> から Chipmunk.WindowBehavior.HelpCommand 添付プロパティの値を取得します。
        /// </summary>
        /// <param name="element">プロパティ値の読み取り元の要素。</param>
        /// <returns>Chipmunk.WindowBehavior.HelpCommand 添付プロパティの値。</returns>
        [AttachedPropertyBrowsableForType(typeof(Window))]
        public static ICommand GetHelpCommand(Window element) => (ICommand)element.GetValue(HelpCommandProperty);

        /// <summary>
        /// Chipmunk.WindowBehavior.HelpCommand 添付プロパティの値を、指定された <see cref="System.Windows.Window"/> に設定します。
        /// </summary>
        /// <param name="element">Chipmunk.WindowBehavior.HelpCommand 添付プロパティを設定する要素。</param>
        /// <param name="value">設定するプロパティ値。</param>
        [AttachedPropertyBrowsableForType(typeof(Window))]
        public static void SetHelpCommand(Window element, ICommand value) => element.SetValue(HelpCommandProperty, value);

        /// <summary>
        /// Chipmunk.WindowBehavior.HelpCommand 添付プロパティを識別します。
        /// </summary>
        public static readonly DependencyProperty HelpCommandProperty =
            DependencyProperty.RegisterAttached("HelpCommand", typeof(ICommand), typeof(WindowBehavior), new PropertyMetadata(null));

        #endregion

        #region HelpCommandParameter 添付プロパティ

        /// <summary>
        /// 指定された <see cref="System.Windows.Window"/> から Chipmunk.WindowBehavior.HelpCommandParameter 添付プロパティの値を取得します。
        /// </summary>
        /// <param name="element">プロパティ値の読み取り元の要素。</param>
        /// <returns>Chipmunk.WindowBehavior.HelpCommandParameter 添付プロパティの値。</returns>
        [AttachedPropertyBrowsableForType(typeof(Window))]
        public static object GetHelpCommandParameter(Window element) => element.GetValue(HelpCommandParameterProperty);

        /// <summary>
        /// Chipmunk.WindowBehavior.HelpCommandParameter 添付プロパティの値を、指定された <see cref="System.Windows.DependencyObject"/> に設定します。
        /// </summary>
        /// <param name="element">Chipmunk.WindowBehavior.HelpCommandParameter 添付プロパティを設定する要素。</param>
        /// <param name="value">設定するプロパティ値。</param>
        [AttachedPropertyBrowsableForType(typeof(Window))]
        public static void SetHelpCommandParameter(Window element, object value) => element.SetValue(HelpCommandParameterProperty, value);

        /// <summary>
        /// Chipmunk.WindowBehavior.HelpCommandParameter 添付プロパティを識別します。
        /// </summary>
        public static readonly DependencyProperty HelpCommandParameterProperty =
            DependencyProperty.RegisterAttached("HelpCommandParameter", typeof(object), typeof(WindowBehavior), new PropertyMetadata(null));

        #endregion

        /// <summary>
        /// 実行中のオペレーティングシステムで Desktop Window Manager (DWM) がサポートされているかどうかを示す値を取得します。
        /// </summary>
        public static bool IsDwmSupported { get; } = Environment.OSVersion.Version.Major >= 6;

        private static Dictionary<Window, WindowBehaviorOption> _windowDictionary = new Dictionary<Window, WindowBehaviorOption>();

        private static IntPtr GetWindowHandleFromWindow(Window window) => new WindowInteropHelper(window).EnsureHandle();

        private static void SetWindowStyle(IntPtr hWnd, WS target, bool enabled)
        {
            var style = NativeMethods.GetWindowLong(hWnd, GWL.STYLE) | target;
            if (!enabled)
            {
                style ^= target;
            }
            NativeMethods.SetWindowLong(hWnd, GWL.STYLE, style);
            NativeMethods.SetWindowPos(hWnd, IntPtr.Zero, 0, 0, 0, 0, SWP.NOMOVE | SWP.NOSIZE | SWP.NOZORDER | SWP.FRAMECHANGED);
        }
        
        private static void SetWindowExtendedStyle(IntPtr hWnd, WS target, bool enabled)
        {
            var style = NativeMethods.GetWindowLong(hWnd, GWL.EXSTYLE) | target;
            if (!enabled)
            {
                style ^= target;
            }
            NativeMethods.SetWindowLong(hWnd, GWL.EXSTYLE, style);
            NativeMethods.SetWindowPos(hWnd, IntPtr.Zero, 0, 0, 0, 0, SWP.NOMOVE | SWP.NOSIZE | SWP.NOZORDER | SWP.FRAMECHANGED);
        }

        private static void RegisterWindow(Window window, Action<IntPtr> action)
        {
            if (window == null)
            {
                return;
            }

            action(GetWindowHandleFromWindow(window));

            if (_windowDictionary.ContainsKey(window))
            {
                return;
            }
            else
            {
                _windowDictionary.Add(window, new WindowBehaviorOption());
                RegisterWndProc(window);
            }
        }

        private static void RegisterWndProc(Window window)
        {
            var hWnd = GetWindowHandleFromWindow(window);
            var source = HwndSource.FromHwnd(hWnd);

            HwndSourceHook hook = (IntPtr hwnd, int msg, IntPtr wParam, IntPtr lParam, ref bool handled) =>
            {
                var option = _windowDictionary[window];
                var message = (WM)msg;

                if ((message == WM.THEMECHANGED || message == WM.DWMCOMPOSITIONCHANGED) && option.DwmComposition != null)
                {
                    DwmCompositionApply(window, hWnd, option.DwmComposition);
                }
                if (message == WM.SYSCOMMAND && wParam.ToInt32() == (int)SC.CLOSE && (!option.IsCloseButtonEnabled || !option.IsControlButtonEnabled))
                {
                    handled = true;
                }
                if (message == WM.SYSCOMMAND && wParam.ToInt32() == (int)SC.CONTEXTHELP)
                {
                    handled = true;

                    var command = GetHelpCommand(window);
                    var param = GetHelpCommandParameter(window);

                    if (command != null && command.CanExecute(param))
                    {
                        command.Execute(param);
                    }
                }
                return IntPtr.Zero;
            };
            source.AddHook(hook);
            window.Closed += (_, __) => source.RemoveHook(hook);
        }

        private static void IsMinimizeButtonEnabled_Changed(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            RegisterWindow(sender as Window, hWnd => SetWindowStyle(hWnd, WS.MINIMIZEBOX, (bool)e.NewValue));
        }

        private static void IsMaximizeButtonEnabled_Changed(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            RegisterWindow(sender as Window, hWnd => SetWindowStyle(hWnd, WS.MAXIMIZEBOX, (bool)e.NewValue));
        }

        private static void IsHelpButtonEnabled_Changed(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            RegisterWindow(sender as Window, hWnd => SetWindowExtendedStyle(hWnd, WS.EX_CONTEXTHELP, (bool)e.NewValue));
        }

        private static void IsControlButtonVisible_Changed(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            var window = sender as Window;
            if (window == null)
            {
                return;
            }

            RegisterWindow(window, hWnd => SetWindowStyle(hWnd, WS.SYSMENU, (bool)e.NewValue));
            _windowDictionary[window].IsControlButtonEnabled = (bool)e.NewValue;
        }

        private static void IsCloseButtonEnabled_Changed(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            var window = sender as Window;
            if (window == null)
            {
                return;
            }

            RegisterWindow(window, hWnd =>
            {
                var menu = NativeMethods.GetSystemMenu(hWnd, false);
                var modify = MF.BYCOMMAND | MF.ENABLED;

                if (!(bool)e.NewValue)
                {
                    modify |= MF.GRAYED;
                }

                NativeMethods.EnableMenuItem(menu, SC.CLOSE, modify);
            });

            _windowDictionary[window].IsCloseButtonEnabled = (bool)e.NewValue;
        }
        
        private static void IsIconVisible_Changed(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            var window = sender as Window;
            if (window == null)
            {
                return;
            }

            if (window.IsLoaded)
            {
                throw new InvalidOperationException("アイコンの表示はウィンドウが初期化される前に設定する必要があります。");
            }

            RegisterWindow(window, hWnd =>
            {
                NativeMethods.SendMessage(hWnd, WM.SETICON, (IntPtr)ICON.SMALL, IntPtr.Zero);
                NativeMethods.SendMessage(hWnd, WM.SETICON, (IntPtr)ICON.BIG, IntPtr.Zero);
                SetWindowExtendedStyle(hWnd, WS.EX_DLGMODALFRAME, !(bool)e.NewValue);
            });
        }

        private static void DwmComposition_Changed(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            var window = sender as Window;
            if (window == null || !IsDwmSupported)
            {
                return;
            }

            var option = e.NewValue as DwmCompositionOption;
            RegisterWindow(window, hWnd => DwmCompositionApply(window, hWnd, option));
            _windowDictionary[window].DwmComposition = option;
        }

        private static void DwmCompositionApply(Window window, IntPtr hWnd, DwmCompositionOption option)
        {
            bool isEnabled = NativeMethods.DwmIsCompositionEnabled();
            var source = HwndSource.FromHwnd(hWnd);
            var margin = option.Margin.ToMARGINS();
            var background = margin.Equals(0) || !isEnabled ? option.Background : Color.FromArgb(0x00, option.Background.R, option.Background.G, option.Background.B);

            if (isEnabled)
            {
                NativeMethods.DwmExtendFrameIntoClientArea(source.Handle, ref margin);
            }
            window.Background = new SolidColorBrush(background);
            source.CompositionTarget.BackgroundColor = background;
        }

        private static void NonClientArea_Changed(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            var element = sender as UIElement;
            var window = e.NewValue as Window;
            if (window == null)
            {
                return;
            }

            element.MouseLeftButtonDown += (_, __) => window.DragMove();
            element.MouseRightButtonUp += (_sender, _e) =>
            {
                var source = _e.Source as FrameworkElement;
                if (source is TextBoxBase || source.ContextMenu != null)
                {
                    return;
                }

                var point = NativeMethods.GetCursorPos();
                var param = new IntPtr(point.X | point.Y << 16);
                var hWnd = GetWindowHandleFromWindow(window);
                NativeMethods.PostMessage(hWnd, (WM)0x313, IntPtr.Zero, param);
            };
        }

        private class WindowBehaviorOption
        {
            public bool IsCloseButtonEnabled { get; set; } = true;
            public bool IsControlButtonEnabled { get; set; } = true;
            public DwmCompositionOption DwmComposition { get; set; }
        }
    }

    /// <summary>
    /// Desktop Window Manager (DWM) の合成設定を格納します。
    /// </summary>
    [TypeConverter(typeof(DwmCompositionOptionConverter))]
    public class DwmCompositionOption
    {
        /// <summary>
        /// ウィンドウの内側の余白を取得または設定します。
        /// </summary>
        public Thickness Margin { get; set; }
        /// <summary>
        /// DWM が無効の場合のウィンドウの背景色を取得または設定します。
        /// </summary>
        public Color Background { get; set; }

        /// <summary>
        /// ウィンドウの内側の余白に指定した <see cref="System.Windows.Thickness"/> 構造体の値を持つ <see cref="Chipmunk.DwmCompositionOption"/> 構造体の新しいインスタンスを初期化します。
        /// </summary>
        /// <param name="thickness">ウィンドウの内側の余白。</param>
        /// <param name="backgroundColor">DWM が無効の場合のウィンドウの背景色。</param>
        public DwmCompositionOption(Thickness thickness, Color backgroundColor)
        {
            this.Margin = thickness;
            this.Background = backgroundColor;
        }

        /// <summary>
        /// ウィンドウの内側の余白の各辺に均一な長さを指定して <see cref="Chipmunk.DwmCompositionOption"/> の新しいインスタンスを初期化します。
        /// </summary>
        /// <param name="uniformLength">外接する四角形の 4 つの辺すべてに均一に適用される長さ。</param>
        /// <param name="backgroundColor">DWM が無効の場合のウィンドウの背景色。</param>
        public DwmCompositionOption(double uniformLength, Color backgroundColor)
        {
            this.Margin = new Thickness(uniformLength);
            this.Background = backgroundColor;
        }

        /// <summary>
        /// ウィンドウの内側の余白の各辺に対して特定の長さ (<see cref="System.Double"/> として指定) が適用される、<see cref="Chipmunk.DwmCompositionOption"/> の新しいインスタンスを初期化します。
        /// </summary>
        /// <param name="left">四角形の左辺の太さ。</param>
        /// <param name="top">四角形の上辺の太さ。</param>
        /// <param name="right">四角形の右辺の太さ。</param>
        /// <param name="bottom">四角形の底辺の太さ。</param>
        /// <param name="backgroundColor">DWM が無効の場合のウィンドウの背景色。</param>
        public DwmCompositionOption(double left, double top, double right, double bottom, Color backgroundColor)
        {
            this.Margin = new Thickness(left, top, right, bottom);
            this.Background = backgroundColor;
        }
    }

    /// <summary>
    /// 他の型のインスタンスと <see cref="Chipmunk.DwmCompositionOption"/> のインスタンスの間の変換を行います。
    /// </summary>
    public class DwmCompositionOptionConverter : TypeConverter
    {
        private const string UniformLengthPattern = @"([\d\-\.]+)(?:[, ])([#a-zA-Z0-9]+)";
        private const string IndivisualLengthPattern = @"([\d\-\.]+)(?:[, ])([\d\-\.]+)(?:[, ])([\d\-\.]+)(?:[, ])([\d\-\.]+)(?:[, ])([#a-zA-Z0-9]+)";
        private static readonly ColorConverter _converter = new ColorConverter();

        private Color ToColor(string s) => (Color)_converter.ConvertFrom(s);

        private double ToDouble(string s)
        {
            double value;
            return double.TryParse(s, out value) ? value : 0;
        }

        /// <summary>
        /// 指定したコンテキストを使用して、コンバーターが特定の型のオブジェクトをコンバーターの型に変換できるかどうかを示す値を返します。
        /// </summary>
        /// <param name="context">書式指定コンテキストを提供する <see cref="System.ComponentModel.ITypeDescriptorContext"/>。</param>
        /// <param name="sourceType">変換前の型を表す <see cref="System.Type"/>。</param>
        /// <returns>コンバーターが変換を実行できる場合は true。それ以外の場合は false。</returns>
        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) => sourceType == typeof(string);

        /// <summary>
        /// 指定したコンテキストとカルチャ情報を使用して、指定したオブジェクトをコンバーターの型に変換します。
        /// </summary>
        /// <param name="context">書式指定コンテキストを提供する <see cref="System.ComponentModel.ITypeDescriptorContext"/>。</param>
        /// <param name="culture">現在のカルチャとして使用する <see cref="System.Globalization.CultureInfo"/>。</param>
        /// <param name="value">変換対象の <see cref="System.Object"/>。</param>
        /// <returns>変換後の値を表す <see cref="System.Object"/>。</returns>
        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
        {
            string source = value as string;
            var uniform = Regex.Match(source, UniformLengthPattern);
            var indivisual = Regex.Match(source, IndivisualLengthPattern);

            if (indivisual.Success)
            {
                return new DwmCompositionOption(ToDouble(indivisual.Groups[1].Value),
                                                ToDouble(indivisual.Groups[2].Value),
                                                ToDouble(indivisual.Groups[3].Value),
                                                ToDouble(indivisual.Groups[4].Value),
                                                ToColor(indivisual.Groups[5].Value));
            }
            else if (uniform.Success)
            {
                return new DwmCompositionOption(ToDouble(uniform.Groups[1].Value), ToColor(uniform.Groups[2].Value));
            }
            else
            {
                return null;
            }
        }
    }
}
