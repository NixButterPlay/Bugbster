using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Memory;

namespace BugbsterInjector
{
    public partial class BugbsterInjector : Form
    {
        int min_dllfilename = 15;
        private Mem mem = new Mem();
        OpenFileDialog ofd = new OpenFileDialog();
        public BugbsterInjector()
        {
            InitializeComponent();
            if (mem.OpenProcess("RustClient.exe"))
            {
                File.WriteAllText(@"C:\Temp\Rust.txt", "RustClient has Founded");
            }
        }

        private void checkBox1_CheckedChanged(object sender)
        {
            if (checkBox1.Checked == true)
            {
                File.WriteAllText(@"C:\Temp\LICENSE.txt", "Thank you For Using This Injector... Made by NixButterPlay... This LICESE under MIT");
                Process.Start("notepad", @"C:\Temp\LICENSE.txt");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ofd.Title = "DLL Files";
            ofd.InitialDirectory = "C:\\"; //Directory of Current Windows :D
            ofd.Filter = "DLL File | *.dll"; //Filter of DLL Files :D
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string mx = ofd.FileName;
                textBox1.Text = mx;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length == min_dllfilename)
            {
                if (mem.InjectDll(textBox1.Text))
                {
                    MessageBox.Show("Inject is Complete Succcessfull!!!");
                    Environment.Exit(3312);
                }
                else
                {
                    MessageBox.Show("Inject is Not Complete Successfull!!!");
                    return;
                }
            }
            else
            {
                throw new Exception("You Must Have 1 DLL File, Otherwise You're Cheat has don't Loaded Successfully or You're Cheat Already Loaded in RustClient's Memory");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string soon = "Soon!!!";
            MessageBox.Show(soon);
            return;
        }
    }


}
   
