using System.Runtime.InteropServices;
using System.Windows;

namespace Chipmunk.Win32
{
    /// <summary>
    /// <see cref="Chipmunk.Win32.POINT"/> 構造体は点の x 座標と y 座標を定義します。
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    internal struct POINT
    {
        /// <summary>
        /// 点の x 座標を取得または設定します。
        /// </summary>
        public int X { get; set; }
        /// <summary>
        /// 点の y 座標を取得または設定します。
        /// </summary>
        public int Y { get; set; }

        /// <summary>
        /// 指定した座標を含む新しい <see cref="Chipmunk.Win32.POINT"/> 構造体を作成します。
        /// </summary>
        /// <param name="x">新しい <see cref="Chipmunk.Win32.POINT"/> 構造体の x 座標。</param>
        /// <param name="y">新しい <see cref="Chipmunk.Win32.POINT"/> 構造体の y 座標。</param>
        public POINT(int x, int y)
            : this()
        {
            this.X = x;
            this.Y = y;
        }
    }

    /// <summary>
    /// <see cref="System.Windows.Point"/> と <see cref="Chipmunk.Win32.POINT"/> を相互変換する static (Visual Basic では Shared) メソッドを提供します。
    /// </summary>
    internal static class POINTExtensions
    {
        /// <summary>
        /// <see cref="System.Windows.Point"/> から <see cref="Chipmunk.Win32.POINT"/> を作成します。
        /// </summary>
        /// <param name="point">作成元の <see cref="System.Windows.Point"/></param>
        /// <returns>作成された <see cref="Chipmunk.Win32.POINT"/></returns>
        public static POINT ToPOINT(this Point point) => new POINT((int)point.X, (int)point.Y);

        /// <summary>
        /// <see cref="Chipmunk.Win32.POINT"/> から <see cref="System.Windows.Point"/> を作成します。
        /// </summary>
        /// <param name="point">作成元の <see cref="Chipmunk.Win32.POINT"/></param>
        /// <returns>作成された <see cref="System.Windows.Point"/></returns>
        public static Point ToPoint(this POINT point) => new Point(point.X, point.Y);
    }
}
