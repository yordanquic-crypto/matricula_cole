namespace matricula_cole
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textnombre = new TextBox();
            textdni = new TextBox();
            textapoderado = new TextBox();
            comboBox1 = new ComboBox();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            APODERADO = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            button2 = new Button();
            label5 = new Label();
            textMONTO = new TextBox();
            button3 = new Button();
            label6 = new Label();
            textTotalMonto = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 10);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 0;
            label1.Text = "NOMBRE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 53);
            label2.Name = "label2";
            label2.Size = new Size(35, 20);
            label2.TabIndex = 1;
            label2.Text = "DNI";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 99);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 2;
            label3.Text = "GRADO";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 142);
            label4.Name = "label4";
            label4.Size = new Size(98, 20);
            label4.TabIndex = 3;
            label4.Text = "APODERADO";
            // 
            // textnombre
            // 
            textnombre.Location = new Point(126, 7);
            textnombre.Name = "textnombre";
            textnombre.Size = new Size(125, 27);
            textnombre.TabIndex = 4;
            // 
            // textdni
            // 
            textdni.Location = new Point(126, 50);
            textdni.Name = "textdni";
            textdni.Size = new Size(125, 27);
            textdni.TabIndex = 5;
            // 
            // textapoderado
            // 
            textapoderado.Location = new Point(126, 143);
            textapoderado.Name = "textapoderado";
            textapoderado.Size = new Size(125, 27);
            textapoderado.TabIndex = 7;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Primero de primaria", "Segundo de primaria", "Tercero de primaria", "Cuarto de primaria", "Quinto de primaria", "Sexto de primaria", "Primero de secundaria", "Segundo de secundaria", "Tercero de secundaria", "Cuarto de secundaria", "Quinto de secundaria" });
            comboBox1.Location = new Point(129, 94);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 8;
            // 
            // button1
            // 
            button1.Location = new Point(320, 31);
            button1.Name = "button1";
            button1.Size = new Size(142, 100);
            button1.TabIndex = 9;
            button1.Text = "REGISTRAR MATRICULA";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, APODERADO, Column4 });
            dataGridView1.Location = new Point(14, 247);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(678, 244);
            dataGridView1.TabIndex = 10;
            // 
            // Column1
            // 
            Column1.HeaderText = "NOMBRE";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "DNI";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "GRADO";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // APODERADO
            // 
            APODERADO.HeaderText = "APODERADO";
            APODERADO.MinimumWidth = 6;
            APODERADO.Name = "APODERADO";
            APODERADO.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "MONTO S/";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // button2
            // 
            button2.Location = new Point(494, 33);
            button2.Name = "button2";
            button2.Size = new Size(108, 98);
            button2.TabIndex = 11;
            button2.Text = "NUEVO";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 195);
            label5.Name = "label5";
            label5.Size = new Size(62, 20);
            label5.TabIndex = 12;
            label5.Text = "MONTO";
            // 
            // textMONTO
            // 
            textMONTO.Location = new Point(125, 196);
            textMONTO.Name = "textMONTO";
            textMONTO.Size = new Size(125, 27);
            textMONTO.TabIndex = 13;
            // 
            // button3
            // 
            button3.Location = new Point(636, 33);
            button3.Name = "button3";
            button3.Size = new Size(94, 98);
            button3.TabIndex = 14;
            button3.Text = "SIGUIENTE";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(22, 526);
            label6.Name = "label6";
            label6.Size = new Size(146, 31);
            label6.TabIndex = 15;
            label6.Text = "Precio Total:";
            // 
            // textTotalMonto
            // 
            textTotalMonto.Location = new Point(174, 532);
            textTotalMonto.Name = "textTotalMonto";
            textTotalMonto.Size = new Size(125, 27);
            textTotalMonto.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 586);
            Controls.Add(textTotalMonto);
            Controls.Add(label6);
            Controls.Add(button3);
            Controls.Add(textMONTO);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(textapoderado);
            Controls.Add(textdni);
            Controls.Add(textnombre);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textnombre;
        private TextBox textdni;
        private TextBox textapoderado;
        private ComboBox comboBox1;
        private Button button1;
        private DataGridView dataGridView1;
        private Button button2;
        private Label label5;
        private TextBox textMONTO;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn APODERADO;
        private DataGridViewTextBoxColumn Column4;
        private Button button3;
        private Label label6;
        private TextBox textTotalMonto;
    }
}
