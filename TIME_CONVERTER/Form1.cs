using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace TIME_CONVERTER
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GetUserTime(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            currentUserTime.Text = dt.ToString("Local "+"h:mm tt");
            UTCTime.Text = DateTime.UtcNow.ToString("Uni "+"h:mm tt");
        }

        private void PSTButton_Click(object sender, EventArgs e)
        {
            var utc = DateTime.UtcNow;
            TimeZoneInfo pacificZone = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time");
            var conversionTime = TimeZoneInfo.ConvertTimeFromUtc(utc, pacificZone);
            newTimeZone.Text = conversionTime.ToString("h:mm tt");
        }

        private void ESTButton_Click(object sender, EventArgs e)
        {
            var utc = DateTime.UtcNow;
            TimeZoneInfo easternStandardTime = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");
            var conversionTime = TimeZoneInfo.ConvertTimeFromUtc(utc, easternStandardTime);
            newTimeZone.Text = conversionTime.ToString("h:mm tt");
        }

        private void CSTButton_Click(object sender, EventArgs e)
        {
            var utc = DateTime.UtcNow;
            TimeZoneInfo centralStandardTime = TimeZoneInfo.FindSystemTimeZoneById("Central Standard Time");
            var consversionTime = TimeZoneInfo.ConvertTimeFromUtc(utc, centralStandardTime);
            newTimeZone.Text = consversionTime.ToString("h:mm tt");
        }

        private void MSTButton_Click(object sender, EventArgs e)
        {
            var utc = DateTime.UtcNow;
            TimeZoneInfo mountainStandardTime = TimeZoneInfo.FindSystemTimeZoneById("Mountain Standard Time");
            var conversionTime = TimeZoneInfo.ConvertTimeFromUtc(utc, mountainStandardTime);
            newTimeZone.Text = conversionTime.ToString("h:mm tt");
        }

        private void ASTButton_Click(object sender, EventArgs e)
        {
            var utc = DateTime.UtcNow;
            TimeZoneInfo alaskaStandardTime = TimeZoneInfo.FindSystemTimeZoneById("Alaskan Standard Time");
            var conversionTime = TimeZoneInfo.ConvertTimeFromUtc(utc, alaskaStandardTime);
            newTimeZone.Text = conversionTime.ToString("h:mm tt");
        }

        private void HSTButton_Click(object sender, EventArgs e)
        {
            var utc = DateTime.UtcNow;//gets universal time from system if system time is wrong then the conversion will be wrong 
            TimeZoneInfo hawaiianTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Hawaiian Standard Time");//gets hiwaiian time zone 
            var conversionTime = TimeZoneInfo.ConvertTimeFromUtc(utc, hawaiianTimeZone);//converts uni to hawaiian time zone
            newTimeZone.Text = conversionTime.ToString("h:mm tt");//to sting in newTimeZone
        }

        private void NonSystemTimeModesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            OFFLINEMode Form2 = new OFFLINEMode();
            Form2.Show();
        }
    }
}