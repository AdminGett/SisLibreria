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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            button1 = new Button();
            dtAutor = new DataGridView();
            btnRegistrarAtor = new Button();
            TxtAutor = new TextBox();
            label3 = new Label();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            btnCerrar = new Button();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtAutor).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(45, 66, 91);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(dtAutor);
            panel1.Controls.Add(btnRegistrarAtor);
            panel1.Controls.Add(TxtAutor);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(600, 295);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Franklin Gothic Medium", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.ImageAlign = ContentAlignment.MiddleRight;
            button1.Location = new Point(12, 251);
            button1.Name = "button1";
            button1.Size = new Size(133, 24);
            button1.TabIndex = 15;
            button1.Text = "Eleminar Registro";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // dtAutor
            // 
            dtAutor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtAutor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtAutor.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dtAutor.BackgroundColor = Color.FromArgb(72, 106, 147);
            dtAutor.BorderStyle = BorderStyle.None;
            dtAutor.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dtAutor.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.RoyalBlue;
            dataGridViewCellStyle1.Font = new Font("Franklin Gothic Medium", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.DarkBlue;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtAutor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtAutor.ColumnHeadersHeight = 30;
            dtAutor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(72, 106, 147);
            dataGridViewCellStyle2.Font = new Font("Franklin Gothic Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.DarkBlue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dtAutor.DefaultCellStyle = dataGridViewCellStyle2;
            dtAutor.EnableHeadersVisualStyles = false;
            dtAutor.GridColor = Color.DarkBlue;
            dtAutor.Location = new Point(12, 139);
            dtAutor.Name = "dtAutor";
            dtAutor.ReadOnly = true;
            dtAutor.RowHeadersVisible = false;
            dtAutor.RowHeadersWidth = 51;
            dtAutor.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dtAutor.Size = new Size(566, 97);
            dtAutor.TabIndex = 14;
            dtAutor.CellContentClick += dtAutor_CellContentClick;
            // 
            // btnRegistrarAtor
            // 
            btnRegistrarAtor.BackColor = Color.FromArgb(84, 122, 169);
            btnRegistrarAtor.FlatStyle = FlatStyle.Flat;
            btnRegistrarAtor.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrarAtor.ForeColor = Color.White;
            btnRegistrarAtor.ImageAlign = ContentAlignment.MiddleRight;
            btnRegistrarAtor.Location = new Point(434, 98);
            btnRegistrarAtor.Name = "btnRegistrarAtor";
            btnRegistrarAtor.Size = new Size(144, 33);
            btnRegistrarAtor.TabIndex = 13;
            btnRegistrarAtor.Text = "Buscar";
            btnRegistrarAtor.UseVisualStyleBackColor = false;
            btnRegistrarAtor.Click += btnRegistrarAtor_Click;
            // 
            // TxtAutor
            // 
            TxtAutor.Location = new Point(12, 104);
            TxtAutor.Name = "TxtAutor";
            TxtAutor.Size = new Size(386, 27);
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
            panel2.BackColor = Color.FromArgb(70, 103, 142);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(btnCerrar);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(6, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(596, 54);
            panel2.TabIndex = 0;
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
            btnCerrar.Click += btnCerrar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Franklin Gothic Medium", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(51, 12);
            label2.Name = "label2";
            label2.Size = new Size(71, 29);
            label2.TabIndex = 1;
            label2.Text = "Autor";
            // 
            // RegistroAutor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(603, 299);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegistroAutor";
            Text = "RegistroAutor";
            Shown += RegistroAutor_Shown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtAutor).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private PictureBox pictureBox1;
        private DataGridView dtAutor;
        private Button button1;
        private DataGridView dtGenero;
    }
}