namespace i_rely_solely_on_god
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
            this.PicFirst = new System.Windows.Forms.PictureBox();
            this.Picresult = new System.Windows.Forms.PictureBox();
            this.level = new System.Windows.Forms.Label();
            this.histogram = new IPLab.Histogram();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.face1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.colorSlider = new IPLab.ColorSlider();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.PicFirst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picresult)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.face1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // PicFirst
            // 
            this.PicFirst.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PicFirst.Location = new System.Drawing.Point(6, 16);
            this.PicFirst.Name = "PicFirst";
            this.PicFirst.Size = new System.Drawing.Size(149, 154);
            this.PicFirst.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicFirst.TabIndex = 0;
            this.PicFirst.TabStop = false;
            // 
            // Picresult
            // 
            this.Picresult.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Picresult.Location = new System.Drawing.Point(161, 16);
            this.Picresult.Name = "Picresult";
            this.Picresult.Size = new System.Drawing.Size(149, 154);
            this.Picresult.TabIndex = 1;
            this.Picresult.TabStop = false;
            // 
            // level
            // 
            this.level.AutoSize = true;
            this.level.Location = new System.Drawing.Point(17, 15);
            this.level.Name = "level";
            this.level.Size = new System.Drawing.Size(42, 13);
            this.level.TabIndex = 4;
            this.level.Text = "Level : ";
            // 
            // histogram
            // 
            this.histogram.AllowDrop = true;
            this.histogram.AllowSelection = true;
            this.histogram.BackColor = System.Drawing.Color.White;
            this.histogram.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.histogram.Location = new System.Drawing.Point(10, 16);
            this.histogram.LogView = true;
            this.histogram.Name = "histogram";
            this.histogram.Size = new System.Drawing.Size(262, 162);
            this.histogram.TabIndex = 2;
            this.histogram.Text = "histogram1";
            this.histogram.PositionChanged += new IPLab.Histogram.HistogramEventHandler(this.histogram_PositionChanged);
            this.histogram.SelectionChanged += new IPLab.Histogram.HistogramEventHandler(this.histogram_SelectionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.level);
            this.groupBox1.Location = new System.Drawing.Point(10, 210);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(107, 31);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 221);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(107, 20);
            this.textBox1.TabIndex = 9;
            // 
            // face1
            // 
            this.face1.BackColor = System.Drawing.Color.White;
            this.face1.Location = new System.Drawing.Point(250, 181);
            this.face1.Name = "face1";
            this.face1.Size = new System.Drawing.Size(60, 60);
            this.face1.TabIndex = 10;
            this.face1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(7, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(630, 289);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button2);
            this.groupBox5.Controls.Add(this.button1);
            this.groupBox5.Controls.Add(this.textBox2);
            this.groupBox5.Controls.Add(this.face1);
            this.groupBox5.Controls.Add(this.PicFirst);
            this.groupBox5.Controls.Add(this.textBox1);
            this.groupBox5.Controls.Add(this.Picresult);
            this.groupBox5.Location = new System.Drawing.Point(10, 19);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(324, 259);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Face Detection";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(135, 221);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "تشخيص";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(135, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "انتخاب عكس";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 195);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(107, 20);
            this.textBox2.TabIndex = 11;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Controls.Add(this.colorSlider);
            this.groupBox3.Controls.Add(this.histogram);
            this.groupBox3.Location = new System.Drawing.Point(340, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(284, 259);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Histogram";
            // 
            // colorSlider
            // 
            this.colorSlider.Color2 = System.Drawing.Color.Silver;
            this.colorSlider.Color3 = System.Drawing.Color.White;
            this.colorSlider.DoubleArrow = false;
            this.colorSlider.Location = new System.Drawing.Point(6, 184);
            this.colorSlider.Name = "colorSlider";
            this.colorSlider.Size = new System.Drawing.Size(262, 20);
            this.colorSlider.TabIndex = 3;
            this.colorSlider.Text = "colorSlider1";
            this.colorSlider.ValuesChanged += new System.EventHandler(this.colorSlider_ValuesChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox4.Controls.Add(this.groupBox2);
            this.groupBox4.Location = new System.Drawing.Point(-5, -8);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(652, 320);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 288);
            this.Controls.Add(this.groupBox4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicFirst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picresult)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.face1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PicFirst;
        private System.Windows.Forms.PictureBox Picresult;
        private IPLab.Histogram histogram;
        private System.Windows.Forms.Label level;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox face1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private IPLab.ColorSlider colorSlider;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

