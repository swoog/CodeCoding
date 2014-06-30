using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeCoding
{
    public class Jedi
    {
        private LightSaber lightSaber;

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public LightSaber LightSaber
        {
            get { return this.lightSaber; }
            set
            {
                this.lightSaber = value;
                this.lightSaber.JediOwner = this;
            }
        }

        public string FullName
        {
            get
            {
                return string.Format("{0} {1}", this.FirstName, this.LastName);
            }
        }

        public void Kill(Jedi jedi)
        {
            Console.WriteLine("{0} kill {1}", this.FullName, jedi.FullName);
        }
    }
}
