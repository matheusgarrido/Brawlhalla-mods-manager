using System.Windows.Forms;

namespace BrawhallaMods
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.img1 = new System.Windows.Forms.PictureBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.titulo = new System.Windows.Forms.Label();
            this.txtPastaBrawlhalla = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.img2 = new System.Windows.Forms.PictureBox();
            this.btn2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl02 = new System.Windows.Forms.Label();
            this.img3 = new System.Windows.Forms.PictureBox();
            this.btn3 = new System.Windows.Forms.Button();
            this.lbl03 = new System.Windows.Forms.Label();
            this.img4 = new System.Windows.Forms.PictureBox();
            this.lbl04 = new System.Windows.Forms.Label();
            this.btn4 = new System.Windows.Forms.Button();
            this.lbl05 = new System.Windows.Forms.Label();
            this.lbl06 = new System.Windows.Forms.Label();
            this.img5 = new System.Windows.Forms.PictureBox();
            this.btn5 = new System.Windows.Forms.Button();
            this.img6 = new System.Windows.Forms.PictureBox();
            this.btn6 = new System.Windows.Forms.Button();
            this.btnSearchFolder = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.img7 = new System.Windows.Forms.PictureBox();
            this.btn7 = new System.Windows.Forms.Button();
            this.lbl07 = new System.Windows.Forms.Label();
            this.img8 = new System.Windows.Forms.PictureBox();
            this.lbl08 = new System.Windows.Forms.Label();
            this.btn8 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.img1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img8)).BeginInit();
            this.SuspendLayout();
            // 
            // img1
            // 
            this.img1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("img1.ErrorImage")));
            this.img1.Image = ((System.Drawing.Image)(resources.GetObject("img1.Image")));
            this.img1.Location = new System.Drawing.Point(23, 193);
            this.img1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.img1.Name = "img1";
            this.img1.Size = new System.Drawing.Size(191, 107);
            this.img1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img1.TabIndex = 0;
            this.img1.TabStop = false;
            this.img1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.Red;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn1.Location = new System.Drawing.Point(23, 299);
            this.btn1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(191, 34);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "Ativar";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.BackColor = System.Drawing.Color.Transparent;
            this.titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.titulo.Location = new System.Drawing.Point(297, 110);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(262, 29);
            this.titulo.TabIndex = 2;
            this.titulo.Text = "SELECIONE O MOD";
            // 
            // txtPastaBrawlhalla
            // 
            this.txtPastaBrawlhalla.Location = new System.Drawing.Point(234, 59);
            this.txtPastaBrawlhalla.Name = "txtPastaBrawlhalla";
            this.txtPastaBrawlhalla.Size = new System.Drawing.Size(476, 22);
            this.txtPastaBrawlhalla.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(58, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Pasta do Brawlhalla:";
            // 
            // img2
            // 
            this.img2.Location = new System.Drawing.Point(220, 193);
            this.img2.Name = "img2";
            this.img2.Size = new System.Drawing.Size(191, 107);
            this.img2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img2.TabIndex = 6;
            this.img2.TabStop = false;
            this.img2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.Red;
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn2.Location = new System.Drawing.Point(220, 299);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(191, 34);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "Ativar";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(20, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "01. Original";
            // 
            // lbl02
            // 
            this.lbl02.AutoSize = true;
            this.lbl02.BackColor = System.Drawing.Color.Transparent;
            this.lbl02.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl02.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl02.Location = new System.Drawing.Point(217, 161);
            this.lbl02.Name = "lbl02";
            this.lbl02.Size = new System.Drawing.Size(154, 18);
            this.lbl02.TabIndex = 7;
            this.lbl02.Text = "02. Mahamadag3ns";
            // 
            // img3
            // 
            this.img3.Location = new System.Drawing.Point(417, 193);
            this.img3.Name = "img3";
            this.img3.Size = new System.Drawing.Size(191, 107);
            this.img3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img3.TabIndex = 8;
            this.img3.TabStop = false;
            this.img3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.Red;
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn3.Location = new System.Drawing.Point(417, 299);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(191, 34);
            this.btn3.TabIndex = 9;
            this.btn3.Text = "Ativar";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // lbl03
            // 
            this.lbl03.AutoSize = true;
            this.lbl03.BackColor = System.Drawing.Color.Transparent;
            this.lbl03.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl03.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl03.Location = new System.Drawing.Point(414, 161);
            this.lbl03.Name = "lbl03";
            this.lbl03.Size = new System.Drawing.Size(115, 18);
            this.lbl03.TabIndex = 7;
            this.lbl03.Text = "03. No escuro";
            // 
            // img4
            // 
            this.img4.Location = new System.Drawing.Point(614, 193);
            this.img4.Name = "img4";
            this.img4.Size = new System.Drawing.Size(191, 107);
            this.img4.TabIndex = 10;
            this.img4.TabStop = false;
            this.img4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // lbl04
            // 
            this.lbl04.AutoSize = true;
            this.lbl04.BackColor = System.Drawing.Color.Transparent;
            this.lbl04.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl04.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl04.Location = new System.Drawing.Point(611, 161);
            this.lbl04.Name = "lbl04";
            this.lbl04.Size = new System.Drawing.Size(133, 18);
            this.lbl04.TabIndex = 7;
            this.lbl04.Text = "04. BrawlzzFeed";
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.Red;
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn4.Location = new System.Drawing.Point(614, 300);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(191, 34);
            this.btn4.TabIndex = 11;
            this.btn4.Text = "Ativar";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // lbl05
            // 
            this.lbl05.AutoSize = true;
            this.lbl05.BackColor = System.Drawing.Color.Transparent;
            this.lbl05.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl05.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl05.Location = new System.Drawing.Point(20, 359);
            this.lbl05.Name = "lbl05";
            this.lbl05.Size = new System.Drawing.Size(138, 18);
            this.lbl05.TabIndex = 7;
            this.lbl05.Text = "05. Cachorríneos";
            // 
            // lbl06
            // 
            this.lbl06.AutoSize = true;
            this.lbl06.BackColor = System.Drawing.Color.Transparent;
            this.lbl06.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl06.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl06.Location = new System.Drawing.Point(217, 359);
            this.lbl06.Name = "lbl06";
            this.lbl06.Size = new System.Drawing.Size(63, 18);
            this.lbl06.TabIndex = 7;
            this.lbl06.Text = "06. ???";
            // 
            // img5
            // 
            this.img5.Location = new System.Drawing.Point(23, 380);
            this.img5.Name = "img5";
            this.img5.Size = new System.Drawing.Size(191, 107);
            this.img5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img5.TabIndex = 12;
            this.img5.TabStop = false;
            this.img5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.Red;
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn5.Location = new System.Drawing.Point(23, 487);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(191, 34);
            this.btn5.TabIndex = 13;
            this.btn5.Text = "Ativar";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // img6
            // 
            this.img6.Location = new System.Drawing.Point(220, 380);
            this.img6.Name = "img6";
            this.img6.Size = new System.Drawing.Size(191, 107);
            this.img6.TabIndex = 14;
            this.img6.TabStop = false;
            this.img6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.Red;
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn6.Location = new System.Drawing.Point(220, 487);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(191, 34);
            this.btn6.TabIndex = 15;
            this.btn6.Text = "Ativar";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btnSearchFolder
            // 
            this.btnSearchFolder.BackColor = System.Drawing.Color.Transparent;
            this.btnSearchFolder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearchFolder.BackgroundImage")));
            this.btnSearchFolder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchFolder.Location = new System.Drawing.Point(716, 60);
            this.btnSearchFolder.Name = "btnSearchFolder";
            this.btnSearchFolder.Size = new System.Drawing.Size(30, 24);
            this.btnSearchFolder.TabIndex = 16;
            this.btnSearchFolder.UseVisualStyleBackColor = false;
            this.btnSearchFolder.Click += new System.EventHandler(this.btnSearchFolder_Click);
            this.btnSearchFolder.MouseHover += new System.EventHandler(this.btnSearchFolder_MouseHover);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(443, 578);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(331, 18);
            this.label8.TabIndex = 17;
            this.label8.Text = "Shitdeveloped by Matheus Garrido ©  2020DMG";
            // 
            // img7
            // 
            this.img7.Location = new System.Drawing.Point(417, 380);
            this.img7.Name = "img7";
            this.img7.Size = new System.Drawing.Size(191, 107);
            this.img7.TabIndex = 18;
            this.img7.TabStop = false;
            this.img7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.Red;
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn7.Location = new System.Drawing.Point(418, 487);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(190, 34);
            this.btn7.TabIndex = 19;
            this.btn7.Text = "Ativar";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // lbl07
            // 
            this.lbl07.AutoSize = true;
            this.lbl07.BackColor = System.Drawing.Color.Transparent;
            this.lbl07.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl07.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl07.Location = new System.Drawing.Point(415, 359);
            this.lbl07.Name = "lbl07";
            this.lbl07.Size = new System.Drawing.Size(52, 18);
            this.lbl07.TabIndex = 20;
            this.lbl07.Text = "label3";
            // 
            // img8
            // 
            this.img8.Location = new System.Drawing.Point(615, 380);
            this.img8.Name = "img8";
            this.img8.Size = new System.Drawing.Size(190, 107);
            this.img8.TabIndex = 21;
            this.img8.TabStop = false;
            this.img8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // lbl08
            // 
            this.lbl08.AutoSize = true;
            this.lbl08.BackColor = System.Drawing.Color.Transparent;
            this.lbl08.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl08.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl08.Location = new System.Drawing.Point(612, 359);
            this.lbl08.Name = "lbl08";
            this.lbl08.Size = new System.Drawing.Size(52, 18);
            this.lbl08.TabIndex = 22;
            this.lbl08.Text = "label3";
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.Red;
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn8.Location = new System.Drawing.Point(614, 487);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(191, 34);
            this.btn8.TabIndex = 23;
            this.btn8.Text = "Ativar";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(817, 617);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.lbl08);
            this.Controls.Add(this.img8);
            this.Controls.Add(this.lbl07);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.img7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnSearchFolder);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.img6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.img5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.img4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.img3);
            this.Controls.Add(this.lbl03);
            this.Controls.Add(this.lbl02);
            this.Controls.Add(this.lbl06);
            this.Controls.Add(this.lbl05);
            this.Controls.Add(this.lbl04);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.img2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPastaBrawlhalla);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.img1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Brawlhalla Mods";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.img1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox img1;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.TextBox txtPastaBrawlhalla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox img2;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl02;
        private System.Windows.Forms.PictureBox img3;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Label lbl03;
        private System.Windows.Forms.PictureBox img4;
        private System.Windows.Forms.Label lbl04;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Label lbl05;
        private System.Windows.Forms.Label lbl06;
        private System.Windows.Forms.PictureBox img5;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.PictureBox img6;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btnSearchFolder;
        private System.Windows.Forms.Label label8;
        private PictureBox img7;
        private Button btn7;
        private Label lbl07;
        private PictureBox img8;
        private Label lbl08;
        private Button btn8;
    }
}

