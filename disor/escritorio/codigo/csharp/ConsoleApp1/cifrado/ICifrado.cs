using System;
using System.Collections.Generic;
using System.Text;

namespace Cifrado
{

    interface ICifrado<T>
    {
        Boolean Equals(T objeto);
    }
}
