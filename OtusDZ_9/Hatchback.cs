using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtusDZ_9
{
    internal class Hatchback : Car, ICloneable
    {
        public Hatchback(Hatchback hatch) : base(hatch)
        {
        }

        public Hatchback()
        {
        }

        public override void Move()
        {
            Console.WriteLine("Едем на Hatcbakc'e");
        }
        //public new Hatchback Clone() => new Hatchback(this);

        object ICloneable.Clone()
        {
            return new Hatchback(this); 
            
        }
    }
}
