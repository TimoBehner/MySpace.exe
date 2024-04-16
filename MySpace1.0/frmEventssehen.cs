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
    public partial class frmEventssehen : Form
    {
        /*
         * allgemeine Attribute
         */
        private static int minuten_anfangswert;
        private static int minuten_endwert;
        private static int stunden_anfangswert;
        private static int stunden_endwert;


        public frmEventssehen()
        {
            InitializeComponent();
        }

        private void frmEventssehen_Load(object sender, EventArgs e)
        {
            minuten_anfangswert = 0;
            stunden_anfangswert = 0;
            stunden_endwert = 0;
            minuten_endwert = 0;
            txtüberschrift.Text = "Events für den " + UserControlDays.getDateOfDisplay();
            for (int i = 1; i <= 96; i++)
            {
                UserControlEventsTermin ucdays = new UserControlEventsTermin();
                termincontainer.Controls.Add(ucdays);
                minuten_endwert = minuten_anfangswert + 15;
                if(minuten_endwert >= 60)
                {
                    stunden_endwert++;
                    minuten_endwert = 00;
                }
            }
        }



        /*
         * Methoden 
         */
        public static void anfangswerteNeuDefinieren()
        {
            minuten_anfangswert = minuten_endwert;
            stunden_anfangswert = stunden_endwert;
        }
        

        /*
         * Getter
         */
        public static int getMinuten_anfangswert()
        {
            return minuten_anfangswert;
        }
        public static int getMinuten_endwert()
        {
            return minuten_endwert;
        }
        public static int getStunden_anfangswert()
        {
            return stunden_anfangswert;
        }
        public static int getStunden_endwert()
        {
            return stunden_endwert;
        }
    }
}
