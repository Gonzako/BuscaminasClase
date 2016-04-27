using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BuscaMinas
{
    public partial class Form1 : Form
    {
        static int N = 0, M = 0;
        Random rand;
        public bool[,] visitadas; // constructor
        public Button[,] campoBotones;
        int[,] m; // 9: mina;0-8:minas alrededor
        private int Porcentaje;

        public Form1() {
            InitializeComponent();
            rand = new Random();
        }

        private void ReiniciaJuego() {
            visitadas = new bool[N, M];  // De las filas y columnas 1 a la N-1
            campoBotones = new Button[N, M];  // De las filas y columnas 1 a la N-1
            m = new int[N, M]; 
            for (int i = 0; i < N; i++)
                for (int j = 0; j < M; j++) {
                    visitadas[i, j] = false;
                    m[i, j] = 0;
                }
            for (int i = 0; i < N; i++) visitadas[i, 0] = visitadas[i, M-1] = true;
            for (int i = 0; i < M; i++) visitadas[0, i] = visitadas[N-1, i] = true;
            creaCampo();
            ubicaMinas();
            cuentaMinas();
        }

        private void ReiniciaControl() {
            for (int i = 1; i < N-1; i++)
                for (int j = 1; j < M-1; j++)
                    Controls.Remove(campoBotones[i, j]);
        }

        private void creaCampo() {
            int y = 75; int x;
            for (int i = 1; i < N-1; i++) {
                x = 10;
                for (int j = 1; j < M-1; j++) {
                    campoBotones[i, j] = new Button();
                    campoBotones[i, j].Tag = i * 100 + j;
                    campoBotones[i, j].Left = x;
                    campoBotones[i, j].Top = y;
                    campoBotones[i, j].Height = campoBotones[i, j].Width = 25;
                    x += 25;
                    campoBotones[i, j].MouseDown += OnClickButton;
                    Controls.Add(campoBotones[i, j]);
                }
                y += 25;
            }
        } // fin metodo

        protected void OnClickButton(object sender, MouseEventArgs e) {
            Button b = (Button)sender;
            int fila = Convert.ToInt32(b.Tag) / 100;
            int columna = Convert.ToInt32(b.Tag) % 100;
            switch (e.Button) {
                case MouseButtons.Left:
                    if (b.Text != "x") {
                        if (m[fila, columna] == 9)
                        {
                            b.Text = "B";
                            b.BackColor = Color.DarkRed;
                            verMinas();
                            b.Refresh();
                            MessageBox.Show("¡Boooooooooooooomba!");
                            ReiniciaControl();
                            ReiniciaJuego();
                        } else {
                            if (m[fila, columna] != 0) {
                                b.Text = "" + m[fila, columna];
                                visitadas[fila, columna] = true;
                                b.Enabled = false;
                            }
                            else escampa(fila, columna);
                        }
                    }
                    break;
                case MouseButtons.Right:
                    if (b.Text == "x") { 
                        b.Text = ""; 
                        visitadas[fila, columna] = false; 
                    } else { 
                        b.Text = "x"; 
                        visitadas[fila, columna] = true; 
                    }
                    if (esGanador()) {
                        MessageBox.Show("¡Has derrotado al campo de minas!");
                        ReiniciaControl();
                        ReiniciaJuego();
                    }
                    break;
            }
        }

        private void verMinas() {
            for (int i = 1; i < N-1; i++)
                for (int j = 1; j < M-1; j++)
                    if (m[i, j] == 9) campoBotones[i, j].Text = "B";
        }

        private bool esGanador() {
            for (int i = 1; i < N-1; i++)
                for (int j = 1; j < M-1; j++)
                    if (m[i,j] == 9 && campoBotones[i,j].Text!="x") return false;
            return true;
        }

        private void cuentaMinas()
        {
            for (byte x = 1; x < N-1; x++)
            {
                for (byte y = 1; y < M-1; y++)
                {
                    if (m[x, y] == 9)
                    {
                        for (int i = -1; i <= 1; i++)
                        {
                            for (int j = -1; j<= 1; j++)
                            {
                                if (m[x-i, y-j] != 9)
                                {
                                    m[x - i, y - j]++;
                                }
                            }
                        }
                    }
                }
                
            }
        }  

        private void ubicaMinas()
        {
            int x;
            int y;
            for (byte i = 0; i < (((N - 2) * (M - 2) / 100) * Porcentaje); i++)
            {
                x = rand.Next(1, N - 1);
                y = rand.Next(1, M - 1);
                if (m[x, y] != 9)
                {
                    m[x, y] = 9;
                } else
                {
                    i--;
                }
            }
            //Coloca una mina aleatoriamente en el campo, si ya está ocupada por otra mina, repite el proceso.
        }

        private void escampa(int x, int y) {
                //Causa problemas, arreglar cuanto antes.
                visitadas[x, y] = true;
                campoBotones[x, y].Enabled = false;

                for (int i = -1; i <= 1; i++)
                {
                    for (int j = -1; j <= 1; j++)
                    {
                        if (x - i < N - 1 && y - j < M - 1 && x - i > 0 && y - j > 0)
                        {
                            if (m[x - i, y - j] != 0)
                            {
                                campoBotones[x - i, y - j].Text = "" + m[x - i, y - j];
                                visitadas[x - i, y - j] = true;
                                campoBotones[x - i, y - j].Enabled = false;
                            }
                            else
                            {
                                escampa(x - i, y - j);
                            }
                        }
                    }
                }
            

        }

        private void button1_Click(object sender, EventArgs e) {
            ReiniciaControl();
            N = (int) nfilasNUD.Value + 2; // 2 filas extras para facilitar las busquedas
            M = (int) ncolumnasNUD.Value + 2;  // 2 columnas extras para facilitar las búsquedas
            Porcentaje = (int) porcentajeMinasNUD.Value;
            Form1.ActiveForm.Left = 0;
            Form1.ActiveForm.Top = 0;
            Form1.ActiveForm.Width = 25 * (M - 2) + 36;
            Form1.ActiveForm.Height = 25 * (N - 2) + 130;
            ReiniciaJuego();
        }
    }
}

