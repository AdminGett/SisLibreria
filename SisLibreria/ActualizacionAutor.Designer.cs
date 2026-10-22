namespace SisLibreria
{
    partial class ActualizacionAutor
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
            btnActualizarAutor = new Button();
            TxtAutor = new TextBox();
            label3 = new Label();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            btnCerrar = new Button();
            label2 = new Label();
            dtVentas = new DataGridView();
            button1 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtVentas).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(45, 66, 91);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(dtVentas);
            panel1.Controls.Add(btnActualizarAutor);
            panel1.Controls.Add(TxtAutor);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(596, 360);
            panel1.TabIndex = 1;
            // 
            // btnActualizarAutor
            // 
            btnActualizarAutor.BackColor = Color.FromArgb(84, 122, 169);
            btnActualizarAutor.FlatStyle = FlatStyle.Flat;
            btnActualizarAutor.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActualizarAutor.ForeColor = Color.White;
            btnActualizarAutor.ImageAlign = ContentAlignment.MiddleRight;
            btnActualizarAutor.Location = new Point(425, 100);
            btnActualizarAutor.Name = "btnActualizarAutor";
            btnActualizarAutor.Size = new Size(144, 33);
            btnActualizarAutor.TabIndex = 13;
            btnActualizarAutor.Text = "Buscar";
            btnActualizarAutor.UseVisualStyleBackColor = false;
            btnActualizarAutor.Click += btnActualizarAutor_Click;
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
            label3.Size = new Size(142, 20);
            label3.TabIndex = 8;
            label3.Text = "Nombre de Autor: ";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = Color.FromArgb(70, 103, 142);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(btnCerrar);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(596, 54);
            panel2.TabIndex = 14;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.libro;
            pictureBox1.Location = new Point(16, 9);
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
            btnCerrar.Location = new Point(558, 9);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(31, 31);
            btnCerrar.TabIndex = 14;
            btnCerrar.Text = "X";
            btnCerrar.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Franklin Gothic Medium", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(51, 12);
            label2.Name = "label2";
            label2.Size = new Size(142, 29);
            label2.TabIndex = 1;
            label2.Text = "Nuevo autor";
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
            dtVentas.Location = new Point(15, 163);
            dtVentas.Name = "dtVentas";
            dtVentas.RowHeadersVisible = false;
            dtVentas.RowHeadersWidth = 51;
            dtVentas.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dtVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtVentas.Size = new Size(384, 160);
            dtVentas.TabIndex = 14;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(84, 122, 169);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.ImageAlign = ContentAlignment.MiddleRight;
            button1.Location = new Point(425, 308);
            button1.Name = "button1";
            button1.Size = new Size(144, 33);
            button1.TabIndex = 15;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // ActualizacionAutor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(602, 366);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ActualizacionAutor";
            Text = "ActualizacionAutor";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtVentas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnActualizarAutor;
        private TextBox TxtAutor;
        private Label label3;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Button btnCerrar;
        private Label label2;
        private DataGridView dtVentas;
        private Button button1;
    }
}