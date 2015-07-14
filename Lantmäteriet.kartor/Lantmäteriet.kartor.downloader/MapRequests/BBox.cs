using System;

namespace Lantmäteriet.kartor.downloader
{
    public class BBox
    {
        public BBox(int left, int bottom, int right, int Top)
        {
            Left = left;
            Bottom = bottom;
            Right = right;
            this.Top = Top;
        }

        public int Left { get; }
        public int Bottom { get; }
        public int Right { get; }
        public int Top { get; }
        public int Width => Math.Abs(Right - Left);
        public int Height => Math.Abs(Top - Bottom);
        public double Ratio => (double)Width/Height;

        public override string ToString()
        {
            return $"{Left},{Bottom},{Right},{Top}";
        }

        public BBox GetBoxLeft(int steps = 1)
        {
            return new BBox(Left - Width*steps, Bottom, Right - Width*steps, Top);
        }

        public BBox GetBoxRight(int steps = 1)
        {
            return new BBox(Left + Width*steps, Bottom, Right + Width*steps, Top);
        }

        public BBox GetBoxOver(int steps = 1)
        {
            return new BBox(Left, Bottom + Height*steps, Right, Top + Height*steps);
        }

        public BBox GetBoxUnder(int steps = 1)
        {
            return new BBox(Left, Bottom - Height*steps, Right, Top - Height*steps);
        }
    }
}