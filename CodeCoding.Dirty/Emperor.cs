using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeCoding
{
    public class Emperor : Jedi, IDSForce
    {
        public Emperor()
        {
            this.FirstName = "Sith";
            this.Name = "Emperor";
        }

        public void Lightning(params Jedi[] jedi)
        {
            Console.WriteLine("Sith emperor use force lightning on {0}", string.Join(" and ", jedi.Select(j => j.Full)));
        }
    }
}
