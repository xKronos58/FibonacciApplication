using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class dllImports
    {
        [DllImport("mytestlibGPTSol", CallingConvention = CallingConvention.Cdecl)]
        public static extern void fibonacci_init(ulong a, ulong b);

        [DllImport("mytestlibGPTSol", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool fibonacci_next();

        [DllImport("mytestlibGPTSol", CallingConvention = CallingConvention.Cdecl)]
        public static extern ulong fibonacci_current();

        [DllImport("mytestlibGPTSol", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint fibonacci_index();
        
        [DllImport("mytestlibGPTSol", CallingConvention = CallingConvention.Cdecl)]
        public static extern int maxSubArray(int[] arr, int n);
    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            Warning.Visible = true;
        }
        
        public bool DllExist()
        {
            if (File.Exists("C:\\WINDOWS\\System32\\mytestlibGPTSol"))
                return true;
            return false;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            TBCounter.Text = trackBar1.Value.ToString();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            TBCounter2.Text = trackBar2.Value.ToString();
        }

        private ulong CPFibonacci(int count)
        {
            ulong outp = 0;
            for (int j = 0; j <= count; j++)
            {
                if (dllImports.fibonacci_next())
                    outp = dllImports.fibonacci_current();
                else
                    throw new Exception("Fibonacci Overflow");
            }

            return outp;
        }
        
        private long C3Fibonacci(int count)
        {
            long current = 1, previous = 0, temp = 0;
            for(int j = 0; j <= count; j++)
            {
                temp = current;
                current += previous;
                previous = temp;
            }

            return current;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Output1.Visible = true;
            var timer = new Stopwatch();
            timer.Start();
            long outp = C3Fibonacci(trackBar1.Value);
            timer.Stop();
            Output1.Text = $@"Output: {outp}";
            timeTaken.Text = $@"Time Taken: {timer.ElapsedTicks} ticks or {timer.ElapsedMilliseconds}ms";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("HEHE");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (DllExist())
            {
                Output2.Visible = true;
                var timer = new Stopwatch();
                timer.Start();
                ulong outp = CPFibonacci(trackBar2.Value);
                timer.Stop();
                Output2.Text = $@"Output: {outp}";
                T.Text = $@"Time Taken: {timer.ElapsedTicks} ticks or {timer.ElapsedMilliseconds}ms";
            }
            else MessageBox.Show(@"Dll ""Fibonacci.dll"" not found");
        }

        private void Code_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/xKronos58/FibonacciApplication");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}