using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtusDZ_9
{
    internal class Motocycle : Transport
    {
        public Motocycle(Motocycle moto) : base(moto)
        {
        }
        public override void Move()
        {
            Console.WriteLine("Едем на Мотоцикле");
        }


        public new Motocycle Clone() => new Motocycle(this);
    }
}
