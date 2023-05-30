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

namespace Async_Await_Thread_Task
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("同步开始");
            Dosomething();
        }
        public void Dosomething()
        {
            Console.WriteLine("Dosomething Begin");
            for (int i = 0; i < 900000000; i++)
            {
                
            }
            Console.WriteLine("Dosomething End");
        }
    }
}
