namespace Lantmäteriet.kartor.downloader
{
    public class BBox
    {
        private readonly double _dx;
        private readonly double _dy;

        public BBox(double x1, double y1, double x2, double y2)
        {
            X1 = x1;
            Y1 = y1;
            X2 = x2;
            Y2 = y2;
            _dx = X2 - X1;
            _dy = Y2 - Y1;
        }

        public double X1 { get; }
        public double Y1 { get; }
        public double X2 { get; }
        public double Y2 { get; }

        public override string ToString()
        {
            return $"{X1},{Y1},{X2},{Y2}";
        }

        public BBox Left(int steps)
        {
            return new BBox(X1 - _dx*steps, Y1, X2 - _dx*steps, Y2);
        }

        public BBox Right(int steps)
        {
            return new BBox(X1 + _dx*steps, Y1, X2 + _dx*steps, Y2);
        }

        public BBox Up(int steps)
        {
            return new BBox(X1, Y1 - _dy*steps, X2, Y2 - _dy*steps);
        }

        public BBox Down(int steps)
        {
            return new BBox(X1, Y1 + _dy*steps, X2, Y2 + _dy*steps);
        }
    }
}