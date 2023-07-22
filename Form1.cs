using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace estoque_top
{
    public partial class Form1 : Form
    {
        List<string> Estacionamento = new List<string>();//Lista
       
        public Form1()
        {
            InitializeComponent();
        }

        void verifcListCHEIA()//FUNÇAO PARA VERIFICAR SE A LISTA/ESTACIONAMENTO ESTA CHEIA(O)
        {
            /**
             cria um if para que veja se a lista  esta dentro do limite de itens estabelecido
             o estacionamento tem um limite de 5 carros ent no if colocamos o nome da list e .Count
             para que seja contado quantos itens a lista tem e fazemos isso com uma determinaçao >= a 5
             para que essa contagem tenha um limite de itens ate 5 e pare apos isso usamos o return para que 
             ao parar ela feche
            ------------------------------------------------------------------------------------------------
            if=SE
            se estacionamento for maior ou igual a 5 mostrar mensagem(MessageBox.Show) e fechar(return).
             **/
          
            //verifica se ta cheio o estacionamento-------------------------------------------/
            if (Estacionamento.Count == 5)
            {
                MessageBox.Show("Estacionamento cheio");
                return;
                
            }
           
        }
                
               
       
        void verific_SE_a_TXTboxESTAvazia()
        {
            /**
             if=SE
            se a caixa de texto(txtPlaca) for igual a vazio("") 
            mostrar mensagem(MessageBox.Show) e fechar(return).
             */

            // verifica se a pessoa digitou alg----------------------------/
            if (txtPlaca.Text == "")
            {
                MessageBox.Show("Preencha todos os campos");
                return;
            }
        }
        
        void adicionaPlaca()
        {
            //adiciona placa na lista do codigo
            string placa = txtPlaca.Text;
            Estacionamento.Add(placa);
        }

        void ATUALIZA_interface_e_labe_DE_CONTAGEM()
        {
            /** 
             pegamos o texto da lista e recebemos nele a contagem da lista
           
            lblVeiculos.text(o .Text foi usado para identificar o que queremos da label)
            Estacionamento.Count.ToString()(count foi usado para contar os elementos da lista 
            estacionamento e o ToString para que me mostre essa contagem em string.
             */
            //atualiza o label de contagem-----------------------------------------------/
            lblVeiculos.Text = Estacionamento.Count.ToString();

          
           
           /**
            LvLista.Items(ListView tem como diferença 
            o uso do Items para denominar oque na ListView 
            foi especificado(chamado/usado))
           
            lvList.Items.Clear(); (apaga os itens da ListView para atuar como 
            um reset funcionand assim uma nova leitura e nao acontecendo erro de contagem.) 
            */
            //atualiza a lista da interface---------------------------------------------------------/
            lvLista.Items.Clear();
            for (int i = 0; i < Estacionamento.Count; i++)
            {

                lvLista.Items.Add($"[VAGA {i}] - {Estacionamento[i]}");
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnEstacionar_Click(object sender, EventArgs e)//BOTAO ESTACIONAR
        {
            
           
            
            verific_SE_a_TXTboxESTAvazia();
            adicionaPlaca();
            ATUALIZA_interface_e_labe_DE_CONTAGEM();
            verifcListCHEIA();
            





        }

        private void btnRetirar_Click(object sender, EventArgs e)//Botao de retirar o veiculo
        {
            /**
            Funciona igual ao botao de adicioar 
            com o diferencial que ao contrario de add ele usa remove 
            tendo as mesmas funçoes de atualizaçao para mostrar na tela etc.
             */
            //REMOVER
            string placa = txtPlaca.Text;
            Estacionamento.Remove(placa);
            //atualiza o label de contagem
            lblVeiculos.Text = Estacionamento.Count.ToString();

            //atualiza a lista da interface
            lvLista.Items.Clear();
            for (int i = 0; i < Estacionamento.Count; i++)
            {

                lvLista.Items.Add($"[VAGA {i}] - {Estacionamento[i]}");
            }

        }
    }
}
            
          
            

            
          



            






