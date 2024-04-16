using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySpace1._0
{
    public partial class Form1 : Form
    {
        private const string filepath = "C:\\Users\\timob\\Timo\\Benutzer";
        private static String directorypath_user;
        public Form1()
        {
            InitializeComponent();
        }
        RegistryKey reg = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
        Loginpage objlogin;
        private void Form1_Load(object sender, EventArgs e)
        {
            reg.SetValue("My app", Application.ExecutablePath.ToString());
            objlogin = new Loginpage();
            objlogin.ShowDialog();
            if (Loginpage.getIsLoginSuccess() == true)
            {
                this.PnlFormLoader.Controls.Clear();
                frmDashboard frmToDo_Vrb = new frmDashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                frmToDo_Vrb.FormBorderStyle = FormBorderStyle.None;
                this.PnlFormLoader.Controls.Add(frmToDo_Vrb);
                frmToDo_Vrb.Show();
            }
            else
            {
                this.Close();
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.PnlFormLoader.Controls.Clear();
            frmKalender frmToDo_Vrb = new frmKalender() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmToDo_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(frmToDo_Vrb);
            frmToDo_Vrb.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.PnlFormLoader.Controls.Clear();
            frmDashboard frmToDo_Vrb = new frmDashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmToDo_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(frmToDo_Vrb);
            frmToDo_Vrb.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        public static string create_filepath_userports()
        {
            //Checken ob alle Ordner vom Grunddateipfad vorhanden sind.
            ornderCheck(filepath);
            //Eine Variable definieren um den Dateipfad zwischenzuspeichern.
            String filepath_userports;
            //Der Variable den erstellten Dateipfad zuweisen.
            filepath_userports = filepath + "\\Userports.txt";
            dateiCheck(filepath_userports);
            //Den Dateipfad zurückgeben.
            return filepath_userports;
        }

        //Den Dateipfad für den Verschlüsselungsschlüssel erstellen.
        public static String create_filepath_aeskey()
        {
            //Checken ob alle Ordner vom Grunddateipfad vorhanden sind.
            ornderCheck(filepath);
            //Eine Variable definieren um den Dateipfad zwischenzuspeichern.
            String filepath_aeskey;
            //Der Variable den erstellten Dateipfad zuweisen.
            filepath_aeskey = filepath + "\\aes_key.bin";
            //Den Dateipfad zurückgeben.
            return filepath_aeskey;
        }
        //Den Dateipfad für den Kalender erstellen.
        public static String create_filepath_kalender()
        {
            //Eine Variable definieren um den Dateipfad zwischenzuspeichern.
            String filepath_kalender;
            //Den Getter für den Grunddateipfad der Benutzer dem filepath_user zuweisen.
            directorypath_user = filepath + "\\User" + Loginpage.getI;
            //Checken ob der Ordner für den Benutzer bereits vorhanden ist.
            ornderCheck(directorypath_user);
            //Der Variable den erstellten Dateipfad zuweisen.
            filepath_kalender = directorypath_user + "\\Kalender.txt";
            //Checken ob die Datei für den Benutzer bereits vorhanden ist.
            dateiCheck(filepath_kalender);
            //Den Dateipfad zurückgeben.
            return filepath_kalender;
        }



        /*
         * Methoden um die Dateien und Ordner zu erstellen.
         */
        //Erstellung der Dateien mit angegebenen Filepath.
        public static void dateiCheck(String filepath_bekommen)
        {

            String filePath = filepath_bekommen;
            if (File.Exists(filePath))
            {

            }
            else
            {
                if (!File.Exists(filePath))
                {
                    File.Create(filePath);
                }
            }
        }

        //Erstellung der Ordner mit angegebenen Directorypath.
        public static void ornderCheck(String direktorypath_bekommen)
        {
            String directoryPath = direktorypath_bekommen;
            if (Directory.Exists(directoryPath))
            {

            }
            else
            {
                if (!Directory.Exists(directoryPath))
                {
                    Directory.CreateDirectory(directoryPath);
                }
            }
        }
    }
}
