using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace AutoWCFClient.view
{

    public partial class MainMenu : Form
    {
        private ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        int selectedID;

        




        public MainMenu()
        {
            InitializeComponent();
        }


        private void MainMenu_Load(object sender, EventArgs e)
        {
            


            this.FormBorderStyle = FormBorderStyle.None;           
            if (this.WindowState == FormWindowState.Minimized) this.WindowState = FormWindowState.Normal;           
            this.menuStrip1.RenderMode = ToolStripRenderMode.ManagerRenderMode;

            SwitchRenderer();


            merkkiComboBox.DataSource = client.GetAllAutoMakersFromDatabase();
            merkkiComboBox.DisplayMember = "Merkki";
            merkkiComboBox.ValueMember = "Id";
            merkkiComboBox.SelectedIndex = 0;

            variComboBox.DataSource = client.GetColorsFromDatabase();
            variComboBox.DisplayMember = "Varin_nimi";
            variComboBox.ValueMember = "Id";

            fuelComboBox.DataSource = client.GetAllFuelsFromDatabase();
            fuelComboBox.DisplayMember = "Polttoaineen_nimi";
            fuelComboBox.ValueMember = "Id";

            selectedID = 0;
            Seuraava_btn_Click(sender, e);
        }

        private void ToolStripExit_click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TestaaTietokantayhteytta(object sender, EventArgs e)
        {
            if (client.ConnectDatabase() == true)
            {
                CustomMessageBox.DisplayMessage("Nice!", "Tietokantayhteys on aktiivinen.");
            }
            else
            {
                CustomMessageBox.DisplayMessage("OOPS!", "Tietokantayhteys ei pelitä.");
            }
        }

        private void MerkkiComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (merkkiComboBox.SelectedValue is int)
            {
                malliComboBox.DataSource = client.GetAutoModelsByMakerId((int)merkkiComboBox.SelectedValue);
                malliComboBox.DisplayMember = "Auton_mallin_nimi";
                malliComboBox.ValueMember = "Id";
            }
        }

        private void Poista_btn_Click(object sender, EventArgs e)
        {
            if (client.DeleteRowFromDatabase(selectedID) == 1)
            {
                CustomMessageBox.DisplayMessage("Success!", "An object was removed from the database.");
            }
            else if (client.DeleteRowFromDatabase(selectedID) == 0)
            {
                CustomMessageBox.DisplayMessage("ERROR", "An object that doesn't exist can't be removed from the database. Are you trying to prove the existence of divinity?");
            }
            else
            {
                CustomMessageBox.DisplayMessage("ERROR!", "Something went wrong.");
            }
        }

        private void UusiTietue_btn_Click(object sender, EventArgs e)
        {
            MainMenu NewForm = new MainMenu();
            NewForm.Show();
            this.Dispose(false);
        }

        private void Tallenna_btn_Click(object sender, EventArgs e)
        {
            try
            {
                var ccConvert = Convert.ToDecimal(moottorinTilavuus_textBox.Text);
                var hintaConvert = Convert.ToDecimal(hinta_textBox.Text);
                var mittariLukuConvert = Convert.ToInt32(mittarilukema_textbox.Text);

                ServiceReference1.AutoDetails uusiauto = new ServiceReference1.AutoDetails(hinta: hintaConvert,
                   rekisteri_pvm: DateTime.Today, moottorin_tilavuus: ccConvert,
                   mittarinlukema: mittariLukuConvert, autonMerkkiID: (int)merkkiComboBox.SelectedValue,
                   autonMalliID: (int)malliComboBox.SelectedValue, varitID: (int)variComboBox.SelectedValue,
                   polttoaineID: (int)fuelComboBox.SelectedValue);

                string message = client.InsertAutoDetails(uusiauto);

                CustomMessageBox.DisplayMessage("Message!",message);
            }
            catch
            {
                CustomMessageBox.DisplayMessage("OOPS!", "Something went wrong. Check the input values of the new object.");
                return;          
            }

        }

        private void Edellinen_btn_Click(object sender, EventArgs e)
        {
            try
            {
                ServiceReference1.AutoDetails edellinen = client.SelectPreviousAutoRow(selectedID);
                if (edellinen != null)
                {
                    selectedID = edellinen.Id;
                    DisplayAuto(edellinen);
                }
                else
                {
                    edellinen = client.ChooseAutoMax();
                    selectedID = edellinen.Id;
                    DisplayAuto(edellinen);
                }
            }

            catch
            {
                CustomMessageBox.DisplayMessage("OOPS!", "Auton valinta epäonistui!");
            }
            
        }

        private void Seuraava_btn_Click(object sender, EventArgs e)
        {

            try
            {
                ServiceReference1.AutoDetails seuraava = client.SelectNextAutoRow(selectedID);
                if (seuraava != null)
                {
                    selectedID = seuraava.Id;
                    DisplayAuto(seuraava);
                }
                else
                {
                    seuraava = client.ChooseAutoMin();
                    selectedID = seuraava.Id;
                    DisplayAuto(seuraava);
                }
            }

            catch
            {
                CustomMessageBox.DisplayMessage("OOPS!", "Auton valinta epäonistui!");
            }
        }

        private void DisplayAuto(ServiceReference1.AutoDetails valittu)
        {
            hinta_textBox.Text = valittu.Hinta.ToString();
            moottorinTilavuus_textBox.Text = valittu.Moottorin_tilavuus.ToString();
            mittarilukema_textbox.Text = valittu.Mittarinlukema.ToString();
            merkkiComboBox.SelectedValue = valittu.AutonMerkkiID;
            malliComboBox.SelectedValue = valittu.AutonMalliID;
            variComboBox.SelectedValue = valittu.VaritID;
            fuelComboBox.SelectedValue = valittu.PolttoaineID;
        }

        public void SwitchRenderer()
        {
            ToolStrip ms = ToolStripManager.FindToolStrip("menuStrip1");
            ms.RenderMode = ToolStripRenderMode.ManagerRenderMode;


            // Assign the custom renderer at the application level.
            ToolStripManager.Renderer = new CustomProfessionalRenderer();
            
        }

        private void MainMenu_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
        }

        private void InfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomMessageBox.DisplayMessage("Author: Riku Vartiainen 2009", "This is a school assignment about the MVC-architecture.");
        }
    }
}
