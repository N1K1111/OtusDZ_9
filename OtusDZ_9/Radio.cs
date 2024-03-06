using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtusDZ_9
{
    internal class Radio
    {
        public bool Power { get; private set; } = false;
        public void Play() 
        { 
            Power = true;
            Console.WriteLine("Радио Включено");
        }
        public void Stop() 
        { 
            Power = false;
            Console.WriteLine("Радио выключено");
        }
    }
}
