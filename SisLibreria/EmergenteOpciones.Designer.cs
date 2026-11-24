namespace SisLibreria
{
    partial class EmergenteOpciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmergenteOpciones));
            btnNuevoGenero = new Button();
            btnRAutor = new Button();
            button2 = new Button();
            btnRegistro = new Button();
            panel1 = new Panel();
            btnSistema = new Button();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            btnCerrar = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnNuevoGenero
            // 
            btnNuevoGenero.BackColor = Color.FromArgb(84, 122, 169);
            btnNuevoGenero.FlatStyle = FlatStyle.Flat;
            btnNuevoGenero.Font = new Font("Franklin Gothic Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNuevoGenero.ForeColor = Color.White;
            btnNuevoGenero.Location = new Point(60, 258);
            btnNuevoGenero.Name = "btnNuevoGenero";
            btnNuevoGenero.Size = new Size(166, 38);
            btnNuevoGenero.TabIndex = 7;
            btnNuevoGenero.TabStop = false;
            btnNuevoGenero.Text = "Genero";
            btnNuevoGenero.UseVisualStyleBackColor = false;
            btnNuevoGenero.Click += btnNuevoGenero_Click;
            // 
            // btnRAutor
            // 
            btnRAutor.BackColor = Color.FromArgb(84, 122, 169);
            btnRAutor.FlatStyle = FlatStyle.Flat;
            btnRAutor.Font = new Font("Franklin Gothic Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRAutor.ForeColor = Color.White;
            btnRAutor.Location = new Point(60, 200);
            btnRAutor.Name = "btnRAutor";
            btnRAutor.Size = new Size(166, 38);
            btnRAutor.TabIndex = 6;
            btnRAutor.TabStop = false;
            btnRAutor.Text = "Autor";
            btnRAutor.UseVisualStyleBackColor = false;
            btnRAutor.Click += btnRAutor_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(84, 122, 169);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Franklin Gothic Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(60, 144);
            button2.Name = "button2";
            button2.Size = new Size(166, 38);
            button2.TabIndex = 4;
            button2.TabStop = false;
            button2.Text = "Actualizar libro";
            button2.UseVisualStyleBackColor = false;
            // 
            // btnRegistro
            // 
            btnRegistro.BackColor = Color.FromArgb(84, 122, 169);
            btnRegistro.FlatStyle = FlatStyle.Flat;
            btnRegistro.Font = new Font("Franklin Gothic Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistro.ForeColor = Color.White;
            btnRegistro.Location = new Point(60, 87);
            btnRegistro.Name = "btnRegistro";
            btnRegistro.Size = new Size(166, 38);
            btnRegistro.TabIndex = 3;
            btnRegistro.TabStop = false;
            btnRegistro.Text = "Nuevo libro";
            btnRegistro.UseVisualStyleBackColor = false;
            btnRegistro.Click += btnVenta_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(45, 66, 91);
            panel1.Controls.Add(btnSistema);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(btnRegistro);
            panel1.Controls.Add(btnNuevoGenero);
            panel1.Controls.Add(btnRAutor);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(436, 324);
            panel1.TabIndex = 6;
            // 
            // btnSistema
            // 
            btnSistema.BackColor = Color.FromArgb(84, 122, 169);
            btnSistema.FlatStyle = FlatStyle.Flat;
            btnSistema.Font = new Font("Franklin Gothic Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSistema.ForeColor = Color.White;
            btnSistema.Location = new Point(273, 175);
            btnSistema.Name = "btnSistema";
            btnSistema.Size = new Size(139, 31);
            btnSistema.TabIndex = 10;
            btnSistema.TabStop = false;
            btnSistema.Text = "Configurariones";
            btnSistema.UseVisualStyleBackColor = false;
            btnSistema.Click += btnSistema_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(70, 103, 142);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(btnCerrar);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(436, 52);
            panel2.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.libro;
            pictureBox1.Location = new Point(16, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(29, 34);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Franklin Gothic Medium", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(51, 13);
            label2.Name = "label2";
            label2.Size = new Size(111, 29);
            label2.TabIndex = 1;
            label2.Text = "Opciones";
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.Red;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCerrar.ForeColor = Color.White;
            btnCerrar.Location = new Point(394, 11);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(31, 31);
            btnCerrar.TabIndex = 14;
            btnCerrar.Text = "X";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // EmergenteOpciones
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            CausesValidation = false;
            ClientSize = new Size(438, 326);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "EmergenteOpciones";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Opciones";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private Button button2;
        private Button btnRegistro;
        private Button btnRAutor;
        private Button button5;
        private Button button3;
        private Button btnNuevoGenero;
        private Panel panel1;
        private Panel panel2;
        private Label label2;
        private Button btnCerrar;
        private PictureBox pictureBox1;
        private Button btnSistema;
    }
}