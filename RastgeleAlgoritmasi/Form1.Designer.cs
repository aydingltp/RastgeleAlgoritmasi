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
            this.lblSayac = new System.Windows.Forms.Label();
            this.lblDeger = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sure = new System.Windows.Forms.Timer(this.components);
            this.txtTimer = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Button();
            this.btnDurdur = new System.Windows.Forms.Button();
            this.rastgeletimer = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSayac
            // 
            this.lblSayac.AutoSize = true;
            this.lblSayac.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSayac.Location = new System.Drawing.Point(166, 74);
            this.lblSayac.Name = "lblSayac";
            this.lblSayac.Size = new System.Drawing.Size(109, 38);
            this.lblSayac.TabIndex = 0;
            this.lblSayac.Text = "Sayac";
            this.lblSayac.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblDeger
            // 
            this.lblDeger.AutoSize = true;
            this.lblDeger.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDeger.Location = new System.Drawing.Point(496, 74);
            this.lblDeger.Name = "lblDeger";
            this.lblDeger.Size = new System.Drawing.Size(106, 38);
            this.lblDeger.TabIndex = 2;
            this.lblDeger.Text = "Deger";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(355, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "=>";
            // 
            // sure
            // 
            this.sure.Interval = 1000;
            this.sure.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtTimer
            // 
            this.txtTimer.AutoSize = true;
            this.txtTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTimer.Location = new System.Drawing.Point(334, 183);
            this.txtTimer.Name = "txtTimer";
            this.txtTimer.Size = new System.Drawing.Size(89, 38);
            this.txtTimer.TabIndex = 4;
            this.txtTimer.Text = "timer";
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.SystemColors.Highlight;
            this.start.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.start.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.start.Location = new System.Drawing.Point(12, 12);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(132, 49);
            this.start.TabIndex = 5;
            this.start.Text = "Başla";
            this.start.UseVisualStyleBackColor = false;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // btnDurdur
            // 
            this.btnDurdur.BackColor = System.Drawing.Color.Red;
            this.btnDurdur.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDurdur.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDurdur.Location = new System.Drawing.Point(171, 12);
            this.btnDurdur.Name = "btnDurdur";
            this.btnDurdur.Size = new System.Drawing.Size(138, 49);
            this.btnDurdur.TabIndex = 6;
            this.btnDurdur.Text = "Durdur";
            this.btnDurdur.UseVisualStyleBackColor = false;
            this.btnDurdur.Click += new System.EventHandler(this.btnDurdur_Click);
            // 
            // rastgeletimer
            // 
            this.rastgeletimer.Interval = 1;
            this.rastgeletimer.Tick += new System.EventHandler(this.rastgeletimer_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(88, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 38);
            this.label2.TabIndex = 7;
            this.label2.Text = "Sonuç :";
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSonuc.ForeColor = System.Drawing.Color.Red;
            this.lblSonuc.Location = new System.Drawing.Point(222, 301);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(0, 38);
            this.lblSonuc.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDurdur);
            this.Controls.Add(this.start);
            this.Controls.Add(this.txtTimer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDeger);
            this.Controls.Add(this.lblSayac);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSayac;
        private System.Windows.Forms.Label lblDeger;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer sure;
        private System.Windows.Forms.Label txtTimer;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button btnDurdur;
        private System.Windows.Forms.Timer rastgeletimer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSonuc;
    }
}

