using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class MainForm : Form
    {
        private ViewControl viewCon;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            viewCon = new ViewControl();
        }

        private void ListViewClear()
        {
            lv_MainVew.Items.Clear();
        }

        private void UpdateListView()
        {
            ListViewClear();
            List<string[]> MainViewListView= viewCon.getAllProduct();
            foreach (string[] ViewString in MainViewListView)
            {
                ListViewItem lvi = new ListViewItem(ViewString);
                lv_MainVew.Items.Add(lvi);
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            int num;
            int puchaseprice;
            int saleprice;

            if(int.TryParse(tb_num.Text.ToString().Trim(), out num) != true)
            {
                MessageBox.Show("수량에 숫자 값만 입력해 주세요.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (int.TryParse(tb_purchasePrice.Text.ToString().Trim(), out puchaseprice) != true)
            {
                MessageBox.Show("매입가에 숫자 값만 입력해 주세요.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (int.TryParse(tb_salePrice.Text.ToString().Trim(), out saleprice) != true)
            {
                MessageBox.Show("판매가에 숫자 값만 입력해 주세요.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            viewCon.AddProduct(tb_Name.Text.ToString(), num, puchaseprice, saleprice);
            UpdateListView();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {

        }

    }
}
