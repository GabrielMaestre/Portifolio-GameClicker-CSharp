using System;
using System.Drawing;
using System.Windows.Forms;

namespace Portifolio_GameClickerRPG
{
    class CustomControls
    {
        const int xMinConst = 120;
        const int xMaxConst = 550;
        const int yMinConst = 105;
        const int yMaxConst = 420;

        public static Label lblPlus(Label lbl, int plus)
        {
            int x = 0, y = 0;
            Random randNum = new Random();

            //IMG AREA = 167; 106

            try
            {
                x = randNum.Next(xMinConst, xMaxConst);

            }
            catch (Exception errX)
            {
                MessageBox.Show("X - ERROR");
            }
            try
            {
                y = randNum.Next(yMinConst, yMaxConst);
            }
            catch (Exception errY)
            {
                MessageBox.Show("Y - ERROR");
            }

            lbl.Location = new Point(x, y);
            lbl.Text = "+" + plus;

            return lbl;
        }
    }
}