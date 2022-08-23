using MENUSELECT;

namespace START
{
    public partial class Start : Form
    {
        public static bool takeOut = false;
        public static int ordercount = 1;
        private int count = 0;
        private string[] eventImageFile = { "ImageDB\\Event_Image\\event1.png", "ImageDB\\Event_Image\\event2.png", "ImageDB\\Event_Image\\event3.png" };

        public Start()
        {
            InitializeComponent();
        }

        private void Start_Load(object sender, EventArgs e)
        {
            eventImage.Load(eventImageFile[2]);
            timer_5Sec.Enabled = true;
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (sender.Equals(btnTakeout))
                takeOut = true;
            else
                takeOut=false;

            MenuSelect_Form menuSelect_Form = new MenuSelect_Form();
            Point parentPoint = this.Location;
            menuSelect_Form.StartPosition = FormStartPosition.Manual;
            menuSelect_Form.Location = new Point(parentPoint.X, parentPoint.Y);
            menuSelect_Form.Show();
            this.Hide();
        }

        private void timer_5Sec_Tick(object sender, EventArgs e)
        {
            eventImage.Load(eventImageFile[count]);
            count++;

            if (count == eventImageFile.Length)
                count = 0;
        }
    }
}
