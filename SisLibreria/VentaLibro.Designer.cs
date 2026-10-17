namespace SisLibreria
{
    partial class VentaLibro
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            lblEliminarElemento = new Label();
            cbxApartar = new CheckBox();
            cbxAbono = new CheckBox();
            lbPresioNeto = new Label();
            roundedButton2 = new SisLibreria.ComponentsDiseans.RoundedButton();
            label3 = new Label();
            btmFinVenta = new SisLibreria.ComponentsDiseans.RoundedButton();
            label2 = new Label();
            TxtLBucar = new Label();
            TxtBusqueda = new TextBox();
            dtVentas = new DataGridView();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            btnCerrar = new Button();
            label1 = new Label();
            pblCobro = new Panel();
            lblVuelto = new Label();
            label13 = new Label();
            label14 = new Label();
            txtMonetario = new TextBox();
            pnlAbono = new Panel();
            lblTicket = new Label();
            label6 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            pnlApartados = new Panel();
            label11 = new Label();
            label10 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            textBox6 = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtVentas).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pblCobro.SuspendLayout();
            pnlAbono.SuspendLayout();
            pnlApartados.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(45, 66, 91);
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(lblEliminarElemento);
            panel1.Controls.Add(cbxApartar);
            panel1.Controls.Add(cbxAbono);
            panel1.Controls.Add(lbPresioNeto);
            panel1.Controls.Add(roundedButton2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btmFinVenta);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(TxtLBucar);
            panel1.Controls.Add(TxtBusqueda);
            panel1.Controls.Add(dtVentas);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(pblCobro);
            panel1.Controls.Add(pnlAbono);
            panel1.Controls.Add(pnlApartados);
            panel1.Location = new Point(1, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1398, 565);
            panel1.TabIndex = 0;
            // 
            // lblEliminarElemento
            // 
            lblEliminarElemento.AutoSize = true;
            lblEliminarElemento.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEliminarElemento.ForeColor = Color.FromArgb(255, 128, 0);
            lblEliminarElemento.Location = new Point(1227, 408);
            lblEliminarElemento.Name = "lblEliminarElemento";
            lblEliminarElemento.Size = new Size(140, 20);
            lblEliminarElemento.TabIndex = 19;
            lblEliminarElemento.Text = "Eliminar de la lista ";
            lblEliminarElemento.Visible = false;
            lblEliminarElemento.MouseClick += lblEliminarElemento_MouseClick;
            // 
            // cbxApartar
            // 
            cbxApartar.AutoSize = true;
            cbxApartar.Font = new Font("Franklin Gothic Medium", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxApartar.ForeColor = Color.White;
            cbxApartar.Location = new Point(1086, 161);
            cbxApartar.Name = "cbxApartar";
            cbxApartar.Size = new Size(86, 25);
            cbxApartar.TabIndex = 12;
            cbxApartar.Text = "Apartar";
            cbxApartar.UseVisualStyleBackColor = true;
            cbxApartar.CheckedChanged += cbxApartar_CheckedChanged;
            // 
            // cbxAbono
            // 
            cbxAbono.AutoSize = true;
            cbxAbono.Font = new Font("Franklin Gothic Medium", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxAbono.ForeColor = Color.White;
            cbxAbono.Location = new Point(1178, 161);
            cbxAbono.Name = "cbxAbono";
            cbxAbono.Size = new Size(78, 25);
            cbxAbono.TabIndex = 11;
            cbxAbono.Text = "Abono";
            cbxAbono.UseVisualStyleBackColor = true;
            cbxAbono.CheckedChanged += cbxAbono_CheckedChanged;
            // 
            // lbPresioNeto
            // 
            lbPresioNeto.AutoSize = true;
            lbPresioNeto.Font = new Font("Franklin Gothic Medium", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbPresioNeto.ForeColor = Color.White;
            lbPresioNeto.Location = new Point(1167, 407);
            lbPresioNeto.Name = "lbPresioNeto";
            lbPresioNeto.Size = new Size(21, 21);
            lbPresioNeto.TabIndex = 1;
            lbPresioNeto.Text = "0";
            // 
            // roundedButton2
            // 
            roundedButton2.BackColor = Color.Red;
            roundedButton2.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
            roundedButton2.FlatAppearance.BorderSize = 0;
            roundedButton2.FlatStyle = FlatStyle.Flat;
            roundedButton2.Font = new Font("Franklin Gothic Medium", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            roundedButton2.ForeColor = Color.White;
            roundedButton2.Location = new Point(1285, 458);
            roundedButton2.Name = "roundedButton2";
            roundedButton2.Size = new Size(97, 32);
            roundedButton2.TabIndex = 9;
            roundedButton2.Text = "Cancelar";
            roundedButton2.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Franklin Gothic Medium", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(1086, 407);
            label3.Name = "label3";
            label3.Size = new Size(76, 21);
            label3.TabIndex = 0;
            label3.Text = "Total:  $";
            // 
            // btmFinVenta
            // 
            btmFinVenta.BackColor = Color.FromArgb(84, 122, 169);
            btmFinVenta.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
            btmFinVenta.FlatAppearance.BorderSize = 0;
            btmFinVenta.FlatStyle = FlatStyle.Flat;
            btmFinVenta.Font = new Font("Franklin Gothic Medium", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btmFinVenta.ForeColor = Color.White;
            btmFinVenta.Location = new Point(1083, 458);
            btmFinVenta.Name = "btmFinVenta";
            btmFinVenta.Size = new Size(101, 32);
            btmFinVenta.TabIndex = 8;
            btmFinVenta.Text = "Cobrar";
            btmFinVenta.UseVisualStyleBackColor = false;
            btmFinVenta.Click += roundedButton1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(1086, 138);
            label2.Name = "label2";
            label2.Size = new Size(133, 20);
            label2.TabIndex = 6;
            label2.Text = "(Nombre,Autor o Id)";
            // 
            // TxtLBucar
            // 
            TxtLBucar.AutoSize = true;
            TxtLBucar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TxtLBucar.ForeColor = Color.White;
            TxtLBucar.Location = new Point(1086, 85);
            TxtLBucar.Name = "TxtLBucar";
            TxtLBucar.Size = new Size(71, 20);
            TxtLBucar.TabIndex = 5;
            TxtLBucar.Text = "Agregar:";
            // 
            // TxtBusqueda
            // 
            TxtBusqueda.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtBusqueda.Location = new Point(1086, 108);
            TxtBusqueda.Name = "TxtBusqueda";
            TxtBusqueda.Size = new Size(293, 27);
            TxtBusqueda.TabIndex = 4;
            TxtBusqueda.KeyDown += TxtBusqueda_KeyDown;
            // 
            // dtVentas
            // 
            dtVentas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtVentas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dtVentas.BackgroundColor = Color.FromArgb(72, 106, 147);
            dtVentas.BorderStyle = BorderStyle.None;
            dtVentas.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dtVentas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.RoyalBlue;
            dataGridViewCellStyle1.Font = new Font("Franklin Gothic Medium", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.DarkBlue;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtVentas.ColumnHeadersHeight = 30;
            dtVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(72, 106, 147);
            dataGridViewCellStyle2.Font = new Font("Franklin Gothic Medium", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(64, 94, 130);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dtVentas.DefaultCellStyle = dataGridViewCellStyle2;
            dtVentas.EnableHeadersVisualStyles = false;
            dtVentas.GridColor = Color.DarkBlue;
            dtVentas.Location = new Point(23, 72);
            dtVentas.Name = "dtVentas";
            dtVentas.RowHeadersVisible = false;
            dtVentas.RowHeadersWidth = 51;
            dtVentas.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dtVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtVentas.Size = new Size(1036, 460);
            dtVentas.TabIndex = 3;
            dtVentas.CellClick += dtVentas_CellClick;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.FromArgb(70, 103, 142);
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(btnCerrar);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1394, 46);
            panel3.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.libro;
            pictureBox1.Location = new Point(12, 6);
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
            btnCerrar.Location = new Point(1354, 6);
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
            label1.Location = new Point(47, 9);
            label1.Name = "label1";
            label1.Size = new Size(73, 29);
            label1.TabIndex = 0;
            label1.Text = "Venta";
            // 
            // pblCobro
            // 
            pblCobro.BackColor = Color.FromArgb(72, 106, 147);
            pblCobro.Controls.Add(lblVuelto);
            pblCobro.Controls.Add(label13);
            pblCobro.Controls.Add(label14);
            pblCobro.Controls.Add(txtMonetario);
            pblCobro.Location = new Point(1083, 213);
            pblCobro.Name = "pblCobro";
            pblCobro.Size = new Size(299, 173);
            pblCobro.TabIndex = 18;
            // 
            // lblVuelto
            // 
            lblVuelto.AutoSize = true;
            lblVuelto.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVuelto.ForeColor = Color.White;
            lblVuelto.Location = new Point(83, 95);
            lblVuelto.Name = "lblVuelto";
            lblVuelto.Size = new Size(18, 20);
            lblVuelto.TabIndex = 16;
            lblVuelto.Text = "0";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.White;
            label13.Location = new Point(6, 95);
            label13.Name = "label13";
            label13.Size = new Size(79, 20);
            label13.TabIndex = 15;
            label13.Text = "Cambio: $";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.White;
            label14.Location = new Point(6, 21);
            label14.Name = "label14";
            label14.Size = new Size(59, 20);
            label14.TabIndex = 13;
            label14.Text = "Recibe:";
            // 
            // txtMonetario
            // 
            txtMonetario.Location = new Point(6, 47);
            txtMonetario.Name = "txtMonetario";
            txtMonetario.Size = new Size(278, 27);
            txtMonetario.TabIndex = 12;
            txtMonetario.TextChanged += textBox4_TextChanged;
            // 
            // pnlAbono
            // 
            pnlAbono.BackColor = Color.FromArgb(72, 106, 147);
            pnlAbono.Controls.Add(lblTicket);
            pnlAbono.Controls.Add(label6);
            pnlAbono.Controls.Add(textBox3);
            pnlAbono.Controls.Add(label5);
            pnlAbono.Controls.Add(textBox2);
            pnlAbono.Controls.Add(label4);
            pnlAbono.Location = new Point(1083, 213);
            pnlAbono.Name = "pnlAbono";
            pnlAbono.Size = new Size(299, 173);
            pnlAbono.TabIndex = 10;
            pnlAbono.Visible = false;
            // 
            // lblTicket
            // 
            lblTicket.AutoSize = true;
            lblTicket.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTicket.ForeColor = Color.White;
            lblTicket.Location = new Point(84, 24);
            lblTicket.Name = "lblTicket";
            lblTicket.Size = new Size(51, 20);
            lblTicket.TabIndex = 17;
            lblTicket.Text = "label1";
            lblTicket.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(6, 121);
            label6.Name = "label6";
            label6.Size = new Size(60, 20);
            label6.TabIndex = 15;
            label6.Text = "Abono:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(87, 118);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(190, 27);
            textBox3.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(6, 75);
            label5.Name = "label5";
            label5.Size = new Size(71, 20);
            label5.TabIndex = 13;
            label5.Text = "Nombre:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(87, 72);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(190, 27);
            textBox2.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(6, 24);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 11;
            label4.Text = "N° ticket:";
            // 
            // pnlApartados
            // 
            pnlApartados.BackColor = Color.FromArgb(72, 106, 147);
            pnlApartados.Controls.Add(label11);
            pnlApartados.Controls.Add(label10);
            pnlApartados.Controls.Add(label7);
            pnlApartados.Controls.Add(label8);
            pnlApartados.Controls.Add(label9);
            pnlApartados.Controls.Add(textBox6);
            pnlApartados.Location = new Point(1083, 213);
            pnlApartados.Name = "pnlApartados";
            pnlApartados.Size = new Size(299, 173);
            pnlApartados.TabIndex = 16;
            pnlApartados.Visible = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Franklin Gothic Medium", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.White;
            label11.Location = new Point(87, 121);
            label11.Name = "label11";
            label11.Size = new Size(65, 21);
            label11.TabIndex = 17;
            label11.Text = "label11";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Franklin Gothic Medium", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(87, 79);
            label10.Name = "label10";
            label10.Size = new Size(59, 21);
            label10.TabIndex = 16;
            label10.Text = "Label1";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(6, 121);
            label7.Name = "label7";
            label7.Size = new Size(60, 20);
            label7.TabIndex = 15;
            label7.Text = "Abono:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(6, 75);
            label8.Name = "label8";
            label8.Size = new Size(71, 20);
            label8.TabIndex = 13;
            label8.Text = "Nombre:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(6, 24);
            label9.Name = "label9";
            label9.Size = new Size(74, 20);
            label9.TabIndex = 11;
            label9.Text = "N° ticket:";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(87, 21);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(190, 27);
            textBox6.TabIndex = 3;
            // 
            // VentaLibro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1399, 567);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "VentaLibro";
            Text = "VentaLibro";
            Shown += VentaLibro_Shown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtVentas).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pblCobro.ResumeLayout(false);
            pblCobro.PerformLayout();
            pnlAbono.ResumeLayout(false);
            pnlAbono.PerformLayout();
            pnlApartados.ResumeLayout(false);
            pnlApartados.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Button btnCerrar;
        private Label label1;
        private DataGridView dtVentas;
        private Label label2;
        private Label TxtLBucar;
        private TextBox TxtBusqueda;
        private ComponentsDiseans.RoundedButton btmFinVenta;
        private ComponentsDiseans.RoundedButton roundedButton2;
        private Panel pnlAbono;
        private Label lbPresioNeto;
        private Label label3;
        private CheckBox cbxAbono;
        private Label label4;
        private Label label5;
        private TextBox textBox2;
        private Label label6;
        private TextBox textBox3;
        private CheckBox cbxApartar;
        private Panel pnlApartados;
        private Label label11;
        private Label label10;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox textBox6;
        private Label lblTicket;
        private Panel pblCobro;
        private Label lblVuelto;
        private Label label13;
        private Label label14;
        private TextBox txtMonetario;
        private Label lblEliminarElemento;
    }
}