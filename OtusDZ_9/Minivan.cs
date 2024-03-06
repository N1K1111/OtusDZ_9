using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtusDZ_9
{
    internal class Minivan : Car
    {
        public Minivan(Minivan mini) : base(mini)
        {
        }

        public Minivan()
        {
        }

        public override void Move()
        {
            Console.WriteLine("Едем на минивэне");
        }
        public new Minivan Clone() => new Minivan(this);
    }
}
