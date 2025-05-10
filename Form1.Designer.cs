//using System.Reflection.Emit;
//using System.Windows.Forms;
//using BfevLibrary.Core;

namespace TotkRandomizer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            progressBar1 = new ProgressBar();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            textBox1 = new TextBox();
            label1 = new Label();
            button2 = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            label7 = new Label();
            panel2 = new Panel();
            label11 = new Label();
            paragliderPatternBox = new ComboBox();
            label2 = new Label();
            panel1 = new Panel();
            label6 = new Label();
            weaponsBox = new ComboBox();
            label5 = new Label();
            natureBox = new ComboBox();
            label4 = new Label();
            chestsBox = new ComboBox();
            label3 = new Label();
            enemiesBox = new ComboBox();
            panel26 = new Panel();
            label26 = new Label();
            label26a = new Label();
            panel27 = new Panel();
            label27 = new Label();
            heartsInt = new NumericUpDown();
            label26b = new Label();
            staminaFloat = new ComboBox();
            label26c = new Label();
            batteryFloat = new ComboBox();
            label26d = new Label();
            rupeesInt = new NumericUpDown();
            label27a = new Label();
            label27b = new Label();
            label27c = new Label();
            weaponOnStart = new ComboBox();
            pouchWInt = new NumericUpDown();
            pouchBInt = new NumericUpDown();
            pouchSInt = new NumericUpDown();

            label3_1 = new Label();
            label3_1p = new Label();
            label3_2 = new Label();
            fairiesInt = new NumericUpDown();

            label4_1 = new Label();
            label4_2 = new Label();
            label4_3 = new Label();
            label4_3a = new Label();
            checkbox4_3 = new CheckBox();
            label4_4 = new Label();
            label4_4a = new Label();
            checkbox4_4 = new CheckBox();
            speedCoeff = new ComboBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ToolTip gameruleTT1 = new ToolTip();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Enabled = false;
            button1.Location = new Point(18, 282);
            button1.Name = "button1";
            button1.Size = new Size(709, 62);
            button1.TabIndex = 0;
            button1.Text = "Randomize Game!";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(18, 249);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(709, 27);
            progressBar1.Style = ProgressBarStyle.Continuous;
            progressBar1.TabIndex = 1;
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            backgroundWorker1.ProgressChanged += ProgressChanged;
            backgroundWorker1.RunWorkerCompleted += BackgroundWorker_RunWorkerCompleted;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(194, 18);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(394, 23);
            textBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 22);
            label1.Name = "label1";
            label1.Size = new Size(170, 15);
            label1.TabIndex = 3;
            label1.Text = "Tears of the Kingdom ROMFS : ";
            // 
            // button2
            // 
            button2.Location = new Point(594, 18);
            button2.Name = "button2";
            button2.Size = new Size(133, 23);
            button2.TabIndex = 4;
            button2.Text = "Browse...";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(753, 390);
            tabControl1.TabIndex = 13;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(progressBar1);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(button2);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(15);
            tabPage1.Size = new Size(745, 362);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Generate";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(panel2);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(panel1);
            tabPage2.Controls.Add(label26);
            tabPage2.Controls.Add(panel26);
            tabPage2.Controls.Add(label27);
            tabPage2.Controls.Add(panel27);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(10);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(15);
            tabPage2.Size = new Size(745, 362);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Settings";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(label3_1);
            tabPage3.Controls.Add(weaponOnStart);
            tabPage3.Controls.Add(label3_1p);
            tabPage3.Controls.Add(label3_2);
            tabPage3.Controls.Add(fairiesInt);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(15);
            tabPage3.Size = new Size(745, 362);
            tabPage3.TabIndex = 0;
            tabPage3.Text = "Inventory";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(label4_1);
            tabPage4.Controls.Add(label4_2);
            tabPage4.Controls.Add(speedCoeff);
            tabPage4.Controls.Add(label4_3);
            tabPage4.Controls.Add(checkbox4_3);
            tabPage4.Controls.Add(label4_3a);
            tabPage4.Controls.Add(label4_4);
            tabPage4.Controls.Add(checkbox4_4);
            tabPage4.Controls.Add(label4_4a);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(15);
            tabPage4.Size = new Size(745, 362);
            tabPage4.TabIndex = 0;
            tabPage4.Text = "Gamerules";
            tabPage4.UseVisualStyleBackColor = true;

            // 
            // label3_1 : WIP
            // 
            label3_1.AutoSize = true;
            label3_1.Location = new Point(30, 40);
            label3_1.Name = "label3_1";
            label3_1.Size = new Size(250, 15);
            label3_1.TabIndex = 22;
            label3_1.Text = "Select Weapon on start: ";
            //label3_1.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);

            weaponOnStart.DropDownStyle = ComboBoxStyle.DropDownList;
            //weaponOnStart.DataSource = SelectWeaponList;
            weaponOnStart.FormattingEnabled = true;
            weaponOnStart.DisplayMember = "Value";
            weaponOnStart.ValueMember = "Key";
            weaponOnStart.SelectedValue = "Random";
            weaponOnStart.Location = new Point(175, 37);
            weaponOnStart.Width = 180;

            // 
            // label3_1p : WIP
            // 
            label3_1p.AutoSize = true;
            label3_1p.Location = new Point(365, 35);
            label3_1p.Name = "label3_1p";
            label3_1p.Size = new Size(450, 50);
            label3_1p.TabIndex = 22;
            label3_1p.Text = "NB : If you can't directly get the weapon (spear and bigsword),\n simply use Ultrahand to move it and allow pickup";
            //label3_1.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);


            label3_2.AutoSize = true;
            label3_2.Location = new Point(30, 80);
            label3_2.Name = "label3_2";
            label3_2.Size = new Size(150, 15);
            label3_2.TabIndex = 22;
            label3_2.Text = "Number of fairies: ";

            //
            // fairiesInt => label3_2
            //
            fairiesInt.Minimum = 0;
            fairiesInt.Maximum = 999;
            fairiesInt.Value = 0;
            fairiesInt.Location = new Point(140, 77);
            fairiesInt.Width = 50;

            // 
            // label4_1 : WARNING FOR GAMERULE
            // 
            label4_1.AutoSize = true;
            label4_1.Location = new Point(30, 10);
            label4_1.Name = "label4_1";
            label4_1.Size = new Size(250, 15);
            label4_1.TabIndex = 22;
            label4_1.Text = "⚠️ Be careful with these custom settings. Let all on Default unless you know what you are doing ⚠️";
            label4_1.ForeColor = Color.DarkRed;

            // 
            // label4_2w : WIP
            // 
            label4_2.AutoSize = true;
            label4_2.Location = new Point(30, 40);
            label4_2.Name = "label4_2";
            label4_2.Size = new Size(250, 15);
            label4_2.TabIndex = 22;
            label4_2.Text = "Speed coefficient (DISABLED, WIP):";
            gameruleTT1.SetToolTip(label4_2, "Change the 'AllSpeed' parameter to Link : Walk, Run, Paraglide");
            //label4_2.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);

            //
            // speedCoeff => label4_2 =>
            //
            speedCoeff.DropDownStyle = ComboBoxStyle.DropDownList;
            speedCoeff.FormattingEnabled = true;
            speedCoeff.Items.AddRange(new object[] { "Default (1.0)", "+10% (1.1)", "+20% (1.2)", "+30% (1.3)" });
            speedCoeff.SelectedItem = (System.String) "Default (1.0)";
            speedCoeff.Location = new Point(250, 38);
            speedCoeff.Width = 100;

            // 
            // label4_3 : LightOrb removal
            // 
            label4_3.AutoSize = true;
            label4_3.Location = new Point(30, 80);
            label4_3.Name = "label4_3";
            label4_3.Size = new Size(250, 15);
            label4_3.TabIndex = 22;
            label4_3.Text = "Remove Light of Blessing from chests ?";

            // 
            // label4_3a : LightOrb removal Info
            // 
            label4_3a.AutoSize = true;
            label4_3a.Location = new Point(360, 80);
            label4_3a.Name = "label4_3a";
            label4_3a.Size = new Size(250, 15);
            label4_3a.TabIndex = 22;
            label4_3a.Text = "(You need at least 4 hearts to use this option)";

            // 
            // checkbox4_3 : LightOrb removal BOOL
            // 
            checkbox4_3.Appearance = Appearance.Button;
            checkbox4_3.AutoSize = true;
            checkbox4_3.Checked = false;
            checkbox4_3.Text = "False (default)";
            checkbox4_3.CheckedChanged += (s, e) =>
            {
                checkbox4_3.Text = checkbox4_3.Checked.ToString();
            };
            checkbox4_3.Location = new Point(250, 77);

            // 
            // label4_4 : ShrineReward enabled ?
            // 
            label4_4.AutoSize = true;
            label4_4.Location = new Point(30, 120);
            label4_4.Name = "label4_4";
            label4_4.Size = new Size(150, 15);
            label4_4.TabIndex = 22;
            label4_4.Text = "Enable random Shrine Rewards ?";

            // 
            // label4_4 : ShrineReward enabled ?
            // 
            label4_4a.AutoSize = true;
            label4_4a.Location = new Point(360, 120);
            label4_4a.Name = "label4_4a";
            label4_4a.Size = new Size(150, 15);
            label4_4a.TabIndex = 22;
            label4_4a.Text = "(It will be the same reward for all shrine)";

            // 
            // checkbox4_4 : LightOrb removal BOOL
            // 
            checkbox4_4.Appearance = Appearance.Button;
            checkbox4_4.AutoSize = true;
            checkbox4_4.Checked = false;
            checkbox4_4.Text = "False (default)";
            checkbox4_4.CheckedChanged += (s, e) =>
            {
                checkbox4_4.Text = checkbox4_4.Checked.ToString();
            };
            checkbox4_4.Location = new Point(250, 116);

            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(28, 109);
            label7.Name = "label7";
            label7.Size = new Size(105, 15);
            label7.TabIndex = 22;
            label7.Text = "Cosmetic Settings:";

            // New label status - Player Settings
            //
            // label26
            //
            label26.AutoSize = true;
            label26.Location = new Point(28, 179);
            label26.Name = "label26";
            label26.Size = new Size(105, 15);
            label26.TabIndex = 22;
            label26.Text = "Player Settings:";

            // 
            // label26a
            // 
            label26a.AutoSize = true;
            label26a.Location = new Point(0, 0);
            label26a.Name = "label26a";
            label26a.Size = new Size(104, 15);
            label26a.TabIndex = 20;
            label26a.Text = "Hearts [3-40]:";

            //
            // heartsInt => label26a => panel26
            //
            heartsInt.Minimum = 3;
            heartsInt.Maximum = 40;
            heartsInt.Value = 3;
            heartsInt.Location = new Point(100, 13);
            heartsInt.Width = 40;

            // 
            // label26b
            // 
            label26b.AutoSize = true;
            label26b.Location = new Point(150, 0);
            label26b.Name = "label26b";
            label26b.Size = new Size(104, 15);
            label26b.TabIndex = 20;
            label26b.Text = "Stamina:";

            //
            // staminaFloat => label26b => panel26
            //
            staminaFloat.DropDownStyle = ComboBoxStyle.DropDownList;
            staminaFloat.FormattingEnabled = true;
            for (System.Single val = (System.Single) 1000f; val <= (System.Single) 3000f; val += (System.Single) 200f)
            {
                staminaFloat.Items.Add(val);
            }
            staminaFloat.SelectedItem = (System.Single) 1000f;
            staminaFloat.Location = new Point(220, 13);
            staminaFloat.Width = 60;

            // 
            // label26c
            // 
            label26c.AutoSize = true;
            label26c.Location = new Point(280, 0);
            label26c.Name = "label26c";
            label26c.Size = new Size(104, 15);
            label26c.TabIndex = 20;
            label26c.Text = "Battery:";

            //
            // batteryFloat => label26b => panel26
            //
            batteryFloat.DropDownStyle = ComboBoxStyle.DropDownList;
            batteryFloat.FormattingEnabled = true;
            for (System.Single wal = (System.Single) 3000f; wal <= (System.Single) 48000f; wal += (System.Single) 1000f)
            {
                batteryFloat.Items.Add(wal);
            }
            batteryFloat.SelectedItem = (System.Single) 3000f;
            batteryFloat.Location = new Point(345, 13);
            batteryFloat.Width = 80;

            // 
            // label26d
            // 
            label26d.AutoSize = true;
            label26d.Location = new Point(430, 0);
            label26d.Name = "label26d";
            label26d.Size = new Size(150, 15);
            label26d.TabIndex = 20;
            label26d.Text = "Rupees [0-999999]:";

            //
            // rupeesInt => label26d => panel26
            //
            rupeesInt.Minimum = 0;
            rupeesInt.Maximum = 999999;
            rupeesInt.Value = 0;
            rupeesInt.Location = new Point(560, 13);
            rupeesInt.Width = 70;

            // New panel Player Settings
            // 
            // panel26
            // 
            panel26.BorderStyle = BorderStyle.FixedSingle;
            panel26.Controls.Add(label26a);
            panel26.Controls.Add(heartsInt);
            panel26.Controls.Add(label26b);
            panel26.Controls.Add(staminaFloat);
            panel26.Controls.Add(label26c);
            panel26.Controls.Add(batteryFloat);
            panel26.Controls.Add(label26d);
            panel26.Controls.Add(rupeesInt);
            panel26.Location = new Point(18, 187);
            panel26.Margin = new Padding(10);
            panel26.Name = "panel26";
            panel26.Padding = new Padding(15);
            panel26.Size = new Size(709, 49);
            panel26.TabIndex = 23;

            // New panel Pouch Settings
            // 
            // panel27
            // 
            panel27.BorderStyle = BorderStyle.FixedSingle;
            panel27.Controls.Add(label27a);
            panel27.Controls.Add(pouchWInt);
            panel27.Controls.Add(label27b);
            panel27.Controls.Add(pouchBInt);
            panel27.Controls.Add(label27c);
            panel27.Controls.Add(pouchSInt);
            panel27.Location = new Point(18, 252);
            panel27.Margin = new Padding(10);
            panel27.Name = "panel27";
            panel27.Padding = new Padding(15);
            panel27.Size = new Size(709, 49);
            panel27.TabIndex = 23;

            // New label status - Pouch Settings
            //
            // label27
            //
            label27.AutoSize = true;
            label27.Location = new Point(28, 244);
            label27.Name = "label27";
            label27.Size = new Size(105, 15);
            label27.TabIndex = 22;
            label27.Text = "Pouch Settings:";

            // 
            // label27a
            // 
            label27a.AutoSize = true;
            label27a.Location = new Point(15, 15);
            label27a.Name = "label27a";
            label27a.Size = new Size(140, 15);
            label27a.TabIndex = 20;
            label27a.Text = "Weapon [8-20]:";

            // 
            // label27b
            // 
            label27b.AutoSize = true;
            label27b.Location = new Point(170, 15);
            label27b.Name = "label27b";
            label27b.Size = new Size(130, 15);
            label27b.TabIndex = 20;
            label27b.Text = "Bow [5-14]:";

            // 
            // label27c
            // 
            label27c.AutoSize = true;
            label27c.Location = new Point(310, 15);
            label27c.Name = "label27c";
            label27c.Size = new Size(130, 15);
            label27c.TabIndex = 20;
            label27c.Text = "Shield [4-20]:";

            // 
            // pouchWInt
            // 
            pouchWInt.Minimum = 8;
            pouchWInt.Maximum = 20;
            pouchWInt.Value = 8;
            pouchWInt.Location = new Point(105, 13);
            pouchWInt.Width = 40;

            // 
            // pouchBInt
            // 
            pouchBInt.Minimum = 5;
            pouchBInt.Maximum = 14;
            pouchBInt.Value = 5;
            pouchBInt.Location = new Point(240, 13);
            pouchBInt.Width = 40;

            // 
            // pouchSInt
            // 
            pouchSInt.Minimum = 4;
            pouchSInt.Maximum = 20;
            pouchSInt.Value = 4;
            pouchSInt.Location = new Point(390, 13);
            pouchSInt.Width = 40;

            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label11);
            panel2.Controls.Add(paragliderPatternBox);
            panel2.Location = new Point(18, 117);
            panel2.Margin = new Padding(10);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(15);
            panel2.Size = new Size(709, 49);
            panel2.TabIndex = 23;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(18, 15);
            label11.Name = "label11";
            label11.Size = new Size(104, 15);
            label11.TabIndex = 20;
            label11.Text = "Paraglider Pattern:";
            // 
            // paragliderPatternBox
            // 
            paragliderPatternBox.DropDownStyle = ComboBoxStyle.DropDownList;
            paragliderPatternBox.FormattingEnabled = true;
            paragliderPatternBox.Items.AddRange(new object[] { "Random", "Ordinary Fabric", "Goron Fabric", "Zora Fabric", "Gerudo Fabric", "Royal Hyrulean Fabric", "Zonai Fabric", "Sheikah Fabric", "Yiga Fabric", "Monster-Control-Crew Fabric", "Zonai Survey Team Fabric", "Horse-God Fabric", "Lurelin Village Fabric", "Lucky Clover Gazette Fabric", "Hudson Construction Fabric", "Koltin's Fabric", "Korok Fabric", "Grizzlemaw-Bear Fabric", "Robbie's Fabric", "Cece Fabric", "Aerocuda Fabric", "Eldin-Ostrich Fabric", "Cucco Fabric", "Horse Fabric", "Chuchu Fabric", "Lynel Fabric", "Gleeok Fabric", "Stalnox Fabric" });
            paragliderPatternBox.Location = new Point(128, 12);
            paragliderPatternBox.Name = "paragliderPatternBox";
            paragliderPatternBox.Size = new Size(196, 23);
            paragliderPatternBox.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 10);
            label2.Name = "label2";
            label2.Size = new Size(118, 15);
            label2.TabIndex = 20;
            label2.Text = "Randomizer Settings:";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(weaponsBox);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(natureBox);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(chestsBox);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(enemiesBox);
            panel1.Location = new Point(18, 18);
            panel1.Margin = new Padding(10);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(15);
            panel1.Size = new Size(709, 79);
            panel1.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(418, 44);
            label6.Name = "label6";
            label6.Size = new Size(59, 15);
            label6.TabIndex = 26;
            label6.Text = "Weapons:";
            // 
            // weaponsBox
            // 
            weaponsBox.DropDownStyle = ComboBoxStyle.DropDownList;
            weaponsBox.FormattingEnabled = true;
            weaponsBox.Items.AddRange(new object[] { "Default", "Random" });
            weaponsBox.Location = new Point(483, 41);
            weaponsBox.Name = "weaponsBox";
            weaponsBox.Size = new Size(206, 23);
            weaponsBox.TabIndex = 25;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(431, 15);
            label5.Name = "label5";
            label5.Size = new Size(46, 15);
            label5.TabIndex = 24;
            label5.Text = "Nature:";
            // 
            // natureBox
            // 
            natureBox.DropDownStyle = ComboBoxStyle.DropDownList;
            natureBox.FormattingEnabled = true;
            natureBox.Items.AddRange(new object[] { "Default", "Random" });
            natureBox.Location = new Point(483, 12);
            natureBox.Name = "natureBox";
            natureBox.Size = new Size(206, 23);
            natureBox.TabIndex = 23;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 44);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 22;
            label4.Text = "Chests:";
            // 
            // chestsBox
            // 
            chestsBox.DropDownStyle = ComboBoxStyle.DropDownList;
            chestsBox.FormattingEnabled = true;
            chestsBox.Items.AddRange(new object[] { "Default", "Random" });
            chestsBox.Location = new Point(78, 41);
            chestsBox.Name = "chestsBox";
            chestsBox.Size = new Size(206, 23);
            chestsBox.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 15);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 20;
            label3.Text = "Enemies:";
            // 
            // enemiesBox
            // 
            enemiesBox.DropDownStyle = ComboBoxStyle.DropDownList;
            enemiesBox.FormattingEnabled = true;
            enemiesBox.Items.AddRange(new object[] { "Default", "Random" });
            enemiesBox.Location = new Point(78, 12);
            enemiesBox.Name = "enemiesBox";
            enemiesBox.Size = new Size(206, 23);
            enemiesBox.TabIndex = 19;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(753, 390);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            Text = "TotK Randomizer";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private ProgressBar progressBar1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox textBox1;
        private Label label1;
        private Button button2;
        private CheckBox randomizeEnemies;
        private CheckBox randomizeWeapons;
        private CheckBox randomizeNature;
        private CheckBox randomizeParagliderFabric;
        private CheckBox randomizeChests;
        private CheckBox test;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private Label label2;
        private Panel panel1;
        private Label label3;
        private ComboBox enemiesBox;
        private Label label6;
        private ComboBox weaponsBox;
        private Label label5;
        private ComboBox natureBox;
        private Label label4;
        private ComboBox chestsBox;
        private Label label7;
        private Panel panel2;
        private Label label11;

        private Label label26;
        private Label label26a;
        private Panel panel26;
        private Label label27;
        private Panel panel27;
        private Label label26b;
        private Label label26c;
        private Label label26d;

        private Label label27a;
        private Label label27b;
        private Label label27c;

        private Label label3_1;
        private Label label3_1p;
        private Label label3_2;

        private Label label4_1;
        private Label label4_2;
        private Label label4_3;
        private Label label4_4;
        private Label label4_3a;
        private Label label4_4a;

        private CheckBox checkbox4_3;
        private CheckBox checkbox4_4;
        private NumericUpDown pouchWInt;
        private NumericUpDown pouchBInt;
        private NumericUpDown pouchSInt;
        private ComboBox speedCoeff;
        private ComboBox staminaFloat;
        private ComboBox batteryFloat;
        private ComboBox weaponOnStart;
        private NumericUpDown fairiesInt;
        private NumericUpDown heartsInt;
        private NumericUpDown rupeesInt;
        private ComboBox paragliderPatternBox;
    }
}