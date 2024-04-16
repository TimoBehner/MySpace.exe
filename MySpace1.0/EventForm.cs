using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MySpace1._0
{
    public partial class EventForm : Form
    {
        /*
         * Attribute für den bekommenen Input
         */
        private static string datum;
        private static string ereignis;
        private static string uhrzeit_anfangswert;
        private static string uhrzeit_endwert;
        private static string notizen;
        private static string kategorie;
        private static string fertigesEvent;
        private static bool neuesEventErstellen;



        /*
         * Allgemeine Attribute
         */
        private static int i;



        /*
         * Dateipfade
         */
        private static string filepath_kalender;
        private static string filepath_userports = Form1.create_filepath_userports();
        private static string directorypath_user;


        public EventForm()
        {
            InitializeComponent();
        }

        private void EventForm_Load(object sender, EventArgs e)
        {
            txtdate.Text = UserControlDays.static_day + "/" + frmKalender.static_month + "/" + frmKalender.static_year;

        }



        /*
         * Der Speichern Button
         */
        private void btnSpeichern_Click(object sender, EventArgs e)
        {
            dateipfadErstellen();
            filepath_kalender = Form1.create_filepath_kalender();
            datum = txtdate.Text;
            ereignis = txtevent.Text;
            uhrzeit_anfangswert = txtuhrzeit_anfangswert.Text;
            uhrzeit_endwert = txtuhrzeit_endwert.Text;
            notizen = txtnotizen.Text;
            //Event zusammenstellen
            eventFertigstellen();
            //Liste erstellen
            List<string> zwischenspeicher = new List<string>();
            if (filepath_kalender != null)
            {
                //Reader erstellen
                StreamReader reader = new StreamReader(filepath_kalender);
                //lokale Variable erstellen als Zwischenspeicher
                string line;
                //Jede Zeile lessen bis leer ist (also null)
                while ((line = reader.ReadLine()) != null)
                {
                    zwischenspeicher.Add(line);
                }
                //Den Reader wieder schließen
                reader.Close();
                //Writer erstellen um die Liste wieder reinzuschreiben.
                StreamWriter writer = new StreamWriter(filepath_kalender);
                zwischenspeicher.Add(fertigesEvent);
                //Die Liste wieder rein printen
                foreach (var item in zwischenspeicher)
                {
                    writer.WriteLine(item);
                }
                //Den Writer wieder schließen
                writer.Close();
            }
            neuesEventErstellen = false;
            MessageBox.Show("Das Event wurde erfolgreich gespeichert.");
            this.Close();
        }



        /*
         * Kategorie wählen
         */
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            kategorie = "Schule";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            kategorie = "Soziales";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            kategorie = "Haushalt";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            kategorie = "Sonstiges";
        }



        /*
         * Methoden
         */
        //Event fertigstellen
        public static void eventFertigstellen()
        {
            fertigesEvent = datum + "\n" + kategorie + "\n" + uhrzeit_anfangswert + "\n" + uhrzeit_endwert + "\n" + ereignis + "\n" + notizen;
        }
        //Dateipfaderstellen
        public static void dateipfadErstellen()
        {
            i = Loginpage.getI();
            StreamReader reader = new StreamReader(filepath_userports);
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                if (line.Contains("C:\\\\Users\\\\timob\\\\Timo\\\\Programmierungen\\\\Java-Projekte\\\\MySpace\\\\Useraccounts\\\\User" + i / 2))
                {
                    directorypath_user = line;
                }
            }
        }




        /*
         * Getter
         */
        public static bool getNeuesEventErstellen()
        {
            return neuesEventErstellen;
        }

    }
}
