using System;
using System.Collections.Generic;
using System.Text;

namespace Cifrado.texto
{
    interface ITexto<T>
    {
        Boolean Equals(T texto);
    }
}
