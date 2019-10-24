namespace LinqEj3
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.DGV_Estados = new System.Windows.Forms.DataGridView();
            this.TXT_Agregar = new System.Windows.Forms.TextBox();
            this.BTN_Agregar = new System.Windows.Forms.Button();
            this.BTN_Editar = new System.Windows.Forms.Button();
            this.LBL_Estados_Editar = new System.Windows.Forms.Label();
            this.TXT_Editar_3 = new System.Windows.Forms.TextBox();
            this.TXT_Editar_2 = new System.Windows.Forms.TextBox();
            this.BTN_Borrar = new System.Windows.Forms.Button();
            this.TXT_Editar_1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Estados)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_Estados
            // 
            this.DGV_Estados.AllowUserToAddRows = false;
            this.DGV_Estados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Estados.Location = new System.Drawing.Point(43, 154);
            this.DGV_Estados.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DGV_Estados.Name = "DGV_Estados";
            this.DGV_Estados.ReadOnly = true;
            this.DGV_Estados.RowHeadersWidth = 62;
            this.DGV_Estados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Estados.Size = new System.Drawing.Size(622, 258);
            this.DGV_Estados.TabIndex = 1;
            this.DGV_Estados.TabStop = false;
            this.DGV_Estados.SelectionChanged += new System.EventHandler(this.DataGridView1_SelectionChanged);
            // 
            // TXT_Agregar
            // 
            this.TXT_Agregar.Location = new System.Drawing.Point(304, 49);
            this.TXT_Agregar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TXT_Agregar.Name = "TXT_Agregar";
            this.TXT_Agregar.Size = new System.Drawing.Size(361, 26);
            this.TXT_Agregar.TabIndex = 0;
            // 
            // BTN_Agregar
            // 
            this.BTN_Agregar.Location = new System.Drawing.Point(673, 44);
            this.BTN_Agregar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTN_Agregar.Name = "BTN_Agregar";
            this.BTN_Agregar.Size = new System.Drawing.Size(170, 37);
            this.BTN_Agregar.TabIndex = 1;
            this.BTN_Agregar.Text = "agregar";
            this.BTN_Agregar.UseVisualStyleBackColor = true;
            this.BTN_Agregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BTN_Editar
            // 
            this.BTN_Editar.Location = new System.Drawing.Point(673, 91);
            this.BTN_Editar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTN_Editar.Name = "BTN_Editar";
            this.BTN_Editar.Size = new System.Drawing.Size(170, 37);
            this.BTN_Editar.TabIndex = 3;
            this.BTN_Editar.Text = "editar";
            this.BTN_Editar.UseVisualStyleBackColor = true;
            this.BTN_Editar.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // LBL_Estados_Editar
            // 
            this.LBL_Estados_Editar.AccessibleName = "";
            this.LBL_Estados_Editar.AutoSize = true;
            this.LBL_Estados_Editar.Location = new System.Drawing.Point(46, 99);
            this.LBL_Estados_Editar.Name = "LBL_Estados_Editar";
            this.LBL_Estados_Editar.Size = new System.Drawing.Size(60, 20);
            this.LBL_Estados_Editar.TabIndex = 2;
            this.LBL_Estados_Editar.Text = "Estado";
            // 
            // TXT_Editar_3
            // 
            this.TXT_Editar_3.Location = new System.Drawing.Point(485, 96);
            this.TXT_Editar_3.Name = "TXT_Editar_3";
            this.TXT_Editar_3.Size = new System.Drawing.Size(180, 26);
            this.TXT_Editar_3.TabIndex = 2;
            // 
            // TXT_Editar_2
            // 
            this.TXT_Editar_2.Location = new System.Drawing.Point(304, 96);
            this.TXT_Editar_2.Name = "TXT_Editar_2";
            this.TXT_Editar_2.ReadOnly = true;
            this.TXT_Editar_2.Size = new System.Drawing.Size(175, 26);
            this.TXT_Editar_2.TabIndex = 9;
            this.TXT_Editar_2.TabStop = false;
            // 
            // BTN_Borrar
            // 
            this.BTN_Borrar.Location = new System.Drawing.Point(673, 154);
            this.BTN_Borrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTN_Borrar.Name = "BTN_Borrar";
            this.BTN_Borrar.Size = new System.Drawing.Size(170, 37);
            this.BTN_Borrar.TabIndex = 5;
            this.BTN_Borrar.Text = "borrar";
            this.BTN_Borrar.UseVisualStyleBackColor = true;
            this.BTN_Borrar.Click += new System.EventHandler(this.Button2_Click);
            // 
            // TXT_Editar_1
            // 
            this.TXT_Editar_1.Location = new System.Drawing.Point(123, 96);
            this.TXT_Editar_1.Name = "TXT_Editar_1";
            this.TXT_Editar_1.ReadOnly = true;
            this.TXT_Editar_1.Size = new System.Drawing.Size(175, 26);
            this.TXT_Editar_1.TabIndex = 2;
            this.TXT_Editar_1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 447);
            this.Controls.Add(this.TXT_Editar_1);
            this.Controls.Add(this.BTN_Borrar);
            this.Controls.Add(this.LBL_Estados_Editar);
            this.Controls.Add(this.TXT_Editar_3);
            this.Controls.Add(this.TXT_Editar_2);
            this.Controls.Add(this.BTN_Editar);
            this.Controls.Add(this.BTN_Agregar);
            this.Controls.Add(this.TXT_Agregar);
            this.Controls.Add(this.DGV_Estados);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Estados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView DGV_Estados;
        private System.Windows.Forms.TextBox TXT_Agregar;
        private System.Windows.Forms.Button BTN_Agregar;
        private System.Windows.Forms.Button BTN_Editar;
        private System.Windows.Forms.Label LBL_Estados_Editar;
        private System.Windows.Forms.TextBox TXT_Editar_3;
        private System.Windows.Forms.TextBox TXT_Editar_2;
        private System.Windows.Forms.Button BTN_Borrar;
        private System.Windows.Forms.TextBox TXT_Editar_1;
    }
}

