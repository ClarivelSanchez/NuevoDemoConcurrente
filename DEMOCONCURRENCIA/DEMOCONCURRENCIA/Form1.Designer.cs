namespace DEMOCONCURRENCIA
{
    partial class FrmConcurrencia
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            splitContainer1 = new SplitContainer();
            BtnCancelarProcesos = new Button();
            BtnIniciarTarea = new Button();
            BtnHilos = new Button();
            BtnSecuencial = new Button();
            TxtResultado = new TextBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(12, 12);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(BtnCancelarProcesos);
            splitContainer1.Panel1.Controls.Add(BtnIniciarTarea);
            splitContainer1.Panel1.Controls.Add(BtnHilos);
            splitContainer1.Panel1.Controls.Add(BtnSecuencial);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(TxtResultado);
            splitContainer1.Size = new Size(776, 381);
            splitContainer1.SplitterDistance = 258;
            splitContainer1.TabIndex = 1;
            // 
            // BtnCancelarProcesos
            // 
            BtnCancelarProcesos.BackColor = Color.FromArgb(255, 192, 192);
            BtnCancelarProcesos.Font = new Font("Algerian", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnCancelarProcesos.Location = new Point(40, 316);
            BtnCancelarProcesos.Name = "BtnCancelarProcesos";
            BtnCancelarProcesos.Size = new Size(174, 49);
            BtnCancelarProcesos.TabIndex = 3;
            BtnCancelarProcesos.Text = "Cancelar Procesos";
            BtnCancelarProcesos.UseVisualStyleBackColor = false;
            BtnCancelarProcesos.Click += BtnCancelarProcesos_Click;
            // 
            // BtnIniciarTarea
            // 
            BtnIniciarTarea.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BtnIniciarTarea.BackColor = Color.FromArgb(255, 255, 192);
            BtnIniciarTarea.Font = new Font("Algerian", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnIniciarTarea.Location = new Point(40, 188);
            BtnIniciarTarea.Name = "BtnIniciarTarea";
            BtnIniciarTarea.Size = new Size(174, 45);
            BtnIniciarTarea.TabIndex = 2;
            BtnIniciarTarea.Text = "Iniciar Tarea";
            BtnIniciarTarea.UseVisualStyleBackColor = false;
            BtnIniciarTarea.Click += BtnIniciarTarea_Click;
            // 
            // BtnHilos
            // 
            BtnHilos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BtnHilos.BackColor = Color.FromArgb(255, 255, 192);
            BtnHilos.Font = new Font("Algerian", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnHilos.Location = new Point(40, 118);
            BtnHilos.Name = "BtnHilos";
            BtnHilos.Size = new Size(174, 47);
            BtnHilos.TabIndex = 1;
            BtnHilos.Text = "Iniciar Hilos";
            BtnHilos.UseVisualStyleBackColor = false;
            BtnHilos.Click += BtnHilos_Click;
            // 
            // BtnSecuencial
            // 
            BtnSecuencial.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BtnSecuencial.BackColor = Color.FromArgb(255, 255, 192);
            BtnSecuencial.Font = new Font("Algerian", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnSecuencial.Location = new Point(40, 24);
            BtnSecuencial.Name = "BtnSecuencial";
            BtnSecuencial.Size = new Size(174, 74);
            BtnSecuencial.TabIndex = 0;
            BtnSecuencial.Text = "Iniciar Secuencial";
            BtnSecuencial.UseVisualStyleBackColor = false;
            BtnSecuencial.Click += BtnSecuencial_Click;
            // 
            // TxtResultado
            // 
            TxtResultado.Location = new Point(3, 3);
            TxtResultado.Multiline = true;
            TxtResultado.Name = "TxtResultado";
            TxtResultado.Size = new Size(508, 375);
            TxtResultado.TabIndex = 0;
            // 
            // FrmConcurrencia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(795, 401);
            Controls.Add(splitContainer1);
            Name = "FrmConcurrencia";
            Text = "FrmDemostracion De Concurrencia";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Button BtnSecuencial;
        private TextBox TxtResultado;
        private Button BtnIniciarTarea;
        private Button BtnHilos;
        private Button BtnCancelarProcesos;
    }
}
