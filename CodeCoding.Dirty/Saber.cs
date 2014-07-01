using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeCoding
{
    public class Saber
    {
        private System.Drawing.Color color;

        public Saber(System.Drawing.Color color)
        {
            this.color = color;
        }

        public Jedi JediOwner { get; set; }

        public void Severing(Jedi jedi)
        {
            Console.WriteLine("{0} severing hand of {1}", this.JediOwner.Full, jedi.Full);
        }
    }
}
