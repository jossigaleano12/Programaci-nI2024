namespace CRUDALUMNOS
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
            button_acep = new Button();
            label1 = new Label();
            textBox_nom = new TextBox();
            dataGridView1 = new DataGridView();
            textBox_Carnet = new TextBox();
            Carnet = new Label();
            textBox_Num = new TextBox();
            label3 = new Label();
            button_eli_persona = new Button();
            button_eliminar = new Button();
            textBox_id = new TextBox();
            label4 = new Label();
            label2 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button_acep
            // 
            button_acep.Location = new Point(403, 515);
            button_acep.Margin = new Padding(3, 4, 3, 4);
            button_acep.Name = "button_acep";
            button_acep.Size = new Size(145, 51);
            button_acep.TabIndex = 0;
            button_acep.Text = "Aceptar / Guardar";
            button_acep.UseVisualStyleBackColor = true;
            button_acep.Click += button_acep_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 183);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 1;
            label1.Text = "Nombre";
            // 
            // textBox_nom
            // 
            textBox_nom.Location = new Point(145, 181);
            textBox_nom.Margin = new Padding(3, 4, 3, 4);
            textBox_nom.Name = "textBox_nom";
            textBox_nom.Size = new Size(114, 27);
            textBox_nom.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(371, 64);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(514, 443);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // textBox_Carnet
            // 
            textBox_Carnet.Location = new Point(145, 241);
            textBox_Carnet.Margin = new Padding(3, 4, 3, 4);
            textBox_Carnet.Name = "textBox_Carnet";
            textBox_Carnet.Size = new Size(114, 27);
            textBox_Carnet.TabIndex = 5;
            textBox_Carnet.TextChanged += textBox_edad_TextChanged;
            // 
            // Carnet
            // 
            Carnet.AutoSize = true;
            Carnet.Location = new Point(61, 241);
            Carnet.Name = "Carnet";
            Carnet.Size = new Size(52, 20);
            Carnet.TabIndex = 4;
            Carnet.Text = "Carnet";
            // 
            // textBox_Num
            // 
            textBox_Num.Location = new Point(145, 293);
            textBox_Num.Margin = new Padding(3, 4, 3, 4);
            textBox_Num.Name = "textBox_Num";
            textBox_Num.Size = new Size(114, 27);
            textBox_Num.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(61, 293);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 6;
            label3.Text = "Telefono";
            // 
            // button_eli_persona
            // 
            button_eli_persona.Location = new Point(580, 515);
            button_eli_persona.Margin = new Padding(3, 4, 3, 4);
            button_eli_persona.Name = "button_eli_persona";
            button_eli_persona.Size = new Size(145, 51);
            button_eli_persona.TabIndex = 8;
            button_eli_persona.Text = "Eliminar";
            button_eli_persona.UseVisualStyleBackColor = true;
            button_eli_persona.Click += button1_Click;
            // 
            // button_eliminar
            // 
            button_eliminar.Location = new Point(740, 515);
            button_eliminar.Margin = new Padding(3, 4, 3, 4);
            button_eliminar.Name = "button_eliminar";
            button_eliminar.Size = new Size(145, 48);
            button_eliminar.TabIndex = 9;
            button_eliminar.Text = "Limpiar pantalla";
            button_eliminar.UseVisualStyleBackColor = true;
            button_eliminar.Click += button_eliminar_Click;
            // 
            // textBox_id
            // 
            textBox_id.Enabled = false;
            textBox_id.Location = new Point(145, 120);
            textBox_id.Margin = new Padding(3, 4, 3, 4);
            textBox_id.Name = "textBox_id";
            textBox_id.Size = new Size(114, 27);
            textBox_id.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(62, 121);
            label4.Name = "label4";
            label4.Size = new Size(24, 20);
            label4.TabIndex = 10;
            label4.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(63, 344);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 12;
            label2.Text = "Grado";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(63, 399);
            label5.Name = "label5";
            label5.Size = new Size(59, 20);
            label5.TabIndex = 13;
            label5.Text = "Usuario";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(145, 344);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(114, 27);
            textBox1.TabIndex = 14;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(145, 396);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(114, 27);
            textBox2.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(textBox_id);
            Controls.Add(label4);
            Controls.Add(button_eliminar);
            Controls.Add(button_eli_persona);
            Controls.Add(textBox_Num);
            Controls.Add(label3);
            Controls.Add(textBox_Carnet);
            Controls.Add(Carnet);
            Controls.Add(dataGridView1);
            Controls.Add(textBox_nom);
            Controls.Add(label1);
            Controls.Add(button_acep);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_acep;
        private Label label1;
        private TextBox textBox_nom;
        private DataGridView dataGridView1;
        private TextBox textBox_Carnet;
        private Label Carnet;
        private TextBox textBox_Num;
        private Label label3;
        private Button button_eli_persona;
        private Button button_eliminar;
        private TextBox textBox_id;
        private Label label4;
        private Label label2;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}
