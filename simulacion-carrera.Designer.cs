namespace simulacion_carrera
{
    partial class Codigo
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Codigo));
            input_arreglo = new TextBox();
            label_arreglo = new Label();
            label_numero = new Label();
            input_numero = new TextBox();
            btn_iniciar = new Button();
            btn_limpiar = new Button();
            label_secuencial = new Label();
            label_binaria = new Label();
            label_burbuja = new Label();
            label_quicksort = new Label();
            label_insercion = new Label();
            label8 = new Label();
            panel1 = new Panel();
            input_binaria_encontrado = new TextBox();
            input_secuencial_encontrado = new TextBox();
            input_secuencial = new TextBox();
            input_binaria = new TextBox();
            panel2 = new Panel();
            btn_aleatorio = new Button();
            input_insercion = new TextBox();
            input_quicksort = new TextBox();
            input_burbuja = new TextBox();
            toolTip1 = new ToolTip(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // input_arreglo
            // 
            input_arreglo.Location = new Point(19, 45);
            input_arreglo.MaxLength = 999999999;
            input_arreglo.Name = "input_arreglo";
            input_arreglo.Size = new Size(305, 27);
            input_arreglo.TabIndex = 1;
            toolTip1.SetToolTip(input_arreglo, "Ingresar números separados por coma (,)");
            // 
            // label_arreglo
            // 
            label_arreglo.AutoSize = true;
            label_arreglo.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label_arreglo.ForeColor = Color.FromArgb(37, 50, 55);
            label_arreglo.Location = new Point(19, 17);
            label_arreglo.Name = "label_arreglo";
            label_arreglo.Size = new Size(161, 25);
            label_arreglo.TabIndex = 0;
            label_arreglo.Text = "Introducir arreglo";
            // 
            // label_numero
            // 
            label_numero.AutoSize = true;
            label_numero.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label_numero.ForeColor = Color.FromArgb(37, 50, 55);
            label_numero.Location = new Point(18, 17);
            label_numero.Name = "label_numero";
            label_numero.Size = new Size(151, 25);
            label_numero.TabIndex = 0;
            label_numero.Text = "Número a buscar";
            // 
            // input_numero
            // 
            input_numero.Location = new Point(18, 45);
            input_numero.Name = "input_numero";
            input_numero.Size = new Size(172, 27);
            input_numero.TabIndex = 2;
            toolTip1.SetToolTip(input_numero, "Ingresar número a buscar en el arreglo");
            // 
            // btn_iniciar
            // 
            btn_iniciar.AccessibleName = "";
            btn_iniciar.BackColor = Color.FromArgb(224, 251, 252);
            btn_iniciar.Cursor = Cursors.Hand;
            btn_iniciar.FlatStyle = FlatStyle.Flat;
            btn_iniciar.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_iniciar.ForeColor = Color.Black;
            btn_iniciar.Location = new Point(208, 43);
            btn_iniciar.Name = "btn_iniciar";
            btn_iniciar.Size = new Size(70, 29);
            btn_iniciar.TabIndex = 3;
            btn_iniciar.Text = "Iniciar";
            toolTip1.SetToolTip(btn_iniciar, "Iniciar carrera");
            btn_iniciar.UseVisualStyleBackColor = false;
            btn_iniciar.Click += btnIniciar_Click;
            // 
            // btn_limpiar
            // 
            btn_limpiar.AccessibleName = "";
            btn_limpiar.BackColor = Color.FromArgb(224, 251, 252);
            btn_limpiar.Cursor = Cursors.Hand;
            btn_limpiar.FlatStyle = FlatStyle.Flat;
            btn_limpiar.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_limpiar.ForeColor = Color.Black;
            btn_limpiar.Location = new Point(284, 43);
            btn_limpiar.Name = "btn_limpiar";
            btn_limpiar.Size = new Size(39, 29);
            btn_limpiar.TabIndex = 4;
            btn_limpiar.Text = "X";
            toolTip1.SetToolTip(btn_limpiar, "Limpiar campos");
            btn_limpiar.UseVisualStyleBackColor = false;
            btn_limpiar.Click += btn_limpiar_Click;
            // 
            // label_secuencial
            // 
            label_secuencial.AutoSize = true;
            label_secuencial.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label_secuencial.ForeColor = Color.FromArgb(37, 50, 55);
            label_secuencial.Location = new Point(18, 137);
            label_secuencial.Name = "label_secuencial";
            label_secuencial.Size = new Size(156, 21);
            label_secuencial.TabIndex = 6;
            label_secuencial.Text = "Búsqueda Secuencial";
            // 
            // label_binaria
            // 
            label_binaria.AutoSize = true;
            label_binaria.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label_binaria.ForeColor = Color.FromArgb(37, 50, 55);
            label_binaria.Location = new Point(193, 137);
            label_binaria.Name = "label_binaria";
            label_binaria.Size = new Size(130, 21);
            label_binaria.TabIndex = 7;
            label_binaria.Text = "Búsqueda Binaria";
            // 
            // label_burbuja
            // 
            label_burbuja.AutoSize = true;
            label_burbuja.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label_burbuja.ForeColor = Color.FromArgb(37, 50, 55);
            label_burbuja.Location = new Point(28, 137);
            label_burbuja.Name = "label_burbuja";
            label_burbuja.Size = new Size(65, 21);
            label_burbuja.TabIndex = 8;
            label_burbuja.Text = "Burbuja";
            // 
            // label_quicksort
            // 
            label_quicksort.AutoSize = true;
            label_quicksort.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label_quicksort.ForeColor = Color.FromArgb(37, 50, 55);
            label_quicksort.Location = new Point(146, 137);
            label_quicksort.Name = "label_quicksort";
            label_quicksort.Size = new Size(80, 21);
            label_quicksort.TabIndex = 9;
            label_quicksort.Text = "Quicksort";
            // 
            // label_insercion
            // 
            label_insercion.AutoSize = true;
            label_insercion.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label_insercion.ForeColor = Color.FromArgb(37, 50, 55);
            label_insercion.Location = new Point(274, 137);
            label_insercion.Name = "label_insercion";
            label_insercion.Size = new Size(76, 21);
            label_insercion.TabIndex = 10;
            label_insercion.Text = "Inserción";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(359, 238);
            label8.Name = "label8";
            label8.Size = new Size(0, 20);
            label8.TabIndex = 11;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(157, 180, 192);
            panel1.Controls.Add(input_binaria_encontrado);
            panel1.Controls.Add(input_secuencial_encontrado);
            panel1.Controls.Add(input_secuencial);
            panel1.Controls.Add(input_binaria);
            panel1.Controls.Add(label_binaria);
            panel1.Controls.Add(label_secuencial);
            panel1.Controls.Add(label_numero);
            panel1.Controls.Add(input_numero);
            panel1.Controls.Add(btn_iniciar);
            panel1.Controls.Add(btn_limpiar);
            panel1.Location = new Point(397, 7);
            panel1.Name = "panel1";
            panel1.Size = new Size(341, 398);
            panel1.TabIndex = 12;
            // 
            // input_binaria_encontrado
            // 
            input_binaria_encontrado.BackColor = Color.FromArgb(157, 180, 192);
            input_binaria_encontrado.BorderStyle = BorderStyle.None;
            input_binaria_encontrado.Enabled = false;
            input_binaria_encontrado.Font = new Font("Comic Sans MS", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            input_binaria_encontrado.ForeColor = Color.FromArgb(37, 50, 55);
            input_binaria_encontrado.Location = new Point(193, 197);
            input_binaria_encontrado.Name = "input_binaria_encontrado";
            input_binaria_encontrado.ReadOnly = true;
            input_binaria_encontrado.Size = new Size(130, 19);
            input_binaria_encontrado.TabIndex = 16;
            input_binaria_encontrado.TextAlign = HorizontalAlignment.Center;
            // 
            // input_secuencial_encontrado
            // 
            input_secuencial_encontrado.BackColor = Color.FromArgb(157, 180, 192);
            input_secuencial_encontrado.BorderStyle = BorderStyle.None;
            input_secuencial_encontrado.Enabled = false;
            input_secuencial_encontrado.Font = new Font("Comic Sans MS", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            input_secuencial_encontrado.ForeColor = Color.FromArgb(37, 50, 55);
            input_secuencial_encontrado.Location = new Point(18, 197);
            input_secuencial_encontrado.Name = "input_secuencial_encontrado";
            input_secuencial_encontrado.ReadOnly = true;
            input_secuencial_encontrado.Size = new Size(151, 19);
            input_secuencial_encontrado.TabIndex = 15;
            input_secuencial_encontrado.TextAlign = HorizontalAlignment.Center;
            // 
            // input_secuencial
            // 
            input_secuencial.BackColor = Color.FromArgb(92, 107, 115);
            input_secuencial.BorderStyle = BorderStyle.None;
            input_secuencial.Font = new Font("Comic Sans MS", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            input_secuencial.ForeColor = Color.FromArgb(224, 251, 252);
            input_secuencial.Location = new Point(18, 161);
            input_secuencial.Name = "input_secuencial";
            input_secuencial.ReadOnly = true;
            input_secuencial.Size = new Size(151, 19);
            input_secuencial.TabIndex = 15;
            input_secuencial.TextAlign = HorizontalAlignment.Center;
            // 
            // input_binaria
            // 
            input_binaria.BackColor = Color.FromArgb(92, 107, 115);
            input_binaria.BorderStyle = BorderStyle.None;
            input_binaria.Font = new Font("Comic Sans MS", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            input_binaria.ForeColor = Color.FromArgb(224, 251, 252);
            input_binaria.Location = new Point(193, 162);
            input_binaria.Name = "input_binaria";
            input_binaria.ReadOnly = true;
            input_binaria.Size = new Size(130, 19);
            input_binaria.TabIndex = 13;
            input_binaria.TextAlign = HorizontalAlignment.Center;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(157, 180, 192);
            panel2.Controls.Add(btn_aleatorio);
            panel2.Controls.Add(input_insercion);
            panel2.Controls.Add(input_quicksort);
            panel2.Controls.Add(input_burbuja);
            panel2.Controls.Add(input_arreglo);
            panel2.Controls.Add(label_insercion);
            panel2.Controls.Add(label_arreglo);
            panel2.Controls.Add(label_burbuja);
            panel2.Controls.Add(label_quicksort);
            panel2.Location = new Point(12, 7);
            panel2.Name = "panel2";
            panel2.Size = new Size(379, 398);
            panel2.TabIndex = 13;
            // 
            // btn_aleatorio
            // 
            btn_aleatorio.BackColor = Color.FromArgb(224, 251, 252);
            btn_aleatorio.BackgroundImage = (Image)resources.GetObject("btn_aleatorio.BackgroundImage");
            btn_aleatorio.BackgroundImageLayout = ImageLayout.Center;
            btn_aleatorio.Cursor = Cursors.Hand;
            btn_aleatorio.FlatStyle = FlatStyle.Flat;
            btn_aleatorio.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_aleatorio.ForeColor = Color.FromArgb(92, 107, 115);
            btn_aleatorio.Location = new Point(334, 45);
            btn_aleatorio.Name = "btn_aleatorio";
            btn_aleatorio.Size = new Size(31, 27);
            btn_aleatorio.TabIndex = 16;
            btn_aleatorio.Tag = "";
            toolTip1.SetToolTip(btn_aleatorio, "Generar números aleatorios");
            btn_aleatorio.UseVisualStyleBackColor = false;
            btn_aleatorio.Click += btn_aleatorio_Click_1;
            // 
            // input_insercion
            // 
            input_insercion.BackColor = Color.FromArgb(92, 107, 115);
            input_insercion.BorderStyle = BorderStyle.None;
            input_insercion.Font = new Font("Comic Sans MS", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            input_insercion.ForeColor = Color.FromArgb(224, 251, 252);
            input_insercion.Location = new Point(256, 162);
            input_insercion.Name = "input_insercion";
            input_insercion.ReadOnly = true;
            input_insercion.Size = new Size(109, 19);
            input_insercion.TabIndex = 14;
            input_insercion.TextAlign = HorizontalAlignment.Center;
            // 
            // input_quicksort
            // 
            input_quicksort.BackColor = Color.FromArgb(92, 107, 115);
            input_quicksort.BorderStyle = BorderStyle.None;
            input_quicksort.Font = new Font("Comic Sans MS", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            input_quicksort.ForeColor = Color.FromArgb(224, 251, 252);
            input_quicksort.Location = new Point(129, 162);
            input_quicksort.Name = "input_quicksort";
            input_quicksort.ReadOnly = true;
            input_quicksort.Size = new Size(110, 19);
            input_quicksort.TabIndex = 12;
            input_quicksort.TextAlign = HorizontalAlignment.Center;
            // 
            // input_burbuja
            // 
            input_burbuja.BackColor = Color.FromArgb(92, 107, 115);
            input_burbuja.BorderStyle = BorderStyle.None;
            input_burbuja.Font = new Font("Comic Sans MS", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            input_burbuja.ForeColor = Color.FromArgb(224, 251, 252);
            input_burbuja.Location = new Point(10, 162);
            input_burbuja.Name = "input_burbuja";
            input_burbuja.ReadOnly = true;
            input_burbuja.Size = new Size(100, 19);
            input_burbuja.TabIndex = 11;
            input_burbuja.TextAlign = HorizontalAlignment.Center;
            // 
            // toolTip1
            // 
            toolTip1.Popup += toolTip1_Popup;
            // 
            // Codigo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(37, 50, 55);
            ClientSize = new Size(745, 416);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label8);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Codigo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Simulación de carrera";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox input_arreglo;
        private Label label_arreglo;
        private Label label_numero;
        private TextBox input_numero;
        private Button btn_iniciar;
        private Button btn_limpiar;
        private Label label_secuencial;
        private Label label_binaria;
        private Label label_burbuja;
        private Label label_quicksort;
        private Label label_insercion;
        private Label label8;
        private Panel panel1;
        private Panel panel2;
        private TextBox input_secuencial;
        private TextBox input_binaria;
        private TextBox input_insercion;
        private TextBox input_quicksort;
        private TextBox input_burbuja;
        private TextBox input_secuencial_encontrado;
        private Button btn_aleatorio;
        private ToolTip toolTip1;
        private TextBox input_binaria_encontrado;
    }
}