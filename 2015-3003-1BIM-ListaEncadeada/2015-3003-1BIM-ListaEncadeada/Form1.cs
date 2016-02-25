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

		private void AdicionarElementoXPos(object sender, EventArgs e)
		{
			Elemento elemento = new Elemento(lista.Count, lista.BuscaX(Convert.ToInt32(numeric1.Value)));
			Elemento prev = lista.BuscaX((Convert.ToInt32(numeric1.Value)) - 1);
			prev.Proximo = null;
			lista.Adiciona(elemento);
		}

		private void AdicionarElementoAposXValor(object sender, EventArgs e)
		{
			Elemento elemento = new Elemento(lista.Count, (lista.BuscaByValor(Convert.ToInt32(numeric2.Value))).Proximo);
			lista.BuscaByValor(Convert.ToInt32(numeric2.Value)).Proximo = null;
			lista.Adiciona(elemento);

		}

		private void TrocarPosXPosY(object sender, EventArgs e)
		{
			Elemento x = lista.BuscaX(Convert.ToInt32(numeric3.Value));
			Elemento y = lista.BuscaX(Convert.ToInt32(numeric4.Value));

			if (Convert.ToInt32(numeric4.Value)/* AKA Y */ > Convert.ToInt32(numeric3.Value)/* AKA X */)
			{
				if (x.Proximo != y)
				{
					Elemento newProx = x.Proximo;
					Elemento prev = lista.BuscaX((Convert.ToInt32(numeric4.Value)) - 1);
					lista.BuscaX((Convert.ToInt32(numeric3.Value)) - 1).Proximo = y;
					x.Proximo = y.Proximo;
					y.Proximo = newProx;
					prev.Proximo = x;
				}
				else 
				{
					Elemento prev = lista.BuscaX((Convert.ToInt32(numeric3.Value)) - 1).Proximo = y;
					x.Proximo = y.Proximo;
					y.Proximo = x;
				}
								
			}
			if (Convert.ToInt32(numeric3.Value) > Convert.ToInt32(numeric4.Value))
			{
				if (y.Proximo != x)
				{
					Elemento newProx = y.Proximo;
					Elemento prev = lista.BuscaX((Convert.ToInt32(numeric3.Value)) - 1);
					lista.BuscaX((Convert.ToInt32(numeric4.Value)) - 1).Proximo = x;
					y.Proximo = x.Proximo;
					x.Proximo = newProx;
					prev.Proximo = y;
				}
				else
				{
					Elemento prev = lista.BuscaX((Convert.ToInt32(numeric4.Value)) - 1).Proximo = x;
					y.Proximo = x.Proximo;
					x.Proximo = y;
				}
				
			}

		}

		private void RemoverElemento(object sender, EventArgs e)
		{
			if (posicaoRadio.Checked)
			{
				Elemento x = lista.BuscaX(Convert.ToInt32(numeric5.Value));
				lista.BuscaX((Convert.ToInt32(numeric5.Value)) - 1).Proximo = x.Proximo;
			}
			else if (valorRadio.Checked)
			{
				Elemento x = lista.BuscaByValor(Convert.ToInt32(numeric5.Value));
				lista.BuscaX(lista.getPos(x) - 1).Proximo = x.Proximo;
			}
		}
    }
}
