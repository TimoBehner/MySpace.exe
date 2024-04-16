using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySpace1._0
{
    public partial class frmKalender : Form
    {
        /*
         * Allgemeine Attribute
         */
        private static bool neuesEventErstellen;
        int month, year;
        public static int static_month, static_year, day, aktuellesdatum;



        public frmKalender()
        {
            InitializeComponent();
        }

        private void frmKalender_Load(object sender, EventArgs e)
        {
            neuesEventErstellen = false;
            displaDays();
        }
        private void displaDays()
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;
            day = now.Day;
            String monthname = DateTimeFormatInfo.CurrentInfo.MonthNames[month];
            lbDate.Text = monthname + " " + year;

            static_month = month;
            static_year = year;
            //Lets get the day of the month.
            DateTime startOfTheMonth = new DateTime(year, month, 1);
            //get the  count of days of the month
            int days = DateTime.DaysInMonth(year, month);
            //convert the startoftheMonth to integer
            int dayOfTheWeek = Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d")) + 1;
            //lets create a blank usercontrol
            for (int i = 1; i < dayOfTheWeek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                daycontainer.Controls.Add(ucblank);
            }
            //lets create usercontrol for days
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {
            //clear container
            daycontainer.Controls.Clear();
            //increment month to go to next month
            month++;
            static_month = month;
            static_year = year;
            String monthname = DateTimeFormatInfo.CurrentInfo.MonthNames[month];
            lbDate.Text = monthname + " " + year;
            //Lets get the day of the month.
            DateTime startOfTheMonth = new DateTime(year, month, 1);
            //get the  count of days of the month
            int days = DateTime.DaysInMonth(year, month);
            //convert the startoftheMonth to integer
            int dayOfTheWeek = Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d")) + 1;
            //lets create a blank usercontrol
            for (int i = 1; i < dayOfTheWeek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                daycontainer.Controls.Add(ucblank);
            }
            //lets create usercontrol for days
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {
            daycontainer.Controls.Clear();
            //decrement month to go to prevoius month
            month--;
            static_month = month;
            static_year = year;
            String monthname = DateTimeFormatInfo.CurrentInfo.MonthNames[month];
            lbDate.Text = monthname + " " + year;
            //Lets get the day of the month.
            DateTime startOfTheMonth = new DateTime(year, month, 1);
            //get the  count of days of the month
            int days = DateTime.DaysInMonth(year, month);
            //convert the startoftheMonth to integer
            int dayOfTheWeek = Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d")) + 1;
            //lets create a blank usercontrol
            for (int i = 1; i < dayOfTheWeek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                daycontainer.Controls.Add(ucblank);
            }
            //lets create usercontrol for days
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            neuesEventErstellen = true;
        }


        /*
         * Getter
         */
        public static bool getNeuesEventErstellen()
        {
            return neuesEventErstellen;
        }

        private void lbDate_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            daycontainer.Controls.Clear();
            //decrement month to go to prevoius month
            month--;
            static_month = month;
            static_year = year;
            String monthname = DateTimeFormatInfo.CurrentInfo.MonthNames[month];
            lbDate.Text = monthname + " " + year;
            //Lets get the day of the month.
            DateTime startOfTheMonth = new DateTime(year, month, 1);
            //get the  count of days of the month
            int days = DateTime.DaysInMonth(year, month);
            //convert the startoftheMonth to integer
            int dayOfTheWeek = Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d")) + 1;
            //lets create a blank usercontrol
            for (int i = 1; i < dayOfTheWeek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                daycontainer.Controls.Add(ucblank);
            }
            //lets create usercontrol for days
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //clear container
            daycontainer.Controls.Clear();
            //increment month to go to next month
            month++;
            static_month = month;
            static_year = year;
            String monthname = DateTimeFormatInfo.CurrentInfo.MonthNames[month];
            lbDate.Text = monthname + " " + year;
            //Lets get the day of the month.
            DateTime startOfTheMonth = new DateTime(year, month, 1);
            //get the  count of days of the month
            int days = DateTime.DaysInMonth(year, month);
            //convert the startoftheMonth to integer
            int dayOfTheWeek = Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d")) + 1;
            //lets create a blank usercontrol
            for (int i = 1; i < dayOfTheWeek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                daycontainer.Controls.Add(ucblank);
            }
            //lets create usercontrol for days
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }
        }
    }
}
