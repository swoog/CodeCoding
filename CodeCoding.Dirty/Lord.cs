using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeCoding
{
    public class Lord : Jedi, IDSForce
    {
        public Lord()
        {
            this.FirstName = "Dark";
            this.Name = "Vador";
        }

        public void Lightning(params Jedi[] jedi)
        {
            Console.WriteLine("Dark Vador use force lightning on {0}", string.Join(" and ", jedi.Select(j => j.Full)));
        }

        public Jedi To(string name, string firstName)
        {
            Console.WriteLine("{0} {1} reemerges", firstName, name);

            return new Jedi { Name = name, FirstName = firstName };
        }

    }
}
