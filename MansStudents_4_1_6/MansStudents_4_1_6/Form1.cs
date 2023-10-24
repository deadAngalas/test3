using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MansStudents_4_1_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student D = new Student("Deniss Olksna", "st2022123", "DVAF", 2, 6.7);
            richTextBox1.Clear();
            richTextBox1.AppendText("D:" + D.ToString());
            D.Sesija(5,9,7,8,10);
            D++;
            richTextBox1.AppendText("\n\nD pec sesijas:" + D.ToString());
        }
    }
}
