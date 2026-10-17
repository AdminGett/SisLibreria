namespace SisLibreria
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            roundedButton1 = new SisLibreria.ComponentsDiseans.RoundedButton();
            button2 = new Button();
            btnVenta = new Button();
            label2 = new Label();
            button1 = new Button();
            TxtLBucar = new Label();
            TxtBusqueda = new TextBox();
            panel2 = new Panel();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            btnCerrar = new Button();
            label1 = new Label();
            DtLibros = new DataGridView();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DtLibros).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(45, 66, 91);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(TxtLBucar);
            panel1.Controls.Add(TxtBusqueda);
            panel1.Location = new Point(988, 48);
            panel1.Name = "panel1";
            panel1.Size = new Size(264, 482);
            panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(roundedButton1);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(btnVenta);
            groupBox1.Location = new Point(9, 185);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 219);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            groupBox1.Visible = false;
            groupBox1.Paint += groupBox1_Paint;
            // 
            // roundedButton1
            // 
            roundedButton1.BackColor = Color.FromArgb(84, 122, 169);
            roundedButton1.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
            roundedButton1.FlatAppearance.BorderSize = 0;
            roundedButton1.FlatStyle = FlatStyle.Flat;
            roundedButton1.Font = new Font("Franklin Gothic Medium", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            roundedButton1.ForeColor = Color.White;
            roundedButton1.Location = new Point(60, 141);
            roundedButton1.Name = "roundedButton1";
            roundedButton1.Size = new Size(128, 38);
            roundedButton1.TabIndex = 5;
            roundedButton1.Text = "Agregar";
            roundedButton1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(84, 122, 169);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Franklin Gothic Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(60, 96);
            button2.Name = "button2";
            button2.Size = new Size(128, 29);
            button2.TabIndex = 4;
            button2.Text = " Apartar";
            button2.UseVisualStyleBackColor = false;
            // 
            // btnVenta
            // 
            btnVenta.BackColor = Color.FromArgb(84, 122, 169);
            btnVenta.FlatStyle = FlatStyle.Flat;
            btnVenta.Font = new Font("Franklin Gothic Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVenta.ForeColor = Color.White;
            btnVenta.Image = Properties.Resources.agregar;
            btnVenta.ImageAlign = ContentAlignment.MiddleLeft;
            btnVenta.Location = new Point(60, 44);
            btnVenta.Name = "btnVenta";
            btnVenta.Size = new Size(128, 29);
            btnVenta.TabIndex = 3;
            btnVenta.TabStop = false;
            btnVenta.Text = "Carrito";
            btnVenta.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnVenta.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(57, 83);
            label2.Name = "label2";
            label2.Size = new Size(152, 20);
            label2.TabIndex = 3;
            label2.Text = "(Titulo, Autor ó Codigo)";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(84, 122, 169);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Franklin Gothic Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(69, 127);
            button1.Name = "button1";
            button1.Size = new Size(128, 29);
            button1.TabIndex = 2;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // TxtLBucar
            // 
            TxtLBucar.AutoSize = true;
            TxtLBucar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TxtLBucar.ForeColor = Color.White;
            TxtLBucar.Location = new Point(28, 30);
            TxtLBucar.Name = "TxtLBucar";
            TxtLBucar.Size = new Size(82, 20);
            TxtLBucar.TabIndex = 1;
            TxtLBucar.Text = "Busqueda:";
            // 
            // TxtBusqueda
            // 
            TxtBusqueda.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtBusqueda.Location = new Point(28, 53);
            TxtBusqueda.Name = "TxtBusqueda";
            TxtBusqueda.Size = new Size(208, 27);
            TxtBusqueda.TabIndex = 0;
            TxtBusqueda.KeyDown += TxtBusqueda_KeyDown;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(45, 66, 91);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(DtLibros);
            panel2.Location = new Point(-4, -2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1256, 535);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.FromArgb(70, 103, 142);
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(btnCerrar);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(1253, 46);
            panel3.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.libro;
            pictureBox1.Location = new Point(23, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(29, 34);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.Red;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCerrar.ForeColor = Color.White;
            btnCerrar.Location = new Point(1209, 6);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(31, 31);
            btnCerrar.TabIndex = 17;
            btnCerrar.Text = "X";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(58, 8);
            label1.Name = "label1";
            label1.Size = new Size(173, 29);
            label1.TabIndex = 0;
            label1.Text = "Stock de libros";
            // 
            // DtLibros
            // 
            DtLibros.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DtLibros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DtLibros.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            DtLibros.BackgroundColor = Color.FromArgb(72, 106, 147);
            DtLibros.BorderStyle = BorderStyle.None;
            DtLibros.CellBorderStyle = DataGridViewCellBorderStyle.None;
            DtLibros.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.RoyalBlue;
            dataGridViewCellStyle1.Font = new Font("Franklin Gothic Medium", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.DarkBlue;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DtLibros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DtLibros.ColumnHeadersHeight = 30;
            DtLibros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(72, 106, 147);
            dataGridViewCellStyle2.Font = new Font("Franklin Gothic Medium", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.DarkBlue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            DtLibros.DefaultCellStyle = dataGridViewCellStyle2;
            DtLibros.EnableHeadersVisualStyles = false;
            DtLibros.GridColor = Color.DarkBlue;
            DtLibros.Location = new Point(16, 72);
            DtLibros.Name = "DtLibros";
            DtLibros.RowHeadersVisible = false;
            DtLibros.RowHeadersWidth = 51;
            DtLibros.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            DtLibros.Size = new Size(978, 449);
            DtLibros.TabIndex = 0;
            DtLibros.CellContentClick += DtLibros_CellContentClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1251, 531);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)DtLibros).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox TxtBusqueda;
        private Label TxtLBucar;
        private Panel panel2;
        private DataGridView DtLibros;
        private Panel panel3;
        private Label label1;
        private Button button1;
        private GroupBox groupBox1;
        private Button btnVenta;
        private Button button2;
        private Label label2;
        private PictureBox pictureBox1;
        private Button btnCerrar;
        private ComponentsDiseans.RoundedButton roundedButton1;
    }
}
