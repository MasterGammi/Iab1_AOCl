namespace WindowsFormsApp1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.button1 = new System.Windows.Forms.Button();
            this.imageBox2 = new Emgu.CV.UI.ImageBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.button9 = new System.Windows.Forms.Button();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            this.SuspendLayout();
            // 
            // imageBox1
            // 
            this.imageBox1.Location = new System.Drawing.Point(12, 12);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(640, 480);
            this.imageBox1.TabIndex = 2;
            this.imageBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(669, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Load";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // imageBox2
            // 
            this.imageBox2.Location = new System.Drawing.Point(756, 10);
            this.imageBox2.Name = "imageBox2";
            this.imageBox2.Size = new System.Drawing.Size(640, 480);
            this.imageBox2.TabIndex = 2;
            this.imageBox2.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(669, 39);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "B/W";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(669, 68);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Canny";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(669, 97);
            this.trackBar1.Maximum = 200;
            this.trackBar1.Minimum = 10;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(75, 45);
            this.trackBar1.TabIndex = 6;
            this.trackBar1.Value = 10;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(667, 132);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(77, 24);
            this.button4.TabIndex = 7;
            this.button4.Text = "Blue";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(667, 162);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(77, 24);
            this.button5.TabIndex = 8;
            this.button5.Text = "Red";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(667, 192);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(77, 24);
            this.button6.TabIndex = 9;
            this.button6.Text = "Green";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(667, 222);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(77, 25);
            this.button7.TabIndex = 10;
            this.button7.Text = "Sepia";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(667, 253);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(77, 24);
            this.button8.TabIndex = 11;
            this.button8.Text = "Contrast";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(674, 283);
            this.trackBar2.Maximum = 3;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(60, 45);
            this.trackBar2.TabIndex = 12;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(667, 334);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(77, 25);
            this.button9.TabIndex = 13;
            this.button9.Text = "Brightness";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // trackBar3
            // 
            this.trackBar3.Location = new System.Drawing.Point(674, 365);
            this.trackBar3.Maximum = 50;
            this.trackBar3.Minimum = -50;
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(60, 45);
            this.trackBar3.TabIndex = 14;
            this.trackBar3.Scroll += new System.EventHandler(this.trackBar3_Scroll);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(12, 498);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(69, 22);
            this.button10.TabIndex = 15;
            this.button10.Text = "+Blue";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(87, 498);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(69, 22);
            this.button11.TabIndex = 16;
            this.button11.Text = "+Green";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(162, 498);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(69, 22);
            this.button12.TabIndex = 17;
            this.button12.Text = "+Red";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(237, 498);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(69, 22);
            this.button13.TabIndex = 18;
            this.button13.Text = "-Blue";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(312, 498);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(69, 22);
            this.button14.TabIndex = 19;
            this.button14.Text = "-Green";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(387, 498);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(69, 22);
            this.button15.TabIndex = 20;
            this.button15.Text = "-Red";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(667, 400);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(77, 23);
            this.button16.TabIndex = 21;
            this.button16.Text = "HSV";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(669, 429);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(75, 25);
            this.button17.TabIndex = 22;
            this.button17.Text = "Blur";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(667, 460);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(77, 23);
            this.button18.TabIndex = 23;
            this.button18.Text = "Sharp";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(667, 489);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(77, 25);
            this.button19.TabIndex = 24;
            this.button19.Text = "Embos";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1408, 527);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.trackBar3);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.imageBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.imageBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Emgu.CV.UI.ImageBox imageBox1;
        private System.Windows.Forms.Button button1;
        private Emgu.CV.UI.ImageBox imageBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
    }
}

