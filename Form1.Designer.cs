namespace AutoClicker
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelLeviY = new System.Windows.Forms.Label();
            this.labelLeviX = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonPozicijaLeviKlik = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelDrugiY = new System.Windows.Forms.Label();
            this.labelDrugiX = new System.Windows.Forms.Label();
            this.buttonPozicijaDrugiKlik = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.labelSrednjiY = new System.Windows.Forms.Label();
            this.buttonPozicijaSrednjiKlik = new System.Windows.Forms.Button();
            this.labelSrednjiX = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelKlikovi = new System.Windows.Forms.Label();
            this.labelTrajanje = new System.Windows.Forms.Label();
            this.radioButtonVremenskiRad = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSeconds = new System.Windows.Forms.TextBox();
            this.textBoxMinutes = new System.Windows.Forms.TextBox();
            this.textBoxHours = new System.Windows.Forms.TextBox();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.timerLevi = new System.Windows.Forms.Timer(this.components);
            this.timerDesni = new System.Windows.Forms.Timer(this.components);
            this.timerTime = new System.Windows.Forms.Timer(this.components);
            this.timerCounter = new System.Windows.Forms.Timer(this.components);
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.sekundaraTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.timerDrugi = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelLeviY);
            this.groupBox1.Controls.Add(this.labelLeviX);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.buttonPozicijaLeviKlik);
            this.groupBox1.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Prvi klik point";
            // 
            // labelLeviY
            // 
            this.labelLeviY.AutoSize = true;
            this.labelLeviY.Location = new System.Drawing.Point(196, 53);
            this.labelLeviY.Name = "labelLeviY";
            this.labelLeviY.Size = new System.Drawing.Size(13, 13);
            this.labelLeviY.TabIndex = 6;
            this.labelLeviY.Text = "0";
            // 
            // labelLeviX
            // 
            this.labelLeviX.AutoSize = true;
            this.labelLeviX.Location = new System.Drawing.Point(196, 30);
            this.labelLeviX.Name = "labelLeviX";
            this.labelLeviX.Size = new System.Drawing.Size(13, 13);
            this.labelLeviX.TabIndex = 5;
            this.labelLeviX.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(167, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Y:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(167, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "X:";
            // 
            // buttonPozicijaLeviKlik
            // 
            this.buttonPozicijaLeviKlik.ForeColor = System.Drawing.Color.Black;
            this.buttonPozicijaLeviKlik.Location = new System.Drawing.Point(15, 30);
            this.buttonPozicijaLeviKlik.Name = "buttonPozicijaLeviKlik";
            this.buttonPozicijaLeviKlik.Size = new System.Drawing.Size(121, 44);
            this.buttonPozicijaLeviKlik.TabIndex = 0;
            this.buttonPozicijaLeviKlik.Text = "Izaberi poziciju za levi klik";
            this.buttonPozicijaLeviKlik.UseVisualStyleBackColor = true;
            this.buttonPozicijaLeviKlik.Click += new System.EventHandler(this.buttonPozicijaLeviKlik_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelDrugiY);
            this.groupBox2.Controls.Add(this.labelDrugiX);
            this.groupBox2.Controls.Add(this.buttonPozicijaDrugiKlik);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.groupBox2.Location = new System.Drawing.Point(270, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(270, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Drugi klik point";
            // 
            // labelDrugiY
            // 
            this.labelDrugiY.AutoSize = true;
            this.labelDrugiY.Location = new System.Drawing.Point(214, 53);
            this.labelDrugiY.Name = "labelDrugiY";
            this.labelDrugiY.Size = new System.Drawing.Size(13, 13);
            this.labelDrugiY.TabIndex = 10;
            this.labelDrugiY.Text = "0";
            // 
            // labelDrugiX
            // 
            this.labelDrugiX.AutoSize = true;
            this.labelDrugiX.Location = new System.Drawing.Point(214, 30);
            this.labelDrugiX.Name = "labelDrugiX";
            this.labelDrugiX.Size = new System.Drawing.Size(13, 13);
            this.labelDrugiX.TabIndex = 9;
            this.labelDrugiX.Text = "0";
            // 
            // buttonPozicijaDrugiKlik
            // 
            this.buttonPozicijaDrugiKlik.ForeColor = System.Drawing.Color.Black;
            this.buttonPozicijaDrugiKlik.Location = new System.Drawing.Point(16, 30);
            this.buttonPozicijaDrugiKlik.Name = "buttonPozicijaDrugiKlik";
            this.buttonPozicijaDrugiKlik.Size = new System.Drawing.Size(121, 44);
            this.buttonPozicijaDrugiKlik.TabIndex = 1;
            this.buttonPozicijaDrugiKlik.Text = "Izaberi poziciju za drugi klik";
            this.buttonPozicijaDrugiKlik.UseVisualStyleBackColor = true;
            this.buttonPozicijaDrugiKlik.Click += new System.EventHandler(this.buttonPozicijaDrugiKlik_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(185, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "X:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(185, 53);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(17, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "Y:";
            // 
            // labelSrednjiY
            // 
            this.labelSrednjiY.AutoSize = true;
            this.labelSrednjiY.Location = new System.Drawing.Point(199, 53);
            this.labelSrednjiY.Name = "labelSrednjiY";
            this.labelSrednjiY.Size = new System.Drawing.Size(13, 13);
            this.labelSrednjiY.TabIndex = 10;
            this.labelSrednjiY.Text = "0";
            // 
            // buttonPozicijaSrednjiKlik
            // 
            this.buttonPozicijaSrednjiKlik.ForeColor = System.Drawing.Color.Black;
            this.buttonPozicijaSrednjiKlik.Location = new System.Drawing.Point(15, 30);
            this.buttonPozicijaSrednjiKlik.Name = "buttonPozicijaSrednjiKlik";
            this.buttonPozicijaSrednjiKlik.Size = new System.Drawing.Size(121, 44);
            this.buttonPozicijaSrednjiKlik.TabIndex = 1;
            this.buttonPozicijaSrednjiKlik.Text = "Izaberi poziciju za srednji klik";
            this.buttonPozicijaSrednjiKlik.UseVisualStyleBackColor = true;
            this.buttonPozicijaSrednjiKlik.Click += new System.EventHandler(this.buttonPozicijaSrednjiKlik_Click);
            // 
            // labelSrednjiX
            // 
            this.labelSrednjiX.AutoSize = true;
            this.labelSrednjiX.Location = new System.Drawing.Point(199, 30);
            this.labelSrednjiX.Name = "labelSrednjiX";
            this.labelSrednjiX.Size = new System.Drawing.Size(13, 13);
            this.labelSrednjiX.TabIndex = 9;
            this.labelSrednjiX.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(170, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "X:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(170, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Y:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelKlikovi);
            this.groupBox3.Controls.Add(this.labelTrajanje);
            this.groupBox3.Controls.Add(this.radioButtonVremenskiRad);
            this.groupBox3.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.groupBox3.Location = new System.Drawing.Point(12, 118);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(252, 100);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ponavljanje";
            // 
            // labelKlikovi
            // 
            this.labelKlikovi.AutoSize = true;
            this.labelKlikovi.Location = new System.Drawing.Point(134, 64);
            this.labelKlikovi.Name = "labelKlikovi";
            this.labelKlikovi.Size = new System.Drawing.Size(50, 13);
            this.labelKlikovi.TabIndex = 2;
            this.labelKlikovi.Text = "Klikovi: 0";
            // 
            // labelTrajanje
            // 
            this.labelTrajanje.AutoSize = true;
            this.labelTrajanje.Location = new System.Drawing.Point(134, 30);
            this.labelTrajanje.Name = "labelTrajanje";
            this.labelTrajanje.Size = new System.Drawing.Size(93, 13);
            this.labelTrajanje.TabIndex = 1;
            this.labelTrajanje.Text = "Trajanje: 00:00:00";
            // 
            // radioButtonVremenskiRad
            // 
            this.radioButtonVremenskiRad.AutoSize = true;
            this.radioButtonVremenskiRad.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonVremenskiRad.Location = new System.Drawing.Point(21, 42);
            this.radioButtonVremenskiRad.Name = "radioButtonVremenskiRad";
            this.radioButtonVremenskiRad.Size = new System.Drawing.Size(92, 17);
            this.radioButtonVremenskiRad.TabIndex = 0;
            this.radioButtonVremenskiRad.TabStop = true;
            this.radioButtonVremenskiRad.Text = "Vremenski rad";
            this.radioButtonVremenskiRad.UseVisualStyleBackColor = false;
            this.radioButtonVremenskiRad.CheckedChanged += new System.EventHandler(this.radioButtonVremenskiRad_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.textBoxSeconds);
            this.groupBox4.Controls.Add(this.textBoxMinutes);
            this.groupBox4.Controls.Add(this.textBoxHours);
            this.groupBox4.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.groupBox4.Location = new System.Drawing.Point(546, 118);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(252, 100);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Vremenski rad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.label3.Location = new System.Drawing.Point(61, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Broj Klikova:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.label2.Location = new System.Drawing.Point(144, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Minuti:";
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.label1.Location = new System.Drawing.Point(34, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sati:";
            this.label1.Visible = false;
            // 
            // textBoxSeconds
            // 
            this.textBoxSeconds.Location = new System.Drawing.Point(137, 42);
            this.textBoxSeconds.Name = "textBoxSeconds";
            this.textBoxSeconds.Size = new System.Drawing.Size(50, 20);
            this.textBoxSeconds.TabIndex = 2;
            this.textBoxSeconds.Text = "0";
            this.textBoxSeconds.TextChanged += new System.EventHandler(this.textBoxSeconds_TextChanged);
            // 
            // textBoxMinutes
            // 
            this.textBoxMinutes.Location = new System.Drawing.Point(199, 19);
            this.textBoxMinutes.Name = "textBoxMinutes";
            this.textBoxMinutes.Size = new System.Drawing.Size(50, 20);
            this.textBoxMinutes.TabIndex = 1;
            this.textBoxMinutes.Text = "0";
            this.textBoxMinutes.Visible = false;
            this.textBoxMinutes.TextChanged += new System.EventHandler(this.textBoxMinutes_TextChanged);
            // 
            // textBoxHours
            // 
            this.textBoxHours.Location = new System.Drawing.Point(77, 19);
            this.textBoxHours.Name = "textBoxHours";
            this.textBoxHours.Size = new System.Drawing.Size(50, 20);
            this.textBoxHours.TabIndex = 0;
            this.textBoxHours.Text = "0";
            this.textBoxHours.Visible = false;
            this.textBoxHours.TextChanged += new System.EventHandler(this.textBoxHours_TextChanged);
            // 
            // buttonStop
            // 
            this.buttonStop.ForeColor = System.Drawing.Color.Black;
            this.buttonStop.Location = new System.Drawing.Point(339, 30);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(121, 44);
            this.buttonStop.TabIndex = 5;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.ForeColor = System.Drawing.Color.Black;
            this.buttonStart.Location = new System.Drawing.Point(97, 30);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(121, 44);
            this.buttonStart.TabIndex = 4;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.buttonStop);
            this.groupBox5.Controls.Add(this.buttonStart);
            this.groupBox5.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.groupBox5.Location = new System.Drawing.Point(125, 224);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(548, 100);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Funkcije ";
            // 
            // timerLevi
            // 
            this.timerLevi.Interval = 1000;
            this.timerLevi.Tick += new System.EventHandler(this.timerLevi_Tick);
            // 
            // timerDesni
            // 
            this.timerDesni.Interval = 1000;
            this.timerDesni.Tick += new System.EventHandler(this.timerDesni_Tick);
            // 
            // timerTime
            // 
            this.timerTime.Interval = 1000;
            this.timerTime.Tick += new System.EventHandler(this.timerTime_Tick);
            // 
            // timerCounter
            // 
            this.timerCounter.Interval = 1000;
            this.timerCounter.Tick += new System.EventHandler(this.timerCounter_Tick);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.sekundaraTextBox);
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.groupBox6.Location = new System.Drawing.Point(270, 118);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(270, 100);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Trajanje do sledećeg klika";
            // 
            // sekundaraTextBox
            // 
            this.sekundaraTextBox.Location = new System.Drawing.Point(158, 43);
            this.sekundaraTextBox.Name = "sekundaraTextBox";
            this.sekundaraTextBox.Size = new System.Drawing.Size(50, 20);
            this.sekundaraTextBox.TabIndex = 6;
            this.sekundaraTextBox.Text = "0";
            this.sekundaraTextBox.TextChanged += new System.EventHandler(this.sekundaraTextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Trajanje u sekundama:";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.buttonPozicijaSrednjiKlik);
            this.groupBox7.Controls.Add(this.labelSrednjiY);
            this.groupBox7.Controls.Add(this.label8);
            this.groupBox7.Controls.Add(this.labelSrednjiX);
            this.groupBox7.Controls.Add(this.label9);
            this.groupBox7.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.groupBox7.Location = new System.Drawing.Point(546, 12);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(253, 100);
            this.groupBox7.TabIndex = 11;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Treći klik point";
            // 
            // timerDrugi
            // 
            this.timerDrugi.Interval = 1000;
            this.timerDrugi.Tick += new System.EventHandler(this.timerDrugi_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(811, 347);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auto Clicker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonPozicijaLeviKlik;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonPozicijaSrednjiKlik;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButtonVremenskiRad;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBoxSeconds;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label labelLeviX;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelLeviY;
        private System.Windows.Forms.Label labelSrednjiY;
        private System.Windows.Forms.Label labelSrednjiX;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.Timer timerLevi;
        public System.Windows.Forms.Timer timerDesni;
        private System.Windows.Forms.Timer timerTime;
        private System.Windows.Forms.Label labelKlikovi;
        private System.Windows.Forms.Label labelTrajanje;
        private System.Windows.Forms.Timer timerCounter;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox sekundaraTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxMinutes;
        private System.Windows.Forms.TextBox textBoxHours;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label labelDrugiY;
        private System.Windows.Forms.Button buttonPozicijaDrugiKlik;
        private System.Windows.Forms.Label labelDrugiX;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.Timer timerDrugi;
    }
}

