namespace Geometry
{
    public class Square : IQuadratic
    {
        private int side;

        public Square(int side)
        {
            this.side = side;
        }

        public int GetSide()
        {
            return this.side;
        }

        public override string ToString()
        {
            return $"Square({this.side})";
        }
    }
}