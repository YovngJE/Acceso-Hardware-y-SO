using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Management.ManagementObjectCollection;

namespace H_P_II_Clase8_AccesoHardware_SO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
          
        }

        public string ObtenerNumeroSerie()
        {
            string numeroserie="NO Encontrado";
            ManagementObjectSearcher buscador = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive");
            ManagementObjectCollection resultados = buscador.Get();

            ManagementObjectEnumerator enumerador = resultados.GetEnumerator();
            if (enumerador.MoveNext()) 
            {
                numeroserie = enumerador.Current["SerialNumber"].ToString().Trim();
            }
            return numeroserie;

        }

        public int ObtenerCantidadDiscos() {
            ManagementObjectSearcher buscador = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive");
            ManagementObjectCollection resultados = buscador.Get();
            return resultados.Count;

        }

        public string ObtenerInformacionProcesador(){
            string procesador = "No encontrado";
            ManagementObjectSearcher buscador = new ManagementObjectSearcher("SELECT * FROM Win32_Processor");
            ManagementObjectCollection resultados = buscador.Get();

            foreach (var item in resultados)
            {
                procesador = item["Name"].ToString();
            }
            return procesador;
        }

        public string ObtenerInformacionRAM()
        {
            long memoria = 0;
            ManagementObjectSearcher buscador = new ManagementObjectSearcher("SELECT * FROM Win32_ComputerSystem");
            ManagementObjectCollection resultados = buscador.Get();

            ManagementObjectEnumerator enumerador = resultados.GetEnumerator();
            if (enumerador.MoveNext())
            {
                memoria = Convert.ToInt64(enumerador.Current["TotalPhysicalMemory"]);
            }
            return Math.Round(memoria / (1024.0 * 1024 * 1024), 2) + " GB";
        }

        private string ObtenerTarjetasRed()
        {
            NetworkInterface[] interfaces = NetworkInterface.GetAllNetworkInterfaces();
            string resultado = "";

            for (int i = 0; i < interfaces.Length; i++)
            {
                resultado += interfaces[i].Description + " - Estado: " + interfaces[i].OperationalStatus + "\n";
            }
            return resultado;
        }

        private string ObtenerDireccionMAC()
        {
            NetworkInterface[] interfaces = NetworkInterface.GetAllNetworkInterfaces();
            for (int i = 0; i < interfaces.Length; i++)
            {
                if (interfaces[i].OperationalStatus == OperationalStatus.Up)
                {
                    return interfaces[i].GetPhysicalAddress().ToString();
                }
            }
            return "No disponible";
        }

        private void CrearClaveRegistro(string ruta, string clave, string valor)
        {
            RegistryKey key = Registry.CurrentUser.CreateSubKey(ruta);
            key.SetValue(clave, valor);
            key.Close();

            // Verificar si la clave se creó correctamente
            string valorLeido = LeerClaveRegistro(ruta, clave);
            MessageBox.Show("Clave creada");
        }

        private string LeerClaveRegistro(string ruta, string clave)
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(ruta);
            return key?.GetValue(clave)?.ToString() ?? "No encontrado";
        }

        private void EliminarClaveRegistro(string ruta, string clave)
        {
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(ruta, true))
            {
                if (key == null)
                {
                    MessageBox.Show("La clave especificada no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (key.GetValue(clave) == null)
                {
                    MessageBox.Show("El valor dentro de la clave no existe.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                key.DeleteValue(clave);
                MessageBox.Show("Clave eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private string[] ObtenerProcesosActivos()
        {
            Process[] procesos = Process.GetProcesses();
            string[] nombres = new string[procesos.Length];

            for (int i = 0; i < procesos.Length; i++)
            {
                nombres[i] = procesos[i].ProcessName;
            }
            return nombres;
        }

        private void MatarProceso(string nombreProceso)
        {
            Process[] procesos = Process.GetProcessesByName(nombreProceso);
            for (int i = 0; i < procesos.Length; i++)
            {
                procesos[i].Kill();
            }
        }




        private void btnNumeroSerie_Click(object sender, EventArgs e)
        {
            lblNumeroSerie.Text = ObtenerNumeroSerie();
        }

        private void btnCrearKey_Click(object sender, EventArgs e)
        {
            CrearClaveRegistro("Software\\MiAplicacion", "ClavePrueba", "12345");
        }

        private void btnLeerKey_Click(object sender, EventArgs e)
        {
            lblRegistroSistema.Text = "Clave Registro: " + LeerClaveRegistro("Software\\MiAplicacion", "ClavePrueba");
        }

        private void btnEliminarKey_Click(object sender, EventArgs e)
        {
            EliminarClaveRegistro("Software\\MiAplicacion", "ClavePrueba");
            lblRegistroSistema.Text = "";
        }

        private void btnCrearProcesos_Click(object sender, EventArgs e)
        {
               string[] procesos = ObtenerProcesosActivos();
        ltbProcesos.Items.Clear();
        ltbProcesos.Items.AddRange(procesos);
        lblInfoProcesos.Text = "📌 Procesos Activos: " + procesos.Length;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (ltbProcesos.SelectedItem != null)
            {
                string nombreProceso = ltbProcesos.SelectedItem.ToString();
                MatarProceso(nombreProceso);
                ltbProcesos.Items.Remove(nombreProceso); // Eliminar de la lista
            }
        }

       
        private void Form1_Load(object sender, EventArgs e)
        {
            tbcPrincipal.DrawMode = TabDrawMode.OwnerDrawFixed; // Permite dibujar manualmente las pestañas
            tbcPrincipal.DrawItem += new DrawItemEventHandler(tabControl1_DrawItem);
        }
        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            TabControl tabControl = sender as TabControl;
            if (tabControl == null) return;

            Graphics g = e.Graphics;
            Brush textBrush;

            // Color de la pestaña activa y las inactivas
            Color backColor = e.Index == tabControl.SelectedIndex ? Color.DarkBlue : Color.Gray;
            textBrush = new SolidBrush(Color.White); // Color del texto

            // Dibujar el fondo de la pestaña
            e.Graphics.FillRectangle(new SolidBrush(backColor), e.Bounds);

            // Dibujar el texto centrado
            string tabText = tabControl.TabPages[e.Index].Text;
            StringFormat stringFlags = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
            g.DrawString(tabText, tabControl.Font, textBrush, e.Bounds, stringFlags);
        }

        private void btnObtenerInfoSistema_Click(object sender, EventArgs e)
        {
                lblInfoSistema.Text =
          "📌 Información del Sistema:\n" +
          "🔹 Número de Serie: " + ObtenerNumeroSerie() + "\n" +
          "🔹 Cantidad de Discos: " + ObtenerCantidadDiscos() + "\n" +
          "🔹 Procesador: " + ObtenerInformacionProcesador() + "\n" +
          "🔹 RAM: " + ObtenerInformacionRAM() + "\n" +
          "🔹 Tarjetas de Red: \n" + ObtenerTarjetasRed() + "\n" +
          "🔹 Dirección MAC: " + ObtenerDireccionMAC();
        }
    }
}
