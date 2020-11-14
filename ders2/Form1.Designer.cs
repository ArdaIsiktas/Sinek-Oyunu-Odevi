namespace ders2
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
            this.btnsayi1 = new System.Windows.Forms.Button();
            this.btnsayi2 = new System.Windows.Forms.Button();
            this.btnsayi3 = new System.Windows.Forms.Button();
            this.btnsonuc = new System.Windows.Forms.Button();
            this.tmrbutton = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnsayi1
            // 
            this.btnsayi1.Location = new System.Drawing.Point(320, 80);
            this.btnsayi1.Name = "btnsayi1";
            this.btnsayi1.Size = new System.Drawing.Size(81, 29);
            this.btnsayi1.TabIndex = 0;
            this.btnsayi1.Text = "button1";
            this.btnsayi1.UseVisualStyleBackColor = true;
            this.btnsayi1.Click += new System.EventHandler(this.NumberClick);
            // 
            // btnsayi2
            // 
            this.btnsayi2.Location = new System.Drawing.Point(320, 141);
            this.btnsayi2.Name = "btnsayi2";
            this.btnsayi2.Size = new System.Drawing.Size(81, 42);
            this.btnsayi2.TabIndex = 1;
            this.btnsayi2.Text = "button2";
            this.btnsayi2.UseVisualStyleBackColor = true;
            this.btnsayi2.Click += new System.EventHandler(this.NumberClick);
            // 
            // btnsayi3
            // 
            this.btnsayi3.Location = new System.Drawing.Point(320, 213);
            this.btnsayi3.Name = "btnsayi3";
            this.btnsayi3.Size = new System.Drawing.Size(81, 38);
            this.btnsayi3.TabIndex = 2;
            this.btnsayi3.Text = "button3";
            this.btnsayi3.UseVisualStyleBackColor = true;
            // 
            // btnsonuc
            // 
            this.btnsonuc.Location = new System.Drawing.Point(287, 279);
            this.btnsonuc.Name = "btnsonuc";
            this.btnsonuc.Size = new System.Drawing.Size(146, 47);
            this.btnsonuc.TabIndex = 3;
            this.btnsonuc.Text = "sonucu göster";
            this.btnsonuc.UseVisualStyleBackColor = true;
            this.btnsonuc.Click += new System.EventHandler(this.btnsonuc_Click);
            // 
            // tmrbutton
            // 
            this.tmrbutton.Interval = 10000;
            this.tmrbutton.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 405);
            this.Controls.Add(this.btnsonuc);
            this.Controls.Add(this.btnsayi3);
            this.Controls.Add(this.btnsayi2);
            this.Controls.Add(this.btnsayi1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnsayi1;
        private System.Windows.Forms.Button btnsayi2;
        private System.Windows.Forms.Button btnsayi3;
        private System.Windows.Forms.Button btnsonuc;
        private System.Windows.Forms.Timer tmrbutton;
    }
}

