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
    public partial class Triqui4x4 : Form
    {

        Boolean checker;
        int sumarUno;
        int contadorDeBotones;

        public Triqui4x4()
        {
            InitializeComponent();
        }

        void disponibleFalse()
        {
            btn1.Enabled = false;
            btn2.Enabled = false;
            btn3.Enabled = false;
            btn4.Enabled = false;
            btn5.Enabled = false;
            btn6.Enabled = false;
            btn7.Enabled = false;
            btn8.Enabled = false;
            btn9.Enabled = false;
            btn10.Enabled = false;
            btn11.Enabled = false;
            btn12.Enabled = false;
            btn13.Enabled = false;
            btn14.Enabled = false;
            btn15.Enabled = false;
            btn16.Enabled = false;
        }

        void scoreTriqui4x4()
        {

            //===========================================================================================================
            //                                      EQUIPO "X"
            //===========================================================================================================


            if (btn1.Text == "X" && btn2.Text == "X" && btn3.Text == "X")
            {
                btn1.BackColor = Color.Crimson;
                btn2.BackColor = Color.Crimson;
                btn3.BackColor = Color.Crimson;

                MessageBox.Show("El equipo X es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoX.Text) + 1;
                lblEquipoX.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }



            // FIN PRUEBA

            else if (btn4.Text == "X" && btn2.Text == "X" && btn3.Text == "X")
            {
                btn4.BackColor = Color.Crimson;
                btn2.BackColor = Color.Crimson;
                btn3.BackColor = Color.Crimson;

                MessageBox.Show("El equipo X es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoX.Text) + 1;
                lblEquipoX.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn5.Text == "X" && btn6.Text == "X" && btn7.Text == "X")
            {
                btn5.BackColor = Color.Crimson;
                btn6.BackColor = Color.Crimson;
                btn7.BackColor = Color.Crimson;

                MessageBox.Show("El equipo X es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoX.Text) + 1;
                lblEquipoX.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn8.Text == "X" && btn6.Text == "X" && btn7.Text == "X")
            {
                btn8.BackColor = Color.Crimson;
                btn6.BackColor = Color.Crimson;
                btn7.BackColor = Color.Crimson;

                MessageBox.Show("El equipo X es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoX.Text) + 1;
                lblEquipoX.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn9.Text == "X" && btn10.Text == "X" && btn11.Text == "X")
            {
                btn9.BackColor = Color.Crimson;
                btn10.BackColor = Color.Crimson;
                btn11.BackColor = Color.Crimson;

                MessageBox.Show("El equipo X es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoX.Text) + 1;
                lblEquipoX.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn12.Text == "X" && btn10.Text == "X" && btn11.Text == "X")
            {
                btn10.BackColor = Color.Crimson;
                btn11.BackColor = Color.Crimson;
                btn12.BackColor = Color.Crimson;

                MessageBox.Show("El equipo X es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoX.Text) + 1;
                lblEquipoX.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn13.Text == "X" && btn14.Text == "X" && btn15.Text == "X")
            {
                btn13.BackColor = Color.Crimson;
                btn14.BackColor = Color.Crimson;
                btn15.BackColor = Color.Crimson;

                MessageBox.Show("El equipo X es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoX.Text) + 1;
                lblEquipoX.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn16.Text == "X" && btn14.Text == "X" && btn15.Text == "X")
            {
                btn16.BackColor = Color.Crimson;
                btn14.BackColor = Color.Crimson;
                btn15.BackColor = Color.Crimson;

                MessageBox.Show("El equipo X es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoX.Text) + 1;
                lblEquipoX.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }

            else if (btn1.Text == "X" && btn5.Text == "X" && btn9.Text == "X")
            {
                btn1.BackColor = Color.Crimson;
                btn9.BackColor = Color.Crimson;
                btn5.BackColor = Color.Crimson;

                MessageBox.Show("El equipo X es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoX.Text) + 1;
                lblEquipoX.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn13.Text == "X" && btn5.Text == "X" && btn9.Text == "X")
            {
                btn13.BackColor = Color.Crimson;
                btn9.BackColor = Color.Crimson;
                btn5.BackColor = Color.Crimson;

                MessageBox.Show("El equipo X es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoX.Text) + 1;
                lblEquipoX.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn2.Text == "X" && btn6.Text == "X" && btn10.Text == "X")
            {
                btn2.BackColor = Color.Crimson;
                btn6.BackColor = Color.Crimson;
                btn10.BackColor = Color.Crimson;

                MessageBox.Show("El equipo X es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoX.Text) + 1;
                lblEquipoX.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn14.Text == "X" && btn6.Text == "X" && btn10.Text == "X")
            {
                btn14.BackColor = Color.Crimson;
                btn6.BackColor = Color.Crimson;
                btn10.BackColor = Color.Crimson;

                MessageBox.Show("El equipo X es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoX.Text) + 1;
                lblEquipoX.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }

            else if (btn3.Text == "X" && btn7.Text == "X" && btn11.Text == "X")
            {
                btn3.BackColor = Color.Crimson;
                btn7.BackColor = Color.Crimson;
                btn11.BackColor = Color.Crimson;

                MessageBox.Show("El equipo X es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoX.Text) + 1;
                lblEquipoX.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn15.Text == "X" && btn7.Text == "X" && btn11.Text == "X")
            {
                btn3.BackColor = Color.Crimson;
                btn7.BackColor = Color.Crimson;
                btn15.BackColor = Color.Crimson;

                MessageBox.Show("El equipo X es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoX.Text) + 1;
                lblEquipoX.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }

            else if (btn4.Text == "X" && btn8.Text == "X" && btn12.Text == "X")
            {
                btn4.BackColor = Color.Crimson;
                btn8.BackColor = Color.Crimson;
                btn12.BackColor = Color.Crimson;

                MessageBox.Show("El equipo X es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoX.Text) + 1;
                lblEquipoX.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }

            else if (btn16.Text == "X" && btn8.Text == "X" && btn12.Text == "X")
            {
                btn16.BackColor = Color.Crimson;
                btn8.BackColor = Color.Crimson;
                btn12.BackColor = Color.Crimson;

                MessageBox.Show("El equipo X es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoX.Text) + 1;
                lblEquipoX.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }


            else if (btn2.Text == "X" && btn7.Text == "X" && btn12.Text == "X")
            {
                btn2.BackColor = Color.Crimson;
                btn7.BackColor = Color.Crimson;
                btn12.BackColor = Color.Crimson;

                MessageBox.Show("El equipo X es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoX.Text) + 1;
                lblEquipoX.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn1.Text == "X" && btn6.Text == "X" && btn11.Text == "X")
            {
                btn1.BackColor = Color.Crimson;
                btn6.BackColor = Color.Crimson;
                btn11.BackColor = Color.Crimson;

                MessageBox.Show("El equipo X es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoX.Text) + 1;
                lblEquipoX.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn16.Text == "X" && btn6.Text == "X" && btn11.Text == "X")
            {
                btn16.BackColor = Color.Crimson;
                btn6.BackColor = Color.Crimson;
                btn11.BackColor = Color.Crimson;

                MessageBox.Show("El equipo X es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoX.Text) + 1;
                lblEquipoX.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn5.Text == "X" && btn10.Text == "X" && btn15.Text == "X")
            {
                btn5.BackColor = Color.Crimson;
                btn10.BackColor = Color.Crimson;
                btn15.BackColor = Color.Crimson;

                MessageBox.Show("El equipo X es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoX.Text) + 1;
                lblEquipoX.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn3.Text == "X" && btn6.Text == "X" && btn9.Text == "O")
            {
                btn3.BackColor = Color.Crimson;
                btn6.BackColor = Color.Crimson;
                btn9.BackColor = Color.Crimson;

                MessageBox.Show("El equipo X es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoX.Text) + 1;
                lblEquipoX.Text = Convert.ToString(sumarUno);
                disponibleFalse();
            }

            else if (btn4.Text == "X" && btn7.Text == "X" && btn10.Text == "X")
            {
                btn4.BackColor = Color.Crimson;
                btn7.BackColor = Color.Crimson;
                btn10.BackColor = Color.Crimson;

                MessageBox.Show("El equipo X es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoX.Text) + 1;
                lblEquipoX.Text = Convert.ToString(sumarUno);
                disponibleFalse();
            }

            else if (btn13.Text == "X" && btn7.Text == "X" && btn10.Text == "X")
            {
                btn13.BackColor = Color.Crimson;
                btn7.BackColor = Color.Crimson;
                btn10.BackColor = Color.Crimson;

                MessageBox.Show("El equipo X es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoX.Text) + 1;
                lblEquipoX.Text = Convert.ToString(sumarUno);
                disponibleFalse();
            }
            else if (btn8.Text == "X" && btn11.Text == "X" && btn14.Text == "X")
            {
                btn8.BackColor = Color.Crimson;
                btn11.BackColor = Color.Crimson;
                btn14.BackColor = Color.Crimson;

                MessageBox.Show("El equipo X es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoX.Text) + 1;
                lblEquipoX.Text = Convert.ToString(sumarUno);
                disponibleFalse();
            }

            //===========================================================================================================
            //                                      EQUIPO "O"
            //===========================================================================================================


            if (btn1.Text == "O" && btn2.Text == "O" && btn3.Text == "O")
            {
                btn1.BackColor = Color.Crimson;
                btn2.BackColor = Color.Crimson;
                btn3.BackColor = Color.Crimson;

                MessageBox.Show("El equipo O es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoX.Text) + 1;
                lblEquipoX.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }

            else if (btn4.Text == "O" && btn2.Text == "O" && btn3.Text == "O")
            {
                btn4.BackColor = Color.Crimson;
                btn2.BackColor = Color.Crimson;
                btn3.BackColor = Color.Crimson;

                MessageBox.Show("El equipo X es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoX.Text) + 1;
                lblEquipoX.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn5.Text == "O" && btn6.Text == "O" && btn7.Text == "O")
            {
                btn5.BackColor = Color.Crimson;
                btn6.BackColor = Color.Crimson;
                btn7.BackColor = Color.Crimson;

                MessageBox.Show("El equipo O es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoX.Text) + 1;
                lblEquipoX.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn8.Text == "O" && btn6.Text == "O" && btn7.Text == "O")
            {
                btn8.BackColor = Color.Crimson;
                btn6.BackColor = Color.Crimson;
                btn7.BackColor = Color.Crimson;

                MessageBox.Show("El equipo O es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoX.Text) + 1;
                lblEquipoX.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn9.Text == "O" && btn10.Text == "O" && btn11.Text == "O")
            {
                btn9.BackColor = Color.Crimson;
                btn10.BackColor = Color.Crimson;
                btn11.BackColor = Color.Crimson;

                MessageBox.Show("El equipo O es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoX.Text) + 1;
                lblEquipoX.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn12.Text == "O" && btn10.Text == "O" && btn11.Text == "O")
            {
                btn10.BackColor = Color.Crimson;
                btn11.BackColor = Color.Crimson;
                btn12.BackColor = Color.Crimson;

                MessageBox.Show("El equipo O es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoX.Text) + 1;
                lblEquipoX.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn13.Text == "O" && btn14.Text == "O" && btn15.Text == "O")
            {
                btn13.BackColor = Color.Crimson;
                btn14.BackColor = Color.Crimson;
                btn15.BackColor = Color.Crimson;

                MessageBox.Show("El equipo O es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoX.Text) + 1;
                lblEquipoX.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn16.Text == "O" && btn14.Text == "O" && btn15.Text == "O")
            {
                btn16.BackColor = Color.Crimson;
                btn14.BackColor = Color.Crimson;
                btn15.BackColor = Color.Crimson;

                MessageBox.Show("El equipo X es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoX.Text) + 1;
                lblEquipoX.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }

            else if (btn1.Text == "X" && btn5.Text == "X" && btn9.Text == "X")
            {
                btn1.BackColor = Color.Crimson;
                btn9.BackColor = Color.Crimson;
                btn5.BackColor = Color.Crimson;

                MessageBox.Show("El equipo X es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoX.Text) + 1;
                lblEquipoX.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn13.Text == "O" && btn5.Text == "O" && btn9.Text == "O")
            {
                btn13.BackColor = Color.Crimson;
                btn9.BackColor = Color.Crimson;
                btn5.BackColor = Color.Crimson;

                MessageBox.Show("El equipo O es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoX.Text) + 1;
                lblEquipoX.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn2.Text == "O" && btn6.Text == "O" && btn10.Text == "O")
            {
                btn2.BackColor = Color.Crimson;
                btn6.BackColor = Color.Crimson;
                btn10.BackColor = Color.Crimson;

                MessageBox.Show("El equipo O es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoX.Text) + 1;
                lblEquipoX.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn14.Text == "O" && btn6.Text == "O" && btn10.Text == "O")
            {
                btn14.BackColor = Color.Crimson;
                btn6.BackColor = Color.Crimson;
                btn10.BackColor = Color.Crimson;

                MessageBox.Show("El equipo O es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoX.Text) + 1;
                lblEquipoX.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }

            else if (btn3.Text == "O" && btn7.Text == "O" && btn11.Text == "O")
            {
                btn3.BackColor = Color.Crimson;
                btn7.BackColor = Color.Crimson;
                btn11.BackColor = Color.Crimson;

                MessageBox.Show("El equipo O es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoX.Text) + 1;
                lblEquipoX.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn15.Text == "O" && btn7.Text == "O" && btn11.Text == "O")
            {
                btn3.BackColor = Color.Crimson;
                btn7.BackColor = Color.Crimson;
                btn15.BackColor = Color.Crimson;

                MessageBox.Show("El equipo O es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoX.Text) + 1;
                lblEquipoX.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }

            else if (btn4.Text == "O" && btn8.Text == "O" && btn12.Text == "O")
            {
                btn4.BackColor = Color.Crimson;
                btn8.BackColor = Color.Crimson;
                btn12.BackColor = Color.Crimson;

                MessageBox.Show("El equipo O es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoX.Text) + 1;
                lblEquipoX.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }

            else if (btn16.Text == "O" && btn8.Text == "O" && btn12.Text == "O")
            {
                btn16.BackColor = Color.Crimson;
                btn8.BackColor = Color.Crimson;
                btn12.BackColor = Color.Crimson;

                MessageBox.Show("El equipo O es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoX.Text) + 1;
                lblEquipoX.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }


            else if (btn2.Text == "O" && btn7.Text == "O" && btn12.Text == "O")
            {
                btn2.BackColor = Color.Crimson;
                btn7.BackColor = Color.Crimson;
                btn12.BackColor = Color.Crimson;

                MessageBox.Show("El equipo O es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoX.Text) + 1;
                lblEquipoX.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn1.Text == "O" && btn6.Text == "O" && btn11.Text == "O")
            {
                btn1.BackColor = Color.Crimson;
                btn6.BackColor = Color.Crimson;
                btn11.BackColor = Color.Crimson;

                MessageBox.Show("El equipo O es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoX.Text) + 1;
                lblEquipoX.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn16.Text == "O" && btn6.Text == "O" && btn11.Text == "O")
            {
                btn16.BackColor = Color.Crimson;
                btn6.BackColor = Color.Crimson;
                btn11.BackColor = Color.Crimson;

                MessageBox.Show("El equipo O es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoX.Text) + 1;
                lblEquipoX.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn5.Text == "O" && btn10.Text == "O" && btn15.Text == "O")
            {
                btn5.BackColor = Color.Crimson;
                btn10.BackColor = Color.Crimson;
                btn15.BackColor = Color.Crimson;

                MessageBox.Show("El equipo O es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoX.Text) + 1;
                lblEquipoX.Text = Convert.ToString(sumarUno);
                disponibleFalse();
            }

            else if (btn3.Text == "O" && btn6.Text == "O" && btn9.Text == "O")
            {
                btn3.BackColor = Color.Crimson;
                btn6.BackColor = Color.Crimson;
                btn9.BackColor = Color.Crimson;

                MessageBox.Show("El equipo O es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoX.Text) + 1;
                lblEquipoX.Text = Convert.ToString(sumarUno);
                disponibleFalse();
            }

            else if (btn4.Text == "O" && btn7.Text == "O" && btn10.Text == "O")
            {
                btn4.BackColor = Color.Crimson;
                btn7.BackColor = Color.Crimson;
                btn10.BackColor = Color.Crimson;

                MessageBox.Show("El equipo O es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoX.Text) + 1;
                lblEquipoX.Text = Convert.ToString(sumarUno);
                disponibleFalse();
            }

            else if (btn13.Text == "O" && btn7.Text == "O" && btn10.Text == "O")
            {
                btn13.BackColor = Color.Crimson;
                btn7.BackColor = Color.Crimson;
                btn10.BackColor = Color.Crimson;

                MessageBox.Show("El equipo O es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoX.Text) + 1;
                lblEquipoX.Text = Convert.ToString(sumarUno);
                disponibleFalse();
            }
            else if (btn8.Text == "O" && btn11.Text == "O" && btn14.Text == "O")
            {
                btn8.BackColor = Color.Crimson;
                btn11.BackColor = Color.Crimson;
                btn14.BackColor = Color.Crimson;

                MessageBox.Show("El equipo O es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoX.Text) + 1;
                lblEquipoX.Text = Convert.ToString(sumarUno);
                disponibleFalse();
            }

            else
            {
                contadorDeBotones++;

                if (contadorDeBotones == 16)
                {


                    btn1.BackColor = Color.Crimson;
                    btn2.BackColor = Color.Crimson;
                    btn3.BackColor = Color.Crimson;
                    btn4.BackColor = Color.Crimson;
                    btn5.BackColor = Color.Crimson;
                    btn6.BackColor = Color.Crimson;
                    btn7.BackColor = Color.Crimson;
                    btn8.BackColor = Color.Crimson;
                    btn9.BackColor = Color.Crimson;
                    btn10.BackColor = Color.Crimson;
                    btn11.BackColor = Color.Crimson;
                    btn12.BackColor = Color.Crimson;
                    btn13.BackColor = Color.Crimson;
                    btn14.BackColor = Color.Crimson;
                    btn15.BackColor = Color.Crimson;
                    btn16.BackColor = Color.Crimson;

                    MessageBox.Show("Empate!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    sumarUno = int.Parse(lblEmpates.Text) + 1;
                    lblEmpates.Text = Convert.ToString(sumarUno);
                    disponibleFalse();



                }

            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Triqui4x4_Load(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {

            if (checker == false)
            {
                btn1.Text = "X";


                checker = true;
            }
            else
            {
                btn1.Text = "O";
                checker = false;

            }
            scoreTriqui4x4();
            btn1.Enabled = false;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btn2.Text = "X";


                checker = true;
            }
            else
            {
                btn2.Text = "O";
                checker = false;

            }
            scoreTriqui4x4();
            btn2.Enabled = false;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btn3.Text = "X";


                checker = true;
            }
            else
            {
                btn3.Text = "O";
                checker = false;

            }
            scoreTriqui4x4();
            btn3.Enabled = false;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btn4.Text = "X";


                checker = true;
            }
            else
            {
                btn4.Text = "O";
                checker = false;

            }
            scoreTriqui4x4();
            btn4.Enabled = false;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btn5.Text = "X";


                checker = true;
            }
            else
            {
                btn5.Text = "O";
                checker = false;

            }
            scoreTriqui4x4();
            btn5.Enabled = false;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btn6.Text = "X";


                checker = true;
            }
            else
            {
                btn6.Text = "O";
                checker = false;

            }
            scoreTriqui4x4();
            btn6.Enabled = false;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btn7.Text = "X";


                checker = true;
            }
            else
            {
                btn7.Text = "O";
                checker = false;

            }
            scoreTriqui4x4();
            btn7.Enabled = false;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btn8.Text = "X";


                checker = true;
            }
            else
            {
                btn8.Text = "O";
                checker = false;

            }
            scoreTriqui4x4();
            btn8.Enabled = false;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btn9.Text = "X";


                checker = true;
            }
            else
            {
                btn9.Text = "O";
                checker = false;

            }
            scoreTriqui4x4();
            btn9.Enabled = false;
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btn10.Text = "X";


                checker = true;
            }
            else
            {
                btn10.Text = "O";
                checker = false;

            }
            scoreTriqui4x4();
            btn10.Enabled = false;
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btn11.Text = "X";


                checker = true;
            }
            else
            {
                btn11.Text = "O";
                checker = false;

            }
            scoreTriqui4x4();
            btn11.Enabled = false;
        }

        private void btn12_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btn12.Text = "X";


                checker = true;
            }
            else
            {
                btn12.Text = "O";
                checker = false;

            }
            scoreTriqui4x4();
            btn12.Enabled = false;
        }

        private void btn13_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btn13.Text = "X";


                checker = true;
            }
            else
            {
                btn13.Text = "O";
                checker = false;

            }
            scoreTriqui4x4();
            btn13.Enabled = false;
        }

        private void btn14_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btn14.Text = "X";


                checker = true;
            }
            else
            {
                btn14.Text = "O";
                checker = false;

            }
            scoreTriqui4x4();
            btn14.Enabled = false;
        }

        private void btn15_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btn15.Text = "X";


                checker = true;
            }
            else
            {
                btn15.Text = "O";
                checker = false;

            }
            scoreTriqui4x4();
            btn15.Enabled = false;
        }

        private void btn16_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btn16.Text = "X";


                checker = true;
            }
            else
            {
                btn16.Text = "O";
                checker = false;

            }
            scoreTriqui4x4();
            btn16.Enabled = false;
        }

        private void btnNuevoJuego_Click(object sender, EventArgs e)
        {
            contadorDeBotones = 0;

            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;
            btn9.Enabled = true;
            btn10.Enabled = true;
            btn11.Enabled = true;
            btn12.Enabled = true;
            btn13.Enabled = true;
            btn14.Enabled = true;
            btn15.Enabled = true;
            btn16.Enabled = true;

            btn1.Text = "";
            btn2.Text = "";
            btn3.Text = "";
            btn4.Text = "";
            btn5.Text = "";
            btn6.Text = "";
            btn7.Text = "";
            btn8.Text = "";
            btn9.Text = "";
            btn10.Text = "";
            btn11.Text = "";
            btn12.Text = "";
            btn13.Text = "";
            btn14.Text = "";
            btn15.Text = "";
            btn16.Text = "";

            lblEquipoX.Text = "0";
            lblEqupoY.Text = "0";
            lblEmpates.Text = "0";

            btn1.BackColor = Color.White;
            btn2.BackColor = Color.White;
            btn3.BackColor = Color.White;
            btn4.BackColor = Color.White;
            btn5.BackColor = Color.White;
            btn6.BackColor = Color.White;
            btn7.BackColor = Color.White;
            btn8.BackColor = Color.White;
            btn9.BackColor = Color.White;
            btn10.BackColor = Color.White;
            btn11.BackColor = Color.White;
            btn12.BackColor = Color.White;
            btn13.BackColor = Color.White;
            btn14.BackColor = Color.White;
            btn15.BackColor = Color.White;
            btn16.BackColor = Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            contadorDeBotones = 0;

            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;
            btn9.Enabled = true;
            btn10.Enabled = true;
            btn11.Enabled = true;
            btn12.Enabled = true;
            btn13.Enabled = true;
            btn14.Enabled = true;
            btn15.Enabled = true;
            btn16.Enabled = true;


            btn1.Text = "";
            btn2.Text = "";
            btn3.Text = "";
            btn4.Text = "";
            btn5.Text = "";
            btn6.Text = "";
            btn7.Text = "";
            btn8.Text = "";
            btn9.Text = "";
            btn10.Text = "";
            btn11.Text = "";
            btn12.Text = "";
            btn13.Text = "";
            btn14.Text = "";
            btn15.Text = "";
            btn16.Text = "";

            btnNuevoJuego.Enabled = true;

            btn1.BackColor = Color.White;
            btn2.BackColor = Color.White;
            btn3.BackColor = Color.White;
            btn4.BackColor = Color.White;
            btn5.BackColor = Color.White;
            btn6.BackColor = Color.White;
            btn7.BackColor = Color.White;
            btn8.BackColor = Color.White;
            btn9.BackColor = Color.White;
            btn10.BackColor = Color.White;
            btn11.BackColor = Color.White;
            btn12.BackColor = Color.White;
            btn13.BackColor = Color.White;
            btn14.BackColor = Color.White;
            btn15.BackColor = Color.White;
            btn16.BackColor = Color.White;


           
        }


       
    }
}
