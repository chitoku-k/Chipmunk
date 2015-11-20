using System.Runtime.InteropServices;
using System.Windows;

namespace Chipmunk.Win32
{
    /// <summary>
    /// 四角形の枠の太さを示します。4 つの <see cref="System.Int32"/> 値は、それぞれ四角形の 4 つの辺を示します。
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    internal struct MARGINS
    {
        /// <summary>
        /// 外接する四角形の左辺の幅を取得または設定します。
        /// </summary>
        public int Left { get; set; }
        /// <summary>
        /// 外接する四角形の右辺の幅を取得または設定します。
        /// </summary>
        public int Right { get; set; }
        /// <summary>
        /// 外接する四角形の上辺の幅を取得または設定します。
        /// </summary>
        public int Top { get; set; }
        /// <summary>
        /// 外接する四角形の底辺の幅を取得または設定します。
        /// </summary>
        public int Bottom { get; set; }

        /// <summary>
        /// 各辺に均一な長さを指定して <see cref="Chipmunk.Win32.MARGINS"/> 構造体の新しいインスタンスを初期化します。
        /// </summary>
        /// <param name="uniformLength">外接する四角形の 4 つの辺すべてに均一に適用される長さ。</param>
        public MARGINS(int uniformLength)
            : this()
        {
            this.Left = this.Top = this.Right = this.Bottom = uniformLength;
        }

        /// <summary>
        /// 各辺に対して特定の長さ (<see cref="System.Int32"/> として指定) が適用される、<see cref="Chipmunk.Win32.MARGINS"/> 構造体の新しいインスタンスを初期化します。
        /// </summary>
        /// <param name="left">四角形の左辺の太さ。</param>
        /// <param name="top">四角形の上辺の太さ。</param>
        /// <param name="right">四角形の右辺の太さ。</param>
        /// <param name="bottom">四角形の底辺の太さ。</param>
        public MARGINS(int left, int top, int right, int bottom)
            : this()
        {
            this.Left = left;
            this.Top = top;
            this.Right = right;
            this.Bottom = bottom;
        }

        /// <summary>
        /// この <see cref="Chipmunk.Win32.MARGINS"/> 構造体のすべての辺が指定した <see cref="System.Int32"/> の値と等しいかどうかを確認します。
        /// </summary>
        /// <param name="value"></param>
        /// <returns>等しい場合は true。それ以外の場合は false。</returns>
        public bool Equals(int value) => this.Left == this.Top && this.Top == this.Right && this.Right == this.Bottom && this.Bottom == value;
    }

    /// <summary>
    /// <see cref="System.Windows.Thickness"/> と <see cref="Chipmunk.Win32.MARGINS"/> を相互変換する static (Visual Basic では Shared) メソッドを提供します。
    /// </summary>
    internal static class ThicknessExtensions
    {
        /// <summary>
        /// <see cref="System.Windows.Thickness"/> から <see cref="Chipmunk.Win32.MARGINS"/> を作成します。
        /// </summary>
        /// <param name="thickness">作成元の <see cref="System.Windows.Thickness"/></param>
        /// <returns>作成された <see cref="Chipmunk.Win32.MARGINS"/></returns>
        public static MARGINS ToMARGINS(this Thickness thickness) => new MARGINS((int)thickness.Left, (int)thickness.Top, (int)thickness.Right, (int)thickness.Bottom);

        /// <summary>
        /// <see cref="Chipmunk.Win32.MARGINS"/> から <see cref="System.Windows.Thickness"/> を作成します。
        /// </summary>
        /// <param name="margins">作成元の <see cref="Chipmunk.Win32.MARGINS"/></param>
        /// <returns>作成された <see cref="System.Windows.Thickness"/></returns>
        public static Thickness ToThickness(this MARGINS margins) => new Thickness(margins.Left, margins.Top, margins.Right, margins.Bottom);
    }
}
