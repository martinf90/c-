namespace WindowsFormsApplication1
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
            this.listapro = new System.Windows.Forms.ListBox();
            this.boton = new System.Windows.Forms.Button();
            this.texto1 = new System.Windows.Forms.TextBox();
            this.boton2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listdesa = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listtotal = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cantapro = new System.Windows.Forms.Label();
            this.cantdesa = new System.Windows.Forms.Label();
            this.texto2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.boton3 = new System.Windows.Forms.Button();
            this.cantotal = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listapro
            // 
            this.listapro.FormattingEnabled = true;
            this.listapro.Location = new System.Drawing.Point(14, 26);
            this.listapro.Name = "listapro";
            this.listapro.Size = new System.Drawing.Size(99, 147);
            this.listapro.TabIndex = 0;
            this.listapro.TabStop = false;
            this.listapro.Click += new System.EventHandler(this.listapro_Click);
            // 
            // boton
            // 
            this.boton.Location = new System.Drawing.Point(12, 288);
            this.boton.Name = "boton";
            this.boton.Size = new System.Drawing.Size(86, 23);
            this.boton.TabIndex = 3;
            this.boton.Text = "Agregar";
            this.boton.UseVisualStyleBackColor = true;
            this.boton.Click += new System.EventHandler(this.boton_Click);
            // 
            // texto1
            // 
            this.texto1.Location = new System.Drawing.Point(61, 19);
            this.texto1.Name = "texto1";
            this.texto1.Size = new System.Drawing.Size(120, 20);
            this.texto1.TabIndex = 1;
            // 
            // boton2
            // 
            this.boton2.Location = new System.Drawing.Point(124, 288);
            this.boton2.Name = "boton2";
            this.boton2.Size = new System.Drawing.Size(86, 23);
            this.boton2.TabIndex = 4;
            this.boton2.Text = "Eliminar";
            this.boton2.UseVisualStyleBackColor = true;
            this.boton2.Click += new System.EventHandler(this.boton2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(269, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Deseleccionar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listdesa
            // 
            this.listdesa.FormattingEnabled = true;
            this.listdesa.Location = new System.Drawing.Point(132, 26);
            this.listdesa.Name = "listdesa";
            this.listdesa.Size = new System.Drawing.Size(100, 147);
            this.listdesa.TabIndex = 0;
            this.listdesa.TabStop = false;
            this.listdesa.Click += new System.EventHandler(this.listdesa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Aprobados:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Desaprobados:";
            // 
            // listtotal
            // 
            this.listtotal.FormattingEnabled = true;
            this.listtotal.Location = new System.Drawing.Point(253, 26);
            this.listtotal.Name = "listtotal";
            this.listtotal.Size = new System.Drawing.Size(103, 147);
            this.listtotal.TabIndex = 0;
            this.listtotal.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(250, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Total alumnos:";
            // 
            // cantapro
            // 
            this.cantapro.AutoSize = true;
            this.cantapro.Location = new System.Drawing.Point(17, 175);
            this.cantapro.Name = "cantapro";
            this.cantapro.Size = new System.Drawing.Size(67, 13);
            this.cantapro.TabIndex = 13;
            this.cantapro.Text = "0 Aprobados";
            // 
            // cantdesa
            // 
            this.cantdesa.AutoSize = true;
            this.cantdesa.Location = new System.Drawing.Point(135, 175);
            this.cantdesa.Name = "cantdesa";
            this.cantdesa.Size = new System.Drawing.Size(85, 13);
            this.cantdesa.TabIndex = 14;
            this.cantdesa.Text = "0 Desaprobados";
            // 
            // texto2
            // 
            this.texto2.Location = new System.Drawing.Point(61, 49);
            this.texto2.Name = "texto2";
            this.texto2.Size = new System.Drawing.Size(47, 20);
            this.texto2.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Nombre:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Nota:";
            // 
            // boton3
            // 
            this.boton3.Location = new System.Drawing.Point(269, 206);
            this.boton3.Name = "boton3";
            this.boton3.Size = new System.Drawing.Size(86, 20);
            this.boton3.TabIndex = 5;
            this.boton3.Text = "Listar";
            this.boton3.UseVisualStyleBackColor = true;
            this.boton3.Click += new System.EventHandler(this.boton3_Click);
            // 
            // cantotal
            // 
            this.cantotal.AutoSize = true;
            this.cantotal.Location = new System.Drawing.Point(256, 176);
            this.cantotal.Name = "cantotal";
            this.cantotal.Size = new System.Drawing.Size(31, 13);
            this.cantotal.TabIndex = 19;
            this.cantotal.Text = "Total";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightGray;
            this.groupBox1.Controls.Add(this.texto1);
            this.groupBox1.Controls.Add(this.texto2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox1.Location = new System.Drawing.Point(14, 200);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(195, 79);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Carga de datos:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(269, 232);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 21);
            this.button2.TabIndex = 6;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(373, 321);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cantotal);
            this.Controls.Add(this.boton3);
            this.Controls.Add(this.cantdesa);
            this.Controls.Add(this.cantapro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listtotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listdesa);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.boton2);
            this.Controls.Add(this.boton);
            this.Controls.Add(this.listapro);
            this.Name = "Form1";
            this.Text = "Listado de alumnos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listapro;
        private System.Windows.Forms.Button boton;
        private System.Windows.Forms.TextBox texto1;
        private System.Windows.Forms.Button boton2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listdesa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listtotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label cantapro;
        private System.Windows.Forms.Label cantdesa;
        private System.Windows.Forms.TextBox texto2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button boton3;
        private System.Windows.Forms.Label cantotal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
    }
}

