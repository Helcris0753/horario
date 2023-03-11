using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaPresentacion
{
    public partial class Profesores : System.Web.UI.Page
    {
        static string[,] Arreglo = new string[17, 7];
        static bool R = true;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Usuario"] == null)
                Response.Redirect("~/login.aspx");
            Orden();
        }
        static void Orden()
        {
            int x = 7;
            for (int i = 1; i < 17; i++)
            {
                Arreglo[i, 0] = x.ToString() + ":00";
                x += 1;
            }

            Arreglo[0, 1] = "Lunes";
            Arreglo[0, 2] = "Martes";
            Arreglo[0, 3] = "Miercoles";
            Arreglo[0, 4] = "Jueves";
            Arreglo[0, 5] = "Viernes";
            Arreglo[0, 6] = "Sabado";
            for (int i = 1; i < 17; i++)
            {
                for (int j = 1; j < 7; j++)
                {
                    if (Arreglo[i, j] != "X" && Arreglo[i, j] != "V") 
                        Arreglo[i, j] = "O";
                    x += 1;
                }
            }
        }
        #region Botones
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (R == true)
            {
                if (Button1.BackColor == System.Drawing.Color.Silver)
                {
                    Button1.BackColor = System.Drawing.Color.Green;
                    Arreglo[1, 1] = "X";
                }
                else
                {
                    Button1.BackColor = System.Drawing.Color.Silver;
                    Arreglo[1, 1] = "O";
                }
            }
            else
                if (Button1.Enabled == true)
            {
                if (Button1.BackColor == System.Drawing.Color.Silver)
                {
                    Button1.BackColor = System.Drawing.Color.Red;
                    Arreglo[1, 1] = "V";
                }

                else
                {
                    Button1.BackColor = System.Drawing.Color.Silver;
                    Arreglo[1, 1] = "O";
                }
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (R == true)
            {
                if (Button2.BackColor == System.Drawing.Color.Silver)
                {
                    Button2.BackColor = System.Drawing.Color.Green;
                    Arreglo[2, 1] = "X";
                }
                else
                {
                    Button2.BackColor = System.Drawing.Color.Silver;
                    Arreglo[2, 1] = "O";
                }
            }
            else
                if (Button2.Enabled == true)
            {
                if (Button2.BackColor == System.Drawing.Color.Silver)
                {
                    Button2.BackColor = System.Drawing.Color.Red;
                    Arreglo[2, 1] = "V";
                }

                else
                {
                    Button2.BackColor = System.Drawing.Color.Silver;
                    Arreglo[2, 1] = "O";
                }
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            if (R == true)
            {
                if (Button3.BackColor == System.Drawing.Color.Silver)
                {
                    Button3.BackColor = System.Drawing.Color.Green;
                    Arreglo[3, 1] = "X";
                }
                else
                {
                    Button3.BackColor = System.Drawing.Color.Silver;
                    Arreglo[3, 1] = "O";
                }
            }
            else
                if (Button3.Enabled == true)
            {
                if (Button3.BackColor == System.Drawing.Color.Silver)
                {
                    Button3.BackColor = System.Drawing.Color.Red;
                    Arreglo[3, 1] = "V";
                }

                else
                {
                    Button3.BackColor = System.Drawing.Color.Silver;
                    Arreglo[3, 1] = "O";
                }
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            if (R == true)
            {
                if (Button4.BackColor == System.Drawing.Color.Silver)
                {
                    Button4.BackColor = System.Drawing.Color.Green;
                    Arreglo[4, 1] = "X";
                }
                else
                {
                    Button4.BackColor = System.Drawing.Color.Silver;
                    Arreglo[4, 1] = "O";
                }
            }
            else
                if (Button4.Enabled == true)
            {
                if (Button4.BackColor == System.Drawing.Color.Silver)
                {
                    Button4.BackColor = System.Drawing.Color.Red;
                    Arreglo[4, 1] = "V";
                }

                else
                {
                    Button4.BackColor = System.Drawing.Color.Silver;
                    Arreglo[4, 1] = "O";
                }
            }
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            if (R == true)
            {
                if (Button5.BackColor == System.Drawing.Color.Silver)
                {
                    Button5.BackColor = System.Drawing.Color.Green;
                    Arreglo[5, 1] = "X";
                }
                else
                {
                    Button5.BackColor = System.Drawing.Color.Silver;
                    Arreglo[5, 1] = "O";
                }
            }
            else
                if (Button5.Enabled == true)
            {
                if (Button5.BackColor == System.Drawing.Color.Silver)
                {
                    Button5.BackColor = System.Drawing.Color.Red;
                    Arreglo[5, 1] = "V";
                }

                else
                {
                    Button5.BackColor = System.Drawing.Color.Silver;
                    Arreglo[5, 1] = "O";
                }
            }
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            if (R == true)
            {
                if (Button6.BackColor == System.Drawing.Color.Silver)
                {
                    Button6.BackColor = System.Drawing.Color.Green;
                    Arreglo[6, 1] = "X";
                }
                else
                {
                    Button6.BackColor = System.Drawing.Color.Silver;
                    Arreglo[6, 1] = "O";
                }
            }
            else
                if (Button6.Enabled == true)
            {
                if (Button6.BackColor == System.Drawing.Color.Silver)
                {
                    Button6.BackColor = System.Drawing.Color.Red;
                    Arreglo[6, 1] = "V";
                }

                else
                {
                    Button6.BackColor = System.Drawing.Color.Silver;
                    Arreglo[6, 1] = "O";
                }
            }
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            if (R == true)
            {
                if (Button7.BackColor == System.Drawing.Color.Silver)
                {
                    Button7.BackColor = System.Drawing.Color.Green;
                    Arreglo[7, 1] = "X";
                }
                else
                {
                    Button7.BackColor = System.Drawing.Color.Silver;
                    Arreglo[7, 1] = "O";
                }
            }
            else
                if (Button7.Enabled == true)
            {
                if (Button7.BackColor == System.Drawing.Color.Silver)
                {
                    Button7.BackColor = System.Drawing.Color.Red;
                    Arreglo[7, 1] = "V";
                }

                else
                {
                    Button7.BackColor = System.Drawing.Color.Silver;
                    Arreglo[7, 1] = "O";
                }
            }
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            if (R == true)
            {
                if (Button8.BackColor == System.Drawing.Color.Silver)
                {
                    Button8.BackColor = System.Drawing.Color.Green;
                    Arreglo[8, 1] = "X";
                }
                else
                {
                    Button8.BackColor = System.Drawing.Color.Silver;
                    Arreglo[8, 1] = "O";
                }
            }
            else
                if (Button8.Enabled == true)
            {
                if (Button8.BackColor == System.Drawing.Color.Silver)
                {
                    Button8.BackColor = System.Drawing.Color.Red;
                    Arreglo[8, 1] = "V";
                }

                else
                {
                    Button8.BackColor = System.Drawing.Color.Silver;
                    Arreglo[8, 1] = "O";
                }
            }
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            if (R == true)
            {
                if (Button9.BackColor == System.Drawing.Color.Silver)
                {
                    Button9.BackColor = System.Drawing.Color.Green;
                    Arreglo[9, 1] = "X";
                }
                else
                {
                    Button9.BackColor = System.Drawing.Color.Silver;
                    Arreglo[9, 1] = "O";
                }
            }
            else
                if (Button9.Enabled == true)
            {
                if (Button9.BackColor == System.Drawing.Color.Silver)
                {
                    Button9.BackColor = System.Drawing.Color.Red;
                    Arreglo[9, 1] = "V";
                }

                else
                {
                    Button9.BackColor = System.Drawing.Color.Silver;
                    Arreglo[9, 1] = "O";
                }
            }
        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            if (R == true)
            {
                if (Button10.BackColor == System.Drawing.Color.Silver)
                {
                    Button10.BackColor = System.Drawing.Color.Green;
                    Arreglo[10, 1] = "X";
                }
                else
                {
                    Button10.BackColor = System.Drawing.Color.Silver;
                    Arreglo[10, 1] = "O";
                }
            }
            else
                if (Button10.Enabled == true)
            {
                if (Button10.BackColor == System.Drawing.Color.Silver)
                {
                    Button10.BackColor = System.Drawing.Color.Red;
                    Arreglo[10, 1] = "V";
                }

                else
                {
                    Button10.BackColor = System.Drawing.Color.Silver;
                    Arreglo[10, 1] = "O";
                }
            }
        }

        protected void Button11_Click(object sender, EventArgs e)
        {
            if (R == true)
            {
                if (Button11.BackColor == System.Drawing.Color.Silver)
                {
                    Button11.BackColor = System.Drawing.Color.Green;
                    Arreglo[11, 1] = "X";
                }
                else
                {
                    Button11.BackColor = System.Drawing.Color.Silver;
                    Arreglo[11, 1] = "O";
                }
            }
            else
                if (Button11.Enabled == true)
            {
                if (Button11.BackColor == System.Drawing.Color.Silver)
                {
                    Button11.BackColor = System.Drawing.Color.Red;
                    Arreglo[11, 1] = "V";
                }

                else
                {
                    Button11.BackColor = System.Drawing.Color.Silver;
                    Arreglo[11, 1] = "O";
                }
            }
        }

        protected void Button12_Click(object sender, EventArgs e)
        {
            if (R == true)
            {
                if (Button12.BackColor == System.Drawing.Color.Silver)
                {
                    Button12.BackColor = System.Drawing.Color.Green;
                    Arreglo[12, 1] = "X";
                }
                else
                {
                    Button12.BackColor = System.Drawing.Color.Silver;
                    Arreglo[12, 1] = "O";
                }
            }
            else
                if (Button12.Enabled == true)
            {
                if (Button12.BackColor == System.Drawing.Color.Silver)
                {
                    Button12.BackColor = System.Drawing.Color.Red;
                    Arreglo[12, 1] = "V";
                }

                else
                {
                    Button12.BackColor = System.Drawing.Color.Silver;
                    Arreglo[12, 1] = "O";
                }
            }
        }

        protected void Button13_Click(object sender, EventArgs e)
        {
            if (R == true)
            {
                if (Button13.BackColor == System.Drawing.Color.Silver)
                {
                    Button13.BackColor = System.Drawing.Color.Green;
                    Arreglo[13, 1] = "X";
                }
                else
                {
                    Button13.BackColor = System.Drawing.Color.Silver;
                    Arreglo[13, 1] = "O";
                }
            }
            else
                if (Button13.Enabled == true)
            {
                if (Button13.BackColor == System.Drawing.Color.Silver)
                {
                    Button13.BackColor = System.Drawing.Color.Red;
                    Arreglo[13, 1] = "V";
                }

                else
                {
                    Button13.BackColor = System.Drawing.Color.Silver;
                    Arreglo[13, 1] = "O";
                }
            }
        }

        protected void Button14_Click(object sender, EventArgs e)
        {
            if (R == true)
            {
                if (Button14.BackColor == System.Drawing.Color.Silver)
                {
                    Button14.BackColor = System.Drawing.Color.Green;
                    Arreglo[14, 1] = "X";
                }
                else
                {
                    Button14.BackColor = System.Drawing.Color.Silver;
                    Arreglo[14, 1] = "O";
                }
            }
            else
                if (Button14.Enabled == true)
            {
                if (Button14.BackColor == System.Drawing.Color.Silver)
                {
                    Button14.BackColor = System.Drawing.Color.Red;
                    Arreglo[14, 1] = "V";
                }

                else
                {
                    Button14.BackColor = System.Drawing.Color.Silver;
                    Arreglo[14, 1] = "O";
                }
            }
        }

        protected void Button15_Click(object sender, EventArgs e)
        {
            if (R == true)
            {
                if (Button15.BackColor == System.Drawing.Color.Silver)
                {
                    Button15.BackColor = System.Drawing.Color.Green;
                    Arreglo[15, 1] = "X";
                }
                else
                {
                    Button15.BackColor = System.Drawing.Color.Silver;
                    Arreglo[15, 1] = "O";
                }
            }
            else
                if (Button15.Enabled == true)
            {
                if (Button15.BackColor == System.Drawing.Color.Silver)
                {
                    Button15.BackColor = System.Drawing.Color.Red;
                    Arreglo[15, 1] = "V";
                }

                else
                {
                    Button15.BackColor = System.Drawing.Color.Silver;
                    Arreglo[15, 1] = "O";
                }
            }
        }

        protected void Button16_Click(object sender, EventArgs e)
        {
            if (R == true)
            {
                if (Button16.BackColor == System.Drawing.Color.Silver)
                {
                    Button16.BackColor = System.Drawing.Color.Green;
                    Arreglo[16, 1] = "X";
                }
                else
                {
                    Button16.BackColor = System.Drawing.Color.Silver;
                    Arreglo[16, 1] = "O";
                }
            }
            else
                if (Button16.Enabled == true)
            {
                if (Button16.BackColor == System.Drawing.Color.Silver)
                {
                    Button16.BackColor = System.Drawing.Color.Red;
                    Arreglo[16, 1] = "V";
                }

                else
                {
                    Button16.BackColor = System.Drawing.Color.Silver;
                    Arreglo[16, 1] = "O";
                }
            }
        }

        protected void Button17_Click(object sender, EventArgs e)
        {
            if (R == true)
            {
                if (Button17.BackColor == System.Drawing.Color.Silver)
                {
                    Button17.BackColor = System.Drawing.Color.Green;
                    Arreglo[1, 2] = "X";
                }
                else
                {
                    Button17.BackColor = System.Drawing.Color.Silver;
                    Arreglo[1, 2] = "O";
                }
            }
            else
                if (Button17.Enabled == true)
            {
                if (Button17.BackColor == System.Drawing.Color.Silver)
                {
                    Button17.BackColor = System.Drawing.Color.Red;
                    Arreglo[1, 2] = "V";
                }

                else
                {
                    Button17.BackColor = System.Drawing.Color.Silver;
                    Arreglo[1, 2] = "O";
                }
            }
        }

        protected void Button18_Click(object sender, EventArgs e)
        {
            if (R == true)
            {
                if (Button18.BackColor == System.Drawing.Color.Silver)
                {
                    Button18.BackColor = System.Drawing.Color.Green;
                    Arreglo[2, 2] = "X";
                }
                else
                {
                    Button18.BackColor = System.Drawing.Color.Silver;
                    Arreglo[2, 2] = "O";
                }
            }
            else
                if (Button18.Enabled == true)
            {
                if (Button18.BackColor == System.Drawing.Color.Silver)
                {
                    Button18.BackColor = System.Drawing.Color.Red;
                    Arreglo[2, 2] = "V";
                }

                else
                {
                    Button18.BackColor = System.Drawing.Color.Silver;
                    Arreglo[2, 2] = "O";
                }
            }
        }

        protected void Button19_Click(object sender, EventArgs e)
        {
            if (R == true)
            {
                if (Button19.BackColor == System.Drawing.Color.Silver)
                {
                    Button19.BackColor = System.Drawing.Color.Green;
                    Arreglo[3, 2] = "X";
                }
                else
                {
                    Button19.BackColor = System.Drawing.Color.Silver;
                    Arreglo[3, 2] = "O";
                }
            }
            else
                if (Button19.Enabled == true)
            {
                if (Button19.BackColor == System.Drawing.Color.Silver)
                {
                    Button19.BackColor = System.Drawing.Color.Red;
                    Arreglo[3, 2] = "V";
                }

                else
                {
                    Button19.BackColor = System.Drawing.Color.Silver;
                    Arreglo[3, 2] = "O";
                }
            }
        }

        protected void Button20_Click(object sender, EventArgs e)
        {
            if (R == true)
            {
                if (Button20.BackColor == System.Drawing.Color.Silver)
                {
                    Button20.BackColor = System.Drawing.Color.Green;
                    Arreglo[4, 2] = "X";
                }
                else
                {
                    Button20.BackColor = System.Drawing.Color.Silver;
                    Arreglo[4, 2] = "O";
                }
            }
            else
                if (Button20.Enabled == true)
            {
                if (Button20.BackColor == System.Drawing.Color.Silver)
                {
                    Button20.BackColor = System.Drawing.Color.Red;
                    Arreglo[4, 2] = "V";
                }

                else
                {
                    Button20.BackColor = System.Drawing.Color.Silver;
                    Arreglo[4, 2] = "O";
                }
            }
        }

        protected void Button21_Click(object sender, EventArgs e)
        {
            if (R == true)
            {
                if (Button21.BackColor == System.Drawing.Color.Silver)
                {
                    Button21.BackColor = System.Drawing.Color.Green;
                    Arreglo[5, 2] = "X";
                }
                else
                {
                    Button21.BackColor = System.Drawing.Color.Silver;
                    Arreglo[5, 2] = "O";
                }
            }
            else
                if (Button21.Enabled == true)
            {
                if (Button21.BackColor == System.Drawing.Color.Silver)
                {
                    Button21.BackColor = System.Drawing.Color.Red;
                    Arreglo[5, 2] = "V";
                }

                else
                {
                    Button21.BackColor = System.Drawing.Color.Silver;
                    Arreglo[5, 2] = "O";
                }
            }
        }

        protected void Button22_Click(object sender, EventArgs e)
        {
            if (R == true)
            {
                if (Button22.BackColor == System.Drawing.Color.Silver)
                {
                    Button22.BackColor = System.Drawing.Color.Green;
                    Arreglo[6, 2] = "X";
                }
                else
                {
                    Button22.BackColor = System.Drawing.Color.Silver;
                    Arreglo[6, 2] = "O";
                }
            }
            else
                if (Button22.Enabled == true)
            {
                if (Button22.BackColor == System.Drawing.Color.Silver)
                {
                    Button22.BackColor = System.Drawing.Color.Red;
                    Arreglo[6, 2] = "V";
                }

                else
                {
                    Button22.BackColor = System.Drawing.Color.Silver;
                    Arreglo[6, 2] = "O";
                }
            }
        }

        protected void Button23_Click(object sender, EventArgs e)
        {
            if (R == true)
            {
                if (Button23.BackColor == System.Drawing.Color.Silver)
                {
                    Button23.BackColor = System.Drawing.Color.Green;
                    Arreglo[7, 2] = "X";
                }
                else
                {
                    Button23.BackColor = System.Drawing.Color.Silver;
                    Arreglo[7, 2] = "O";
                }
            }
            else
                if (Button23.Enabled == true)
            {
                if (Button23.BackColor == System.Drawing.Color.Silver)
                {
                    Button23.BackColor = System.Drawing.Color.Red;
                    Arreglo[7, 2] = "V";
                }

                else
                {
                    Button23.BackColor = System.Drawing.Color.Silver;
                    Arreglo[7, 2] = "O";
                }
            }
        }

        protected void Button24_Click(object sender, EventArgs e)
        {
            if (R == true)
            {
                if (Button24.BackColor == System.Drawing.Color.Silver)
                {
                    Button24.BackColor = System.Drawing.Color.Green;
                    Arreglo[8, 2] = "X";
                }
                else
                {
                    Button24.BackColor = System.Drawing.Color.Silver;
                    Arreglo[8, 2] = "O";
                }
            }
            else
                if (Button24.Enabled == true)
            {
                if (Button24.BackColor == System.Drawing.Color.Silver)
                {
                    Button24.BackColor = System.Drawing.Color.Red;
                    Arreglo[8, 2] = "V";
                }

                else
                {
                    Button24.BackColor = System.Drawing.Color.Silver;
                    Arreglo[8, 2] = "O";
                }
            }
        }

        protected void Button25_Click(object sender, EventArgs e)
        {
            if (R == true)
            {
                if (Button25.BackColor == System.Drawing.Color.Silver)
                {
                    Button25.BackColor = System.Drawing.Color.Green;
                    Arreglo[9, 2] = "X";
                }
                else
                {
                    Button25.BackColor = System.Drawing.Color.Silver;
                    Arreglo[9, 2] = "O";
                }
            }
            else
                if (Button25.Enabled == true)
            {
                if (Button25.BackColor == System.Drawing.Color.Silver)
                {
                    Button25.BackColor = System.Drawing.Color.Red;
                    Arreglo[9, 2] = "V";
                }

                else
                {
                    Button25.BackColor = System.Drawing.Color.Silver;
                    Arreglo[9, 2] = "O";
                }
            }
        }

        protected void Button26_Click(object sender, EventArgs e)
        {
            if (R == true)
            {
                if (Button26.BackColor == System.Drawing.Color.Silver)
                {
                    Button26.BackColor = System.Drawing.Color.Green;
                    Arreglo[10, 2] = "X";
                }
                else
                {
                    Button26.BackColor = System.Drawing.Color.Silver;
                    Arreglo[10, 2] = "O";
                }
            }
            else
                if (Button26.Enabled == true)
            {
                if (Button26.BackColor == System.Drawing.Color.Silver)
                {
                    Button26.BackColor = System.Drawing.Color.Red;
                    Arreglo[10, 2] = "V";
                }

                else
                {
                    Button26.BackColor = System.Drawing.Color.Silver;
                    Arreglo[10, 2] = "O";
                }
            }
        }

        protected void Button27_Click(object sender, EventArgs e)
        {
            if (R == true)
            {
                if (Button27.BackColor == System.Drawing.Color.Silver)
                {
                    Button27.BackColor = System.Drawing.Color.Green;
                    Arreglo[11, 2] = "X";
                }
                else
                {
                    Button27.BackColor = System.Drawing.Color.Silver;
                    Arreglo[11, 2] = "O";
                }
            }
            else
                if (Button27.Enabled == true)
            {
                if (Button27.BackColor == System.Drawing.Color.Silver)
                {
                    Button27.BackColor = System.Drawing.Color.Red;
                    Arreglo[11, 2] = "V";
                }

                else
                {
                    Button27.BackColor = System.Drawing.Color.Silver;
                    Arreglo[11, 2] = "O";
                }
            }
        }

        protected void Button28_Click(object sender, EventArgs e)
        {
            if (R == true)
            {
                if (Button28.BackColor == System.Drawing.Color.Silver)
                {
                    Button28.BackColor = System.Drawing.Color.Green;
                    Arreglo[12, 2] = "X";
                }
                else
                {
                    Button28.BackColor = System.Drawing.Color.Silver;
                    Arreglo[12, 2] = "O";
                }
            }
            else
                if (Button28.Enabled == true)
            {
                if (Button28.BackColor == System.Drawing.Color.Silver)
                {
                    Button28.BackColor = System.Drawing.Color.Red;
                    Arreglo[12, 2] = "V";
                }

                else
                {
                    Button28.BackColor = System.Drawing.Color.Silver;
                    Arreglo[12, 2] = "O";
                }
            }
        }

        protected void Button29_Click(object sender, EventArgs e)
        {
            if (R == true)
            {
                if (Button29.BackColor == System.Drawing.Color.Silver)
                {
                    Button29.BackColor = System.Drawing.Color.Green;
                    Arreglo[13, 2] = "X";
                }
                else
                {
                    Button29.BackColor = System.Drawing.Color.Silver;
                    Arreglo[13, 2] = "O";
                }
            }
            else
                if (Button29.Enabled == true)
            {
                if (Button29.BackColor == System.Drawing.Color.Silver)
                {
                    Button29.BackColor = System.Drawing.Color.Red;
                    Arreglo[13, 2] = "V";
                }

                else
                {
                    Button29.BackColor = System.Drawing.Color.Silver;
                    Arreglo[13, 2] = "O";
                }
            }
        }

        protected void Button30_Click(object sender, EventArgs e)
        {
            if (R == true)
            {
                if (Button30.BackColor == System.Drawing.Color.Silver)
                {
                    Button30.BackColor = System.Drawing.Color.Green;
                    Arreglo[14, 2] = "X";
                }
                else
                {
                    Button30.BackColor = System.Drawing.Color.Silver;
                    Arreglo[14, 2] = "O";
                }
            }
            else
                if (Button30.Enabled == true)
            {
                if (Button30.BackColor == System.Drawing.Color.Silver)
                {
                    Button30.BackColor = System.Drawing.Color.Red;
                    Arreglo[14, 2] = "V";
                }

                else
                {
                    Button30.BackColor = System.Drawing.Color.Silver;
                    Arreglo[14, 2] = "O";
                }
            }
        }

        protected void Button31_Click(object sender, EventArgs e)
        {
            if (R == true)
            {
                if (Button31.BackColor == System.Drawing.Color.Silver)
                {
                    Button31.BackColor = System.Drawing.Color.Green;
                    Arreglo[15, 2] = "X";
                }
                else
                {
                    Button31.BackColor = System.Drawing.Color.Silver;
                    Arreglo[15, 2] = "O";
                }
            }
            else
                if (Button31.Enabled == true)
            {
                if (Button31.BackColor == System.Drawing.Color.Silver)
                {
                    Button31.BackColor = System.Drawing.Color.Red;
                    Arreglo[15, 2] = "V";
                }

                else
                {
                    Button31.BackColor = System.Drawing.Color.Silver;
                    Arreglo[15, 2] = "O";
                }
            }
        }

        protected void Button32_Click(object sender, EventArgs e)
        {
            if (R == true)
            {
                if (Button32.BackColor == System.Drawing.Color.Silver)
                {
                    Button32.BackColor = System.Drawing.Color.Green;
                    Arreglo[16, 2] = "X";
                }
                else
                {
                    Button32.BackColor = System.Drawing.Color.Silver;
                    Arreglo[16, 2] = "O";
                }
            }
            else
                if (Button32.Enabled == true)
            {
                if (Button32.BackColor == System.Drawing.Color.Silver)
                {
                    Button32.BackColor = System.Drawing.Color.Red;
                    Arreglo[16, 2] = "V";
                }

                else
                {
                    Button32.BackColor = System.Drawing.Color.Silver;
                    Arreglo[16, 2] = "O";
                }
            }
        }

        protected void Button33_Click(object sender, EventArgs e)
        {
            if (R == true)
            {
                if (Button33.BackColor == System.Drawing.Color.Silver)
                {
                    Button33.BackColor = System.Drawing.Color.Green;
                    Arreglo[1, 3] = "X";
                }
                else
                {
                    Button33.BackColor = System.Drawing.Color.Silver;
                    Arreglo[1, 3] = "O";
                }
            }
            else
                if (Button33.Enabled == true)
            {
                if (Button33.BackColor == System.Drawing.Color.Silver)
                {
                    Button33.BackColor = System.Drawing.Color.Red;
                    Arreglo[1, 3] = "V";
                }

                else
                {
                    Button33.BackColor = System.Drawing.Color.Silver;
                    Arreglo[1, 3] = "O";
                }
            }
        }

        protected void Button34_Click(object sender, EventArgs e)
        {
            if (R == true)
            {
                if (Button34.BackColor == System.Drawing.Color.Silver)
                {
                    Button34.BackColor = System.Drawing.Color.Green;
                    Arreglo[2, 3] = "X";
                }
                else
                {
                    Button34.BackColor = System.Drawing.Color.Silver;
                    Arreglo[2, 3] = "O";
                }
            }
            else
                if (Button34.Enabled == true)
            {
                if (Button34.BackColor == System.Drawing.Color.Silver)
                {
                    Button34.BackColor = System.Drawing.Color.Red;
                    Arreglo[2, 3] = "V";
                }

                else
                {
                    Button34.BackColor = System.Drawing.Color.Silver;
                    Arreglo[2, 3] = "O";
                }
            }
        }

        protected void Button35_Click(object sender, EventArgs e)
        {
            if (R == true)
            {
                if (Button35.BackColor == System.Drawing.Color.Silver)
                {
                    Button35.BackColor = System.Drawing.Color.Green;
                    Arreglo[3, 3] = "X";
                }
                else
                {
                    Button35.BackColor = System.Drawing.Color.Silver;
                    Arreglo[3, 3] = "O";
                }
            }
            else
                if (Button35.Enabled == true)
            {
                if (Button35.BackColor == System.Drawing.Color.Silver)
                {
                    Button35.BackColor = System.Drawing.Color.Red;
                    Arreglo[3, 3] = "V";
                }

                else
                {
                    Button35.BackColor = System.Drawing.Color.Silver;
                    Arreglo[3, 3] = "O";
                }
            }
        }

        protected void Button36_Click(object sender, EventArgs e)
        {
            if (R == true)
            {
                if (Button36.BackColor == System.Drawing.Color.Silver)
                {
                    Button36.BackColor = System.Drawing.Color.Green;
                    Arreglo[4, 3] = "X";
                }
                else
                {
                    Button36.BackColor = System.Drawing.Color.Silver;
                    Arreglo[4, 3] = "O";
                }
            }
            else
                if (Button36.Enabled == true)
            {
                if (Button36.BackColor == System.Drawing.Color.Silver)
                {
                    Button36.BackColor = System.Drawing.Color.Red;
                    Arreglo[4, 3] = "V";
                }

                else
                {
                    Button36.BackColor = System.Drawing.Color.Silver;
                    Arreglo[4, 3] = "O";
                }
            }
        }

        protected void Button37_Click(object sender, EventArgs e)
        {
            if (R == true)
            {
                if (Button37.BackColor == System.Drawing.Color.Silver)
                {
                    Button37.BackColor = System.Drawing.Color.Green;
                    Arreglo[5, 3] = "X";
                }
                else
                {
                    Button37.BackColor = System.Drawing.Color.Silver;
                    Arreglo[5, 3] = "O";
                }
            }
            else
                if (Button37.Enabled == true)
            {
                if (Button37.BackColor == System.Drawing.Color.Silver)
                {
                    Button37.BackColor = System.Drawing.Color.Red;
                    Arreglo[5, 3] = "V";
                }

                else
                {
                    Button37.BackColor = System.Drawing.Color.Silver;
                    Arreglo[5, 3] = "O";
                }
            }
        }

        protected void Button38_Click(object sender, EventArgs e)
        {
            if (R == true)
            {
                if (Button38.BackColor == System.Drawing.Color.Silver)
                {
                    Button38.BackColor = System.Drawing.Color.Green;
                    Arreglo[6, 3] = "X";
                }
                else
                {
                    Button38.BackColor = System.Drawing.Color.Silver;
                    Arreglo[6, 3] = "O";
                }
            }
            else
                if (Button38.Enabled == true)
            {
                if (Button38.BackColor == System.Drawing.Color.Silver)
                {
                    Button38.BackColor = System.Drawing.Color.Red;
                    Arreglo[6, 3] = "V";
                }

                else
                {
                    Button38.BackColor = System.Drawing.Color.Silver;
                    Arreglo[6, 3] = "O";
                }
            }
        }

        protected void Button39_Click(object sender, EventArgs e)
        {
            if (R == true)
            {
                if (Button39.BackColor == System.Drawing.Color.Silver)
                {
                    Button39.BackColor = System.Drawing.Color.Green;
                    Arreglo[7, 3] = "X";
                }
                else
                {
                    Button39.BackColor = System.Drawing.Color.Silver;
                    Arreglo[7, 3] = "O";
                }
            }
            else
                if (Button39.Enabled == true)
            {
                if (Button39.BackColor == System.Drawing.Color.Silver)
                {
                    Button39.BackColor = System.Drawing.Color.Red;
                    Arreglo[7, 3] = "V";
                }

                else
                {
                    Button39.BackColor = System.Drawing.Color.Silver;
                    Arreglo[7, 3] = "O";
                }
            }
        }

        protected void Button40_Click(object sender, EventArgs e)
        {
            if (R == true)
            {
                if (Button40.BackColor == System.Drawing.Color.Silver)
                {
                    Button40.BackColor = System.Drawing.Color.Green;
                    Arreglo[8, 3] = "X";
                }
                else
                {
                    Button40.BackColor = System.Drawing.Color.Silver;
                    Arreglo[8, 3] = "O";
                }
            }
            else
                if (Button40.Enabled == true)
            {
                if (Button40.BackColor == System.Drawing.Color.Silver)
                {
                    Button40.BackColor = System.Drawing.Color.Red;
                    Arreglo[8, 3] = "V";
                }

                else
                {
                    Button40.BackColor = System.Drawing.Color.Silver;
                    Arreglo[8, 3] = "O";
                }
            }
        }

        protected void Button41_Click(object sender, EventArgs e)
        {
            if (R == true)
            {
                if (Button41.BackColor == System.Drawing.Color.Silver)
                {
                    Button41.BackColor = System.Drawing.Color.Green;
                    Arreglo[9, 3] = "X";
                }
                else
                {
                    Button41.BackColor = System.Drawing.Color.Silver;
                    Arreglo[9, 3] = "O";
                }
            }
            else
                if (Button41.Enabled == true)
            {
                if (Button41.BackColor == System.Drawing.Color.Silver)
                {
                    Button41.BackColor = System.Drawing.Color.Red;
                    Arreglo[9, 3] = "V";
                }

                else
                {
                    Button41.BackColor = System.Drawing.Color.Silver;
                    Arreglo[9, 3] = "O";
                }
            }
        }

        protected void Button42_Click(object sender, EventArgs e)
        {
            if (R == true)
            {
                if (Button42.BackColor == System.Drawing.Color.Silver)
                {
                    Button42.BackColor = System.Drawing.Color.Green;
                    Arreglo[10, 3] = "X";
                }
                else
                {
                    Button42.BackColor = System.Drawing.Color.Silver;
                    Arreglo[10, 3] = "O";
                }
            }
            else
                if (Button42.Enabled == true)
            {
                if (Button42.BackColor == System.Drawing.Color.Silver)
                {
                    Button42.BackColor = System.Drawing.Color.Red;
                    Arreglo[10, 3] = "V";
                }

                else
                {
                    Button42.BackColor = System.Drawing.Color.Silver;
                    Arreglo[10, 3] = "O";
                }
            }
        }

        protected void Button43_Click(object sender, EventArgs e)
        {
            if (R == true)
            {
                if (Button43.BackColor == System.Drawing.Color.Silver)
                {
                    Button43.BackColor = System.Drawing.Color.Green;
                    Arreglo[11, 3] = "X";
                }
                else
                {
                    Button43.BackColor = System.Drawing.Color.Silver;
                    Arreglo[11, 3] = "O";
                }
            }
            else
                if (Button43.Enabled == true)
            {
                if (Button43.BackColor == System.Drawing.Color.Silver)
                {
                    Button43.BackColor = System.Drawing.Color.Red;
                    Arreglo[11, 3] = "V";
                }

                else
                {
                    Button43.BackColor = System.Drawing.Color.Silver;
                    Arreglo[11, 3] = "O";
                }
            }
        }

        protected void Button44_Click(object sender, EventArgs e)
        {
            if (R == true)
            {
                if (Button44.BackColor == System.Drawing.Color.Silver)
                {
                    Button44.BackColor = System.Drawing.Color.Green;
                    Arreglo[12, 3] = "X";
                }
                else
                {
                    Button44.BackColor = System.Drawing.Color.Silver;
                    Arreglo[12, 3] = "O";
                }
            }
            else
                if (Button44.Enabled == true)
            {
                if (Button44.BackColor == System.Drawing.Color.Silver)
                {
                    Button44.BackColor = System.Drawing.Color.Red;
                    Arreglo[12, 3] = "V";
                }

                else
                {
                    Button44.BackColor = System.Drawing.Color.Silver;
                    Arreglo[12, 3] = "O";
                }
            }
        }

        protected void Button45_Click(object sender, EventArgs e)
        {
            if (R == true)
            {
                if (Button45.BackColor == System.Drawing.Color.Silver)
                {
                    Button45.BackColor = System.Drawing.Color.Green;
                    Arreglo[13, 3] = "X";
                }
                else
                {
                    Button45.BackColor = System.Drawing.Color.Silver;
                    Arreglo[13, 3] = "O";
                }
            }
            else
                if (Button45.Enabled == true)
            {
                if (Button45.BackColor == System.Drawing.Color.Silver)
                {
                    Button45.BackColor = System.Drawing.Color.Red;
                    Arreglo[13, 3] = "V";
                }

                else
                {
                    Button45.BackColor = System.Drawing.Color.Silver;
                    Arreglo[13, 3] = "O";
                }
            }
        }

        protected void Button46_Click(object sender, EventArgs e)
        {
            if (R == true)
            {
                if (Button46.BackColor == System.Drawing.Color.Silver)
                {
                    Button46.BackColor = System.Drawing.Color.Green;
                    Arreglo[14, 3] = "X";
                }
                else
                {
                    Button46.BackColor = System.Drawing.Color.Silver;
                    Arreglo[14, 3] = "O";
                }
            }
            else
                if (Button46.Enabled == true)
            {
                if (Button46.BackColor == System.Drawing.Color.Silver)
                {
                    Button46.BackColor = System.Drawing.Color.Red;
                    Arreglo[14, 3] = "V";
                }

                else
                {
                    Button46.BackColor = System.Drawing.Color.Silver;
                    Arreglo[14, 3] = "O";
                }
            }
        }

        protected void Button47_Click(object sender, EventArgs e)
        {
            if (R == true)
            {
                if (Button47.BackColor == System.Drawing.Color.Silver)
                {
                    Button47.BackColor = System.Drawing.Color.Green;
                    Arreglo[15, 3] = "X";
                }
                else
                {
                    Button47.BackColor = System.Drawing.Color.Silver;
                    Arreglo[15, 3] = "O";
                }
            }
            else
                if (Button47.Enabled == true)
            {
                if (Button47.BackColor == System.Drawing.Color.Silver)
                {
                    Button47.BackColor = System.Drawing.Color.Red;
                    Arreglo[15, 3] = "V";
                }

                else
                {
                    Button47.BackColor = System.Drawing.Color.Silver;
                    Arreglo[15, 3] = "O";
                }
            }
        }

        protected void Button48_Click(object sender, EventArgs e)
        {
            if (R == true)
            {
                if (Button48.BackColor == System.Drawing.Color.Silver)
                {
                    Button48.BackColor = System.Drawing.Color.Green;
                    Arreglo[16, 3] = "X";
                }
                else
                {
                    Button48.BackColor = System.Drawing.Color.Silver;
                    Arreglo[16, 3] = "O";
                }
            }
            else
                if (Button48.Enabled == true)
            {
                if (Button48.BackColor == System.Drawing.Color.Silver)
                {
                    Button48.BackColor = System.Drawing.Color.Red;
                    Arreglo[16, 3] = "V";
                }

                else
                {
                    Button48.BackColor = System.Drawing.Color.Silver;
                    Arreglo[16, 3] = "O";
                }
            }
        }

        protected void Button49_Click(object sender, EventArgs e)
        {
            if (R == true)
            {
                if (Button49.BackColor == System.Drawing.Color.Silver)
                {
                    Button49.BackColor = System.Drawing.Color.Green;
                    Arreglo[1, 4] = "X";
                }
                else
                {
                    Button49.BackColor = System.Drawing.Color.Silver;
                    Arreglo[1, 4] = "O";
                }
            }
            else
                if (Button49.Enabled == true)
            {
                if (Button49.BackColor == System.Drawing.Color.Silver)
                {
                    Button49.BackColor = System.Drawing.Color.Red;
                    Arreglo[1, 4] = "V";
                }

                else
                {
                    Button49.BackColor = System.Drawing.Color.Silver;
                    Arreglo[1, 4] = "O";
                }
            }
        }

        protected void Button50_Click(object sender, EventArgs e)
        {
            if (R == true)
            {
                if (Button50.BackColor == System.Drawing.Color.Silver)
                {
                    Button50.BackColor = System.Drawing.Color.Green;
                    Arreglo[2, 4] = "X";
                }
                else
                {
                    Button50.BackColor = System.Drawing.Color.Silver;
                    Arreglo[2, 4] = "O";
                }
            }
            else
                if (Button50.Enabled == true)
            {
                if (Button50.BackColor == System.Drawing.Color.Silver)
                {
                    Button50.BackColor = System.Drawing.Color.Red;
                    Arreglo[2, 4] = "V";
                }

                else
                {
                    Button50.BackColor = System.Drawing.Color.Silver;
                    Arreglo[2, 4] = "O";
                }
            }
        }

        protected void Button51_Click(object sender, EventArgs e)
        {
            if (R == true)
            {
                if (Button51.BackColor == System.Drawing.Color.Silver)
                {
                    Button51.BackColor = System.Drawing.Color.Green;
                    Arreglo[3, 4] = "X";
                }
                else
                {
                    Button51.BackColor = System.Drawing.Color.Silver;
                    Arreglo[3, 4] = "O";
                }
            }
            else
                if (Button51.Enabled == true)
            {
                if (Button51.BackColor == System.Drawing.Color.Silver)
                {
                    Button51.BackColor = System.Drawing.Color.Red;
                    Arreglo[3, 4] = "V";
                }

                else
                {
                    Button51.BackColor = System.Drawing.Color.Silver;
                    Arreglo[3, 4] = "O";
                }
            }
        }

        protected void Button52_Click(object sender, EventArgs e)
        {
            if (R == true)
            {
                if (Button52.BackColor == System.Drawing.Color.Silver)
                {
                    Button52.BackColor = System.Drawing.Color.Green;
                    Arreglo[4, 4] = "X";
                }
                else
                {
                    Button52.BackColor = System.Drawing.Color.Silver;
                    Arreglo[4, 4] = "O";
                }
            }
            else
                if (Button52.Enabled == true)
            {
                if (Button52.BackColor == System.Drawing.Color.Silver)
                {
                    Button52.BackColor = System.Drawing.Color.Red;
                    Arreglo[4, 4] = "V";
                }

                else
                {
                    Button52.BackColor = System.Drawing.Color.Silver;
                    Arreglo[4, 4] = "O";
                }
            }
        }

        protected void Button53_Click(object sender, EventArgs e)
        {
            if (R == true)
            {
                if (Button53.BackColor == System.Drawing.Color.Silver)
                {
                    Button53.BackColor = System.Drawing.Color.Green;
                    Arreglo[5, 4] = "X";
                }
                else
                {
                    Button53.BackColor = System.Drawing.Color.Silver;
                    Arreglo[5, 4] = "O";
                }
            }
            else
                if (Button53.Enabled == true)
            {
                if (Button53.BackColor == System.Drawing.Color.Silver)
                {
                    Button53.BackColor = System.Drawing.Color.Red;
                    Arreglo[5, 4] = "V";
                }

                else
                {
                    Button53.BackColor = System.Drawing.Color.Silver;
                    Arreglo[5, 4] = "O";
                }
            }
        }

        protected void Button54_Click(object sender, EventArgs e)
        {
            if (R == true)
            {
                if (Button54.BackColor == System.Drawing.Color.Silver)
                {
                    Button54.BackColor = System.Drawing.Color.Green;
                    Arreglo[6, 4] = "X";
                }
                else
                {
                    Button54.BackColor = System.Drawing.Color.Silver;
                    Arreglo[6, 4] = "O";
                }
            }
            else
                if (Button54.Enabled == true)
            {
                if (Button54.BackColor == System.Drawing.Color.Silver)
                {
                    Button54.BackColor = System.Drawing.Color.Red;
                    Arreglo[6, 4] = "V";
                }

                else
                {
                    Button54.BackColor = System.Drawing.Color.Silver;
                    Arreglo[6, 4] = "O";
                }
            }
        }

        protected void Button55_Click(object sender, EventArgs e)
        {
            if (R == true)
            {
                if (Button55.BackColor == System.Drawing.Color.Silver)
                {
                    Button55.BackColor = System.Drawing.Color.Green;
                    Arreglo[7, 4] = "X";
                }
                else
                {
                    Button55.BackColor = System.Drawing.Color.Silver;
                    Arreglo[7, 4] = "O";
                }
            }
            else
                if (Button55.Enabled == true)
            {
                if (Button55.BackColor == System.Drawing.Color.Silver)
                {
                    Button55.BackColor = System.Drawing.Color.Red;
                    Arreglo[7, 4] = "V";
                }

                else
                {
                    Button55.BackColor = System.Drawing.Color.Silver;
                    Arreglo[7, 4] = "O";
                }
            }
        }

        protected void Button56_Click(object sender, EventArgs e)
        {
            if (R == true)
            {
                if (Button56.BackColor == System.Drawing.Color.Silver)
                {
                    Button56.BackColor = System.Drawing.Color.Green;
                    Arreglo[8, 4] = "X";
                }
                else
                {
                    Button56.BackColor = System.Drawing.Color.Silver;
                    Arreglo[8, 4] = "O";
                }
            }
            else
                if (Button56.Enabled == true)
            {
                if (Button56.BackColor == System.Drawing.Color.Silver)
                {
                    Button56.BackColor = System.Drawing.Color.Red;
                    Arreglo[8, 4] = "V";
                }

                else
                {
                    Button56.BackColor = System.Drawing.Color.Silver;
                    Arreglo[8, 4] = "O";
                }
            }
        }

        protected void Button57_Click(object sender, EventArgs e)
        {
            if (R == true)
            {
                if (Button57.BackColor == System.Drawing.Color.Silver)
                {
                    Button57.BackColor = System.Drawing.Color.Green;
                    Arreglo[9, 4] = "X";
                }
                else
                {
                    Button57.BackColor = System.Drawing.Color.Silver;
                    Arreglo[9, 4] = "O";
                }
            }
            else
                if (Button57.Enabled == true)
            {
                if (Button57.BackColor == System.Drawing.Color.Silver)
                {
                    Button57.BackColor = System.Drawing.Color.Red;
                    Arreglo[9, 4] = "V";
                }

                else
                {
                    Button57.BackColor = System.Drawing.Color.Silver;
                    Arreglo[9, 4] = "O";
                }
            }
        }

        protected void Button58_Click(object sender, EventArgs e)
        {
            if (R == true)
            {
                if (Button58.BackColor == System.Drawing.Color.Silver)
                {
                    Button58.BackColor = System.Drawing.Color.Green;
                    Arreglo[10, 4] = "X";
                }
                else
                {
                    Button58.BackColor = System.Drawing.Color.Silver;
                    Arreglo[10, 4] = "O";
                }
            }
            else
                if (Button58.Enabled == true)
            {
                if (Button58.BackColor == System.Drawing.Color.Silver)
                {
                    Button58.BackColor = System.Drawing.Color.Red;
                    Arreglo[10, 4] = "V";
                }

                else
                {
                    Button58.BackColor = System.Drawing.Color.Silver;
                    Arreglo[10, 4] = "O";
                }
            }
        }

        protected void Button59_Click(object sender, EventArgs e)
        {
            if (R == true)
            {
                if (Button59.BackColor == System.Drawing.Color.Silver)
                {
                    Button59.BackColor = System.Drawing.Color.Green;
                    Arreglo[11, 4] = "X";
                }
                else
                {
                    Button59.BackColor = System.Drawing.Color.Silver;
                    Arreglo[11, 4] = "O";
                }
            }
            else
                if (Button59.Enabled == true)
            {
                if (Button59.BackColor == System.Drawing.Color.Silver)
                {
                    Button59.BackColor = System.Drawing.Color.Red;
                    Arreglo[11, 4] = "V";
                }

                else
                {
                    Button59.BackColor = System.Drawing.Color.Silver;
                    Arreglo[11, 4] = "O";
                }
            }
        }

        protected void Button60_Click(object sender, EventArgs e)
        {
            if (R == true)
            {
                if (Button60.BackColor == System.Drawing.Color.Silver)
                {
                    Button60.BackColor = System.Drawing.Color.Green;
                    Arreglo[12, 4] = "X";
                }
                else
                {
                    Button60.BackColor = System.Drawing.Color.Silver;
                    Arreglo[12, 4] = "O";
                }
            }
            else
                if (Button60.Enabled == true)
            {
                if (Button60.BackColor == System.Drawing.Color.Silver)
                {
                    Button60.BackColor = System.Drawing.Color.Red;
                    Arreglo[12, 4] = "V";
                }

                else
                {
                    Button60.BackColor = System.Drawing.Color.Silver;
                    Arreglo[12, 4] = "O";
                }
            }
        }

        protected void Button61_Click(object sender, EventArgs e)
        {
            if (R == true)
            {
                if (Button61.BackColor == System.Drawing.Color.Silver)
                {
                    Button61.BackColor = System.Drawing.Color.Green;
                    Arreglo[13, 4] = "X";
                }
                else
                {
                    Button61.BackColor = System.Drawing.Color.Silver;
                    Arreglo[13, 4] = "O";
                }
            }
            else
                if (Button61.Enabled == true)
            {
                if (Button61.BackColor == System.Drawing.Color.Silver)
                {
                    Button61.BackColor = System.Drawing.Color.Red;
                    Arreglo[13, 4] = "V";
                }

                else
                {
                    Button61.BackColor = System.Drawing.Color.Silver;
                    Arreglo[13, 4] = "O";
                }
            }
        }

        protected void Button62_Click(object sender, EventArgs e)
        {
            if (R == true)
            {
                if (Button62.BackColor == System.Drawing.Color.Silver)
                {
                    Button62.BackColor = System.Drawing.Color.Green;
                    Arreglo[14, 4] = "X";
                }
                else
                {
                    Button62.BackColor = System.Drawing.Color.Silver;
                    Arreglo[14, 4] = "O";
                }
            }
            else
                if (Button62.Enabled == true)
            {
                if (Button62.BackColor == System.Drawing.Color.Silver)
                {
                    Button62.BackColor = System.Drawing.Color.Red;
                    Arreglo[14, 4] = "V";
                }

                else
                {
                    Button62.BackColor = System.Drawing.Color.Silver;
                    Arreglo[14, 4] = "O";
                }
            }
        }

        protected void Button63_Click(object sender, EventArgs e)
        {
            if (R == true)
            {
                if (Button63.BackColor == System.Drawing.Color.Silver)
                {
                    Button63.BackColor = System.Drawing.Color.Green;
                    Arreglo[15, 4] = "X";
                }
                else
                {
                    Button63.BackColor = System.Drawing.Color.Silver;
                    Arreglo[15, 4] = "O";
                }
            }
            else
                if (Button63.Enabled == true)
            {
                if (Button63.BackColor == System.Drawing.Color.Silver)
                {
                    Button63.BackColor = System.Drawing.Color.Red;
                    Arreglo[15, 4] = "V";
                }

                else
                {
                    Button63.BackColor = System.Drawing.Color.Silver;
                    Arreglo[15, 4] = "O";
                }
            }
        }

        protected void Button64_Click(object sender, EventArgs e)
        {
            if (R == true)
            {
                if (Button64.BackColor == System.Drawing.Color.Silver)
                {
                    Button64.BackColor = System.Drawing.Color.Green;
                    Arreglo[16, 4] = "X";
                }
                else
                {
                    Button64.BackColor = System.Drawing.Color.Silver;
                    Arreglo[16, 4] = "O";
                }
            }
            else
                if (Button64.Enabled == true)
            {
                if (Button64.BackColor == System.Drawing.Color.Silver)
                {
                    Button64.BackColor = System.Drawing.Color.Red;
                    Arreglo[16, 4] = "V";
                }

                else
                {
                    Button64.BackColor = System.Drawing.Color.Silver;
                    Arreglo[16, 4] = "O";
                }
            }
        }

        protected void Button65_Click(object sender, EventArgs e)
        {
            if (R == true)
            {
                if (Button65.BackColor == System.Drawing.Color.Silver)
                {
                    Button65.BackColor = System.Drawing.Color.Green;
                    Arreglo[1, 5] = "X";
                }
                else
                {
                    Button65.BackColor = System.Drawing.Color.Silver;
                    Arreglo[1, 5] = "O";
                }
            }
            else
                if (Button65.Enabled == true)
            {
                if (Button65.BackColor == System.Drawing.Color.Silver)
                {
                    Button65.BackColor = System.Drawing.Color.Red;
                    Arreglo[1, 5] = "V";
                }

                else
                {
                    Button65.BackColor = System.Drawing.Color.Silver;
                    Arreglo[1, 5] = "O";
                }
            }
        }

        protected void Button66_Click(object sender, EventArgs e)
        {
            if (R == true)
            {
                if (Button66.BackColor == System.Drawing.Color.Silver)
                {
                    Button66.BackColor = System.Drawing.Color.Green;
                    Arreglo[2, 5] = "X";
                }
                else
                {
                    Button66.BackColor = System.Drawing.Color.Silver;
                    Arreglo[2, 5] = "O";
                }
            }
            else
                if (Button66.Enabled == true)
            {
                if (Button66.BackColor == System.Drawing.Color.Silver)
                {
                    Button66.BackColor = System.Drawing.Color.Red;
                    Arreglo[2, 5] = "V";
                }

                else
                {
                    Button66.BackColor = System.Drawing.Color.Silver;
                    Arreglo[2, 5] = "O";
                }
            }
        }

        protected void Button67_Click(object sender, EventArgs e)
        {
            if (R == true)
            {
                if (Button67.BackColor == System.Drawing.Color.Silver)
                {
                    Button67.BackColor = System.Drawing.Color.Green;
                    Arreglo[3, 5] = "X";
                }
                else
                {
                    Button67.BackColor = System.Drawing.Color.Silver;
                    Arreglo[3, 5] = "O";
                }
            }
            else
                if (Button67.Enabled == true)
            {
                if (Button67.BackColor == System.Drawing.Color.Silver)
                {
                    Button67.BackColor = System.Drawing.Color.Red;
                    Arreglo[3, 5] = "V";
                }

                else
                {
                    Button67.BackColor = System.Drawing.Color.Silver;
                    Arreglo[3, 5] = "O";
                }
            }
        }

        protected void Button68_Click(object sender, EventArgs e)
        {
            if (R == true)
            {
                if (Button68.BackColor == System.Drawing.Color.Silver)
                {
                    Button68.BackColor = System.Drawing.Color.Green;
                    Arreglo[4, 5] = "X";
                }
                else
                {
                    Button68.BackColor = System.Drawing.Color.Silver;
                    Arreglo[4, 5] = "O";
                }
            }
            else
                if (Button68.Enabled == true)
            {
                if (Button68.BackColor == System.Drawing.Color.Silver)
                {
                    Button68.BackColor = System.Drawing.Color.Red;
                    Arreglo[4, 5] = "V";
                }

                else
                {
                    Button68.BackColor = System.Drawing.Color.Silver;
                    Arreglo[4, 5] = "O";
                }
            }
        }

        protected void Button69_Click(object sender, EventArgs e)
        {
            if (R == true)
            {
                if (Button69.BackColor == System.Drawing.Color.Silver)
                {
                    Button69.BackColor = System.Drawing.Color.Green;
                    Arreglo[5, 5] = "X";
                }
                else
                {
                    Button69.BackColor = System.Drawing.Color.Silver;
                    Arreglo[5, 5] = "O";
                }
            }
            else
                if (Button69.Enabled == true)
            {
                if (Button69.BackColor == System.Drawing.Color.Silver)
                {
                    Button69.BackColor = System.Drawing.Color.Red;
                    Arreglo[5, 5] = "V";
                }

                else
                {
                    Button69.BackColor = System.Drawing.Color.Silver;
                    Arreglo[5, 5] = "O";
                }
            }
        }

        protected void Button70_Click(object sender, EventArgs e)
        {
            if (R == true)
            {
                if (Button70.BackColor == System.Drawing.Color.Silver)
                {
                    Button70.BackColor = System.Drawing.Color.Green;
                    Arreglo[6, 5] = "X";
                }
                else
                {
                    Button70.BackColor = System.Drawing.Color.Silver;
                    Arreglo[6, 5] = "O";
                }
            }
            else
                if (Button70.Enabled == true)
            {
                if (Button70.BackColor == System.Drawing.Color.Silver)
                {
                    Button70.BackColor = System.Drawing.Color.Red;
                    Arreglo[6, 5] = "V";
                }

                else
                {
                    Button70.BackColor = System.Drawing.Color.Silver;
                    Arreglo[6, 5] = "O";
                }
            }
        }

        protected void Button71_Click(object sender, EventArgs e)
        {
            if (R == true)
            {
                if (Button71.BackColor == System.Drawing.Color.Silver)
                {
                    Button71.BackColor = System.Drawing.Color.Green;
                    Arreglo[7, 5] = "X";
                }
                else
                {
                    Button71.BackColor = System.Drawing.Color.Silver;
                    Arreglo[7, 5] = "O";
                }
            }
            else
                if (Button71.Enabled == true)
            {
                if (Button71.BackColor == System.Drawing.Color.Silver)
                {
                    Button71.BackColor = System.Drawing.Color.Red;
                    Arreglo[7, 5] = "V";
                }

                else
                {
                    Button71.BackColor = System.Drawing.Color.Silver;
                    Arreglo[7, 5] = "O";
                }
            }
        }

        protected void Button72_Click(object sender, EventArgs e)
        {
            if (R == true)
            {
                if (Button72.BackColor == System.Drawing.Color.Silver)
                {
                    Button72.BackColor = System.Drawing.Color.Green;
                    Arreglo[8, 5] = "X";
                }
                else
                {
                    Button72.BackColor = System.Drawing.Color.Silver;
                    Arreglo[8, 5] = "O";
                }
            }
            else
                if (Button72.Enabled == true)
            {
                if (Button72.BackColor == System.Drawing.Color.Silver)
                {
                    Button72.BackColor = System.Drawing.Color.Red;
                    Arreglo[8, 5] = "V";
                }

                else
                {
                    Button72.BackColor = System.Drawing.Color.Silver;
                    Arreglo[8, 5] = "O";
                }
            }
        }

        protected void Button73_Click(object sender, EventArgs e)
        {
            if (R == true)
            {
                if (Button73.BackColor == System.Drawing.Color.Silver)
                {
                    Button73.BackColor = System.Drawing.Color.Green;
                    Arreglo[9, 5] = "X";
                }
                else
                {
                    Button73.BackColor = System.Drawing.Color.Silver;
                    Arreglo[9, 5] = "O";
                }
            }
            else
                if (Button73.Enabled == true)
            {
                if (Button73.BackColor == System.Drawing.Color.Silver)
                {
                    Button73.BackColor = System.Drawing.Color.Red;
                    Arreglo[9, 5] = "V";
                }

                else
                {
                    Button73.BackColor = System.Drawing.Color.Silver;
                    Arreglo[9, 5] = "O";
                }
            }
        }

        protected void Button74_Click(object sender, EventArgs e)
        {
            if (R == true)
            {
                if (Button74.BackColor == System.Drawing.Color.Silver)
                {
                    Button74.BackColor = System.Drawing.Color.Green;
                    Arreglo[10, 5] = "X";
                }
                else
                {
                    Button74.BackColor = System.Drawing.Color.Silver;
                    Arreglo[10, 5] = "O";
                }
            }
            else
                if (Button74.Enabled == true)
            {
                if (Button74.BackColor == System.Drawing.Color.Silver)
                {
                    Button74.BackColor = System.Drawing.Color.Red;
                    Arreglo[10, 5] = "V";
                }

                else
                {
                    Button74.BackColor = System.Drawing.Color.Silver;
                    Arreglo[10, 5] = "O";
                }
            }
        }

        protected void Button75_Click(object sender, EventArgs e)
        {
            if (R == true)
            {
                if (Button75.BackColor == System.Drawing.Color.Silver)
                {
                    Button75.BackColor = System.Drawing.Color.Green;
                    Arreglo[11, 5] = "X";
                }
                else
                {
                    Button75.BackColor = System.Drawing.Color.Silver;
                    Arreglo[11, 5] = "O";
                }
            }
            else
                if (Button75.Enabled == true)
            {
                if (Button75.BackColor == System.Drawing.Color.Silver)
                {
                    Button75.BackColor = System.Drawing.Color.Red;
                    Arreglo[11, 5] = "V";
                }

                else
                {
                    Button75.BackColor = System.Drawing.Color.Silver;
                    Arreglo[11, 5] = "O";
                }
            }
        }

        protected void Button76_Click(object sender, EventArgs e)
        {
            if (R == true)
            {
                if (Button76.BackColor == System.Drawing.Color.Silver)
                {
                    Button76.BackColor = System.Drawing.Color.Green;
                    Arreglo[12, 5] = "X";
                }
                else
                {
                    Button76.BackColor = System.Drawing.Color.Silver;
                    Arreglo[12, 5] = "O";
                }
            }
            else
                if (Button76.Enabled == true)
            {
                if (Button76.BackColor == System.Drawing.Color.Silver)
                {
                    Button76.BackColor = System.Drawing.Color.Red;
                    Arreglo[12, 5] = "V";
                }

                else
                {
                    Button76.BackColor = System.Drawing.Color.Silver;
                    Arreglo[12, 5] = "O";
                }
            }
        }

        protected void Button77_Click(object sender, EventArgs e)
        {
            if (R == true)
            {
                if (Button77.BackColor == System.Drawing.Color.Silver)
                {
                    Button77.BackColor = System.Drawing.Color.Green;
                    Arreglo[13, 5] = "X";
                }
                else
                {
                    Button77.BackColor = System.Drawing.Color.Silver;
                    Arreglo[13, 5] = "O";
                }
            }
            else
                if (Button77.Enabled == true)
            {
                if (Button77.BackColor == System.Drawing.Color.Silver)
                {
                    Button77.BackColor = System.Drawing.Color.Red;
                    Arreglo[13, 5] = "V";
                }

                else
                {
                    Button77.BackColor = System.Drawing.Color.Silver;
                    Arreglo[13, 5] = "O";
                }
            }
        }

        protected void Button78_Click(object sender, EventArgs e)
        {
            if (R == true)
            {
                if (Button78.BackColor == System.Drawing.Color.Silver)
                {
                    Button78.BackColor = System.Drawing.Color.Green;
                    Arreglo[14, 5] = "X";
                }
                else
                {
                    Button78.BackColor = System.Drawing.Color.Silver;
                    Arreglo[14, 5] = "O";
                }
            }
            else
                if (Button78.Enabled == true)
            {
                if (Button78.BackColor == System.Drawing.Color.Silver)
                {
                    Button78.BackColor = System.Drawing.Color.Red;
                    Arreglo[14, 5] = "V";
                }

                else
                {
                    Button78.BackColor = System.Drawing.Color.Silver;
                    Arreglo[14, 5] = "O";
                }
            }
        }

        protected void Button79_Click(object sender, EventArgs e)
        {
            if (R == true)
            {
                if (Button79.BackColor == System.Drawing.Color.Silver)
                {
                    Button79.BackColor = System.Drawing.Color.Green;
                    Arreglo[15, 5] = "X";
                }
                else
                {
                    Button79.BackColor = System.Drawing.Color.Silver;
                    Arreglo[15, 5] = "O";
                }
            }
            else
                if (Button79.Enabled == true)
            {
                if (Button79.BackColor == System.Drawing.Color.Silver)
                {
                    Button79.BackColor = System.Drawing.Color.Red;
                    Arreglo[15, 5] = "V";
                }

                else
                {
                    Button79.BackColor = System.Drawing.Color.Silver;
                    Arreglo[15, 5] = "O";
                }
            }
        }

        protected void Button80_Click(object sender, EventArgs e)
        {
            if (R == true)
            {
                if (Button80.BackColor == System.Drawing.Color.Silver)
                {
                    Button80.BackColor = System.Drawing.Color.Green;
                    Arreglo[16, 5] = "X";
                }
                else
                {
                    Button80.BackColor = System.Drawing.Color.Silver;
                    Arreglo[16, 5] = "O";
                }
            }
            else
                if (Button80.Enabled == true)
            {
                if (Button80.BackColor == System.Drawing.Color.Silver)
                {
                    Button80.BackColor = System.Drawing.Color.Red;
                    Arreglo[16, 5] = "V";
                }

                else
                {
                    Button80.BackColor = System.Drawing.Color.Silver;
                    Arreglo[16, 5] = "O";
                }
            }
        }

        protected void Button81_Click(object sender, EventArgs e)
        {
            if (R == true)
            {
                if (Button81.BackColor == System.Drawing.Color.Silver)
                {
                    Button81.BackColor = System.Drawing.Color.Green;
                    Arreglo[1, 6] = "X";
                }
                else
                {
                    Button81.BackColor = System.Drawing.Color.Silver;
                    Arreglo[1, 6] = "O";
                }
            }
            else
                if (Button81.Enabled == true)
            {
                if (Button81.BackColor == System.Drawing.Color.Silver)
                {
                    Button81.BackColor = System.Drawing.Color.Red;
                    Arreglo[1, 6] = "V";
                }

                else
                {
                    Button81.BackColor = System.Drawing.Color.Silver;
                    Arreglo[1, 6] = "O";
                }
            }
        }

        protected void Button82_Click(object sender, EventArgs e)
        {
            if (R == true)
            {
                if (Button82.BackColor == System.Drawing.Color.Silver)
                {
                    Button82.BackColor = System.Drawing.Color.Green;
                    Arreglo[2, 6] = "X";
                }
                else
                {
                    Button82.BackColor = System.Drawing.Color.Silver;
                    Arreglo[2, 6] = "O";
                }
            }
            else
                if (Button82.Enabled == true)
            {
                if (Button82.BackColor == System.Drawing.Color.Silver)
                {
                    Button82.BackColor = System.Drawing.Color.Red;
                    Arreglo[2, 6] = "V";
                }

                else
                {
                    Button82.BackColor = System.Drawing.Color.Silver;
                    Arreglo[2, 6] = "O";
                }
            }
        }

        protected void Button83_Click(object sender, EventArgs e)
        {
            if (R == true)
            {
                if (Button83.BackColor == System.Drawing.Color.Silver)
                {
                    Button83.BackColor = System.Drawing.Color.Green;
                    Arreglo[3, 6] = "X";
                }
                else
                {
                    Button83.BackColor = System.Drawing.Color.Silver;
                    Arreglo[3, 6] = "O";
                }
            }
            else
                if (Button83.Enabled == true)
            {
                if (Button83.BackColor == System.Drawing.Color.Silver)
                {
                    Button83.BackColor = System.Drawing.Color.Red;
                    Arreglo[3, 6] = "V";
                }

                else
                {
                    Button83.BackColor = System.Drawing.Color.Silver;
                    Arreglo[3, 6] = "O";
                }
            }
        }

        protected void Button84_Click(object sender, EventArgs e)
        {
            if (R == true)
            {
                if (Button84.BackColor == System.Drawing.Color.Silver)
                {
                    Button84.BackColor = System.Drawing.Color.Green;
                    Arreglo[4, 6] = "X";
                }
                else
                {
                    Button84.BackColor = System.Drawing.Color.Silver;
                    Arreglo[4, 6] = "O";
                }
            }
            else
                if (Button84.Enabled == true)
            {
                if (Button84.BackColor == System.Drawing.Color.Silver)
                {
                    Button84.BackColor = System.Drawing.Color.Red;
                    Arreglo[4, 6] = "V";
                }

                else
                {
                    Button84.BackColor = System.Drawing.Color.Silver;
                    Arreglo[4, 6] = "O";
                }
            }
        }

        protected void Button85_Click(object sender, EventArgs e)
        {
            if (R == true)
            {
                if (Button85.BackColor == System.Drawing.Color.Silver)
                {
                    Button85.BackColor = System.Drawing.Color.Green;
                    Arreglo[5, 6] = "X";
                }
                else
                {
                    Button85.BackColor = System.Drawing.Color.Silver;
                    Arreglo[5, 6] = "O";
                }
            }
            else
                if (Button85.Enabled == true)
            {
                if (Button85.BackColor == System.Drawing.Color.Silver)
                {
                    Button85.BackColor = System.Drawing.Color.Red;
                    Arreglo[5, 6] = "V";
                }

                else
                {
                    Button85.BackColor = System.Drawing.Color.Silver;
                    Arreglo[5, 6] = "O";
                }
            }
        }

        protected void Button86_Click(object sender, EventArgs e)
        {
            if (R == true)
            {
                if (Button86.BackColor == System.Drawing.Color.Silver)
                {
                    Button86.BackColor = System.Drawing.Color.Green;
                    Arreglo[6, 6] = "X";
                }
                else
                {
                    Button86.BackColor = System.Drawing.Color.Silver;
                    Arreglo[6, 6] = "O";
                }
            }
            else
                if (Button86.Enabled == true)
            {
                if (Button86.BackColor == System.Drawing.Color.Silver)
                {
                    Button86.BackColor = System.Drawing.Color.Red;
                    Arreglo[6, 6] = "V";
                }

                else
                {
                    Button86.BackColor = System.Drawing.Color.Silver;
                    Arreglo[6, 6] = "O";
                }
            }
        }

        protected void Button87_Click(object sender, EventArgs e)
        {
            if (R == true)
            {
                if (Button87.BackColor == System.Drawing.Color.Silver)
                {
                    Button87.BackColor = System.Drawing.Color.Green;
                    Arreglo[7, 6] = "X";
                }
                else
                {
                    Button87.BackColor = System.Drawing.Color.Silver;
                    Arreglo[7, 6] = "O";
                }
            }
            else
                if (Button87.Enabled == true)
            {
                if (Button87.BackColor == System.Drawing.Color.Silver)
                {
                    Button87.BackColor = System.Drawing.Color.Red;
                    Arreglo[7, 6] = "V";
                }

                else
                {
                    Button87.BackColor = System.Drawing.Color.Silver;
                    Arreglo[7, 6] = "O";
                }
            }
        }

        protected void Button88_Click(object sender, EventArgs e)
        {
            if (R == true)
            {
                if (Button88.BackColor == System.Drawing.Color.Silver)
                {
                    Button88.BackColor = System.Drawing.Color.Green;
                    Arreglo[8, 6] = "X";
                }
                else
                {
                    Button88.BackColor = System.Drawing.Color.Silver;
                    Arreglo[8, 6] = "O";
                }
            }
            else
                if (Button88.Enabled == true)
            {
                if (Button88.BackColor == System.Drawing.Color.Silver)
                {
                    Button88.BackColor = System.Drawing.Color.Red;
                    Arreglo[8, 6] = "V";
                }

                else
                {
                    Button88.BackColor = System.Drawing.Color.Silver;
                    Arreglo[8, 6] = "O";
                }
            }
        }

        protected void Button89_Click(object sender, EventArgs e)
        {
            if (R == true)
            {
                if (Button89.BackColor == System.Drawing.Color.Silver)
                {
                    Button89.BackColor = System.Drawing.Color.Green;
                    Arreglo[9, 6] = "X";
                }
                else
                {
                    Button89.BackColor = System.Drawing.Color.Silver;
                    Arreglo[9, 6] = "O";
                }
            }
            else
                if (Button89.Enabled == true)
            {
                if (Button89.BackColor == System.Drawing.Color.Silver)
                {
                    Button89.BackColor = System.Drawing.Color.Red;
                    Arreglo[9, 6] = "V";
                }

                else
                {
                    Button89.BackColor = System.Drawing.Color.Silver;
                    Arreglo[9, 6] = "O";
                }
            }
        }

        protected void Button90_Click(object sender, EventArgs e)
        {
            if (R == true)
            {
                if (Button90.BackColor == System.Drawing.Color.Silver)
                {
                    Button90.BackColor = System.Drawing.Color.Green;
                    Arreglo[10, 6] = "X";
                }
                else
                {
                    Button90.BackColor = System.Drawing.Color.Silver;
                    Arreglo[10, 6] = "O";
                }
            }
            else
                if (Button90.Enabled == true)
            {
                if (Button90.BackColor == System.Drawing.Color.Silver)
                {
                    Button90.BackColor = System.Drawing.Color.Red;
                    Arreglo[10, 6] = "V";
                }

                else
                {
                    Button90.BackColor = System.Drawing.Color.Silver;
                    Arreglo[10, 6] = "O";
                }
            }
        }

        protected void Button91_Click(object sender, EventArgs e)
        {
            if (R == true)
            {
                if (Button91.BackColor == System.Drawing.Color.Silver)
                {
                    Button91.BackColor = System.Drawing.Color.Green;
                    Arreglo[11, 6] = "X";
                }
                else
                {
                    Button91.BackColor = System.Drawing.Color.Silver;
                    Arreglo[11, 6] = "O";
                }
            }
            else
                if (Button91.Enabled == true)
            {
                if (Button91.BackColor == System.Drawing.Color.Silver)
                {
                    Button91.BackColor = System.Drawing.Color.Red;
                    Arreglo[11, 6] = "V";
                }

                else
                {
                    Button91.BackColor = System.Drawing.Color.Silver;
                    Arreglo[11, 6] = "O";
                }
            }
        }

        protected void Button92_Click(object sender, EventArgs e)
        {
            if (R == true)
            {
                if (Button92.BackColor == System.Drawing.Color.Silver)
                {
                    Button92.BackColor = System.Drawing.Color.Green;
                    Arreglo[12, 6] = "X";
                }
                else
                {
                    Button92.BackColor = System.Drawing.Color.Silver;
                    Arreglo[12, 6] = "O";
                }
            }
            else
                if (Button92.Enabled == true)
            {
                if (Button92.BackColor == System.Drawing.Color.Silver)
                {
                    Button92.BackColor = System.Drawing.Color.Red;
                    Arreglo[12, 6] = "V";
                }

                else
                {
                    Button92.BackColor = System.Drawing.Color.Silver;
                    Arreglo[12, 6] = "O";
                }
            }
        }

        protected void Button93_Click(object sender, EventArgs e)
        {
            if (R == true)
            {
                if (Button93.BackColor == System.Drawing.Color.Silver)
                {
                    Button93.BackColor = System.Drawing.Color.Green;
                    Arreglo[13, 6] = "X";
                }
                else
                {
                    Button93.BackColor = System.Drawing.Color.Silver;
                    Arreglo[13, 6] = "O";
                }
            }
            else
                if (Button93.Enabled == true)
            {
                if (Button93.BackColor == System.Drawing.Color.Silver)
                {
                    Button93.BackColor = System.Drawing.Color.Red;
                    Arreglo[13, 6] = "V";
                }

                else
                {
                    Button93.BackColor = System.Drawing.Color.Silver;
                    Arreglo[13, 6] = "O";
                }
            }
        }

        protected void Button94_Click(object sender, EventArgs e)
        {
            if (R == true)
            {
                if (Button94.BackColor == System.Drawing.Color.Silver)
                {
                    Button94.BackColor = System.Drawing.Color.Green;
                    Arreglo[14, 6] = "X";
                }
                else
                {
                    Button94.BackColor = System.Drawing.Color.Silver;
                    Arreglo[14, 6] = "O";
                }
            }
            else
                if (Button94.Enabled == true)
            {
                if (Button94.BackColor == System.Drawing.Color.Silver)
                {
                    Button94.BackColor = System.Drawing.Color.Red;
                    Arreglo[14, 6] = "V";
                }

                else
                {
                    Button94.BackColor = System.Drawing.Color.Silver;
                    Arreglo[14, 6] = "O";
                }
            }
        }

        protected void Button95_Click(object sender, EventArgs e)
        {
            if (R == true)
            {
                if (Button95.BackColor == System.Drawing.Color.Silver)
                {
                    Button95.BackColor = System.Drawing.Color.Green;
                    Arreglo[15, 6] = "X";
                }
                else
                {
                    Button95.BackColor = System.Drawing.Color.Silver;
                    Arreglo[15, 6] = "O";
                }
            }
            else
                if (Button95.Enabled == true)
            {
                if (Button95.BackColor == System.Drawing.Color.Silver)
                {
                    Button95.BackColor = System.Drawing.Color.Red;
                    Arreglo[15, 6] = "V";
                }

                else
                {
                    Button95.BackColor = System.Drawing.Color.Silver;
                    Arreglo[15, 6] = "O";
                }
            }
        }

        protected void Button96_Click(object sender, EventArgs e)
        {
            if (R == true)
            {
                if (Button96.BackColor == System.Drawing.Color.Silver)
                {
                    Button96.BackColor = System.Drawing.Color.Green;
                    Arreglo[16, 6] = "X";
                }
                else
                {
                    Button96.BackColor = System.Drawing.Color.Silver;
                    Arreglo[16, 6] = "O";
                }
            }
            else
                if (Button96.Enabled == true)
            {
                if (Button96.BackColor == System.Drawing.Color.Silver)
                {
                    Button96.BackColor = System.Drawing.Color.Red;
                    Arreglo[16, 6] = "V";
                }

                else
                {
                    Button96.BackColor = System.Drawing.Color.Silver;
                    Arreglo[16, 6] = "O";
                }
            }
        }
#endregion

        protected void Button97_Click(object sender, EventArgs e)
        {
            R = false;
            if (Button1.BackColor == System.Drawing.Color.Green)
                Button1.Enabled = false;
            if (Button2.BackColor == System.Drawing.Color.Green)
                Button2.Enabled = false;
            if (Button3.BackColor == System.Drawing.Color.Green)
                Button3.Enabled = false;
            if (Button4.BackColor == System.Drawing.Color.Green)
                Button4.Enabled = false;
            if (Button5.BackColor == System.Drawing.Color.Green)
                Button5.Enabled = false;
            if (Button6.BackColor == System.Drawing.Color.Green)
                Button6.Enabled = false;
            if (Button7.BackColor == System.Drawing.Color.Green)
                Button7.Enabled = false;
            if (Button8.BackColor == System.Drawing.Color.Green)
                Button8.Enabled = false;
            if (Button9.BackColor == System.Drawing.Color.Green)
                Button9.Enabled = false;
            if (Button10.BackColor == System.Drawing.Color.Green)
                Button10.Enabled = false;
            if (Button11.BackColor == System.Drawing.Color.Green)
                Button11.Enabled = false;
            if (Button12.BackColor == System.Drawing.Color.Green)
                Button12.Enabled = false;
            if (Button13.BackColor == System.Drawing.Color.Green)
                Button13.Enabled = false;
            if (Button14.BackColor == System.Drawing.Color.Green)
                Button14.Enabled = false;
            if (Button15.BackColor == System.Drawing.Color.Green)
                Button15.Enabled = false;
            if (Button16.BackColor == System.Drawing.Color.Green)
                Button16.Enabled = false;
            if (Button17.BackColor == System.Drawing.Color.Green)
                Button17.Enabled = false;
            if (Button18.BackColor == System.Drawing.Color.Green)
                Button18.Enabled = false;
            if (Button19.BackColor == System.Drawing.Color.Green)
                Button19.Enabled = false;
            if (Button20.BackColor == System.Drawing.Color.Green)
                Button20.Enabled = false;
            if (Button21.BackColor == System.Drawing.Color.Green)
                Button21.Enabled = false;
            if (Button22.BackColor == System.Drawing.Color.Green)
                Button22.Enabled = false;
            if (Button23.BackColor == System.Drawing.Color.Green)
                Button23.Enabled = false;
            if (Button24.BackColor == System.Drawing.Color.Green)
                Button24.Enabled = false;
            if (Button25.BackColor == System.Drawing.Color.Green)
                Button25.Enabled = false;
            if (Button26.BackColor == System.Drawing.Color.Green)
                Button26.Enabled = false;
            if (Button27.BackColor == System.Drawing.Color.Green)
                Button27.Enabled = false;
            if (Button28.BackColor == System.Drawing.Color.Green)
                Button28.Enabled = false;
            if (Button29.BackColor == System.Drawing.Color.Green)
                Button29.Enabled = false;
            if (Button30.BackColor == System.Drawing.Color.Green)
                Button30.Enabled = false;
            if (Button31.BackColor == System.Drawing.Color.Green)
                Button31.Enabled = false;
            if (Button32.BackColor == System.Drawing.Color.Green)
                Button32.Enabled = false;
            if (Button33.BackColor == System.Drawing.Color.Green)
                Button33.Enabled = false;
            if (Button34.BackColor == System.Drawing.Color.Green)
                Button34.Enabled = false;
            if (Button35.BackColor == System.Drawing.Color.Green)
                Button35.Enabled = false;
            if (Button36.BackColor == System.Drawing.Color.Green)
                Button36.Enabled = false;
            if (Button37.BackColor == System.Drawing.Color.Green)
                Button37.Enabled = false;
            if (Button38.BackColor == System.Drawing.Color.Green)
                Button38.Enabled = false;
            if (Button39.BackColor == System.Drawing.Color.Green)
                Button39.Enabled = false;
            if (Button40.BackColor == System.Drawing.Color.Green)
                Button40.Enabled = false;
            if (Button41.BackColor == System.Drawing.Color.Green)
                Button41.Enabled = false;
            if (Button42.BackColor == System.Drawing.Color.Green)
                Button42.Enabled = false;
            if (Button43.BackColor == System.Drawing.Color.Green)
                Button43.Enabled = false;
            if (Button44.BackColor == System.Drawing.Color.Green)
                Button44.Enabled = false;
            if (Button45.BackColor == System.Drawing.Color.Green)
                Button45.Enabled = false;
            if (Button46.BackColor == System.Drawing.Color.Green)
                Button46.Enabled = false;
            if (Button47.BackColor == System.Drawing.Color.Green)
                Button47.Enabled = false;
            if (Button48.BackColor == System.Drawing.Color.Green)
                Button48.Enabled = false;
            if (Button49.BackColor == System.Drawing.Color.Green)
                Button49.Enabled = false;
            if (Button50.BackColor == System.Drawing.Color.Green)
                Button50.Enabled = false;
            if (Button51.BackColor == System.Drawing.Color.Green)
                Button51.Enabled = false;
            if (Button52.BackColor == System.Drawing.Color.Green)
                Button52.Enabled = false;
            if (Button53.BackColor == System.Drawing.Color.Green)
                Button53.Enabled = false;
            if (Button54.BackColor == System.Drawing.Color.Green)
                Button54.Enabled = false;
            if (Button55.BackColor == System.Drawing.Color.Green)
                Button55.Enabled = false;
            if (Button56.BackColor == System.Drawing.Color.Green)
                Button56.Enabled = false;
            if (Button57.BackColor == System.Drawing.Color.Green)
                Button57.Enabled = false;
            if (Button58.BackColor == System.Drawing.Color.Green)
                Button58.Enabled = false;
            if (Button59.BackColor == System.Drawing.Color.Green)
                Button59.Enabled = false;
            if (Button60.BackColor == System.Drawing.Color.Green)
                Button60.Enabled = false;
            if (Button61.BackColor == System.Drawing.Color.Green)
                Button61.Enabled = false;
            if (Button62.BackColor == System.Drawing.Color.Green)
                Button62.Enabled = false;
            if (Button63.BackColor == System.Drawing.Color.Green)
                Button63.Enabled = false;
            if (Button64.BackColor == System.Drawing.Color.Green)
                Button64.Enabled = false;
            if (Button65.BackColor == System.Drawing.Color.Green)
                Button65.Enabled = false;
            if (Button66.BackColor == System.Drawing.Color.Green)
                Button66.Enabled = false;
            if (Button67.BackColor == System.Drawing.Color.Green)
                Button67.Enabled = false;
            if (Button68.BackColor == System.Drawing.Color.Green)
                Button68.Enabled = false;
            if (Button69.BackColor == System.Drawing.Color.Green)
                Button69.Enabled = false;
            if (Button70.BackColor == System.Drawing.Color.Green)
                Button70.Enabled = false;
            if (Button71.BackColor == System.Drawing.Color.Green)
                Button71.Enabled = false;
            if (Button72.BackColor == System.Drawing.Color.Green)
                Button72.Enabled = false;
            if (Button73.BackColor == System.Drawing.Color.Green)
                Button73.Enabled = false;
            if (Button74.BackColor == System.Drawing.Color.Green)
                Button74.Enabled = false;
            if (Button75.BackColor == System.Drawing.Color.Green)
                Button75.Enabled = false;
            if (Button76.BackColor == System.Drawing.Color.Green)
                Button76.Enabled = false;
            if (Button77.BackColor == System.Drawing.Color.Green)
                Button77.Enabled = false;
            if (Button78.BackColor == System.Drawing.Color.Green)
                Button78.Enabled = false;
            if (Button79.BackColor == System.Drawing.Color.Green)
                Button79.Enabled = false;
            if (Button80.BackColor == System.Drawing.Color.Green)
                Button80.Enabled = false;
            if (Button81.BackColor == System.Drawing.Color.Green)
                Button81.Enabled = false;
            if (Button82.BackColor == System.Drawing.Color.Green)
                Button82.Enabled = false;
            if (Button83.BackColor == System.Drawing.Color.Green)
                Button83.Enabled = false;
            if (Button84.BackColor == System.Drawing.Color.Green)
                Button84.Enabled = false;
            if (Button85.BackColor == System.Drawing.Color.Green)
                Button85.Enabled = false;
            if (Button86.BackColor == System.Drawing.Color.Green)
                Button86.Enabled = false;
            if (Button87.BackColor == System.Drawing.Color.Green)
                Button87.Enabled = false;
            if (Button88.BackColor == System.Drawing.Color.Green)
                Button88.Enabled = false;
            if (Button89.BackColor == System.Drawing.Color.Green)
                Button89.Enabled = false;
            if (Button90.BackColor == System.Drawing.Color.Green)
                Button90.Enabled = false;
            if (Button91.BackColor == System.Drawing.Color.Green)
                Button91.Enabled = false;
            if (Button92.BackColor == System.Drawing.Color.Green)
                Button92.Enabled = false;
            if (Button93.BackColor == System.Drawing.Color.Green)
                Button93.Enabled = false;
            if (Button94.BackColor == System.Drawing.Color.Green)
                Button94.Enabled = false;
            if (Button95.BackColor == System.Drawing.Color.Green)
                Button95.Enabled = false;
            if (Button96.BackColor == System.Drawing.Color.Green)
                Button96.Enabled = false;


            Button97.Visible = false;
            Button99.Visible = true;

        }

        

        protected void Button98_Click(object sender, EventArgs e)
        {
            R=true;
            Response.Redirect("~/Menu.aspx");
        }

        protected void Button99_Click(object sender, EventArgs e)
        {
            HorarioPBD horario = new HorarioPBD();
            horario.Profesor = int.Parse(Session["Usuario"].ToString());
            for (int i = 1; i < 17; i++)
            {
                for (int j = 1; j < 7; j++)
                {
                    if (Arreglo[i, j] != "O")
                    {
                        if (Arreglo[i, j] == "X")
                        {
                            horario.Dia = Arreglo[0, j];
                            horario.Hora = Arreglo[i, 0];
                            horario.modalidad = 1;
                            horario.Comprobacion();
                        }
                        if (Arreglo[i, j] == "V")
                        {
                            horario.Dia = Arreglo[0, j];
                            horario.Hora = Arreglo[i, 0];
                            horario.modalidad = 2;
                            horario.Comprobacion();
                        }
                    }
                }
            }

         


            
        }
    }
}