using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtusDZ_9
{
    internal class Transport : IMyCloneable<Transport>
    {
        public string Model { get; set; }
        public int MaxSpeed { get; set; }
        public Transport() { }
        public Transport(Transport ts)
        {
            this.Model = ts.Model;
            this.MaxSpeed = ts.MaxSpeed;
        }
        public Transport Clone() => new Transport(this);
        public virtual void Move() { }
    }
}
