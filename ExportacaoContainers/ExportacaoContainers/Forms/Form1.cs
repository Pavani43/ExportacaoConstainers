using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExportacaoContainers.Class;
using ExportacaoContainers.CONTROLLER;

namespace ExportacaoContainers.Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Controller.InsertExp(cod_lacre.Text, cod_navio.Text, float.Parse(peso.Text), porto_saida.Text, porto_entrega.Text, data_saida.Text, data_entrega.Text);
                MessageBox.Show("Inserido com sucesso.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.tabelaTableAdapter.Fill(this.database1DataSet.Tabela);
        }
    }
}
