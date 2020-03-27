namespace EJ_INDIVIDUAL_2
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
            this.desconect = new System.Windows.Forms.Button();
            this.conect = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.F = new System.Windows.Forms.TextBox();
            this.FC = new System.Windows.Forms.RadioButton();
            this.CF = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.C = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // desconect
            // 
            this.desconect.Location = new System.Drawing.Point(42, 412);
            this.desconect.Name = "desconect";
            this.desconect.Size = new System.Drawing.Size(110, 38);
            this.desconect.TabIndex = 11;
            this.desconect.Text = "DESCONECTAR";
            this.desconect.UseVisualStyleBackColor = true;
            this.desconect.Click += new System.EventHandler(this.desconect_Click);
            // 
            // conect
            // 
            this.conect.Location = new System.Drawing.Point(42, 24);
            this.conect.Name = "conect";
            this.conect.Size = new System.Drawing.Size(110, 38);
            this.conect.TabIndex = 10;
            this.conect.Text = "CONECTAR";
            this.conect.UseVisualStyleBackColor = true;
            this.conect.Click += new System.EventHandler(this.conect_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.F);
            this.groupBox1.Controls.Add(this.FC);
            this.groupBox1.Controls.Add(this.CF);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.C);
            this.groupBox1.Location = new System.Drawing.Point(42, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 282);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Peticion";
            // 
            // F
            // 
            this.F.Location = new System.Drawing.Point(85, 137);
            this.F.Name = "F";
            this.F.Size = new System.Drawing.Size(164, 20);
            this.F.TabIndex = 10;
            // 
            // FC
            // 
            this.FC.AutoSize = true;
            this.FC.Location = new System.Drawing.Point(85, 163);
            this.FC.Name = "FC";
            this.FC.Size = new System.Drawing.Size(75, 17);
            this.FC.TabIndex = 7;
            this.FC.TabStop = true;
            this.FC.Text = "De ºF a ºC";
            this.FC.UseVisualStyleBackColor = true;
            // 
            // CF
            // 
            this.CF.AutoSize = true;
            this.CF.Location = new System.Drawing.Point(85, 92);
            this.CF.Name = "CF";
            this.CF.Size = new System.Drawing.Size(75, 17);
            this.CF.TabIndex = 8;
            this.CF.TabStop = true;
            this.CF.Text = "De ºC a ºF";
            this.CF.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(82, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "TEMPERATURA EN ºC";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(220, 233);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Convertir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // C
            // 
            this.C.Location = new System.Drawing.Point(85, 66);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(164, 20);
            this.C.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "TEMPERATURA EN ºF";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 484);
            this.Controls.Add(this.desconect);
            this.Controls.Add(this.conect);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button desconect;
        private System.Windows.Forms.Button conect;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox F;
        private System.Windows.Forms.RadioButton FC;
        private System.Windows.Forms.RadioButton CF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox C;
        private System.Windows.Forms.Label label1;
    }
}

