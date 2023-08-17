using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AulaComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            //clássica mensagem de aviso de fechar
            if (MessageBox.Show ("Tem certeza que deseja sair?", "?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) { Application.Exit (); }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(tbTexto.Text); //adiciona o texto digitado na lista do combobox
            tbTexto.Clear(); //limpa o texto digitado
            tbTexto.Focus(); //foca na caixa de texto
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            tbTexto.Clear (); //limpa o texto na caixa de texto
            comboBox1.SelectedIndex = -1; //deixa selecionado o campo vazio da combobox
            tbPosicao.Text = " "; //deixa vazio as caixas
            tbTextoSelecionado.Text = " "; //deixa vazio as caixas
            tbTotal.Text = " "; //deixa vazio as caixas
            tbTexto.Focus(); //foca na caixa de texto
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                //se ninguém da lista for selecionado, mensagem de erro
                MessageBox.Show("Nenhum item foi selecionado!", "Combo Box", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //o selecionado é removido
                comboBox1.Items.RemoveAt(comboBox1.SelectedIndex);
            }
        }

        private void btLimparLista_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear(); //deleta todos os itens da lista
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1) //se o index for diferente de -1 que é a primeira opção de caixa vazia executa o código
            {
                tbPosicao.Text = comboBox1.SelectedIndex.ToString(); //vê a posição do item e mostra ela na textbox
                tbTextoSelecionado.Text = comboBox1.SelectedItem.ToString(); //vê o item selecionado e mostra na textbox
                tbTotal.Text = comboBox1.Items.Count.ToString(); //conta quantos itens tem na caixa e mostra o número na textbox
            }

     
        }

        private void tbTexto_KeyPress(object sender, KeyPressEventArgs e) //EVENTO KEYPRESS FEITO NO RAIOZINHO
        {
            if (e.KeyChar == 13) //se a tecla enter for pressionada o botão adicionar é coisado
            {
                btAdd_Click (sender, e);
            }
        }
    }
}
