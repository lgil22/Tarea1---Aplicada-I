namespace CAP2.Tarea3
{
    partial class estructura
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
            this.Nombrelabel1 = new System.Windows.Forms.Label();
            this.NombretextBox1 = new System.Windows.Forms.TextBox();
            this.ProductoNewtextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ProductocomboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Eliminarbutton2 = new System.Windows.Forms.Button();
            this.Seleccionlabel2 = new System.Windows.Forms.Label();
            this.Salirbutton2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Nombrelabel1
            // 
            this.Nombrelabel1.AutoSize = true;
            this.Nombrelabel1.Location = new System.Drawing.Point(11, 25);
            this.Nombrelabel1.Name = "Nombrelabel1";
            this.Nombrelabel1.Size = new System.Drawing.Size(90, 13);
            this.Nombrelabel1.TabIndex = 0;
            this.Nombrelabel1.Text = "Nombre Producto";
            // 
            // NombretextBox1
            // 
            this.NombretextBox1.Location = new System.Drawing.Point(182, 41);
            this.NombretextBox1.Name = "NombretextBox1";
            this.NombretextBox1.ReadOnly = true;
            this.NombretextBox1.Size = new System.Drawing.Size(100, 20);
            this.NombretextBox1.TabIndex = 5;
            this.NombretextBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // ProductoNewtextBox
            // 
            this.ProductoNewtextBox.Location = new System.Drawing.Point(14, 41);
            this.ProductoNewtextBox.Name = "ProductoNewtextBox";
            this.ProductoNewtextBox.Size = new System.Drawing.Size(100, 20);
            this.ProductoNewtextBox.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(119, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 46);
            this.button1.TabIndex = 10;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Seleccionlabel2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ProductocomboBox);
            this.groupBox1.Controls.Add(this.ProductoNewtextBox);
            this.groupBox1.Controls.Add(this.NombretextBox1);
            this.groupBox1.Controls.Add(this.Nombrelabel1);
            this.groupBox1.Location = new System.Drawing.Point(12, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 138);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Productos";
            // 
            // ProductocomboBox
            // 
            this.ProductocomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProductocomboBox.FormattingEnabled = true;
            this.ProductocomboBox.Location = new System.Drawing.Point(14, 95);
            this.ProductocomboBox.Name = "ProductocomboBox";
            this.ProductocomboBox.Size = new System.Drawing.Size(121, 21);
            this.ProductocomboBox.TabIndex = 0;
            this.ProductocomboBox.SelectedIndexChanged += new System.EventHandler(this.ProductocomboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(179, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Producto seleccionado";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // Eliminarbutton2
            // 
            this.Eliminarbutton2.Location = new System.Drawing.Point(12, 246);
            this.Eliminarbutton2.Name = "Eliminarbutton2";
            this.Eliminarbutton2.Size = new System.Drawing.Size(75, 23);
            this.Eliminarbutton2.TabIndex = 12;
            this.Eliminarbutton2.Text = "Eliminar";
            this.Eliminarbutton2.UseVisualStyleBackColor = true;
            this.Eliminarbutton2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Seleccionlabel2
            // 
            this.Seleccionlabel2.AutoSize = true;
            this.Seleccionlabel2.Location = new System.Drawing.Point(11, 79);
            this.Seleccionlabel2.Name = "Seleccionlabel2";
            this.Seleccionlabel2.Size = new System.Drawing.Size(160, 13);
            this.Seleccionlabel2.TabIndex = 7;
            this.Seleccionlabel2.Text = "Seleccione el producto deseado";
            // 
            // Salirbutton2
            // 
            this.Salirbutton2.Location = new System.Drawing.Point(253, 246);
            this.Salirbutton2.Name = "Salirbutton2";
            this.Salirbutton2.Size = new System.Drawing.Size(75, 23);
            this.Salirbutton2.TabIndex = 13;
            this.Salirbutton2.Text = "Salir";
            this.Salirbutton2.UseVisualStyleBackColor = true;
            this.Salirbutton2.Click += new System.EventHandler(this.Salirbutton2_Click);
            // 
            // estructura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 292);
            this.Controls.Add(this.Salirbutton2);
            this.Controls.Add(this.Eliminarbutton2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Name = "estructura";
            this.Text = "Estructura";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Nombrelabel1;
        private System.Windows.Forms.TextBox NombretextBox1;
        private System.Windows.Forms.TextBox ProductoNewtextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ProductocomboBox;
        private System.Windows.Forms.Button Eliminarbutton2;
        private System.Windows.Forms.Label Seleccionlabel2;
        private System.Windows.Forms.Button Salirbutton2;
    }
}