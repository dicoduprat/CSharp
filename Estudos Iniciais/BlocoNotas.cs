using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FrameWork1
{
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //criar uma ação ao clicar única vez / salvar
        //evento de chama "e"
      
        private void SalvarClick(object sender, EventArgs e)
        {
            //puxando o savefaledialog que criamos
            saveFileDialog1.ShowDialog();
        }

        //Metodo salvar - fazer acontecer algo
        private void SalvarOk(object sender, CancelEventArgs e)
        {
            String Caminho = saveFileDialog1.FileName;
            //Ele salva porém precisa da biblioteca "using System.IO;" ativa
            // Onde = Caminho
            // Salvar o que? = TxbJanela
            File.WriteAllText(Caminho, TxbJanela.Text);


        }
    }
}
