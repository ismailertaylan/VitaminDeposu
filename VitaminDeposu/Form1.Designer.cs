
namespace VitaminDeposu
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.picElma = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblSaniye = new System.Windows.Forms.Label();
            this.picGreyfurt = new System.Windows.Forms.PictureBox();
            this.picMandalina = new System.Windows.Forms.PictureBox();
            this.picPortakal = new System.Windows.Forms.PictureBox();
            this.picArmut = new System.Windows.Forms.PictureBox();
            this.picCilek = new System.Windows.Forms.PictureBox();
            this.butNarenciye = new System.Windows.Forms.Button();
            this.butKatiMeyve = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTopGr = new System.Windows.Forms.Label();
            this.lblvitC = new System.Windows.Forms.Label();
            this.lblvitA = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gameover = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picElma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGreyfurt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMandalina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPortakal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picArmut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCilek)).BeginInit();
            this.SuspendLayout();
            // 
            // picElma
            // 
            this.picElma.BackColor = System.Drawing.Color.Transparent;
            this.picElma.Image = ((System.Drawing.Image)(resources.GetObject("picElma.Image")));
            this.picElma.Location = new System.Drawing.Point(278, 129);
            this.picElma.Name = "picElma";
            this.picElma.Size = new System.Drawing.Size(250, 250);
            this.picElma.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picElma.TabIndex = 0;
            this.picElma.TabStop = false;
            this.picElma.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.YellowGreen;
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(280, 461);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(248, 88);
            this.button1.TabIndex = 1;
            this.button1.Text = "BAŞLA";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblSaniye
            // 
            this.lblSaniye.AutoSize = true;
            this.lblSaniye.BackColor = System.Drawing.Color.Transparent;
            this.lblSaniye.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSaniye.ForeColor = System.Drawing.Color.White;
            this.lblSaniye.Location = new System.Drawing.Point(3, 0);
            this.lblSaniye.Name = "lblSaniye";
            this.lblSaniye.Size = new System.Drawing.Size(0, 75);
            this.lblSaniye.TabIndex = 2;
            // 
            // picGreyfurt
            // 
            this.picGreyfurt.BackColor = System.Drawing.Color.Transparent;
            this.picGreyfurt.Image = ((System.Drawing.Image)(resources.GetObject("picGreyfurt.Image")));
            this.picGreyfurt.Location = new System.Drawing.Point(278, 129);
            this.picGreyfurt.Name = "picGreyfurt";
            this.picGreyfurt.Size = new System.Drawing.Size(250, 250);
            this.picGreyfurt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picGreyfurt.TabIndex = 3;
            this.picGreyfurt.TabStop = false;
            this.picGreyfurt.Visible = false;
            // 
            // picMandalina
            // 
            this.picMandalina.BackColor = System.Drawing.Color.Transparent;
            this.picMandalina.Image = ((System.Drawing.Image)(resources.GetObject("picMandalina.Image")));
            this.picMandalina.Location = new System.Drawing.Point(278, 129);
            this.picMandalina.Name = "picMandalina";
            this.picMandalina.Size = new System.Drawing.Size(250, 250);
            this.picMandalina.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMandalina.TabIndex = 4;
            this.picMandalina.TabStop = false;
            this.picMandalina.Visible = false;
            // 
            // picPortakal
            // 
            this.picPortakal.BackColor = System.Drawing.Color.Transparent;
            this.picPortakal.Image = ((System.Drawing.Image)(resources.GetObject("picPortakal.Image")));
            this.picPortakal.Location = new System.Drawing.Point(278, 129);
            this.picPortakal.Name = "picPortakal";
            this.picPortakal.Size = new System.Drawing.Size(250, 250);
            this.picPortakal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPortakal.TabIndex = 5;
            this.picPortakal.TabStop = false;
            this.picPortakal.Visible = false;
            // 
            // picArmut
            // 
            this.picArmut.BackColor = System.Drawing.Color.Transparent;
            this.picArmut.Image = ((System.Drawing.Image)(resources.GetObject("picArmut.Image")));
            this.picArmut.Location = new System.Drawing.Point(280, 129);
            this.picArmut.Name = "picArmut";
            this.picArmut.Size = new System.Drawing.Size(250, 250);
            this.picArmut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picArmut.TabIndex = 6;
            this.picArmut.TabStop = false;
            this.picArmut.Visible = false;
            // 
            // picCilek
            // 
            this.picCilek.BackColor = System.Drawing.Color.Transparent;
            this.picCilek.Image = ((System.Drawing.Image)(resources.GetObject("picCilek.Image")));
            this.picCilek.Location = new System.Drawing.Point(280, 129);
            this.picCilek.Name = "picCilek";
            this.picCilek.Size = new System.Drawing.Size(250, 250);
            this.picCilek.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCilek.TabIndex = 7;
            this.picCilek.TabStop = false;
            this.picCilek.Visible = false;
            // 
            // butNarenciye
            // 
            this.butNarenciye.BackColor = System.Drawing.Color.YellowGreen;
            this.butNarenciye.Font = new System.Drawing.Font("Arial Narrow", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.butNarenciye.Location = new System.Drawing.Point(12, 204);
            this.butNarenciye.Name = "butNarenciye";
            this.butNarenciye.Size = new System.Drawing.Size(248, 88);
            this.butNarenciye.TabIndex = 8;
            this.butNarenciye.Text = "NARENCİYE";
            this.butNarenciye.UseVisualStyleBackColor = false;
            this.butNarenciye.Visible = false;
            this.butNarenciye.Click += new System.EventHandler(this.butNarenciye_Click);
            // 
            // butKatiMeyve
            // 
            this.butKatiMeyve.BackColor = System.Drawing.Color.YellowGreen;
            this.butKatiMeyve.Font = new System.Drawing.Font("Arial Narrow", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.butKatiMeyve.Location = new System.Drawing.Point(525, 204);
            this.butKatiMeyve.Name = "butKatiMeyve";
            this.butKatiMeyve.Size = new System.Drawing.Size(248, 88);
            this.butKatiMeyve.TabIndex = 9;
            this.butKatiMeyve.Text = "KATI MEYVE";
            this.butKatiMeyve.UseVisualStyleBackColor = false;
            this.butKatiMeyve.Visible = false;
            this.butKatiMeyve.Click += new System.EventHandler(this.butKatiMeyve_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Cyan;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(52, 430);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 43);
            this.label1.TabIndex = 10;
            this.label1.Text = "Vitamin A";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Cyan;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(314, 430);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 43);
            this.label2.TabIndex = 11;
            this.label2.Text = "Vitamin C";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Cyan;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(534, 430);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(241, 43);
            this.label3.TabIndex = 12;
            this.label3.Text = "Toplam Gramaj";
            this.label3.Visible = false;
            // 
            // lblTopGr
            // 
            this.lblTopGr.AutoSize = true;
            this.lblTopGr.BackColor = System.Drawing.Color.Cyan;
            this.lblTopGr.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTopGr.ForeColor = System.Drawing.Color.Black;
            this.lblTopGr.Location = new System.Drawing.Point(606, 473);
            this.lblTopGr.Name = "lblTopGr";
            this.lblTopGr.Size = new System.Drawing.Size(104, 43);
            this.lblTopGr.TabIndex = 15;
            this.lblTopGr.Text = "00000";
            this.lblTopGr.Visible = false;
            // 
            // lblvitC
            // 
            this.lblvitC.AutoSize = true;
            this.lblvitC.BackColor = System.Drawing.Color.Cyan;
            this.lblvitC.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblvitC.ForeColor = System.Drawing.Color.Black;
            this.lblvitC.Location = new System.Drawing.Point(345, 473);
            this.lblvitC.Name = "lblvitC";
            this.lblvitC.Size = new System.Drawing.Size(104, 43);
            this.lblvitC.TabIndex = 14;
            this.lblvitC.Text = "00000";
            this.lblvitC.Visible = false;
            // 
            // lblvitA
            // 
            this.lblvitA.AutoSize = true;
            this.lblvitA.BackColor = System.Drawing.Color.Cyan;
            this.lblvitA.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblvitA.ForeColor = System.Drawing.Color.Black;
            this.lblvitA.Location = new System.Drawing.Point(78, 473);
            this.lblvitA.Name = "lblvitA";
            this.lblvitA.Size = new System.Drawing.Size(104, 43);
            this.lblvitA.TabIndex = 13;
            this.lblvitA.Text = "00000";
            this.lblvitA.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Cyan;
            this.panel1.Location = new System.Drawing.Point(-2, 416);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(791, 115);
            this.panel1.TabIndex = 16;
            this.panel1.Visible = false;
            // 
            // gameover
            // 
            this.gameover.AutoSize = true;
            this.gameover.BackColor = System.Drawing.Color.Transparent;
            this.gameover.Font = new System.Drawing.Font("Arial", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gameover.ForeColor = System.Drawing.Color.White;
            this.gameover.Location = new System.Drawing.Point(94, 204);
            this.gameover.Name = "gameover";
            this.gameover.Size = new System.Drawing.Size(616, 111);
            this.gameover.TabIndex = 17;
            this.gameover.Text = "OYUN BİTTİ!";
            this.gameover.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.gameover);
            this.Controls.Add(this.lblTopGr);
            this.Controls.Add(this.lblvitC);
            this.Controls.Add(this.lblvitA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butKatiMeyve);
            this.Controls.Add(this.butNarenciye);
            this.Controls.Add(this.picCilek);
            this.Controls.Add(this.picArmut);
            this.Controls.Add(this.picPortakal);
            this.Controls.Add(this.picMandalina);
            this.Controls.Add(this.picGreyfurt);
            this.Controls.Add(this.lblSaniye);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.picElma);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vitamin Deposu";
            ((System.ComponentModel.ISupportInitialize)(this.picElma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGreyfurt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMandalina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPortakal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picArmut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCilek)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picElma;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblSaniye;
        private System.Windows.Forms.PictureBox picGreyfurt;
        private System.Windows.Forms.PictureBox picMandalina;
        private System.Windows.Forms.PictureBox picPortakal;
        private System.Windows.Forms.PictureBox picArmut;
        private System.Windows.Forms.PictureBox picCilek;
        private System.Windows.Forms.Button butNarenciye;
        private System.Windows.Forms.Button butKatiMeyve;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTopGr;
        private System.Windows.Forms.Label lblvitC;
        private System.Windows.Forms.Label lblvitA;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label gameover;
    }
}

