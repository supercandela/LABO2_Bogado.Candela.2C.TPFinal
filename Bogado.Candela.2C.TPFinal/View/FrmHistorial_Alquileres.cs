using Entidades.Clases;
using Entidades.Controladores;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.Json;

namespace View
{
    public partial class FrmHistorial_Alquileres : Form
    {
        //para ubicar carpeta "Downloads" en la computadora que hostea la app
        public static readonly Guid Downloads = new Guid("374DE290-123F-4565-9164-39C4925E467B");
        [DllImport("shell32.dll", CharSet = CharSet.Unicode)]
        static extern int SHGetKnownFolderPath([MarshalAs(UnmanagedType.LPStruct)] Guid rfid,
        uint dwFlags, IntPtr hToken, out string pszPath);


        private Usuario user;
        private List<Alquiler> listaAlq;
        private Usuario_Controlador usuarioControlador;

        public FrmHistorial_Alquileres(Usuario user)
        {
            InitializeComponent();
            this.user = user;
            this.listaAlq = new List<Alquiler>();
            this.usuarioControlador = new Usuario_Controlador();
        }

        private void FrmHistorial_Alquileres_Load(object sender, EventArgs e)
        {
            this.lblSinPeliculas.Hide();
            this.dgvListado.Hide();
            this.ActualizarListadoDeAlquileres();
        }

        private void ActualizarListadoDeAlquileres()
        {
            this.dgvListado.Rows.Clear();
            this.GetListadoDeAlquileres();
            if (this.listaAlq is not null && this.listaAlq.Count > 0)
            {
                foreach (Alquiler alq in this.listaAlq)
                {
                    this.dgvListado.Rows.Add(alq.Id, alq.FechaInicio, alq.FechaFin, alq.TituloPelicula);
                }

                this.lblSinPeliculas.Hide();
                this.dgvListado.Show();
            }
            else
            {
                this.dgvListado.Hide();
                this.lblSinPeliculas.Show();
            }
        }

        private void GetListadoDeAlquileres()
        {
            try
            {
                this.listaAlq = this.usuarioControlador.GetHistorialDeAlquileres(this.user.Id);
                this.listaAlq = this.listaAlq.OrdenarPorFechaReciente();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lblGuardar_Click(object sender, EventArgs e)
        {
            if (this.listaAlq is not null && this.listaAlq.Count > 0)
            {
                DialogResult respuesta = MessageBox.Show("La siguiente acción sobreescribe cualquier versión anterior guardada. ¿Desea continuar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    StringBuilder sb = new StringBuilder();
                    foreach (Alquiler alq in listaAlq)
                    {
                        JsonSerializerOptions opciones = new JsonSerializerOptions();
                        opciones.WriteIndented = true;

                        sb.AppendLine(JsonSerializer.Serialize(alq, opciones));
                    
                    }
                    string downloads;
                    SHGetKnownFolderPath(Downloads, 0, IntPtr.Zero, out downloads);
                    File.WriteAllText(downloads + "\\listado_de_alquileres.json", sb.ToString());
                }
                else
                {
                    MessageBox.Show("No se guardó el archivo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("No hay elementos para guardar en archivo. Si realiza un alquiler, podrá guardar el registro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void lblVolver_Click(object sender, EventArgs e)
        {
            FrmHome_Socio formSocio = new FrmHome_Socio(this.user);
            formSocio.Show();
            this.Close();
        }
    }
}