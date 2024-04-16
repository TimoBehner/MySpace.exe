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
using static System.Net.Mime.MediaTypeNames;

namespace MySpace1._0
{
    public partial class UserControlDays : UserControl
    {

        /*
         * Dateipfade
         */
        private static string filepath_userports = Form1.create_filepath_userports();
        private static string directorypath_user;
        private static string filepath_kalender;

        /*
         * Attribute
         */
        public static bool neuesEventErstellen;
        public static string static_day, dateOfDisplay, kategoriegegeben, aktuellesDatum, angezeigtesDatum, displaytag;
        public static int month, year, day, i;



        /*
         * Komponente der Form hinzuzufügen
         */
        public UserControlDays()
        {
            InitializeComponent();
        }



        /*
         * Die Methode displayEvent() wird aus geführt soblad die Form geladen wird.
         */
        private void UserControlDays_Load(object sender, EventArgs e)
        {
            neuesEventErstellen = frmKalender.getNeuesEventErstellen();
            displayEvent();
        }



        /*
         * Die Ziffer des Datums wird auf die Form geladen.
         */
        public void days(int numday)
        {
            lbdays.Text = numday + "";
            displaytag = lbdays.Text;
        }



        /*
         * Wenn auf den slot des Tages geklickt, öffnet sich das Fenster zum hinzufügen eines neues Events.
         */
        private void UserControlDays_Click(object sender, EventArgs e)
        {
            neuesEventErstellen = frmKalender.getNeuesEventErstellen();
            dateOfDisplay = lbdays.Text + "/" + frmKalender.static_month + "/" + frmKalender.static_year;
            if (neuesEventErstellen == true)
            {
                static_day = lbdays.Text;
                timer1.Start();
                EventForm eventForm = new EventForm();
                eventForm.Show();
            }
            else
            {
                frmEventssehen frmEventssehen = new frmEventssehen();
                frmEventssehen.Show();
            }
            neuesEventErstellen = EventForm.getNeuesEventErstellen();
        }



        /*
         * Diese Methode ließt die Datei Kalender.txt-Datei des jeweiligen Benutzers aus und fügt die Events zu dem jeweilgen Slot in der Farbe der 
         * Kategorie hinzu.
         */
        private void displayEvent()
        {
            dateOfDisplay = lbdays.Text + "/" + frmKalender.static_month + "/" + frmKalender.static_year;
            filepath_kalender = Form1.create_filepath_kalender();
            StreamReader reader = new StreamReader(filepath_kalender);
            string datum;
            string uhrzeit;
            string kategorie;
            string ereignis;
            while ((datum = reader.ReadLine()) != null)
            {
                if (datum.Contains(dateOfDisplay))
                {
                    kategorie = reader.ReadLine(); ;
                    if (kategorie.Contains("Schule"))
                    {
                        if (lbevent.Text == "")
                        {
                            lbevent.ForeColor = Color.Gold;
                        }
                        if (lbevent01.Text == "")
                        {
                            lbevent01.ForeColor = Color.Gold;
                        }
                    }
                    if (kategorie.Contains("Soziales"))
                    {

                        if (lbevent.Text == "")
                        {
                            lbevent.ForeColor = Color.YellowGreen;
                        }
                        if (lbevent01.Text == "")
                        {
                            lbevent01.ForeColor = Color.YellowGreen;
                        }
                    }
                    if (kategorie.Contains("Haushalt"))
                    {
                        if (lbevent.Text == "")
                        {
                            lbevent.ForeColor = Color.Cyan;
                        }
                        if (lbevent01.Text == "")
                        {
                            lbevent01.ForeColor = Color.Cyan;
                        }
                    }
                    if (kategorie.Contains("Sonstiges"))
                    {
                        if (lbevent.Text == "")
                        {
                            lbevent.ForeColor = Color.BlueViolet;
                        }
                        if (lbevent01.Text == "")
                        {
                            lbevent01.ForeColor = Color.BlueViolet;
                        }
                    }
                    uhrzeit = reader.ReadLine();
                    reader.ReadLine();
                    ereignis = reader.ReadLine();
                    if (lbevent.Text == "")
                    {
                        lbevent.Text = uhrzeit + " " + ereignis;
                    }
                    else
                    {
                        ereignis = uhrzeit + " " + ereignis;
                        if (lbevent.Text != ereignis)
                        {
                            lbevent01.Text = ereignis;
                        }
                    }

                }
            }
            reader.Close();
        }



        /*
         * Der Timer bewirkt, dass die jeweiligen Slots auch nach dem Laden reloadet werden.
         */
        private void timer1_Tick(object sender, EventArgs e)
        {
            displayEvent();
        }


        /*
         * Das Fenster zur erstellung der neuen Termine wird auch geöffnet, wenn auf das Label geklickt wird.
         */
        private void lbevent_Click(object sender, EventArgs e)
        {
            static_day = lbdays.Text;
            timer1.Start();
            EventForm eventForm = new EventForm();
            eventForm.Show();
        }

        /*
         * Methoden
         */

        /*
         * Getter
         */
        public static string getDateOfDisplay()
        {
            return dateOfDisplay;
        }

        private void lbevent01_Click(object sender, EventArgs e)
        {

        }
    }
}
