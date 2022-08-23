namespace MENUSELECT
{
    partial class MenuSelect_Form
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuSelect_Form));
            this.momsLogoImage = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Tab_Chicken = new System.Windows.Forms.TabPage();
            this.Tab_Set = new System.Windows.Forms.TabPage();
            this.Tab_Side = new System.Windows.Forms.TabPage();
            this.Tab_Drink = new System.Windows.Forms.TabPage();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_Pay = new System.Windows.Forms.Button();
            this.tb_PayPrice = new System.Windows.Forms.TextBox();
            this.orderView = new System.Windows.Forms.ListView();
            this.order_name = new System.Windows.Forms.ColumnHeader();
            this.order_number = new System.Windows.Forms.ColumnHeader();
            this.order_price = new System.Windows.Forms.ColumnHeader();
            this.Label_totalPrice = new System.Windows.Forms.Label();
            this.btn_plus = new System.Windows.Forms.Button();
            this.btn_minus = new System.Windows.Forms.Button();
            this.Tab_Buger = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.momsLogoImage)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // momsLogoImage
            // 
            this.momsLogoImage.Image = ((System.Drawing.Image)(resources.GetObject("momsLogoImage.Image")));
            this.momsLogoImage.Location = new System.Drawing.Point(12, 15);
            this.momsLogoImage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.momsLogoImage.Name = "momsLogoImage";
            this.momsLogoImage.Size = new System.Drawing.Size(170, 69);
            this.momsLogoImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.momsLogoImage.TabIndex = 0;
            this.momsLogoImage.TabStop = false;
            this.momsLogoImage.DoubleClick += new System.EventHandler(this.momsLogoImage_DoubleClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Tab_Buger);
            this.tabControl1.Controls.Add(this.Tab_Chicken);
            this.tabControl1.Controls.Add(this.Tab_Set);
            this.tabControl1.Controls.Add(this.Tab_Side);
            this.tabControl1.Controls.Add(this.Tab_Drink);
            this.tabControl1.Font = new System.Drawing.Font("돋움", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabControl1.HotTrack = true;
            this.tabControl1.ItemSize = new System.Drawing.Size(160, 50);
            this.tabControl1.Location = new System.Drawing.Point(10, 110);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(810, 640);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 1;
            // 
            // Tab_Chicken
            // 
            this.Tab_Chicken.AutoScroll = true;
            this.Tab_Chicken.AutoScrollMargin = new System.Drawing.Size(0, 50);
            this.Tab_Chicken.Font = new System.Drawing.Font("돋움", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Tab_Chicken.Location = new System.Drawing.Point(4, 54);
            this.Tab_Chicken.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Tab_Chicken.Name = "Tab_Chicken";
            this.Tab_Chicken.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Tab_Chicken.Size = new System.Drawing.Size(802, 582);
            this.Tab_Chicken.TabIndex = 1;
            this.Tab_Chicken.Text = "치킨";
            this.Tab_Chicken.UseVisualStyleBackColor = true;
            // 
            // Tab_Set
            // 
            this.Tab_Set.AutoScroll = true;
            this.Tab_Set.AutoScrollMargin = new System.Drawing.Size(0, 50);
            this.Tab_Set.Font = new System.Drawing.Font("돋움", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Tab_Set.Location = new System.Drawing.Point(4, 54);
            this.Tab_Set.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Tab_Set.Name = "Tab_Set";
            this.Tab_Set.Size = new System.Drawing.Size(802, 582);
            this.Tab_Set.TabIndex = 2;
            this.Tab_Set.Text = "세트메뉴";
            this.Tab_Set.UseVisualStyleBackColor = true;
            // 
            // Tab_Side
            // 
            this.Tab_Side.AutoScroll = true;
            this.Tab_Side.AutoScrollMargin = new System.Drawing.Size(0, 50);
            this.Tab_Side.Font = new System.Drawing.Font("돋움", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Tab_Side.Location = new System.Drawing.Point(4, 54);
            this.Tab_Side.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Tab_Side.Name = "Tab_Side";
            this.Tab_Side.Size = new System.Drawing.Size(802, 582);
            this.Tab_Side.TabIndex = 3;
            this.Tab_Side.Text = "사이드";
            this.Tab_Side.UseVisualStyleBackColor = true;
            // 
            // Tab_Drink
            // 
            this.Tab_Drink.AutoScroll = true;
            this.Tab_Drink.AutoScrollMargin = new System.Drawing.Size(0, 50);
            this.Tab_Drink.Font = new System.Drawing.Font("돋움", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Tab_Drink.Location = new System.Drawing.Point(4, 54);
            this.Tab_Drink.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Tab_Drink.Name = "Tab_Drink";
            this.Tab_Drink.Size = new System.Drawing.Size(802, 582);
            this.Tab_Drink.TabIndex = 4;
            this.Tab_Drink.Text = "음료";
            this.Tab_Drink.UseVisualStyleBackColor = true;
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(662, 26);
            this.btn_Back.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(140, 58);
            this.btn_Back.TabIndex = 2;
            this.btn_Back.Text = "처음메뉴로 돌아가기";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_Pay
            // 
            this.btn_Pay.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Pay.Location = new System.Drawing.Point(667, 875);
            this.btn_Pay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Pay.Name = "btn_Pay";
            this.btn_Pay.Size = new System.Drawing.Size(153, 58);
            this.btn_Pay.TabIndex = 93;
            this.btn_Pay.Text = "결제";
            this.btn_Pay.UseVisualStyleBackColor = true;
            this.btn_Pay.Click += new System.EventHandler(this.btn_Pay_Click);
            // 
            // tb_PayPrice
            // 
            this.tb_PayPrice.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tb_PayPrice.ForeColor = System.Drawing.SystemColors.Window;
            this.tb_PayPrice.Location = new System.Drawing.Point(620, 820);
            this.tb_PayPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_PayPrice.Name = "tb_PayPrice";
            this.tb_PayPrice.ReadOnly = true;
            this.tb_PayPrice.Size = new System.Drawing.Size(200, 39);
            this.tb_PayPrice.TabIndex = 95;
            this.tb_PayPrice.Text = "0원";
            this.tb_PayPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // orderView
            // 
            this.orderView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.order_name,
            this.order_number,
            this.order_price});
            this.orderView.Location = new System.Drawing.Point(10, 760);
            this.orderView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.orderView.Name = "orderView";
            this.orderView.Size = new System.Drawing.Size(600, 200);
            this.orderView.TabIndex = 96;
            this.orderView.UseCompatibleStateImageBehavior = false;
            this.orderView.View = System.Windows.Forms.View.Details;
            // 
            // order_name
            // 
            this.order_name.Text = "상품명";
            this.order_name.Width = 450;
            // 
            // order_number
            // 
            this.order_number.Text = "수량";
            this.order_number.Width = 50;
            // 
            // order_price
            // 
            this.order_price.Text = "금액";
            this.order_price.Width = 90;
            // 
            // Label_totalPrice
            // 
            this.Label_totalPrice.AutoSize = true;
            this.Label_totalPrice.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label_totalPrice.Location = new System.Drawing.Point(670, 785);
            this.Label_totalPrice.Name = "Label_totalPrice";
            this.Label_totalPrice.Size = new System.Drawing.Size(96, 19);
            this.Label_totalPrice.TabIndex = 97;
            this.Label_totalPrice.Text = "결제 금액";
            // 
            // btn_plus
            // 
            this.btn_plus.Location = new System.Drawing.Point(620, 875);
            this.btn_plus.Name = "btn_plus";
            this.btn_plus.Size = new System.Drawing.Size(28, 23);
            this.btn_plus.TabIndex = 98;
            this.btn_plus.Text = "+";
            this.btn_plus.UseVisualStyleBackColor = true;
            this.btn_plus.Click += new System.EventHandler(this.btn_plus_Click);
            // 
            // btn_minus
            // 
            this.btn_minus.Location = new System.Drawing.Point(620, 910);
            this.btn_minus.Name = "btn_minus";
            this.btn_minus.Size = new System.Drawing.Size(28, 23);
            this.btn_minus.TabIndex = 99;
            this.btn_minus.Text = "-";
            this.btn_minus.UseVisualStyleBackColor = true;
            this.btn_minus.Click += new System.EventHandler(this.btn_minus_Click);
            // 
            // Tab_Buger
            // 
            this.Tab_Buger.AutoScroll = true;
            this.Tab_Buger.AutoScrollMargin = new System.Drawing.Size(0, 50);
            this.Tab_Buger.BackColor = System.Drawing.Color.White;
            this.Tab_Buger.Font = new System.Drawing.Font("돋움", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Tab_Buger.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Tab_Buger.Location = new System.Drawing.Point(4, 54);
            this.Tab_Buger.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Tab_Buger.Name = "Tab_Buger";
            this.Tab_Buger.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Tab_Buger.Size = new System.Drawing.Size(802, 582);
            this.Tab_Buger.TabIndex = 0;
            this.Tab_Buger.Text = "버거";
            // 
            // MenuSelect_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(827, 965);
            this.Controls.Add(this.btn_minus);
            this.Controls.Add(this.btn_plus);
            this.Controls.Add(this.Label_totalPrice);
            this.Controls.Add(this.orderView);
            this.Controls.Add(this.tb_PayPrice);
            this.Controls.Add(this.btn_Pay);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.momsLogoImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MenuSelect_Form";
            this.Text = "Mom\'s Touch";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.momsLogoImage)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox momsLogoImage;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Tab_Chicken;
        private System.Windows.Forms.TabPage Tab_Set;
        private System.Windows.Forms.TabPage Tab_Side;
        private System.Windows.Forms.TabPage Tab_Drink;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_Pay;
        private System.Windows.Forms.TextBox tb_PayPrice;
        public System.Windows.Forms.ListView orderView;
        private System.Windows.Forms.ColumnHeader order_name;
        private System.Windows.Forms.ColumnHeader order_number;
        private System.Windows.Forms.ColumnHeader order_price;
        private System.Windows.Forms.Label Label_totalPrice;
        private Button btn_plus;
        private Button btn_minus;
        private TabPage Tab_Buger;
    }
}

