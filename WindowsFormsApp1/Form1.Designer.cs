namespace WindowsFormsApp1
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
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.TBCounter = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Output1 = new System.Windows.Forms.Label();
            this.timeTaken = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.TBCounter2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.Output2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.T = new System.Windows.Forms.Label();
            this.Warning = new System.Windows.Forms.Label();
            this.Code = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 10;
            this.trackBar1.Location = new System.Drawing.Point(25, 48);
            this.trackBar1.Maximum = 90;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(259, 45);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // TBCounter
            // 
            this.TBCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBCounter.Location = new System.Drawing.Point(25, 93);
            this.TBCounter.Name = "TBCounter";
            this.TBCounter.Size = new System.Drawing.Size(246, 34);
            this.TBCounter.TabIndex = 1;
            this.TBCounter.Text = "0";
            this.TBCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(308, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 58);
            this.button1.TabIndex = 2;
            this.button1.Text = "Run";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Output1
            // 
            this.Output1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Output1.Location = new System.Drawing.Point(411, 66);
            this.Output1.Name = "Output1";
            this.Output1.Size = new System.Drawing.Size(301, 42);
            this.Output1.TabIndex = 3;
            this.Output1.Text = "Out: ";
            this.Output1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Output1.Visible = false;
            // 
            // timeTaken
            // 
            this.timeTaken.Location = new System.Drawing.Point(411, 104);
            this.timeTaken.Name = "timeTaken";
            this.timeTaken.Size = new System.Drawing.Size(377, 12);
            this.timeTaken.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(763, 33);
            this.label1.TabIndex = 5;
            this.label1.Text = "C# Fibonacci Sequence (Slower) (90)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // trackBar2
            // 
            this.trackBar2.LargeChange = 10;
            this.trackBar2.Location = new System.Drawing.Point(25, 258);
            this.trackBar2.Maximum = 93;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(259, 45);
            this.trackBar2.TabIndex = 6;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // TBCounter2
            // 
            this.TBCounter2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBCounter2.Location = new System.Drawing.Point(25, 303);
            this.TBCounter2.Name = "TBCounter2";
            this.TBCounter2.Size = new System.Drawing.Size(246, 34);
            this.TBCounter2.TabIndex = 7;
            this.TBCounter2.Text = "0";
            this.TBCounter2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(308, 268);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 58);
            this.button2.TabIndex = 8;
            this.button2.Text = "Run";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Output2
            // 
            this.Output2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Output2.Location = new System.Drawing.Point(411, 276);
            this.Output2.Name = "Output2";
            this.Output2.Size = new System.Drawing.Size(301, 42);
            this.Output2.TabIndex = 9;
            this.Output2.Text = "Out: ";
            this.Output2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Output2.Visible = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(763, 33);
            this.label2.TabIndex = 10;
            this.label2.Text = "C++ Fibonacci Sequence (Faster) (93)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // T
            // 
            this.T.Location = new System.Drawing.Point(395, 314);
            this.T.Name = "T";
            this.T.Size = new System.Drawing.Size(377, 12);
            this.T.TabIndex = 11;
            // 
            // Warning
            // 
            this.Warning.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Warning.ForeColor = System.Drawing.Color.Red;
            this.Warning.Location = new System.Drawing.Point(200, 203);
            this.Warning.Name = "Warning";
            this.Warning.Size = new System.Drawing.Size(334, 22);
            this.Warning.TabIndex = 12;
            this.Warning.Text = "/!\\ Warning, \"mytestlib.dll\" must be in sys32";
            this.Warning.Visible = false;
            // 
            // Code
            // 
            this.Code.Cursor = System.Windows.Forms.Cursors.Help;
            this.Code.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Code.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Code.Location = new System.Drawing.Point(686, 31);
            this.Code.Name = "Code";
            this.Code.Size = new System.Drawing.Size(85, 84);
            this.Code.TabIndex = 13;
            this.Code.Text = "Code";
            this.Code.UseVisualStyleBackColor = true;
            this.Code.Click += new System.EventHandler(this.Code_Click);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Help;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(686, 121);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(85, 84);
            this.button3.TabIndex = 14;
            this.button3.Text = "Magic 8 Ball";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Help;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(687, 211);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(85, 84);
            this.button4.TabIndex = 15;
            this.button4.Text = "Free Choice";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Cursor = System.Windows.Forms.Cursors.Help;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(687, 303);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(85, 84);
            this.button5.TabIndex = 16;
            this.button5.Text = "DLL Not Found";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Code);
            this.Controls.Add(this.Warning);
            this.Controls.Add(this.T);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Output2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.TBCounter2);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.timeTaken);
            this.Controls.Add(this.Output1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TBCounter);
            this.Controls.Add(this.trackBar1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;

        private System.Windows.Forms.Button Code;

        private System.Windows.Forms.Label Warning;

        private System.Windows.Forms.Label T;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Output2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label TBCounter2;
        private System.Windows.Forms.TrackBar trackBar2;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Label timeTaken;

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Output1;

        private System.Windows.Forms.Label TBCounter;

        private System.Windows.Forms.TrackBar trackBar1;

        #endregion
    }
}