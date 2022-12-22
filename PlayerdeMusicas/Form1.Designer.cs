namespace PlayerdeMusicas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.retroceder = new System.Windows.Forms.Button();
            this.avancar = new System.Windows.Forms.Button();
            this.adicionar_musica = new System.Windows.Forms.Button();
            this.sair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(241)))));
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 22;
            this.listBox1.Location = new System.Drawing.Point(47, 258);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(170, 88);
            this.listBox1.TabIndex = 2;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBox2
            // 
            this.listBox2.Enabled = false;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(109, 7);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(46, 30);
            this.listBox2.TabIndex = 3;
            this.listBox2.Visible = false;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(24, 207);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(216, 45);
            this.axWindowsMediaPlayer1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(75)))), ((int)(((byte)(55)))));
            this.pictureBox1.Image = global::PlayerdeMusicas.Properties.Resources._1632300549398;
            this.pictureBox1.Location = new System.Drawing.Point(47, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 158);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // retroceder
            // 
            this.retroceder.FlatAppearance.BorderSize = 0;
            this.retroceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.retroceder.Image = global::PlayerdeMusicas.Properties.Resources.anterior;
            this.retroceder.Location = new System.Drawing.Point(12, 106);
            this.retroceder.Name = "retroceder";
            this.retroceder.Size = new System.Drawing.Size(41, 35);
            this.retroceder.TabIndex = 6;
            this.retroceder.UseVisualStyleBackColor = true;
            this.retroceder.Click += new System.EventHandler(this.retroceder_Click);
            // 
            // avancar
            // 
            this.avancar.FlatAppearance.BorderSize = 0;
            this.avancar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.avancar.Image = global::PlayerdeMusicas.Properties.Resources.proximo;
            this.avancar.Location = new System.Drawing.Point(209, 106);
            this.avancar.Name = "avancar";
            this.avancar.Size = new System.Drawing.Size(41, 35);
            this.avancar.TabIndex = 5;
            this.avancar.UseVisualStyleBackColor = true;
            this.avancar.Click += new System.EventHandler(this.avancar_Click);
            // 
            // adicionar_musica
            // 
            this.adicionar_musica.BackColor = System.Drawing.Color.Transparent;
            this.adicionar_musica.FlatAppearance.BorderSize = 0;
            this.adicionar_musica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adicionar_musica.Image = global::PlayerdeMusicas.Properties.Resources.adicionar__3_;
            this.adicionar_musica.Location = new System.Drawing.Point(47, 7);
            this.adicionar_musica.Name = "adicionar_musica";
            this.adicionar_musica.Size = new System.Drawing.Size(26, 35);
            this.adicionar_musica.TabIndex = 1;
            this.adicionar_musica.UseVisualStyleBackColor = false;
            this.adicionar_musica.Click += new System.EventHandler(this.adicionar_musica_Click);
            // 
            // sair
            // 
            this.sair.FlatAppearance.BorderSize = 0;
            this.sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sair.Image = global::PlayerdeMusicas.Properties.Resources.sair;
            this.sair.Location = new System.Drawing.Point(186, 7);
            this.sair.Name = "sair";
            this.sair.Size = new System.Drawing.Size(31, 35);
            this.sair.TabIndex = 0;
            this.sair.UseVisualStyleBackColor = true;
            this.sair.Click += new System.EventHandler(this.sair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(259, 361);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.retroceder);
            this.Controls.Add(this.avancar);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.adicionar_musica);
            this.Controls.Add(this.sair);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button sair;
        private System.Windows.Forms.Button adicionar_musica;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button avancar;
        private System.Windows.Forms.Button retroceder;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

