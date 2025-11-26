namespace Projek_Akhir_Semester_M_David_X_PPLG2
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
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            tbxkembalian = new TextBox();
            label7 = new Label();
            tbxbayar = new TextBox();
            label6 = new Label();
            tbxtotal = new TextBox();
            label5 = new Label();
            tbxjumlah = new TextBox();
            label4 = new Label();
            tbxharga = new TextBox();
            label3 = new Label();
            cmbjenis = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // button3
            // 
            button3.BackColor = Color.Gray;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(577, 229);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 31;
            button3.Text = "Bayar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Gray;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(474, 440);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 30;
            button2.Text = "CLOSE";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Gray;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(165, 440);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 29;
            button1.Text = "NEW";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // tbxkembalian
            // 
            tbxkembalian.Location = new Point(563, 302);
            tbxkembalian.Name = "tbxkembalian";
            tbxkembalian.Size = new Size(125, 27);
            tbxkembalian.TabIndex = 28;
            tbxkembalian.TextChanged += tbxkembalian_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(590, 279);
            label7.Name = "label7";
            label7.Size = new Size(75, 17);
            label7.TabIndex = 27;
            label7.Text = "kembalian";
            // 
            // tbxbayar
            // 
            tbxbayar.Location = new Point(563, 196);
            tbxbayar.Name = "tbxbayar";
            tbxbayar.Size = new Size(125, 27);
            tbxbayar.TabIndex = 26;
            tbxbayar.TextChanged += tbxbayar_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(583, 173);
            label6.Name = "label6";
            label6.Size = new Size(87, 17);
            label6.TabIndex = 25;
            label6.Text = "Pembayaran";
            // 
            // tbxtotal
            // 
            tbxtotal.Location = new Point(563, 122);
            tbxtotal.Name = "tbxtotal";
            tbxtotal.ReadOnly = true;
            tbxtotal.Size = new Size(125, 27);
            tbxtotal.TabIndex = 24;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(583, 99);
            label5.Name = "label5";
            label5.Size = new Size(83, 17);
            label5.TabIndex = 23;
            label5.Text = "Total Bayar";
            // 
            // tbxjumlah
            // 
            tbxjumlah.Location = new Point(44, 302);
            tbxjumlah.Name = "tbxjumlah";
            tbxjumlah.Size = new Size(140, 27);
            tbxjumlah.TabIndex = 22;
            tbxjumlah.TextChanged += tbxjumlah_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(47, 282);
            label4.Name = "label4";
            label4.Size = new Size(126, 17);
            label4.TabIndex = 21;
            label4.Text = "Jumlah Beli Tiket";
            // 
            // tbxharga
            // 
            tbxharga.Location = new Point(44, 196);
            tbxharga.Name = "tbxharga";
            tbxharga.ReadOnly = true;
            tbxharga.Size = new Size(140, 27);
            tbxharga.TabIndex = 20;
            tbxharga.TextChanged += tbxharga_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(67, 173);
            label3.Name = "label3";
            label3.Size = new Size(106, 17);
            label3.TabIndex = 19;
            label3.Text = "Harga Pertiket";
            // 
            // cmbjenis
            // 
            cmbjenis.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbjenis.FormattingEnabled = true;
            cmbjenis.Location = new Point(44, 122);
            cmbjenis.Name = "cmbjenis";
            cmbjenis.Size = new Size(140, 28);
            cmbjenis.TabIndex = 18;
            cmbjenis.SelectedIndexChanged += cmbjenis_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(74, 99);
            label2.Name = "label2";
            label2.Size = new Size(83, 17);
            label2.TabIndex = 17;
            label2.Text = "Jenis Tiket";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(269, 43);
            label1.Name = "label1";
            label1.Size = new Size(195, 25);
            label1.TabIndex = 16;
            label1.Text = "Resevasi Tiket M7";
            label1.Click += label1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.optimize_image__1_;
            ClientSize = new Size(732, 512);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(tbxkembalian);
            Controls.Add(label7);
            Controls.Add(tbxbayar);
            Controls.Add(label6);
            Controls.Add(tbxtotal);
            Controls.Add(label5);
            Controls.Add(tbxjumlah);
            Controls.Add(label4);
            Controls.Add(tbxharga);
            Controls.Add(label3);
            Controls.Add(cmbjenis);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox tbxkembalian;
        private Label label7;
        private TextBox tbxbayar;
        private Label label6;
        private TextBox tbxtotal;
        private Label label5;
        private TextBox tbxjumlah;
        private Label label4;
        private TextBox tbxharga;
        private Label label3;
        private ComboBox cmbjenis;
        private Label label2;
        private Label label1;
    }
}