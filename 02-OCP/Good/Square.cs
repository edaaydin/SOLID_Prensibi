namespace _02_OCP.Good
{
    public class Square : Shape
    {
        public double Width { get; set; }
        public Square(double width)
        {
            Width = width;

        }
        public override double Area()
        {
            throw new NotImplementedException();
        }
    }
}
