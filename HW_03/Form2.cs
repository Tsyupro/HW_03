namespace HW_03
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {


            Random random = new Random();
            label1.Location = new Point(random.Next(ClientSize.Width / 2), random.Next(ClientSize.Height / 2));

        }
    }
}
