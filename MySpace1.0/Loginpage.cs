using System;
using System.IO;
using System.Security.Cryptography;
using System.Threading;
using System.ComponentModel;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MySpace1._0
{
    public partial class Loginpage : Form
    {



        /*
         * konstante Attribute für die Verschlüsselung
         */
        private static string KEY_FILE_PATH = Form1.create_filepath_aeskey();
        private const int KEY_SIZE = 256; // AES-256



        /*
         * Datenpfade
         */
        private static string filepath_userports = Form1.create_filepath_userports();



        /*
         * Allgemeine Attribute
         */
        private static bool IsLoginSuccess;
        private static string passwort_verschlüsselt;
        private static int i;



        /*
         * Atrribute für die Anmeldedaten
         */
        private static string passwortGegeben;
        private static string benutzernameGegeben;



        public Loginpage()
        {
            InitializeComponent();
        }



        /*
         * Der Loginbutton
         */
        private void btnlogin1_Click(object sender, EventArgs e)
        {
            passwortGegeben = txtpass.Text;
            benutzernameGegeben = txtuser.Text;
            passwort_verschlüsselt = EncryptPassword(passwortGegeben, LoadOrCreateAESKey());
            if (!backgroundWorker1.IsBusy)
            {
                btnlogin1.Text = "Lädt...";
                backgroundWorker1.RunWorkerAsync();
            }
        }



        /*
         * Der Registrierungsbutton
         */
        Registerpage objlogin;
        private void btnRegistrieren_Click(object sender, EventArgs e)
        {
            this.Hide();
            objlogin = new Registerpage();
            objlogin.ShowDialog();
            if (objlogin.getIsSuccessfuly() == true)
            {
                this.Show();
            }
            else
            {
                this.Close();
            }
        }



        /*
         * Der Bakgroundworker vergleicht die Benutzerdaten und schließt dieses Fenster sobal diese Stimmen.
         */
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            überprüfungDerAnmeldedaten();
        }
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (IsLoginSuccess == true)
            {
                this.Close();
            }
            else
            {
                label6.Visible = true;
                label6.Text = "Bitte überprüfe Benutzername und Passwort!";
            }
            btnlogin1.Text = "Anmelden";
        }



        /*
         * Verschlüsselung
         */
        //Verschlüsslungsschlüssel laden
        public static byte[] LoadOrCreateAESKey()
        {
            if (File.Exists(KEY_FILE_PATH))
            {
                return File.ReadAllBytes(KEY_FILE_PATH);
            }
            else
            {
                using (Aes aes = Aes.Create())
                {
                    aes.KeySize = KEY_SIZE;
                    aes.GenerateKey();
                    byte[] key = aes.Key;
                    File.WriteAllBytes(KEY_FILE_PATH, key);
                    return key;
                }
            }
        }
        //Passwort verschlüsseln
        public static string EncryptPassword(string password, byte[] secretKey)
        {
            using (Aes aes = Aes.Create())
            {
                aes.Key = secretKey;
                aes.Mode = CipherMode.ECB; // ECB-Modus wird hier verwendet, bitte überprüfen Sie Ihre Anforderungen und verwenden Sie den passenden Modus
                aes.Padding = PaddingMode.PKCS7;

                ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);
                byte[] encryptedBytes = null;
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(password);
                            swEncrypt.Close();
                        }
                        encryptedBytes = msEncrypt.ToArray();
                        csEncrypt.Close();
                    }
                    msEncrypt.Close();
                }
                return Convert.ToBase64String(encryptedBytes);
            }
        }



        /*
         * Methoden
         */
        //Methode um die Korrektheit der Anmeldedaten zu überprüfen
        public static void überprüfungDerAnmeldedaten()
        {
            i = 0;
            StreamReader reader = new StreamReader(filepath_userports);
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                if (line.Contains(benutzernameGegeben) && line.Contains(passwort_verschlüsselt))
                {
                    IsLoginSuccess = true;
                    break;
                }
                else
                {
                    IsLoginSuccess = false;
                }
                i++;
            }
            reader.Close();
        }




        /*
         * Getter
         */
        public static bool getIsLoginSuccess()
        {
            return IsLoginSuccess;
        }

        public static int getI()
        {
            return i;
        }

        private void Loginpage_Load(object sender, EventArgs e)
        {

        }
    }
}