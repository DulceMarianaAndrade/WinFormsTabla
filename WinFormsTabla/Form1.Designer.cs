namespace WinFormsTabla
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
            panelprincipal = new Panel();
            richTextBoxresultados = new RichTextBox();
            buttonver = new Button();
            textBoxnum = new TextBox();
            labelnumero = new Label();
            labeltitulo = new Label();
            label1 = new Label();
            panelprincipal.SuspendLayout();
            SuspendLayout();
            // 
            // panelprincipal
            // 
            panelprincipal.BackColor = Color.FromArgb(192, 255, 255);
            panelprincipal.Controls.Add(label1);
            panelprincipal.Controls.Add(richTextBoxresultados);
            panelprincipal.Controls.Add(buttonver);
            panelprincipal.Controls.Add(textBoxnum);
            panelprincipal.Controls.Add(labelnumero);
            panelprincipal.Controls.Add(labeltitulo);
            panelprincipal.Location = new Point(12, 12);
            panelprincipal.Name = "panelprincipal";
            panelprincipal.Size = new Size(776, 426);
            panelprincipal.TabIndex = 0;
            // 
            // richTextBoxresultados
            // 
            richTextBoxresultados.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBoxresultados.Location = new Point(285, 63);
            richTextBoxresultados.Name = "richTextBoxresultados";
            richTextBoxresultados.Size = new Size(202, 280);
            richTextBoxresultados.TabIndex = 4;
            richTextBoxresultados.Text = "";
            // 
            // buttonver
            // 
            buttonver.BackColor = Color.FromArgb(192, 192, 255);
            buttonver.ForeColor = SystemColors.WindowText;
            buttonver.Location = new Point(53, 174);
            buttonver.Name = "buttonver";
            buttonver.Size = new Size(112, 34);
            buttonver.TabIndex = 3;
            buttonver.Text = "ver tabla";
            buttonver.UseVisualStyleBackColor = false;
            buttonver.Click += buttonver_Click;
            // 
            // textBoxnum
            // 
            textBoxnum.Location = new Point(53, 122);
            textBoxnum.Name = "textBoxnum";
            textBoxnum.Size = new Size(150, 31);
            textBoxnum.TabIndex = 2;
            // 
            // labelnumero
            // 
            labelnumero.AutoSize = true;
            labelnumero.Font = new Font("Sitka Text", 10F, FontStyle.Italic, GraphicsUnit.Point);
            labelnumero.ForeColor = Color.FromArgb(192, 0, 192);
            labelnumero.Location = new Point(40, 72);
            labelnumero.Name = "labelnumero";
            labelnumero.Size = new Size(200, 29);
            labelnumero.TabIndex = 1;
            labelnumero.Text = "¿Cuál tabla quieres?";
            // 
            // labeltitulo
            // 
            labeltitulo.AutoSize = true;
            labeltitulo.Font = new Font("Yu Gothic UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labeltitulo.ForeColor = SystemColors.MenuHighlight;
            labeltitulo.Location = new Point(40, 28);
            labeltitulo.Name = "labeltitulo";
            labeltitulo.Size = new Size(188, 28);
            labeltitulo.TabIndex = 0;
            labeltitulo.Text = "Tabla de Multiplicar";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SimSun", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(128, 128, 255);
            label1.Location = new Point(68, 375);
            label1.Name = "label1";
            label1.Size = new Size(386, 18);
            label1.TabIndex = 5;
            label1.Text = "Dulce Mariana Andrade Olvera 3-C ID:376905";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelprincipal);
            Name = "Form1";
            Text = "Form1";
            panelprincipal.ResumeLayout(false);
            panelprincipal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelprincipal;
        private Label labeltitulo;
        private TextBox textBoxnum;
        private Label labelnumero;
        private RichTextBox richTextBoxresultados;
        private Button buttonver;
        private Label label1;
    }
}
