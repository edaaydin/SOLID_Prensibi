namespace _02_OCP.Good
{
    public class Rectangle : Square
    {
        public double Height { get; set; }

        public Rectangle(double width, double height) : base(width)
        {
            Height = height;
        }

        public Rectangle(double width) : base(width)
        {

        }

        public override double Area()
        {
            return Width * Height;
        }


    }
}
