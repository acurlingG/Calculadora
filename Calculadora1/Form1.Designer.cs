namespace Calculadora1
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
            b1 = new Button();
            b2 = new Button();
            b3 = new Button();
            panel1 = new Panel();
            bc = new Button();
            bigual = new Button();
            bsuma = new Button();
            lresultado = new Label();
            bresta = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // b1
            // 
            b1.Font = new Font("Segoe UI", 21.75F);
            b1.ForeColor = Color.Red;
            b1.Location = new Point(29, 135);
            b1.Name = "b1";
            b1.Size = new Size(149, 146);
            b1.TabIndex = 0;
            b1.Text = "1";
            b1.UseVisualStyleBackColor = true;
            b1.Click += b1_Click;
            // 
            // b2
            // 
            b2.Font = new Font("Segoe UI", 21.75F);
            b2.ForeColor = Color.Red;
            b2.Location = new Point(215, 135);
            b2.Name = "b2";
            b2.Size = new Size(149, 146);
            b2.TabIndex = 1;
            b2.Text = "2";
            b2.UseVisualStyleBackColor = true;
            b2.Click += b2_Click;
            // 
            // b3
            // 
            b3.Font = new Font("Segoe UI", 21.75F);
            b3.ForeColor = Color.Red;
            b3.Location = new Point(413, 135);
            b3.Name = "b3";
            b3.Size = new Size(149, 146);
            b3.TabIndex = 2;
            b3.Text = "3";
            b3.UseVisualStyleBackColor = true;
            b3.Click += b3_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(bresta);
            panel1.Controls.Add(bc);
            panel1.Controls.Add(bigual);
            panel1.Controls.Add(bsuma);
            panel1.Controls.Add(lresultado);
            panel1.Controls.Add(b1);
            panel1.Controls.Add(b3);
            panel1.Controls.Add(b2);
            panel1.Location = new Point(3, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(801, 458);
            panel1.TabIndex = 3;
            // 
            // bc
            // 
            bc.Font = new Font("Segoe UI", 21.75F);
            bc.ForeColor = Color.Red;
            bc.Location = new Point(599, 135);
            bc.Name = "bc";
            bc.Size = new Size(149, 146);
            bc.TabIndex = 6;
            bc.Text = "C";
            bc.UseVisualStyleBackColor = true;
            bc.Click += bc_Click;
            // 
            // bigual
            // 
            bigual.Font = new Font("Segoe UI", 21.75F);
            bigual.ForeColor = Color.Red;
            bigual.Location = new Point(413, 302);
            bigual.Name = "bigual";
            bigual.Size = new Size(149, 146);
            bigual.TabIndex = 5;
            bigual.Text = "=";
            bigual.UseVisualStyleBackColor = true;
            bigual.Click += bigual_Click;
            // 
            // bsuma
            // 
            bsuma.Font = new Font("Segoe UI", 21.75F);
            bsuma.ForeColor = Color.Red;
            bsuma.Location = new Point(29, 302);
            bsuma.Name = "bsuma";
            bsuma.Size = new Size(149, 146);
            bsuma.TabIndex = 4;
            bsuma.Text = "+";
            bsuma.UseVisualStyleBackColor = true;
            bsuma.Click += bsuma_Click;
            // 
            // lresultado
            // 
            lresultado.BackColor = SystemColors.ButtonHighlight;
            lresultado.BorderStyle = BorderStyle.Fixed3D;
            lresultado.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lresultado.ForeColor = Color.Red;
            lresultado.Location = new Point(29, 35);
            lresultado.Name = "lresultado";
            lresultado.Size = new Size(533, 72);
            lresultado.TabIndex = 3;
            // 
            // bresta
            // 
            bresta.Font = new Font("Segoe UI", 21.75F);
            bresta.ForeColor = Color.Red;
            bresta.Location = new Point(215, 302);
            bresta.Name = "bresta";
            bresta.Size = new Size(149, 146);
            bresta.TabIndex = 7;
            bresta.Text = "-";
            bresta.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(799, 472);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button b1;
        private Button b2;
        private Button b3;
        private Panel panel1;
        private Label lresultado;
        private Button bigual;
        private Button bsuma;
        private Button bc;
        private Button bresta;
    }
}
