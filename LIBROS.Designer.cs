namespace matricula_cole
{
    partial class LIBROS
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textlibro = new TextBox();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            button1 = new Button();
            textprecio = new TextBox();
            textcantidad = new TextBox();
            button2 = new Button();
            label4 = new Label();
            textTotalGeneral = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 16);
            label1.Name = "label1";
            label1.Size = new Size(43, 20);
            label1.TabIndex = 0;
            label1.Text = "Libro";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 102);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 1;
            label2.Text = "Precio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 185);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 2;
            label3.Text = "Cantidad";
            // 
            // textlibro
            // 
            textlibro.Location = new Point(35, 52);
            textlibro.Name = "textlibro";
            textlibro.Size = new Size(192, 27);
            textlibro.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridView1.Location = new Point(43, 319);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(554, 188);
            dataGridView1.TabIndex = 6;
            // 
            // Column1
            // 
            Column1.HeaderText = "Libro";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Precio";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Cantidad";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Precio";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // button1
            // 
            button1.Location = new Point(43, 263);
            button1.Name = "button1";
            button1.Size = new Size(184, 29);
            button1.TabIndex = 7;
            button1.Text = "REGISTAR LIBRO";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textprecio
            // 
            textprecio.Location = new Point(43, 140);
            textprecio.Name = "textprecio";
            textprecio.Size = new Size(125, 27);
            textprecio.TabIndex = 8;
            // 
            // textcantidad
            // 
            textcantidad.Location = new Point(46, 228);
            textcantidad.Name = "textcantidad";
            textcantidad.Size = new Size(125, 27);
            textcantidad.TabIndex = 9;
            // 
            // button2
            // 
            button2.Location = new Point(202, 156);
            button2.Name = "button2";
            button2.Size = new Size(128, 79);
            button2.TabIndex = 10;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 537);
            label4.Name = "label4";
            label4.Size = new Size(100, 20);
            label4.TabIndex = 11;
            label4.Text = "Total a pagar:";
            // 
            // textTotalGeneral
            // 
            textTotalGeneral.Location = new Point(129, 534);
            textTotalGeneral.Name = "textTotalGeneral";
            textTotalGeneral.Size = new Size(125, 27);
            textTotalGeneral.TabIndex = 12;
            // 
            // LIBROS
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(612, 585);
            Controls.Add(textTotalGeneral);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(textcantidad);
            Controls.Add(textprecio);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(textlibro);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "LIBROS";
            Text = "LIBROS";
            Load += LIBROS_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textlibro;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private Button button1;
        private TextBox textprecio;
        private TextBox textcantidad;
        private Button button2;
        private Label label4;
        private TextBox textTotalGeneral;
    }
}