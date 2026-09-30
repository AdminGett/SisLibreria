namespace SisLibreria
{
    partial class RegistroAutor
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
            panel1 = new Panel();
            btnRegistrarAtor = new Button();
            TxtAutor = new TextBox();
            label3 = new Label();
            panel2 = new Panel();
            btnCerrar = new Button();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(45, 66, 91);
            panel1.Controls.Add(btnRegistrarAtor);
            panel1.Controls.Add(TxtAutor);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(604, 204);
            panel1.TabIndex = 0;
            // 
            // btnRegistrarAtor
            // 
            btnRegistrarAtor.BackColor = Color.FromArgb(84, 122, 169);
            btnRegistrarAtor.FlatStyle = FlatStyle.Flat;
            btnRegistrarAtor.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrarAtor.ForeColor = Color.White;
            btnRegistrarAtor.Location = new Point(366, 98);
            btnRegistrarAtor.Name = "btnRegistrarAtor";
            btnRegistrarAtor.Size = new Size(144, 33);
            btnRegistrarAtor.TabIndex = 13;
            btnRegistrarAtor.Text = "Registrar";
            btnRegistrarAtor.UseVisualStyleBackColor = false;
            btnRegistrarAtor.Click += btnRegistrarAtor_Click;
            // 
            // TxtAutor
            // 
            TxtAutor.Location = new Point(12, 104);
            TxtAutor.Name = "TxtAutor";
            TxtAutor.Size = new Size(313, 27);
            TxtAutor.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(12, 72);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 8;
            label3.Text = "Autor:";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(btnCerrar);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(0, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(604, 56);
            panel2.TabIndex = 0;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.Red;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCerrar.ForeColor = Color.White;
            btnCerrar.Location = new Point(560, 12);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(31, 31);
            btnCerrar.TabIndex = 14;
            btnCerrar.Text = "X";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Franklin Gothic Medium", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 18);
            label2.Name = "label2";
            label2.Size = new Size(142, 29);
            label2.TabIndex = 1;
            label2.Text = "Nuevo autor";
            // 
            // RegistroAutor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(603, 199);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegistroAutor";
            Text = "RegistroAutor";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label2;
        private TextBox TxtAutor;
        private Label label3;
        private Button btnRegistrarAtor;
        private Button btnCerrar;
    }
}