namespace TrikiApp
{
    public partial class Form1 : Form
    {
        bool turnoX = true;
        int movimientos = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void ClickBoton(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (btn.Text != "")
                return;

            if (turnoX) 
                btn.Text = "X";
            else
                btn.Text = "O";

            turnoX = !turnoX;
            movimientos++;

            VerificarGanador();
        }

        private void VerificarGanador()
        {
            Button[] b =
            {
                btn1, btn2, btn3, 
                btn4, btn5, btn6, 
                btn7, btn8, btn9 
            };

            int[,] combinaciones =
            {
                {0, 1, 2}, 
                {3, 4, 5}, 
                {6, 7, 8}, // filas
                {0, 3, 6}, 
                {1, 4, 7}, 
                {2, 5, 8}, // columnas
                {0, 4, 8}, 
                {2, 4, 6}  // diagonales
            };

            for (int i = 0; i < combinaciones.GetLength(0); i++)
            {
                int a = combinaciones[i, 0];
                int c = combinaciones[i, 1];
                int d = combinaciones[i, 2];
                if (b[combinaciones[i, 0]].Text != "" &&
                    b[combinaciones[i, 0]].Text == b[combinaciones[i, 1]].Text &&
                    b[combinaciones[i, 1]].Text == b[combinaciones[i, 2]].Text)
                {
                    MessageBox.Show(
                      "GANADOR: " + b[a].Text);

                    DeshabilitarBotones();
                    return;
                }
            }

            if (movimientos == 9)
            {
                MessageBox.Show("EMPATE");
            }
        }

        private void DeshabilitarBotones()
        {
            foreach (Control c in Controls)
            {
                if (c is Button btn &&
                    btn.Name != "btnReiniciar")
                {
                    btn.Enabled = false;
                }
            }
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            foreach (Control c in Controls)
            {
                if (c is Button btn &&
                    btn.Name != "btnReiniciar")
                {
                    btn.Text = "";
                    btn.Enabled = true;
                }
            }

            turnoX = true;
            movimientos = 0;
        }

     /*   private void Form1_Load(object sender, EventArgs e)
        {

        }*/
    }
}
