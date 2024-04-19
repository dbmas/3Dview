using DbHelper;
using Models;
using MyControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp30
{
    public partial class ZkBaseFm : Form
    {
        public ZkBaseFm()
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
                if(string.IsNullOrEmpty(labelText1.MyText.Trim())|| string.IsNullOrEmpty(labelText2.MyText.Trim())|| string.IsNullOrEmpty(labelText15.MyText.Trim())|| string.IsNullOrEmpty(labelText14.MyText.Trim())|| string.IsNullOrEmpty(labelText13.MyText.Trim())|| string.IsNullOrEmpty(labelText12.MyText.Trim())|| string.IsNullOrEmpty(labelText6.MyText.Trim())|| string.IsNullOrEmpty(labelText5.MyText.Trim())|| string.IsNullOrEmpty(labelText4.MyText.Trim())|| string.IsNullOrEmpty(labelText7.MyText.Trim())|| string.IsNullOrEmpty(labelText17.MyText.Trim())|| string.IsNullOrEmpty(labelText16.MyText.Trim())|| string.IsNullOrEmpty(labelText9.MyText.Trim())|| string.IsNullOrEmpty(labelText10.MyText.Trim())|| string.IsNullOrEmpty(labelText20.MyText.Trim())|| string.IsNullOrEmpty(labelText19.MyText.Trim())|| string.IsNullOrEmpty(labelText18.MyText.Trim()))
                {
                    MessageBox.Show("内容不完整");
                }
                else
                {
                    ZkBase model = new ZkBase();
                    model.ZkNo = labelText1.MyText.Trim();
                    model.ZkQj = float.Parse(labelText2.MyText.Trim());
                    model.XZb = float.Parse(labelText15.MyText.Trim());
                    model.YZb = float.Parse(labelText14.MyText.Trim());
                    model.ZZb = float.Parse(labelText13.MyText.Trim());
                    model.ZkSd = float.Parse(labelText12.MyText.Trim());
                    model.EndSd = float.Parse(labelText6.MyText.Trim());
                    model.EndCw = labelText5.MyText.Trim();
                    model.EndXd = float.Parse(labelText4.MyText.Trim());
                    model.StartDate = DateTime.Parse(labelText7.MyText.Trim());
                    model.EndQ = float.Parse(labelText17.MyText.Trim());
                    model.SgDw = labelText16.MyText.Trim();
                    model.SgDd = labelText9.MyText.Trim();
                    model.CgCw = labelText10.MyText.Trim();
                    model.CgMc = labelText20.MyText.Trim();
                    model.CjSd = float.Parse(labelText19.MyText.Trim());
                    model.CjQ = float.Parse(labelText18.MyText.Trim());
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
