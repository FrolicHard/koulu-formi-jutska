using Autokauppa.controller;
using Autokauppa.model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Autokauppa.view
{
    public partial class MainMenu : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        int selectedID;
        AutoRegisterHandler control = new AutoRegisterHandler();
        DatabaseController dbControl = new DatabaseController();



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

            List<AutonMerkki> merkit;
            List<Vari> varit;
            List<Polttoaine> fuels;

            merkit = control.GetAllAutoMakers();
            varit = control.GetVarit();
            fuels = control.GetFuels();

            merkkiComboBox.DataSource = merkit;
            merkkiComboBox.DisplayMember = "Merkki";
            merkkiComboBox.ValueMember = "Id";
            merkkiComboBox.SelectedIndex = 0;

            variComboBox.DataSource = varit;
            variComboBox.DisplayMember = "Varin_nimi";
            variComboBox.ValueMember = "Id";

            fuelComboBox.DataSource = fuels;
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
            control.TestDatabaseConnection();
        }

        private void MerkkiComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<AutonMalli> mallit;
            if (merkkiComboBox.SelectedValue is int)
            {
                mallit = control.GetAutoModels((int)merkkiComboBox.SelectedValue);

                malliComboBox.DataSource = mallit;
                malliComboBox.DisplayMember = "Auton_mallin_nimi";
                malliComboBox.ValueMember = "Id";
            }
        }

        private void Poista_btn_Click(object sender, EventArgs e)
        {
            if (control.DeleteSelectedRowFromDatabase(selectedID) == 1)
            {
                CustomMessageBox.DisplayMessage("Success!", "An object was removed from the database.");
            }
            else if (control.DeleteSelectedRowFromDatabase(selectedID) == 0)
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

                Auto uusiAuto = new Auto(hinta: hintaConvert,
                    rekisteri_paivamaara: DateTime.Today, moottorin_tilavuus: ccConvert,
                    mittarilukema: mittariLukuConvert, autonMerkkiId: (int)merkkiComboBox.SelectedValue,
                    autonMalliId: (int)malliComboBox.SelectedValue, variId: (int)variComboBox.SelectedValue,
                    polttoaineId: (int)fuelComboBox.SelectedValue);

                if (control.SaveAuto(uusiAuto) == true)
                {
                    CustomMessageBox.DisplayMessage("Success!", "A new car has been added into the database.");
                }
                else
                {
                    CustomMessageBox.DisplayMessage("ERROR!", "Adding a new object into the database failed.");
                    return;
                }
            }
            catch
            {
                CustomMessageBox.DisplayMessage("OOPS!", "Something went wrong. Check the input values of the new object.");
                return;          
            }

        }

        private void Edellinen_btn_Click(object sender, EventArgs e)
        {

            Auto edellinen = control.ValitseEdellinen(selectedID);
            selectedID = edellinen.Id;
            DisplayAuto(edellinen);
        }

        private void Seuraava_btn_Click(object sender, EventArgs e)
        {

            Auto seuraava = control.ValitseSeuraava(selectedID);
            selectedID = seuraava.Id;
            DisplayAuto(seuraava);
        }

        private void DisplayAuto(Auto seuraava)
        {
            hinta_textBox.Text = seuraava.Hinta.ToString();
            moottorinTilavuus_textBox.Text = seuraava.Moottorin_tilavuus.ToString();
            mittarilukema_textbox.Text = seuraava.Mittarilukema.ToString();
            merkkiComboBox.SelectedValue = seuraava.AutonMerkkiId;
            malliComboBox.SelectedValue = seuraava.AutonMalliId;
            variComboBox.SelectedValue = seuraava.VariId;
            fuelComboBox.SelectedValue = seuraava.PolttoaineId;
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
