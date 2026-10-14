using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DATOS;
using entidades;
using LOGICA;
namespace VISTA
{
    public partial class FrmPreguntasSeguridad : Form
    {
        public FrmPreguntasSeguridad(int IdUsuario)
        {
            IdusuarioSeleccionado = IdUsuario;
            InitializeComponent();
        }
        private int IdusuarioSeleccionado;
        private TextBox[] respuestas; 
        private void FrmPreguntasSeguridad_Load(object sender, EventArgs e)
        {
            ListarPreguntaSeguridadLogica listar = new ListarPreguntaSeguridadLogica();
            List<PreguntaSeguridad> preguntaSeguridads = new List<PreguntaSeguridad>();
            
            preguntaSeguridads = listar.Listar();
            respuestas = new TextBox[] { txtrespuesta1, txtrespuesta2, txtrespuesta3, txtrespuesta4, txtrespuesta5 };
            Label[] pregunta= { lblpregunta1, lblpregunta2, lblpregunta3, lblpregunta4, lblpregunta5 };
            for (int i = 0; i < 5; ++i)
            {
                pregunta[i].Text = preguntaSeguridads[i].Pregunta;
            }
        }
        private void btnenviar_Click(object sender, EventArgs e)
        {
          
        }
    }
}
