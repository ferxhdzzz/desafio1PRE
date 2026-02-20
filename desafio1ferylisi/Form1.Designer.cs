namespace desafio1ferylisi
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtmontoTotal = new System.Windows.Forms.TextBox();
			this.txtprecioProducto = new System.Windows.Forms.TextBox();
			this.cmbCategoria = new System.Windows.Forms.ComboBox();
			this.btncalcular = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.lbPrecioTotal = new System.Windows.Forms.Label();
			this.Descuento = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Garamond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
			this.label1.Location = new System.Drawing.Point(11, 199);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(276, 21);
			this.label1.TabIndex = 0;
			this.label1.Text = "Ingrese el monto total de la compra";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.label2.Location = new System.Drawing.Point(316, 306);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(0, 18);
			this.label2.TabIndex = 1;
			// 
			// txtmontoTotal
			// 
			this.txtmontoTotal.BackColor = System.Drawing.SystemColors.InfoText;
			this.txtmontoTotal.Location = new System.Drawing.Point(293, 187);
			this.txtmontoTotal.Multiline = true;
			this.txtmontoTotal.Name = "txtmontoTotal";
			this.txtmontoTotal.Size = new System.Drawing.Size(114, 41);
			this.txtmontoTotal.TabIndex = 2;
			// 
			// txtprecioProducto
			// 
			this.txtprecioProducto.BackColor = System.Drawing.SystemColors.InfoText;
			this.txtprecioProducto.Location = new System.Drawing.Point(249, 108);
			this.txtprecioProducto.Multiline = true;
			this.txtprecioProducto.Name = "txtprecioProducto";
			this.txtprecioProducto.Size = new System.Drawing.Size(117, 37);
			this.txtprecioProducto.TabIndex = 3;
			this.txtprecioProducto.TextChanged += new System.EventHandler(this.txtprecioProducto_TextChanged);
			// 
			// cmbCategoria
			// 
			this.cmbCategoria.BackColor = System.Drawing.SystemColors.ControlLight;
			this.cmbCategoria.DropDownHeight = 168;
			this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
			this.cmbCategoria.ForeColor = System.Drawing.SystemColors.InfoText;
			this.cmbCategoria.FormattingEnabled = true;
			this.cmbCategoria.IntegralHeight = false;
			this.cmbCategoria.ItemHeight = 18;
			this.cmbCategoria.Location = new System.Drawing.Point(221, 269);
			this.cmbCategoria.Name = "cmbCategoria";
			this.cmbCategoria.Size = new System.Drawing.Size(126, 26);
			this.cmbCategoria.TabIndex = 4;
			this.cmbCategoria.SelectedIndexChanged += new System.EventHandler(this.cmbCategoria_SelectedIndexChanged);
			// 
			// btncalcular
			// 
			this.btncalcular.BackColor = System.Drawing.Color.SteelBlue;
			this.btncalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btncalcular.Font = new System.Drawing.Font("Garamond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btncalcular.ForeColor = System.Drawing.SystemColors.InfoText;
			this.btncalcular.Location = new System.Drawing.Point(385, 351);
			this.btncalcular.Name = "btncalcular";
			this.btncalcular.Size = new System.Drawing.Size(107, 38);
			this.btncalcular.TabIndex = 5;
			this.btncalcular.Text = "Calcular";
			this.btncalcular.UseVisualStyleBackColor = false;
			this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Garamond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
			this.label3.Location = new System.Drawing.Point(7, 271);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(190, 21);
			this.label3.TabIndex = 6;
			this.label3.Text = "Seleccione una categoria";
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Garamond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.SystemColors.Window;
			this.label4.Location = new System.Drawing.Point(11, 124);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(232, 21);
			this.label4.TabIndex = 7;
			this.label4.Text = "Ingrese el precio del producto";
			this.label4.Click += new System.EventHandler(this.label4_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.SteelBlue;
			this.label5.Font = new System.Drawing.Font("Imprint MT Shadow", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.MenuText;
			this.label5.Location = new System.Drawing.Point(28, 27);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(436, 42);
			this.label5.TabIndex = 8;
			this.label5.Text = "Calculadora de descuentos";
			this.label5.Click += new System.EventHandler(this.label5_Click);
			// 
			// lbPrecioTotal
			// 
			this.lbPrecioTotal.AutoSize = true;
			this.lbPrecioTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbPrecioTotal.Location = new System.Drawing.Point(131, 342);
			this.lbPrecioTotal.Name = "lbPrecioTotal";
			this.lbPrecioTotal.Size = new System.Drawing.Size(0, 20);
			this.lbPrecioTotal.TabIndex = 9;
			this.lbPrecioTotal.Click += new System.EventHandler(this.lbPrecioTotal_Click);
			// 
			// Descuento
			// 
			this.Descuento.AutoSize = true;
			this.Descuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Descuento.Location = new System.Drawing.Point(132, 388);
			this.Descuento.Name = "Descuento";
			this.Descuento.Size = new System.Drawing.Size(0, 20);
			this.Descuento.TabIndex = 10;
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.Color.SteelBlue;
			this.textBox1.Location = new System.Drawing.Point(-12, -2);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(838, 91);
			this.textBox1.TabIndex = 11;
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.SkyBlue;
			this.ClientSize = new System.Drawing.Size(504, 401);
			this.Controls.Add(this.Descuento);
			this.Controls.Add(this.lbPrecioTotal);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btncalcular);
			this.Controls.Add(this.cmbCategoria);
			this.Controls.Add(this.txtprecioProducto);
			this.Controls.Add(this.txtmontoTotal);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox1);
			this.ForeColor = System.Drawing.SystemColors.Menu;
			this.Name = "Form1";
			this.Text = "Calculadora de descuentos";
			this.TransparencyKey = System.Drawing.Color.Black;
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmontoTotal;
        private System.Windows.Forms.TextBox txtprecioProducto;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbPrecioTotal;
        private System.Windows.Forms.Label Descuento;
        private System.Windows.Forms.TextBox textBox1;
    }
}

