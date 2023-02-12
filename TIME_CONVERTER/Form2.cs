namespace TIME_CONVERTER
{
    public partial class OFFLINEMode : Form
    {
        public OFFLINEMode()
        {
            InitializeComponent();
        }

        public void backToSystemTimeModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }
        public void TimeZoneConversionMethod(object sender, EventArgs e)
        {
            string userTimeZone = UserTimeZoneUpDown.Text.ToString();
            int userHour = int.Parse(HourUpDown.Text.ToString());
            int userMin = int.Parse(minUpDown.Text.ToString());
            int Hour = int.Parse(amPm.Text.ToString());
            string changeToTime = TimeZoneDomian.Text.ToString();
            if (userTimeZone == "EST" && changeToTime == "EST")
            {
                DateTime dt = DateTime.Now;
                var est = new DateTime(dt.Year, dt.Month, dt.Day, userHour, userMin, dt.Second);
                TimeZoneInfo east = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");
                var conversion = TimeZoneInfo.ConvertTimeFromUtc(est, east);
                ConvertedTime.Text = conversion.ToString();



            }
            if (true)
            {


            }
            if (true)
            {

            }





        }
    }
}
