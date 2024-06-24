using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_tutorial_d2
{
    internal class Room
    {
        private string code;
        public string Code { 
            get { return code; }
            set { code = value; }
        }
        private int seats;
        public int Seats { 
            get { return seats; }
            set { seats = value; }
        }
        public Room() { }
        public Room(string code,int seats)
        {
            this.code = code;
            this.seats = seats;
        }
        public void occupy() 
        {
            if (this.seats > 0)
            {
                Console.WriteLine("Room occupied!");
            }
            else
            {
                Console.WriteLine("No seats available!");
            }
        }
        public void vacate()
        {
            if (this.seats <= 0)
            {
                Console.WriteLine("Room vacated!");
            }
            else
            {
                Console.WriteLine("Room is already empty!");
            }
        }
    }
}
