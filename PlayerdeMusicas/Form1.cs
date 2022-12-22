using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayerdeMusicas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void adicionar_musica_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileInfo info = new FileInfo(openFileDialog1.FileName);
                string nome_arquivo = info.Name; //Nome da música
                string diretorio_msc = info.DirectoryName; //Diretório da música
                //caminho completo
                string caminho = diretorio_msc + "\\" + nome_arquivo;

                listBox1.Items.Add(nome_arquivo);
                listBox2.Items.Add(caminho);
            }   
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //pega o indice do vetor que contem a musica selecionada
            int i = listBox1.SelectedIndex;
            //pega o caminho completo da musica selecionada
            string caminho = listBox2.Items[i].ToString();

            //Executar a música
            axWindowsMediaPlayer1.URL = caminho;
        }

        private void avancar_Click(object sender, EventArgs e)
        {
            listBox1.SelectedIndex++;
        }

        private void retroceder_Click(object sender, EventArgs e)
        {
            listBox1.SelectedIndex--;
        }
    }
}