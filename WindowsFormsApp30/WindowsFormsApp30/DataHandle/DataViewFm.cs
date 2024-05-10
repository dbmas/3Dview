using DapperExtensions.Mapper;
using DbHelper;
using Models;
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
    public partial class DataViewFm : Form
    {
        private ISqlHelper _sqlHelper;
        Dictionary<string, string> _base=new Dictionary<string, string>();
        Dictionary<string, string> _yan=new Dictionary<string, string>();
        Dictionary<string, string> _ktx = new Dictionary<string, string>();
        public DataViewFm()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            DataTable table=new DataTable();
            if (comboBox1.SelectedIndex==0)
            {
                var zkBases=_sqlHelper.GetList<ZkBase>().ToList();
                table = ConvertListToDataTable<ZkBase>(zkBases,_base);
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                var zkYx=_sqlHelper.GetList<ZkYanXing>().ToList();
                table = ConvertListToDataTable(zkYx,_yan);
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                var ktx=_sqlHelper.GetList<Ktx>().ToList();
                table = ConvertListToDataTable<Ktx>(ktx,_ktx);
            }

            dataGridView1.DataSource = table;
            for (int i = 0; i < table.Columns.Count; i++)
            {
                if (dataGridView1.Columns.Count >= i)
                {
                    dataGridView1.Columns[i].HeaderText = table.Columns[i].Caption;
                }
            }
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Refresh();
        }


        private void DataViewFm_Load(object sender, EventArgs e)
        {
            _sqlHelper = DbHelper.InitHelper.GetSqlHelper();
            if (_sqlHelper == null)
            {
                if (MessageBox.Show("数据库未连接，请先连接数据库") == DialogResult.OK)
                {
                    this.Close();
                }
            }
            _base.Add("ZkNo", "钻孔编号");
            _base.Add("ZkQj", "钻孔倾角");
            _base.Add("XZb", "x坐标");
            _base.Add("YZb", "y坐标");
            _base.Add("ZZb", "z坐标");
            _base.Add("ZkSd", "钻孔深度");
            _base.Add("EndSd", "终孔深度");
            _base.Add("EndCw", "终孔层位");
            _base.Add("EndXd", "最终斜度");
            _base.Add("StartDate", "开工日期");
            _base.Add("EndQ", "竣工日期");
            _base.Add("SgDw", "施工单位");
            _base.Add("SgDd", "施工地点");
            _base.Add("CgCw", "穿过层位");
            _base.Add("CgMc", "穿过煤层");
            _base.Add("CjSd", "测井深度");
            _base.Add("CjQ", "测井期");

            _yan.Add("ZkNo", "钻孔编号");
            _yan.Add("DcDmj", "地层代码界");
            _yan.Add("DcDmt", "地层代码统");
            _yan.Add("DcDmd", "地层代码段");
            _yan.Add("YcCh", "岩层层号");
            _yan.Add("DcDmx", "地层代码系");
            _yan.Add("DcDmz", "地层代码组");
            _yan.Add("YcLjJhd", "岩层累计假厚度");
            _yan.Add("YcJhd", "岩层假厚度");
            _yan.Add("YsMc", "岩石名称");
            _yan.Add("YcZhd", "岩层真厚度");
            _yan.Add("YcLjZhd", "岩层累计真厚度");
            _yan.Add("YxMs", "岩性描述");
            _yan.Add("YcQj", "岩层倾角");
            _yan.Add("Cql", "采取率");
            _yan.Add("Cc", "采长");
            _yan.Add("BzcMc", "标志层名称");

            _ktx.Add("KtxNo", "勘探线编号");
            _ktx.Add("ZkNo", "钻孔编号");
            _ktx.Add("ZkKtxNo", "钻孔在该勘探线中的编号");
        }


        /// <summary>
        /// List转DataTable
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        private DataTable ConvertListToDataTable<T>(List<T> items,Dictionary<string,string> keyValues)
        {
            DataTable dataTable = new DataTable();

            // 确保没有元素
            if (items.Count == 0)
                return dataTable;

            // 创建列
            PropertyInfo[] properties = typeof(T).GetProperties();
            foreach (PropertyInfo prop in properties)
            {
                var col = new DataColumn();
                col.ColumnName = prop.Name;
                if (keyValues.ContainsKey(prop.Name))
                    col.Caption = keyValues[prop.Name];
                else 
                    col.Caption = prop.Name;
                dataTable.Columns.Add(col);
            }

            // 创建行
            foreach (T item in items)
            {
                var row = dataTable.NewRow();
                foreach (PropertyInfo prop in properties)
                {
                    row[prop.Name] = prop.GetValue(item, null);
                }
                dataTable.Rows.Add(row);
            }

            return dataTable;
        }
    }
}
