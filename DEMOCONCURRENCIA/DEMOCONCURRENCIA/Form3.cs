using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DEMOCONCURRENCIA
{
    public partial class FrmControlProducto : Form
    {
        private int stock = 0;
        private object bloqueo = new();
        private SemaphoreSlim semaforo = new SemaphoreSlim(2);

        public FrmControlProducto()
        {
            InitializeComponent();
        }

        private void btnIngresarProductos_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                semaforo.Wait();
                lock (bloqueo)
                {
                    stock++;
                    Thread.Sleep(1000);

                    this.Invoke((MethodInvoker)delegate
                    {
                        TxtResultado.AppendText($"Producto ingresado. Stock actual: {stock}{Environment.NewLine}");
                    });

                    Monitor.Pulse(bloqueo);
                }
                semaforo.Release();
            });
        }

        private void btnCancelarProducto_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                lock (bloqueo)
                {
                    while (stock <= 0)
                    {
                        ActualizarResultado("Esperando stock...");
                        Monitor.Wait(bloqueo); 
                    }

                    if (stock > 0)
                    {
                        stock--;
                        Thread.Sleep(1000);

                        this.Invoke((MethodInvoker)delegate
                        {
                            TxtResultado.AppendText($"Producto cancelado. Stock actual: {stock}{Environment.NewLine}");
                        });
                    }
                }
            });
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                TxtResultado.AppendText($"Consulta de stock. Stock actual: {stock}{Environment.NewLine}");
            });
        }

        private void ActualizarResultado(string mensaje)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => ActualizarResultado(mensaje)));
                return;
            }
            TxtResultado.AppendText($"{DateTime.Now:HH:mm:ss.fff}: {mensaje}{Environment.NewLine}");
        }
    }
}
