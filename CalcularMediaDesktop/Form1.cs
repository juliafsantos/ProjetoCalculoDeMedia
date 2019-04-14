using CalcularMediaDesktop.ServiceReference1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcularMediaDesktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();

            MediaRequest request = new MediaRequest();



            request.Nota1 = Convert.ToDouble(txtP1.Text);

            request.Nota2 = Convert.ToDouble(txtP2.Text);



            MediaResponse response = client.CalcularMedia(request);


            txtResultado.Text = response.Resultado;

            txtMedia.Text = response.Media.ToString();



            client.Close();
        }
    }
}
