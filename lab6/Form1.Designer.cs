namespace lab6
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtAngle = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.secondPointZ = new System.Windows.Forms.TextBox();
            this.secondPointY = new System.Windows.Forms.TextBox();
            this.secondPointX = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.firstPointZ = new System.Windows.Forms.TextBox();
            this.firstPointY = new System.Windows.Forms.TextBox();
            this.firstPointX = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cbFlipYZ = new System.Windows.Forms.CheckBox();
            this.cbFlipXZ = new System.Windows.Forms.CheckBox();
            this.cbFlipXY = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtScaleZ = new System.Windows.Forms.TextBox();
            this.txtScaleY = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtScaleX = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRotationZ = new System.Windows.Forms.TextBox();
            this.txtRotationY = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtRotationX = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOffsetZ = new System.Windows.Forms.TextBox();
            this.txtOffsetY = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOffsetX = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.кубToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.икосаэдрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фигураВращенияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.додекаэдрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.create_fig = new System.Windows.Forms.Button();
            this.panel_points = new System.Windows.Forms.Panel();
            this.cnt_points = new System.Windows.Forms.TextBox();
            this.tbCnt = new System.Windows.Forms.TextBox();
            this.cbX = new System.Windows.Forms.CheckBox();
            this.cbY = new System.Windows.Forms.CheckBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 53);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1836, 1532);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.txtAngle);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.secondPointZ);
            this.panel1.Controls.Add(this.secondPointY);
            this.panel1.Controls.Add(this.secondPointX);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.firstPointZ);
            this.panel1.Controls.Add(this.firstPointY);
            this.panel1.Controls.Add(this.firstPointX);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.cbFlipYZ);
            this.panel1.Controls.Add(this.cbFlipXZ);
            this.panel1.Controls.Add(this.cbFlipXY);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txtScaleZ);
            this.panel1.Controls.Add(this.txtScaleY);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.txtScaleX);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtRotationZ);
            this.panel1.Controls.Add(this.txtRotationY);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtRotationX);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtOffsetZ);
            this.panel1.Controls.Add(this.txtOffsetY);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtOffsetX);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1411, 53);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(425, 1532);
            this.panel1.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(47, 1490);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(316, 49);
            this.comboBox1.TabIndex = 39;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtAngle
            // 
            this.txtAngle.Location = new System.Drawing.Point(130, 1398);
            this.txtAngle.Margin = new System.Windows.Forms.Padding(6);
            this.txtAngle.Name = "txtAngle";
            this.txtAngle.Size = new System.Drawing.Size(238, 47);
            this.txtAngle.TabIndex = 38;
            this.txtAngle.Text = "0";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(26, 1404);
            this.label19.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(87, 41);
            this.label19.TabIndex = 37;
            this.label19.Text = "Угол:";
            // 
            // secondPointZ
            // 
            this.secondPointZ.Location = new System.Drawing.Point(289, 1312);
            this.secondPointZ.Margin = new System.Windows.Forms.Padding(6);
            this.secondPointZ.Name = "secondPointZ";
            this.secondPointZ.Size = new System.Drawing.Size(78, 47);
            this.secondPointZ.TabIndex = 36;
            // 
            // secondPointY
            // 
            this.secondPointY.Location = new System.Drawing.Point(198, 1312);
            this.secondPointY.Margin = new System.Windows.Forms.Padding(6);
            this.secondPointY.Name = "secondPointY";
            this.secondPointY.Size = new System.Drawing.Size(78, 47);
            this.secondPointY.TabIndex = 35;
            // 
            // secondPointX
            // 
            this.secondPointX.Location = new System.Drawing.Point(106, 1312);
            this.secondPointX.Margin = new System.Windows.Forms.Padding(6);
            this.secondPointX.Name = "secondPointX";
            this.secondPointX.Size = new System.Drawing.Size(78, 47);
            this.secondPointX.TabIndex = 34;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(30, 1318);
            this.label18.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(59, 41);
            this.label18.TabIndex = 33;
            this.label18.Text = "p2:";
            // 
            // firstPointZ
            // 
            this.firstPointZ.Location = new System.Drawing.Point(289, 1244);
            this.firstPointZ.Margin = new System.Windows.Forms.Padding(6);
            this.firstPointZ.Name = "firstPointZ";
            this.firstPointZ.Size = new System.Drawing.Size(78, 47);
            this.firstPointZ.TabIndex = 32;
            // 
            // firstPointY
            // 
            this.firstPointY.Location = new System.Drawing.Point(198, 1244);
            this.firstPointY.Margin = new System.Windows.Forms.Padding(6);
            this.firstPointY.Name = "firstPointY";
            this.firstPointY.Size = new System.Drawing.Size(78, 47);
            this.firstPointY.TabIndex = 31;
            // 
            // firstPointX
            // 
            this.firstPointX.Location = new System.Drawing.Point(106, 1244);
            this.firstPointX.Margin = new System.Windows.Forms.Padding(6);
            this.firstPointX.Name = "firstPointX";
            this.firstPointX.Size = new System.Drawing.Size(78, 47);
            this.firstPointX.TabIndex = 30;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(308, 1195);
            this.label17.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(35, 41);
            this.label17.TabIndex = 29;
            this.label17.Text = "Z";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(219, 1195);
            this.label16.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(35, 41);
            this.label16.TabIndex = 28;
            this.label16.Text = "Y";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(130, 1195);
            this.label15.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(36, 41);
            this.label15.TabIndex = 27;
            this.label15.Text = "X";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(30, 1250);
            this.label14.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 41);
            this.label14.TabIndex = 26;
            this.label14.Text = "p1:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(26, 1128);
            this.label13.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(354, 41);
            this.label13.TabIndex = 25;
            this.label13.Text = "Поворот вокруг прямой";
            // 
            // cbFlipYZ
            // 
            this.cbFlipYZ.AutoSize = true;
            this.cbFlipYZ.Location = new System.Drawing.Point(53, 1023);
            this.cbFlipYZ.Margin = new System.Windows.Forms.Padding(6);
            this.cbFlipYZ.Name = "cbFlipYZ";
            this.cbFlipYZ.Size = new System.Drawing.Size(266, 45);
            this.cbFlipYZ.TabIndex = 23;
            this.cbFlipYZ.Text = "Отразить по YZ";
            this.cbFlipYZ.UseVisualStyleBackColor = true;
            this.cbFlipYZ.CheckedChanged += new System.EventHandler(this.cbFlipYZ_CheckedChanged);
            // 
            // cbFlipXZ
            // 
            this.cbFlipXZ.AutoSize = true;
            this.cbFlipXZ.Location = new System.Drawing.Point(53, 961);
            this.cbFlipXZ.Margin = new System.Windows.Forms.Padding(6);
            this.cbFlipXZ.Name = "cbFlipXZ";
            this.cbFlipXZ.Size = new System.Drawing.Size(267, 45);
            this.cbFlipXZ.TabIndex = 22;
            this.cbFlipXZ.Text = "Отразить по XZ";
            this.cbFlipXZ.UseVisualStyleBackColor = true;
            this.cbFlipXZ.CheckedChanged += new System.EventHandler(this.cbFlipXZ_CheckedChanged);
            // 
            // cbFlipXY
            // 
            this.cbFlipXY.AutoSize = true;
            this.cbFlipXY.Location = new System.Drawing.Point(53, 900);
            this.cbFlipXY.Margin = new System.Windows.Forms.Padding(6);
            this.cbFlipXY.Name = "cbFlipXY";
            this.cbFlipXY.Size = new System.Drawing.Size(267, 45);
            this.cbFlipXY.TabIndex = 21;
            this.cbFlipXY.Text = "Отразить по XY";
            this.cbFlipXY.UseVisualStyleBackColor = true;
            this.cbFlipXY.CheckedChanged += new System.EventHandler(this.cbFlipXY_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(53, 793);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 41);
            this.label9.TabIndex = 20;
            this.label9.Text = "Z";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(53, 726);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 41);
            this.label10.TabIndex = 19;
            this.label10.Text = "Y";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(53, 658);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 41);
            this.label11.TabIndex = 18;
            this.label11.Text = "X";
            // 
            // txtScaleZ
            // 
            this.txtScaleZ.Location = new System.Drawing.Point(106, 787);
            this.txtScaleZ.Margin = new System.Windows.Forms.Padding(6);
            this.txtScaleZ.Name = "txtScaleZ";
            this.txtScaleZ.Size = new System.Drawing.Size(261, 47);
            this.txtScaleZ.TabIndex = 17;
            this.txtScaleZ.Text = "1";
            // 
            // txtScaleY
            // 
            this.txtScaleY.Location = new System.Drawing.Point(106, 720);
            this.txtScaleY.Margin = new System.Windows.Forms.Padding(6);
            this.txtScaleY.Name = "txtScaleY";
            this.txtScaleY.Size = new System.Drawing.Size(261, 47);
            this.txtScaleY.TabIndex = 16;
            this.txtScaleY.Text = "1";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(30, 605);
            this.label12.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(142, 41);
            this.label12.TabIndex = 15;
            this.label12.Text = "Масштаб";
            // 
            // txtScaleX
            // 
            this.txtScaleX.Location = new System.Drawing.Point(106, 652);
            this.txtScaleX.Margin = new System.Windows.Forms.Padding(6);
            this.txtScaleX.Name = "txtScaleX";
            this.txtScaleX.Size = new System.Drawing.Size(261, 47);
            this.txtScaleX.TabIndex = 14;
            this.txtScaleX.Text = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 508);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 41);
            this.label5.TabIndex = 13;
            this.label5.Text = "Z";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 441);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 41);
            this.label6.TabIndex = 12;
            this.label6.Text = "Y";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(53, 373);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 41);
            this.label7.TabIndex = 11;
            this.label7.Text = "X";
            // 
            // txtRotationZ
            // 
            this.txtRotationZ.Location = new System.Drawing.Point(106, 502);
            this.txtRotationZ.Margin = new System.Windows.Forms.Padding(6);
            this.txtRotationZ.Name = "txtRotationZ";
            this.txtRotationZ.Size = new System.Drawing.Size(261, 47);
            this.txtRotationZ.TabIndex = 10;
            this.txtRotationZ.Text = "0";
            // 
            // txtRotationY
            // 
            this.txtRotationY.Location = new System.Drawing.Point(106, 435);
            this.txtRotationY.Margin = new System.Windows.Forms.Padding(6);
            this.txtRotationY.Name = "txtRotationY";
            this.txtRotationY.Size = new System.Drawing.Size(261, 47);
            this.txtRotationY.TabIndex = 9;
            this.txtRotationY.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 320);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 41);
            this.label8.TabIndex = 8;
            this.label8.Text = "Поворот";
            // 
            // txtRotationX
            // 
            this.txtRotationX.Location = new System.Drawing.Point(106, 367);
            this.txtRotationX.Margin = new System.Windows.Forms.Padding(6);
            this.txtRotationX.Name = "txtRotationX";
            this.txtRotationX.Size = new System.Drawing.Size(261, 47);
            this.txtRotationX.TabIndex = 7;
            this.txtRotationX.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 232);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 41);
            this.label4.TabIndex = 6;
            this.label4.Text = "Z";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 164);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 41);
            this.label3.TabIndex = 5;
            this.label3.Text = "Y";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 41);
            this.label2.TabIndex = 4;
            this.label2.Text = "X";
            // 
            // txtOffsetZ
            // 
            this.txtOffsetZ.Location = new System.Drawing.Point(106, 226);
            this.txtOffsetZ.Margin = new System.Windows.Forms.Padding(6);
            this.txtOffsetZ.Name = "txtOffsetZ";
            this.txtOffsetZ.Size = new System.Drawing.Size(261, 47);
            this.txtOffsetZ.TabIndex = 3;
            this.txtOffsetZ.Text = "0";
            // 
            // txtOffsetY
            // 
            this.txtOffsetY.Location = new System.Drawing.Point(106, 158);
            this.txtOffsetY.Margin = new System.Windows.Forms.Padding(6);
            this.txtOffsetY.Name = "txtOffsetY";
            this.txtOffsetY.Size = new System.Drawing.Size(261, 47);
            this.txtOffsetY.TabIndex = 2;
            this.txtOffsetY.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "Смещение";
            // 
            // txtOffsetX
            // 
            this.txtOffsetX.Location = new System.Drawing.Point(106, 90);
            this.txtOffsetX.Margin = new System.Windows.Forms.Padding(6);
            this.txtOffsetX.Name = "txtOffsetX";
            this.txtOffsetX.Size = new System.Drawing.Size(261, 47);
            this.txtOffsetX.TabIndex = 0;
            this.txtOffsetX.Text = "0";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.добавитьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(13, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(1836, 53);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.открытьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(112, 45);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(329, 54);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(329, 54);
            this.открытьToolStripMenuItem.Text = "Открыть";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.кубToolStripMenuItem,
            this.икосаэдрToolStripMenuItem,
            this.фигураВращенияToolStripMenuItem,
            this.додекаэдрToolStripMenuItem});
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(173, 45);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            // 
            // кубToolStripMenuItem
            // 
            this.кубToolStripMenuItem.Name = "кубToolStripMenuItem";
            this.кубToolStripMenuItem.Size = new System.Drawing.Size(448, 54);
            this.кубToolStripMenuItem.Text = "Куб";
            this.кубToolStripMenuItem.Click += new System.EventHandler(this.кубToolStripMenuItem_Click);
            // 
            // икосаэдрToolStripMenuItem
            // 
            this.икосаэдрToolStripMenuItem.Name = "икосаэдрToolStripMenuItem";
            this.икосаэдрToolStripMenuItem.Size = new System.Drawing.Size(448, 54);
            this.икосаэдрToolStripMenuItem.Text = "Икосаэдр";
            this.икосаэдрToolStripMenuItem.Click += new System.EventHandler(this.икосаэдрToolStripMenuItem_Click);
            // 
            // фигураВращенияToolStripMenuItem
            // 
            this.фигураВращенияToolStripMenuItem.Name = "фигураВращенияToolStripMenuItem";
            this.фигураВращенияToolStripMenuItem.Size = new System.Drawing.Size(448, 54);
            this.фигураВращенияToolStripMenuItem.Text = "Фигура вращения";
            this.фигураВращенияToolStripMenuItem.Click += new System.EventHandler(this.фигураВращенияToolStripMenuItem_Click);
            // 
            // додекаэдрToolStripMenuItem
            // 
            this.додекаэдрToolStripMenuItem.Name = "додекаэдрToolStripMenuItem";
            this.додекаэдрToolStripMenuItem.Size = new System.Drawing.Size(448, 54);
            this.додекаэдрToolStripMenuItem.Text = "Додекаэдр";
            this.додекаэдрToolStripMenuItem.Click += new System.EventHandler(this.додекаэдрToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.create_fig);
            this.panel2.Controls.Add(this.panel_points);
            this.panel2.Controls.Add(this.cnt_points);
            this.panel2.Controls.Add(this.tbCnt);
            this.panel2.Controls.Add(this.cbX);
            this.panel2.Controls.Add(this.cbY);
            this.panel2.Controls.Add(this.label22);
            this.panel2.Controls.Add(this.label21);
            this.panel2.Controls.Add(this.label20);
            this.panel2.Enabled = false;
            this.panel2.Location = new System.Drawing.Point(0, 56);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(395, 602);
            this.panel2.TabIndex = 40;
            this.panel2.Visible = false;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // create_fig
            // 
            this.create_fig.Location = new System.Drawing.Point(3, 538);
            this.create_fig.Name = "create_fig";
            this.create_fig.Size = new System.Drawing.Size(188, 58);
            this.create_fig.TabIndex = 0;
            this.create_fig.Text = "Построить";
            this.create_fig.UseVisualStyleBackColor = true;
            this.create_fig.Click += new System.EventHandler(this.create_fig_Click);
            // 
            // panel_points
            // 
            this.panel_points.Location = new System.Drawing.Point(0, 282);
            this.panel_points.Name = "panel_points";
            this.panel_points.Size = new System.Drawing.Size(324, 250);
            this.panel_points.TabIndex = 44;
            // 
            // cnt_points
            // 
            this.cnt_points.Location = new System.Drawing.Point(216, 229);
            this.cnt_points.Name = "cnt_points";
            this.cnt_points.Size = new System.Drawing.Size(74, 47);
            this.cnt_points.TabIndex = 43;
            this.cnt_points.TextChanged += new System.EventHandler(this.cnt_points_TextChanged);
            // 
            // tbCnt
            // 
            this.tbCnt.Location = new System.Drawing.Point(12, 161);
            this.tbCnt.Name = "tbCnt";
            this.tbCnt.Size = new System.Drawing.Size(250, 47);
            this.tbCnt.TabIndex = 42;
            this.tbCnt.Text = "20";
            // 
            // cbX
            // 
            this.cbX.AutoSize = true;
            this.cbX.Location = new System.Drawing.Point(12, 64);
            this.cbX.Name = "cbX";
            this.cbX.Size = new System.Drawing.Size(74, 45);
            this.cbX.TabIndex = 40;
            this.cbX.Text = "X";
            this.cbX.UseVisualStyleBackColor = true;
            // 
            // cbY
            // 
            this.cbY.AutoSize = true;
            this.cbY.Checked = true;
            this.cbY.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbY.Location = new System.Drawing.Point(92, 64);
            this.cbY.Name = "cbY";
            this.cbY.Size = new System.Drawing.Size(73, 45);
            this.cbY.TabIndex = 41;
            this.cbY.Text = "Y";
            this.cbY.UseVisualStyleBackColor = true;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(12, 223);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(198, 41);
            this.label22.TabIndex = 2;
            this.label22.Text = "Образующая";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(12, 112);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(270, 41);
            this.label21.TabIndex = 1;
            this.label21.Text = "Кол-во разбиений";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(12, 20);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(217, 41);
            this.label20.TabIndex = 0;
            this.label20.Text = "Ось вращения";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1836, 1585);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private TextBox txtOffsetZ;
        private TextBox txtOffsetY;
        private Label label1;
        private TextBox txtOffsetX;
        private Label label2;
        private Label label4;
        private Label label3;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox txtScaleZ;
        private TextBox txtScaleY;
        private Label label12;
        private TextBox txtScaleX;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtRotationZ;
        private TextBox txtRotationY;
        private Label label8;
        private TextBox txtRotationX;
        private CheckBox cbFlipYZ;
        private CheckBox cbFlipXZ;
        private CheckBox cbFlipXY;
        private TextBox firstPointZ;
        private TextBox firstPointY;
        private TextBox firstPointX;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private TextBox secondPointZ;
        private TextBox secondPointY;
        private TextBox secondPointX;
        private Label label18;
        private Label label19;
        private TextBox txtAngle;
        private ComboBox comboBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem сохранитьToolStripMenuItem;
        private ToolStripMenuItem открытьToolStripMenuItem;
        private ToolStripMenuItem добавитьToolStripMenuItem;
        private ToolStripMenuItem икосаэдрToolStripMenuItem;
        private ToolStripMenuItem кубToolStripMenuItem;
        private Panel panel2;
        private TextBox tbCnt;
        private CheckBox cbX;
        private CheckBox cbY;
        private Label label22;
        private Label label21;
        private Label label20;
        private TextBox cnt_points;
        private Panel panel_points;
        private Button create_fig;
        private ToolStripMenuItem фигураВращенияToolStripMenuItem;
        private ToolStripMenuItem додекаэдрToolStripMenuItem;
    }
}