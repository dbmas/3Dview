using DbHelper;
using Models;
using MyControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp30
{
    public partial class ZkYanXingFm : Form
    {
        public ZkYanXingFm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ISqlHelper sqlHelper = InitHelper.GetSqlHelper();
            if (sqlHelper == null)
                MessageBox.Show("数据库未连接");
            else
            {
                if (string.IsNullOrEmpty(labelText1.MyText.Trim()) || string.IsNullOrEmpty(labelText3.MyText.Trim()) || string.IsNullOrEmpty(labelText2.MyText.Trim()) || string.IsNullOrEmpty(labelText4.MyText.Trim()) || string.IsNullOrEmpty(labelText8.MyText.Trim()) || string.IsNullOrEmpty(labelText6.MyText.Trim()) || string.IsNullOrEmpty(labelText7.MyText.Trim()) || string.IsNullOrEmpty(labelText16.MyText.Trim()) || string.IsNullOrEmpty(labelText14.MyText.Trim()) || string.IsNullOrEmpty(labelText15.MyText.Trim()) || string.IsNullOrEmpty(labelText12.MyText.Trim()) || string.IsNullOrEmpty(labelText11.MyText.Trim()) || string.IsNullOrEmpty(labelText24.MyText.Trim()) || string.IsNullOrEmpty(labelText10.MyText.Trim()) || string.IsNullOrEmpty(labelText22.MyText.Trim()) || string.IsNullOrEmpty(labelText20.MyText.Trim()) || string.IsNullOrEmpty(labelText18.MyText.Trim()))
                {
                    MessageBox.Show("内容不完整");
                }
                else
                {
                    ZkYanXing model = new ZkYanXing();
                    model.ZkNo = labelText1.MyText.Trim();
                    model.DcDmj = labelText3.MyText.Trim();
                    model.DcDmt = labelText2.MyText.Trim();
                    model.DcDmd = labelText4.MyText.Trim();
                    model.YcCh = labelText8.MyText.Trim();
                    model.DcDmx = labelText6.MyText.Trim();
                    model.DcDmz = labelText7.MyText.Trim();
                    model.YcLjJhd = float.Parse(labelText16.MyText.Trim());
                    model.YcJhd = float.Parse(labelText14.MyText.Trim());
                    model.YsMc = labelText15.MyText.Trim();
                    model.YcZhd = labelText12.MyText.Trim();
                    model.YcLjZhd = labelText10.MyText.Trim();
                    model.YxMs = labelText11.MyText.Trim();
                    model.YcQj = float.Parse(labelText24.MyText.Trim());
                    model.Cql = float.Parse(labelText22.MyText.Trim());
                    model.Cc = float.Parse(labelText20.MyText.Trim());
                    model.BzcMc = labelText18.MyText.Trim();
                    try
                    {
                        sqlHelper.Insert(model);
                        MessageBox.Show("保存成功");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
    }
}
