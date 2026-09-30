namespace SisLibreria
{
    partial class RegistroLibro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroLibro));
            panel1 = new Panel();
            TxtAutorLibro = new ComboBox();
            CkxRepacionLibro = new CheckBox();
            CbxGenero = new ComboBox();
            TxtTitulo = new TextBox();
            button2 = new Button();
            label5 = new Label();
            TxtPrecio = new TextBox();
            label4 = new Label();
            label3 = new Label();
            panel3 = new Panel();
            label2 = new Label();
            TxtLBucar = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(45, 66, 91);
            panel1.Controls.Add(TxtAutorLibro);
            panel1.Controls.Add(CkxRepacionLibro);
            panel1.Controls.Add(CbxGenero);
            panel1.Controls.Add(TxtTitulo);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(TxtPrecio);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(TxtLBucar);
            panel1.Location = new Point(-2, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1374, 359);
            panel1.TabIndex = 0;
            // 
            // TxtAutorLibro
            // 
            TxtAutorLibro.FormattingEnabled = true;
            TxtAutorLibro.Location = new Point(53, 181);
            TxtAutorLibro.Name = "TxtAutorLibro";
            TxtAutorLibro.Size = new Size(464, 28);
            TxtAutorLibro.TabIndex = 17;
            // 
            // CkxRepacionLibro
            // 
            CkxRepacionLibro.AutoSize = true;
            CkxRepacionLibro.ForeColor = Color.White;
            CkxRepacionLibro.Location = new Point(613, 158);
            CkxRepacionLibro.Name = "CkxRepacionLibro";
            CkxRepacionLibro.Size = new Size(158, 24);
            CkxRepacionLibro.TabIndex = 16;
            CkxRepacionLibro.Text = "¿Ocupa Repararse?";
            CkxRepacionLibro.UseVisualStyleBackColor = true;
            // 
            // CbxGenero
            // 
            CbxGenero.FormattingEnabled = true;
            CbxGenero.Location = new Point(53, 269);
            CbxGenero.Name = "CbxGenero";
            CbxGenero.Size = new Size(278, 28);
            CbxGenero.TabIndex = 15;
            // 
            // TxtTitulo
            // 
            TxtTitulo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtTitulo.Location = new Point(53, 104);
            TxtTitulo.Name = "TxtTitulo";
            TxtTitulo.Size = new Size(464, 27);
            TxtTitulo.TabIndex = 13;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(84, 122, 169);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(613, 294);
            button2.Name = "button2";
            button2.Size = new Size(144, 33);
            button2.TabIndex = 12;
            button2.Text = "Registrar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(613, 81);
            label5.Name = "label5";
            label5.Size = new Size(56, 20);
            label5.TabIndex = 11;
            label5.Text = "Precio:";
            // 
            // TxtPrecio
            // 
            TxtPrecio.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtPrecio.Location = new Point(613, 104);
            TxtPrecio.Name = "TxtPrecio";
            TxtPrecio.Size = new Size(101, 27);
            TxtPrecio.TabIndex = 10;
            TxtPrecio.KeyPress += TxtPrecio_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(53, 158);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 9;
            label4.Text = "Autor:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(53, 81);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 7;
            label3.Text = "Titulo:";
            // 
            // panel3
            // 
            panel3.Controls.Add(label2);
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(1371, 46);
            panel3.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Franklin Gothic Medium", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(13, 8);
            label2.Name = "label2";
            label2.Size = new Size(140, 29);
            label2.TabIndex = 0;
            label2.Text = "Nuevo Libro";
            // 
            // TxtLBucar
            // 
            TxtLBucar.AutoSize = true;
            TxtLBucar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TxtLBucar.ForeColor = Color.White;
            TxtLBucar.Location = new Point(53, 246);
            TxtLBucar.Name = "TxtLBucar";
            TxtLBucar.Size = new Size(127, 20);
            TxtLBucar.TabIndex = 2;
            TxtLBucar.Text = "Genero Literario:";
            // 
            // RegistroLibro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1372, 354);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "RegistroLibro";
            Load += RegistroLibro_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ComboBox CbxGenero;
        private Label label1;
        private ComboBox comboBox2;
        private Label TxtLBucar;
        private Panel panel3;
        private Label label2;
        private Label label3;
        private TextBox TxtBusqueda;
        private Label label4;
        private TextBox textBox1;
        private Label label5;
        private TextBox TxtPrecio;
        private Button button2;
        private CheckBox CkxRepacionLibro;
        private ComboBox TxtAutorLibro;
        private TextBox TxtTitulo;
    }
}