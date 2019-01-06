using projeto03.Entities.Enums;

namespace projeto03.Entities
{
    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle (double width, double heigth, Color color) : base(color)
        {

            Width = width;
            Height = heigth;
        }


        public override double Area()
        {
            return Width * Height;
        }
    }
}
