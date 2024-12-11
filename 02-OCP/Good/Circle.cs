namespace _02_OCP.Good
{
    public class Circle : Shape
    {
        public int Radius { get; set; }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
