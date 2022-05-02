using OutherSpaceEnum;
namespace OuterSpaceEntities
{
    public class CelestialBody
    {
        public CelestialBody(ECelestialBodyType type, double mass, double size)
        {
            Type = type;
            Mass = mass;
            this.size = size;
        }

        public ECelestialBodyType Type { get; set; }
        public double Mass { get; set; }

        public double size { get; set; }

        
    

    }
}