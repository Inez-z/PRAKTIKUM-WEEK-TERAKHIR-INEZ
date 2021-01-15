namespace PRAKTIKUMWEEKTERAKHIR
{
    partial class Form2
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
            this.checkBoxDiscount = new System.Windows.Forms.CheckBox();
            this.buttonCalcu = new System.Windows.Forms.Button();
            this.labelSub = new System.Windows.Forms.Label();
            this.labelTax = new System.Windows.Forms.Label();
            this.labelDisc = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelSUBTOTAL = new System.Windows.Forms.Label();
            this.labelTaxx = new System.Windows.Forms.Label();
            this.labelDISCOUNT = new System.Windows.Forms.Label();
            this.labelALL = new System.Windows.Forms.Label();
            this.textBoxdiskon = new System.Windows.Forms.TextBox();
            this.labelinput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkBoxDiscount
            // 
            this.checkBoxDiscount.AutoSize = true;
            this.checkBoxDiscount.Location = new System.Drawing.Point(40, 32);
            this.checkBoxDiscount.Name = "checkBoxDiscount";
            this.checkBoxDiscount.Size = new System.Drawing.Size(98, 24);
            this.checkBoxDiscount.TabIndex = 0;
            this.checkBoxDiscount.Text = "Discount";
            this.checkBoxDiscount.UseVisualStyleBackColor = true;
            this.checkBoxDiscount.CheckedChanged += new System.EventHandler(this.checkBoxDiscount_CheckedChanged);
            // 
            // buttonCalcu
            // 
            this.buttonCalcu.Location = new System.Drawing.Point(40, 104);
            this.buttonCalcu.Name = "buttonCalcu";
            this.buttonCalcu.Size = new System.Drawing.Size(152, 60);
            this.buttonCalcu.TabIndex = 1;
            this.buttonCalcu.Text = "CALCULATE";
            this.buttonCalcu.UseVisualStyleBackColor = true;
            this.buttonCalcu.Click += new System.EventHandler(this.buttonCalcu_Click);
            // 
            // labelSub
            // 
            this.labelSub.AutoSize = true;
            this.labelSub.Location = new System.Drawing.Point(272, 38);
            this.labelSub.Name = "labelSub";
            this.labelSub.Size = new System.Drawing.Size(93, 20);
            this.labelSub.TabIndex = 2;
            this.labelSub.Text = "SUBTOTAL";
            // 
            // labelTax
            // 
            this.labelTax.AutoSize = true;
            this.labelTax.Location = new System.Drawing.Point(280, 82);
            this.labelTax.Name = "labelTax";
            this.labelTax.Size = new System.Drawing.Size(40, 20);
            this.labelTax.TabIndex = 3;
            this.labelTax.Text = "TAX";
            // 
            // labelDisc
            // 
            this.labelDisc.AutoSize = true;
            this.labelDisc.Location = new System.Drawing.Point(280, 129);
            this.labelDisc.Name = "labelDisc";
            this.labelDisc.Size = new System.Drawing.Size(92, 20);
            this.labelDisc.TabIndex = 4;
            this.labelDisc.Text = "DISCOUNT";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(289, 179);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(59, 20);
            this.labelTotal.TabIndex = 5;
            this.labelTotal.Text = "TOTAL";
            // 
            // labelSUBTOTAL
            // 
            this.labelSUBTOTAL.AutoSize = true;
            this.labelSUBTOTAL.Location = new System.Drawing.Point(474, 42);
            this.labelSUBTOTAL.Name = "labelSUBTOTAL";
            this.labelSUBTOTAL.Size = new System.Drawing.Size(18, 20);
            this.labelSUBTOTAL.TabIndex = 6;
            this.labelSUBTOTAL.Text = "0";
            // 
            // labelTaxx
            // 
            this.labelTaxx.AutoSize = true;
            this.labelTaxx.Location = new System.Drawing.Point(477, 83);
            this.labelTaxx.Name = "labelTaxx";
            this.labelTaxx.Size = new System.Drawing.Size(18, 20);
            this.labelTaxx.TabIndex = 7;
            this.labelTaxx.Text = "0";
            // 
            // labelDISCOUNT
            // 
            this.labelDISCOUNT.AutoSize = true;
            this.labelDISCOUNT.Location = new System.Drawing.Point(479, 135);
            this.labelDISCOUNT.Name = "labelDISCOUNT";
            this.labelDISCOUNT.Size = new System.Drawing.Size(18, 20);
            this.labelDISCOUNT.TabIndex = 8;
            this.labelDISCOUNT.Text = "0";
            // 
            // labelALL
            // 
            this.labelALL.AutoSize = true;
            this.labelALL.Location = new System.Drawing.Point(489, 186);
            this.labelALL.Name = "labelALL";
            this.labelALL.Size = new System.Drawing.Size(18, 20);
            this.labelALL.TabIndex = 9;
            this.labelALL.Text = "0";
            // 
            // textBoxdiskon
            // 
            this.textBoxdiskon.Enabled = false;
            this.textBoxdiskon.Location = new System.Drawing.Point(106, 62);
            this.textBoxdiskon.Name = "textBoxdiskon";
            this.textBoxdiskon.Size = new System.Drawing.Size(101, 26);
            this.textBoxdiskon.TabIndex = 10;
            // 
            // labelinput
            // 
            this.labelinput.AutoSize = true;
            this.labelinput.Enabled = false;
            this.labelinput.Location = new System.Drawing.Point(34, 69);
            this.labelinput.Name = "labelinput";
            this.labelinput.Size = new System.Drawing.Size(56, 20);
            this.labelinput.TabIndex = 11;
            this.labelinput.Text = "INPUT";
            this.labelinput.Click += new System.EventHandler(this.labelinput_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelinput);
            this.Controls.Add(this.textBoxdiskon);
            this.Controls.Add(this.labelALL);
            this.Controls.Add(this.labelDISCOUNT);
            this.Controls.Add(this.labelTaxx);
            this.Controls.Add(this.labelSUBTOTAL);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.labelDisc);
            this.Controls.Add(this.labelTax);
            this.Controls.Add(this.labelSub);
            this.Controls.Add(this.buttonCalcu);
            this.Controls.Add(this.checkBoxDiscount);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxDiscount;
        private System.Windows.Forms.Button buttonCalcu;
        private System.Windows.Forms.Label labelSub;
        private System.Windows.Forms.Label labelTax;
        private System.Windows.Forms.Label labelDisc;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelSUBTOTAL;
        private System.Windows.Forms.Label labelTaxx;
        private System.Windows.Forms.Label labelDISCOUNT;
        private System.Windows.Forms.Label labelALL;
        private System.Windows.Forms.TextBox textBoxdiskon;
        private System.Windows.Forms.Label labelinput;
    }
}