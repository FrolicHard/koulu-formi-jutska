using System;
using System.Windows.Forms;

namespace AutoWCFClient.view
{
    internal partial class MessageForm : Form
    {
        public MessageForm()
        {
            InitializeComponent();
        }

        private void MessageForm_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
        }
        public MessageForm(string title, string description)
        {
            InitializeComponent();

            this.titleLabel.Text = title;
            this.descriptionLabel.Text = description;
        }

        private void Btn_ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
    public class CustomMessageBox 
    {
        public static void DisplayMessage(string title, string description)
        {
            using (var msgForm = new MessageForm(title, description))
            {
                msgForm.ShowDialog();
            }
        }
    }
}



