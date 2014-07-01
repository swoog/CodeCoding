using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeCoding
{
    public interface IDSForce : IForce
    {
        void Lightning(params Jedi [] jedi);
    }
}
