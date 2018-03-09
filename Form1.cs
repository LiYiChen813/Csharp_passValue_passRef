using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void passvalue(int x,int y)
        {
            label1.Text += "進入方法，值還沒變 x=" + x.ToString() + ",y=" + y.ToString()+ "\n\n";
            x += 3;
            y += 2;
            label1.Text += "進入方法，值已經變 x=" + x.ToString() + ",y=" + y.ToString()+ "\n\n";
        }

        private void passref(ref int x,ref int y)
        {
            label2.Text += "進入方法，值還沒變 x=" + x.ToString() + ",y=" + y.ToString() + "\n\n";
            x += 3;
            y += 2;
            label2.Text += "進入方法，值已經變 x=" + x.ToString() + ",y=" + y.ToString() + "\n\n";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int a = 10,b = 15;
            label1.Text  = "呼叫方法前a=" + a.ToString() + ",b=" + b.ToString()+ "\n\n";
            passvalue(a, b);
            label1.Text += "呼叫方法後a=" + a.ToString() + ",b=" + b.ToString()+ "\n\n";


            int c = 20, d = 22;
            label2.Text  = "呼叫方法前c=" + c.ToString() + ",d=" + d.ToString()+ "\n\n";
            passref(ref c,ref d);
            label2.Text += "呼叫方法後c=" + c.ToString() + ",d=" + d.ToString()+ "\n\n";
        }
    }
}
