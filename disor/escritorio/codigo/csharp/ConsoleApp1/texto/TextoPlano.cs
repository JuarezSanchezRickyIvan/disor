using System;
using System.Collections.Generic;
using System.Text;

namespace Cifrado.texto
{
    class TextoPlano : ITexto<TextoPlano>
    {
        CharEnumerator contenido;

        public TextoPlano(String texto)
        {
            contenido = texto.GetEnumerator();
        }



        public bool Equals(TextoPlano texto)
        {
            throw new NotImplementedException();
        }
    }
}
