namespace ProgrammingClassEntities
{
    public class StrutureMatrix
    {
        public StrutureMatrix(int sizeLine, int sizeColumn)
        {
            Matrix = new int[sizeLine,sizeColumn];
            SizeLine =  sizeLine;
            SizeColumn = sizeColumn;

        }

        public  int[,] Matrix { get; set; }
        private  int SizeLine { get; set; }
        private int SizeColumn {get; set;}

        public void Populates(){
            Random randomNumber = new Random();  
            for(int countLine = 0; countLine <SizeLine; countLine ++)
            {
                for(int countColumn = 0; countColumn < SizeColumn; countColumn ++)
                {
                    Matrix[countLine, countColumn] = randomNumber.Next(0,51);
                }
            }
        }
        
        public int TotalValue()
        {
            int sum = 0;
             for(int countLine = 0; countLine <=SizeLine; countLine ++)
            {
                for(int countColumn = 0; countColumn <= SizeColumn; countColumn ++)
                {
                    sum += Matrix[countLine, countColumn];
                }
            }
            return sum;
        }

        public int Average() => TotalValue()/ (SizeLine/SizeColumn);

        public int MinValue(){
            int min = 50;
             for(int countLine = 0; countLine <SizeLine; countLine ++)
            {
                for(int countColumn = 0; countColumn < SizeColumn; countColumn ++)
                {
                    if(Matrix[countLine, countColumn] < min)
                    {
                        min = Matrix[countLine, countColumn] ;
                    }
                }
            }
            return min;
        }
        public int MaxValue(){
            int max = 0;
             for(int countLine = 0; countLine <SizeLine; countLine ++)
            {
                for(int countColumn = 0; countColumn < SizeColumn; countColumn ++)
                {
                    if(Matrix[countLine, countColumn] > max)
                    {
                        max = Matrix[countLine, countColumn] ;
                    }
                }
            }
            return max;
        }
        public void Print()
        {
            for(int countLine = 0; countLine <SizeLine; countLine ++)
            {
                for(int countColumn = 0; countColumn < SizeColumn; countColumn ++)
                {
                    Console.Write($"[{countLine},{countColumn}]");
                    Console.WriteLine(Matrix[countLine, countColumn]); 
                }
            }
        }


    }
}