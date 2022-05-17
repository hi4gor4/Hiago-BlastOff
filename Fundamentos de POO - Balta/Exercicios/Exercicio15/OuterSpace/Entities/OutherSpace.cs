using OutherSpaceEnum;
namespace OuterSpaceEntities
{
    public class OutherSpace
    {
        public OutherSpace()
        {
            Celestials = new List<CelestialBody>();
        }
        public List<CelestialBody> Celestials { get; set; }
        
        public void AddBody(CelestialBody item) => Celestials.Add(item);

        public bool RemoveBody(int index){
            if(Celestials[index] != null){
                Celestials.Remove(Celestials[index]);
                return true;
            }
            return false;
        }
        public int Count(ECelestialBodyType type)
        {
            int count = 0;
            foreach(CelestialBody celestial in Celestials)
            {
                if(celestial.Type == type)
                    count+=1;
            }
            return count;
        }

    }
}