namespace PRAKTIKUMWEEKTERAKHIR
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
            this.labelBuDewi = new System.Windows.Forms.Label();
            this.labelItem = new System.Windows.Forms.Label();
            this.radioButtonoMakanan = new System.Windows.Forms.RadioButton();
            this.radioButtonMinuman = new System.Windows.Forms.RadioButton();
            this.listBoxMenu = new System.Windows.Forms.ListBox();
            this.listBoxHarga = new System.Windows.Forms.ListBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.labelMenu = new System.Windows.Forms.Label();
            this.comboBoxMenu = new System.Windows.Forms.ComboBox();
            this.labelHarga = new System.Windows.Forms.Label();
            this.labelHargaOtomatis = new System.Windows.Forms.Label();
            this.radioButtonNormal = new System.Windows.Forms.RadioButton();
            this.radioButtonJumbo = new System.Windows.Forms.RadioButton();
            this.labelSize = new System.Windows.Forms.Label();
            this.buttonBUY = new System.Windows.Forms.Button();
            this.buttonCheckout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelBuDewi
            // 
            this.labelBuDewi.AutoSize = true;
            this.labelBuDewi.Location = new System.Drawing.Point(354, 35);
            this.labelBuDewi.Name = "labelBuDewi";
            this.labelBuDewi.Size = new System.Drawing.Size(68, 20);
            this.labelBuDewi.TabIndex = 0;
            this.labelBuDewi.Text = "Bu Dewi";
            this.labelBuDewi.Click += new System.EventHandler(this.labelBuDewi_Click);
            // 
            // labelItem
            // 
            this.labelItem.AutoSize = true;
            this.labelItem.Location = new System.Drawing.Point(85, 104);
            this.labelItem.Name = "labelItem";
            this.labelItem.Size = new System.Drawing.Size(58, 20);
            this.labelItem.TabIndex = 1;
            this.labelItem.Text = "ITEMS";
            // 
            // radioButtonoMakanan
            // 
            this.radioButtonoMakanan.AutoSize = true;
            this.radioButtonoMakanan.Location = new System.Drawing.Point(596, 100);
            this.radioButtonoMakanan.Name = "radioButtonoMakanan";
            this.radioButtonoMakanan.Size = new System.Drawing.Size(100, 24);
            this.radioButtonoMakanan.TabIndex = 2;
            this.radioButtonoMakanan.TabStop = true;
            this.radioButtonoMakanan.Text = "Makanan";
            this.radioButtonoMakanan.UseVisualStyleBackColor = true;
            this.radioButtonoMakanan.CheckedChanged += new System.EventHandler(this.radioButtonoMakanan_CheckedChanged);
            // 
            // radioButtonMinuman
            // 
            this.radioButtonMinuman.AutoSize = true;
            this.radioButtonMinuman.Location = new System.Drawing.Point(714, 100);
            this.radioButtonMinuman.Name = "radioButtonMinuman";
            this.radioButtonMinuman.Size = new System.Drawing.Size(99, 24);
            this.radioButtonMinuman.TabIndex = 3;
            this.radioButtonMinuman.TabStop = true;
            this.radioButtonMinuman.Text = "Minuman";
            this.radioButtonMinuman.UseVisualStyleBackColor = true;
            this.radioButtonMinuman.CheckedChanged += new System.EventHandler(this.radioButtonMinuman_CheckedChanged);
            // 
            // listBoxMenu
            // 
            this.listBoxMenu.FormattingEnabled = true;
            this.listBoxMenu.ItemHeight = 20;
            this.listBoxMenu.Location = new System.Drawing.Point(12, 140);
            this.listBoxMenu.Name = "listBoxMenu";
            this.listBoxMenu.Size = new System.Drawing.Size(288, 364);
            this.listBoxMenu.TabIndex = 4;
            this.listBoxMenu.SelectedIndexChanged += new System.EventHandler(this.listBoxMenu_SelectedIndexChanged);
            // 
            // listBoxHarga
            // 
            this.listBoxHarga.FormattingEnabled = true;
            this.listBoxHarga.ItemHeight = 20;
            this.listBoxHarga.Location = new System.Drawing.Point(316, 140);
            this.listBoxHarga.Name = "listBoxHarga";
            this.listBoxHarga.Size = new System.Drawing.Size(181, 364);
            this.listBoxHarga.TabIndex = 5;
            this.listBoxHarga.SelectedIndexChanged += new System.EventHandler(this.listBoxHarga_SelectedIndexChanged);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Enabled = false;
            this.buttonDelete.Location = new System.Drawing.Point(183, 546);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(127, 35);
            this.buttonDelete.TabIndex = 6;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // labelMenu
            // 
            this.labelMenu.AutoSize = true;
            this.labelMenu.Location = new System.Drawing.Point(516, 145);
            this.labelMenu.Name = "labelMenu";
            this.labelMenu.Size = new System.Drawing.Size(49, 20);
            this.labelMenu.TabIndex = 7;
            this.labelMenu.Text = "Menu";
            // 
            // comboBoxMenu
            // 
            this.comboBoxMenu.FormattingEnabled = true;
            this.comboBoxMenu.Location = new System.Drawing.Point(596, 140);
            this.comboBoxMenu.Name = "comboBoxMenu";
            this.comboBoxMenu.Size = new System.Drawing.Size(217, 28);
            this.comboBoxMenu.TabIndex = 8;
            this.comboBoxMenu.SelectedIndexChanged += new System.EventHandler(this.labelHargaOtomatis_Click);
            // 
            // labelHarga
            // 
            this.labelHarga.AutoSize = true;
            this.labelHarga.Location = new System.Drawing.Point(844, 145);
            this.labelHarga.Name = "labelHarga";
            this.labelHarga.Size = new System.Drawing.Size(57, 20);
            this.labelHarga.TabIndex = 9;
            this.labelHarga.Text = "Harga:";
            this.labelHarga.Click += new System.EventHandler(this.labelHarga_Click);
            // 
            // labelHargaOtomatis
            // 
            this.labelHargaOtomatis.AutoSize = true;
            this.labelHargaOtomatis.Location = new System.Drawing.Point(921, 150);
            this.labelHargaOtomatis.Name = "labelHargaOtomatis";
            this.labelHargaOtomatis.Size = new System.Drawing.Size(17, 20);
            this.labelHargaOtomatis.TabIndex = 10;
            this.labelHargaOtomatis.Text = "  ";
            this.labelHargaOtomatis.Click += new System.EventHandler(this.labelHargaOtomatis_Click);
            // 
            // radioButtonNormal
            // 
            this.radioButtonNormal.AutoSize = true;
            this.radioButtonNormal.Enabled = false;
            this.radioButtonNormal.Location = new System.Drawing.Point(596, 220);
            this.radioButtonNormal.Name = "radioButtonNormal";
            this.radioButtonNormal.Size = new System.Drawing.Size(84, 24);
            this.radioButtonNormal.TabIndex = 11;
            this.radioButtonNormal.TabStop = true;
            this.radioButtonNormal.Text = "Normal";
            this.radioButtonNormal.UseVisualStyleBackColor = true;
            this.radioButtonNormal.CheckedChanged += new System.EventHandler(this.radioButtonNormal_CheckedChanged);
            // 
            // radioButtonJumbo
            // 
            this.radioButtonJumbo.AutoSize = true;
            this.radioButtonJumbo.Enabled = false;
            this.radioButtonJumbo.Location = new System.Drawing.Point(731, 220);
            this.radioButtonJumbo.Name = "radioButtonJumbo";
            this.radioButtonJumbo.Size = new System.Drawing.Size(82, 24);
            this.radioButtonJumbo.TabIndex = 12;
            this.radioButtonJumbo.TabStop = true;
            this.radioButtonJumbo.Text = "Jumbo";
            this.radioButtonJumbo.UseVisualStyleBackColor = true;
            this.radioButtonJumbo.CheckedChanged += new System.EventHandler(this.radioButtonJumbo_CheckedChanged);
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Enabled = false;
            this.labelSize.Location = new System.Drawing.Point(592, 184);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(40, 20);
            this.labelSize.TabIndex = 13;
            this.labelSize.Text = "Size";
            this.labelSize.Click += new System.EventHandler(this.labelSize_Click);
            // 
            // buttonBUY
            // 
            this.buttonBUY.Location = new System.Drawing.Point(603, 300);
            this.buttonBUY.Name = "buttonBUY";
            this.buttonBUY.Size = new System.Drawing.Size(210, 84);
            this.buttonBUY.TabIndex = 14;
            this.buttonBUY.Text = "BUY";
            this.buttonBUY.UseVisualStyleBackColor = true;
            this.buttonBUY.Click += new System.EventHandler(this.buttonBUY_Click);
            // 
            // buttonCheckout
            // 
            this.buttonCheckout.Location = new System.Drawing.Point(880, 488);
            this.buttonCheckout.Name = "buttonCheckout";
            this.buttonCheckout.Size = new System.Drawing.Size(183, 105);
            this.buttonCheckout.TabIndex = 15;
            this.buttonCheckout.Text = "Check Out";
            this.buttonCheckout.UseVisualStyleBackColor = true;
            this.buttonCheckout.Click += new System.EventHandler(this.buttonCheckout_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 611);
            this.Controls.Add(this.buttonCheckout);
            this.Controls.Add(this.buttonBUY);
            this.Controls.Add(this.labelSize);
            this.Controls.Add(this.radioButtonJumbo);
            this.Controls.Add(this.radioButtonNormal);
            this.Controls.Add(this.labelHargaOtomatis);
            this.Controls.Add(this.labelHarga);
            this.Controls.Add(this.comboBoxMenu);
            this.Controls.Add(this.labelMenu);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.listBoxHarga);
            this.Controls.Add(this.listBoxMenu);
            this.Controls.Add(this.radioButtonMinuman);
            this.Controls.Add(this.radioButtonoMakanan);
            this.Controls.Add(this.labelItem);
            this.Controls.Add(this.labelBuDewi);
            this.Name = "Form1";
            this.Text = "BU DEWI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBuDewi;
        private System.Windows.Forms.Label labelItem;
        private System.Windows.Forms.RadioButton radioButtonoMakanan;
        private System.Windows.Forms.RadioButton radioButtonMinuman;
        private System.Windows.Forms.ListBox listBoxMenu;
        private System.Windows.Forms.ListBox listBoxHarga;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label labelMenu;
        private System.Windows.Forms.ComboBox comboBoxMenu;
        private System.Windows.Forms.Label labelHarga;
        private System.Windows.Forms.Label labelHargaOtomatis;
        private System.Windows.Forms.RadioButton radioButtonNormal;
        private System.Windows.Forms.RadioButton radioButtonJumbo;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.Button buttonBUY;
        private System.Windows.Forms.Button buttonCheckout;
    }
}

