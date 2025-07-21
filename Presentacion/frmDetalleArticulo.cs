using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;

namespace Presentacion
{
    public partial class frmDetalle : Form
    {
        private Articulo articulo;
        public frmDetalle(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
        }

        private void frmDetalle_Load(object sender, EventArgs e)
        {
            if(articulo != null)
            {
                {
                    lblCodDetalle2.Text = articulo.Codigo;
                    lblNombreDetalle.Text = articulo.Nombre;
                    lblNombreDetalle.Left = (this.ClientSize.Width - lblNombreDetalle.Width) / 2;
                    lblDescDetalle.Text = articulo.Descripcion;
                    lblDescDetalle.Left = (this.ClientSize.Width - lblDescDetalle.Width) / 2;
                    lblMarcaDetalle2.Text = articulo.Marca.Descripcion;
                    lblCatDetalle2.Text = articulo.Categoria.Descripcion;
                    lblPrecioDetalle2.Text = articulo.Precio.ToString("N2");

                    try
                    {
                        pbxDetalle.Load(articulo.ImagenUrl);
                    }
                    catch
                    {
                        pbxDetalle.Load("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRQPpf7UgQjAfrXDj_965DrqqKv00L6FLO5yBDhy2rLXFDAQAxUnA7C0f7UN4gZMi72cEE&usqp=CAU");
                    }
                }
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
