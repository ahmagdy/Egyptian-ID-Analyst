using System;
using System.Globalization;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Egyptian_National_ID
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
            //code below belongs to MaterialSkin
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue600, Primary.Blue700, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void Analysbtn_Click(object sender, EventArgs e)
        {
            //we check the input number and if the number length = 14 will move to next step
            if (IDTB.Text.Length == 14)
            {
                //create object from DTFI to get month name
                DateTimeFormatInfo dtfi = new DateTimeFormatInfo();
                //create object from IDAnalyst  which contains all of process
                IDAnalyst id = new IDAnalyst();
                //convert id number from string in textBox to long 
                long num = long.Parse(IDTB.Text);
                //set DateTimePicker "Date" to Date input to extract name of the day and month
                DTP.Value = new DateTime(int.Parse(id.GetBirthYear(num)), int.Parse(id.GetBirthMonth(num)), int.Parse(id.GetBirthDay(num)));
                //assign value of Day TextBox to day from IDAnalyst class and get a day from DateTimePicker
                Daytb.Text = id.GetBirthDay(num)+" : "+DTP.Value.DayOfWeek.ToString();
                //Get Month and using DTFI to get month name which we get from DateTimePicker
                Montb.Text = id.GetBirthMonth(num)+" : "+dtfi.GetMonthName(DTP.Value.Month);
                //Get Month Year  
                Yeartb.Text = id.GetBirthYear(num);
                //Get Sex
                Sextb.Text = id.Sex(num);
                //Get Get Province Name
                provtb.Text = id.GetProvince(num);
                //Get Child number
                cid.Text = id.NumOfChild(num).ToString();
                
            }
        }
    }
}
