namespace EditorTexto1
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fuenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorTextoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deshacerCtrlzToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rehacerCtrlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copiarCtrlcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cortarCtrlxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pegarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editor = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.formatoToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(498, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.abrirToolStripMenuItem,
            this.guardarToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // formatoToolStripMenuItem
            // 
            this.formatoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fuenteToolStripMenuItem,
            this.colorTextoToolStripMenuItem});
            this.formatoToolStripMenuItem.Name = "formatoToolStripMenuItem";
            this.formatoToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.formatoToolStripMenuItem.Text = "Formato";
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deshacerCtrlzToolStripMenuItem,
            this.rehacerCtrlyToolStripMenuItem,
            this.copiarCtrlcToolStripMenuItem,
            this.cortarCtrlxToolStripMenuItem,
            this.pegarToolStripMenuItem});
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // fuenteToolStripMenuItem
            // 
            this.fuenteToolStripMenuItem.Name = "fuenteToolStripMenuItem";
            this.fuenteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.fuenteToolStripMenuItem.Text = "fuente";
            this.fuenteToolStripMenuItem.Click += new System.EventHandler(this.fuenteToolStripMenuItem_Click);
            // 
            // colorTextoToolStripMenuItem
            // 
            this.colorTextoToolStripMenuItem.Name = "colorTextoToolStripMenuItem";
            this.colorTextoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.colorTextoToolStripMenuItem.Text = "Color Texto";
            this.colorTextoToolStripMenuItem.Click += new System.EventHandler(this.colorTextoToolStripMenuItem_Click);
            // 
            // deshacerCtrlzToolStripMenuItem
            // 
            this.deshacerCtrlzToolStripMenuItem.Name = "deshacerCtrlzToolStripMenuItem";
            this.deshacerCtrlzToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.deshacerCtrlzToolStripMenuItem.Text = "•\tDeshacer  Ctrl+z";
            this.deshacerCtrlzToolStripMenuItem.Click += new System.EventHandler(this.deshacerCtrlzToolStripMenuItem_Click);
            // 
            // rehacerCtrlyToolStripMenuItem
            // 
            this.rehacerCtrlyToolStripMenuItem.Name = "rehacerCtrlyToolStripMenuItem";
            this.rehacerCtrlyToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.rehacerCtrlyToolStripMenuItem.Text = "•\tRehacer    Ctrl+y";
            this.rehacerCtrlyToolStripMenuItem.Click += new System.EventHandler(this.rehacerCtrlyToolStripMenuItem_Click);
            // 
            // copiarCtrlcToolStripMenuItem
            // 
            this.copiarCtrlcToolStripMenuItem.Name = "copiarCtrlcToolStripMenuItem";
            this.copiarCtrlcToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.copiarCtrlcToolStripMenuItem.Text = "•Copiar       Ctrl+c";
            this.copiarCtrlcToolStripMenuItem.Click += new System.EventHandler(this.copiarCtrlcToolStripMenuItem_Click);
            // 
            // cortarCtrlxToolStripMenuItem
            // 
            this.cortarCtrlxToolStripMenuItem.Name = "cortarCtrlxToolStripMenuItem";
            this.cortarCtrlxToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.cortarCtrlxToolStripMenuItem.Text = "•Cortar        Ctrl+x";
            this.cortarCtrlxToolStripMenuItem.Click += new System.EventHandler(this.cortarCtrlxToolStripMenuItem_Click);
            // 
            // pegarToolStripMenuItem
            // 
            this.pegarToolStripMenuItem.Name = "pegarToolStripMenuItem";
            this.pegarToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.pegarToolStripMenuItem.Text = "•Pegar         Ctrl+v";
            this.pegarToolStripMenuItem.Click += new System.EventHandler(this.pegarToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(49, 20);
            this.toolStripMenuItem1.Text = "          ";
            // 
            // editor
            // 
            this.editor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editor.Location = new System.Drawing.Point(0, 24);
            this.editor.Name = "editor";
            this.editor.Size = new System.Drawing.Size(498, 280);
            this.editor.TabIndex = 2;
            this.editor.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 304);
            this.Controls.Add(this.editor);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "     ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fuenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorTextoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deshacerCtrlzToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rehacerCtrlyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copiarCtrlcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cortarCtrlxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pegarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.RichTextBox editor;
    }
}

