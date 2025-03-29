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
            this.lblNumeroSerie = new System.Windows.Forms.Label();
            this.btnCrearKey = new System.Windows.Forms.Button();
            this.btnLeerKey = new System.Windows.Forms.Button();
            this.btnEliminarKey = new System.Windows.Forms.Button();
            this.ltbProcesos = new System.Windows.Forms.ListBox();
            this.btnCrearProcesos = new System.Windows.Forms.Button();
            this.btnMatarProceso = new System.Windows.Forms.Button();
            this.tbcPrincipal = new System.Windows.Forms.TabControl();
            this.tbpIformacion = new System.Windows.Forms.TabPage();
            this.tbpRegistro = new System.Windows.Forms.TabPage();
            this.tbpGestion = new System.Windows.Forms.TabPage();
            this.btnObtenerInfoSistema = new System.Windows.Forms.Button();
            this.lblInfoSistema = new System.Windows.Forms.Label();
            this.lblRegistroSistema = new System.Windows.Forms.Label();
            this.lblInfoProcesos = new System.Windows.Forms.Label();
            this.tbcPrincipal.SuspendLayout();
            this.tbpIformacion.SuspendLayout();
            this.tbpRegistro.SuspendLayout();
            this.tbpGestion.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNumeroSerie
            // 
            this.lblNumeroSerie.AutoSize = true;
            this.lblNumeroSerie.Location = new System.Drawing.Point(821, 115);
            this.lblNumeroSerie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumeroSerie.Name = "lblNumeroSerie";
            this.lblNumeroSerie.Size = new System.Drawing.Size(0, 23);
            this.lblNumeroSerie.TabIndex = 1;
            // 
            // btnCrearKey
            // 
            this.btnCrearKey.BackColor = System.Drawing.Color.Green;
            this.btnCrearKey.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnCrearKey.FlatAppearance.BorderSize = 0;
            this.btnCrearKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearKey.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearKey.ForeColor = System.Drawing.Color.White;
            this.btnCrearKey.Location = new System.Drawing.Point(20, 80);
            this.btnCrearKey.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCrearKey.Name = "btnCrearKey";
            this.btnCrearKey.Size = new System.Drawing.Size(120, 40);
            this.btnCrearKey.TabIndex = 11;
            this.btnCrearKey.Text = "Crear Clave";
            this.btnCrearKey.UseVisualStyleBackColor = false;
            this.btnCrearKey.Click += new System.EventHandler(this.btnCrearKey_Click);
            // 
            // btnLeerKey
            // 
            this.btnLeerKey.BackColor = System.Drawing.Color.Orange;
            this.btnLeerKey.FlatAppearance.BorderSize = 0;
            this.btnLeerKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeerKey.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeerKey.ForeColor = System.Drawing.Color.White;
            this.btnLeerKey.Location = new System.Drawing.Point(151, 80);
            this.btnLeerKey.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLeerKey.Name = "btnLeerKey";
            this.btnLeerKey.Size = new System.Drawing.Size(120, 40);
            this.btnLeerKey.TabIndex = 12;
            this.btnLeerKey.Text = "Leer Clave";
            this.btnLeerKey.UseVisualStyleBackColor = false;
            this.btnLeerKey.Click += new System.EventHandler(this.btnLeerKey_Click);
            // 
            // btnEliminarKey
            // 
            this.btnEliminarKey.BackColor = System.Drawing.Color.Red;
            this.btnEliminarKey.FlatAppearance.BorderSize = 0;
            this.btnEliminarKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarKey.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarKey.ForeColor = System.Drawing.Color.White;
            this.btnEliminarKey.Location = new System.Drawing.Point(280, 80);
            this.btnEliminarKey.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminarKey.Name = "btnEliminarKey";
            this.btnEliminarKey.Size = new System.Drawing.Size(120, 40);
            this.btnEliminarKey.TabIndex = 13;
            this.btnEliminarKey.Text = "Eliminar Clave";
            this.btnEliminarKey.UseVisualStyleBackColor = false;
            this.btnEliminarKey.Click += new System.EventHandler(this.btnEliminarKey_Click);
            // 
            // ltbProcesos
            // 
            this.ltbProcesos.FormattingEnabled = true;
            this.ltbProcesos.ItemHeight = 23;
            this.ltbProcesos.Location = new System.Drawing.Point(20, 60);
            this.ltbProcesos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ltbProcesos.Name = "ltbProcesos";
            this.ltbProcesos.Size = new System.Drawing.Size(400, 188);
            this.ltbProcesos.TabIndex = 15;
            // 
            // btnCrearProcesos
            // 
            this.btnCrearProcesos.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCrearProcesos.FlatAppearance.BorderSize = 0;
            this.btnCrearProcesos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearProcesos.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearProcesos.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCrearProcesos.Location = new System.Drawing.Point(20, 280);
            this.btnCrearProcesos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCrearProcesos.Name = "btnCrearProcesos";
            this.btnCrearProcesos.Size = new System.Drawing.Size(180, 40);
            this.btnCrearProcesos.TabIndex = 16;
            this.btnCrearProcesos.Text = "Obtener Procesos";
            this.btnCrearProcesos.UseVisualStyleBackColor = false;
            this.btnCrearProcesos.Click += new System.EventHandler(this.btnCrearProcesos_Click);
            // 
            // btnMatarProceso
            // 
            this.btnMatarProceso.BackColor = System.Drawing.Color.Red;
            this.btnMatarProceso.FlatAppearance.BorderSize = 0;
            this.btnMatarProceso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMatarProceso.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMatarProceso.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMatarProceso.Location = new System.Drawing.Point(220, 280);
            this.btnMatarProceso.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMatarProceso.Name = "btnMatarProceso";
            this.btnMatarProceso.Size = new System.Drawing.Size(180, 40);
            this.btnMatarProceso.TabIndex = 17;
            this.btnMatarProceso.Text = "Matar Procesos";
            this.btnMatarProceso.UseVisualStyleBackColor = false;
            this.btnMatarProceso.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // tbcPrincipal
            // 
            this.tbcPrincipal.Controls.Add(this.tbpIformacion);
            this.tbcPrincipal.Controls.Add(this.tbpRegistro);
            this.tbcPrincipal.Controls.Add(this.tbpGestion);
            this.tbcPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tbcPrincipal.Name = "tbcPrincipal";
            this.tbcPrincipal.SelectedIndex = 0;
            this.tbcPrincipal.Size = new System.Drawing.Size(982, 553);
            this.tbcPrincipal.TabIndex = 18;
            // 
            // tbpIformacion
            // 
            this.tbpIformacion.BackColor = System.Drawing.Color.LightGray;
            this.tbpIformacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbpIformacion.Controls.Add(this.lblInfoSistema);
            this.tbpIformacion.Controls.Add(this.btnObtenerInfoSistema);
            this.tbpIformacion.Location = new System.Drawing.Point(4, 32);
            this.tbpIformacion.Name = "tbpIformacion";
            this.tbpIformacion.Padding = new System.Windows.Forms.Padding(3);
            this.tbpIformacion.Size = new System.Drawing.Size(974, 517);
            this.tbpIformacion.TabIndex = 0;
            this.tbpIformacion.Text = "Información del Sistema";
            // 
            // tbpRegistro
            // 
            this.tbpRegistro.BackColor = System.Drawing.Color.LightGray;
            this.tbpRegistro.Controls.Add(this.lblRegistroSistema);
            this.tbpRegistro.Controls.Add(this.btnCrearKey);
            this.tbpRegistro.Controls.Add(this.btnLeerKey);
            this.tbpRegistro.Controls.Add(this.btnEliminarKey);
            this.tbpRegistro.Location = new System.Drawing.Point(4, 32);
            this.tbpRegistro.Name = "tbpRegistro";
            this.tbpRegistro.Padding = new System.Windows.Forms.Padding(3);
            this.tbpRegistro.Size = new System.Drawing.Size(974, 517);
            this.tbpRegistro.TabIndex = 1;
            this.tbpRegistro.Text = "Registro del Sistema";
            // 
            // tbpGestion
            // 
            this.tbpGestion.BackColor = System.Drawing.Color.LightGray;
            this.tbpGestion.Controls.Add(this.ltbProcesos);
            this.tbpGestion.Controls.Add(this.lblInfoProcesos);
            this.tbpGestion.Controls.Add(this.btnMatarProceso);
            this.tbpGestion.Controls.Add(this.btnCrearProcesos);
            this.tbpGestion.Location = new System.Drawing.Point(4, 32);
            this.tbpGestion.Name = "tbpGestion";
            this.tbpGestion.Size = new System.Drawing.Size(974, 517);
            this.tbpGestion.TabIndex = 2;
            this.tbpGestion.Text = "Gestión de Procesos";
            // 
            // btnObtenerInfoSistema
            // 
            this.btnObtenerInfoSistema.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnObtenerInfoSistema.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnObtenerInfoSistema.FlatAppearance.BorderSize = 0;
            this.btnObtenerInfoSistema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObtenerInfoSistema.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObtenerInfoSistema.ForeColor = System.Drawing.SystemColors.Control;
            this.btnObtenerInfoSistema.Location = new System.Drawing.Point(24, 161);
            this.btnObtenerInfoSistema.Name = "btnObtenerInfoSistema";
            this.btnObtenerInfoSistema.Size = new System.Drawing.Size(200, 40);
            this.btnObtenerInfoSistema.TabIndex = 0;
            this.btnObtenerInfoSistema.Text = "Obtener Información";
            this.btnObtenerInfoSistema.UseVisualStyleBackColor = false;
            this.btnObtenerInfoSistema.Click += new System.EventHandler(this.btnObtenerInfoSistema_Click);
            // 
            // lblInfoSistema
            // 
            this.lblInfoSistema.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInfoSistema.Location = new System.Drawing.Point(20, 20);
            this.lblInfoSistema.Name = "lblInfoSistema";
            this.lblInfoSistema.Size = new System.Drawing.Size(400, 120);
            this.lblInfoSistema.TabIndex = 1;
            this.lblInfoSistema.Text = "Aquí se mostrará la información del sistema...";
            // 
            // lblRegistroSistema
            // 
            this.lblRegistroSistema.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRegistroSistema.Location = new System.Drawing.Point(20, 20);
            this.lblRegistroSistema.Name = "lblRegistroSistema";
            this.lblRegistroSistema.Size = new System.Drawing.Size(400, 50);
            this.lblRegistroSistema.TabIndex = 0;
            this.lblRegistroSistema.Text = "Clave del registro aparecerá aquí...";
            // 
            // lblInfoProcesos
            // 
            this.lblInfoProcesos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInfoProcesos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoProcesos.Location = new System.Drawing.Point(20, 20);
            this.lblInfoProcesos.Name = "lblInfoProcesos";
            this.lblInfoProcesos.Size = new System.Drawing.Size(400, 30);
            this.lblInfoProcesos.TabIndex = 18;
            this.lblInfoProcesos.Text = "Procesos activos aparecerán aquí...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.lblNumeroSerie);
            this.Controls.Add(this.tbcPrincipal);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tbcPrincipal.ResumeLayout(false);
            this.tbpIformacion.ResumeLayout(false);
            this.tbpRegistro.ResumeLayout(false);
            this.tbpGestion.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNumeroSerie;
        private System.Windows.Forms.Button btnCrearKey;
        private System.Windows.Forms.Button btnLeerKey;
        private System.Windows.Forms.Button btnEliminarKey;
        private System.Windows.Forms.ListBox ltbProcesos;
        private System.Windows.Forms.Button btnCrearProcesos;
        private System.Windows.Forms.Button btnMatarProceso;
        private System.Windows.Forms.TabControl tbcPrincipal;
        private System.Windows.Forms.TabPage tbpIformacion;
        private System.Windows.Forms.TabPage tbpRegistro;
        private System.Windows.Forms.TabPage tbpGestion;
        private System.Windows.Forms.Label lblInfoSistema;
        private System.Windows.Forms.Button btnObtenerInfoSistema;
        private System.Windows.Forms.Label lblRegistroSistema;
        private System.Windows.Forms.Label lblInfoProcesos;
    }
}

