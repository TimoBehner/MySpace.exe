using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySpace1._0
{
    public partial class UserControlEventsTermin : UserControl
    {
        /*
         * allgemeine Attribute
         */
        private static int minuten_anfangswert;
        private static int minuten_endwert;
        private static int stunden_anfangswert;
        private static int stunden_endwert;
        private static int i;
        private static string uhrzeit;
        private static string uhrzeit_anfangswert;
        private static string uhrzeit_endwert;
        private static string uhrzeit_anfangswert_eingelesen;
        private static string uhrzeit_endwert_eingelesen;
        private static string datum_eingelesen;
        private static string datum_fenster;
        private static string kategorie;
        private static string ereignis;
        private static string backcolor;

        /*
         * Dateipfade
         */
        private static string filepath_userports = Form1.create_filepath_userports();
        private static string directorypath_user;
        private static string filepath_kalender;

        public UserControlEventsTermin()
        {
            InitializeComponent();
        }

        private void UserControlEventsTermin_Load(object sender, EventArgs e)
        {
            uhrzeitbestimmen();
            label1.Text = uhrzeit;
            displayEvent();
            if (backcolor == "Gold")
            {
                panel1.BackColor = Color.Gold;
                label1.BackColor = Color.Gold;
                label2.BackColor = Color.Gold;
                label1.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
            }
            if (backcolor == "YellowGreen")
            {
                panel1.BackColor = Color.YellowGreen;
                label1.BackColor = Color.YellowGreen;
                label2.BackColor = Color.YellowGreen;
                label1.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
            }
            if (backcolor == "Cyan")
            {
                panel1.BackColor = Color.Cyan;
                label1.BackColor = Color.Cyan;
                label2.BackColor = Color.Cyan;
                label1.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
            }
            if (backcolor == "BlueViolet")
            {
                panel1.BackColor = Color.BlueViolet;
                label1.BackColor = Color.BlueViolet;
                label2.BackColor = Color.BlueViolet;
                label1.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
            }
            if (backcolor == "Transparent")
            {
                panel1.BackColor = Color.FromArgb(37, 42, 64);
                label1.BackColor = Color.Transparent;
                label2.BackColor = Color.Transparent;

            }
            if (uhrzeit_anfangswert == uhrzeit_anfangswert_eingelesen)
            {
                label2.Visible = true;
                label2.Text = ereignis;
            }


        }

        /*
         * Methoden
         */
        public static void uhrzeitbestimmen()
        {
            minuten_anfangswert = frmEventssehen.getMinuten_anfangswert();
            minuten_endwert = frmEventssehen.getMinuten_endwert();
            stunden_anfangswert = frmEventssehen.getStunden_anfangswert();
            stunden_endwert = frmEventssehen.getStunden_endwert();
            uhrzeit = stunden_anfangswert + ":" + minuten_anfangswert + " - " + stunden_endwert + ":" + minuten_endwert;
            uhrzeit_anfangswert = stunden_anfangswert + ":" + minuten_anfangswert;
            uhrzeit_endwert = stunden_endwert + ":" + minuten_endwert;
            frmEventssehen.anfangswerteNeuDefinieren();
        }
        public static void displayEvent()
        {
            filepath_kalender = Form1.create_filepath_kalender();
            datum_fenster = UserControlDays.getDateOfDisplay();
            StreamReader reader = new StreamReader(filepath_kalender);
            while ((datum_eingelesen = reader.ReadLine()) != null)
            {
                if (datum_eingelesen == datum_fenster)
                {
                    kategorie = reader.ReadLine();
                    uhrzeit_anfangswert_eingelesen = reader.ReadLine();
                    uhrzeit_endwert_eingelesen = reader.ReadLine();
                    if (uhrzeit_anfangswert_eingelesen == uhrzeit_anfangswert)
                    {
                        ereignis = reader.ReadLine();
                        if (kategorie.Contains("Schule"))
                        {
                            backcolor = "Gold";
                        }
                        if (kategorie.Contains("Soziales"))
                        {
                            backcolor = "YellowGreen";
                        }
                        if (kategorie.Contains("Haushalt"))
                        {
                            backcolor = "Cyan";
                        }
                        if (kategorie.Contains("Sonstiges"))
                        {
                            backcolor = "BlueViolet";
                        }
                        break;
                    }
                    if (uhrzeit_endwert_eingelesen == uhrzeit_endwert)
                    {
                        backcolor = "Transparent";
                        break;
                    }

                }
            }
            reader.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
