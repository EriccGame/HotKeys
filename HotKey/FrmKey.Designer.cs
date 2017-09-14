namespace HotKey
{
    partial class FrmKey
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
            this.tbKeyCopy = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbKeyCopy
            // 
            this.tbKeyCopy.Location = new System.Drawing.Point(12, 12);
            this.tbKeyCopy.Multiline = true;
            this.tbKeyCopy.Name = "tbKeyCopy";
            this.tbKeyCopy.ShortcutsEnabled = false;
            this.tbKeyCopy.Size = new System.Drawing.Size(260, 100);
            this.tbKeyCopy.TabIndex = 0;
            this.tbKeyCopy.WordWrap = false;
            this.tbKeyCopy.TextChanged += new System.EventHandler(this.tbKeyCopy_TextChanged);
            // 
            // FrmKey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.tbKeyCopy);
            this.Name = "FrmKey";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "\\ FrmKey";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmKey_FormClosing);
            this.Load += new System.EventHandler(this.FrmKey_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbKeyCopy;
    }
}

