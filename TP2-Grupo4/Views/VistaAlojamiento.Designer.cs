
namespace TP2_Grupo4.Views
{
    partial class VistaAlojamiento
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
            this.lblAlojamiento = new System.Windows.Forms.Label();
            this.dgvAlojamiento = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.checkBoxTv = new System.Windows.Forms.CheckBox();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBarrio = new System.Windows.Forms.TextBox();
            this.comboBoxCantPersonas = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxEstrellas = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxTipoAloj = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlojamiento)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAlojamiento
            // 
            this.lblAlojamiento.AutoSize = true;
            this.lblAlojamiento.Font = new System.Drawing.Font("Arial", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAlojamiento.ForeColor = System.Drawing.Color.Black;
            this.lblAlojamiento.Location = new System.Drawing.Point(370, 7);
            this.lblAlojamiento.Name = "lblAlojamiento";
            this.lblAlojamiento.Size = new System.Drawing.Size(260, 45);
            this.lblAlojamiento.TabIndex = 0;
            this.lblAlojamiento.Text = "Alojamientos";
            // 
            // dgvAlojamiento
            // 
            this.dgvAlojamiento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAlojamiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlojamiento.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvAlojamiento.Location = new System.Drawing.Point(12, 174);
            this.dgvAlojamiento.Name = "dgvAlojamiento";
            this.dgvAlojamiento.RowTemplate.Height = 25;
            this.dgvAlojamiento.Size = new System.Drawing.Size(976, 376);
            this.dgvAlojamiento.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.checkBoxTv);
            this.groupBox1.Controls.Add(this.txtCiudad);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.txtPrecio);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtBarrio);
            this.groupBox1.Controls.Add(this.comboBoxCantPersonas);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.comboBoxEstrellas);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(84, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(842, 117);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ordenamiento";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(114, 19);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(121, 23);
            this.txtCodigo.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(60, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 15);
            this.label10.TabIndex = 0;
            this.label10.Text = "Código:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(485, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 15);
            this.label9.TabIndex = 14;
            this.label9.Text = "Hasta:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(501, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 15);
            this.label8.TabIndex = 12;
            this.label8.Text = "De:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(531, 84);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 23);
            this.textBox4.TabIndex = 9;
            // 
            // checkBoxTv
            // 
            this.checkBoxTv.AutoSize = true;
            this.checkBoxTv.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxTv.Location = new System.Drawing.Point(316, 86);
            this.checkBoxTv.Name = "checkBoxTv";
            this.checkBoxTv.Size = new System.Drawing.Size(78, 19);
            this.checkBoxTv.TabIndex = 8;
            this.checkBoxTv.Text = "¿Tiene Tv?";
            this.checkBoxTv.UseVisualStyleBackColor = true;
            // 
            // txtCiudad
            // 
            this.txtCiudad.Location = new System.Drawing.Point(114, 53);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(121, 23);
            this.txtCiudad.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(60, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 15);
            this.label7.TabIndex = 9;
            this.label7.Text = "Ciudad:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(531, 53);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 23);
            this.textBox3.TabIndex = 6;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(531, 19);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 23);
            this.txtPrecio.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(457, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Fecha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(485, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Precio";
            // 
            // txtBarrio
            // 
            this.txtBarrio.Location = new System.Drawing.Point(114, 84);
            this.txtBarrio.Name = "txtBarrio";
            this.txtBarrio.Size = new System.Drawing.Size(121, 23);
            this.txtBarrio.TabIndex = 7;
            // 
            // comboBoxCantPersonas
            // 
            this.comboBoxCantPersonas.FormattingEnabled = true;
            this.comboBoxCantPersonas.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBoxCantPersonas.Location = new System.Drawing.Point(380, 19);
            this.comboBoxCantPersonas.Name = "comboBoxCantPersonas";
            this.comboBoxCantPersonas.Size = new System.Drawing.Size(65, 23);
            this.comboBoxCantPersonas.TabIndex = 2;
            this.comboBoxCantPersonas.Text = "1";
            this.comboBoxCantPersonas.SelectedIndexChanged += new System.EventHandler(this.comboBoxCantPersonas_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cantidad de Personas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(325, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Estrellas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Barrio:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(692, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 63);
            this.button1.TabIndex = 10;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxEstrellas
            // 
            this.comboBoxEstrellas.FormattingEnabled = true;
            this.comboBoxEstrellas.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5"});
            this.comboBoxEstrellas.Location = new System.Drawing.Point(380, 53);
            this.comboBoxEstrellas.Name = "comboBoxEstrellas";
            this.comboBoxEstrellas.Size = new System.Drawing.Size(53, 23);
            this.comboBoxEstrellas.TabIndex = 5;
            this.comboBoxEstrellas.Text = "1";
            this.comboBoxEstrellas.SelectedIndexChanged += new System.EventHandler(this.comboBoxEstrellas_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo: ";
            // 
            // comboBoxTipoAloj
            // 
            this.comboBoxTipoAloj.FormattingEnabled = true;
            this.comboBoxTipoAloj.Items.AddRange(new object[] {
            "Hotel",
            "Cabaña"});
            this.comboBoxTipoAloj.Location = new System.Drawing.Point(113, 7);
            this.comboBoxTipoAloj.Name = "comboBoxTipoAloj";
            this.comboBoxTipoAloj.Size = new System.Drawing.Size(107, 23);
            this.comboBoxTipoAloj.TabIndex = 1;
            this.comboBoxTipoAloj.Text = "Hotel";
            this.comboBoxTipoAloj.SelectedIndexChanged += new System.EventHandler(this.comboBoxTipoAloj_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(882, 80);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 63);
            this.button2.TabIndex = 11;
            this.button2.Text = "Modificar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // VistaAlojamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvAlojamiento);
            this.Controls.Add(this.lblAlojamiento);
            this.Controls.Add(this.comboBoxTipoAloj);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VistaAlojamiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAlojamiento";
            this.Load += new System.EventHandler(this.FormAlojamiento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlojamiento)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAlojamiento;
        private System.Windows.Forms.DataGridView dgvAlojamiento;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBarrio;
        private System.Windows.Forms.ComboBox comboBoxCantPersonas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxEstrellas;
        private System.Windows.Forms.ComboBox comboBoxTipoAloj;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.CheckBox checkBoxTv;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label10;
    }
}