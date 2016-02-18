using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2015_3003_1BIM_ListaEncadeada
{
    public partial class Form1 : Form
    {
        private Lista lista;

        public Form1()
        {
            InitializeComponent();
        }

        private void CarregarPrograma(object sender, EventArgs e)
        {
            lista = new Lista();
        }

        private void InicializarLista(object sender, EventArgs e)
        {
            Elemento elemento = new Elemento(lista.Count);
            lista.Adiciona(elemento);
        }

        private void ExibirLista(object sender, EventArgs e)
        {
            lista.ImprimeLista();
        }

		private void AdicionaElemento(object sender, EventArgs e)
		{
			Random r = new Random();
			//r.Next(1,100) + (2 * DateTime.Now.Second)
			Elemento elemento = new Elemento(lista.Count);
			lista.Adiciona(elemento);
		}

		private void AdicionarElementoXPosição(object sender, EventArgs e)
		{
			Elemento x = lista.BuscaX(Convert.ToInt32(NumericX.Value) - 1);
			Elemento elemento = new Elemento(lista.Count);

			elemento.Proximo = x.Proximo;
			x.Proximo = elemento;
		}

		private void RemoverElemento(object sender, EventArgs e)
		{
			Elemento x = lista.BuscaX(Convert.ToInt32(NumericY.Value) - 1);
			Elemento toRemove = x.Proximo;
			x.Proximo = toRemove.Proximo;
		}

		private void AdicionarElementoAposZValor(object sender, EventArgs e)
		{
			Elemento x = lista.BuscaXValor(Convert.ToInt32(NumericZ.Value) - 1);
			Elemento elemento = new Elemento(lista.Count);

			if (x != null) {
				elemento.Proximo = x.Proximo;
				x.Proximo = elemento.Proximo;
			}
		}

		private void TrocarElementosAB(object sender, EventArgs e)
		{
			Elemento a = lista.BuscaX(Convert.ToInt32(NumericA.Value));
			Elemento aProx = a.Proximo;
			Elemento aPrev = lista.BuscaX(Convert.ToInt32(NumericA.Value) - 1);
			Elemento b = lista.BuscaX(Convert.ToInt32(NumericB.Value));
			Elemento bProx = b.Proximo;
			Elemento bPrev = lista.BuscaX(Convert.ToInt32(NumericB.Value) - 1);

			if (NumericA.Value < NumericB.Value)
			{
				if (NumericA.Value - NumericB.Value == 1 || NumericB.Value - NumericA.Value == 1)
				{

					aPrev.Proximo = b;
					a.Proximo = b.Proximo;
					b.Proximo = a;

				}
				else
				{
					aPrev.Proximo = b;
					b.Proximo = aProx;
					bPrev.Proximo = a;
					a.Proximo = bProx;
				}
			}
			else if (NumericA.Value > NumericB.Value)
			{
				if (NumericB.Value - NumericA.Value == 1 || NumericA.Value - NumericB.Value == 1)
				{

					bPrev.Proximo = a;
					b.Proximo = a.Proximo;
					a.Proximo = b;

				}
				else
				{
					bPrev.Proximo = a;
					a.Proximo = bProx;
					aPrev.Proximo = b;
					b.Proximo = aProx;
				}
			}

		}
    }
}
