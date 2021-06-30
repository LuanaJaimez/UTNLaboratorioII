using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public interface IDeserializar
    {
        bool Xml(string path, out DepositoHeredado d);
    }
}
