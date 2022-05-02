using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Room
    {
        public Room(int seats)
        {
            Seats = seats;
            seatsInUse = 0;
            
        }
        private int seatsInUse = 0;
        public int Seats { get; set; }
        
        public void ReseveSeat(){
            seatsInUse++;
            if(seatsInUse >=Seats){
                OnRonmSoldOut(EventArgs.Empty);
            }else{
                Console.WriteLine("Assento Reservado");
            }
        }
        public event EventHandler RoomSoldOut;// cria um evento
        protected virtual void OnRonmSoldOut(EventArgs e)//monta uma estrutura para o evento
        {   
            EventHandler handler = RoomSoldOut;
            handler?.Invoke(this, e);
        }
    }
}