using System.Text.RegularExpressions;

namespace MENUSELECT
{
    public partial class MenuSelect_Form : Form
    {
        public static bool ispay = false;
        private string soldOutImage = "ImageDB\\Setting\\soldout.png";
        private PictureBox? picBox;
        private Label? label;

        private MENU.Menu[]? buger;
        private MENU.Menu[]? chicken;
        private MENU.Menu[]? setmenu;
        private MENU.Menu[]? side;
        private MENU.Menu[]? drink;

        public MenuSelect_Form()
        {
            InitializeComponent();
            this.FormClosed += Form_Closing!;
        }

        private void UpdateData()
        {
            this.buger = DB.DataBase.GetMenuByType("buger").OrderByDescending(ob => ob.dataNum).ToArray();
            this.chicken = DB.DataBase.GetMenuByType("chicken").OrderByDescending(ob => ob.dataNum).ToArray();
            this.setmenu = DB.DataBase.GetMenuByType("setmenu").OrderByDescending(ob => ob.dataNum).ToArray();
            this.side = DB.DataBase.GetMenuByType("side").OrderByDescending(ob => ob.dataNum).ToArray();
            this.drink = DB.DataBase.GetMenuByType("drink").OrderByDescending(ob => ob.dataNum).ToArray();
        }

        private void SetMenuInfo()
        {
            TabPage[] tab = { Tab_Buger, Tab_Chicken, Tab_Set, Tab_Side, Tab_Drink };

            MENU.Menu[] data= buger!;
            for (int i = 0; i < tab.Length; i++)
            {
                tab[i].Controls.Clear();

                switch (i)
                {
                    case 0:
                        data = (MENU.Menu[])buger!.Clone();
                        break;
                    case 1:
                        data = (MENU.Menu[])chicken!.Clone();
                        break;
                    case 2:
                        data = (MENU.Menu[])setmenu!.Clone();
                        break;
                    case 3:
                        data = (MENU.Menu[])side!.Clone();
                        break;
                    case 4:
                        data = (MENU.Menu[])drink!.Clone();
                        break;
                }

                for (int j = 0; j < data.Length; j++)
                {
                    picBox = new PictureBox();
                    if (data[j].isSoldout == 1)
                    {
                        picBox.Load(soldOutImage);
                        picBox.Tag = true;
                    }
                    else
                    {
                        picBox.Load(data[j].image);
                        picBox.Tag = false;
                    }

                    picBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    picBox.Image.Tag = data[j].type;
                    picBox.Name = data[j].name;
                    picBox.Size = new Size(175, 175);
                    picBox.Location = new Point(195 * (j % 4) + 15, 215 * (j / 4) + 15);
                    picBox.Click += MenuImageClick!;
                    tab[i].Controls.Add(picBox);

                    label = new Label();
                    label.Text = data[j].name;
                    label.Font = new Font(label.Font.Name, 9);
                    label.TextAlign = ContentAlignment.MiddleCenter;
                    label.Size = new Size(picBox.Size.Width, 15);
                    label.Location = new Point((int)picBox.Location.X, (int)picBox.Location.Y + picBox.Size.Height);
                    tab[i].Controls.Add(label);

                    label = new Label();
                    label.Text = String.Format($"{data[j].price}원");
                    label.Font = new Font(label.Font.Name, 9);
                    label.TextAlign = ContentAlignment.MiddleCenter;
                    label.Size = new Size(picBox.Size.Width, 15);
                    label.Location = new Point((int)picBox.Location.X, (int)picBox.Location.Y + picBox.Size.Height + label.Size.Height);
                    tab[i].Controls.Add(label);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            orderView.Items.Clear();
            UpdateData();
            SetMenuInfo();
        }

        private void SetListviewData(object sender, string menuName, int price)
        {
            PictureBox box = (PictureBox)sender;
            if (Convert.ToBoolean(box.Tag) == true)
            {
                return;
            }

            int numOfItem = orderView.Items.Count;

            for (int i = 0; i < numOfItem; i++)
            {
                if (orderView.Items[i].SubItems[0].Text == menuName)
                {
                    int quantity = Convert.ToInt32(orderView.Items[i].SubItems[1].Text);
                    orderView.Items[i].SubItems[1].Text = (++quantity).ToString();
                    orderView.Items[i].SubItems[2].Text = String.Format($"{quantity * price,0:N0}원");
                    return;
                }
            }
            string[] data = { menuName, "1", String.Format($"{price,0:N0}원") };
            ListViewItem item = new ListViewItem(data);
            orderView.Items.Add(item);
            return;
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            MAIN.Program.start.Show();
            this.Close();
        }

        private void Form_Closing(object sender, FormClosedEventArgs e)
        {
            MAIN.Program.start.Show();
        }

        private void btn_Pay_Click(object sender, EventArgs e)
        {
            if (orderView.Items.Count == 0)
                return;
            
            Point parentPoint = this.Location;
            Pay.PayForm payform = new Pay.PayForm(this);
            payform.StartPosition = FormStartPosition.Manual;
            payform.Location = new Point(parentPoint.X + 120, parentPoint.Y + 150);
            payform.ShowDialog();
            if (ispay == true)
            {
                ispay = false;
                this.Close();
            }
        }

        private void momsLogoImage_DoubleClick(object sender, EventArgs e)
        {
            Point parentPoint = this.Location;
            Admin.AdminPage admin = new Admin.AdminPage();
            admin.StartPosition = FormStartPosition.Manual;
            admin.Location = new Point(parentPoint.X + 100, parentPoint.Y + 100);
            admin.ShowDialog();
            Form1_Load(sender, e);
        }

        private void Update_tb_PayPrice()
        {
            int index = orderView.Items.Count;
            int totalPrice = 0;
            string pricestr = "";

            for (int i = 0; i < index; i++)
            {
                pricestr = orderView.Items[i].SubItems[2].Text;
                totalPrice += int.Parse(Regex.Replace(pricestr, @"\D", ""));
            }
            tb_PayPrice.Text = String.Format($"{totalPrice,0:N0}원");
        }

        private void btn_plus_Click(object sender, EventArgs e)
        {
            if (0 == orderView.SelectedItems.Count)
                return;
            else
            {
                int quantity = Convert.ToInt32(orderView.SelectedItems[0].SubItems[1].Text);
                string pricestr = orderView.SelectedItems[0].SubItems[2].Text;
                int price = int.Parse(Regex.Replace(pricestr, @"\D", "")) / quantity;
                orderView.SelectedItems[0].SubItems[1].Text = (++quantity).ToString();
                orderView.SelectedItems[0].SubItems[2].Text = String.Format($"{quantity * price,0:N0}원");
            }
            Update_tb_PayPrice();
        }

        private void btn_minus_Click(object sender, EventArgs e)
        {
            if (0 == orderView.SelectedItems.Count)
                return;
            else
            {
                int quantity = Convert.ToInt32(orderView.SelectedItems[0].SubItems[1].Text);
                string pricestr = orderView.SelectedItems[0].SubItems[2].Text;
                int price = int.Parse(Regex.Replace(pricestr, @"\D", "")) / quantity;
                if (1 == quantity)
                {
                    orderView.SelectedItems[0].Remove();
                    Update_tb_PayPrice();
                    return;
                }
                orderView.SelectedItems[0].SubItems[1].Text = (--quantity).ToString();
                orderView.SelectedItems[0].SubItems[2].Text = String.Format($"{quantity * price,0:N0}원");
            }
            Update_tb_PayPrice();
        }

        private void MenuImageClick(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            if (Convert.ToBoolean(pic.Tag) == true)
            {
                return;
            }

            int index;
            switch (pic.Image.Tag!.ToString())
            {
                case "buger":
                    for (index = 0; index < this.buger!.Length; index++)
                    {
                        if (this.buger[index].name == pic.Name)
                            break;
                    }
                    SetListviewData(sender, this.buger[index].name, this.buger[index].price);
                    break;
                case "chicken":
                    for (index = 0; index < this.chicken!.Length; index++)
                    {
                        if (this.chicken[index].name == pic.Name)
                            break;
                    }
                    SetListviewData(sender, this.chicken[index].name, this.chicken[index].price);
                    break;
                case "setmenu":
                    for (index = 0; index < this.setmenu!.Length; index++)
                    {
                        if (this.setmenu[index].name == pic.Name)
                            break;
                    }
                    Point parentPoint = this.Location;
                    SideMenu_Pick.SidePick sidePickForm = new SideMenu_Pick.SidePick("setmenu1", this);
                    sidePickForm.StartPosition = FormStartPosition.Manual;
                    sidePickForm.Location = new Point(parentPoint.X + 100, parentPoint.Y + 100);
                    sidePickForm.ShowDialog();
                    break;
                case "side":
                    for (index = 0; index < this.side!.Length; index++)
                    {
                        if (this.side[index].name == pic.Name)
                            break;
                    }
                    SetListviewData(sender, this.side[index].name, this.side[index].price);
                    break;
                case "drink":
                    for (index = 0; index < this.drink!.Length; index++)
                    {
                        if (this.drink[index].name == pic.Name)
                            break;
                    }
                    SetListviewData(sender, this.drink[index].name, this.drink[index].price);
                    break;
            }
            Update_tb_PayPrice();
        }
    }
}