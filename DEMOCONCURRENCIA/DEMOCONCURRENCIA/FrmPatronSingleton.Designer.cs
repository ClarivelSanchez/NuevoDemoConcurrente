namespace DEMOCONCURRENCIA
{
    partial class FrmPatronSingleton
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAsignar = new Button();
            btnRecuperar = new Button();
            TxtCadenadeConexion = new TextBox();
            label1 = new Label();
            lblCadenaConexionRecuperada = new Label();
            SuspendLayout();
            // 
            // btnAsignar
            // 
            btnAsignar.Location = new Point(99, 100);
            btnAsignar.Name = "btnAsignar";
            btnAsignar.Size = new Size(105, 62);
            btnAsignar.TabIndex = 0;
            btnAsignar.Text = "Asignar cadena de conexion";
            btnAsignar.UseVisualStyleBackColor = true;
            btnAsignar.Click += btnAsignar_Click;
            // 
            // btnRecuperar
            // 
            btnRecuperar.Location = new Point(99, 198);
            btnRecuperar.Name = "btnRecuperar";
            btnRecuperar.Size = new Size(105, 58);
            btnRecuperar.TabIndex = 1;
            btnRecuperar.Text = "Obtener cadena de conexion";
            btnRecuperar.UseVisualStyleBackColor = true;
            btnRecuperar.Click += btnRecuperar_Click;
            // 
            // TxtCadenadeConexion
            // 
            TxtCadenadeConexion.Location = new Point(99, 57);
            TxtCadenadeConexion.Name = "TxtCadenadeConexion";
            TxtCadenadeConexion.Size = new Size(330, 23);
            TxtCadenadeConexion.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(99, 24);
            label1.Name = "label1";
            label1.Size = new Size(115, 15);
            label1.TabIndex = 3;
            label1.Text = "Cadena de conexion";
            // 
            // lblCadenaConexionRecuperada
            // 
            lblCadenaConexionRecuperada.AutoSize = true;
            lblCadenaConexionRecuperada.Location = new Point(99, 309);
            lblCadenaConexionRecuperada.Name = "lblCadenaConexionRecuperada";
            lblCadenaConexionRecuperada.Size = new Size(38, 15);
            lblCadenaConexionRecuperada.TabIndex = 4;
            lblCadenaConexionRecuperada.Text = "label2";
            // 
            // FrmPatronSingleton
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblCadenaConexionRecuperada);
            Controls.Add(label1);
            Controls.Add(TxtCadenadeConexion);
            Controls.Add(btnRecuperar);
            Controls.Add(btnAsignar);
            Name = "FrmPatronSingleton";
            Text = "FrmPatronSingleton";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAsignar;
        private Button btnRecuperar;
        private TextBox TxtCadenadeConexion;
        private Label label1;
        private Label lblCadenaConexionRecuperada;
    }
}