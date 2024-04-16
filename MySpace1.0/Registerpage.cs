using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.ApplicationServices;

namespace MySpace1._0
{
    public partial class Registerpage : Form
    {



        /*
         * konstante Attribute für die Verschlüsselung
         */
        private static string KEY_FILE_PATH = Form1.create_filepath_aeskey();
        private const int KEY_SIZE = 256; // AES-256



        /*
         * Dateipfade
         */
        private static string filepath_userports = Form1.create_filepath_userports();
        private static string directorypath_user;
        private static string filepath_user;
        private static string filepath_calendar;


        /*
         * Allgemeine Attribute
         */
        private static bool IsSuccessfuly = false;
        private static string neueRegistrierung;
        private static string passwort_verschlüsselt;
        private static int i;
        //Die Variable für den Input der Textboxen
        private static string benutzernameGegeben;
        private static string passwortGegeben01;
        private static string passwortGegeben02;
        //Variable um die beiden Passwörter aus denn Textboxen zu vergleichen
        private static bool passwörterStimmenÜberein;
        private static bool benutzernameVerfügbar;
        private static bool registrierungIstKorrekt;

 

        public Registerpage()
        {
            InitializeComponent();
        }

        private void Registerpage_Load(object sender, EventArgs e)
        {

        }

        private void btnlogin1_Click(object sender, EventArgs e)
        {
            IsSuccessfuly = true;
            this.Close();
        }



        /*
         * Registreierungsbutton
         */
        private void btnRegistrieren_Click(object sender, EventArgs e)
        {
            label6.ForeColor = Color.Red;
            label6.Visible = false;
            benutzernameGegeben = txtuser.Text;
            passwortGegeben01 = txtpass01.Text;
            passwortGegeben02 = txtpass02.Text;
            //Aufruf der Methode um die beiden Passwörter der Textboxen zu vergleichen
            verfügbarkeitDesBenutzernamensÜberprüfen();
            //Aufruf der Methode um die Verfügbarkeit des Benutzernamens zu überprüfen
            passwörterAusDenTextboxenVergleichen();
            //Aufruf der Methode um zu Überprüfen ob der Benutzername und die Passwörter übereinstimmen
            überprüfungAufKorrektheitDerRegistrierung();
            if (passwörterStimmenÜberein == false )
            {
                label6.Visible = true;
                label6.Text = "Die Passwörter stimmen nicht überein!";
            }
            if (benutzernameVerfügbar == false )
            {
                label6.Visible = true;
                label6.Text = "Der Benutzername ist bereits vergeben!";
            }
            if (registrierungIstKorrekt == true)
            {
                label6.Visible = true;
                label6.ForeColor = Color.Green;
                label6.Text = "Login erfolgreich!";
                //Passwort verschlüsseln
                passwort_verschlüsselt = EncryptPassword(passwortGegeben01, LoadOrCreateAESKey());
                //Den Zwischenspeicher erstellen um nicht alle Einträge aus dem Dokument zu löschen, dann den neuen User Hinzufügen und anschließend printen.
                zwischenspeicherErstellenUndDenneuenUserHinzufügenUndPrinten();
                IsSuccessfuly = true;
                this.Close();
            }
        }



        /*
         * Verschlüsselung
         */

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
                        }
                        encryptedBytes = msEncrypt.ToArray();
                    }
                }
                return Convert.ToBase64String(encryptedBytes);
            }
        }

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



        /*
         * Methoden
         */

        //Die beiden Passwörter aus den Textboxen vergleichen.
        public static void passwörterAusDenTextboxenVergleichen()
        {
            if(passwortGegeben01 == passwortGegeben02)
            {
                passwörterStimmenÜberein = true;
            }else
            {
                passwörterStimmenÜberein = false;
            }
        }

        //Verfügbarkeit des Benutzernamens überprüfen
        public static void verfügbarkeitDesBenutzernamensÜberprüfen()
        {
            //Erstellung eines Readers um das Textdokument zu durchsuchen
            StreamReader reader = new StreamReader(filepath_userports);
            //Definierung einer lokalen Variable um jede Zeile zwischenzuspeichern
            string line;
            if((line = reader.ReadLine()) == null) 
            { 

                        benutzernameVerfügbar = true;
            }
            else
            {
                if (line.Contains(benutzernameGegeben))
                {
                    benutzernameVerfügbar = false;
                }
                else
                {
                    benutzernameVerfügbar = true;
                    //Der reader liest solange eine Zeile nach der anderen bis die Zeile leer (also null) ist
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (line.Contains(benutzernameGegeben))
                        {
                            benutzernameVerfügbar = false;
                            break;
                        }
                        else
                        {
                            benutzernameVerfügbar = true;
                        }
                    }
                }

            }
            reader.Close();
        }

        //Überprüfung ob die Passwörter übereinstimmen und der Benutzername bereits vergeben ist.
        public static void überprüfungAufKorrektheitDerRegistrierung()
        {
            if(benutzernameVerfügbar == true && passwörterStimmenÜberein == true)
            {
                registrierungIstKorrekt = true;
            }
            else
            {
                registrierungIstKorrekt = false;
            }
        }



        //Neue Registrierung mit dem was geprintet werden soll definieren
        public static void neueRegistrierungBauen()
        {
            neueRegistrierung = "User" + i/2 + "  Benutzername: " + benutzernameGegeben + "   Passwort: " + passwort_verschlüsselt + "\n" + directorypath_user;
        }



        //Der Liste Zwischenspeicher alle sich bisher in dem Dokument befindenden User hinzufügen
        public static void zwischenspeicherErstellenUndDenneuenUserHinzufügenUndPrinten()
        {
            //Liste erstellen
            List<string> zwischenspeicher = new List<string>();
            //Reader erstellen
            StreamReader reader = new StreamReader(filepath_userports);
            //lokale Variable erstellen als Zwischenspeicher
            string line;
            //Der Variable i einen Wert zuweisen um den Dateipfad erstellen zu können.
            i = 0;
            //Jede Zeile lessen bis leer ist (also null)
            while ((line = reader.ReadLine()) != null)
            {
                zwischenspeicher.Add(line);
                //Bei jedem Durchgang wird zu i eins hinzugefügt
                i++;
            }
            //Den Reader wieder schließen
            reader.Close();
            //Den Dateipfad erstellen
            directorypath_user_erstellen();
            //Die neue Registerung für das printen vorbereiten.
            neueRegistrierungBauen();
            zwischenspeicher.Add(neueRegistrierung);
            //Writer erstellen um die Liste wieder reinzuschreiben.
            StreamWriter writer = new StreamWriter(filepath_userports);
            //Die Liste wieder rein printen
            foreach (var item in zwischenspeicher)
            {
                writer.WriteLine(item);
            }
            //Den Writer wieder schließen
            writer.Close();
        }




        // Den Dateipfad für den User erstellen
        public static void directorypath_user_erstellen()
        {
            directorypath_user = "C:\\\\Users\\\\timob\\\\Timo\\\\Programmierungen\\\\Java-Projekte\\\\MySpace\\\\Useraccounts\\\\User" + i / 2;
        }




        /*
         * Getter
         */
        public bool getIsSuccessfuly()
        {
            return IsSuccessfuly;
        }

        public static string getFilepath_userports()
        {
            return filepath_userports;
        }
        
        public static string getFilepath_kalender()
        {
            return filepath_calendar;
        }

    }
}
