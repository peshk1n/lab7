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
            this.икосаэдрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.кубToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 28);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(864, 745);
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
            this.panel1.Location = new System.Drawing.Point(664, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 745);
            this.panel1.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(22, 727);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 28);
            this.comboBox1.TabIndex = 39;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtAngle
            // 
            this.txtAngle.Location = new System.Drawing.Point(61, 682);
            this.txtAngle.Name = "txtAngle";
            this.txtAngle.Size = new System.Drawing.Size(114, 27);
            this.txtAngle.TabIndex = 38;
            this.txtAngle.Text = "0";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(12, 685);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(44, 20);
            this.label19.TabIndex = 37;
            this.label19.Text = "Угол:";
            // 
            // secondPointZ
            // 
            this.secondPointZ.Location = new System.Drawing.Point(136, 640);
            this.secondPointZ.Name = "secondPointZ";
            this.secondPointZ.Size = new System.Drawing.Size(39, 27);
            this.secondPointZ.TabIndex = 36;
            // 
            // secondPointY
            // 
            this.secondPointY.Location = new System.Drawing.Point(93, 640);
            this.secondPointY.Name = "secondPointY";
            this.secondPointY.Size = new System.Drawing.Size(39, 27);
            this.secondPointY.TabIndex = 35;
            // 
            // secondPointX
            // 
            this.secondPointX.Location = new System.Drawing.Point(50, 640);
            this.secondPointX.Name = "secondPointX";
            this.secondPointX.Size = new System.Drawing.Size(39, 27);
            this.secondPointX.TabIndex = 34;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(14, 643);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(29, 20);
            this.label18.TabIndex = 33;
            this.label18.Text = "p2:";
            // 
            // firstPointZ
            // 
            this.firstPointZ.Location = new System.Drawing.Point(136, 607);
            this.firstPointZ.Name = "firstPointZ";
            this.firstPointZ.Size = new System.Drawing.Size(39, 27);
            this.firstPointZ.TabIndex = 32;
            // 
            // firstPointY
            // 
            this.firstPointY.Location = new System.Drawing.Point(93, 607);
            this.firstPointY.Name = "firstPointY";
            this.firstPointY.Size = new System.Drawing.Size(39, 27);
            this.firstPointY.TabIndex = 31;
            // 
            // firstPointX
            // 
            this.firstPointX.Location = new System.Drawing.Point(50, 607);
            this.firstPointX.Name = "firstPointX";
            this.firstPointX.Size = new System.Drawing.Size(39, 27);
            this.firstPointX.TabIndex = 30;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(145, 583);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(18, 20);
            this.label17.TabIndex = 29;
            this.label17.Text = "Z";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(103, 583);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(17, 20);
            this.label16.TabIndex = 28;
            this.label16.Text = "Y";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(61, 583);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(18, 20);
            this.label15.TabIndex = 27;
            this.label15.Text = "X";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(14, 610);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 20);
            this.label14.TabIndex = 26;
            this.label14.Text = "p1:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 550);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(179, 20);
            this.label13.TabIndex = 25;
            this.label13.Text = "Поворот вокруг прямой";
            // 
            // cbFlipYZ
            // 
            this.cbFlipYZ.AutoSize = true;
            this.cbFlipYZ.Location = new System.Drawing.Point(25, 499);
            this.cbFlipYZ.Name = "cbFlipYZ";
            this.cbFlipYZ.Size = new System.Drawing.Size(138, 24);
            this.cbFlipYZ.TabIndex = 23;
            this.cbFlipYZ.Text = "Отразить по YZ";
            this.cbFlipYZ.UseVisualStyleBackColor = true;
            this.cbFlipYZ.CheckedChanged += new System.EventHandler(this.cbFlipYZ_CheckedChanged);
            // 
            // cbFlipXZ
            // 
            this.cbFlipXZ.AutoSize = true;
            this.cbFlipXZ.Location = new System.Drawing.Point(25, 469);
            this.cbFlipXZ.Name = "cbFlipXZ";
            this.cbFlipXZ.Size = new System.Drawing.Size(139, 24);
            this.cbFlipXZ.TabIndex = 22;
            this.cbFlipXZ.Text = "Отразить по XZ";
            this.cbFlipXZ.UseVisualStyleBackColor = true;
            this.cbFlipXZ.CheckedChanged += new System.EventHandler(this.cbFlipXZ_CheckedChanged);
            // 
            // cbFlipXY
            // 
            this.cbFlipXY.AutoSize = true;
            this.cbFlipXY.Location = new System.Drawing.Point(25, 439);
            this.cbFlipXY.Name = "cbFlipXY";
            this.cbFlipXY.Size = new System.Drawing.Size(138, 24);
            this.cbFlipXY.TabIndex = 21;
            this.cbFlipXY.Text = "Отразить по XY";
            this.cbFlipXY.UseVisualStyleBackColor = true;
            this.cbFlipXY.CheckedChanged += new System.EventHandler(this.cbFlipXY_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 387);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "Z";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 354);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 20);
            this.label10.TabIndex = 19;
            this.label10.Text = "Y";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(25, 321);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(18, 20);
            this.label11.TabIndex = 18;
            this.label11.Text = "X";
            // 
            // txtScaleZ
            // 
            this.txtScaleZ.Location = new System.Drawing.Point(50, 384);
            this.txtScaleZ.Name = "txtScaleZ";
            this.txtScaleZ.Size = new System.Drawing.Size(125, 27);
            this.txtScaleZ.TabIndex = 17;
            this.txtScaleZ.Text = "1";
            // 
            // txtScaleY
            // 
            this.txtScaleY.Location = new System.Drawing.Point(50, 351);
            this.txtScaleY.Name = "txtScaleY";
            this.txtScaleY.Size = new System.Drawing.Size(125, 27);
            this.txtScaleY.TabIndex = 16;
            this.txtScaleY.Text = "1";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(14, 295);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 20);
            this.label12.TabIndex = 15;
            this.label12.Text = "Масштаб";
            // 
            // txtScaleX
            // 
            this.txtScaleX.Location = new System.Drawing.Point(50, 318);
            this.txtScaleX.Name = "txtScaleX";
            this.txtScaleX.Size = new System.Drawing.Size(125, 27);
            this.txtScaleX.TabIndex = 14;
            this.txtScaleX.Text = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Z";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Y";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "X";
            // 
            // txtRotationZ
            // 
            this.txtRotationZ.Location = new System.Drawing.Point(50, 245);
            this.txtRotationZ.Name = "txtRotationZ";
            this.txtRotationZ.Size = new System.Drawing.Size(125, 27);
            this.txtRotationZ.TabIndex = 10;
            this.txtRotationZ.Text = "0";
            // 
            // txtRotationY
            // 
            this.txtRotationY.Location = new System.Drawing.Point(50, 212);
            this.txtRotationY.Name = "txtRotationY";
            this.txtRotationY.Size = new System.Drawing.Size(125, 27);
            this.txtRotationY.TabIndex = 9;
            this.txtRotationY.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Поворот";
            // 
            // txtRotationX
            // 
            this.txtRotationX.Location = new System.Drawing.Point(50, 179);
            this.txtRotationX.Name = "txtRotationX";
            this.txtRotationX.Size = new System.Drawing.Size(125, 27);
            this.txtRotationX.TabIndex = 7;
            this.txtRotationX.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Z";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Y";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "X";
            // 
            // txtOffsetZ
            // 
            this.txtOffsetZ.Location = new System.Drawing.Point(50, 110);
            this.txtOffsetZ.Name = "txtOffsetZ";
            this.txtOffsetZ.Size = new System.Drawing.Size(125, 27);
            this.txtOffsetZ.TabIndex = 3;
            this.txtOffsetZ.Text = "0";
            // 
            // txtOffsetY
            // 
            this.txtOffsetY.Location = new System.Drawing.Point(50, 77);
            this.txtOffsetY.Name = "txtOffsetY";
            this.txtOffsetY.Size = new System.Drawing.Size(125, 27);
            this.txtOffsetY.TabIndex = 2;
            this.txtOffsetY.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Смещение";
            // 
            // txtOffsetX
            // 
            this.txtOffsetX.Location = new System.Drawing.Point(50, 44);
            this.txtOffsetX.Name = "txtOffsetX";
            this.txtOffsetX.Size = new System.Drawing.Size(125, 27);
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
            this.menuStrip1.Size = new System.Drawing.Size(864, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.открытьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.открытьToolStripMenuItem.Text = "Открыть";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.кубToolStripMenuItem,
            this.икосаэдрToolStripMenuItem});
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            // 
            // икосаэдрToolStripMenuItem
            // 
            this.икосаэдрToolStripMenuItem.Name = "икосаэдрToolStripMenuItem";
            this.икосаэдрToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.икосаэдрToolStripMenuItem.Text = "Икосаэдр";
            // 
            // кубToolStripMenuItem
            // 
            this.кубToolStripMenuItem.Name = "кубToolStripMenuItem";
            this.кубToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.кубToolStripMenuItem.Text = "Куб";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 773);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
    }
}