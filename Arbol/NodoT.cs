using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arbol
{
    class NodoT
    {
        public NodoT NodoIzquierdo;
        public int Informacion;
        public NodoT NodoDerecho;
        //Constructor
        public NodoT()
        {
            this.NodoIzquierdo = null;
            this.Informacion = 0;
            this.NodoDerecho = null;
        }
    }
}
