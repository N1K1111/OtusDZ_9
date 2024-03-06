using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtusDZ_9
{
    internal class Car : Transport
    {
        Radio radio;
        public Car(Car ts) : base(ts)
        {
            radio = new Radio(); 
        }

        public Car()
        {
            radio = new Radio();
        }

        public override void Move()
        {
            Console.WriteLine("Едем на машине");
        }

        public void OnRadio(bool ds) 
        {
            if (ds == true) { radio.Play(); }
            else { radio.Stop(); }
        }


        public new Car Clone() => new Car(this);


    }
}
