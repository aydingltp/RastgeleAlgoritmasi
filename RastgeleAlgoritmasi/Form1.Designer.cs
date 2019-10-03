namespace RastgeleAlgoritmasi
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
            this.Sayac = new System.Windows.Forms.Label();
            this.Deger = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txttimer = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Sayac
            // 
            this.Sayac.AutoSize = true;
            this.Sayac.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Sayac.Location = new System.Drawing.Point(216, 74);
            this.Sayac.Name = "Sayac";
            this.Sayac.Size = new System.Drawing.Size(112, 39);
            this.Sayac.TabIndex = 0;
            this.Sayac.Text = "Sayac";
            this.Sayac.Click += new System.EventHandler(this.label1_Click);
            // 
            // Deger
            // 
            this.Deger.AutoSize = true;
            this.Deger.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Deger.Location = new System.Drawing.Point(443, 74);
            this.Deger.Name = "Deger";
            this.Deger.Size = new System.Drawing.Size(110, 39);
            this.Deger.TabIndex = 2;
            this.Deger.Text = "Deger";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(355, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "=>";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txttimer
            // 
            this.txttimer.AutoSize = true;
            this.txttimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txttimer.Location = new System.Drawing.Point(334, 183);
            this.txttimer.Name = "txttimer";
            this.txttimer.Size = new System.Drawing.Size(92, 39);
            this.txttimer.TabIndex = 4;
            this.txttimer.Text = "timer";
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.SystemColors.Highlight;
            this.start.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.start.Location = new System.Drawing.Point(12, 12);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(104, 49);
            this.start.TabIndex = 5;
            this.start.Text = "Başla";
            this.start.UseVisualStyleBackColor = false;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.start);
            this.Controls.Add(this.txttimer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Deger);
            this.Controls.Add(this.Sayac);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Sayac;
        private System.Windows.Forms.Label Deger;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label txttimer;
        private System.Windows.Forms.Button start;
    }
}

