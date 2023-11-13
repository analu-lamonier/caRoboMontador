using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão_02
{
    internal class Pilha
    {
        private NohPilha topo;
        private int slot;

        public Pilha()
        {
            Topo = null;
        }

        public Pilha(NohPilha topo)
        {
            this.Topo = topo;
        }

        internal NohPilha Topo { get => topo; set => topo = value; }
        public int Slot { get => slot; set => slot = value; }

        public bool estarVazia()
        {
            if (topo == null)
                return true;
            else
                return false;
        }

        public void inserir(string codigo)
        {
            if (estarVazia())
            {
                NohPilha novaPilha = new NohPilha(codigo);
                topo = novaPilha;
            }
            else
            {
                NohPilha novaPilha = new NohPilha(codigo, topo);
                topo = novaPilha;
            }
        }

        public string remover()
        {
            if (estarVazia())
                return "Esta vazia";
            else
            {
                string temp = topo.ToString();
                topo = topo.Anterior;
                return temp;
            }
        }

        public int quantNaPilha()
        {
            int n = 0;
            NohPilha temp = topo;
            while (temp != null)
            {
                temp = temp.Anterior;
                n++;
            }
            return n;
        }

        public bool estaCheia()
        {
            if (quantNaPilha() >= 3)
                return true;
            else
                return false;
        }

        public bool codigoExiste(string codigo)
        {
            NohPilha temp = topo;
            while (temp != null)
            {
                if (temp.Codigo.Equals(codigo))
                    return true;
                else
                    temp = temp.Anterior;
            }

            return false;
        }
     


    }
}

