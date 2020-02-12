using Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void BuscarNome()
        {
            WebClient client = new WebClient();
            string json = client.DownloadString("https://servicodados.ibge.gov.br/api/v2/censos/nomes/" + textBox1.Text);
            if (json.Length > 2)
            {

                var dados = JsonConvert.DeserializeObject<List<Dados>>(json);

                dataGridView1.Rows.Clear();
                foreach (var dado in dados[0].res)
                {
                    dataGridView1.Rows.Add(dado.periodo.Replace("[", "").Replace("]", ""), dado.frequencia);
                }

                label3.Text = dados[0].localidade.ToString();
            }
            else
                MessageBox.Show("Nome não encontrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BuscarNome();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                BuscarNome();
            }
        }
    }
}
