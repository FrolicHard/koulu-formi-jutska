using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client client = new
        ServiceReference1.Service1Client();
            string returnString;

            returnString = client.GetData(textBox1.Text);
            label5.Text = returnString;
        }

        private void ExcitingBtnClick(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client client = new
                ServiceReference1.Service1Client();
            int returnValue;
            int luku = int.Parse(textBox_EkaLuku.Text);
            int toinen = int.Parse(textBox_TokaLuku.Text);

            returnValue = client.Tulo(luku, toinen);
            label4.Text = returnValue.ToString();
        }
    }
}
