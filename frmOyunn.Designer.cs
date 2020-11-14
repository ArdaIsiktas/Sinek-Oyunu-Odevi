namespace ders2
{
    partial class frmOyunn
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
            this.tmrButton = new System.Windows.Forms.Timer(this.components);
            this.pnlGosterge = new System.Windows.Forms.Panel();
            this.lblSure = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.tmrSure = new System.Windows.Forms.Timer(this.components);
            this.btnBaslat = new System.Windows.Forms.Button();
            this.btnBitir = new System.Windows.Forms.Button();
            this.pnlGosterge.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmrButton
            // 
            this.tmrButton.Interval = 1000;
            this.tmrButton.Tick += new System.EventHandler(this.tmrButton_Tick);
            // 
            // pnlGosterge
            // 
            this.pnlGosterge.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlGosterge.Controls.Add(this.btnBitir);
            this.pnlGosterge.Controls.Add(this.lblSure);
            this.pnlGosterge.Controls.Add(this.btnBaslat);
            this.pnlGosterge.Controls.Add(this.lblScore);
            this.pnlGosterge.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlGosterge.Location = new System.Drawing.Point(600, 0);
            this.pnlGosterge.Name = "pnlGosterge";
            this.pnlGosterge.Size = new System.Drawing.Size(200, 450);
            this.pnlGosterge.TabIndex = 0;
            // 
            // lblSure
            // 
            this.lblSure.AutoSize = true;
            this.lblSure.Location = new System.Drawing.Point(3, 8);
            this.lblSure.Name = "lblSure";
            this.lblSure.Size = new System.Drawing.Size(81, 13);
            this.lblSure.TabIndex = 1;
            this.lblSure.Text = "Kalan Süreniz : ";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(3, 42);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(61, 13);
            this.lblScore.TabIndex = 0;
            this.lblScore.Text = "Skorunuz : ";
            // 
            // tmrSure
            // 
            this.tmrSure.Interval = 1000;
            this.tmrSure.Tick += new System.EventHandler(this.tmrSure_Tick);
            // 
            // btnBaslat
            // 
            this.btnBaslat.ForeColor = System.Drawing.Color.DarkRed;
            this.btnBaslat.Location = new System.Drawing.Point(6, 114);
            this.btnBaslat.Name = "btnBaslat";
            this.btnBaslat.Size = new System.Drawing.Size(75, 23);
            this.btnBaslat.TabIndex = 1;
            this.btnBaslat.Text = "Başlat";
            this.btnBaslat.UseVisualStyleBackColor = true;
            this.btnBaslat.Click += new System.EventHandler(this.btnBaslat_Click);
            // 
            // btnBitir
            // 
            this.btnBitir.ForeColor = System.Drawing.Color.DarkRed;
            this.btnBitir.Location = new System.Drawing.Point(98, 114);
            this.btnBitir.Name = "btnBitir";
            this.btnBitir.Size = new System.Drawing.Size(75, 23);
            this.btnBitir.TabIndex = 2;
            this.btnBitir.Text = "Bitir";
            this.btnBitir.UseVisualStyleBackColor = true;
            this.btnBitir.Click += new System.EventHandler(this.btnBitir_Click);
            // 
            // frmOyunn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlGosterge);
            this.Name = "frmOyunn";
            this.Text = "frmOyunn";
            this.Load += new System.EventHandler(this.frmOyunn_Load);
            this.pnlGosterge.ResumeLayout(false);
            this.pnlGosterge.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tmrButton;
        private System.Windows.Forms.Panel pnlGosterge;
        private System.Windows.Forms.Label lblSure;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Timer tmrSure;
        private System.Windows.Forms.Button btnBitir;
        private System.Windows.Forms.Button btnBaslat;
    }
}