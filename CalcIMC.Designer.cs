namespace CalculoIMC
{
    partial class CalcIMC
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
            label1 = new Label();
            label2 = new Label();
            txt_peso = new TextBox();
            txt_altura = new TextBox();
            btn_resultado = new Button();
            gb_resultado = new GroupBox();
            lb_observacao = new Label();
            lb_resultado = new Label();
            btn_recalcular = new Button();
            pictureBox1 = new PictureBox();
            gb_resultado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 48);
            label1.Name = "label1";
            label1.Size = new Size(126, 20);
            label1.TabIndex = 0;
            label1.Text = "DIGITE SEU PESO:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 92);
            label2.Name = "label2";
            label2.Size = new Size(146, 20);
            label2.TabIndex = 1;
            label2.Text = "DIGITE SUA ALTURA:";
            // 
            // txt_peso
            // 
            txt_peso.Location = new Point(171, 48);
            txt_peso.Name = "txt_peso";
            txt_peso.Size = new Size(125, 27);
            txt_peso.TabIndex = 2;
            // 
            // txt_altura
            // 
            txt_altura.Location = new Point(171, 92);
            txt_altura.Name = "txt_altura";
            txt_altura.Size = new Size(125, 27);
            txt_altura.TabIndex = 3;
            // 
            // btn_resultado
            // 
            btn_resultado.Location = new Point(79, 125);
            btn_resultado.Name = "btn_resultado";
            btn_resultado.Size = new Size(154, 29);
            btn_resultado.TabIndex = 4;
            btn_resultado.Text = "Obter Resultado";
            btn_resultado.UseVisualStyleBackColor = true;
            btn_resultado.Click += btn_resultado_Click;
            // 
            // gb_resultado
            // 
            gb_resultado.BackColor = SystemColors.ActiveCaption;
            gb_resultado.Controls.Add(lb_observacao);
            gb_resultado.Controls.Add(lb_resultado);
            gb_resultado.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            gb_resultado.Location = new Point(39, 238);
            gb_resultado.Name = "gb_resultado";
            gb_resultado.Size = new Size(734, 200);
            gb_resultado.TabIndex = 5;
            gb_resultado.TabStop = false;
            gb_resultado.Text = "RESULTADO";
            gb_resultado.Visible = false;
            // 
            // lb_observacao
            // 
            lb_observacao.AutoSize = true;
            lb_observacao.Location = new Point(6, 93);
            lb_observacao.Name = "lb_observacao";
            lb_observacao.Size = new Size(86, 38);
            lb_observacao.TabIndex = 7;
            lb_observacao.Text = "Teste";
            lb_observacao.Visible = false;
            // 
            // lb_resultado
            // 
            lb_resultado.AutoSize = true;
            lb_resultado.Location = new Point(6, 39);
            lb_resultado.Name = "lb_resultado";
            lb_resultado.Size = new Size(86, 38);
            lb_resultado.TabIndex = 6;
            lb_resultado.Text = "Teste";
            lb_resultado.Visible = false;
            // 
            // btn_recalcular
            // 
            btn_recalcular.BackColor = Color.PaleGreen;
            btn_recalcular.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_recalcular.Location = new Point(317, 45);
            btn_recalcular.Name = "btn_recalcular";
            btn_recalcular.Size = new Size(125, 29);
            btn_recalcular.TabIndex = 6;
            btn_recalcular.Text = "Recalcular IMC";
            btn_recalcular.UseVisualStyleBackColor = false;
            btn_recalcular.Visible = false;
            btn_recalcular.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.foto;
            pictureBox1.Location = new Point(484, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(289, 230);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // CalcIMC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(btn_recalcular);
            Controls.Add(gb_resultado);
            Controls.Add(btn_resultado);
            Controls.Add(txt_altura);
            Controls.Add(txt_peso);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CalcIMC";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CalcIMC";
            gb_resultado.ResumeLayout(false);
            gb_resultado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txt_peso;
        private TextBox txt_altura;
        private Button btn_resultado;
        private GroupBox gb_resultado;
        private Label lb_resultado;
        private Label lb_observacao;
        private Button btn_recalcular;
        private PictureBox pictureBox1;
    }
}