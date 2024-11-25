namespace DEMOCONCURRENCIA
{
    partial class FrmControlProducto
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
            splitContainer1 = new SplitContainer();
            btnStock = new Button();
            btnCancelarProducto = new Button();
            btnIngresarProductos = new Button();
            TxtResultado = new TextBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.FromArgb(255, 255, 192);
            splitContainer1.Panel1.Controls.Add(btnStock);
            splitContainer1.Panel1.Controls.Add(btnCancelarProducto);
            splitContainer1.Panel1.Controls.Add(btnIngresarProductos);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(TxtResultado);
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 266;
            splitContainer1.TabIndex = 0;
            // 
            // btnStock
            // 
            btnStock.BackColor = Color.FromArgb(255, 192, 192);
            btnStock.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStock.Location = new Point(72, 314);
            btnStock.Name = "btnStock";
            btnStock.Size = new Size(75, 43);
            btnStock.TabIndex = 2;
            btnStock.Text = "Stock";
            btnStock.UseVisualStyleBackColor = false;
            btnStock.Click += btnStock_Click;
            // 
            // btnCancelarProducto
            // 
            btnCancelarProducto.BackColor = Color.FromArgb(255, 192, 192);
            btnCancelarProducto.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelarProducto.Location = new Point(38, 131);
            btnCancelarProducto.Name = "btnCancelarProducto";
            btnCancelarProducto.Size = new Size(150, 37);
            btnCancelarProducto.TabIndex = 1;
            btnCancelarProducto.Text = "Cancelar Producto";
            btnCancelarProducto.UseVisualStyleBackColor = false;
            btnCancelarProducto.Click += btnCancelarProducto_Click;
            // 
            // btnIngresarProductos
            // 
            btnIngresarProductos.BackColor = Color.FromArgb(255, 192, 192);
            btnIngresarProductos.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIngresarProductos.Location = new Point(38, 56);
            btnIngresarProductos.Name = "btnIngresarProductos";
            btnIngresarProductos.Size = new Size(150, 38);
            btnIngresarProductos.TabIndex = 0;
            btnIngresarProductos.Text = "IngresarProductos";
            btnIngresarProductos.UseVisualStyleBackColor = false;
            btnIngresarProductos.Click += btnIngresarProductos_Click;
            // 
            // TxtResultado
            // 
            TxtResultado.Location = new Point(3, 3);
            TxtResultado.Multiline = true;
            TxtResultado.Name = "TxtResultado";
            TxtResultado.Size = new Size(527, 447);
            TxtResultado.TabIndex = 2;
            // 
            // FrmControlProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Name = "FrmControlProducto";
            Text = "Control de Productos";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Button btnIngresarProductos;
        private Button btnStock;
        private Button btnCancelarProducto;
        private TextBox TxtResultado;
    }
}