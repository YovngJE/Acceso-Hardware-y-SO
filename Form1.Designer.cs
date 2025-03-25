namespace H_P_II_Clase8_AccesoHardware_SO
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
            this.btnNumeroSerie = new System.Windows.Forms.Button();
            this.lblNumeroSerie = new System.Windows.Forms.Label();
            this.lblDiscos = new System.Windows.Forms.Label();
            this.btnDiscos = new System.Windows.Forms.Button();
            this.lblProcesador = new System.Windows.Forms.Label();
            this.btnProcesador = new System.Windows.Forms.Button();
            this.lblRam = new System.Windows.Forms.Label();
            this.lblNic = new System.Windows.Forms.Label();
            this.btnMac = new System.Windows.Forms.Button();
            this.lblMac = new System.Windows.Forms.Label();
            this.btnCrearKey = new System.Windows.Forms.Button();
            this.btnLeerKey = new System.Windows.Forms.Button();
            this.btnEliminarKey = new System.Windows.Forms.Button();
            this.lblLeerClave = new System.Windows.Forms.Label();
            this.ltbProcesos = new System.Windows.Forms.ListBox();
            this.btnCrearProcesos = new System.Windows.Forms.Button();
            this.btnMatarProceso = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNumeroSerie
            // 
            this.btnNumeroSerie.Location = new System.Drawing.Point(79, 34);
            this.btnNumeroSerie.Name = "btnNumeroSerie";
            this.btnNumeroSerie.Size = new System.Drawing.Size(159, 23);
            this.btnNumeroSerie.TabIndex = 0;
            this.btnNumeroSerie.Text = "Leer Numero Serie";
            this.btnNumeroSerie.UseVisualStyleBackColor = true;
            this.btnNumeroSerie.Click += new System.EventHandler(this.btnNumeroSerie_Click);
            // 
            // lblNumeroSerie
            // 
            this.lblNumeroSerie.AutoSize = true;
            this.lblNumeroSerie.Location = new System.Drawing.Point(130, 60);
            this.lblNumeroSerie.Name = "lblNumeroSerie";
            this.lblNumeroSerie.Size = new System.Drawing.Size(44, 16);
            this.lblNumeroSerie.TabIndex = 1;
            this.lblNumeroSerie.Text = "label1";
            // 
            // lblDiscos
            // 
            this.lblDiscos.AutoSize = true;
            this.lblDiscos.Location = new System.Drawing.Point(550, 87);
            this.lblDiscos.Name = "lblDiscos";
            this.lblDiscos.Size = new System.Drawing.Size(44, 16);
            this.lblDiscos.TabIndex = 3;
            this.lblDiscos.Text = "label1";
            // 
            // btnDiscos
            // 
            this.btnDiscos.Location = new System.Drawing.Point(453, 34);
            this.btnDiscos.Name = "btnDiscos";
            this.btnDiscos.Size = new System.Drawing.Size(203, 23);
            this.btnDiscos.TabIndex = 2;
            this.btnDiscos.Text = "Obtener unidades de disco";
            this.btnDiscos.UseVisualStyleBackColor = true;
            this.btnDiscos.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblProcesador
            // 
            this.lblProcesador.AutoSize = true;
            this.lblProcesador.Location = new System.Drawing.Point(130, 166);
            this.lblProcesador.Name = "lblProcesador";
            this.lblProcesador.Size = new System.Drawing.Size(44, 16);
            this.lblProcesador.TabIndex = 5;
            this.lblProcesador.Text = "label1";
            // 
            // btnProcesador
            // 
            this.btnProcesador.Location = new System.Drawing.Point(41, 129);
            this.btnProcesador.Name = "btnProcesador";
            this.btnProcesador.Size = new System.Drawing.Size(254, 23);
            this.btnProcesador.TabIndex = 4;
            this.btnProcesador.Text = "Obtener Informacion Sistema";
            this.btnProcesador.UseVisualStyleBackColor = true;
            this.btnProcesador.Click += new System.EventHandler(this.btnProcesador_Click);
            // 
            // lblRam
            // 
            this.lblRam.AutoSize = true;
            this.lblRam.Location = new System.Drawing.Point(130, 206);
            this.lblRam.Name = "lblRam";
            this.lblRam.Size = new System.Drawing.Size(44, 16);
            this.lblRam.TabIndex = 7;
            this.lblRam.Text = "label1";
            // 
            // lblNic
            // 
            this.lblNic.AutoSize = true;
            this.lblNic.Location = new System.Drawing.Point(130, 257);
            this.lblNic.Name = "lblNic";
            this.lblNic.Size = new System.Drawing.Size(44, 16);
            this.lblNic.TabIndex = 8;
            this.lblNic.Text = "label1";
            // 
            // btnMac
            // 
            this.btnMac.Location = new System.Drawing.Point(427, 149);
            this.btnMac.Name = "btnMac";
            this.btnMac.Size = new System.Drawing.Size(254, 23);
            this.btnMac.TabIndex = 9;
            this.btnMac.Text = "Obtener Mac";
            this.btnMac.UseVisualStyleBackColor = true;
            this.btnMac.Click += new System.EventHandler(this.btnMac_Click);
            // 
            // lblMac
            // 
            this.lblMac.AutoSize = true;
            this.lblMac.Location = new System.Drawing.Point(539, 188);
            this.lblMac.Name = "lblMac";
            this.lblMac.Size = new System.Drawing.Size(44, 16);
            this.lblMac.TabIndex = 10;
            this.lblMac.Text = "label1";
            // 
            // btnCrearKey
            // 
            this.btnCrearKey.Location = new System.Drawing.Point(99, 327);
            this.btnCrearKey.Name = "btnCrearKey";
            this.btnCrearKey.Size = new System.Drawing.Size(139, 23);
            this.btnCrearKey.TabIndex = 11;
            this.btnCrearKey.Text = "Crear Clave";
            this.btnCrearKey.UseVisualStyleBackColor = true;
            this.btnCrearKey.Click += new System.EventHandler(this.btnCrearKey_Click);
            // 
            // btnLeerKey
            // 
            this.btnLeerKey.Location = new System.Drawing.Point(295, 327);
            this.btnLeerKey.Name = "btnLeerKey";
            this.btnLeerKey.Size = new System.Drawing.Size(139, 23);
            this.btnLeerKey.TabIndex = 12;
            this.btnLeerKey.Text = "Leer Clave";
            this.btnLeerKey.UseVisualStyleBackColor = true;
            this.btnLeerKey.Click += new System.EventHandler(this.btnLeerKey_Click);
            // 
            // btnEliminarKey
            // 
            this.btnEliminarKey.Location = new System.Drawing.Point(503, 327);
            this.btnEliminarKey.Name = "btnEliminarKey";
            this.btnEliminarKey.Size = new System.Drawing.Size(139, 23);
            this.btnEliminarKey.TabIndex = 13;
            this.btnEliminarKey.Text = "Eliminar Clave";
            this.btnEliminarKey.UseVisualStyleBackColor = true;
            this.btnEliminarKey.Click += new System.EventHandler(this.btnEliminarKey_Click);
            // 
            // lblLeerClave
            // 
            this.lblLeerClave.AutoSize = true;
            this.lblLeerClave.Location = new System.Drawing.Point(346, 366);
            this.lblLeerClave.Name = "lblLeerClave";
            this.lblLeerClave.Size = new System.Drawing.Size(44, 16);
            this.lblLeerClave.TabIndex = 14;
            this.lblLeerClave.Text = "label1";
            // 
            // ltbProcesos
            // 
            this.ltbProcesos.FormattingEnabled = true;
            this.ltbProcesos.ItemHeight = 16;
            this.ltbProcesos.Location = new System.Drawing.Point(835, 68);
            this.ltbProcesos.Name = "ltbProcesos";
            this.ltbProcesos.Size = new System.Drawing.Size(120, 84);
            this.ltbProcesos.TabIndex = 15;
            // 
            // btnCrearProcesos
            // 
            this.btnCrearProcesos.Location = new System.Drawing.Point(717, 327);
            this.btnCrearProcesos.Name = "btnCrearProcesos";
            this.btnCrearProcesos.Size = new System.Drawing.Size(139, 23);
            this.btnCrearProcesos.TabIndex = 16;
            this.btnCrearProcesos.Text = "Obtener Procesos";
            this.btnCrearProcesos.UseVisualStyleBackColor = true;
            this.btnCrearProcesos.Click += new System.EventHandler(this.btnCrearProcesos_Click);
            // 
            // btnMatarProceso
            // 
            this.btnMatarProceso.Location = new System.Drawing.Point(911, 327);
            this.btnMatarProceso.Name = "btnMatarProceso";
            this.btnMatarProceso.Size = new System.Drawing.Size(139, 23);
            this.btnMatarProceso.TabIndex = 17;
            this.btnMatarProceso.Text = "Matar Procesos";
            this.btnMatarProceso.UseVisualStyleBackColor = true;
            this.btnMatarProceso.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 450);
            this.Controls.Add(this.btnMatarProceso);
            this.Controls.Add(this.btnCrearProcesos);
            this.Controls.Add(this.ltbProcesos);
            this.Controls.Add(this.lblLeerClave);
            this.Controls.Add(this.btnEliminarKey);
            this.Controls.Add(this.btnLeerKey);
            this.Controls.Add(this.btnCrearKey);
            this.Controls.Add(this.lblMac);
            this.Controls.Add(this.btnMac);
            this.Controls.Add(this.lblNic);
            this.Controls.Add(this.lblRam);
            this.Controls.Add(this.lblProcesador);
            this.Controls.Add(this.btnProcesador);
            this.Controls.Add(this.lblDiscos);
            this.Controls.Add(this.btnDiscos);
            this.Controls.Add(this.lblNumeroSerie);
            this.Controls.Add(this.btnNumeroSerie);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNumeroSerie;
        private System.Windows.Forms.Label lblNumeroSerie;
        private System.Windows.Forms.Label lblDiscos;
        private System.Windows.Forms.Button btnDiscos;
        private System.Windows.Forms.Label lblProcesador;
        private System.Windows.Forms.Button btnProcesador;
        private System.Windows.Forms.Label lblRam;
        private System.Windows.Forms.Label lblNic;
        private System.Windows.Forms.Button btnMac;
        private System.Windows.Forms.Label lblMac;
        private System.Windows.Forms.Button btnCrearKey;
        private System.Windows.Forms.Button btnLeerKey;
        private System.Windows.Forms.Button btnEliminarKey;
        private System.Windows.Forms.Label lblLeerClave;
        private System.Windows.Forms.ListBox ltbProcesos;
        private System.Windows.Forms.Button btnCrearProcesos;
        private System.Windows.Forms.Button btnMatarProceso;
    }
}

