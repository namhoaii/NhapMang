using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestArray
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        NumericUpDown InputCell()
        {
            NumericUpDown n = new NumericUpDown();
            n.Width = 50;
            n.Height = 50;
            n.Minimum = 0;
            n.Maximum = 1000;
            return n;
        }

        bool IsPrime(int n)
        {
            for (int i = 2; i <= Math.Sqrt(n); i++)
                if (n % i == 0) return false;
            return n > 1;
        }

        void DrawResult(List<int> numbers)
        {
            foreach (int i in numbers)
            {
                Label lbl = new Label();
                lbl.Text = i.ToString();
                lbl.Width = 50;
                lbl.Height = 50;
                
                lbl.Font = new Font("Times New Roman", 14, FontStyle.Bold);

                flpOutput.Controls.Add(lbl);
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            flpInput.Controls.Clear();

            int number = (int)numericUpDown1.Value;
            for (int i = 0; i < number; i++)
            {
                flpInput.Controls.Add(InputCell());
            }
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            List<int> numbers = new List<int>();
            foreach (var item in flpInput.Controls)
            {
                if (item is NumericUpDown)
                {
                    int temp = (int)(item as NumericUpDown).Value;
                    if (IsPrime(temp))
                        numbers.Add(temp);
                }
            }

            flpOutput.Controls.Clear();

            DrawResult(numbers);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            numericUpDown1.Value = 1;
            flpInput.Controls.Clear();
            flpOutput.Controls.Clear();
        }
    }
}
