namespace SisLibreria
{
    partial class NuevoGenero
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
            dtGenero = new DataGridView();
            btnRegistrarGenero = new Button();
            TxtGenero = new TextBox();
            label3 = new Label();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            btnCerrar = new Button();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtGenero).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(45, 66, 91);
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(dtGenero);
            panel1.Controls.Add(btnRegistrarGenero);
            panel1.Controls.Add(TxtGenero);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(600, 319);
            panel1.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Franklin Gothic Medium", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.ImageAlign = ContentAlignment.MiddleRight;
            button1.Location = new Point(12, 269);
            button1.Name = "button1";
            button1.Size = new Size(133, 25);
            button1.TabIndex = 16;
            button1.Text = "Eleminar Registro";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dtGenero
            // 
            dtGenero.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtGenero.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtGenero.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dtGenero.BackgroundColor = Color.FromArgb(72, 106, 147);
            dtGenero.BorderStyle = BorderStyle.None;
            dtGenero.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dtGenero.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.RoyalBlue;
            dataGridViewCellStyle1.Font = new Font("Franklin Gothic Medium", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.DarkBlue;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtGenero.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtGenero.ColumnHeadersHeight = 30;
            dtGenero.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(72, 106, 147);
            dataGridViewCellStyle2.Font = new Font("Franklin Gothic Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.DarkBlue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dtGenero.DefaultCellStyle = dataGridViewCellStyle2;
            dtGenero.EnableHeadersVisualStyles = false;
            dtGenero.GridColor = Color.DarkBlue;
            dtGenero.Location = new Point(12, 156);
            dtGenero.Name = "dtGenero";
            dtGenero.ReadOnly = true;
            dtGenero.RowHeadersVisible = false;
            dtGenero.RowHeadersWidth = 51;
            dtGenero.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dtGenero.Size = new Size(572, 97);
            dtGenero.TabIndex = 15;
            // 
            // btnRegistrarGenero
            // 
            btnRegistrarGenero.BackColor = Color.FromArgb(84, 122, 169);
            btnRegistrarGenero.FlatStyle = FlatStyle.Flat;
            btnRegistrarGenero.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrarGenero.ForeColor = Color.White;
            btnRegistrarGenero.Location = new Point(440, 98);
            btnRegistrarGenero.Name = "btnRegistrarGenero";
            btnRegistrarGenero.Size = new Size(144, 33);
            btnRegistrarGenero.TabIndex = 13;
            btnRegistrarGenero.Text = "Buscar";
            btnRegistrarGenero.UseVisualStyleBackColor = false;
            btnRegistrarGenero.Click += btnRegistrarAtor_Click;
            // 
            // TxtGenero
            // 
            TxtGenero.Location = new Point(12, 104);
            TxtGenero.Name = "TxtGenero";
            TxtGenero.Size = new Size(370, 27);
            TxtGenero.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(12, 72);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 8;
            label3.Text = "Genero:";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(70, 103, 142);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(btnCerrar);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(0, -2);
            panel2.Name = "panel2";
            panel2.Size = new Size(596, 53);
            panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.libro;
            pictureBox1.Location = new Point(15, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(29, 34);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.Red;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCerrar.ForeColor = Color.White;
            btnCerrar.Location = new Point(553, 12);
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
            label2.Location = new Point(50, 12);
            label2.Name = "label2";
            label2.Size = new Size(90, 29);
            label2.TabIndex = 1;
            label2.Text = "Genero";
            // 
            // NuevoGenero
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(601, 319);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "NuevoGenero";
            Text = "NuevoGenero";
            Shown += NuevoGenero_Show;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtGenero).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnRegistrarGenero;
        private TextBox TxtGenero;
        private Label label3;
        private Panel panel2;
        private Button btnCerrar;
        private Label label2;
        private PictureBox pictureBox1;
        private DataGridView dtAutor;
        private Button button1;
        private DataGridView dtGenero;
    }
}