namespace classproject
{
    public partial class Form1 : Form
    {

        const int LowTemp= 32;
        const int HighTemp= 36;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CheckTemp_Click(object sender, EventArgs e)
        {
            int Temp=Convert.ToInt32(TempInput.Text);
            if (Temp <= 32)
            {
                Result.Text = "too low";
            }
            if(Temp >= HighTemp)
            {
                Result.Text = "too high";
            }
            if(Temp > LowTemp && Temp < HighTemp)
            {
                Result.Text = "acceptable range";
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}