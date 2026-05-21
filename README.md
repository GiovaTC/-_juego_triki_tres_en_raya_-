# -_juego_triki_tres_en_raya_- :.
Juego Triki (Tres en Raya):

<img width="1024" height="1024" alt="image" src="https://github.com/user-attachments/assets/4793024c-4c9e-4926-b25f-7d69ddce7be4" />  

```
C# + Windows Forms + Interfaz Grafica:
Ejemplo completo de un juego Triki desarrollado en:
Visual Studio 2022
C#
Windows Forms
Interfaz gráfica

1. Crear Proyecto:
Crear proyecto:
Windows Forms App (.NET Framework)
Nombre del proyecto:
TrikiApp

2. Diseño de la Interfaz:
En el formulario Form1 agregar:
9 botones
1 Label
1 Button para reiniciar
Distribución
BTN1   BTN2   BTN3
BTN4   BTN5   BTN6
BTN7   BTN8   BTN9

3. Código Form1.cs:
using System;
using System.Linq;
using System.Windows.Forms;

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
                {0,1,2},
                {3,4,5},
                {6,7,8},
                {0,3,6},
                {1,4,7},
                {2,5,8},
                {0,4,8},
                {2,4,6}
            };

            for (int i = 0; i < combinaciones.GetLength(0); i++)
            {
                int a = combinaciones[i, 0];
                int c = combinaciones[i, 1];
                int d = combinaciones[i, 2];

                if (b[a].Text != "" &&
                    b[a].Text == b[c].Text &&
                    b[c].Text == b[d].Text)
                {
                    MessageBox.Show(
                        "Ganador: " + b[a].Text);

                    DeshabilitarBotones();
                    return;
                }
            }

            if (movimientos == 9)
            {
                MessageBox.Show("Empate");
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
    }
}

4. Código Form1.Designer.cs:
Declaración de botones principales
private System.Windows.Forms.Button btn1;
private System.Windows.Forms.Button btn2;
private System.Windows.Forms.Button btn3;
private System.Windows.Forms.Button btn4;
private System.Windows.Forms.Button btn5;
private System.Windows.Forms.Button btn6;
private System.Windows.Forms.Button btn7;
private System.Windows.Forms.Button btn8;
private System.Windows.Forms.Button btn9;
private System.Windows.Forms.Button btnReiniciar;

5. Configuración Visual:
Configuración de cada botón
Size = 80,80
Font = 20 Bold
Evento Click
this.btn1.Click += new System.EventHandler(this.ClickBoton);

Aplicar el mismo evento a los 9 botones.

6. Resultado:

El sistema permitirá:

✅ Juego para 2 jugadores
✅ Detectar ganador
✅ Detectar empate
✅ Reiniciar partida
✅ Interfaz gráfica completa.

7. Vista Esperada:
 X | O | X
-----------
 O | X | O
-----------
 X |   | O

8. Mejoras Opcionales:
Puedes agregar:
IA contra computadora
Puntaje
Sonidos
Colores dinámicos
Base de datos Oracle 19c
Tiempo por turno
Animaciones

9. Estructura del Proyecto:
TrikiApp
│
├── Form1.cs
├── Form1.Designer.cs
├── Program.cs
└── Resources

10. Tecnologías Utilizadas:
C#
Windows Forms
.NET Framework
Visual Studio 2022

11. Funcionamiento General:
El flujo del juego funciona así:

El jugador presiona un botón.
El sistema coloca X u O.
Se valida si existe una combinación ganadora.
Si alguien gana:
Se muestra un mensaje.
Se bloquean los botones.
Si se completan los 9 movimientos:
El sistema declara empate.
El botón Reiniciar limpia el tablero .

12. Recomendaciones:
Buenas prácticas
Nombrar correctamente los controles.
Centralizar la lógica del juego.
Evitar duplicar código.
Usar métodos reutilizables.
Posibles mejoras empresariales
Arquitectura por capas
Persistencia en Oracle 19c
Ranking de jugadores
Historial de partidas
Multiplayer online
IA con Minimax

13. Ejemplo Visual del Tablero:
+---+---+---+
| X | O | X |
+---+---+---+
| O | X | O |
+---+---+---+
| X |   | O |
+---+---+---+

14. Conclusion:
Este proyecto permite aprender:
Eventos en Windows Forms
Manejo de botones
Programación orientada a objetos
Validación de lógica
Interfaces gráficas en C#
Desarrollo en Visual Studio 2022 .
:. . / .
