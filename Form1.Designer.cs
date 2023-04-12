namespace CalculoIMC
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
            btn_form = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 32);
            label1.Name = "label1";
            label1.Size = new Size(779, 60);
            label1.TabIndex = 0;
            label1.Text = resources.GetString("label1.Text");
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(187, 145);
            label2.Name = "label2";
            label2.Size = new Size(446, 20);
            label2.TabIndex = 1;
            label2.Text = "Caso queira, poderá calcular seu IMC clicando no botão abaixo:";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // btn_form
            // 
            btn_form.BackColor = SystemColors.ActiveCaption;
            btn_form.FlatAppearance.BorderColor = Color.Black;
            btn_form.FlatAppearance.BorderSize = 5;
            btn_form.FlatAppearance.MouseDownBackColor = Color.Black;
            btn_form.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btn_form.ForeColor = SystemColors.ActiveCaptionText;
            btn_form.Location = new Point(282, 244);
            btn_form.Name = "btn_form";
            btn_form.Size = new Size(230, 80);
            btn_form.TabIndex = 2;
            btn_form.Text = "Cálculo de IMC";
            btn_form.UseVisualStyleBackColor = false;
            btn_form.Click += btn_form_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_form);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btn_form;
    }
}