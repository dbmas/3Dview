using DbHelper;
using ExcelDataReader;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp30
{
    public partial class DataImportFm : Form
    {
        private ISqlHelper _sqlHelper;

        public DataImportFm()
        {
            InitializeComponent();
        }

        DataSet sheets= new DataSet();
        /// <summary>
        /// 选择导入表格
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "表格|*.xlsx;*.xls;*.cvs";
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog.FileName;
                using (var stream=File.Open(openFileDialog.FileName,FileMode.Open,FileAccess.Read)) {
                    using(var reader=ExcelReaderFactory.CreateReader(stream)) {
                         sheets = reader.AsDataSet();
                         Func<List<string>> a =()=>
                         {
                            var tableList =  new List<string>();
                            foreach (var table in sheets.Tables)
                            {
                                tableList.Add(table.ToString());
                            }

                            return tableList;
                        };
                        comboBox1.DataSource = a.Invoke();
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 确定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {

            if (comboBox2.Text.Equals("钻孔基本信息"))
            {
                var sheet = sheets.Tables["钻孔基本信息"];
                if (sheet.Columns.Count < 16)
                {
                    MessageBox.Show("表格格式不正确，钻孔基本信息至少有16列");
                }
                List<ZkBase> list = new List<ZkBase>();
                for (int i = 1; i < sheet.Rows.Count; i++)
                {
                    DataRow dr = sheet.Rows[i];
                    ZkBase zkBase = new ZkBase();
                    zkBase.ZkNo = dr[0].ToString();
                    zkBase.ZkQj = float.Parse(dr[1].ToString());
                    zkBase.XZb = float.Parse(dr[2].ToString());
                    zkBase.YZb = float.Parse(dr[3].ToString());
                    zkBase.ZkSd = float.Parse(dr[4].ToString());
                    zkBase.EndSd = float.Parse(dr[5].ToString());
                    zkBase.EndCw = dr[6].ToString();
                    zkBase.EndXd = float.Parse(dr[7].ToString());
                    zkBase.StartDate = DateTime.Parse(dr[8].ToString());
                    zkBase.EndQ = float.Parse(dr[9].ToString());
                    zkBase.SgDw = dr[10].ToString();
                    zkBase.SgDd = dr[11].ToString();
                    zkBase.CgCw = dr[12].ToString();
                    zkBase.CgMc = dr[13].ToString();
                    zkBase.CjSd = float.Parse(dr[14].ToString());
                    zkBase.CjQ = float.Parse(dr[15].ToString());
                    list.Add(zkBase);
                }

                if(list.Count > 0)
                {
                    try
                    {
                        _sqlHelper.Insert<ZkBase>(list);
                        MessageBox.Show("导入成功");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("导入失败：" + ex.Message);
                    }
                }
            }
            else if (comboBox2.Text.Equals("钻孔岩性信息"))
            {
                var sheet = sheets.Tables["钻孔岩性信息"];
                if (sheet.Columns.Count < 17)
                {
                    MessageBox.Show("表格格式不正确，钻孔岩性信息至少有17列");
                }
                List<ZkYanXing> list = new List<ZkYanXing>();
                for (int i = 1; i < sheet.Rows.Count; i++)
                {
                    DataRow dr = sheet.Rows[i];
                    ZkYanXing zkYan = new ZkYanXing();
                    zkYan.ZkNo = dr[0].ToString();
                    zkYan.DcDmj = dr[1].ToString();
                    zkYan.DcDmt = dr[2].ToString();
                    zkYan.DcDmd = dr[3].ToString();
                    zkYan.YcCh = dr[4].ToString();
                    zkYan.DcDmx = dr[5].ToString();
                    zkYan.DcDmz = dr[6].ToString();
                    zkYan.YcLjJhd = float.Parse(dr[7].ToString());
                    zkYan.YcJhd = float.Parse(dr[8].ToString()); ;
                    zkYan.YsMc = dr[9].ToString();
                    zkYan.YcZhd = dr[10].ToString();
                    zkYan.YcLjZhd = dr[11].ToString();
                    zkYan.YxMs = dr[12].ToString();
                    zkYan.YcQj = float.Parse(dr[13].ToString());
                    zkYan.Cql = float.Parse(dr[14].ToString());
                    zkYan.Cc = float.Parse(dr[15].ToString());
                    zkYan.BzcMc = dr[16].ToString();
                    list.Add(zkYan);
                }
                if (list.Count > 0)
                {
                    try
                    {
                        _sqlHelper.Insert<ZkYanXing>(list);
                        MessageBox.Show("导入成功");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("导入失败：" + ex.Message);
                    }
                }
            }
            else if (comboBox2.Text.Equals("勘探线剖面数据"))
            {
                var sheet = sheets.Tables["勘探线剖面数据"];
                if (sheet.Columns.Count < 3)
                {
                    MessageBox.Show("表格格式不正确，勘探线剖面数据至少有3列");
                }
                List<Ktx> list = new List<Ktx>();
                for (int i = 1; i < sheet.Rows.Count; i++)
                {
                    DataRow dr = sheet.Rows[i];
                    Ktx ktx=new Ktx();
                    ktx.KtxNo = dr[0].ToString();
                    ktx.ZkNo= dr[1].ToString();
                    ktx.ZkKtxNo = dr[2].ToString();
                    list.Add(ktx);
                }
                if (list.Count > 0)
                {
                    try
                    {
                        _sqlHelper.Insert<Ktx>(list);
                        MessageBox.Show("导入成功");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("导入失败："+ex.Message);
                    }
                }
            }
        }

        private void DataImportFm_Load(object sender, EventArgs e)
        {
            _sqlHelper= DbHelper.InitHelper.GetSqlHelper();
            if( _sqlHelper == null )
            {
                if (MessageBox.Show("数据库未连接，请先连接数据库") == DialogResult.OK)
                {
                    this.Close();
                }
            }
        }
    }
}
