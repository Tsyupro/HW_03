namespace HW_03
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            DateTime dateTime = dateTimePicker1.Value;
            MessageBox.Show(dateTime.DayOfWeek.ToString());


        }
    }
}
