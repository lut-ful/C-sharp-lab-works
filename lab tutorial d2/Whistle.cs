using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_tutorial_d2
{
    internal class Whistle
    {
        private string sound;
        public string Sound
        {
            get { return sound; }
            set { sound = value; }
        }
        public Whistle() { }
        public Whistle(string sound)
        {
            this.sound = sound;
            
        }
        public void SoundWhistle()
        {
            Console.WriteLine(this.sound);
        }
        public void ChangeSound(string sound)
        {
            this.sound = sound;
        }
    }
}
