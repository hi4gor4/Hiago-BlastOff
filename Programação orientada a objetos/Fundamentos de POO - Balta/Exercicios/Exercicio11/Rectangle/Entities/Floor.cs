
namespace RectangleEntities
{
    public class Floor : Rectangle
    {
        public Floor(double comprimento, double largura) : base(comprimento, largura)
        {
        }
        public double CalculateTilesNumber(Rectangle tile)
        {
            return Math.Ceiling( this.CalculateArea()/ tile.CalculateArea());
        } 

        public double CalculateBaseboard(Rectangle tile)
        {
            return Math.Ceiling(this.CalculatePerimeter()/ tile.Length) ;
        }

    }
}