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
        }

        private string LeerClaveRegistro(string ruta, string clave)
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(ruta);
            return key?.GetValue(clave)?.ToString() ?? "No encontrado";
        }

        private void EliminarClaveRegistro(string ruta, string clave)
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(ruta, true);
            if (key != null)
            {
                key.DeleteValue(clave);
                key.Close();
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

        private void button1_Click(object sender, EventArgs e)
        {
            lblDiscos.Text= ObtenerCantidadDiscos().ToString();
        }

        private void btnProcesador_Click(object sender, EventArgs e)
        {
            lblProcesador.Text=ObtenerInformacionProcesador().ToString();
            lblRam.Text = ObtenerInformacionRAM().ToString();
            lblNic.Text= ObtenerTarjetasRed().ToString();  
        }

        private void btnMac_Click(object sender, EventArgs e)
        {
            lblMac.Text=ObtenerDireccionMAC();
        }

        private void btnCrearKey_Click(object sender, EventArgs e)
        {
            CrearClaveRegistro("Software\\MiAplicacion", "ClavePrueba", "12345");
        }

        private void btnLeerKey_Click(object sender, EventArgs e)
        {
            lblLeerClave.Text = LeerClaveRegistro("Software\\MiAplicacion", "ClavePrueba");
        }

        private void btnEliminarKey_Click(object sender, EventArgs e)
        {
            EliminarClaveRegistro("Software\\MiAplicacion", "ClavePrueba");
        }

        private void btnCrearProcesos_Click(object sender, EventArgs e)
        {
            ltbProcesos.Items.Clear();
            string[] procesos = ObtenerProcesosActivos();
            for (int i = 0; i < procesos.Length; i++)
            {
                ltbProcesos.Items.Add(procesos[i]);
            }
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
    }
}
