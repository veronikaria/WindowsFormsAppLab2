using System;
using System.Windows.Forms;

namespace WindowsFormsAppLab2
{
    public partial class FormLab2 : Form
    {
        public FormLab2()
        {
            InitializeComponent();
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            try
            {
                double xn, xk, xh, a, y;
                xn = Convert.ToDouble(textBoxXn.Text);
                xk = Convert.ToDouble(textBoxXk.Text);
                xh = Convert.ToDouble(textBoxXh.Text);
                a = Convert.ToDouble(textBoxA.Text);

                dg.Rows.Clear();
                chart1.Series[0].Points.Clear();
                while (xn <= xk)
                {
                    if (xn <= 0)
                    {
                        y = Math.Pow(xn, 3) * (1 / Math.Tan(2 * Math.Pow(xn, 3)));
                    }
                    else if (xn > 0 && xn <= a)
                    {
                        y = 5 / (Math.Tan(2 * xn + 3) + 1);
                    }
                    else
                    {
                        y = Math.Tan(Math.Pow(xn, 2) + 1) * Math.Exp(-xn);
                    }
                    dg.Rows.Add(xn.ToString(), y.ToString());
                    chart1.Series[0].Points.AddXY(xn, y);
                    xn += xh;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
