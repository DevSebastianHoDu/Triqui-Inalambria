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
using FontAwesome.Sharp;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        //FIELDS

        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form formularioHijoActual;

        public Form1()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
            //Form
            this.Text = string.Empty;
            //this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }


        //Metodos Botoenes

        private void ActivateButton(Object senderBtn , Color color)
        {
            if(senderBtn != null)
            {

                disableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                //Left Border Button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
        }


        private struct RGBColor
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 241);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }

        private void disableButton()
        {
            if(currentBtn != null)
            {
                currentBtn.BackColor = Color.MidnightBlue;
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.White;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;

            }
        }


        private void abrirFormularioHijo(Form formularioHijo)
        {
            if(formularioHijoActual != null)
            {
                formularioHijoActual.Close();
            }

            formularioHijoActual = formularioHijo;
            formularioHijo.TopLevel = false;
            formularioHijo.FormBorderStyle = FormBorderStyle.None;
            formularioHijo.Dock = DockStyle.Fill;
            panelEscritorio.Controls.Add(formularioHijo);
            panelEscritorio.Tag = formularioHijo;
            formularioHijo.BringToFront();
            formularioHijo.Show();

        }

        private void iconButtonPrincipal_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColor.color3);

            //abrirFormularioHijo(new Principal());
            try
            {

                formularioHijoActual.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ya estas en la ventana principal");
            }
        }

        private void iconTriquiClasico_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColor.color1);
            abrirFormularioHijo(new Triqui());
            iconButtonPrincipal.Enabled = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        //Drag Form

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int hMsg, int wParam, int lParam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            formularioHijoActual.Close();
           
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aplicacion creada por Sebastian Hoyos");
        }

        private void btnTriqui4x4_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColor.color2);
            abrirFormularioHijo(new Triqui4x4());
            iconButtonPrincipal.Enabled = true;
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColor.color3);
            abrirFormularioHijo(new GUITriqui6x6());
            iconButtonPrincipal.Enabled = true;
        }
    }
}
