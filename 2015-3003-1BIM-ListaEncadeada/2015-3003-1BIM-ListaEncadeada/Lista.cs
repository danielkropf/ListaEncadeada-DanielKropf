using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace _2015_3003_1BIM_ListaEncadeada
{
    class Lista
    {
        private Elemento primeiro;
        public Elemento Primeiro
        {
            get
            {
                return primeiro;
            }
            set
            {
                primeiro = value;
            }
        }

        public Elemento Ultimo
        {
            get
            {
                return BuscaUltimo();
            }
        }

        public Lista()
        {
            
        }

        public void Adiciona(Elemento e)
        {
            if (Primeiro == null)
            {
                Primeiro = e;
            }
            else
            {
                Ultimo.Proximo = e;
            }
        }

        public int Count
        {
            get {
                int count = 0;
                Elemento current = Primeiro;
                while (current != null)
                {
                    current = current.Proximo;
                    count++;
                }
                return count;
            }
        }

        public void ImprimeLista(System.Windows.Forms.ListBox x)
        {
            Elemento current = Primeiro;
			x.Items.Clear();
            while (current != null)
            {
                x.Items.Add("[" + this.getPos(current) + "]: " + current.AsString);
                current = current.Proximo;
            } 
        }

        public Elemento BuscaUltimo()
        {
            Elemento current = Primeiro;
            while (current.Proximo != null)
            {
                current = current.Proximo;
            }
            return current;
        }

        public Elemento BuscaX(int x) 
        {
            Elemento current = Primeiro;
            int count = 0;
            while (count < x)
            {
                current = current.Proximo;
                count++;
            }
            return current;
        }

        public Elemento BuscaByValor(int x)
        {
            Elemento current = Primeiro;
            while (current.Valor != x)
            {
                current = current.Proximo;
            }
            return current;
        }

		public int getPos(Elemento x)
		{
			Elemento current = Primeiro;
			int count = 0;
			while (current != x)
			{
				current = current.Proximo;
				count++;
			}
			return count;
		}
    }
}
