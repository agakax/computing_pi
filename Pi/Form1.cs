using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Pi
{

    public partial class Form1 : Form
    {

        public double ReturnPiAsm()
        {
            FuncAsm func = new FuncAsm();
            Double pi = 0, x;
            int p, i;
            Double[] parts;
            p = System.Convert.ToInt32(numericUpDownP.Value);
            parts = new Double[p];
            for (i = 0; i < p; i++)
            {
                x = System.Convert.ToDouble(i);
                parts[i] = func.computePartPi(x);

            }
            for (i = 0; i < p; i++)
            {
                pi = pi + parts[i];
            }
            return pi;
        }

        public double ReturnPiCpp()
        {
            FuncCpp func = new FuncCpp();
            Double pi = 0, x;
            int p, i;
            Double[] parts;
            p = System.Convert.ToInt32(numericUpDownP.Value);
            parts = new Double[p];
            for (i = 0; i < p; i++)
            {
                x = System.Convert.ToDouble(i);
                parts[i] = func.computePartPi(x);

            }
            for (i = 0; i < p; i++)
            {
                pi = pi + parts[i];
            }
            return pi;
        }

        public Form1()
        {
            InitializeComponent();
        }
 
        private void Form1_Load(object sender, EventArgs e)
        {

        }
 
        private void labelComputing_Click(object sender, EventArgs e)
        {

        }
 
        private void pictureFormula_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDownP_ValueChanged(object sender, EventArgs e)
        {

        }
 
        private void labelP_Click(object sender, EventArgs e)
        {

        }
 
        private void numericUpDownThreads_ValueChanged(object sender, EventArgs e)
        {

        }
 
        private void labelThreads_Click(object sender, EventArgs e)
        {

        }
 
        private void buttonAsm_Click(object sender, EventArgs e)
        {
            Form1 compute = new Form1();
Thread newThread = new Thread(new ThreadStart(compute.ReturnPiAsm));
            int time = 0;
            string unit = " ms";
            double pi = compute.ReturnPiAsm() ;
            textBoxTimeAsm.Text = time.ToString() + unit;
            richTextBoxPi.Text = pi.ToString();
        }
 
        private void labelTimeAsm_Click(object sender, EventArgs e)
        {

        }
 
        private void textBoxTimeAsm_TextChanged(object sender, EventArgs e)
        {

        }
 
        private void buttonCpp_Click(object sender, EventArgs e)
        {
            Form1 compute = new Form1();
            int time = 0;
            string unit = " ms";
            double pi = compute.ReturnPiCpp();
            textBoxTimeCpp.Text = time.ToString() + unit;
            richTextBoxPi.Text = pi.ToString();
        }
 
        private void labelTimeCpp_Click(object sender, EventArgs e)
        {

        }
 
        private void textBoxTimeCpp_TextChanged(object sender, EventArgs e)
        {

        }
 
        private void labelPi_Click(object sender, EventArgs e)
        {

        }
 
        private void richTextBoxPi_TextChanged(object sender, EventArgs e)
        {

        }
 
        private void buttonSave_Click(object sender, EventArgs e)
        {
            saveFileDialogPi.ShowDialog();
        }

        private void saveFileDialogPi_FileOk(object sender, CancelEventArgs e)
        {
            string name = saveFileDialogPi.FileName;
            File.WriteAllText(name, richTextBoxPi.Text);
        }

    }
}
