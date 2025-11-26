namespace Projek_Akhir_Semester_M_David_X_PPLG2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            cmbjenis = new ComboBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(173, 50);
            label1.Name = "label1";
            label1.Size = new Size(414, 32);
            label1.TabIndex = 0;
            label1.Text = "Reservasi Tiket Pertandingan M7";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(266, 172);
            label2.Name = "label2";
            label2.Size = new Size(208, 23);
            label2.TabIndex = 1;
            label2.Text = "Pilih Tim Yang Ditonton";
            label2.Click += label2_Click_2;
            // 
            // cmbjenis
            // 
            cmbjenis.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbjenis.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbjenis.FormattingEnabled = true;
            cmbjenis.Location = new Point(222, 211);
            cmbjenis.Name = "cmbjenis";
            cmbjenis.Size = new Size(294, 25);
            cmbjenis.TabIndex = 2;
            cmbjenis.SelectedIndexChanged += comboBox1_SelectedIndexChanged_1;
            // 
            // button2
            // 
            button2.BackColor = Color.Gray;
            button2.ForeColor = Color.White;
            button2.Location = new Point(321, 262);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 4;
            button2.Text = "Continue";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(732, 512);
            Controls.Add(button2);
            Controls.Add(cmbjenis);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cmbjenis;
        private Button button2;
    }
}
