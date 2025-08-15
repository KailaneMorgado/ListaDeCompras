using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaDeCompras
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            //Verificar se TXBPRODUTO está vazio (se alguem adicionou produto ou não)
            if (txbProduto.Text.Length == 0) //pode ser == "") também 
            {
                //para mostrar erro se a pessoa não adicionou nada, com um botão de ok e um icone de erro
                MessageBox.Show("O nome do produto não pode estar vazio!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                //Mudar a cor do fundo e da letra por conta do erro:
                txbProduto.BackColor = Color.IndianRed;
                txbProduto.ForeColor = Color.White;
            }
            else if (txbProduto.Text.Length < 2)
            {
                //para mostrar erro se a pessoa adicionou um produto com apenas uma letra (o que não existe(eu acho))
                MessageBox.Show("O nome do produto precisa ter no mínimo duas letras!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                //Mudar a cor do fundo e da letra por conta do erro:
                txbProduto.BackColor = Color.IndianRed;
                txbProduto.ForeColor = Color.White;
            }
            else
            {
                //Verificar se o item está na lista:
                if (libCompras.Items.Contains(txbProduto.Text))
                {
                    MessageBox.Show("Já existe na lista!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //mostrar a mensagem de sucesso
                    libCompras.Items.Add(txbProduto.Text);
                    MessageBox.Show($"{txbProduto.Text} foi adicionado à sua lista de compras!", "Muito bom!", //CONTINUA DENTRO DO () DE MENSAGEM
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Se uma vez eu coloquei errado, após eu adicionar certo, ele retorna para o normal
                    txbProduto.BackColor = Color.White;
                    txbProduto.ForeColor = Color.Black;

                    //limpar a caixinha depois de adicionada
                    txbProduto.Text = "";
                }
            }
        } 
        //limpar a lista
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //Perguntar se deseja apagar tudo, se sim, ele apaga
            DialogResult resposta = MessageBox.Show("Tem certeza que deseja apagar tudo?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            
            if (resposta == DialogResult.Yes)
            {
                libCompras.Items.Clear();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //Verificar se o usuario não selecionou nada para excluir.:
            if(libCompras.SelectedIndex == -1) 
            {
                MessageBox.Show("Selecione um item para remover!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Salvar temporariamente o nome do produto a ser removido:
                string itemRemovido = libCompras.SelectedItem.ToString(); //por que eu salvei temporariamente?
                //porque se eu não colocasse "lib.compras....selected item" o programa ia quebrar
                //porque primeiro o usuario vai excluir e depois vai aparecer a mensagem de
                //"tal item foi removido" só que como ele ia falar qual item foi removido se ele já foi removido antes da mensagem?
                //por isso adicionamos em uma variável temporaria.

                //Remover o item selecionado:
                libCompras.Items.RemoveAt(libCompras.SelectedIndex);


                //mostrar a mensagem de sucesso juntamente com o nome do produto removido
                MessageBox.Show($"{itemRemovido} foi removido da lista!", "Feito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //esse é o evento criado para quando eu apertar enter, já for ao invés de eu ter que pegar o mouse e clicar
        private void txbProduto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //"Pressionar" o enter no btnAdicionar:
                btnAdicionar.PerformClick();
            }
        }
    }
}
