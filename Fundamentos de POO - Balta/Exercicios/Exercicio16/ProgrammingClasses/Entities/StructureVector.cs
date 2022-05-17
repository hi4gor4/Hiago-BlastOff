namespace ProgrammingClassEntities
{
    public class StrutureVector
    {
        public StrutureVector(uint sizeVector)
        {
            Vector = new float[sizeVector];
            
            CounterVector = 0;
            SizeVector = sizeVector;
            
        }

        private float[] Vector { get; set; }
        public int CounterVector { get; set; }
        public uint SizeVector { get; set; }
 
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

        public int IntValue(uint index)
        {
            if(index < SizeVector && index >= 0)
            {
                return (int)Math.Ceiling(Vector[index]); 
            }
            throw new IndexOutOfRangeException();
        }

        public void Multiply(int value)
        {
            for(int i=0; i<SizeVector; i++){
                Vector[i]= Vector[i]* value;
            }
        }

    }
}