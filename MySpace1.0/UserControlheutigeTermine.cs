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
    public partial class UserControlheutigeTermine : UserControl
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


        public UserControlheutigeTermine()
        {
            InitializeComponent();
        }

        private void UserControlheutigeTermine_Load(object sender, EventArgs e)
        {
            displayEvent();
        }

        /*
         * Diese Methode ließt die Datei Kalender.txt-Datei des jeweiligen Benutzers aus und fügt die Events zu dem jeweilgen Slot in der Farbe der 
         * Kategorie hinzu.
         */
        private void displayEvent()
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;
            day = now.Day;
            dateOfDisplay = day + "/" + month + "/" + year;
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
                        if (label1.Text == "")
                        {
                            label1.ForeColor = Color.Gold;
                        }
                        if (label2.Text == "")
                        {
                            label2.ForeColor = Color.Gold;
                        }
                        if (label3.Text == "")
                        {
                            label3.ForeColor = Color.Gold;
                        }
                        if (label4.Text == "")
                        {
                            label4.ForeColor = Color.Gold;
                        }
                        if (label5.Text == "")
                        {
                            label5.ForeColor = Color.Gold;
                        }
                        if (label6.Text == "")
                        {
                            label6.ForeColor = Color.Gold;
                        }
                        if (label7.Text == "")
                        {
                            label7.ForeColor = Color.Gold;
                        }
                    }
                    if (kategorie.Contains("Soziales"))
                    {

                        if (label1.Text == "")
                        {
                            label1.ForeColor = Color.YellowGreen;
                        }
                        if (label2.Text == "")
                        {
                            label2.ForeColor = Color.YellowGreen;
                        }
                        if (label3.Text == "")
                        {
                            label3.ForeColor = Color.YellowGreen;
                        }
                        if (label4.Text == "")
                        {
                            label4.ForeColor = Color.YellowGreen;
                        }
                        if (label5.Text == "")
                        {
                            label5.ForeColor = Color.YellowGreen;
                        }
                        if (label6.Text == "")
                        {
                            label6.ForeColor = Color.YellowGreen;
                        }
                        if (label7.Text == "")
                        {
                            label7.ForeColor = Color.YellowGreen;
                        }
                    }
                    if (kategorie.Contains("Haushalt"))
                    {
                        if (label1.Text == "")
                        {
                            label1.ForeColor = Color.Cyan;
                        }
                        if (label2.Text == "")
                        {
                            label2.ForeColor = Color.Cyan;
                        }
                        if (label3.Text == "")
                        {
                            label3.ForeColor = Color.Cyan;
                        }
                        if (label4.Text == "")
                        {
                            label4.ForeColor = Color.Cyan;
                        }
                        if (label5.Text == "")
                        {
                            label5.ForeColor = Color.Cyan;
                        }
                        if (label6.Text == "")
                        {
                            label6.ForeColor = Color.Cyan;
                        }
                        if (label7.Text == "")
                        {
                            label7.ForeColor = Color.Cyan;
                        }
                    }
                    if (kategorie.Contains("Sonstiges"))
                    {
                        if (label1.Text == "")
                        {
                            label1.ForeColor = Color.BlueViolet;
                        }
                        if (label2.Text == "")
                        {
                            label2.ForeColor = Color.BlueViolet;
                        }
                        if (label3.Text == "")
                        {
                            label3.ForeColor = Color.BlueViolet;
                        }
                        if (label4.Text == "")
                        {
                            label4.ForeColor = Color.BlueViolet;
                        }
                        if (label5.Text == "")
                        {
                            label5.ForeColor = Color.BlueViolet;
                        }
                        if (label6.Text == "")
                        {
                            label6.ForeColor = Color.BlueViolet;
                        }
                        if (label7.Text == "")
                        {
                            label7.ForeColor = Color.BlueViolet;
                        }
                    }
                    uhrzeit = reader.ReadLine();
                    reader.ReadLine();
                    ereignis = reader.ReadLine();
                    if (label1.Text == "")
                    {
                        label1.Visible = true;
                        label1.Text = uhrzeit + " " + ereignis;
                    }
                    else
                    {
                        if (label1.Text != ereignis)
                        {
                            if (label2.Text == "")
                            {
                                label2.Visible = true;
                                label2.Text = uhrzeit + " " + ereignis;
                            }
                            else
                            {
                                if (label2.Text != ereignis)
                                {
                                    if (label3.Text == "")
                                    {
                                        label3.Visible = true;
                                        label3.Text = uhrzeit + " " + ereignis;
                                    }
                                    else
                                    {
                                        if (label3.Text != ereignis)
                                        {
                                            if (label4.Text == "")
                                            {
                                                label4.Visible = true;
                                                label4.Text = uhrzeit + " " + ereignis;
                                            }
                                            else
                                            {
                                                if (label4.Text != ereignis)
                                                {
                                                    if (label5.Text == "")
                                                    {
                                                        label5.Visible = true;
                                                        label5.Text = uhrzeit + " " + ereignis;
                                                    }
                                                    else
                                                    {
                                                        if (label5.Text != ereignis)
                                                        {
                                                            if (label6.Text == "")
                                                            {
                                                                label6.Visible = true;
                                                                label6.Text = uhrzeit + " " + ereignis;
                                                            }
                                                            else
                                                            {
                                                                if (label6.Text != ereignis)
                                                                {
                                                                    if (label7.Text == "")
                                                                    {
                                                                        label7.Visible = true;
                                                                        label7.Text = uhrzeit + " " + ereignis;
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }

                        }
                    }

                }
            }
            reader.Close();
        }




        /*
         * Methoden
         */

        private void UserControlheutigeTermine_Click(object sender, EventArgs e)
        {
            frmEventssehen frmEventssehen = new frmEventssehen();
            frmEventssehen.Show();
        }
    }
}
