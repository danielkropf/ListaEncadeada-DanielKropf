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
			int count = 0;
			Elemento current = Primeiro;
			while (count < x)
			{
				current = current.Proximo;
				count++;
			}
			return current;
		}

		public Elemento BuscaXValor(int x) 
		{
			bool positive = false;
			Elemento current = Primeiro;
			while (current.Proximo != null)
			{
				if (current.Valor == x) positive = true;
				current = current.Proximo;
			}
			if (positive)
			{
				while(current.Valor != x)
				{
					current = current.Proximo;
				}
			} else {
				current = null;
			}
			return current;
		}

        public int Count
        {
            get {
                int count = 1;
                Elemento current = Primeiro;
                while (current != null)
                {
                    current = current.Proximo;
                    count++;
                }
                return count;
            }
        }

        public void ImprimeLista()
        {
            Elemento current = Primeiro;
            while (current != null)
            {
                Debug.WriteLine(current.AsString);
                current = current.Proximo;
            } 
        }
    }
}
