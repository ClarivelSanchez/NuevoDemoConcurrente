namespace DEMOCONCURRENCIA
{
    partial class FrmBloqueos
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
            BtnIncrementar = new Button();
            LblContador = new Label();
            BtnDisminuir = new Button();
            splitContainer1 = new SplitContainer();
            TxtResultado = new TextBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // BtnIncrementar
            // 
            BtnIncrementar.BackColor = Color.FromArgb(255, 192, 255);
            BtnIncrementar.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnIncrementar.Location = new Point(21, 22);
            BtnIncrementar.Name = "BtnIncrementar";
            BtnIncrementar.Size = new Size(108, 40);
            BtnIncrementar.TabIndex = 0;
            BtnIncrementar.Text = "Incrementar";
            BtnIncrementar.UseVisualStyleBackColor = false;
            BtnIncrementar.Click += BtnIncrementar_Click;
            // 
            // LblContador
            // 
            LblContador.AutoSize = true;
            LblContador.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblContador.Location = new Point(67, 177);
            LblContador.Name = "LblContador";
            LblContador.Size = new Size(16, 20);
            LblContador.TabIndex = 1;
            LblContador.Text = "0";
            // 
            // BtnDisminuir
            // 
            BtnDisminuir.BackColor = Color.FromArgb(255, 224, 192);
            BtnDisminuir.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnDisminuir.Location = new Point(21, 102);
            BtnDisminuir.Name = "BtnDisminuir";
            BtnDisminuir.Size = new Size(108, 37);
            BtnDisminuir.TabIndex = 2;
            BtnDisminuir.Text = "Disminuir";
            BtnDisminuir.UseVisualStyleBackColor = false;
            BtnDisminuir.Click += BtnDisminuir_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(12, 12);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(BtnIncrementar);
            splitContainer1.Panel1.Controls.Add(LblContador);
            splitContainer1.Panel1.Controls.Add(BtnDisminuir);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(TxtResultado);
            splitContainer1.Size = new Size(481, 261);
            splitContainer1.SplitterDistance = 160;
            splitContainer1.TabIndex = 3;
            // 
            // TxtResultado
            // 
            TxtResultado.Location = new Point(3, 3);
            TxtResultado.Multiline = true;
            TxtResultado.Name = "TxtResultado";
            TxtResultado.Size = new Size(310, 254);
            TxtResultado.TabIndex = 1;
            // 
            // FrmBloqueos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            ClientSize = new Size(506, 292);
            Controls.Add(splitContainer1);
            Name = "FrmBloqueos";
            Text = "Gestion de bloqueos";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button BtnIncrementar;
        private Label LblContador;
        private Button BtnDisminuir;
        private SplitContainer splitContainer1;
        private TextBox TxtResultado;
    }
}