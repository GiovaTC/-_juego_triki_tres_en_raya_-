namespace TrikiApp
{
    partial class Form1
    {
        /// <summary>
        /// Variable requerida por el diseñador.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Liberar recursos.
        /// </summary>
        /// <param name="disposing">true si se deben liberar recursos administrados.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método requerido para el Diseñador.
        /// </summary>
        private void InitializeComponent()
        {
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();

            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();

            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();

            label1 = new Label();
            btnReiniciar = new Button();

            SuspendLayout();

            // ======================================================
            // LABEL TITULO
            // ======================================================

            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.Location = new Point(150, 20);
            label1.Name = "label1";
            label1.Size = new Size(180, 32);
            label1.TabIndex = 0;
            label1.Text = "Juego Triki";

            // ======================================================
            // BOTON REINICIAR
            // ======================================================

            btnReiniciar.Location = new Point(170, 70);
            btnReiniciar.Name = "btnReiniciar";
            btnReiniciar.Size = new Size(120, 40);
            btnReiniciar.TabIndex = 1;
            btnReiniciar.Text = "Reiniciar";
            btnReiniciar.UseVisualStyleBackColor = true;
            btnReiniciar.Click += btnReiniciar_Click;

            // ======================================================
            // FILA 1
            // ======================================================

            btn1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            btn1.Location = new Point(80, 140);
            btn1.Name = "btn1";
            btn1.Size = new Size(80, 80);
            btn1.TabIndex = 2;
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += new EventHandler(this.ClickBoton);

            btn2.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            btn2.Location = new Point(190, 140);
            btn2.Name = "btn2";
            btn2.Size = new Size(80, 80);
            btn2.TabIndex = 3;
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += new EventHandler(this.ClickBoton);

            btn3.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            btn3.Location = new Point(300, 140);
            btn3.Name = "btn3";
            btn3.Size = new Size(80, 80);
            btn3.TabIndex = 4;
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += new EventHandler(this.ClickBoton);

            // ======================================================
            // FILA 2
            // ======================================================

            btn4.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            btn4.Location = new Point(80, 240);
            btn4.Name = "btn4";
            btn4.Size = new Size(80, 80);
            btn4.TabIndex = 5;
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += new EventHandler(this.ClickBoton);

            btn5.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            btn5.Location = new Point(190, 240);
            btn5.Name = "btn5";
            btn5.Size = new Size(80, 80);
            btn5.TabIndex = 6;
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += new EventHandler(this.ClickBoton);

            btn6.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            btn6.Location = new Point(300, 240);
            btn6.Name = "btn6";
            btn6.Size = new Size(80, 80);
            btn6.TabIndex = 7;
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += new EventHandler(this.ClickBoton);

            // ======================================================
            // FILA 3
            // ======================================================

            btn7.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            btn7.Location = new Point(80, 340);
            btn7.Name = "btn7";
            btn7.Size = new Size(80, 80);
            btn7.TabIndex = 8;
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += new EventHandler(this.ClickBoton);

            btn8.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            btn8.Location = new Point(190, 340);
            btn8.Name = "btn8";
            btn8.Size = new Size(80, 80);
            btn8.TabIndex = 9;
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += new EventHandler(this.ClickBoton);

            btn9.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            btn9.Location = new Point(300, 340);
            btn9.Name = "btn9";
            btn9.Size = new Size(80, 80);
            btn9.TabIndex = 10;
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += new EventHandler(this.ClickBoton);

            // ======================================================
            // FORMULARIO
            // ======================================================

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;

            ClientSize = new Size(470, 470);

            Controls.Add(label1);

            Controls.Add(btn1);
            Controls.Add(btn2);
            Controls.Add(btn3);

            Controls.Add(btn4);
            Controls.Add(btn5);
            Controls.Add(btn6);

            Controls.Add(btn7);
            Controls.Add(btn8);
            Controls.Add(btn9);

            Controls.Add(btnReiniciar);

            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Triki - Tres en Raya";

            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn1;
        private Button btn2;
        private Button btn3;

        private Button btn4;
        private Button btn5;
        private Button btn6;

        private Button btn7;
        private Button btn8;
        private Button btn9;

        private Label label1;
        private Button btnReiniciar;
    }
}