using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var room = new Room(3);
            room.RoomSoldOut += OnRonmSoldOut; // delegação do evento
            room.ReseveSeat();
            room.ReseveSeat();
            room.ReseveSeat();
            room.ReseveSeat();
        }
        static void OnRonmSoldOut(object ob, EventArgs e ){
            Console.WriteLine("Sala lotada!");
        }
    }
}