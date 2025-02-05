namespace toplama_islemi
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
            btntopla = new Button();
            txt1 = new TextBox();
            txt2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            lblSonuc = new Label();
            txtsonuc = new TextBox();
            SuspendLayout();
            // 
            // btntopla
            // 
            btntopla.Location = new Point(17, 165);
            btntopla.Margin = new Padding(5);
            btntopla.Name = "btntopla";
            btntopla.Size = new Size(258, 43);
            btntopla.TabIndex = 0;
            btntopla.Text = "Topla";
            btntopla.UseVisualStyleBackColor = true;
            btntopla.Click += btntopla_Click;
            // 
            // txt1
            // 
            txt1.Location = new Point(95, 29);
            txt1.Margin = new Padding(5);
            txt1.Name = "txt1";
            txt1.Size = new Size(180, 33);
            txt1.TabIndex = 1;
            // 
            // txt2
            // 
            txt2.Location = new Point(95, 95);
            txt2.Margin = new Padding(5);
            txt2.Name = "txt2";
            txt2.Size = new Size(180, 33);
            txt2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 37);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(58, 25);
            label1.TabIndex = 3;
            label1.Text = "1.sayı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 103);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(61, 25);
            label2.TabIndex = 3;
            label2.Text = "2.sayı";
            // 
            // lblSonuc
            // 
            lblSonuc.AutoSize = true;
            lblSonuc.Location = new Point(17, 229);
            lblSonuc.Margin = new Padding(5, 0, 5, 0);
            lblSonuc.Name = "lblSonuc";
            lblSonuc.Size = new Size(77, 25);
            lblSonuc.TabIndex = 3;
            lblSonuc.Text = "Sonuc=";
            // 
            // txtsonuc
            // 
            txtsonuc.Location = new Point(95, 221);
            txtsonuc.Margin = new Padding(5);
            txtsonuc.Name = "txtsonuc";
            txtsonuc.Size = new Size(180, 33);
            txtsonuc.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(304, 274);
            Controls.Add(lblSonuc);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtsonuc);
            Controls.Add(txt2);
            Controls.Add(txt1);
            Controls.Add(btntopla);
            Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Margin = new Padding(5);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btntopla;
        private TextBox txt1;
        private TextBox txt2;
        private Label label1;
        private Label label2;
        private Label lblSonuc;
        private TextBox txtsonuc;
    }
}
