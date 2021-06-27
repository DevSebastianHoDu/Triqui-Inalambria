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
    public partial class Triqui : Form
    {
        public Triqui()
        {
            InitializeComponent();
        }

        Boolean checker;
        int sumarUno;
        int contadorDeBotones;

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
        }


        void scoreTriqui3x3()
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


            else if (btn1.Text == "X" && btn4.Text == "X" && btn7.Text == "X")
            {
                btn1.BackColor = Color.Crimson;
                btn4.BackColor = Color.Crimson;
                btn7.BackColor = Color.Crimson;

                MessageBox.Show("El equipo X es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoX.Text) + 1;
                lblEquipoX.Text = Convert.ToString(sumarUno);
                disponibleFalse();
            }

            else if (btn2.Text == "X" && btn5.Text == "X" && btn8.Text == "X")
            {
                btn2.BackColor = Color.Crimson;
                btn5.BackColor = Color.Crimson;
                btn8.BackColor = Color.Crimson;

                MessageBox.Show("El equipo X es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoX.Text) + 1;
                lblEquipoX.Text = Convert.ToString(sumarUno);
                disponibleFalse();
            }

            else if (btn3.Text == "X" && btn6.Text == "X" && btn9.Text == "X")
            {
                btn3.BackColor = Color.Crimson;
                btn6.BackColor = Color.Crimson;
                btn9.BackColor = Color.Crimson;

                MessageBox.Show("El equipo X es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoX.Text) + 1;
                lblEquipoX.Text = Convert.ToString(sumarUno);
                disponibleFalse();
            }

            //DIAGONALES

            else if (btn1.Text == "X" && btn5.Text == "X" && btn9.Text == "X")
            {
                btn1.BackColor = Color.Crimson;
                btn5.BackColor = Color.Crimson;
                btn9.BackColor = Color.Crimson;

                MessageBox.Show("El equipo X es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoX.Text) + 1;
                lblEquipoX.Text = Convert.ToString(sumarUno);
                disponibleFalse();
            }

            else if (btn3.Text == "X" && btn5.Text == "X" && btn7.Text == "X")
            {
                btn3.BackColor = Color.Crimson;
                btn5.BackColor = Color.Crimson;
                btn7.BackColor = Color.Crimson;

                MessageBox.Show("El equipo X es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoX.Text) + 1;
                lblEquipoX.Text = Convert.ToString(sumarUno);
                disponibleFalse();
            }

            //===========================================================================================================
            //                                      EQUIPO "O"
            //===========================================================================================================



            else if (btn1.Text == "O" && btn2.Text == "O" && btn3.Text == "O")
            {
                btn1.BackColor = Color.Crimson;
                btn2.BackColor = Color.Crimson;
                btn3.BackColor = Color.Crimson;

                MessageBox.Show("El equipo O es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoO.Text) + 1;
                lblEquipoO.Text = Convert.ToString(sumarUno);
                disponibleFalse();

            }

            else if (btn4.Text == "O" && btn5.Text == "O" && btn6.Text == "O")
            {
                btn4.BackColor = Color.Crimson;
                btn5.BackColor = Color.Crimson;
                btn6.BackColor = Color.Crimson;

                MessageBox.Show("El equipo O es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoO.Text) + 1;
                lblEquipoO.Text = Convert.ToString(sumarUno);
                disponibleFalse();
            }


            else if (btn7.Text == "O" && btn8.Text == "O" && btn9.Text == "O")
            {
                btn7.BackColor = Color.Crimson;
                btn8.BackColor = Color.Crimson;
                btn9.BackColor = Color.Crimson;

                MessageBox.Show("El equipo O es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoO.Text) + 1;
                lblEquipoO.Text = Convert.ToString(sumarUno);
                disponibleFalse();
            }


            else if (btn1.Text == "O" && btn4.Text == "O" && btn7.Text == "O")
            {
                btn1.BackColor = Color.Crimson;
                btn4.BackColor = Color.Crimson;
                btn7.BackColor = Color.Crimson;

                MessageBox.Show("El equipo O es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoO.Text) + 1;
                lblEquipoO.Text = Convert.ToString(sumarUno);
                disponibleFalse();
            }

            else if (btn2.Text == "O" && btn5.Text == "O" && btn8.Text == "O")
            {
                btn2.BackColor = Color.Crimson;
                btn5.BackColor = Color.Crimson;
                btn8.BackColor = Color.Crimson;

                MessageBox.Show("El equipo X es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoO.Text) + 1;
                lblEquipoO.Text = Convert.ToString(sumarUno);
                disponibleFalse();
            }

            else if (btn3.Text == "O" && btn6.Text == "O" && btn9.Text == "O")
            {
                btn3.BackColor = Color.Crimson;
                btn6.BackColor = Color.Crimson;
                btn9.BackColor = Color.Crimson;

                MessageBox.Show("El equipo O es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoO.Text) + 1;
                lblEquipoO.Text = Convert.ToString(sumarUno);
                disponibleFalse();
            }

            //DIAGONALES

            else if (btn1.Text == "O" && btn5.Text == "O" && btn9.Text == "O")
            {
                btn1.BackColor = Color.Crimson;
                btn5.BackColor = Color.Crimson;
                btn9.BackColor = Color.Crimson;

                MessageBox.Show("El equipo O es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoO.Text) + 1;
                lblEquipoO.Text = Convert.ToString(sumarUno);
                disponibleFalse();
            }

            else if (btn3.Text == "O" && btn5.Text == "O" && btn7.Text == "O")
            {
                btn3.BackColor = Color.Crimson;
                btn5.BackColor = Color.Crimson;
                btn7.BackColor = Color.Crimson;

                MessageBox.Show("El equipo O es el Ganador!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumarUno = int.Parse(lblEquipoO.Text) + 1;
                lblEquipoO.Text = Convert.ToString(sumarUno);
                disponibleFalse();
            }

            else
            {
                contadorDeBotones++;

                if (contadorDeBotones == 9)
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

                    MessageBox.Show("Empate!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    sumarUno = int.Parse(lblEmpates.Text) + 1;
                    lblEmpates.Text = Convert.ToString(sumarUno);
                    disponibleFalse();
                    

                   
                }
            }

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
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
            scoreTriqui3x3();
            btn1.Enabled = false;
        }

        private void btn1_Click_1(object sender, EventArgs e)
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
            scoreTriqui3x3();
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
            scoreTriqui3x3();
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
            scoreTriqui3x3();
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
            scoreTriqui3x3();
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
            scoreTriqui3x3();
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
            scoreTriqui3x3();
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
            scoreTriqui3x3();
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
            scoreTriqui3x3();
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
            scoreTriqui3x3();
            btn9.Enabled = false;
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


            btn1.Text = "";
            btn2.Text = "";
            btn3.Text = "";
            btn4.Text = "";
            btn5.Text = "";
            btn6.Text = "";
            btn7.Text = "";
            btn8.Text = "";
            btn9.Text = "";

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
        }

        private void btnNuevoJuego_Click_1(object sender, EventArgs e)
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


            btn1.Text = "";
            btn2.Text = "";
            btn3.Text = "";
            btn4.Text = "";
            btn5.Text = "";
            btn6.Text = "";
            btn7.Text = "";
            btn8.Text = "";
            btn9.Text = "";

            lblEquipoX.Text = "0";
            lblEquipoO.Text = "0";
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
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aplicacion creada por Sebastian Hoyos!", "TRIQUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void panel5_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Triqui_Load(object sender, EventArgs e)
        {

        }
    }
}
