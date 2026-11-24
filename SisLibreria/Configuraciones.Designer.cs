namespace SisLibreria
{
    partial class Configuraciones
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
            panel4 = new Panel();
            lblFacturas = new Label();
            TxtLocal = new Label();
            lblImpresora = new Label();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            btnCerrar = new Button();
            label2 = new Label();
            pnlDatosEstablecimiento = new Panel();
            textBox4 = new TextBox();
            label9 = new Label();
            textBox5 = new TextBox();
            label10 = new Label();
            textBox3 = new TextBox();
            label8 = new Label();
            textBox2 = new TextBox();
            label7 = new Label();
            textBox1 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            btnActualizalogo = new Button();
            pictureBox2 = new PictureBox();
            txtNombreLocal = new TextBox();
            label1 = new Label();
            pnlFactura = new Panel();
            label4 = new Label();
            pnlImpresora = new Panel();
            label3 = new Label();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlDatosEstablecimiento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            pnlFactura.SuspendLayout();
            pnlImpresora.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(45, 66, 91);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pnlDatosEstablecimiento);
            panel1.Controls.Add(pnlFactura);
            panel1.Controls.Add(pnlImpresora);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1095, 419);
            panel1.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Controls.Add(lblFacturas);
            panel4.Controls.Add(TxtLocal);
            panel4.Controls.Add(lblImpresora);
            panel4.Location = new Point(-1, 44);
            panel4.Name = "panel4";
            panel4.Size = new Size(1095, 32);
            panel4.TabIndex = 15;
            // 
            // lblFacturas
            // 
            lblFacturas.AutoSize = true;
            lblFacturas.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFacturas.ForeColor = Color.White;
            lblFacturas.Location = new Point(222, 3);
            lblFacturas.Name = "lblFacturas";
            lblFacturas.Size = new Size(68, 20);
            lblFacturas.TabIndex = 4;
            lblFacturas.Text = "Facturas";
            lblFacturas.MouseClick += lblFacturas_MouseClick;
            // 
            // TxtLocal
            // 
            TxtLocal.AutoSize = true;
            TxtLocal.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TxtLocal.ForeColor = Color.White;
            TxtLocal.Location = new Point(11, 3);
            TxtLocal.Name = "TxtLocal";
            TxtLocal.Size = new Size(120, 20);
            TxtLocal.TabIndex = 2;
            TxtLocal.Text = "Establecimiento";
            TxtLocal.MouseClick += TxtLocal_MouseClick;
            // 
            // lblImpresora
            // 
            lblImpresora.AutoSize = true;
            lblImpresora.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblImpresora.ForeColor = Color.White;
            lblImpresora.Location = new Point(135, 3);
            lblImpresora.Name = "lblImpresora";
            lblImpresora.Size = new Size(81, 20);
            lblImpresora.TabIndex = 3;
            lblImpresora.Text = "Impresora";
            lblImpresora.MouseClick += lblImpresora_MouseClick;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = Color.FromArgb(70, 103, 142);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(btnCerrar);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(-1, -1);
            panel2.Name = "panel2";
            panel2.Size = new Size(1095, 45);
            panel2.TabIndex = 14;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.libro;
            pictureBox1.Location = new Point(9, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(29, 34);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.Red;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCerrar.ForeColor = Color.White;
            btnCerrar.Location = new Point(1053, 8);
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
            label2.Location = new Point(44, 8);
            label2.Name = "label2";
            label2.Size = new Size(292, 29);
            label2.TabIndex = 1;
            label2.Text = "Configuracion del sistema";
            // 
            // pnlDatosEstablecimiento
            // 
            pnlDatosEstablecimiento.BackColor = Color.FromArgb(45, 66, 91);
            pnlDatosEstablecimiento.Controls.Add(textBox4);
            pnlDatosEstablecimiento.Controls.Add(label9);
            pnlDatosEstablecimiento.Controls.Add(textBox5);
            pnlDatosEstablecimiento.Controls.Add(label10);
            pnlDatosEstablecimiento.Controls.Add(textBox3);
            pnlDatosEstablecimiento.Controls.Add(label8);
            pnlDatosEstablecimiento.Controls.Add(textBox2);
            pnlDatosEstablecimiento.Controls.Add(label7);
            pnlDatosEstablecimiento.Controls.Add(textBox1);
            pnlDatosEstablecimiento.Controls.Add(label6);
            pnlDatosEstablecimiento.Controls.Add(label5);
            pnlDatosEstablecimiento.Controls.Add(btnActualizalogo);
            pnlDatosEstablecimiento.Controls.Add(pictureBox2);
            pnlDatosEstablecimiento.Controls.Add(txtNombreLocal);
            pnlDatosEstablecimiento.Controls.Add(label1);
            pnlDatosEstablecimiento.Location = new Point(0, 73);
            pnlDatosEstablecimiento.Name = "pnlDatosEstablecimiento";
            pnlDatosEstablecimiento.Size = new Size(1095, 347);
            pnlDatosEstablecimiento.TabIndex = 16;
            pnlDatosEstablecimiento.Visible = false;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(540, 254);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(365, 27);
            textBox4.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(540, 231);
            label9.Name = "label9";
            label9.Size = new Size(199, 20);
            label9.TabIndex = 16;
            label9.Text = "Nombre del establecimiento";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(540, 182);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(365, 27);
            textBox5.TabIndex = 15;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(540, 159);
            label10.Name = "label10";
            label10.Size = new Size(199, 20);
            label10.TabIndex = 14;
            label10.Text = "Nombre del establecimiento";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(71, 254);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(365, 27);
            textBox3.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(71, 231);
            label8.Name = "label8";
            label8.Size = new Size(199, 20);
            label8.TabIndex = 12;
            label8.Text = "Nombre del establecimiento";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(71, 182);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(365, 27);
            textBox2.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(71, 159);
            label7.Name = "label7";
            label7.Size = new Size(199, 20);
            label7.TabIndex = 10;
            label7.Text = "Nombre del establecimiento";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(71, 109);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(365, 27);
            textBox1.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(71, 86);
            label6.Name = "label6";
            label6.Size = new Size(199, 20);
            label6.TabIndex = 8;
            label6.Text = "Nombre del establecimiento";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(540, 12);
            label5.Name = "label5";
            label5.Size = new Size(105, 20);
            label5.TabIndex = 7;
            label5.Text = "Nueva Imagen";
            label5.Click += label5_Click;
            // 
            // btnActualizalogo
            // 
            btnActualizalogo.BackColor = Color.FromArgb(34, 108, 66);
            btnActualizalogo.FlatStyle = FlatStyle.Flat;
            btnActualizalogo.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActualizalogo.ForeColor = Color.White;
            btnActualizalogo.Location = new Point(753, 107);
            btnActualizalogo.Name = "btnActualizalogo";
            btnActualizalogo.Size = new Size(72, 29);
            btnActualizalogo.TabIndex = 6;
            btnActualizalogo.Text = "UpDate";
            btnActualizalogo.UseVisualStyleBackColor = false;
            btnActualizalogo.Click += btnActualizalogo_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.Image = Properties.Resources.imagen1;
            pictureBox2.Location = new Point(540, 35);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(181, 101);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // txtNombreLocal
            // 
            txtNombreLocal.Location = new Point(71, 40);
            txtNombreLocal.Name = "txtNombreLocal";
            txtNombreLocal.ReadOnly = true;
            txtNombreLocal.Size = new Size(365, 27);
            txtNombreLocal.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(71, 17);
            label1.Name = "label1";
            label1.Size = new Size(199, 20);
            label1.TabIndex = 3;
            label1.Text = "Nombre del establecimiento";
            // 
            // pnlFactura
            // 
            pnlFactura.BackColor = Color.FromArgb(45, 66, 91);
            pnlFactura.Controls.Add(label4);
            pnlFactura.Location = new Point(0, 70);
            pnlFactura.Name = "pnlFactura";
            pnlFactura.Size = new Size(1095, 348);
            pnlFactura.TabIndex = 17;
            pnlFactura.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(10, 15);
            label4.Name = "label4";
            label4.Size = new Size(207, 20);
            label4.TabIndex = 3;
            label4.Text = "Nombre del establecimiento";
            // 
            // pnlImpresora
            // 
            pnlImpresora.BackColor = Color.FromArgb(45, 66, 91);
            pnlImpresora.Controls.Add(label3);
            pnlImpresora.Location = new Point(1, 72);
            pnlImpresora.Name = "pnlImpresora";
            pnlImpresora.Size = new Size(1095, 348);
            pnlImpresora.TabIndex = 17;
            pnlImpresora.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(9, 13);
            label3.Name = "label3";
            label3.Size = new Size(207, 20);
            label3.TabIndex = 3;
            label3.Text = "Nombre del establecimiento";
            // 
            // Configuraciones
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1097, 421);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Configuraciones";
            Text = "ActualizacionAutor";
            Load += Configuraciones_Load;
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlDatosEstablecimiento.ResumeLayout(false);
            pnlDatosEstablecimiento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            pnlFactura.ResumeLayout(false);
            pnlFactura.PerformLayout();
            pnlImpresora.ResumeLayout(false);
            pnlImpresora.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Button btnCerrar;
        private Label label2;
        private Panel pnlDatosEstablecimiento;
        private Label label1;
        private Panel panel4;
        private Label TxtLocal;
        private Label lblFacturas;
        private Label lblImpresora;
        private Panel pnlImpresora;
        private Panel pnlFactura;
        private Label label4;
        private Label label3;
        private TextBox txtNombreLocal;
        private PictureBox pictureBox2;
        private Button btnActualizalogo;
        private Label label5;
        private TextBox textBox4;
        private Label label9;
        private TextBox textBox5;
        private Label label10;
        private TextBox textBox3;
        private Label label8;
        private TextBox textBox2;
        private Label label7;
        private TextBox textBox1;
        private Label label6;
    }
}