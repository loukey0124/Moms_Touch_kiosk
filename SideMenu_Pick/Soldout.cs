namespace Admin
{
    public partial class Soldout : Form
    {
        private MENU.Menu[] bugerData = DB.DataBase.GetMenuByType("buger").OrderByDescending(ob => ob.dataNum).ToArray();
        private MENU.Menu[] chickenData = DB.DataBase.GetMenuByType("chicken").OrderByDescending(ob => ob.dataNum).ToArray();
        private MENU.Menu[] setData = DB.DataBase.GetMenuByType("setmenu").OrderByDescending(ob => ob.dataNum).ToArray();
        private MENU.Menu[] sideData = DB.DataBase.GetMenuByType("side").OrderByDescending(ob => ob.dataNum).ToArray();
        private MENU.Menu[] drinkData = DB.DataBase.GetMenuByType("drink").OrderByDescending(ob => ob.dataNum).ToArray();

        public Soldout()
        {
            InitializeComponent();
        }

        private void Soldout_Load(object sender, EventArgs e)
        {
            LogoImage.Load("ImageDB\\Setting\\Logo.png");

            for (int i = 0; i < bugerData.Length; i++)
            {
                bugerListBox.Items.Add(bugerData[i].name);
                if (bugerData[i].isSoldout == 1)
                {
                    bugerListBox.SetItemCheckState(i, CheckState.Checked);
                }
            }
            
            for (int i = 0; i < chickenData.Length; i++)
            {
                chickenListBox.Items.Add(chickenData[i].name);
                if (chickenData[i].isSoldout == 1)
                {
                    chickenListBox.SetItemCheckState(i, CheckState.Checked);
                }
            }

            for (int i = 0; i < setData.Length; i++)
            {
                setListBox.Items.Add(setData[i].name);
                if (setData[i].isSoldout == 1)
                {
                    setListBox.SetItemCheckState(i, CheckState.Checked);
                }
            }

            for (int i = 0; i < sideData.Length; i++)
            {
                sideListBox.Items.Add(sideData[i].name);
                if (sideData[i].isSoldout == 1)
                {
                    sideListBox.SetItemCheckState(i, CheckState.Checked);
                }
            }

            for (int i = 0; i < drinkData.Length; i++)
            {
                drinkListBox.Items.Add(drinkData[i].name);
                if (drinkData[i].isSoldout == 1)
                {
                    drinkListBox.SetItemCheckState(i, CheckState.Checked);
                }
            }
        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DB.DataBase.UpdateDB(bugerData);
            DB.DataBase.UpdateDB(chickenData);
            DB.DataBase.UpdateDB(setData);
            DB.DataBase.UpdateDB(sideData);
            DB.DataBase.UpdateDB(drinkData);
            MessageBox.Show("저장되었습니다.", "알림");
            this.Close();
        }

        private void ItemSelected(object sender, EventArgs e)
        {
            CheckedListBox box = (CheckedListBox)sender;
            switch (box.Name)
            {
                case "bugerListBox":
                    if (bugerData[box.SelectedIndex].isSoldout == 0)
                    {
                        bugerData[box.SelectedIndex].isSoldout = 1;
                    }
                    else
                    {
                        bugerData[box.SelectedIndex].isSoldout = 0;
                    }
                    break;
                case "chickenListBox":
                    if (chickenData[box.SelectedIndex].isSoldout == 0)
                    {
                        chickenData[box.SelectedIndex].isSoldout = 1;
                    }
                    else
                    {
                        chickenData[box.SelectedIndex].isSoldout = 0;
                    }
                    break;
                case "setListBox":
                    if (setData[box.SelectedIndex].isSoldout == 0)
                    {
                        setData[box.SelectedIndex].isSoldout = 1;
                    }
                    else
                    {
                        setData[box.SelectedIndex].isSoldout = 0;
                    }
                    break;
                case "sideListBox":
                    if (sideData[box.SelectedIndex].isSoldout == 0)
                    {
                        sideData[box.SelectedIndex].isSoldout = 1;
                    }
                    else
                    {
                        sideData[box.SelectedIndex].isSoldout = 0;
                    }
                    break;
                case "drinkListBox":
                    if (drinkData[box.SelectedIndex].isSoldout == 0)
                    {
                        drinkData[box.SelectedIndex].isSoldout = 1;
                    }
                    else
                    {
                        drinkData[box.SelectedIndex].isSoldout = 0;
                    }
                    break;
            }
        }
    }
}
