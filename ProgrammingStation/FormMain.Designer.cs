namespace ProgrammingStation
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.rtbConsole = new System.Windows.Forms.RichTextBox();
            this.tbState = new System.Windows.Forms.TextBox();
            this.timerAdmin = new System.Windows.Forms.Timer(this.components);
            this.btnCikis = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnAyar = new System.Windows.Forms.Button();
            this.projectNameTxt = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.cardPicture = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rbMicrochipUVC = new System.Windows.Forms.RadioButton();
            this.rbMicrochipPakistan = new System.Windows.Forms.RadioButton();
            this.rbMicrochipEBI = new System.Windows.Forms.RadioButton();
            this.rbMicrochipRomanya = new System.Windows.Forms.RadioButton();
            this.rbRenesasIND = new System.Windows.Forms.RadioButton();
            this.rbRenesasPakistan = new System.Windows.Forms.RadioButton();
            this.rbRenesasEBI = new System.Windows.Forms.RadioButton();
            this.rbRenesasRomanya = new System.Windows.Forms.RadioButton();
            this.rbSTUVC = new System.Windows.Forms.RadioButton();
            this.rbSTPakistan = new System.Windows.Forms.RadioButton();
            this.rbSTEBI = new System.Windows.Forms.RadioButton();
            this.rbSTRomanya = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardPicture)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbConsole
            // 
            this.rtbConsole.BackColor = System.Drawing.SystemColors.Info;
            this.rtbConsole.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbConsole.ForeColor = System.Drawing.Color.White;
            this.rtbConsole.Location = new System.Drawing.Point(747, 40);
            this.rtbConsole.Margin = new System.Windows.Forms.Padding(0);
            this.rtbConsole.Name = "rtbConsole";
            this.rtbConsole.Size = new System.Drawing.Size(439, 719);
            this.rtbConsole.TabIndex = 0;
            this.rtbConsole.TabStop = false;
            this.rtbConsole.Text = "";
            this.rtbConsole.TextChanged += new System.EventHandler(this.rtbConsole_TextChanged);
            // 
            // tbState
            // 
            this.tbState.BackColor = System.Drawing.Color.DarkGray;
            this.tbState.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbState.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbState.ForeColor = System.Drawing.Color.White;
            this.tbState.Location = new System.Drawing.Point(747, 7);
            this.tbState.Margin = new System.Windows.Forms.Padding(0);
            this.tbState.Name = "tbState";
            this.tbState.Size = new System.Drawing.Size(439, 33);
            this.tbState.TabIndex = 0;
            this.tbState.TabStop = false;
            this.tbState.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timerAdmin
            // 
            this.timerAdmin.Tick += new System.EventHandler(this.timerAdmin_Tick);
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.Red;
            this.btnCikis.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.Location = new System.Drawing.Point(441, 704);
            this.btnCikis.Margin = new System.Windows.Forms.Padding(4);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(302, 55);
            this.btnCikis.TabIndex = 48;
            this.btnCikis.Text = "ÇIKIŞ";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(322, 720);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 49;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // btnAyar
            // 
            this.btnAyar.BackColor = System.Drawing.Color.Red;
            this.btnAyar.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAyar.Location = new System.Drawing.Point(-1, 704);
            this.btnAyar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAyar.Name = "btnAyar";
            this.btnAyar.Size = new System.Drawing.Size(302, 55);
            this.btnAyar.TabIndex = 47;
            this.btnAyar.Text = "AYARLAR";
            this.btnAyar.UseVisualStyleBackColor = false;
            this.btnAyar.Click += new System.EventHandler(this.btnAyar_Click);
            // 
            // projectNameTxt
            // 
            this.projectNameTxt.BackColor = System.Drawing.Color.DarkGray;
            this.projectNameTxt.Enabled = false;
            this.projectNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.projectNameTxt.Location = new System.Drawing.Point(7, 98);
            this.projectNameTxt.Name = "projectNameTxt";
            this.projectNameTxt.Size = new System.Drawing.Size(737, 44);
            this.projectNameTxt.TabIndex = 58;
            this.projectNameTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox2
            // 
            this.pictureBox2.ErrorImage = global::ProgrammingStation.Properties.Resources.alpNEXT;
            this.pictureBox2.Image = global::ProgrammingStation.Properties.Resources.alpNEXT;
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(10, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(734, 85);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 57;
            this.pictureBox2.TabStop = false;
            // 
            // cardPicture
            // 
            this.cardPicture.InitialImage = null;
            this.cardPicture.Location = new System.Drawing.Point(7, 149);
            this.cardPicture.Margin = new System.Windows.Forms.Padding(2);
            this.cardPicture.Name = "cardPicture";
            this.cardPicture.Size = new System.Drawing.Size(737, 400);
            this.cardPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cardPicture.TabIndex = 56;
            this.cardPicture.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rbMicrochipUVC);
            this.groupBox1.Controls.Add(this.rbMicrochipPakistan);
            this.groupBox1.Controls.Add(this.rbMicrochipEBI);
            this.groupBox1.Controls.Add(this.rbMicrochipRomanya);
            this.groupBox1.Controls.Add(this.rbRenesasIND);
            this.groupBox1.Controls.Add(this.rbRenesasPakistan);
            this.groupBox1.Controls.Add(this.rbRenesasEBI);
            this.groupBox1.Controls.Add(this.rbRenesasRomanya);
            this.groupBox1.Controls.Add(this.rbSTUVC);
            this.groupBox1.Controls.Add(this.rbSTPakistan);
            this.groupBox1.Controls.Add(this.rbSTEBI);
            this.groupBox1.Controls.Add(this.rbSTRomanya);
            this.groupBox1.Location = new System.Drawing.Point(7, 554);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(736, 143);
            this.groupBox1.TabIndex = 59;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(6, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 29);
            this.label3.TabIndex = 14;
            this.label3.Text = "MICROCHIP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(6, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 29);
            this.label2.TabIndex = 13;
            this.label2.Text = "RENESAS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = "ST";
            // 
            // rbMicrochipUVC
            // 
            this.rbMicrochipUVC.AutoSize = true;
            this.rbMicrochipUVC.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbMicrochipUVC.Location = new System.Drawing.Point(645, 97);
            this.rbMicrochipUVC.Name = "rbMicrochipUVC";
            this.rbMicrochipUVC.Size = new System.Drawing.Size(75, 33);
            this.rbMicrochipUVC.TabIndex = 11;
            this.rbMicrochipUVC.Text = "UVC";
            this.rbMicrochipUVC.UseVisualStyleBackColor = true;
            this.rbMicrochipUVC.CheckedChanged += new System.EventHandler(this.rbMicrochipUVC_CheckedChanged);
            // 
            // rbMicrochipPakistan
            // 
            this.rbMicrochipPakistan.AutoSize = true;
            this.rbMicrochipPakistan.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbMicrochipPakistan.Location = new System.Drawing.Point(490, 97);
            this.rbMicrochipPakistan.Name = "rbMicrochipPakistan";
            this.rbMicrochipPakistan.Size = new System.Drawing.Size(119, 33);
            this.rbMicrochipPakistan.TabIndex = 10;
            this.rbMicrochipPakistan.Text = "Pakistan";
            this.rbMicrochipPakistan.UseVisualStyleBackColor = true;
            this.rbMicrochipPakistan.CheckedChanged += new System.EventHandler(this.rbMicrochipPakistan_CheckedChanged);
            // 
            // rbMicrochipEBI
            // 
            this.rbMicrochipEBI.AutoSize = true;
            this.rbMicrochipEBI.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbMicrochipEBI.Location = new System.Drawing.Point(384, 97);
            this.rbMicrochipEBI.Name = "rbMicrochipEBI";
            this.rbMicrochipEBI.Size = new System.Drawing.Size(67, 33);
            this.rbMicrochipEBI.TabIndex = 9;
            this.rbMicrochipEBI.Text = "EBI";
            this.rbMicrochipEBI.UseVisualStyleBackColor = true;
            this.rbMicrochipEBI.CheckedChanged += new System.EventHandler(this.rbMicrochipEBI_CheckedChanged);
            // 
            // rbMicrochipRomanya
            // 
            this.rbMicrochipRomanya.AutoSize = true;
            this.rbMicrochipRomanya.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbMicrochipRomanya.Location = new System.Drawing.Point(212, 97);
            this.rbMicrochipRomanya.Name = "rbMicrochipRomanya";
            this.rbMicrochipRomanya.Size = new System.Drawing.Size(130, 33);
            this.rbMicrochipRomanya.TabIndex = 8;
            this.rbMicrochipRomanya.Text = "Romanya";
            this.rbMicrochipRomanya.UseVisualStyleBackColor = true;
            this.rbMicrochipRomanya.CheckedChanged += new System.EventHandler(this.rbMicrochipRomanya_CheckedChanged);
            // 
            // rbRenesasIND
            // 
            this.rbRenesasIND.AutoSize = true;
            this.rbRenesasIND.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbRenesasIND.Location = new System.Drawing.Point(645, 58);
            this.rbRenesasIND.Name = "rbRenesasIND";
            this.rbRenesasIND.Size = new System.Drawing.Size(72, 33);
            this.rbRenesasIND.TabIndex = 7;
            this.rbRenesasIND.Text = "IND";
            this.rbRenesasIND.UseVisualStyleBackColor = true;
            this.rbRenesasIND.CheckedChanged += new System.EventHandler(this.rbRenesasIND_CheckedChanged);
            // 
            // rbRenesasPakistan
            // 
            this.rbRenesasPakistan.AutoSize = true;
            this.rbRenesasPakistan.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbRenesasPakistan.Location = new System.Drawing.Point(490, 58);
            this.rbRenesasPakistan.Name = "rbRenesasPakistan";
            this.rbRenesasPakistan.Size = new System.Drawing.Size(119, 33);
            this.rbRenesasPakistan.TabIndex = 6;
            this.rbRenesasPakistan.Text = "Pakistan";
            this.rbRenesasPakistan.UseVisualStyleBackColor = true;
            this.rbRenesasPakistan.CheckedChanged += new System.EventHandler(this.rbRenesasPakistan_CheckedChanged);
            // 
            // rbRenesasEBI
            // 
            this.rbRenesasEBI.AutoSize = true;
            this.rbRenesasEBI.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbRenesasEBI.Location = new System.Drawing.Point(384, 58);
            this.rbRenesasEBI.Name = "rbRenesasEBI";
            this.rbRenesasEBI.Size = new System.Drawing.Size(67, 33);
            this.rbRenesasEBI.TabIndex = 5;
            this.rbRenesasEBI.Text = "EBI";
            this.rbRenesasEBI.UseVisualStyleBackColor = true;
            this.rbRenesasEBI.CheckedChanged += new System.EventHandler(this.rbRenesasEBI_CheckedChanged);
            // 
            // rbRenesasRomanya
            // 
            this.rbRenesasRomanya.AutoSize = true;
            this.rbRenesasRomanya.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbRenesasRomanya.Location = new System.Drawing.Point(212, 58);
            this.rbRenesasRomanya.Name = "rbRenesasRomanya";
            this.rbRenesasRomanya.Size = new System.Drawing.Size(130, 33);
            this.rbRenesasRomanya.TabIndex = 4;
            this.rbRenesasRomanya.Text = "Romanya";
            this.rbRenesasRomanya.UseVisualStyleBackColor = true;
            this.rbRenesasRomanya.CheckedChanged += new System.EventHandler(this.rbRenesasRomanya_CheckedChanged);
            // 
            // rbSTUVC
            // 
            this.rbSTUVC.AutoSize = true;
            this.rbSTUVC.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbSTUVC.Location = new System.Drawing.Point(645, 19);
            this.rbSTUVC.Name = "rbSTUVC";
            this.rbSTUVC.Size = new System.Drawing.Size(75, 33);
            this.rbSTUVC.TabIndex = 3;
            this.rbSTUVC.Text = "UVC";
            this.rbSTUVC.UseVisualStyleBackColor = true;
            this.rbSTUVC.CheckedChanged += new System.EventHandler(this.rbSTUVC_CheckedChanged);
            // 
            // rbSTPakistan
            // 
            this.rbSTPakistan.AutoSize = true;
            this.rbSTPakistan.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbSTPakistan.Location = new System.Drawing.Point(490, 19);
            this.rbSTPakistan.Name = "rbSTPakistan";
            this.rbSTPakistan.Size = new System.Drawing.Size(119, 33);
            this.rbSTPakistan.TabIndex = 2;
            this.rbSTPakistan.Text = "Pakistan";
            this.rbSTPakistan.UseVisualStyleBackColor = true;
            this.rbSTPakistan.CheckedChanged += new System.EventHandler(this.rbSTPakistan_CheckedChanged);
            // 
            // rbSTEBI
            // 
            this.rbSTEBI.AutoSize = true;
            this.rbSTEBI.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbSTEBI.Location = new System.Drawing.Point(384, 19);
            this.rbSTEBI.Name = "rbSTEBI";
            this.rbSTEBI.Size = new System.Drawing.Size(67, 33);
            this.rbSTEBI.TabIndex = 1;
            this.rbSTEBI.Text = "EBI";
            this.rbSTEBI.UseVisualStyleBackColor = true;
            this.rbSTEBI.CheckedChanged += new System.EventHandler(this.rbSTEBI_CheckedChanged);
            // 
            // rbSTRomanya
            // 
            this.rbSTRomanya.AutoSize = true;
            this.rbSTRomanya.Checked = true;
            this.rbSTRomanya.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbSTRomanya.Location = new System.Drawing.Point(212, 19);
            this.rbSTRomanya.Name = "rbSTRomanya";
            this.rbSTRomanya.Size = new System.Drawing.Size(130, 33);
            this.rbSTRomanya.TabIndex = 0;
            this.rbSTRomanya.TabStop = true;
            this.rbSTRomanya.Text = "Romanya";
            this.rbSTRomanya.UseVisualStyleBackColor = true;
            this.rbSTRomanya.CheckedChanged += new System.EventHandler(this.rbSTRomanya_CheckedChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1196, 769);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.projectNameTxt);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.cardPicture);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnAyar);
            this.Controls.Add(this.rtbConsole);
            this.Controls.Add(this.tbState);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "All Harvest Fresh Programing Station";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardPicture)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox rtbConsole;
        private System.Windows.Forms.TextBox tbState;
        private System.Windows.Forms.Timer timerAdmin;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnAyar;
        private System.Windows.Forms.PictureBox cardPicture;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox projectNameTxt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbSTUVC;
        private System.Windows.Forms.RadioButton rbSTPakistan;
        private System.Windows.Forms.RadioButton rbSTEBI;
        private System.Windows.Forms.RadioButton rbSTRomanya;
        private System.Windows.Forms.RadioButton rbMicrochipUVC;
        private System.Windows.Forms.RadioButton rbMicrochipPakistan;
        private System.Windows.Forms.RadioButton rbMicrochipEBI;
        private System.Windows.Forms.RadioButton rbMicrochipRomanya;
        private System.Windows.Forms.RadioButton rbRenesasIND;
        private System.Windows.Forms.RadioButton rbRenesasPakistan;
        private System.Windows.Forms.RadioButton rbRenesasEBI;
        private System.Windows.Forms.RadioButton rbRenesasRomanya;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

