namespace RectangleEntities
{
    public abstract class Rectangle
    {
        public Rectangle(double length , double width)
        {
            Length  = length ;
            Width = width;
        }

        public double  Length  { get; set; }
        public double Width {get; set; }

        public double CalculatePerimeter() =>  Length *2 + Width*2;

        public double CalculateArea() => Length *Width;

    }
}