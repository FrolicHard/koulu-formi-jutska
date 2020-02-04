namespace AutoWCFClient.view
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testaaTietokantayhteyttäToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mittarilukema_label = new System.Windows.Forms.Label();
            this.moottorinTilavuus_label = new System.Windows.Forms.Label();
            this.hinta_label = new System.Windows.Forms.Label();
            this.merkki_label = new System.Windows.Forms.Label();
            this.malli_label = new System.Windows.Forms.Label();
            this.uusiTietue_btn = new System.Windows.Forms.Button();
            this.tallenna_btn = new System.Windows.Forms.Button();
            this.poista_btn = new System.Windows.Forms.Button();
            this.edellinen_btn = new System.Windows.Forms.Button();
            this.seuraava_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_minimize = new System.Windows.Forms.Button();
            this.fuelComboBox = new AutoWCFClient.FlatCombo();
            this.variComboBox = new AutoWCFClient.FlatCombo();
            this.malliComboBox = new AutoWCFClient.FlatCombo();
            this.merkkiComboBox = new AutoWCFClient.FlatCombo();
            this.moottorinTilavuus_textBox = new AutoWCFClient.CustomTextBox();
            this.hinta_textBox = new AutoWCFClient.CustomTextBox();
            this.mittarilukema_textbox = new AutoWCFClient.CustomTextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(559, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainMenu_MouseDown);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.Lime;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.exitToolStripMenuItem.ForeColor = System.Drawing.Color.Lime;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ToolStripExit_click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testaaTietokantayhteyttäToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.aboutToolStripMenuItem.ForeColor = System.Drawing.Color.Lime;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // testaaTietokantayhteyttäToolStripMenuItem
            // 
            this.testaaTietokantayhteyttäToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.testaaTietokantayhteyttäToolStripMenuItem.ForeColor = System.Drawing.Color.Lime;
            this.testaaTietokantayhteyttäToolStripMenuItem.Name = "testaaTietokantayhteyttäToolStripMenuItem";
            this.testaaTietokantayhteyttäToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.testaaTietokantayhteyttäToolStripMenuItem.Text = "Testaa tietokantayhteyttä";
            this.testaaTietokantayhteyttäToolStripMenuItem.Click += new System.EventHandler(this.TestaaTietokantayhteytta);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.infoToolStripMenuItem.ForeColor = System.Drawing.Color.Lime;
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.infoToolStripMenuItem.Text = "Info";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.InfoToolStripMenuItem_Click);
            // 
            // mittarilukema_label
            // 
            this.mittarilukema_label.AutoSize = true;
            this.mittarilukema_label.ForeColor = System.Drawing.Color.Lime;
            this.mittarilukema_label.Location = new System.Drawing.Point(321, 62);
            this.mittarilukema_label.Name = "mittarilukema_label";
            this.mittarilukema_label.Size = new System.Drawing.Size(91, 17);
            this.mittarilukema_label.TabIndex = 4;
            this.mittarilukema_label.Text = "mittarilukema";
            // 
            // moottorinTilavuus_label
            // 
            this.moottorinTilavuus_label.AutoSize = true;
            this.moottorinTilavuus_label.ForeColor = System.Drawing.Color.Lime;
            this.moottorinTilavuus_label.Location = new System.Drawing.Point(321, 97);
            this.moottorinTilavuus_label.Name = "moottorinTilavuus_label";
            this.moottorinTilavuus_label.Size = new System.Drawing.Size(119, 17);
            this.moottorinTilavuus_label.TabIndex = 5;
            this.moottorinTilavuus_label.Text = "Moottorin tilavuus";
            // 
            // hinta_label
            // 
            this.hinta_label.AutoSize = true;
            this.hinta_label.ForeColor = System.Drawing.Color.Lime;
            this.hinta_label.Location = new System.Drawing.Point(208, 422);
            this.hinta_label.Name = "hinta_label";
            this.hinta_label.Size = new System.Drawing.Size(41, 17);
            this.hinta_label.TabIndex = 6;
            this.hinta_label.Text = "Hinta";
            // 
            // merkki_label
            // 
            this.merkki_label.AutoSize = true;
            this.merkki_label.ForeColor = System.Drawing.Color.Lime;
            this.merkki_label.Location = new System.Drawing.Point(25, 62);
            this.merkki_label.Name = "merkki_label";
            this.merkki_label.Size = new System.Drawing.Size(49, 17);
            this.merkki_label.TabIndex = 8;
            this.merkki_label.Text = "Merkki";
            // 
            // malli_label
            // 
            this.malli_label.AutoSize = true;
            this.malli_label.ForeColor = System.Drawing.Color.Lime;
            this.malli_label.Location = new System.Drawing.Point(25, 97);
            this.malli_label.Name = "malli_label";
            this.malli_label.Size = new System.Drawing.Size(36, 17);
            this.malli_label.TabIndex = 10;
            this.malli_label.Text = "Malli";
            // 
            // uusiTietue_btn
            // 
            this.uusiTietue_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.uusiTietue_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(110)))));
            this.uusiTietue_btn.FlatAppearance.BorderSize = 3;
            this.uusiTietue_btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.uusiTietue_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.uusiTietue_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepPink;
            this.uusiTietue_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uusiTietue_btn.ForeColor = System.Drawing.Color.Lime;
            this.uusiTietue_btn.Location = new System.Drawing.Point(116, 241);
            this.uusiTietue_btn.Name = "uusiTietue_btn";
            this.uusiTietue_btn.Size = new System.Drawing.Size(133, 85);
            this.uusiTietue_btn.TabIndex = 11;
            this.uusiTietue_btn.Text = "Uusi Tietue";
            this.uusiTietue_btn.UseVisualStyleBackColor = false;
            this.uusiTietue_btn.Click += new System.EventHandler(this.UusiTietue_btn_Click);
            // 
            // tallenna_btn
            // 
            this.tallenna_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.tallenna_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(110)))));
            this.tallenna_btn.FlatAppearance.BorderSize = 3;
            this.tallenna_btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tallenna_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.tallenna_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepPink;
            this.tallenna_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tallenna_btn.ForeColor = System.Drawing.Color.Lime;
            this.tallenna_btn.Location = new System.Drawing.Point(307, 241);
            this.tallenna_btn.Name = "tallenna_btn";
            this.tallenna_btn.Size = new System.Drawing.Size(133, 85);
            this.tallenna_btn.TabIndex = 12;
            this.tallenna_btn.Text = "Tallenna";
            this.tallenna_btn.UseVisualStyleBackColor = false;
            this.tallenna_btn.Click += new System.EventHandler(this.Tallenna_btn_Click);
            // 
            // poista_btn
            // 
            this.poista_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.poista_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(110)))));
            this.poista_btn.FlatAppearance.BorderSize = 3;
            this.poista_btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.poista_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.poista_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepPink;
            this.poista_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.poista_btn.ForeColor = System.Drawing.Color.Lime;
            this.poista_btn.Location = new System.Drawing.Point(453, 404);
            this.poista_btn.Name = "poista_btn";
            this.poista_btn.Size = new System.Drawing.Size(88, 46);
            this.poista_btn.TabIndex = 13;
            this.poista_btn.Text = "Poista";
            this.poista_btn.UseVisualStyleBackColor = false;
            this.poista_btn.Click += new System.EventHandler(this.Poista_btn_Click);
            // 
            // edellinen_btn
            // 
            this.edellinen_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.edellinen_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(110)))));
            this.edellinen_btn.FlatAppearance.BorderSize = 3;
            this.edellinen_btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.edellinen_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.edellinen_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepPink;
            this.edellinen_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edellinen_btn.ForeColor = System.Drawing.Color.Lime;
            this.edellinen_btn.Location = new System.Drawing.Point(12, 195);
            this.edellinen_btn.Name = "edellinen_btn";
            this.edellinen_btn.Size = new System.Drawing.Size(88, 176);
            this.edellinen_btn.TabIndex = 14;
            this.edellinen_btn.Text = "Edellinen";
            this.edellinen_btn.UseVisualStyleBackColor = false;
            this.edellinen_btn.Click += new System.EventHandler(this.Edellinen_btn_Click);
            // 
            // seuraava_btn
            // 
            this.seuraava_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.seuraava_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(110)))));
            this.seuraava_btn.FlatAppearance.BorderSize = 3;
            this.seuraava_btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.seuraava_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.seuraava_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepPink;
            this.seuraava_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.seuraava_btn.ForeColor = System.Drawing.Color.Lime;
            this.seuraava_btn.Location = new System.Drawing.Point(453, 195);
            this.seuraava_btn.Name = "seuraava_btn";
            this.seuraava_btn.Size = new System.Drawing.Size(94, 176);
            this.seuraava_btn.TabIndex = 15;
            this.seuraava_btn.Text = "Seuraava";
            this.seuraava_btn.UseVisualStyleBackColor = false;
            this.seuraava_btn.Click += new System.EventHandler(this.Seuraava_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(25, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Väri";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(321, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Polttoaine";
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.btn_exit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(110)))));
            this.btn_exit.FlatAppearance.BorderSize = 2;
            this.btn_exit.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btn_exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.btn_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepPink;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.Color.Lime;
            this.btn_exit.Location = new System.Drawing.Point(503, 2);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(44, 25);
            this.btn_exit.TabIndex = 21;
            this.btn_exit.Text = "X";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.ToolStripExit_click);
            // 
            // btn_minimize
            // 
            this.btn_minimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.btn_minimize.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(110)))));
            this.btn_minimize.FlatAppearance.BorderSize = 2;
            this.btn_minimize.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btn_minimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.btn_minimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepPink;
            this.btn_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_minimize.ForeColor = System.Drawing.Color.Lime;
            this.btn_minimize.Location = new System.Drawing.Point(453, 2);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.Size = new System.Drawing.Size(44, 25);
            this.btn_minimize.TabIndex = 22;
            this.btn_minimize.Text = "-";
            this.btn_minimize.UseVisualStyleBackColor = false;
            this.btn_minimize.Click += new System.EventHandler(this.Btn_minimize_Click);
            // 
            // fuelComboBox
            // 
            this.fuelComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(110)))));
            this.fuelComboBox.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.fuelComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fuelComboBox.ForeColor = System.Drawing.Color.Lime;
            this.fuelComboBox.FormattingEnabled = true;
            this.fuelComboBox.Location = new System.Drawing.Point(446, 130);
            this.fuelComboBox.MaxDropDownItems = 25;
            this.fuelComboBox.Name = "fuelComboBox";
            this.fuelComboBox.Size = new System.Drawing.Size(100, 24);
            this.fuelComboBox.Sorted = true;
            this.fuelComboBox.TabIndex = 20;
            // 
            // variComboBox
            // 
            this.variComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(110)))));
            this.variComboBox.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.variComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.variComboBox.ForeColor = System.Drawing.Color.Lime;
            this.variComboBox.FormattingEnabled = true;
            this.variComboBox.Location = new System.Drawing.Point(128, 130);
            this.variComboBox.MaxDropDownItems = 25;
            this.variComboBox.Name = "variComboBox";
            this.variComboBox.Size = new System.Drawing.Size(121, 24);
            this.variComboBox.Sorted = true;
            this.variComboBox.TabIndex = 18;
            // 
            // malliComboBox
            // 
            this.malliComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(110)))));
            this.malliComboBox.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.malliComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.malliComboBox.ForeColor = System.Drawing.Color.Lime;
            this.malliComboBox.FormattingEnabled = true;
            this.malliComboBox.Location = new System.Drawing.Point(128, 95);
            this.malliComboBox.MaxDropDownItems = 25;
            this.malliComboBox.Name = "malliComboBox";
            this.malliComboBox.Size = new System.Drawing.Size(121, 24);
            this.malliComboBox.Sorted = true;
            this.malliComboBox.TabIndex = 9;
            // 
            // merkkiComboBox
            // 
            this.merkkiComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(110)))));
            this.merkkiComboBox.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.merkkiComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.merkkiComboBox.ForeColor = System.Drawing.Color.Lime;
            this.merkkiComboBox.FormattingEnabled = true;
            this.merkkiComboBox.Location = new System.Drawing.Point(128, 60);
            this.merkkiComboBox.MaxDropDownItems = 25;
            this.merkkiComboBox.Name = "merkkiComboBox";
            this.merkkiComboBox.Size = new System.Drawing.Size(121, 24);
            this.merkkiComboBox.Sorted = true;
            this.merkkiComboBox.TabIndex = 7;
            this.merkkiComboBox.SelectedIndexChanged += new System.EventHandler(this.MerkkiComboBox_SelectedIndexChanged);
            // 
            // moottorinTilavuus_textBox
            // 
            this.moottorinTilavuus_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(110)))));
            this.moottorinTilavuus_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.moottorinTilavuus_textBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.moottorinTilavuus_textBox.ForeColor = System.Drawing.Color.Lime;
            this.moottorinTilavuus_textBox.Location = new System.Drawing.Point(446, 97);
            this.moottorinTilavuus_textBox.Margin = new System.Windows.Forms.Padding(15);
            this.moottorinTilavuus_textBox.Multiline = true;
            this.moottorinTilavuus_textBox.Name = "moottorinTilavuus_textBox";
            this.moottorinTilavuus_textBox.Size = new System.Drawing.Size(100, 24);
            this.moottorinTilavuus_textBox.TabIndex = 3;
            this.moottorinTilavuus_textBox.Text = " ";
            // 
            // hinta_textBox
            // 
            this.hinta_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(110)))));
            this.hinta_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hinta_textBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.hinta_textBox.ForeColor = System.Drawing.Color.Lime;
            this.hinta_textBox.Location = new System.Drawing.Point(255, 420);
            this.hinta_textBox.Margin = new System.Windows.Forms.Padding(15);
            this.hinta_textBox.MinimumSize = new System.Drawing.Size(2, 24);
            this.hinta_textBox.Multiline = true;
            this.hinta_textBox.Name = "hinta_textBox";
            this.hinta_textBox.Size = new System.Drawing.Size(100, 24);
            this.hinta_textBox.TabIndex = 2;
            this.hinta_textBox.Text = " ";
            // 
            // mittarilukema_textbox
            // 
            this.mittarilukema_textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(110)))));
            this.mittarilukema_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mittarilukema_textbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mittarilukema_textbox.ForeColor = System.Drawing.Color.Lime;
            this.mittarilukema_textbox.Location = new System.Drawing.Point(446, 60);
            this.mittarilukema_textbox.Margin = new System.Windows.Forms.Padding(15);
            this.mittarilukema_textbox.Multiline = true;
            this.mittarilukema_textbox.Name = "mittarilukema_textbox";
            this.mittarilukema_textbox.Size = new System.Drawing.Size(100, 24);
            this.mittarilukema_textbox.TabIndex = 1;
            this.mittarilukema_textbox.Text = " ";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(559, 461);
            this.Controls.Add(this.btn_minimize);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.fuelComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.variComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.seuraava_btn);
            this.Controls.Add(this.edellinen_btn);
            this.Controls.Add(this.poista_btn);
            this.Controls.Add(this.tallenna_btn);
            this.Controls.Add(this.uusiTietue_btn);
            this.Controls.Add(this.malli_label);
            this.Controls.Add(this.malliComboBox);
            this.Controls.Add(this.merkki_label);
            this.Controls.Add(this.merkkiComboBox);
            this.Controls.Add(this.hinta_label);
            this.Controls.Add(this.moottorinTilavuus_label);
            this.Controls.Add(this.mittarilukema_label);
            this.Controls.Add(this.moottorinTilavuus_textBox);
            this.Controls.Add(this.hinta_textBox);
            this.Controls.Add(this.mittarilukema_textbox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainMenu_MouseDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testaaTietokantayhteyttäToolStripMenuItem;
        private CustomTextBox mittarilukema_textbox;
        private CustomTextBox hinta_textBox;
        private CustomTextBox moottorinTilavuus_textBox;
        private System.Windows.Forms.Label mittarilukema_label;
        private System.Windows.Forms.Label moottorinTilavuus_label;
        private System.Windows.Forms.Label hinta_label;
        private FlatCombo merkkiComboBox;
        private System.Windows.Forms.Label merkki_label;
        private FlatCombo malliComboBox;
        private System.Windows.Forms.Label malli_label;
        private System.Windows.Forms.Button uusiTietue_btn;
        private System.Windows.Forms.Button tallenna_btn;
        private System.Windows.Forms.Button poista_btn;
        private System.Windows.Forms.Button edellinen_btn;
        private System.Windows.Forms.Button seuraava_btn;
        private System.Windows.Forms.Label label1;
        private FlatCombo variComboBox;
        private System.Windows.Forms.Label label2;
        private FlatCombo fuelComboBox;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_minimize;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
    }
}