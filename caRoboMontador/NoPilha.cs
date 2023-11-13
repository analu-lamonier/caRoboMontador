using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão_02
{
    internal class NohPilha
    {
        private string codigo;
        private NohPilha anterior;

        public NohPilha()
        {
            this.Anterior = null;
        }
        public NohPilha(string codigo)
        {
            this.Codigo = codigo;
            this.Anterior = null;
        }

        public NohPilha(string codigo, NohPilha anterior)
        {
            this.Codigo = codigo;
            this.Anterior = anterior;
        }

        public string Codigo { get => codigo; set => codigo = value; }
        internal NohPilha Anterior { get => anterior; set => anterior = value; }
    }
}
