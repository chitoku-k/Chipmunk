using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace Chipmunk.Win32
{
    /// <summary>
    /// P/Invoke を利用してアンマネージ コードにアクセスする static (Visual Basic では Shared) メソッドを提供します。
    /// </summary>
    internal class NativeMethods
    {
        /// <summary>
        /// <para>指定されたウィンドウに関する情報を取得します。</para>
        /// <para>拡張ウィンドウメモリ内の指定されたオフセット位置にある long データ（32 ビット値）も取得できます。</para>
        /// </summary>
        /// <param name="hWnd">ウィンドウのハンドルを指定します。</param>
        /// <param name="nIndex">取得する値の 0 から始まるオフセットを指定します。</param>
        /// <returns>要求したデータ（32 ビット値）が返ります。</returns>
        [DllImport("user32.dll")]
        internal static extern WS GetWindowLong(IntPtr hWnd, GWL nIndex);

        /// <summary>
        /// <para>指定されたダイアログボックスに関する情報を取得します。</para>
        /// <para>拡張ウィンドウメモリ内の指定されたオフセット位置にある long データ（32 ビット値）も取得できます。</para>
        /// </summary>
        /// <param name="hWnd">ウィンドウのハンドルを指定します。</param>
        /// <param name="nIndex">取得する値の 0 から始まるオフセットを指定します。</param>
        /// <returns>要求したデータ（32 ビット値）が返ります。</returns>
        [DllImport("user32.dll")]
        internal static extern WS GetWindowLong(IntPtr hWnd, DWL nIndex);

        /// <summary>
        /// <para>指定されたウィンドウの属性を変更します。</para>
        /// <para>拡張ウィンドウメモリ内の指定されたオフセット位置にある long データ（32 ビット値）も設定できます。</para>
        /// </summary>
        /// <param name="hWnd">ウィンドウのハンドルを指定します。</param>
        /// <param name="nIndex">設定する値の 0 から始まるオフセットを指定します。</param>
        /// <param name="dwNewLong">新しく設定する値を指定します。</param>
        /// <returns>変更前の値が返ります。</returns>
        [DllImport("user32.dll")]
        internal static extern WS SetWindowLong(IntPtr hWnd, GWL nIndex, WS dwNewLong);

        /// <summary>
        /// <para>指定されたダイアログボックスの属性を変更します。</para>
        /// <para>拡張ウィンドウメモリ内の指定されたオフセット位置にある long データ（32 ビット値）も設定できます。</para>
        /// </summary>
        /// <param name="hWnd">ウィンドウのハンドルを指定します。</param>
        /// <param name="nIndex">設定する値の 0 から始まるオフセットを指定します。</param>
        /// <param name="dwNewLong">新しく設定する値を指定します。</param>
        /// <returns>変更前の値が返ります。</returns>
        [DllImport("user32.dll")]
        internal static extern WS SetWindowLong(IntPtr hWnd, DWL nIndex, WS dwNewLong);

        /// <summary>
        /// <para>子ウィンドウ、ポップアップウィンドウ、またはトップレベルウィンドウのサイズ、位置、および Z オーダーを変更します。</para>
        /// <para>これらのウィンドウは、その画面上での表示に従って順序が決められます。</para>
        /// <para>最前面にあるウィンドウは最も高いランクを与えられ、Z オーダーの先頭に置かれます。</para>
        /// </summary>
        /// <param name="hWnd">ウィンドウのハンドルを指定します。</param>
        /// <param name="hWndInsertAfter">Z オーダーを決めるためのウィンドウハンドルを指定します。</param>
        /// <param name="x">ウィンドウの左上端の新しい x 座標をクライアント座標で指定します。</param>
        /// <param name="y">ウィンドウの左上端の新しい y 座標をクライアント座標で指定します。</param>
        /// <param name="cx">ウィンドウの新しい幅をピクセル単位で指定します。</param>
        /// <param name="cy">ウィンドウの新しい高さをピクセル単位で指定します。</param>
        /// <param name="uFlags">ウィンドウのサイズと位置の変更に関するフラグを指定します。</param>
        [DllImport("user32.dll")]
        internal static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int x, int y, int cx, int cy, SWP uFlags);

        /// <summary>
        /// <para>1 つまたは複数のウィンドウへ、指定されたメッセージを送信します。</para>
        /// <para>この関数は、指定されたウィンドウのウィンドウプロシージャを呼び出し、そのウィンドウプロシージャがメッセージを処理し終わった後で、制御を返します。</para>
        /// </summary>
        /// <param name="hWnd">1 つのウィンドウのハンドルを指定します。このウィンドウのウィンドウプロシージャがメッセージを受信します。</param>
        /// <param name="Msg">送信するべきメッセージを指定します。</param>
        /// <param name="wParam">メッセージ特有の追加情報を指定します。</param>
        /// <param name="lParam">メッセージ特有の追加情報を指定します。</param>
        /// <returns>メッセージ処理の結果が返ります。この戻り値の意味は、送信されたメッセージにより異なります。</returns>
        [DllImport("user32.dll")]
        internal static extern IntPtr SendMessage(IntPtr hWnd, WM Msg, IntPtr wParam, IntPtr lParam);

        /// <summary>
        /// 指定されたウィンドウを作成したスレッドに関連付けられているメッセージキューに、1 つのメッセージをポストします（書き込みます）。
        /// </summary>
        /// <param name="hWnd">1 つのウィンドウのハンドルを指定します。このウィンドウのウィンドウプロシージャは、ポストされたメッセージを受信します。</param>
        /// <param name="Msg">ポストするべきメッセージを指定します。</param>
        /// <param name="wParam">メッセージ特有の追加情報を指定します。</param>
        /// <param name="lParam">メッセージ特有の追加情報を指定します。</param>
        [DllImport("user32.dll", PreserveSig = false)]
        internal static extern void PostMessage(IntPtr hWnd, WM Msg, IntPtr wParam, IntPtr lParam);

        /// <summary>
        /// <para>既定のウィンドウプロシージャを呼び出して、アプリケーションが処理しないウィンドウメッセージに対して、既定の処理を提供します。</para>
        /// <para>この関数は、すべてのメッセージが処理されることを保証します。</para>
        /// <para>DefWindowProc 関数には、既定のウィンドウプロシージャが受け取るのと同じパラメータが渡されます。</para>
        /// </summary>
        /// <param name="hWnd">メッセージを受信したウィンドウプロシージャのハンドルを指定します。</param>
        /// <param name="Msg">メッセージを指定します。</param>
        /// <param name="wParam">メッセージの追加情報を指定します。このパラメータの意味は、<paramref name="Msg"/> パラメータの値によって異なります。</param>
        /// <param name="lParam">メッセージの追加情報を指定します。このパラメータの意味は <paramref name="Msg"/> パラメータの値によってり異なります。</param>
        /// <returns>メッセージ処理の結果が返ります。戻り値の意味は、メッセージによって異なります。</returns>
        [DllImport("user32.dll")]
        internal static extern IntPtr DefWindowProc(IntPtr hWnd, WM Msg, IntPtr wParam, IntPtr lParam);

        /// <summary>
        /// <para>ウィンドウメニュー（システムメニューまたはコントロールメニューとも呼ばれる）のハンドルを取得します。</para>
        /// <para>このハンドルはコピーであり、ウィンドウメニューの変更に利用できます。ウィンドウメニューを既定の状態へ戻すこともできます</para>
        /// </summary>
        /// <param name="hWnd">ウィンドウメニューを保持しているウィンドウのハンドルを指定します。</param>
        /// <param name="bRevert">
        /// <para>関数の動作を指定します。</para>
        /// <para>false を指定すると、この関数は、現在使用中のウィンドウメニューをコピーして、コピー先のメニューハンドルを返します。</para>
        /// <para>返されたメニューハンドルは、指定されたウィンドウのウィンドウメニューと同じものですが、その後、変更を加えることができます。</para>
        /// <para>true を指定すると、この関数は、ウィンドウメニューをリセットして Windows の既定の状態へ戻します。</para>
        /// <para>つまり、ウィンドウメニューがカスタマイズされていた場合、カスタマイズを取り消します。</para>
        /// <para>以前の（カスタマイズ済みの）ウィンドウメニューが存在する場合、そのウィンドウメニューを破棄します。</para>
        /// </param>
        /// <returns>bRevert パラメータが false の場合、ウィンドウメニューが内部でコピーされ、コピー先のメニューハンドルが返ります。<paramref name="bRevert"/> パラメータが true の場合、null が返ります。</returns>
        [DllImport("user32.dll")]
        internal static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);

        /// <summary>
        /// 指定されたメニュー項目を有効化、無効化、または淡色表示にします。
        /// </summary>
        /// <param name="hMenu">メニューのハンドルを指定します。</param>
        /// <param name="uIDEnableItem">
        /// <para><paramref name="uEnable"/> パラメータの指定に従って、有効化、無効化、淡色表示のいずれかを行うべきメニュー項目を指定します。</para>
        /// <para><paramref name="uIDEnableItem"/> パラメータは、メニューバー、メニュー、サブメニューいずれかの中の項目を指定します。</para>
        /// </param>
        /// <param name="uEnable">
        /// <para><paramref name="uIDEnableItem"/> パラメータの意味と、メニュー項目の新しい状態として、有効、無効、淡色表示のいずれかを指定します。</para>
        /// <para><paramref name="uEnable"/> パラメータでは、MF_BYCOMMAND、MF_BYPOSITION のいずれかと、MF_ENABLED、MF_DISABLED、MF_GRAYED のいずれかを組み合わせたものを指定します。</para>
        /// </param>
        /// <returns>メニュー項目の以前の状態を表す値（MF_DISABLED、MF_ENABLED、MF_GRAYED のいずれか）が返ります。指定されたメニュー項目が存在しない場合は、-1 が返ります。</returns>
        [DllImport("user32.dll")]
        internal static extern MF EnableMenuItem(IntPtr hMenu, SC uIDEnableItem, MF uEnable);

        [DllImport("user32.dll")]
        private static extern bool GetCursorPos(out POINT lpPoint);

        /// <summary>
        /// マウスカーソル（マウスポインタ）の現在の位置に相当するスクリーン座標を取得します。
        /// </summary>
        /// <returns>マウスカーソルの位置に相当するスクリーン座標が返ります。</returns>
        internal static POINT GetCursorPos()
        {
            POINT p;
            GetCursorPos(out p);
            return p;
        }

        /// <summary>
        /// <para>Obtains a value that indicates whether Desktop Window Manager (DWM) composition is enabled.</para>
        /// <para>Applications on machines running Windows 7 or earlier can listen for composition state changes by handling the <see cref="WM.DWMCOMPOSITIONCHANGED"/> notification.</para>
        /// </summary>
        /// <returns></returns>
        [DllImport("dwmapi.dll", PreserveSig = false)]
        internal static extern bool DwmIsCompositionEnabled();

        /// <summary>
        /// Extends the window frame into the client area.
        /// </summary>
        /// <param name="hWnd">The handle to the window in which the frame will be extended into the client area.</param>
        /// <param name="pMarInset">A <see cref="MARGINS"/> structure that describes the margins to use when extending the frame into the client area.</param>
        [DllImport("dwmapi.dll", PreserveSig = false)]
        internal static extern void DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS pMarInset);
    }
}
