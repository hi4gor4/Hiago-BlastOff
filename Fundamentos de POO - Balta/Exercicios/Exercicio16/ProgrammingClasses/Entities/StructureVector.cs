namespace ProgrammingClassEntities
{
    public class StrutureVector
    {
        public StrutureVector(int sizeVector)
        {
            Vector = new float[sizeVector];
            
            CounterVector = 0;
            SizeVector = sizeVector;
            
        }

        private float[] Vector { get; set; }
        public int CounterVector { get; set; }
        public int SizeVector { get; set; }
 
        public bool AddValue(float value)
        {
            if(this.CounterVector < this.SizeVector)
            {
                Vector[CounterVector] = value;
                CounterVector +=1;
                return true;
            }
            return false;
        }

        public int IntValue(int index)
        {
            if(index < SizeVector && index >= 0)
            {
                return (int)Math.Ceiling(Vector[index]); 
            }
            throw new IndexOutOfRangeException();
        }

    }
}