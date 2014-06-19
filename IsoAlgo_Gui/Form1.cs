using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.IO;
using System.Diagnostics;
using System.Collections.Specialized;

namespace IsoAlgo_Gui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void but_src_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Multiselect = false;
            ofd.InitialDirectory = "C:\"";
            ofd.Filter = ".pcf (*.pcf)|*.pcf";
            ofd.Title = "Datei zum Öffnen auswählen";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txt_src.Text = "";
                foreach (string s in ofd.FileNames)
                    txt_src.Text += s;
            }
            else
            {

            }

        }

        private void but_dest_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.InitialDirectory = "C:\"";
            sfd.Filter = ".dxf (*.dxf)|*.dxf";
            sfd.Title = "Ort zum Speichern auswählen";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                txt_dest.Text = "";
                foreach (string s in sfd.FileNames)
                    txt_dest.Text += s;
            }
            else
            {

            }

        }

        private void but_convert_Click(object sender, EventArgs e)
        {
            if (File.Exists("IsoAlgo.bat"))
            {
                File.Delete("IsoAlgo.bat");
            }
            
            FileStream fs = new FileStream(
                "IsoAlgo.bat", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("call IsoAlgoTest " + txt_src.Text + " " + txt_dest.Text);
            sw.Close();
            
            Process p = new Process();
            p.StartInfo.FileName = "IsoAlgo.bat";
            p.Start();
                        
        }

        private void lbl_src_Click(object sender, EventArgs e)
        {

        }



    }
}
