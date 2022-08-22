namespace Message
{
    public partial class MessageForm : Form
    {
        Card.CardForm messageform;
        public MessageForm(Card.CardForm messageform_)
        {
            InitializeComponent();
            this.messageform = messageform_;
        }

        private void MessageForm_Load(object sender, EventArgs e)
        {
            timetxt.Text = DateTime.Now.ToString();
            receiptlist.Items.Clear();

            foreach(ListViewItem item in messageform.receipt.Items)
            {
                
                receiptlist.Items.Add((ListViewItem)item.Clone());
            }
            totaltxt.Text = String.Format($"{messageform.receiptprice,0:N0}원");
            barcodebox.Load("ImageDB\\Setting\\barcode.jpg");

            string takeout = "매장";
            if (START.Start.takeOut == true)
                takeout = "포장";

            l_takeout.Text = takeout;
        }
    }
}
