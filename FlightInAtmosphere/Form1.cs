using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightInAtmosphere
{
    public partial class Form1 : Form
    {
        decimal t = 0, x = 0, y, v0, cosA, sinA, S, m, k, vX, vY;



        const decimal dt = 0.01M, g = 9.81M, C = 0.15M, rho = 1.29M;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (inputWeight.Value != 0)
            {
                if (t == 0)
                {
                    chart1.Series[0].Points.Clear(); //А оно ТУТ надо вообще?
                    x = 0;
                    y = inputHeight.Value;
                    v0 = inputSpeed.Value;
                    double alpha = (double)inputAngle.Value * Math.PI / 180;
                    cosA = (decimal)Math.Cos(alpha);
                    sinA = (decimal)Math.Sin(alpha);
                    S = inputSize.Value;
                    m = inputWeight.Value;
                    k = 0.5M * C * rho * S / m;
                    vX = v0 * cosA;
                    vY = v0 * sinA;
                    chart1.ChartAreas[0].AxisX.Minimum = 0;
                    chart1.ChartAreas[0].AxisY.Maximum = 0;
                    chart1.ChartAreas[0].AxisX.Maximum = (double)(v0 * v0 * (decimal)Math.Sin(2 * alpha) / g); //А есть формулы для этого в данном случае? А то я не нашёл
                    chart1.ChartAreas[0].AxisY.Maximum = (double)(v0 * v0 * sinA * sinA / (2 * g));
                    chart1.Series[0].Points.AddXY(x, y);
                    timer.Start();
                }
                else
                {
                    timer.Start();
                }
            }
            else
                MessageBox.Show("Масса не может быть нулевой!");
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            t += dt;
            decimal v = (decimal)Math.Sqrt((double)(vX * vX + vY * vY));
            vX -= (k * vX * v * dt);
            vY -= ((g + k * vY * v) * dt);
            x += vX * dt;
            y += vY * dt;
            chart1.Series[0].Points.AddXY(x, y);
            timeShow.Text = ("Seconds: " + t);
            if (y <= 0)
            {
                t = 0;
                timer.Stop();
            }
        }

        private void breakButton_Click(object sender, EventArgs e)
        {
            timer.Stop();
            t = 0;
            timeShow.Text = ("Seconds: " + t);
            chart1.Series[0].Points.Clear();
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }
    }
}
