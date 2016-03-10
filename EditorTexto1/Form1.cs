using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EditorTexto1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            SaveFileDialog Save = new SaveFileDialog();
            System.IO.StreamWriter myStreamWriter = null;
            
            Save.Filter = "Text (*.txt)|*.txt|HTML(*.html*)|*.html|All files(*.*)|*.*";
            Save.CheckPathExists = true;
            Save.Title = "Guardar como";
            Save.ShowDialog(this);
            try
            {
                
                myStreamWriter = System.IO.File.AppendText(Save.FileName);
                myStreamWriter.Write(editor.Text);
                myStreamWriter.Flush();

            }
            catch (Exception) { }
        }

        private void pegarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //metodo paste
            editor.Paste();
        }

        private void cortarCtrlxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //metodo cut 
            editor.Cut();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editor.Clear();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog Open = new OpenFileDialog();
            System.IO.StreamReader myStreamReader = null;
           
            Open.Filter = "Text [*.txt*]|*.txt|All Files [*,*]|*,*";
            Open.CheckFileExists = true;
            Open.Title = "Abrir Archivo";
            Open.ShowDialog(this);
            try
            {
               
                Open.OpenFile();
                myStreamReader = System.IO.File.OpenText(Open.FileName);
                editor.Text = myStreamReader.ReadToEnd();

            }
            catch (Exception) { }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            Close();
        }

        private void fuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {

           
            FontDialog font = new FontDialog();
           
            font.Font = editor.Font;
            
            if (font.ShowDialog() == DialogResult.OK)
            {
                editor.Font = font.Font;
            }
        }

        private void colorTextoToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            ColorDialog color = new ColorDialog();
           
            if (color.ShowDialog() == DialogResult.OK)
            {
                editor.ForeColor = color.Color;
            }
        }

        private void deshacerCtrlzToolStripMenuItem_Click(object sender, EventArgs e)
        {
     
            editor.Undo();
        }

        private void rehacerCtrlyToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            editor.Redo();
        }

        private void copiarCtrlcToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            editor.Copy();
        }
    }
}
