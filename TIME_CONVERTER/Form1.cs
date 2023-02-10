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
            var pacificTime = TimeZoneInfo.ConvertTimeFromUtc(utc, pacificZone);
            label2.Text = pacificTime.ToString("h:mm tt");

        }

        private void ESTButton_Click(object sender, EventArgs e)
        {
            var utc = DateTime.UtcNow;
            TimeZoneInfo easternStandardTime = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");
            var pacificTime = TimeZoneInfo.ConvertTimeFromUtc(utc, easternStandardTime);
            label2.Text = pacificTime.ToString("h:mm tt");
        }

        private void CSTButton_Click(object sender, EventArgs e)
        {
            var utc = DateTime.UtcNow;
            TimeZoneInfo centralStandardTime = TimeZoneInfo.FindSystemTimeZoneById("Central Standard Time");
            var pacificTime = TimeZoneInfo.ConvertTimeFromUtc(utc, centralStandardTime);
            label2.Text = pacificTime.ToString("h:mm tt");
        }

        private void MSTButton_Click(object sender, EventArgs e)
        {
            var utc = DateTime.UtcNow;
            TimeZoneInfo mountainStandardTime = TimeZoneInfo.FindSystemTimeZoneById("Mountain Standard Time");
            var pacificTime = TimeZoneInfo.ConvertTimeFromUtc(utc, mountainStandardTime);
            label2.Text = pacificTime.ToString("h:mm tt");
        }

        private void ASTButton_Click(object sender, EventArgs e)
        {
            var utc = DateTime.UtcNow;
            TimeZoneInfo alaskaStandardTime = TimeZoneInfo.FindSystemTimeZoneById("Alaskan Standard Time");
            var pacificTime = TimeZoneInfo.ConvertTimeFromUtc(utc, alaskaStandardTime);
            label2.Text = pacificTime.ToString("h:mm tt");
        }

        private void HSTButton_Click(object sender, EventArgs e)
        {
            var utc = DateTime.UtcNow;//gets universal time
            TimeZoneInfo alaskaStandardTime = TimeZoneInfo.FindSystemTimeZoneById("Hawaiian Standard Time");//gets hiwaiian time zone 
            var pacificTime = TimeZoneInfo.ConvertTimeFromUtc(utc, alaskaStandardTime);//converts uni to hiwaiian time zone
            label2.Text = pacificTime.ToString("h:mm tt");//to sting in label2
        }
    }
}