namespace MENU
{
    public class Menu
    {
        public string name;
        public int price;
        public string image;
        public string type;
        public int isSoldout = 0;
        public int dataNum;

        public Menu(string name, int price, string image, string type, int sold, int num)
        {
            this.name = name;
            this.price = price;
            this.image = image;
            this.type = type;
            if (sold == 1)
                this.isSoldout = 1;
            this.dataNum = num;
        }
    }
}
