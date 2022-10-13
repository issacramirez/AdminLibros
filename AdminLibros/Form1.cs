using DataAccess.Manager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminLibros {
    public partial class Form1 : Form {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
        private readonly DateTime hoy = DateTime.Now;
        private readonly DateTime hace1mes = DateTime.Now.AddMonths(-1);

        public Form1() {
            InitializeComponent();
            CargarInicio();
        }

        private void CargarInicio() {
            datePickDesde.Value = hace1mes;
            datePickHasta.Value = hoy;
        }

        private void AltaRegistro() {
            try {
                DataManager manager = new DataManager(connectionString, (ConnectionType)1);

                List<PoolConnectionParameters> prm = llenarParametrosRegistro(1, DateTime.Now, DateTime.Now, Convert.ToInt64(txtCodigo.Text));
                var dataset = manager.ExecuteDataSet(CommandType.StoredProcedure, "[dbo].[SP_Registros]", prm);

                if (dataset.Tables[0].Rows.Count > 0) {
                    txtLibro.Text = dataset.Tables[0].Rows[0]["Titulo"].ToString();
                    txtAutor.Text = dataset.Tables[0].Rows[0]["Autor"].ToString();
                    txtFecha.Text = DateTime.Now.ToString("dd/MMMM/yyyy hh:mm:ss tt");
                }

                DialogResult result = MessageBox.Show("Registro Guardado", "BIEN");
                if (result == DialogResult.OK) {
                    txtCodigo.Text = "";
                    txtLibro.Text = "";
                    txtAutor.Text = "";
                    txtFecha.Text = "";
                }
            } catch (Exception ex) {
                MessageBox.Show("Error Alta de Libro, Exception: " + ex.Message, "ERROR");
            }
        }

        private void AltaLibro() {
            try {
                int BibId;
                if (!Int32.TryParse(numAgregarBibId.Value.ToString(), out BibId)) {
                    MessageBox.Show("Ingrese un BibId válido", "ERROR");
                    return;
                }
                if (BibId == 0) {
                    MessageBox.Show("Ingrese un BibId válido", "ERROR");
                    return;
                }

                int CodBarr;
                if (!Int32.TryParse(numAgregarCodBarr.Value.ToString(), out CodBarr)) {
                    MessageBox.Show("Ingrese un Código de Barras válido", "ERROR");
                    return;
                }
                if (CodBarr == 0) {
                    MessageBox.Show("Ingrese un Código de Barras válido", "ERROR");
                    return;
                }

                string ClasfEjemplar = txtAgregarClasEjem.Text;
                string ClasfBib = txtAgregarClasBib.Text;
                string ClaseEjem = txtAgregarClaseEjem.Text;
                string Estado = txtAgregarEstado.Text;
                int Copia;
                if (!Int32.TryParse(numAgregarCopia.Value.ToString(), out Copia)) {
                    MessageBox.Show("Número de Copia es inválido", "ERROR");
                    return;
                }
                string Unidad = txtAgregarUnid.Text;
                string Edicion = txtAgregarEdicion.Text;
                string Titulo = txtAgregarTitulo.Text;
                string Autor = txtAgregarAutor.Text;
                string Editorial = txtAgregarEditorial.Text;
                int Anio;
                if (!Int32.TryParse(numAgregarAnio.Value.ToString(), out Anio)) {
                    MessageBox.Show("Año Ingresado es inválido", "ERROR");
                    return;
                }
                string Fondo = txtAgregarFondo.Text;
                string Et264 = txtAgregarEt264.Text;

                DataManager manager = new DataManager(connectionString, (ConnectionType)1);
                List<PoolConnectionParameters> prm = llenarParametrosLibros(1, BibId, CodBarr, ClasfEjemplar, ClasfBib, ClaseEjem, Estado, Copia, Unidad, Edicion, Titulo, Autor, Editorial, Anio, Et264, Fondo);
                manager.ExecuteNonQuery(CommandType.StoredProcedure, "[dbo].[SP_Libros]", prm);

                DialogResult result = MessageBox.Show("Libro dado de Alta", "BIEN");
                if (result == DialogResult.OK) {
                    numAgregarBibId.Value = 0;
                    numAgregarCodBarr.Value = 0;
                    txtAgregarClasEjem.Text = "";
                    txtAgregarClasBib.Text = "";
                    txtAgregarClaseEjem.Text = "";
                    txtAgregarEstado.Text = "";
                    numAgregarCopia.Value = 0;
                    txtAgregarUnid.Text = "";
                    txtAgregarEdicion.Text = "";
                    txtAgregarTitulo.Text = "";
                    txtAgregarAutor.Text = "";
                    txtAgregarEditorial.Text = "";
                    numAgregarAnio.Value = 0;
                    txtAgregarFondo.Text = "";
                    txtAgregarEt264.Text = "";
                }
            } catch (Exception ex) {
                MessageBox.Show("Error Alta de Libro, Exception: " + ex.Message, "ERROR");
            }
        }

        private void EliminarLibro() {
            try {
                int CodBarr;
                if (!Int32.TryParse(numEliminarCodBarr.Value.ToString(), out CodBarr)) {
                    MessageBox.Show("Ingrese un Código de Barras válido", "ERROR");
                    return;
                }
                if (CodBarr == 0) {
                    MessageBox.Show("Ingrese un Código de Barras válido", "ERROR");
                    return;
                }

                DataManager manager = new DataManager(connectionString, (ConnectionType)1);
                List<PoolConnectionParameters> prm = llenarParametrosLibros(4, 0, CodBarr);
                var dataset = manager.ExecuteDataSet(CommandType.StoredProcedure, "[dbo].[SP_Libros]", prm);

                if (dataset.Tables[0].Rows[0]["Resultado"].ToString() == "1") {
                    DialogResult result = MessageBox.Show("Libro Eliminado", "BIEN");
                    if (result == DialogResult.OK) {
                        numEliminarCodBarr.Value = 0;
                    }
                } else {
                    MessageBox.Show("Libro No Existe", "WARNING");
                }
            } catch (Exception ex) {
                MessageBox.Show("Error Alta de Libro, Exception: " + ex.Message, "ERROR");
            }
        }

        private void Buscar() {
            try {
                int locationY = 0;

                int locationtxtCodBarrX = 0;
                int locationtxtTituloX = 159;
                int locationtxtAutorX = 546;

                panelConsultaLib.Controls.Clear();

                #region Encabezado

                // textbox para el Codigo de Barras
                TextBox txtCodBarr = new TextBox {
                    AutoSize = true,
                    Location = new Point(locationtxtCodBarrX, locationY),
                    Size = new Size(160, 20),
                    Text = "Código de Barras",
                    Enabled = false,
                    Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0)
                };
                panelConsultaLib.Controls.Add(txtCodBarr);

                // textbox para el Titulo
                TextBox txtTitulo = new TextBox {
                    AutoSize = true,
                    Location = new Point(locationtxtTituloX, locationY),
                    Size = new Size(388, 20),
                    Text = "Titulo",
                    Enabled = false,
                    Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0)
                };
                panelConsultaLib.Controls.Add(txtTitulo);

                // textbox para el Autor
                TextBox txtAutor = new TextBox {
                    AutoSize = true,
                    Location = new Point(locationtxtAutorX, locationY),
                    Size = new Size(217, 20),
                    Text = "Autor",
                    Enabled = false,
                    Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0)
                };
                panelConsultaLib.Controls.Add(txtAutor);

                #endregion

                DataManager manager = new DataManager(connectionString, (ConnectionType)1);
                List<PoolConnectionParameters> prm = llenarParametrosLibros(3, 0, 0, Titulo: txtBuscarTitulo.Text);
                var dataset = manager.ExecuteDataSet(CommandType.StoredProcedure, "[dbo].[SP_Libros]", prm);
                locationY += 19;

                #region Registros

                foreach (DataRow dr in dataset.Tables[0].Rows) {
                    // textbox para el Codigo de Barras
                    TextBox txtCodBarrR = new TextBox {
                        AutoSize = true,
                        Location = new Point(locationtxtCodBarrX, locationY),
                        Size = new Size(160, 20),
                        Text = dr["CodigoBarras"].ToString(),
                        Enabled = false,
                        Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0)
                    };
                    panelConsultaLib.Controls.Add(txtCodBarrR);

                    // textbox para el Titulo
                    TextBox txtTituloR = new TextBox {
                        AutoSize = true,
                        Location = new Point(locationtxtTituloX, locationY),
                        Size = new Size(388, 20),
                        Text = dr["Titulo"].ToString(),
                        Enabled = false,
                        Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0)
                    };
                    panelConsultaLib.Controls.Add(txtTituloR);

                    // textbox para el Autor
                    TextBox txtAutorR = new TextBox {
                        AutoSize = true,
                        Location = new Point(locationtxtAutorX, locationY),
                        Size = new Size(217, 20),
                        Text = dr["Autor"].ToString(),
                        Enabled = false,
                        Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0)
                    };
                    panelConsultaLib.Controls.Add(txtAutorR);

                    locationY += 19;
                }
                #endregion

                if (dataset.Tables[0].Rows.Count == 100) {
                    MessageBox.Show("Solo se mostraron los primero 100 Libros encontrados, si no se encuentra el libro que busca se recomienda ser mas específico", "ERROR");
                    txtLibrosEncontrados.Text = dataset.Tables[0].Rows.Count.ToString();
                } else if (dataset.Tables[0].Rows.Count == 0) {
                    MessageBox.Show("no se encuentra ningún libro con ese título", "WARNING");
                    txtLibrosEncontrados.Text = "0";
                } else {
                    txtLibrosEncontrados.Text = dataset.Tables[0].Rows.Count.ToString();
                }

            } catch (Exception ex) {
                MessageBox.Show("Error Generando Reporte, Exception: " + ex.Message, "ERROR");
            }
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char)Keys.Enter) {
                AltaRegistro();
            }
        }

        internal static List<PoolConnectionParameters> llenarParametrosRegistro(int accion, DateTime fechaDesde, DateTime fechaHasta, long codigoBarras = 0) {
            List<PoolConnectionParameters> prm = new List<PoolConnectionParameters>();
            prm.Add(new PoolConnectionParameters() { ParameterName = "@RETURN_VALUE", ParemeterDbType = (int)SqlDbType.Int, ParameterDirection = (int)ParameterDirection.ReturnValue });
            prm.Add(new PoolConnectionParameters() { ParameterName = "@accion", ParameterValue = accion });
            prm.Add(new PoolConnectionParameters() { ParameterName = "@fechaDesde", ParameterValue = fechaDesde });
            prm.Add(new PoolConnectionParameters() { ParameterName = "@fechaHasta", ParameterValue = fechaHasta });
            prm.Add(new PoolConnectionParameters() { ParameterName = "@codigoBarras", ParameterValue = codigoBarras });
            return prm;
        }

        internal static List<PoolConnectionParameters> llenarParametrosLibros(int accion, int BibId, long CodigoBarras, string ClasificacionEjemplar = "",
            string ClasificacionBibliografico = "", string ClaseEjemplar = "", string Estado = "", int Cop = 1, string Unidad = "",
            string Edicion = "", string Titulo = "", string Autor = "", string Editorial = "", int Anio = 0, string Et264 = "", string Fondo = "") {
            List<PoolConnectionParameters> prm = new List<PoolConnectionParameters>();
            prm.Add(new PoolConnectionParameters() { ParameterName = "@RETURN_VALUE", ParemeterDbType = (int)SqlDbType.Int, ParameterDirection = (int)ParameterDirection.ReturnValue });
            prm.Add(new PoolConnectionParameters() { ParameterName = "@Accion", ParameterValue = accion });
            prm.Add(new PoolConnectionParameters() { ParameterName = "@BibId", ParameterValue = BibId });
            prm.Add(new PoolConnectionParameters() { ParameterName = "@CodigoBarras", ParameterValue = CodigoBarras });
            prm.Add(new PoolConnectionParameters() { ParameterName = "@ClasificacionEjemplar", ParameterValue = ClasificacionEjemplar });
            prm.Add(new PoolConnectionParameters() { ParameterName = "@ClasificacionBibliografico", ParameterValue = ClasificacionBibliografico });
            prm.Add(new PoolConnectionParameters() { ParameterName = "@ClaseEjemplar", ParameterValue = ClaseEjemplar });
            prm.Add(new PoolConnectionParameters() { ParameterName = "@Estado", ParameterValue = Estado });
            prm.Add(new PoolConnectionParameters() { ParameterName = "@Cop", ParameterValue = Cop });
            prm.Add(new PoolConnectionParameters() { ParameterName = "@Unidad", ParameterValue = Unidad });
            prm.Add(new PoolConnectionParameters() { ParameterName = "@Edicion", ParameterValue = Edicion });
            prm.Add(new PoolConnectionParameters() { ParameterName = "@Titulo", ParameterValue = Titulo });
            prm.Add(new PoolConnectionParameters() { ParameterName = "@Autor", ParameterValue = Autor });
            prm.Add(new PoolConnectionParameters() { ParameterName = "@Editorial", ParameterValue = Editorial });
            prm.Add(new PoolConnectionParameters() { ParameterName = "@Anio", ParameterValue = Anio });
            prm.Add(new PoolConnectionParameters() { ParameterName = "@Et264", ParameterValue = Et264 });
            prm.Add(new PoolConnectionParameters() { ParameterName = "@Fondo", ParameterValue = Fondo });
            return prm;
        }

        private void btnGenerar_Click(object sender, EventArgs e) {
            try {

                int locationY = 0;

                int locationtxtTituloX = 0;
                int locationtxtAutorX = 387;

                panelResultados.Controls.Clear();

                #region Encabezado

                // textbox para el Titulo
                TextBox txtTitulo = new TextBox {
                    AutoSize = true,
                    Location = new Point(locationtxtTituloX, locationY),
                    Size = new Size(388, 20),
                    Text = "Titulo",
                    Enabled = false,
                    Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0)
                };
                panelResultados.Controls.Add(txtTitulo);

                // textbox para el Autor
                TextBox txtAutor = new TextBox {
                    AutoSize = true,
                    Location = new Point(locationtxtAutorX, locationY),
                    Size = new Size(217, 20),
                    Text = "Autor",
                    Enabled = false,
                    Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0)
                };
                panelResultados.Controls.Add(txtAutor);

                #endregion

                DataManager manager = new DataManager(connectionString, (ConnectionType)1);
                List<PoolConnectionParameters> prm = llenarParametrosRegistro(2, datePickDesde.Value, datePickHasta.Value, 0);
                var dataset = manager.ExecuteDataSet(CommandType.StoredProcedure, "[dbo].[SP_Registros]", prm);
                txtCantidadLibros.Text = dataset.Tables[0].Rows.Count.ToString();
                locationY += 19;

                #region Registros

                foreach (DataRow dr in dataset.Tables[0].Rows) {
                    // textbox para el Titulo
                    TextBox txtTituloR = new TextBox {
                        AutoSize = true,
                        Location = new Point(locationtxtTituloX, locationY),
                        Size = new Size(388, 20),
                        Text = dr["Titulo"].ToString(),
                        Enabled = false,
                        Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0)
                    };
                    panelResultados.Controls.Add(txtTituloR);

                    // textbox para el Autor
                    TextBox txtAutorR = new TextBox {
                        AutoSize = true,
                        Location = new Point(locationtxtAutorX, locationY),
                        Size = new Size(217, 20),
                        Text = dr["Autor"].ToString(),
                        Enabled = false,
                        Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0)
                    };
                    panelResultados.Controls.Add(txtAutorR);

                    locationY += 19;
                }
                #endregion

            } catch (Exception ex) {
                MessageBox.Show("Error Generando Reporte, Exception: " + ex.Message, "ERROR");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e) {
            AltaLibro();
        }

        private void btnEliminar_Click(object sender, EventArgs e) {
            EliminarLibro();
        }

        private void btnBuscar_Click(object sender, EventArgs e) {
            if (txtBuscarTitulo.Text != "") {
                Buscar();
            } else {
                MessageBox.Show("Ingrese el título para buscar", "WARNING");
            }

        }
    }
}
