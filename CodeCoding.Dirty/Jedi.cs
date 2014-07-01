using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeCoding
{
    public class Jedi
    {
        private Saber saber;

        public string FirstName { get; set; }

        public string Name { get; set; }

        public Saber Saber
        {
            get { return this.saber; }
            set
            {
                this.saber = value;
                this.saber.JediOwner = this;
            }
        }

        public string Full
        {
            get
            {
                return string.Format("{0} {1}", this.FirstName, this.Name);
            }
        }

        public void Kill(Jedi jedi)
        {
            Console.WriteLine("{0} kill {1}", this.Full, jedi.Full);
        }
    }
}
