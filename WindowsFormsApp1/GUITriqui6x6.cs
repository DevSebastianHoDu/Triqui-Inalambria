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
    public partial class GUITriqui6x6 : Form
    {
        public GUITriqui6x6()
        {
            InitializeComponent();
        }

        int turno = 1;
        int sumarUno;
        int contadorDeBotones = 0;


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
            btn17.Enabled = false;
            btn18.Enabled = false;
            btn19.Enabled = false;
            btn20.Enabled = false;
            btn21.Enabled = false;
            btn22.Enabled = false;
            btn23.Enabled = false;
            btn24.Enabled = false;
            btn25.Enabled = false;
            btn26.Enabled = false;
            btn27.Enabled = false;
            btn28.Enabled = false;
            btn29.Enabled = false;
            btn30.Enabled = false;
            btn31.Enabled = false;
            btn32.Enabled = false;
            btn33.Enabled = false;
            btn34.Enabled = false;
            btn35.Enabled = false;
            btn36.Enabled = false;
        }

        void score6x6()
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
            else if (btn4.Text == "X" && btn5.Text == "X" && btn3.Text == "X")
            {
                btn4.BackColor = Color.Crimson;
                btn5.BackColor = Color.Crimson;
                btn3.BackColor = Color.Crimson;

                MessageBox.Show("El equipo X es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoX.Text) + 1;
                lblEquipoX.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn4.Text == "X" && btn5.Text == "X" && btn6.Text == "X")
            {
                btn4.BackColor = Color.Crimson;
                btn5.BackColor = Color.Crimson;
                btn6.BackColor = Color.Crimson;

                MessageBox.Show("El equipo X es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoX.Text) + 1;
                lblEquipoX.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }

            else if (btn7.Text == "X" && btn8.Text == "X" && btn9.Text == "X")
            {
                btn7.BackColor = Color.Crimson;
                btn8.BackColor = Color.Crimson;
                btn9.BackColor = Color.Crimson;

                MessageBox.Show("El equipo X es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoX.Text) + 1;
                lblEquipoX.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn10.Text == "X" && btn8.Text == "X" && btn9.Text == "X")
            {
                btn7.BackColor = Color.Crimson;
                btn8.BackColor = Color.Crimson;
                btn9.BackColor = Color.Crimson;

                MessageBox.Show("El equipo X es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoX.Text) + 1;
                lblEquipoX.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn10.Text == "X" && btn11.Text == "X" && btn9.Text == "X")
            {
                btn7.BackColor = Color.Crimson;
                btn8.BackColor = Color.Crimson;
                btn9.BackColor = Color.Crimson;

                MessageBox.Show("El equipo X es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoX.Text) + 1;
                lblEquipoX.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn10.Text == "X" && btn11.Text == "X" && btn12.Text == "X")
            {
                btn7.BackColor = Color.Crimson;
                btn8.BackColor = Color.Crimson;
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
            else if (btn16.Text == "X" && btn17.Text == "X" && btn15.Text == "X")
            {
                btn16.BackColor = Color.Crimson;
                btn17.BackColor = Color.Crimson;
                btn15.BackColor = Color.Crimson;

                MessageBox.Show("El equipo X es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoX.Text) + 1;
                lblEquipoX.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn16.Text == "X" && btn17.Text == "X" && btn18.Text == "X")
            {
                btn16.BackColor = Color.Crimson;
                btn17.BackColor = Color.Crimson;
                btn18.BackColor = Color.Crimson;

                MessageBox.Show("El equipo X es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoX.Text) + 1;
                lblEquipoX.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn19.Text == "X" && btn20.Text == "X" && btn21.Text == "X")
            {
                btn19.BackColor = Color.Crimson;
                btn20.BackColor = Color.Crimson;
                btn21.BackColor = Color.Crimson;

                MessageBox.Show("El equipo X es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoX.Text) + 1;
                lblEquipoX.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn22.Text == "X" && btn20.Text == "X" && btn21.Text == "X")
            {
                btn22.BackColor = Color.Crimson;
                btn20.BackColor = Color.Crimson;
                btn21.BackColor = Color.Crimson;

                MessageBox.Show("El equipo X es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoX.Text) + 1;
                lblEquipoX.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn22.Text == "X" && btn23.Text == "X" && btn21.Text == "X")
            {
                btn22.BackColor = Color.Crimson;
                btn23.BackColor = Color.Crimson;
                btn21.BackColor = Color.Crimson;

                MessageBox.Show("El equipo X es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoX.Text) + 1;
                lblEquipoX.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn22.Text == "X" && btn23.Text == "X" && btn24.Text == "X")
            {
                btn22.BackColor = Color.Crimson;
                btn23.BackColor = Color.Crimson;
                btn24.BackColor = Color.Crimson;

                MessageBox.Show("El equipo X es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoX.Text) + 1;
                lblEquipoX.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn25.Text == "X" && btn26.Text == "X" && btn27.Text == "X")
            {
                btn25.BackColor = Color.Crimson;
                btn26.BackColor = Color.Crimson;
                btn27.BackColor = Color.Crimson;

                MessageBox.Show("El equipo X es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoX.Text) + 1;
                lblEquipoX.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn28.Text == "X" && btn26.Text == "X" && btn27.Text == "X")
            {
                btn28.BackColor = Color.Crimson;
                btn26.BackColor = Color.Crimson;
                btn27.BackColor = Color.Crimson;

                MessageBox.Show("El equipo X es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoX.Text) + 1;
                lblEquipoX.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }

            else if (btn28.Text == "X" && btn29.Text == "X" && btn27.Text == "X")
            {
                btn28.BackColor = Color.Crimson;
                btn29.BackColor = Color.Crimson;
                btn27.BackColor = Color.Crimson;

                MessageBox.Show("El equipo X es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoX.Text) + 1;
                lblEquipoX.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn28.Text == "X" && btn29.Text == "X" && btn30.Text == "X")
            {
                btn28.BackColor = Color.Crimson;
                btn29.BackColor = Color.Crimson;
                btn30.BackColor = Color.Crimson;

                MessageBox.Show("El equipo X es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoX.Text) + 1;
                lblEquipoX.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn31.Text == "X" && btn32.Text == "X" && btn33.Text == "X")
            {
                btn31.BackColor = Color.Crimson;
                btn32.BackColor = Color.Crimson;
                btn33.BackColor = Color.Crimson;

                MessageBox.Show("El equipo X es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoX.Text) + 1;
                lblEquipoX.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn34.Text == "X" && btn32.Text == "X" && btn33.Text == "X")
            {
                btn34.BackColor = Color.Crimson;
                btn32.BackColor = Color.Crimson;
                btn33.BackColor = Color.Crimson;

                MessageBox.Show("El equipo X es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoX.Text) + 1;
                lblEquipoX.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn34.Text == "X" && btn35.Text == "X" && btn33.Text == "X")
            {
                btn34.BackColor = Color.Crimson;
                btn35.BackColor = Color.Crimson;
                btn33.BackColor = Color.Crimson;

                MessageBox.Show("El equipo X es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoX.Text) + 1;
                lblEquipoX.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn34.Text == "X" && btn35.Text == "X" && btn36.Text == "X")
            {
                btn34.BackColor = Color.Crimson;
                btn35.BackColor = Color.Crimson;
                btn36.BackColor = Color.Crimson;

                MessageBox.Show("El equipo X es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoX.Text) + 1;
                lblEquipoX.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }

            // FALTA HORIZONTAL Y AMBAS DIAGONALES



            else if (btn1.Text == "X" && btn7.Text == "X" && btn13.Text == "X")
            {
                btn1.BackColor = Color.Crimson;
                btn7.BackColor = Color.Crimson;
                btn13.BackColor = Color.Crimson;

                MessageBox.Show("El equipo X es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoX.Text) + 1;
                lblEquipoX.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }

            else if (btn19.Text == "X" && btn7.Text == "X" && btn13.Text == "X")
            {
                btn19.BackColor = Color.Crimson;
                btn7.BackColor = Color.Crimson;
                btn13.BackColor = Color.Crimson;

                MessageBox.Show("El equipo X es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoX.Text) + 1;
                lblEquipoX.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn19.Text == "X" && btn25.Text == "X" && btn13.Text == "X")
            {
                btn19.BackColor = Color.Crimson;
                btn25.BackColor = Color.Crimson;
                btn13.BackColor = Color.Crimson;

                MessageBox.Show("El equipo X es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoX.Text) + 1;
                lblEquipoX.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn19.Text == "X" && btn25.Text == "X" && btn31.Text == "X")
            {
                btn19.BackColor = Color.Crimson;
                btn25.BackColor = Color.Crimson;
                btn31.BackColor = Color.Crimson;

                MessageBox.Show("El equipo X es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoX.Text) + 1;
                lblEquipoX.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn2.Text == "X" && btn8.Text == "X" && btn14.Text == "X")
            {
                btn2.BackColor = Color.Crimson;
                btn8.BackColor = Color.Crimson;
                btn14.BackColor = Color.Crimson;

                MessageBox.Show("El equipo X es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoX.Text) + 1;
                lblEquipoX.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn20.Text == "X" && btn8.Text == "X" && btn14.Text == "X")
            {
                btn20.BackColor = Color.Crimson;
                btn8.BackColor = Color.Crimson;
                btn14.BackColor = Color.Crimson;

                MessageBox.Show("El equipo X es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoX.Text) + 1;
                lblEquipoX.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn20.Text == "X" && btn26.Text == "X" && btn14.Text == "X")
            {
                btn20.BackColor = Color.Crimson;
                btn26.BackColor = Color.Crimson;
                btn14.BackColor = Color.Crimson;

                MessageBox.Show("El equipo X es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoX.Text) + 1;
                lblEquipoX.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn20.Text == "X" && btn26.Text == "X" && btn32.Text == "X")
            {
                btn20.BackColor = Color.Crimson;
                btn26.BackColor = Color.Crimson;
                btn32.BackColor = Color.Crimson;

                MessageBox.Show("El equipo X es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoX.Text) + 1;
                lblEquipoX.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn3.Text == "X" && btn9.Text == "X" && btn15.Text == "X")
            {
                btn3.BackColor = Color.Crimson;
                btn9.BackColor = Color.Crimson;
                btn15.BackColor = Color.Crimson;

                MessageBox.Show("El equipo X es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoX.Text) + 1;
                lblEquipoX.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn21.Text == "X" && btn9.Text == "X" && btn15.Text == "X")
            {
                btn21.BackColor = Color.Crimson;
                btn9.BackColor = Color.Crimson;
                btn15.BackColor = Color.Crimson;

                MessageBox.Show("El equipo X es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoX.Text) + 1;
                lblEquipoX.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn21.Text == "X" && btn27.Text == "X" && btn15.Text == "X")
            {
                btn21.BackColor = Color.Crimson;
                btn27.BackColor = Color.Crimson;
                btn15.BackColor = Color.Crimson;

                MessageBox.Show("El equipo X es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoX.Text) + 1;
                lblEquipoX.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn21.Text == "X" && btn27.Text == "X" && btn33.Text == "X")
            {
                btn21.BackColor = Color.Crimson;
                btn27.BackColor = Color.Crimson;
                btn33.BackColor = Color.Crimson;

                MessageBox.Show("El equipo X es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoX.Text) + 1;
                lblEquipoX.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn4.Text == "X" && btn10.Text == "X" && btn16.Text == "X")
            {
                btn4.BackColor = Color.Crimson;
                btn10.BackColor = Color.Crimson;
                btn16.BackColor = Color.Crimson;

                MessageBox.Show("El equipo X es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoX.Text) + 1;
                lblEquipoX.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn22.Text == "X" && btn10.Text == "X" && btn16.Text == "X")
            {
                btn22.BackColor = Color.Crimson;
                btn10.BackColor = Color.Crimson;
                btn16.BackColor = Color.Crimson;

                MessageBox.Show("El equipo X es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoX.Text) + 1;
                lblEquipoX.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn22.Text == "X" && btn28.Text == "X" && btn16.Text == "X")
            {
                btn22.BackColor = Color.Crimson;
                btn28.BackColor = Color.Crimson;
                btn16.BackColor = Color.Crimson;

                MessageBox.Show("El equipo X es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoX.Text) + 1;
                lblEquipoX.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn22.Text == "X" && btn28.Text == "X" && btn34.Text == "X")
            {
                btn22.BackColor = Color.Crimson;
                btn28.BackColor = Color.Crimson;
                btn34.BackColor = Color.Crimson;

                MessageBox.Show("El equipo X es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoX.Text) + 1;
                lblEquipoX.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn5.Text == "X" && btn11.Text == "X" && btn17.Text == "X")
            {
                btn5.BackColor = Color.Crimson;
                btn11.BackColor = Color.Crimson;
                btn17.BackColor = Color.Crimson;

                MessageBox.Show("El equipo X es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoX.Text) + 1;
                lblEquipoX.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn23.Text == "X" && btn11.Text == "X" && btn17.Text == "X")
            {
                btn23.BackColor = Color.Crimson;
                btn11.BackColor = Color.Crimson;
                btn17.BackColor = Color.Crimson;

                MessageBox.Show("El equipo X es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoX.Text) + 1;
                lblEquipoX.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn23.Text == "X" && btn29.Text == "X" && btn17.Text == "X")
            {
                btn29.BackColor = Color.Crimson;
                btn11.BackColor = Color.Crimson;
                btn17.BackColor = Color.Crimson;

                MessageBox.Show("El equipo X es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoX.Text) + 1;
                lblEquipoX.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn23.Text == "X" && btn29.Text == "X" && btn17.Text == "X")
            {
                btn29.BackColor = Color.Crimson;
                btn11.BackColor = Color.Crimson;
                btn17.BackColor = Color.Crimson;

                MessageBox.Show("El equipo X es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoX.Text) + 1;
                lblEquipoX.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn23.Text == "X" && btn29.Text == "X" && btn35.Text == "X")
            {
                btn29.BackColor = Color.Crimson;
                btn35.BackColor = Color.Crimson;
                btn23.BackColor = Color.Crimson;

                MessageBox.Show("El equipo X es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoX.Text) + 1;
                lblEquipoX.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn6.Text == "X" && btn12.Text == "X" && btn18.Text == "X")
            {
                btn6.BackColor = Color.Crimson;
                btn12.BackColor = Color.Crimson;
                btn18.BackColor = Color.Crimson;

                MessageBox.Show("El equipo X es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoX.Text) + 1;
                lblEquipoX.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn24.Text == "X" && btn12.Text == "X" && btn18.Text == "X")
            {
                btn24.BackColor = Color.Crimson;
                btn12.BackColor = Color.Crimson;
                btn18.BackColor = Color.Crimson;

                MessageBox.Show("El equipo X es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoX.Text) + 1;
                lblEquipoX.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn24.Text == "X" && btn30.Text == "X" && btn18.Text == "X")
            {
                btn24.BackColor = Color.Crimson;
                btn30.BackColor = Color.Crimson;
                btn18.BackColor = Color.Crimson;

                MessageBox.Show("El equipo X es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoX.Text) + 1;
                lblEquipoX.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn24.Text == "X" && btn30.Text == "X" && btn36.Text == "X")
            {
                btn24.BackColor = Color.Crimson;
                btn30.BackColor = Color.Crimson;
                btn36.BackColor = Color.Crimson;

                MessageBox.Show("El equipo X es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoX.Text) + 1;
                lblEquipoX.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }

            // Diagonal derecha

            else if (btn4.Text == "X" && btn11.Text == "X" && btn18.Text == "X")
            {
                btn4.BackColor = Color.Crimson;
                btn11.BackColor = Color.Crimson;
                btn18.BackColor = Color.Crimson;

                MessageBox.Show("El equipo X es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoX.Text) + 1;
                lblEquipoX.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn3.Text == "X" && btn10.Text == "X" && btn17.Text == "X")
            {
                btn3.BackColor = Color.Crimson;
                btn10.BackColor = Color.Crimson;
                btn17.BackColor = Color.Crimson;

                MessageBox.Show("El equipo X es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoX.Text) + 1;
                lblEquipoX.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn10.Text == "X" && btn17.Text == "X" && btn24.Text == "X")
            {
                btn24.BackColor = Color.Crimson;
                btn10.BackColor = Color.Crimson;
                btn17.BackColor = Color.Crimson;

                MessageBox.Show("El equipo X es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoX.Text) + 1;
                lblEquipoX.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }

            else if (btn2.Text == "X" && btn9.Text == "X" && btn16.Text == "X")
            {
                btn2.BackColor = Color.Crimson;
                btn9.BackColor = Color.Crimson;
                btn16.BackColor = Color.Crimson;

                MessageBox.Show("El equipo X es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoX.Text) + 1;
                lblEquipoX.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn23.Text == "X" && btn9.Text == "X" && btn16.Text == "X")
            {
                btn23.BackColor = Color.Crimson;
                btn9.BackColor = Color.Crimson;
                btn16.BackColor = Color.Crimson;

                MessageBox.Show("El equipo X es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoX.Text) + 1;
                lblEquipoX.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn23.Text == "X" && btn30.Text == "X" && btn16.Text == "X")
            {
                btn23.BackColor = Color.Crimson;
                btn30.BackColor = Color.Crimson;
                btn16.BackColor = Color.Crimson;

                MessageBox.Show("El equipo X es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoX.Text) + 1;
                lblEquipoX.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn1.Text == "X" && btn8.Text == "X" && btn15.Text == "X")
            {
                btn1.BackColor = Color.Crimson;
                btn8.BackColor = Color.Crimson;
                btn15.BackColor = Color.Crimson;

                MessageBox.Show("El equipo X es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoX.Text) + 1;
                lblEquipoX.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn22.Text == "X" && btn8.Text == "X" && btn15.Text == "X")
            {
                btn22.BackColor = Color.Crimson;
                btn8.BackColor = Color.Crimson;
                btn15.BackColor = Color.Crimson;

                MessageBox.Show("El equipo X es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoX.Text) + 1;
                lblEquipoX.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }

            else if (btn22.Text == "X" && btn29.Text == "X" && btn15.Text == "X")
            {
                btn22.BackColor = Color.Crimson;
                btn29.BackColor = Color.Crimson;
                btn15.BackColor = Color.Crimson;

                MessageBox.Show("El equipo X es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoX.Text) + 1;
                lblEquipoX.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn22.Text == "X" && btn29.Text == "X" && btn36.Text == "X")
            {
                btn22.BackColor = Color.Crimson;
                btn29.BackColor = Color.Crimson;
                btn36.BackColor = Color.Crimson;

                MessageBox.Show("El equipo X es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoX.Text) + 1;
                lblEquipoX.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn7.Text == "X" && btn14.Text == "X" && btn21.Text == "X")
            {
                btn7.BackColor = Color.Crimson;
                btn14.BackColor = Color.Crimson;
                btn21.BackColor = Color.Crimson;

                MessageBox.Show("El equipo X es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoX.Text) + 1;
                lblEquipoX.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn21.Text == "X" && btn14.Text == "X" && btn28.Text == "X")
            {
                btn28.BackColor = Color.Crimson;
                btn14.BackColor = Color.Crimson;
                btn21.BackColor = Color.Crimson;

                MessageBox.Show("El equipo X es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoX.Text) + 1;
                lblEquipoX.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn21.Text == "X" && btn28.Text == "X" && btn35.Text == "X")
            {
                btn21.BackColor = Color.Crimson;
                btn14.BackColor = Color.Crimson;
                btn35.BackColor = Color.Crimson;

                MessageBox.Show("El equipo X es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoX.Text) + 1;
                lblEquipoX.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }

            else if (btn13.Text == "X" && btn20.Text == "X" && btn27.Text == "X")
            {
                btn13.BackColor = Color.Crimson;
                btn20.BackColor = Color.Crimson;
                btn27.BackColor = Color.Crimson;

                MessageBox.Show("El equipo X es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoX.Text) + 1;
                lblEquipoX.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn34.Text == "X" && btn20.Text == "X" && btn27.Text == "X")
            {
                btn34.BackColor = Color.Crimson;
                btn20.BackColor = Color.Crimson;
                btn27.BackColor = Color.Crimson;

                MessageBox.Show("El equipo X es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoX.Text) + 1;
                lblEquipoX.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn19.Text == "X" && btn26.Text == "X" && btn33.Text == "X")
            {
                btn19.BackColor = Color.Crimson;
                btn26.BackColor = Color.Crimson;
                btn33.BackColor = Color.Crimson;

                MessageBox.Show("El equipo X es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoX.Text) + 1;
                lblEquipoX.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }

            // DIAGONALES IZQUIERDAS

            else if (btn3.Text == "X" && btn8.Text == "X" && btn13.Text == "X")
            {
                btn3.BackColor = Color.Crimson;
                btn8.BackColor = Color.Crimson;
                btn13.BackColor = Color.Crimson;

                MessageBox.Show("El equipo X es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoX.Text) + 1;
                lblEquipoX.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn4.Text == "X" && btn9.Text == "X" && btn14.Text == "X")
            {
                btn4.BackColor = Color.Crimson;
                btn9.BackColor = Color.Crimson;
                btn14.BackColor = Color.Crimson;

                MessageBox.Show("El equipo X es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoX.Text) + 1;
                lblEquipoX.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn19.Text == "X" && btn9.Text == "X" && btn14.Text == "X")
            {
                btn19.BackColor = Color.Crimson;
                btn9.BackColor = Color.Crimson;
                btn14.BackColor = Color.Crimson;

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
            else if (btn20.Text == "X" && btn10.Text == "X" && btn15.Text == "X")
            {
                btn20.BackColor = Color.Crimson;
                btn10.BackColor = Color.Crimson;
                btn15.BackColor = Color.Crimson;

                MessageBox.Show("El equipo X es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoX.Text) + 1;
                lblEquipoX.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn20.Text == "X" && btn25.Text == "X" && btn15.Text == "X")
            {
                btn20.BackColor = Color.Crimson;
                btn25.BackColor = Color.Crimson;
                btn15.BackColor = Color.Crimson;

                MessageBox.Show("El equipo X es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoX.Text) + 1;
                lblEquipoX.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn6.Text == "X" && btn11.Text == "X" && btn16.Text == "X")
            {
                btn20.BackColor = Color.Crimson;
                btn25.BackColor = Color.Crimson;
                btn15.BackColor = Color.Crimson;

                MessageBox.Show("El equipo X es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoX.Text) + 1;
                lblEquipoX.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn21.Text == "X" && btn11.Text == "X" && btn16.Text == "X")
            {
                btn21.BackColor = Color.Crimson;
                btn26.BackColor = Color.Crimson;
                btn16.BackColor = Color.Crimson;

                MessageBox.Show("El equipo X es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoX.Text) + 1;
                lblEquipoX.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn21.Text == "X" && btn26.Text == "X" && btn16.Text == "X")
            {
                btn21.BackColor = Color.Crimson;
                btn26.BackColor = Color.Crimson;
                btn16.BackColor = Color.Crimson;

                MessageBox.Show("El equipo X es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoX.Text) + 1;
                lblEquipoX.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn21.Text == "X" && btn26.Text == "X" && btn31.Text == "X")
            {
                btn21.BackColor = Color.Crimson;
                btn26.BackColor = Color.Crimson;
                btn31.BackColor = Color.Crimson;

                MessageBox.Show("El equipo X es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoX.Text) + 1;
                lblEquipoX.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn12.Text == "X" && btn17.Text == "X" && btn22.Text == "X")
            {
                btn12.BackColor = Color.Crimson;
                btn17.BackColor = Color.Crimson;
                btn22.BackColor = Color.Crimson;

                MessageBox.Show("El equipo X es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoX.Text) + 1;
                lblEquipoX.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }

            else if (btn27.Text == "X" && btn17.Text == "X" && btn22.Text == "X")
            {
                btn27.BackColor = Color.Crimson;
                btn17.BackColor = Color.Crimson;
                btn22.BackColor = Color.Crimson;

                MessageBox.Show("El equipo X es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoX.Text) + 1;
                lblEquipoX.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn27.Text == "X" && btn32.Text == "X" && btn22.Text == "X")
            {
                btn27.BackColor = Color.Crimson;
                btn32.BackColor = Color.Crimson;
                btn22.BackColor = Color.Crimson;

                MessageBox.Show("El equipo X es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoX.Text) + 1;
                lblEquipoX.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn18.Text == "X" && btn23.Text == "X" && btn28.Text == "X")
            {
                btn18.BackColor = Color.Crimson;
                btn23.BackColor = Color.Crimson;
                btn28.BackColor = Color.Crimson;

                MessageBox.Show("El equipo X es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoX.Text) + 1;
                lblEquipoX.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn33.Text == "X" && btn23.Text == "X" && btn28.Text == "X")
            {
                btn33.BackColor = Color.Crimson;
                btn23.BackColor = Color.Crimson;
                btn28.BackColor = Color.Crimson;

                MessageBox.Show("El equipo X es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoX.Text) + 1;
                lblEquipoX.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn24.Text == "X" && btn29.Text == "X" && btn34.Text == "X")
            {
                btn34.BackColor = Color.Crimson;
                btn29.BackColor = Color.Crimson;
                btn24.BackColor = Color.Crimson;

                MessageBox.Show("El equipo X es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoX.Text) + 1;
                lblEquipoX.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }

            //////////////////////////////////////////////////////////////////////////
            ///
            ///////////////////////////////////////////////////////////////////////



            if (btn1.Text == "♣" && btn2.Text == "♣" && btn3.Text == "♣")
            {
                btn1.BackColor = Color.Crimson;
                btn2.BackColor = Color.Crimson;
                btn3.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♣ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquiporTrebol.Text) + 1;
                lblEquiporTrebol.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }


            else if (btn4.Text == "♣" && btn2.Text == "♣" && btn3.Text == "♣")
            {
                btn4.BackColor = Color.Crimson;
                btn2.BackColor = Color.Crimson;
                btn3.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♣ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquiporTrebol.Text) + 1;
                lblEquiporTrebol.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn4.Text == "♣" && btn5.Text == "♣" && btn3.Text == "♣")
            {
                btn4.BackColor = Color.Crimson;
                btn5.BackColor = Color.Crimson;
                btn3.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♣ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquiporTrebol.Text) + 1;
                lblEquiporTrebol.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn4.Text == "♣" && btn5.Text == "♣" && btn6.Text == "♣")
            {
                btn4.BackColor = Color.Crimson;
                btn5.BackColor = Color.Crimson;
                btn6.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♣ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquiporTrebol.Text) + 1;
                lblEquiporTrebol.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }

            else if (btn7.Text == "♣" && btn8.Text == "♣" && btn9.Text == "♣")
            {
                btn7.BackColor = Color.Crimson;
                btn8.BackColor = Color.Crimson;
                btn9.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♣ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquiporTrebol.Text) + 1;
                lblEquiporTrebol.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn10.Text == "♣" && btn8.Text == "♣" && btn9.Text == "♣")
            {
                btn7.BackColor = Color.Crimson;
                btn8.BackColor = Color.Crimson;
                btn9.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♣ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquiporTrebol.Text) + 1;
                lblEquiporTrebol.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn10.Text == "♣" && btn11.Text == "♣" && btn9.Text == "♣")
            {
                btn7.BackColor = Color.Crimson;
                btn8.BackColor = Color.Crimson;
                btn9.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♣ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquiporTrebol.Text) + 1;
                lblEquiporTrebol.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn10.Text == "♣" && btn11.Text == "♣" && btn12.Text == "♣")
            {
                btn7.BackColor = Color.Crimson;
                btn8.BackColor = Color.Crimson;
                btn12.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♣ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquiporTrebol.Text) + 1;
                lblEquiporTrebol.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }

            else if (btn13.Text == "♣" && btn14.Text == "♣" && btn15.Text == "♣")
            {
                btn13.BackColor = Color.Crimson;
                btn14.BackColor = Color.Crimson;
                btn15.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♣ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquiporTrebol.Text) + 1;
                lblEquiporTrebol.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn16.Text == "♣" && btn14.Text == "♣" && btn15.Text == "♣")
            {
                btn16.BackColor = Color.Crimson;
                btn14.BackColor = Color.Crimson;
                btn15.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♣ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquiporTrebol.Text) + 1;
                lblEquiporTrebol.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn16.Text == "♣" && btn17.Text == "♣" && btn15.Text == "♣")
            {
                btn16.BackColor = Color.Crimson;
                btn17.BackColor = Color.Crimson;
                btn15.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♣ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquiporTrebol.Text) + 1;
                lblEquiporTrebol.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn16.Text == "♣" && btn17.Text == "♣" && btn18.Text == "♣")
            {
                btn16.BackColor = Color.Crimson;
                btn17.BackColor = Color.Crimson;
                btn18.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♣ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquiporTrebol.Text) + 1;
                lblEquiporTrebol.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn19.Text == "♣" && btn20.Text == "♣" && btn21.Text == "♣")
            {
                btn19.BackColor = Color.Crimson;
                btn20.BackColor = Color.Crimson;
                btn21.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♣ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquiporTrebol.Text) + 1;
                lblEquiporTrebol.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn22.Text == "♣" && btn20.Text == "♣" && btn21.Text == "♣")
            {
                btn22.BackColor = Color.Crimson;
                btn20.BackColor = Color.Crimson;
                btn21.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♣ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquiporTrebol.Text) + 1;
                lblEquiporTrebol.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn22.Text == "♣" && btn23.Text == "♣" && btn21.Text == "♣")
            {
                btn22.BackColor = Color.Crimson;
                btn23.BackColor = Color.Crimson;
                btn21.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♣ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquiporTrebol.Text) + 1;
                lblEquiporTrebol.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn22.Text == "♣" && btn23.Text == "♣" && btn24.Text == "♣")
            {
                btn22.BackColor = Color.Crimson;
                btn23.BackColor = Color.Crimson;
                btn24.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♣ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquiporTrebol.Text) + 1;
                lblEquiporTrebol.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn25.Text == "♣" && btn26.Text == "♣" && btn27.Text == "♣")
            {
                btn25.BackColor = Color.Crimson;
                btn26.BackColor = Color.Crimson;
                btn27.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♣ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquiporTrebol.Text) + 1;
                lblEquiporTrebol.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn28.Text == "♣" && btn26.Text == "♣" && btn27.Text == "♣")
            {
                btn28.BackColor = Color.Crimson;
                btn26.BackColor = Color.Crimson;
                btn27.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♣ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquiporTrebol.Text) + 1;
                lblEquiporTrebol.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }

            else if (btn28.Text == "♣" && btn29.Text == "♣" && btn27.Text == "♣")
            {
                btn28.BackColor = Color.Crimson;
                btn29.BackColor = Color.Crimson;
                btn27.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♣ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquiporTrebol.Text) + 1;
                lblEquiporTrebol.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn28.Text == "♣" && btn29.Text == "♣" && btn30.Text == "♣")
            {
                btn28.BackColor = Color.Crimson;
                btn29.BackColor = Color.Crimson;
                btn30.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♣ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquiporTrebol.Text) + 1;
                lblEquiporTrebol.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn31.Text == "♣" && btn32.Text == "♣" && btn33.Text == "♣")
            {
                btn31.BackColor = Color.Crimson;
                btn32.BackColor = Color.Crimson;
                btn33.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♣ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquiporTrebol.Text) + 1;
                lblEquiporTrebol.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn34.Text == "♣" && btn32.Text == "♣" && btn33.Text == "♣")
            {
                btn34.BackColor = Color.Crimson;
                btn32.BackColor = Color.Crimson;
                btn33.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♣ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquiporTrebol.Text) + 1;
                lblEquiporTrebol.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn34.Text == "♣" && btn35.Text == "♣" && btn33.Text == "♣")
            {
                btn34.BackColor = Color.Crimson;
                btn35.BackColor = Color.Crimson;
                btn33.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♣ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquiporTrebol.Text) + 1;
                lblEquiporTrebol.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn34.Text == "♣" && btn35.Text == "♣" && btn36.Text == "♣")
            {
                btn34.BackColor = Color.Crimson;
                btn35.BackColor = Color.Crimson;
                btn36.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♣ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquiporTrebol.Text) + 1;
                lblEquiporTrebol.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }

            // FALTA HORIZONTAL Y AMBAS DIAGONALES



            else if (btn1.Text == "♣" && btn7.Text == "♣" && btn13.Text == "♣")
            {
                btn1.BackColor = Color.Crimson;
                btn7.BackColor = Color.Crimson;
                btn13.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♣ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquiporTrebol.Text) + 1;
                lblEquiporTrebol.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }

            else if (btn19.Text == "♣" && btn7.Text == "♣" && btn13.Text == "♣")
            {
                btn19.BackColor = Color.Crimson;
                btn7.BackColor = Color.Crimson;
                btn13.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♣ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquiporTrebol.Text) + 1;
                lblEquiporTrebol.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn19.Text == "♣" && btn25.Text == "♣" && btn13.Text == "♣")
            {
                btn19.BackColor = Color.Crimson;
                btn25.BackColor = Color.Crimson;
                btn13.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♣ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquiporTrebol.Text) + 1;
                lblEquiporTrebol.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn19.Text == "♣" && btn25.Text == "♣" && btn31.Text == "♣")
            {
                btn19.BackColor = Color.Crimson;
                btn25.BackColor = Color.Crimson;
                btn31.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♣ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquiporTrebol.Text) + 1;
                lblEquiporTrebol.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn2.Text == "♣" && btn8.Text == "♣" && btn14.Text == "♣")
            {
                btn2.BackColor = Color.Crimson;
                btn8.BackColor = Color.Crimson;
                btn14.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♣ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquiporTrebol.Text) + 1;
                lblEquiporTrebol.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn20.Text == "♣" && btn8.Text == "♣" && btn14.Text == "♣")
            {
                btn20.BackColor = Color.Crimson;
                btn8.BackColor = Color.Crimson;
                btn14.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♣ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquiporTrebol.Text) + 1;
                lblEquiporTrebol.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn20.Text == "♣" && btn26.Text == "♣" && btn14.Text == "♣")
            {
                btn20.BackColor = Color.Crimson;
                btn26.BackColor = Color.Crimson;
                btn14.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♣ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquiporTrebol.Text) + 1;
                lblEquiporTrebol.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn20.Text == "♣" && btn26.Text == "♣" && btn32.Text == "♣")
            {
                btn20.BackColor = Color.Crimson;
                btn26.BackColor = Color.Crimson;
                btn32.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♣ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquiporTrebol.Text) + 1;
                lblEquiporTrebol.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn3.Text == "♣" && btn9.Text == "♣" && btn15.Text == "♣")
            {
                btn3.BackColor = Color.Crimson;
                btn9.BackColor = Color.Crimson;
                btn15.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♣ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquiporTrebol.Text) + 1;
                lblEquiporTrebol.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn21.Text == "♣" && btn9.Text == "♣" && btn15.Text == "♣")
            {
                btn21.BackColor = Color.Crimson;
                btn9.BackColor = Color.Crimson;
                btn15.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♣ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquiporTrebol.Text) + 1;
                lblEquiporTrebol.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn21.Text == "♣" && btn27.Text == "♣" && btn15.Text == "♣")
            {
                btn21.BackColor = Color.Crimson;
                btn27.BackColor = Color.Crimson;
                btn15.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♣ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquiporTrebol.Text) + 1;
                lblEquiporTrebol.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn21.Text == "♣" && btn27.Text == "♣" && btn33.Text == "♣")
            {
                btn21.BackColor = Color.Crimson;
                btn27.BackColor = Color.Crimson;
                btn33.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♣ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquiporTrebol.Text) + 1;
                lblEquiporTrebol.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn4.Text == "♣" && btn10.Text == "♣" && btn16.Text == "♣")
            {
                btn4.BackColor = Color.Crimson;
                btn10.BackColor = Color.Crimson;
                btn16.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♣ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquiporTrebol.Text) + 1;
                lblEquiporTrebol.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn22.Text == "♣" && btn10.Text == "♣" && btn16.Text == "♣")
            {
                btn22.BackColor = Color.Crimson;
                btn10.BackColor = Color.Crimson;
                btn16.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♣ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquiporTrebol.Text) + 1;
                lblEquiporTrebol.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn22.Text == "♣" && btn28.Text == "♣" && btn16.Text == "♣")
            {
                btn22.BackColor = Color.Crimson;
                btn28.BackColor = Color.Crimson;
                btn16.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♣ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquiporTrebol.Text) + 1;
                lblEquiporTrebol.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn22.Text == "♣" && btn28.Text == "♣" && btn34.Text == "♣")
            {
                btn22.BackColor = Color.Crimson;
                btn28.BackColor = Color.Crimson;
                btn34.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♣ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquiporTrebol.Text) + 1;
                lblEquiporTrebol.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn5.Text == "♣" && btn11.Text == "♣" && btn17.Text == "♣")
            {
                btn5.BackColor = Color.Crimson;
                btn11.BackColor = Color.Crimson;
                btn17.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♣ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquiporTrebol.Text) + 1;
                lblEquiporTrebol.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn23.Text == "♣" && btn11.Text == "♣" && btn17.Text == "♣")
            {
                btn23.BackColor = Color.Crimson;
                btn11.BackColor = Color.Crimson;
                btn17.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♣ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquiporTrebol.Text) + 1;
                lblEquiporTrebol.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn23.Text == "♣" && btn29.Text == "♣" && btn17.Text == "♣")
            {
                btn29.BackColor = Color.Crimson;
                btn11.BackColor = Color.Crimson;
                btn17.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♣ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquiporTrebol.Text) + 1;
                lblEquiporTrebol.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn23.Text == "♣" && btn29.Text == "♣" && btn17.Text == "♣")
            {
                btn29.BackColor = Color.Crimson;
                btn11.BackColor = Color.Crimson;
                btn17.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♣ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquiporTrebol.Text) + 1;
                lblEquiporTrebol.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn23.Text == "♣" && btn29.Text == "♣" && btn35.Text == "♣")
            {
                btn29.BackColor = Color.Crimson;
                btn35.BackColor = Color.Crimson;
                btn17.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♣ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquiporTrebol.Text) + 1;
                lblEquiporTrebol.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn6.Text == "♣" && btn12.Text == "♣" && btn18.Text == "♣")
            {
                btn6.BackColor = Color.Crimson;
                btn12.BackColor = Color.Crimson;
                btn18.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♣ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquiporTrebol.Text) + 1;
                lblEquiporTrebol.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn24.Text == "♣" && btn12.Text == "♣" && btn18.Text == "♣")
            {
                btn24.BackColor = Color.Crimson;
                btn12.BackColor = Color.Crimson;
                btn18.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♣ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquiporTrebol.Text) + 1;
                lblEquiporTrebol.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn24.Text == "♣" && btn30.Text == "♣" && btn18.Text == "♣")
            {
                btn24.BackColor = Color.Crimson;
                btn30.BackColor = Color.Crimson;
                btn18.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♣ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquiporTrebol.Text) + 1;
                lblEquiporTrebol.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn24.Text == "♣" && btn30.Text == "♣" && btn36.Text == "♣")
            {
                btn24.BackColor = Color.Crimson;
                btn30.BackColor = Color.Crimson;
                btn36.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♣ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquiporTrebol.Text) + 1;
                lblEquiporTrebol.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }

            // Diagonal derecha

            else if (btn4.Text == "♣" && btn11.Text == "♣" && btn18.Text == "♣")
            {
                btn4.BackColor = Color.Crimson;
                btn11.BackColor = Color.Crimson;
                btn18.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♣ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquiporTrebol.Text) + 1;
                lblEquiporTrebol.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn3.Text == "♣" && btn10.Text == "♣" && btn17.Text == "♣")
            {
                btn3.BackColor = Color.Crimson;
                btn10.BackColor = Color.Crimson;
                btn17.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♣ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquiporTrebol.Text) + 1;
                lblEquiporTrebol.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn10.Text == "♣" && btn17.Text == "♣" && btn24.Text == "♣")
            {
                btn24.BackColor = Color.Crimson;
                btn10.BackColor = Color.Crimson;
                btn17.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♣ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquiporTrebol.Text) + 1;
                lblEquiporTrebol.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }

            else if (btn2.Text == "♣" && btn9.Text == "♣" && btn16.Text == "♣")
            {
                btn2.BackColor = Color.Crimson;
                btn9.BackColor = Color.Crimson;
                btn16.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♣ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquiporTrebol.Text) + 1;
                lblEquiporTrebol.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn23.Text == "♣" && btn9.Text == "♣" && btn16.Text == "♣")
            {
                btn23.BackColor = Color.Crimson;
                btn9.BackColor = Color.Crimson;
                btn16.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♣ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquiporTrebol.Text) + 1;
                lblEquiporTrebol.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn23.Text == "♣" && btn30.Text == "♣" && btn16.Text == "♣")
            {
                btn23.BackColor = Color.Crimson;
                btn30.BackColor = Color.Crimson;
                btn16.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♣ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquiporTrebol.Text) + 1;
                lblEquiporTrebol.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn1.Text == "♣" && btn8.Text == "♣" && btn15.Text == "♣")
            {
                btn1.BackColor = Color.Crimson;
                btn8.BackColor = Color.Crimson;
                btn15.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♣ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquiporTrebol.Text) + 1;
                lblEquiporTrebol.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn22.Text == "♣" && btn8.Text == "♣" && btn15.Text == "♣")
            {
                btn22.BackColor = Color.Crimson;
                btn8.BackColor = Color.Crimson;
                btn15.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♣ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquiporTrebol.Text) + 1;
                lblEquiporTrebol.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }

            else if (btn22.Text == "♣" && btn29.Text == "♣" && btn15.Text == "♣")
            {
                btn22.BackColor = Color.Crimson;
                btn29.BackColor = Color.Crimson;
                btn15.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♣ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquiporTrebol.Text) + 1;
                lblEquiporTrebol.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn22.Text == "♣" && btn29.Text == "♣" && btn36.Text == "♣")
            {
                btn22.BackColor = Color.Crimson;
                btn29.BackColor = Color.Crimson;
                btn36.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♣ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquiporTrebol.Text) + 1;
                lblEquiporTrebol.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn7.Text == "♣" && btn14.Text == "♣" && btn21.Text == "♣")
            {
                btn7.BackColor = Color.Crimson;
                btn14.BackColor = Color.Crimson;
                btn21.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♣ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquiporTrebol.Text) + 1;
                lblEquiporTrebol.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn21.Text == "♣" && btn14.Text == "♣" && btn28.Text == "♣")
            {
                btn28.BackColor = Color.Crimson;
                btn14.BackColor = Color.Crimson;
                btn21.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♣ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquiporTrebol.Text) + 1;
                lblEquiporTrebol.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn21.Text == "♣" && btn28.Text == "♣" && btn35.Text == "♣")
            {
                btn21.BackColor = Color.Crimson;
                btn14.BackColor = Color.Crimson;
                btn35.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♣ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquiporTrebol.Text) + 1;
                lblEquiporTrebol.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }

            else if (btn13.Text == "♣" && btn20.Text == "♣" && btn27.Text == "♣")
            {
                btn13.BackColor = Color.Crimson;
                btn20.BackColor = Color.Crimson;
                btn27.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♣ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquiporTrebol.Text) + 1;
                lblEquiporTrebol.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn34.Text == "♣" && btn20.Text == "♣" && btn27.Text == "♣")
            {
                btn34.BackColor = Color.Crimson;
                btn20.BackColor = Color.Crimson;
                btn27.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♣ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquiporTrebol.Text) + 1;
                lblEquiporTrebol.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn19.Text == "♣" && btn26.Text == "♣" && btn33.Text == "♣")
            {
                btn19.BackColor = Color.Crimson;
                btn26.BackColor = Color.Crimson;
                btn33.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♣ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquiporTrebol.Text) + 1;
                lblEquiporTrebol.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }

            // DIAGONALES IZQUIERDAS

            else if (btn3.Text == "♣" && btn8.Text == "♣" && btn13.Text == "♣")
            {
                btn3.BackColor = Color.Crimson;
                btn8.BackColor = Color.Crimson;
                btn13.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♣ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquiporTrebol.Text) + 1;
                lblEquiporTrebol.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn4.Text == "♣" && btn9.Text == "♣" && btn14.Text == "♣")
            {
                btn4.BackColor = Color.Crimson;
                btn9.BackColor = Color.Crimson;
                btn14.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♣ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquiporTrebol.Text) + 1;
                lblEquiporTrebol.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn19.Text == "♣" && btn9.Text == "♣" && btn14.Text == "♣")
            {
                btn19.BackColor = Color.Crimson;
                btn9.BackColor = Color.Crimson;
                btn14.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♣ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquiporTrebol.Text) + 1;
                lblEquiporTrebol.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn5.Text == "♣" && btn10.Text == "♣" && btn15.Text == "♣")
            {
                btn5.BackColor = Color.Crimson;
                btn10.BackColor = Color.Crimson;
                btn15.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♣ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquiporTrebol.Text) + 1;
                lblEquiporTrebol.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn20.Text == "♣" && btn10.Text == "♣" && btn15.Text == "♣")
            {
                btn20.BackColor = Color.Crimson;
                btn10.BackColor = Color.Crimson;
                btn15.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♣ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquiporTrebol.Text) + 1;
                lblEquiporTrebol.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn20.Text == "♣" && btn25.Text == "♣" && btn15.Text == "♣")
            {
                btn20.BackColor = Color.Crimson;
                btn25.BackColor = Color.Crimson;
                btn15.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♣ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquiporTrebol.Text) + 1;
                lblEquiporTrebol.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn6.Text == "♣" && btn11.Text == "♣" && btn16.Text == "♣")
            {
                btn20.BackColor = Color.Crimson;
                btn25.BackColor = Color.Crimson;
                btn15.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♣ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquiporTrebol.Text) + 1;
                lblEquiporTrebol.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn21.Text == "♣" && btn11.Text == "♣" && btn16.Text == "♣")
            {
                btn21.BackColor = Color.Crimson;
                btn26.BackColor = Color.Crimson;
                btn16.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♣ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquiporTrebol.Text) + 1;
                lblEquiporTrebol.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn21.Text == "♣" && btn26.Text == "♣" && btn16.Text == "♣")
            {
                btn21.BackColor = Color.Crimson;
                btn26.BackColor = Color.Crimson;
                btn16.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♣ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquiporTrebol.Text) + 1;
                lblEquiporTrebol.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn21.Text == "♣" && btn26.Text == "♣" && btn31.Text == "♣")
            {
                btn21.BackColor = Color.Crimson;
                btn26.BackColor = Color.Crimson;
                btn31.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♣ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquiporTrebol.Text) + 1;
                lblEquiporTrebol.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn12.Text == "♣" && btn17.Text == "♣" && btn22.Text == "♣")
            {
                btn12.BackColor = Color.Crimson;
                btn17.BackColor = Color.Crimson;
                btn22.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♣ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquiporTrebol.Text) + 1;
                lblEquiporTrebol.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }

            else if (btn27.Text == "♣" && btn17.Text == "♣" && btn22.Text == "♣")
            {
                btn27.BackColor = Color.Crimson;
                btn17.BackColor = Color.Crimson;
                btn22.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♣ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquiporTrebol.Text) + 1;
                lblEquiporTrebol.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn27.Text == "♣" && btn32.Text == "♣" && btn22.Text == "♣")
            {
                btn27.BackColor = Color.Crimson;
                btn32.BackColor = Color.Crimson;
                btn22.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♣ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquiporTrebol.Text) + 1;
                lblEquiporTrebol.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn18.Text == "♣" && btn23.Text == "♣" && btn28.Text == "♣")
            {
                btn18.BackColor = Color.Crimson;
                btn23.BackColor = Color.Crimson;
                btn28.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♣ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquiporTrebol.Text) + 1;
                lblEquiporTrebol.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn33.Text == "♣" && btn23.Text == "♣" && btn28.Text == "♣")
            {
                btn33.BackColor = Color.Crimson;
                btn23.BackColor = Color.Crimson;
                btn28.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♣ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquiporTrebol.Text) + 1;
                lblEquiporTrebol.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn24.Text == "♣" && btn29.Text == "♣" && btn34.Text == "♣")
            {
                btn34.BackColor = Color.Crimson;
                btn29.BackColor = Color.Crimson;
                btn24.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♣ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquiporTrebol.Text) + 1;
                lblEquiporTrebol.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }

            ///=========================================================
            ///EQUIPO MUSICAL
            ///==========================================================

            if (btn1.Text == "♪" && btn2.Text == "♪" && btn3.Text == "♪")
            {
                btn1.BackColor = Color.Crimson;
                btn2.BackColor = Color.Crimson;
                btn3.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♪ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoMusica.Text) + 1;
                lblEquipoMusica.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }


            else if (btn4.Text == "♪" && btn2.Text == "♪" && btn3.Text == "♪")
            {
                btn4.BackColor = Color.Crimson;
                btn2.BackColor = Color.Crimson;
                btn3.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♪ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoMusica.Text) + 1;
                lblEquipoMusica.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn4.Text == "♪" && btn5.Text == "♪" && btn3.Text == "♪")
            {
                btn4.BackColor = Color.Crimson;
                btn5.BackColor = Color.Crimson;
                btn3.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♪ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoMusica.Text) + 1;
                lblEquipoMusica.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn4.Text == "♪" && btn5.Text == "♪" && btn6.Text == "♪")
            {
                btn4.BackColor = Color.Crimson;
                btn5.BackColor = Color.Crimson;
                btn6.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♪ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoMusica.Text) + 1;
                lblEquipoMusica.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }

            else if (btn7.Text == "♪" && btn8.Text == "♪" && btn9.Text == "♪")
            {
                btn7.BackColor = Color.Crimson;
                btn8.BackColor = Color.Crimson;
                btn9.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♪ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoMusica.Text) + 1;
                lblEquipoMusica.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn10.Text == "♪" && btn8.Text == "♪" && btn9.Text == "♪")
            {
                btn7.BackColor = Color.Crimson;
                btn8.BackColor = Color.Crimson;
                btn9.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♪ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoMusica.Text) + 1;
                lblEquipoMusica.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn10.Text == "♪" && btn11.Text == "♪" && btn9.Text == "♪")
            {
                btn7.BackColor = Color.Crimson;
                btn8.BackColor = Color.Crimson;
                btn9.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♪ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoMusica.Text) + 1;
                lblEquipoMusica.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn10.Text == "♪" && btn11.Text == "♪" && btn12.Text == "♪")
            {
                btn7.BackColor = Color.Crimson;
                btn8.BackColor = Color.Crimson;
                btn12.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♪ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoMusica.Text) + 1;
                lblEquipoMusica.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }

            else if (btn13.Text == "♪" && btn14.Text == "♪" && btn15.Text == "♪")
            {
                btn13.BackColor = Color.Crimson;
                btn14.BackColor = Color.Crimson;
                btn15.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♪ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoMusica.Text) + 1;
                lblEquipoMusica.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn16.Text == "♪" && btn14.Text == "♪" && btn15.Text == "♪")
            {
                btn16.BackColor = Color.Crimson;
                btn14.BackColor = Color.Crimson;
                btn15.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♪ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoMusica.Text) + 1;
                lblEquipoMusica.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn16.Text == "♪" && btn17.Text == "♪" && btn15.Text == "♪")
            {
                btn16.BackColor = Color.Crimson;
                btn17.BackColor = Color.Crimson;
                btn15.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♪ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoMusica.Text) + 1;
                lblEquipoMusica.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn16.Text == "♪" && btn17.Text == "♪" && btn18.Text == "♪")
            {
                btn16.BackColor = Color.Crimson;
                btn17.BackColor = Color.Crimson;
                btn18.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♪ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoMusica.Text) + 1;
                lblEquipoMusica.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn19.Text == "♪" && btn20.Text == "♪" && btn21.Text == "♪")
            {
                btn19.BackColor = Color.Crimson;
                btn20.BackColor = Color.Crimson;
                btn21.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♪ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoMusica.Text) + 1;
                lblEquipoMusica.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn22.Text == "♪" && btn20.Text == "♪" && btn21.Text == "♪")
            {
                btn22.BackColor = Color.Crimson;
                btn20.BackColor = Color.Crimson;
                btn21.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♪ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoMusica.Text) + 1;
                lblEquipoMusica.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn22.Text == "♪" && btn23.Text == "♪" && btn21.Text == "♪")
            {
                btn22.BackColor = Color.Crimson;
                btn23.BackColor = Color.Crimson;
                btn21.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♪ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoMusica.Text) + 1;
                lblEquipoMusica.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn22.Text == "♪" && btn23.Text == "♪" && btn24.Text == "♪")
            {
                btn22.BackColor = Color.Crimson;
                btn23.BackColor = Color.Crimson;
                btn24.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♪ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoMusica.Text) + 1;
                lblEquipoMusica.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn25.Text == "♪" && btn26.Text == "♪" && btn27.Text == "♪")
            {
                btn25.BackColor = Color.Crimson;
                btn26.BackColor = Color.Crimson;
                btn27.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♪ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoMusica.Text) + 1;
                lblEquipoMusica.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn28.Text == "♪" && btn26.Text == "♪" && btn27.Text == "♪")
            {
                btn28.BackColor = Color.Crimson;
                btn26.BackColor = Color.Crimson;
                btn27.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♪ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoMusica.Text) + 1;
                lblEquipoMusica.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }

            else if (btn28.Text == "♪" && btn29.Text == "♪" && btn27.Text == "♪")
            {
                btn28.BackColor = Color.Crimson;
                btn29.BackColor = Color.Crimson;
                btn27.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♪ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoMusica.Text) + 1;
                lblEquipoMusica.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn28.Text == "♪" && btn29.Text == "♪" && btn30.Text == "♪")
            {
                btn28.BackColor = Color.Crimson;
                btn29.BackColor = Color.Crimson;
                btn30.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♪ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoMusica.Text) + 1;
                lblEquipoMusica.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn31.Text == "♪" && btn32.Text == "♪" && btn33.Text == "♪")
            {
                btn31.BackColor = Color.Crimson;
                btn32.BackColor = Color.Crimson;
                btn33.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♪ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoMusica.Text) + 1;
                lblEquipoMusica.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn34.Text == "♪" && btn32.Text == "♪" && btn33.Text == "♪")
            {
                btn34.BackColor = Color.Crimson;
                btn32.BackColor = Color.Crimson;
                btn33.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♪ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoMusica.Text) + 1;
                lblEquipoMusica.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn34.Text == "♪" && btn35.Text == "♪" && btn33.Text == "♪")
            {
                btn34.BackColor = Color.Crimson;
                btn35.BackColor = Color.Crimson;
                btn33.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♪ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoMusica.Text) + 1;
                lblEquipoMusica.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn34.Text == "♪" && btn35.Text == "♪" && btn36.Text == "♪")
            {
                btn34.BackColor = Color.Crimson;
                btn35.BackColor = Color.Crimson;
                btn36.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♪ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoMusica.Text) + 1;
                lblEquipoMusica.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }

            // FALTA HORIZONTAL Y AMBAS DIAGONALES



            else if (btn1.Text == "♪" && btn7.Text == "♪" && btn13.Text == "♪")
            {
                btn1.BackColor = Color.Crimson;
                btn7.BackColor = Color.Crimson;
                btn13.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♪ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoMusica.Text) + 1;
                lblEquipoMusica.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }

            else if (btn19.Text == "♪" && btn7.Text == "♪" && btn13.Text == "♪")
            {
                btn19.BackColor = Color.Crimson;
                btn7.BackColor = Color.Crimson;
                btn13.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♪ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoMusica.Text) + 1;
                lblEquipoMusica.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn19.Text == "♪" && btn25.Text == "♪" && btn13.Text == "♪")
            {
                btn19.BackColor = Color.Crimson;
                btn25.BackColor = Color.Crimson;
                btn13.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♪ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoMusica.Text) + 1;
                lblEquipoMusica.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn19.Text == "♪" && btn25.Text == "♪" && btn31.Text == "♪")
            {
                btn19.BackColor = Color.Crimson;
                btn25.BackColor = Color.Crimson;
                btn31.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♪ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoMusica.Text) + 1;
                lblEquipoMusica.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn2.Text == "♪" && btn8.Text == "♪" && btn14.Text == "♪")
            {
                btn2.BackColor = Color.Crimson;
                btn8.BackColor = Color.Crimson;
                btn14.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♪ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoMusica.Text) + 1;
                lblEquipoMusica.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn20.Text == "♪" && btn8.Text == "♪" && btn14.Text == "♪")
            {
                btn20.BackColor = Color.Crimson;
                btn8.BackColor = Color.Crimson;
                btn14.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♪ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoMusica.Text) + 1;
                lblEquipoMusica.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn20.Text == "♪" && btn26.Text == "♪" && btn14.Text == "♪")
            {
                btn20.BackColor = Color.Crimson;
                btn26.BackColor = Color.Crimson;
                btn14.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♪ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoMusica.Text) + 1;
                lblEquipoMusica.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn20.Text == "♪" && btn26.Text == "♪" && btn32.Text == "♪")
            {
                btn20.BackColor = Color.Crimson;
                btn26.BackColor = Color.Crimson;
                btn32.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♪ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoMusica.Text) + 1;
                lblEquipoMusica.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn3.Text == "♪" && btn9.Text == "♪" && btn15.Text == "♪")
            {
                btn3.BackColor = Color.Crimson;
                btn9.BackColor = Color.Crimson;
                btn15.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♪ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoMusica.Text) + 1;
                lblEquipoMusica.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn21.Text == "♪" && btn9.Text == "♪" && btn15.Text == "♪")
            {
                btn21.BackColor = Color.Crimson;
                btn9.BackColor = Color.Crimson;
                btn15.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♪ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoMusica.Text) + 1;
                lblEquipoMusica.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn21.Text == "♪" && btn27.Text == "♪" && btn15.Text == "♪")
            {
                btn21.BackColor = Color.Crimson;
                btn27.BackColor = Color.Crimson;
                btn15.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♪ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoMusica.Text) + 1;
                lblEquipoMusica.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn21.Text == "♪" && btn27.Text == "♪" && btn33.Text == "♪")
            {
                btn21.BackColor = Color.Crimson;
                btn27.BackColor = Color.Crimson;
                btn33.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♪ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoMusica.Text) + 1;
                lblEquipoMusica.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn4.Text == "♪" && btn10.Text == "♪" && btn16.Text == "♪")
            {
                btn4.BackColor = Color.Crimson;
                btn10.BackColor = Color.Crimson;
                btn16.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♪ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoMusica.Text) + 1;
                lblEquipoMusica.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn22.Text == "♪" && btn10.Text == "♪" && btn16.Text == "♪")
            {
                btn22.BackColor = Color.Crimson;
                btn10.BackColor = Color.Crimson;
                btn16.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♪ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoMusica.Text) + 1;
                lblEquipoMusica.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn22.Text == "♪" && btn28.Text == "♪" && btn16.Text == "♪")
            {
                btn22.BackColor = Color.Crimson;
                btn28.BackColor = Color.Crimson;
                btn16.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♪ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoMusica.Text) + 1;
                lblEquipoMusica.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn22.Text == "♪" && btn28.Text == "♪" && btn34.Text == "♪")
            {
                btn22.BackColor = Color.Crimson;
                btn28.BackColor = Color.Crimson;
                btn34.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♪ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoMusica.Text) + 1;
                lblEquipoMusica.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn5.Text == "♪" && btn11.Text == "♪" && btn17.Text == "♪")
            {
                btn5.BackColor = Color.Crimson;
                btn11.BackColor = Color.Crimson;
                btn17.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♪ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoMusica.Text) + 1;
                lblEquipoMusica.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn23.Text == "♪" && btn11.Text == "♪" && btn17.Text == "♪")
            {
                btn23.BackColor = Color.Crimson;
                btn11.BackColor = Color.Crimson;
                btn17.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♪ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoMusica.Text) + 1;
                lblEquipoMusica.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn23.Text == "♪" && btn29.Text == "♪" && btn17.Text == "♪")
            {
                btn29.BackColor = Color.Crimson;
                btn11.BackColor = Color.Crimson;
                btn17.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♪ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoMusica.Text) + 1;
                lblEquipoMusica.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn23.Text == "♪" && btn29.Text == "♪" && btn17.Text == "♪")
            {
                btn29.BackColor = Color.Crimson;
                btn11.BackColor = Color.Crimson;
                btn17.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♪ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoMusica.Text) + 1;
                lblEquipoMusica.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn23.Text == "♪" && btn29.Text == "♪" && btn35.Text == "♪")
            {
                btn29.BackColor = Color.Crimson;
                btn35.BackColor = Color.Crimson;
                btn17.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♪ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoMusica.Text) + 1;
                lblEquipoMusica.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn6.Text == "♪" && btn12.Text == "♪" && btn18.Text == "♪")
            {
                btn6.BackColor = Color.Crimson;
                btn12.BackColor = Color.Crimson;
                btn18.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♪ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoMusica.Text) + 1;
                lblEquipoMusica.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn24.Text == "♪" && btn12.Text == "♪" && btn18.Text == "♪")
            {
                btn24.BackColor = Color.Crimson;
                btn12.BackColor = Color.Crimson;
                btn18.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♪ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoMusica.Text) + 1;
                lblEquipoMusica.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn24.Text == "♪" && btn30.Text == "♪" && btn18.Text == "♪")
            {
                btn24.BackColor = Color.Crimson;
                btn30.BackColor = Color.Crimson;
                btn18.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♪ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoMusica.Text) + 1;
                lblEquipoMusica.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn24.Text == "♪" && btn30.Text == "♪" && btn36.Text == "♪")
            {
                btn24.BackColor = Color.Crimson;
                btn30.BackColor = Color.Crimson;
                btn36.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♪ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoMusica.Text) + 1;
                lblEquipoMusica.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }

            // Diagonal derecha

            else if (btn4.Text == "♪" && btn11.Text == "♪" && btn18.Text == "♪")
            {
                btn4.BackColor = Color.Crimson;
                btn11.BackColor = Color.Crimson;
                btn18.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♪ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoMusica.Text) + 1;
                lblEquipoMusica.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn3.Text == "♪" && btn10.Text == "♪" && btn17.Text == "♪")
            {
                btn3.BackColor = Color.Crimson;
                btn10.BackColor = Color.Crimson;
                btn17.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♪ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoMusica.Text) + 1;
                lblEquipoMusica.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn10.Text == "♪" && btn17.Text == "♪" && btn24.Text == "♪")
            {
                btn24.BackColor = Color.Crimson;
                btn10.BackColor = Color.Crimson;
                btn17.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♪ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoMusica.Text) + 1;
                lblEquipoMusica.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }

            else if (btn2.Text == "♪" && btn9.Text == "♪" && btn16.Text == "♪")
            {
                btn2.BackColor = Color.Crimson;
                btn9.BackColor = Color.Crimson;
                btn16.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♪ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoMusica.Text) + 1;
                lblEquipoMusica.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn23.Text == "♪" && btn9.Text == "♪" && btn16.Text == "♪")
            {
                btn23.BackColor = Color.Crimson;
                btn9.BackColor = Color.Crimson;
                btn16.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♪ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoMusica.Text) + 1;
                lblEquipoMusica.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn23.Text == "♪" && btn30.Text == "♪" && btn16.Text == "♪")
            {
                btn23.BackColor = Color.Crimson;
                btn30.BackColor = Color.Crimson;
                btn16.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♪ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoMusica.Text) + 1;
                lblEquipoMusica.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn1.Text == "♪" && btn8.Text == "♪" && btn15.Text == "♪")
            {
                btn1.BackColor = Color.Crimson;
                btn8.BackColor = Color.Crimson;
                btn15.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♪ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoMusica.Text) + 1;
                lblEquipoMusica.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn22.Text == "♪" && btn8.Text == "♪" && btn15.Text == "♪")
            {
                btn22.BackColor = Color.Crimson;
                btn8.BackColor = Color.Crimson;
                btn15.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♪ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoMusica.Text) + 1;
                lblEquipoMusica.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }

            else if (btn22.Text == "♪" && btn29.Text == "♪" && btn15.Text == "♪")
            {
                btn22.BackColor = Color.Crimson;
                btn29.BackColor = Color.Crimson;
                btn15.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♪ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoMusica.Text) + 1;
                lblEquipoMusica.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn22.Text == "♪" && btn29.Text == "♪" && btn36.Text == "♪")
            {
                btn22.BackColor = Color.Crimson;
                btn29.BackColor = Color.Crimson;
                btn36.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♪ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoMusica.Text) + 1;
                lblEquipoMusica.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn7.Text == "♪" && btn14.Text == "♪" && btn21.Text == "♪")
            {
                btn7.BackColor = Color.Crimson;
                btn14.BackColor = Color.Crimson;
                btn21.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♪ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoMusica.Text) + 1;
                lblEquipoMusica.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn21.Text == "♪" && btn14.Text == "♪" && btn28.Text == "♪")
            {
                btn28.BackColor = Color.Crimson;
                btn14.BackColor = Color.Crimson;
                btn21.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♪ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoMusica.Text) + 1;
                lblEquipoMusica.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn21.Text == "♪" && btn28.Text == "♪" && btn35.Text == "♪")
            {
                btn21.BackColor = Color.Crimson;
                btn14.BackColor = Color.Crimson;
                btn35.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♪ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoMusica.Text) + 1;
                lblEquipoMusica.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }

            else if (btn13.Text == "♪" && btn20.Text == "♪" && btn27.Text == "♪")
            {
                btn13.BackColor = Color.Crimson;
                btn20.BackColor = Color.Crimson;
                btn27.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♪ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoMusica.Text) + 1;
                lblEquipoMusica.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn34.Text == "♪" && btn20.Text == "♪" && btn27.Text == "♪")
            {
                btn34.BackColor = Color.Crimson;
                btn20.BackColor = Color.Crimson;
                btn27.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♪ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoMusica.Text) + 1;
                lblEquipoMusica.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn19.Text == "♪" && btn26.Text == "♪" && btn33.Text == "♪")
            {
                btn19.BackColor = Color.Crimson;
                btn26.BackColor = Color.Crimson;
                btn33.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♪ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoMusica.Text) + 1;
                lblEquipoMusica.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }

            // DIAGONALES IZQUIERDAS

            else if (btn3.Text == "♪" && btn8.Text == "♪" && btn13.Text == "♪")
            {
                btn3.BackColor = Color.Crimson;
                btn8.BackColor = Color.Crimson;
                btn13.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♪ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoMusica.Text) + 1;
                lblEquipoMusica.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn4.Text == "♪" && btn9.Text == "♪" && btn14.Text == "♪")
            {
                btn4.BackColor = Color.Crimson;
                btn9.BackColor = Color.Crimson;
                btn14.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♪ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoMusica.Text) + 1;
                lblEquipoMusica.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn19.Text == "♪" && btn9.Text == "♪" && btn14.Text == "♪")
            {
                btn19.BackColor = Color.Crimson;
                btn9.BackColor = Color.Crimson;
                btn14.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♪ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoMusica.Text) + 1;
                lblEquipoMusica.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn5.Text == "♪" && btn10.Text == "♪" && btn15.Text == "♪")
            {
                btn5.BackColor = Color.Crimson;
                btn10.BackColor = Color.Crimson;
                btn15.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♪ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoMusica.Text) + 1;
                lblEquipoMusica.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn20.Text == "♪" && btn10.Text == "♪" && btn15.Text == "♪")
            {
                btn20.BackColor = Color.Crimson;
                btn10.BackColor = Color.Crimson;
                btn15.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♪ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoMusica.Text) + 1;
                lblEquipoMusica.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn20.Text == "♪" && btn25.Text == "♪" && btn15.Text == "♪")
            {
                btn20.BackColor = Color.Crimson;
                btn25.BackColor = Color.Crimson;
                btn15.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♪ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoMusica.Text) + 1;
                lblEquipoMusica.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn6.Text == "♪" && btn11.Text == "♪" && btn16.Text == "♪")
            {
                btn20.BackColor = Color.Crimson;
                btn25.BackColor = Color.Crimson;
                btn15.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♪ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoMusica.Text) + 1;
                lblEquipoMusica.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn21.Text == "♪" && btn11.Text == "♪" && btn16.Text == "♪")
            {
                btn21.BackColor = Color.Crimson;
                btn26.BackColor = Color.Crimson;
                btn16.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♪ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoMusica.Text) + 1;
                lblEquipoMusica.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn21.Text == "♪" && btn26.Text == "♪" && btn16.Text == "♪")
            {
                btn21.BackColor = Color.Crimson;
                btn26.BackColor = Color.Crimson;
                btn16.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♪ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoMusica.Text) + 1;
                lblEquipoMusica.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn21.Text == "♪" && btn26.Text == "♪" && btn31.Text == "♪")
            {
                btn21.BackColor = Color.Crimson;
                btn26.BackColor = Color.Crimson;
                btn31.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♪ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoMusica.Text) + 1;
                lblEquipoMusica.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn12.Text == "♪" && btn17.Text == "♪" && btn22.Text == "♪")
            {
                btn12.BackColor = Color.Crimson;
                btn17.BackColor = Color.Crimson;
                btn22.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♪ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoMusica.Text) + 1;
                lblEquipoMusica.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }

            else if (btn27.Text == "♪" && btn17.Text == "♪" && btn22.Text == "♪")
            {
                btn27.BackColor = Color.Crimson;
                btn17.BackColor = Color.Crimson;
                btn22.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♪ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoMusica.Text) + 1;
                lblEquipoMusica.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn27.Text == "♪" && btn32.Text == "♪" && btn22.Text == "♪")
            {
                btn27.BackColor = Color.Crimson;
                btn32.BackColor = Color.Crimson;
                btn22.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♪ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoMusica.Text) + 1;
                lblEquipoMusica.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn18.Text == "♪" && btn23.Text == "♪" && btn28.Text == "♪")
            {
                btn18.BackColor = Color.Crimson;
                btn23.BackColor = Color.Crimson;
                btn28.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♪ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoMusica.Text) + 1;
                lblEquipoMusica.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn33.Text == "♪" && btn23.Text == "♪" && btn28.Text == "♪")
            {
                btn33.BackColor = Color.Crimson;
                btn23.BackColor = Color.Crimson;
                btn28.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♪ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoMusica.Text) + 1;
                lblEquipoMusica.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else if (btn24.Text == "♪" && btn29.Text == "♪" && btn34.Text == "♪")
            {
                btn34.BackColor = Color.Crimson;
                btn29.BackColor = Color.Crimson;
                btn24.BackColor = Color.Crimson;

                MessageBox.Show("El equipo ♪ es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoMusica.Text) + 1;
                lblEquipoMusica.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }
            else
            {
                contadorDeBotones++;

                if(contadorDeBotones == 36)
                {

                    MessageBox.Show("Empate!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    sumarUno = int.Parse(lblEmpates.Text) + 1;
                    lblEmpates.Text = Convert.ToString(sumarUno);
                    disponibleFalse();

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
                    btn17.BackColor = Color.Crimson;
                    btn18.BackColor = Color.Crimson;
                    btn19.BackColor = Color.Crimson;
                    btn20.BackColor = Color.Crimson;
                    btn21.BackColor = Color.Crimson;
                    btn22.BackColor = Color.Crimson;
                    btn23.BackColor = Color.Crimson;
                    btn24.BackColor = Color.Crimson;
                    btn25.BackColor = Color.Crimson;
                    btn26.BackColor = Color.Crimson;
                    btn27.BackColor = Color.Crimson;
                    btn28.BackColor = Color.Crimson;
                    btn29.BackColor = Color.Crimson;
                    btn30.BackColor = Color.Crimson;
                    btn31.BackColor = Color.Crimson;
                    btn32.BackColor = Color.Crimson;
                    btn33.BackColor = Color.Crimson;
                    btn34.BackColor = Color.Crimson;
                    btn35.BackColor = Color.Crimson;
                    btn36.BackColor = Color.Crimson;
                }

            }


        }





        private void btn31_Click(object sender, EventArgs e)
        {
            if (turno == 1)
            {
                turno = 2;
                btn31.Enabled = false;
                btn31.Text = "X";
            }
            else if (turno == 2)
            {
                turno = 3;
                btn31.Enabled = false;
                btn31.Text = "♣";

            }
            else if (turno == 3)
            {
                turno = 1;
                btn31.Enabled = false;
                btn31.Text = "♪";

            }
            score6x6();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
           if(turno == 1)
            {
                turno = 2;
                btn1.Enabled = false;
                btn1.Text = "X";
            }
           else if(turno ==2)
            {
                 turno = 3;
                 btn1.Enabled = false;
                 btn1.Text = "♣";
                
            }
            else if (turno == 3)
            {
                turno = 1;
                btn1.Enabled = false;
                btn1.Text = "♪";

            }
            score6x6();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (turno == 1)
            {
                turno = 2;
                btn2.Enabled = false;
                btn2.Text = "X";
            }
            else if (turno == 2)
            {
                turno = 3;
                btn2.Enabled = false;
                btn2.Text = "♣";

            }
            else if (turno == 3)
            {
                turno = 1;
                btn2.Enabled = false;
                btn2.Text = "♪";

            }
            score6x6();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (turno == 1)
            {
                turno = 2;
                btn3.Enabled = false;
                btn3.Text = "X";
            }
            else if (turno == 2)
            {
                turno = 3;
                btn3.Enabled = false;
                btn3.Text = "♣";

            }
            else if (turno == 3)
            {
                turno = 1;
                btn3.Enabled = false;
                btn3.Text = "♪";

            }
            score6x6();

        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (turno == 1)
            {
                turno = 2;
                btn4.Enabled = false;
                btn4.Text = "X";
            }
            else if (turno == 2)
            {
                turno = 3;
                btn4.Enabled = false;
                btn4.Text = "♣";

            }
            else if (turno == 3)
            {
                turno = 1;
                btn4.Enabled = false;
                btn4.Text = "♪";

            }
            score6x6();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (turno == 1)
            {
                turno = 2;
                btn5.Enabled = false;
                btn5.Text = "X";
            }
            else if (turno == 2)
            {
                turno = 3;
                btn5.Enabled = false;
                btn5.Text = "♣";

            }
            else if (turno == 3)
            {
                turno = 1;
                btn5.Enabled = false;
                btn5.Text = "♪";

            }
            score6x6();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (turno == 1)
            {
                turno = 2;
                btn6.Enabled = false;
                btn6.Text = "X";
            }
            else if (turno == 2)
            {
                turno = 3;
                btn6.Enabled = false;
                btn6.Text = "♣";

            }
            else if (turno == 3)
            {
                turno = 1;
                btn6.Enabled = false;
                btn6.Text = "♪";

            }
            score6x6();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (turno == 1)
            {
                turno = 2;
                btn7.Enabled = false;
                btn7.Text = "X";
            }
            else if (turno == 2)
            {
                turno = 3;
                btn7.Enabled = false;
                btn7.Text = "♣";

            }
            else if (turno == 3)
            {
                turno = 1;
                btn7.Enabled = false;
                btn7.Text = "♪";

            }
            score6x6();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (turno == 1)
            {
                turno = 2;
                btn8.Enabled = false;
                btn8.Text = "X";
            }
            else if (turno == 2)
            {
                turno = 3;
                btn8.Enabled = false;
                btn8.Text = "♣";

            }
            else if (turno == 3)
            {
                turno = 1;
                btn8.Enabled = false;
                btn8.Text = "♪";

            }
            score6x6();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (turno == 1)
            {
                turno = 2;
                btn9.Enabled = false;
                btn9.Text = "X";
            }
            else if (turno == 2)
            {
                turno = 3;
                btn9.Enabled = false;
                btn9.Text = "♣";

            }
            else if (turno == 3)
            {
                turno = 1;
                btn9.Enabled = false;
                btn9.Text = "♪";

            }
            score6x6();
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            if (turno == 1)
            {
                turno = 2;
                btn10.Enabled = false;
                btn10.Text = "X";
            }
            else if (turno == 2)
            {
                turno = 3;
                btn10.Enabled = false;
                btn10.Text = "♣";

            }
            else if (turno == 3)
            {
                turno = 1;
                btn10.Enabled = false;
                btn10.Text = "♪";

            }
            score6x6();
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            if (turno == 1)
            {
                turno = 2;
                btn11.Enabled = false;
                btn11.Text = "X";
            }
            else if (turno == 2)
            {
                turno = 3;
                btn11.Enabled = false;
                btn11.Text = "♣";

            }
            else if (turno == 3)
            {
                turno = 1;
                btn11.Enabled = false;
                btn11.Text = "♪";

            }
            score6x6();
        }

        private void btn12_Click(object sender, EventArgs e)
        {
            if (turno == 1)
            {
                turno = 2;
                btn12.Enabled = false;
                btn12.Text = "X";
            }
            else if (turno == 2)
            {
                turno = 3;
                btn12.Enabled = false;
                btn12.Text = "♣";

            }
            else if (turno == 3)
            {
                turno = 1;
                btn12.Enabled = false;
                btn12.Text = "♪";

            }
            score6x6();
        }

        private void btn13_Click(object sender, EventArgs e)
        {
            if (turno == 1)
            {
                turno = 2;
                btn13.Enabled = false;
                btn13.Text = "X";
            }
            else if (turno == 2)
            {
                turno = 3;
                btn13.Enabled = false;
                btn13.Text = "♣";

            }
            else if (turno == 3)
            {
                turno = 1;
                btn13.Enabled = false;
                btn13.Text = "♪";

            }
            score6x6();
        }

        private void btn14_Click(object sender, EventArgs e)
        {
            if (turno == 1)
            {
                turno = 2;
                btn14.Enabled = false;
                btn14.Text = "X";
            }
            else if (turno == 2)
            {
                turno = 3;
                btn14.Enabled = false;
                btn14.Text = "♣";

            }
            else if (turno == 3)
            {
                turno = 1;
                btn14.Enabled = false;
                btn14.Text = "♪";

            }
            score6x6();
        }

        private void btn15_Click(object sender, EventArgs e)
        {
            if(turno == 1)
            {
                turno = 2;
                btn15.Enabled = false;
                btn15.Text = "X";
            }
           else if (turno == 2)
            {
                turno = 3;
                btn15.Enabled = false;
                btn15.Text = "♣";

            }
            else if (turno == 3)
            {
                turno = 1;
                btn15.Enabled = false;
                btn15.Text = "♪";

            }
            score6x6();
        }

        private void btn16_Click(object sender, EventArgs e)
        {
            if (turno == 1)
            {
                turno = 2;
                btn16.Enabled = false;
                btn16.Text = "X";
            }
            else if (turno == 2)
            {
                turno = 3;
                btn16.Enabled = false;
                btn16.Text = "♣";

            }
            else if (turno == 3)
            {
                turno = 1;
                btn16.Enabled = false;
                btn16.Text = "♪";

            }
            score6x6();
        }

        private void btn17_Click(object sender, EventArgs e)
        {
            if (turno == 1)
            {
                turno = 2;
                btn17.Enabled = false;
                btn17.Text = "X";
            }
            else if (turno == 2)
            {
                turno = 3;
                btn17.Enabled = false;
                btn17.Text = "♣";

            }
            else if (turno == 3)
            {
                turno = 1;
                btn17.Enabled = false;
                btn17.Text = "♪";

            }
            score6x6();
        }

        private void btn18_Click(object sender, EventArgs e)
        {
            if (turno == 1)
            {
                turno = 2;
                btn18.Enabled = false;
                btn18.Text = "X";
            }
            else if (turno == 2)
            {
                turno = 3;
                btn18.Enabled = false;
                btn18.Text = "♣";

            }
            else if (turno == 3)
            {
                turno = 1;
                btn18.Enabled = false;
                btn18.Text = "♪";

            }
            score6x6();
        }

        private void btn19_Click(object sender, EventArgs e)
        {
            if (turno == 1)
            {
                turno = 2;
                btn19.Enabled = false;
                btn19.Text = "X";
            }
            else if (turno == 2)
            {
                turno = 3;
                btn19.Enabled = false;
                btn19.Text = "♣";

            }
            else if (turno == 3)
            {
                turno = 1;
                btn19.Enabled = false;
                btn19.Text = "♪";

            }
            score6x6();
        }

        private void btn20_Click(object sender, EventArgs e)
        {
            if (turno == 1)
            {
                turno = 2;
                btn20.Enabled = false;
                btn20.Text = "X";
            }
            else if (turno == 2)
            {
                turno = 3;
                btn20.Enabled = false;
                btn20.Text = "♣";

            }
            else if (turno == 3)
            {
                turno = 1;
                btn20.Enabled = false;
                btn20.Text = "♪";

            }
            score6x6();
        }

        private void btn21_Click(object sender, EventArgs e)
        {
            if (turno == 1)
            {
                turno = 2;
                btn21.Enabled = false;
                btn21.Text = "X";
            }
            else if (turno == 2)
            {
                turno = 3;
                btn21.Enabled = false;
                btn21.Text = "♣";

            }
            else if (turno == 3)
            {
                turno = 1;
                btn21.Enabled = false;
                btn21.Text = "♪";

            }
            score6x6();
        }

        private void btn22_Click(object sender, EventArgs e)
        {
            if (turno == 1)
            {
                turno = 2;
                btn22.Enabled = false;
                btn22.Text = "X";
            }
            else if (turno == 2)
            {
                turno = 3;
                btn22.Enabled = false;
                btn22.Text = "♣";

            }
            else if (turno == 3)
            {
                turno = 1;
                btn22.Enabled = false;
                btn22.Text = "♪";

            }
            score6x6();
        }

        private void btn23_Click(object sender, EventArgs e)
        {
            if (turno == 1)
            {
                turno = 2;
                btn23.Enabled = false;
                btn23.Text = "X";
            }
            else if (turno == 2)
            {
                turno = 3;
                btn23.Enabled = false;
                btn23.Text = "♣";

            }
            else if (turno == 3)
            {
                turno = 1;
                btn23.Enabled = false;
                btn23.Text = "♪";

            }
            score6x6();
        }

        private void btn24_Click(object sender, EventArgs e)
        {
            if (turno == 1)
            {
                turno = 2;
                btn24.Enabled = false;
                btn24.Text = "X";
            }
            else if (turno == 2)
            {
                turno = 3;
                btn24.Enabled = false;
                btn24.Text = "♣";

            }
            else if (turno == 3)
            {
                turno = 1;
                btn24.Enabled = false;
                btn24.Text = "♪";

            }
            score6x6();
        }

        private void btn25_Click(object sender, EventArgs e)
        {
            if (turno == 1)
            {
                turno = 2;
                btn25.Enabled = false;
                btn25.Text = "X";
            }
            else if (turno == 2)
            {
                turno = 3;
                btn25.Enabled = false;
                btn25.Text = "♣";

            }
            else if (turno == 3)
            {
                turno = 1;
                btn25.Enabled = false;
                btn25.Text = "♪";

            }
            score6x6();
        }

        private void btn26_Click(object sender, EventArgs e)
        {
            if (turno == 1)
            {
                turno = 2;
                btn26.Enabled = false;
                btn26.Text = "X";
            }
            else if (turno == 2)
            {
                turno = 3;
                btn26.Enabled = false;
                btn26.Text = "♣";

            }
            else if (turno == 3)
            {
                turno = 1;
                btn26.Enabled = false;
                btn26.Text = "♪";

            }
            score6x6();
        }

        private void btn27_Click(object sender, EventArgs e)
        {
            if (turno == 1)
            {
                turno = 2;
                btn27.Enabled = false;
                btn27.Text = "X";
            }
            else if (turno == 2)
            {
                turno = 3;
                btn27.Enabled = false;
                btn27.Text = "♣";

            }
            else if (turno == 3)
            {
                turno = 1;
                btn27.Enabled = false;
                btn27.Text = "♪";

            }
            score6x6();
        }

        private void btn28_Click(object sender, EventArgs e)
        {
            if (turno == 1)
            {
                turno = 2;
                btn28.Enabled = false;
                btn28.Text = "X";
            }
            else if (turno == 2)
            {
                turno = 3;
                btn28.Enabled = false;
                btn28.Text = "♣";

            }
            else if (turno == 3)
            {
                turno = 1;
                btn28.Enabled = false;
                btn28.Text = "♪";

            }
            score6x6();
        }

        private void btn29_Click(object sender, EventArgs e)
        {
            if (turno == 1)
            {
                turno = 2;
                btn29.Enabled = false;
                btn29.Text = "X";
            }
            else if (turno == 2)
            {
                turno = 3;
                btn29.Enabled = false;
                btn29.Text = "♣";

            }
            else if (turno == 3)
            {
                turno = 1;
                btn29.Enabled = false;
                btn29.Text = "♪";

            }
            score6x6();
        }

        private void btn30_Click(object sender, EventArgs e)
        {
            if (turno == 1)
            {
                turno = 2;
                btn30.Enabled = false;
                btn30.Text = "X";
            }
            else if (turno == 2)
            {
                turno = 3;
                btn30.Enabled = false;
                btn30.Text = "♣";

            }
            else if (turno == 3)
            {
                turno = 1;
                btn30.Enabled = false;
                btn30.Text = "♪";

            }
            score6x6();
        }

        private void btn32_Click(object sender, EventArgs e)
        {
            if (turno == 1)
            {
                turno = 2;
                btn32.Enabled = false;
                btn32.Text = "X";
            }
            else if (turno == 2)
            {
                turno = 3;
                btn32.Enabled = false;
                btn32.Text = "♣";

            }
            else if (turno == 3)
            {
                turno = 1;
                btn32.Enabled = false;
                btn32.Text = "♪";

            }
            score6x6();
        }

        private void btn33_Click(object sender, EventArgs e)
        {
            if (turno == 1)
            {
                turno = 2;
                btn33.Enabled = false;
                btn33.Text = "X";
            }
            else if (turno == 2)
            {
                turno = 3;
                btn33.Enabled = false;
                btn33.Text = "♣";

            }
            else if (turno == 3)
            {
                turno = 1;
                btn33.Enabled = false;
                btn33.Text = "♪";

            }
            score6x6();
        }

        private void btn34_Click(object sender, EventArgs e)
        {
            if (turno == 1)
            {
                turno = 2;
                btn34.Enabled = false;
                btn34.Text = "X";
            }
            else if (turno == 2)
            {
                turno = 3;
                btn34.Enabled = false;
                btn34.Text = "♣";

            }
            else if (turno == 3)
            {
                turno = 1;
                btn34.Enabled = false;
                btn34.Text = "♪";

            }
            score6x6();
        }

        private void btn35_Click(object sender, EventArgs e)
        {
            if (turno == 1)
            {
                turno = 2;
                btn35.Enabled = false;
                btn35.Text = "X";
            }
            else if (turno == 2)
            {
                turno = 3;
                btn35.Enabled = false;
                btn35.Text = "♣";

            }
            else if (turno == 3)
            {
                turno = 1;
                btn35.Enabled = false;
                btn35.Text = "♪";

            }
        }

        private void btn36_Click(object sender, EventArgs e)
        {
            if (turno == 1)
            {
                turno = 2;
                btn36.Enabled = false;
                btn36.Text = "X";
            }
            else if (turno == 2)
            {
                turno = 3;
                btn36.Enabled = false;
                btn36.Text = "♣";

            }
            else if (turno == 3)
            {
                turno = 1;
                btn36.Enabled = false;
                btn36.Text = "♪";

            }

            score6x6();
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
            btn17.Enabled = true;
            btn18.Enabled = true;
            btn19.Enabled = true;
            btn20.Enabled = true;
            btn21.Enabled = true;
            btn22.Enabled = true;
            btn23.Enabled = true;
            btn24.Enabled = true;
            btn25.Enabled = true;
            btn26.Enabled = true;
            btn27.Enabled = true;
            btn28.Enabled = true;
            btn29.Enabled = true;
            btn30.Enabled = true;
            btn31.Enabled = true;
            btn32.Enabled = true;
            btn33.Enabled = true;
            btn34.Enabled = true;
            btn35.Enabled = true;
            btn36.Enabled = true;


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
            btn17.Text = "";
            btn18.Text = "";
            btn19.Text = "";
            btn20.Text = "";
            btn21.Text = "";
            btn22.Text = "";
            btn23.Text = "";
            btn24.Text = "";
            btn25.Text = "";
            btn26.Text = "";
            btn27.Text = "";
            btn28.Text = "";
            btn29.Text = "";
            btn30.Text = "";
            btn31.Text = "";
            btn32.Text = "";
            btn33.Text = "";
            btn34.Text = "";
            btn35.Text = "";
            btn36.Text = "";
            


            lblEquipoX.Text = "0";
            lblEquipoMusica.Text = "0";
            lblEquiporTrebol.Text = "0";
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
            btn17.BackColor = Color.White;
            btn18.BackColor = Color.White;
            btn19.BackColor = Color.White;
            btn20.BackColor = Color.White;
            btn21.BackColor = Color.White;
            btn22.BackColor = Color.White;
            btn23.BackColor = Color.White;
            btn24.BackColor = Color.White;
            btn25.BackColor = Color.White;
            btn26.BackColor = Color.White;
            btn27.BackColor = Color.White;
            btn28.BackColor = Color.White;
            btn29.BackColor = Color.White;
            btn30.BackColor = Color.White;
            btn31.BackColor = Color.White;
            btn32.BackColor = Color.White;
            btn33.BackColor = Color.White;
            btn34.BackColor = Color.White;
            btn35.BackColor = Color.White;
            btn36.BackColor = Color.White;
        }

        private void button37_Click(object sender, EventArgs e)
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
            btn17.Enabled = true;
            btn18.Enabled = true;
            btn19.Enabled = true;
            btn20.Enabled = true;
            btn21.Enabled = true;
            btn22.Enabled = true;
            btn23.Enabled = true;
            btn24.Enabled = true;
            btn25.Enabled = true;
            btn26.Enabled = true;
            btn27.Enabled = true;
            btn28.Enabled = true;
            btn29.Enabled = true;
            btn30.Enabled = true;
            btn31.Enabled = true;
            btn32.Enabled = true;
            btn33.Enabled = true;
            btn34.Enabled = true;
            btn35.Enabled = true;
            btn36.Enabled = true;


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
            btn17.Text = "";
            btn18.Text = "";
            btn19.Text = "";
            btn20.Text = "";
            btn21.Text = "";
            btn22.Text = "";
            btn23.Text = "";
            btn24.Text = "";
            btn25.Text = "";
            btn26.Text = "";
            btn27.Text = "";
            btn28.Text = "";
            btn29.Text = "";
            btn30.Text = "";
            btn31.Text = "";
            btn32.Text = "";
            btn33.Text = "";
            btn34.Text = "";
            btn35.Text = "";
            btn36.Text = "";



 
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
            btn17.BackColor = Color.White;
            btn18.BackColor = Color.White;
            btn19.BackColor = Color.White;
            btn20.BackColor = Color.White;
            btn21.BackColor = Color.White;
            btn22.BackColor = Color.White;
            btn23.BackColor = Color.White;
            btn24.BackColor = Color.White;
            btn25.BackColor = Color.White;
            btn26.BackColor = Color.White;
            btn27.BackColor = Color.White;
            btn28.BackColor = Color.White;
            btn29.BackColor = Color.White;
            btn30.BackColor = Color.White;
            btn31.BackColor = Color.White;
            btn32.BackColor = Color.White;
            btn33.BackColor = Color.White;
            btn34.BackColor = Color.White;
            btn35.BackColor = Color.White;
            btn36.BackColor = Color.White;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
