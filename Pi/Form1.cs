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
                int localnumber = i;
                Thread tempThread = new Thread(
                    () =>
                        {
                            parts[localnumber] = func.computePartPi(x);
                        }
                );
                tempThread.Start();

            }
            for (i = 0; i < p; i++)
            {
                pi = pi + parts[i];
            }
            return pi;
        }

        public double ReturnPiCpp(int p, int threads)
        {
            FuncCpp func = new FuncCpp();
            p = p + 1;
            Double pi = 0, x;
            int i;
            //foreach (int element in threads)
            Thread[] freds;
            Double[] parts;
            object a = numericUpDownP;
            freds = new Thread[threads];
            parts = new Double[p];
            for (i = 0; i < p; i++)
            {
                var eventDone = new ManualResetEvent(false);
                int localnumber = i;
                x = System.Convert.ToDouble(i);
                var fredki = freds.Where(item => item == null);
                Thread fred = fredki.First();
                fred = new Thread(() =>
                {
                    parts[localnumber] = func.computePartPi(x);
                    eventDone.Set();
                    fred.Abort();
                    fred = null;
                });
                fred.Start();
                fred.Join();
                eventDone.WaitOne();

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
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            Form1 compute = new Form1();
            int p = System.Convert.ToInt32(numericUpDownP.Value);
            int thread = System.Convert.ToInt32(numericUpDownThreads.Value);
            double pi = compute.ReturnPiCpp(p, thread);
            Console.WriteLine(numericUpDownP.Text);
            Console.WriteLine(numericUpDownP.Value);
            stopwatch.Stop();
            var time = stopwatch.ElapsedMilliseconds;
            TimeSpan t = TimeSpan.FromMilliseconds(time);
            string formattedTime = string.Format("{0:D2}m {1:D2}s {2:D2}ms",
                                    t.Minutes,
                                    t.Seconds,
                                    t.Milliseconds);
            textBoxTimeCpp.Text = time.ToString();
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
