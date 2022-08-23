using MySql.Data.MySqlClient;

namespace DB
{
    public static class DataBase
    {
        private static string host = "localhost";
        private static int port = 3306;
        private static string db = "menu_db";
        private static string uid = "root";
        private static string pwd = "qwer";
        private static string connect = string.Format($"Server = {host}; Port = {port}; Database = {db}; Uid = {uid}; Pwd = {pwd}");

        public static MENU.Menu GetMenuByName(string name)
        {
            using (MySqlConnection connection = new MySqlConnection(connect))
            {
                try
                {
                    connection.Open();
                    string sqlcmd = string.Format($"SELECT * FROM menu where Name_kor = '{name}'");
                    MySqlCommand cmd = new MySqlCommand(sqlcmd, connection);
                    MySqlDataReader table = cmd.ExecuteReader();

                    table.Read();
                    MENU.Menu menu = new MENU.Menu(table["Name_kor"].ToString()!, Convert.ToInt32(table["Price"])!,
                        table["Image"].ToString()!, table["Type"].ToString()!, Convert.ToInt32(table["IsSoldout"]), Convert.ToInt32(table["DataNumber"]));
                    return menu;
                }
                catch (Exception)
                {
                    MessageBox.Show("DB ERROR!!");
                    return new MENU.Menu("NULL", 0, "NULL", "NULL", 0, 0);
                }
            }
        }

        public static MENU.Menu[] GetMenuByType(string type)
        {
            int menuCount = 0;

            using(MySqlConnection connection = new MySqlConnection(connect))
            {
                try
                {
                    connection.Open();
                    string sqlcmd = string.Format($"SELECT COUNT(*) FROM menu WHERE Type = '{type}'");
                    MySqlCommand cmd = new MySqlCommand(sqlcmd, connection);
                    MySqlDataReader table = cmd.ExecuteReader();
                    table.Read();
                    menuCount = Convert.ToInt32(table["COUNT(*)"]);
                }
                catch
                {
                    MessageBox.Show("DB ERROR!!");
                }
            }
            MENU.Menu[] menu = new MENU.Menu[menuCount];

            using (MySqlConnection connection = new MySqlConnection(connect))
            {
                try
                {
                    connection.Open();
                    string sqlcmd = string.Format($"SELECT * FROM menu WHERE Type = '{type}'");
                    MySqlCommand cmd = new MySqlCommand(sqlcmd, connection);
                    MySqlDataReader table = cmd.ExecuteReader();

                    int i = 0;
                    while (table.Read())
                    {
                        menu[i] = new MENU.Menu(table["Name_kor"].ToString()!, Convert.ToInt32(table["Price"])!,
                            table["Image"].ToString()!, table["Type"].ToString()!, Convert.ToInt32(table["IsSoldout"]), Convert.ToInt32(table["DataNumber"]));
                        i++;
                    }
                }
                catch
                {
                    MessageBox.Show("DB ERROR!!");
                }
            }
            return menu;
        }

        public static void UpdateDB(MENU.Menu[] menu)
        {
            using (MySqlConnection connection = new MySqlConnection(connect))
            {
                try
                {
                    connection.Open();
                    for (int i = 0; i < menu.Length; i++)
                    {
                        string sqlcmd = string.Format($"UPDATE menu SET isSoldout = {menu[i].isSoldout} WHERE Name_kor = '{menu[i].name}'");
                        MySqlCommand cmd = new MySqlCommand(sqlcmd, connection);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch
                {
                    MessageBox.Show("DB ERROR!!");
                }
            }
        }
    }
}