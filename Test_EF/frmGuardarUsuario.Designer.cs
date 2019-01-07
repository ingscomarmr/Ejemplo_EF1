namespace Test_EF
{
    partial class frmGuardarUsuario
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
            this.lblUsuarioName = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.lblPwd = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblUsuarioName
            // 
            this.lblUsuarioName.AutoSize = true;
            this.lblUsuarioName.Location = new System.Drawing.Point(30, 35);
            this.lblUsuarioName.Name = "lblUsuarioName";
            this.lblUsuarioName.Size = new System.Drawing.Size(46, 13);
            this.lblUsuarioName.TabIndex = 0;
            this.lblUsuarioName.Text = "Usuario:";
            this.lblUsuarioName.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(82, 32);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(175, 20);
            this.txtUsuario.TabIndex = 1;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(97, 87);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtContrasena
            // 
            this.txtContrasena.Location = new System.Drawing.Point(82, 58);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(175, 20);
            this.txtContrasena.TabIndex = 4;
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.Location = new System.Drawing.Point(12, 61);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(64, 13);
            this.lblPwd.TabIndex = 3;
            this.lblPwd.Text = "Contraseña:";
            this.lblPwd.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(82, 6);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(175, 20);
            this.txtID.TabIndex = 6;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(55, 9);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(21, 13);
            this.lblId.TabIndex = 5;
            this.lblId.Text = "ID:";
            // 
            // frmGuardarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 117);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtContrasena);
            this.Controls.Add(this.lblPwd);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblUsuarioName);
            this.Name = "frmGuardarUsuario";
            this.Text = "Guardar Usuario";
            this.Load += new System.EventHandler(this.frmGuardarUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsuarioName;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblId;
    }
}