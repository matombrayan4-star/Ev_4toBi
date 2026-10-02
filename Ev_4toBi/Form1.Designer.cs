namespace Ev_4toBi
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
            this.components = new System.ComponentModel.Container();
            this.TextUsuario = new System.Windows.Forms.TextBox();
            this.TextContraseña = new System.Windows.Forms.TextBox();
            this.BtnIngresar = new System.Windows.Forms.Button();
            this.LBL1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // TextUsuario
            // 
            this.TextUsuario.Location = new System.Drawing.Point(33, 13);
            this.TextUsuario.Name = "TextUsuario";
            this.TextUsuario.Size = new System.Drawing.Size(100, 22);
            this.TextUsuario.TabIndex = 0;
            this.TextUsuario.TextChanged += new System.EventHandler(this.TextUsuario_TextChanged);
            // 
            // TextContraseña
            // 
            this.TextContraseña.Location = new System.Drawing.Point(203, 12);
            this.TextContraseña.Name = "TextContraseña";
            this.TextContraseña.Size = new System.Drawing.Size(100, 22);
            this.TextContraseña.TabIndex = 1;
            // 
            // BtnIngresar
            // 
            this.BtnIngresar.Location = new System.Drawing.Point(58, 66);
            this.BtnIngresar.Name = "BtnIngresar";
            this.BtnIngresar.Size = new System.Drawing.Size(75, 23);
            this.BtnIngresar.TabIndex = 2;
            this.BtnIngresar.Text = "Ingresar";
            this.BtnIngresar.UseVisualStyleBackColor = true;
            // 
            // LBL1
            // 
            this.LBL1.AutoSize = true;
            this.LBL1.Location = new System.Drawing.Point(239, 69);
            this.LBL1.Name = "LBL1";
            this.LBL1.Size = new System.Drawing.Size(88, 16);
            this.LBL1.TabIndex = 3;
            this.LBL1.Text = "Examen Final";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LBL1);
            this.Controls.Add(this.BtnIngresar);
            this.Controls.Add(this.TextContraseña);
            this.Controls.Add(this.TextUsuario);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextUsuario;
        private System.Windows.Forms.TextBox TextContraseña;
        private System.Windows.Forms.Button BtnIngresar;
        private System.Windows.Forms.Label LBL1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

