namespace _02_OCP.Bad
{
    public class Shape
    {
        public string Type { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }

        public int Radius { get; set; }

        public double Area()
        {
            if (Type == "Dikdortgen")
                return Width * Height;

            else if (Type == "Kare")
                return Math.Pow(Width, 2);
            else if (Type == "Daire")
                return Math.PI * Radius * Radius;

            return 0;
        }

    }
}
