using DbHelper;
using Models;
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
    public partial class KtxFm : Form
    {
        public KtxFm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ISqlHelper sqlHelper = InitHelper.GetSqlHelper();
            if (sqlHelper == null)
                MessageBox.Show("数据库未连接");
            else
            {
                Ktx model = new Ktx();
                model.KtxNo= labelText1.MyText.Trim();
                model.ZkNo= labelText2.MyText.Trim();
                model.ZkKtxNo= labelText3.MyText.Trim();
                if (string.IsNullOrEmpty(model.KtxNo) || string.IsNullOrEmpty(model.ZkNo) || string.IsNullOrEmpty(model.ZkKtxNo))
                {
                    MessageBox.Show("内容不完整");
                }
                else
                {
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
