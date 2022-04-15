using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CG_1
{
    public partial class LW_1 : Form
    {
        public LW_1()
        {
            InitializeComponent();
        }

        private void Task_one_Click(object sender, EventArgs e)
        {
            double A1, A2, B1, B2,C1,C2;
            A1 = Convert.ToDouble(T_one_A1.Text);
            A2 = Convert.ToDouble(T_one_A2.Text);
            B1 = Convert.ToDouble(T_one_B1.Text);
            B2 = Convert.ToDouble(T_one_B2.Text);
            C1 = Convert.ToDouble(T_one_C1.Text);
            C2 = Convert.ToDouble(T_one_C2.Text);


            if ((A1 == 0 && B1 == 0) || (A2 == 0 && B2 == 0)) {
                T_one_answer.Text = "Некорректные данные.";
                return;
            }

            if (A1 == 0 && A2 == 0 && (Math.Abs(C1 * B2 - C2 * B1) < 0.0000000001)) {
                T_one_answer.Text = "Прямые совпадают.";
                return;
            }

            if (A1 == 0 && A2 == 0 && (Math.Abs(C1 * B2 - C2 * B1) > 0.0000000001))
            {
                T_one_answer.Text = "Прямые не пересекаются.";
                return;
            }

            if (B1 == 0 && B2 == 0 && (Math.Abs(C1 * A2 - C2 * A1) < 0.0000000001)) {
                T_one_answer.Text = "Прямые совпадают.";
                return;
            }

            if (B1 == 0 && B2 == 0 && (Math.Abs(C1 * A2 - C2 * A1) > 0.0000000001))
            {
                T_one_answer.Text = "Прямые не пересекаются.";
                return;
            }

            if ((Math.Abs(A1 * B2 - B1 * A2) < 0.0000000001) && (Math.Abs(A1 * C2 - C1 * A2) < 0.0000000001)) {
                T_one_answer.Text = "Прямые совпадают.";
                return;
            }

            if (Math.Abs(A1 * B2 - B1 * A2) < 0.0000000001) {
                T_one_answer.Text = "Прямые не пересекаются.";
            }
            else {
                T_one_answer.Text = "Прямые пересекаются.";
            }
        }

        private void Task_two_Click(object sender, EventArgs e)
        {
            double x1, x2, x3, x4, y1, y2, y3, y4;
            x1 = Convert.ToDouble(T_two_x1.Text);
            x2 = Convert.ToDouble(T_two_x2.Text);
            x3 = Convert.ToDouble(T_two_x3.Text);
            x4 = Convert.ToDouble(T_two_x4.Text);
            y1 = Convert.ToDouble(T_two_y1.Text);
            y2 = Convert.ToDouble(T_two_y2.Text);
            y3 = Convert.ToDouble(T_two_y3.Text);
            y4 = Convert.ToDouble(T_two_y4.Text);

            if (((y3 - y1) / (y2 - y1) == (x3 - x1) / (x2 - x1)) && ((y4 - y1) / (y2 - y1) == (x4 - x1) / (x2 - x1))) {

                if ((x3 < x1 && x3 < x2) && (x4 < x1 && x4 < x2) && (x1 < x2)) {
                    T_two_answer.Text = "Луч AB и отрезок CD не пересекаются.";
                    return;
                }

                if ((x3 > x1 && x3 > x2) && (x4 > x1 && x4 > x2) && (x1 > x2)) {
                    T_two_answer.Text = "Луч AB и отрезок CD не пересекаются.";
                    return;
                }

                if ((x1 == x2 && x1 == x3 && x1 == x4) && ((y3 < y1 && y3 < y2) && (y4 < y1 && y4 < y2)) && (y2 > y1)) {
                    T_two_answer.Text = "Луч AB и отрезок CD не пересекаются.";
                    return;
                }

                if ((x1 == x2 && x1 == x3 && x1 == x4) && ((y3 > y1 && y3 > y2) && (y4 > y1 && y4 > y2)) && (y2 < y1)) {
                    T_two_answer.Text = "Луч AB и отрезок CD не пересекаются.";
                }
                else {
                    T_two_answer.Text = "Луч AB и отрезок CD пересекаются.";
                }
            }
            else {
                T_two_answer.Text = "Точки не лежат на одной прямой.";
            }
        }

        private void Task_three_Click(object sender, EventArgs e)
        {
            double x1, x2, x3, y1, y2, y3, z1, z2, z3;
            x1 = Convert.ToDouble(T_three_x1.Text);
            x2 = Convert.ToDouble(T_three_x2.Text);
            x3 = Convert.ToDouble(T_three_x3.Text);
            y1 = Convert.ToDouble(T_three_y1.Text);
            y2 = Convert.ToDouble(T_three_y2.Text);
            y3 = Convert.ToDouble(T_three_y3.Text);
            z1 = Convert.ToDouble(T_three_z1.Text);
            z2 = Convert.ToDouble(T_three_z2.Text);
            z3 = Convert.ToDouble(T_three_z3.Text);

            double angle = (180 / Math.PI) * Math.Acos(((x1 - x2) * (x3 - x2) + (y1 - y2) * (y3 - y2) + (z1 - z2) * (z3 - z2)) / Math.Sqrt((Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2) + Math.Pow((z1 - z2), 2)) * (Math.Pow((x3 - x2), 2) + Math.Pow((y3 - y2), 2) + Math.Pow((z3 - z2), 2))));
            if (angle >= 0 && angle < 90) {
                T_three_answer.Text = "Угол острый." + " Величина: " + Math.Round(angle, 3).ToString() + "°";
            }

            if (angle == 90) {
                T_three_answer.Text = "Угол прямой.";
            }

            if (angle > 90 && angle < 180) {
                T_three_answer.Text = "Угол тупой." + " Величина: " + Math.Round(angle, 3).ToString() + "°";
            }

            if (angle == 180) {
                T_three_answer.Text = "Угол развернутый.";
            }
        }

        private void Task_four_Click(object sender, EventArgs e)
        {
            double x1, x2, x3, y1, y2, y3, z1, z2, z3;
            x1 = Convert.ToDouble(T_four_x1.Text);
            x2 = Convert.ToDouble(T_four_x2.Text);
            x3 = Convert.ToDouble(T_four_x3.Text);
            y1 = Convert.ToDouble(T_four_y1.Text);
            y2 = Convert.ToDouble(T_four_y2.Text);
            y3 = Convert.ToDouble(T_four_y3.Text);
            z1 = Convert.ToDouble(T_four_z1.Text);
            z2 = Convert.ToDouble(T_four_z2.Text);
            z3 = Convert.ToDouble(T_four_z3.Text);

            if ((((x3 - x1) / (x2 - x1)) == ((y3 - y1) / (y2 - y1))) && ( ((x3 - x1) / (x2 - x1)) == ((z3 - z1) / (z2 - z1))))
            {
                T_four_answer.Text = "Точки лежат на одной прямой.";
            }
            else {
                T_four_answer.Text = "Точки не лежат на одной прямой.";
            }

        }
    }
}
