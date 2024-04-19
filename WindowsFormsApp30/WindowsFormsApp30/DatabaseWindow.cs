using DbHelper;
using Models;
using Newtonsoft.Json;
using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp30
{
    public partial class DatabaseWindow : Form
    {
        private bool _isCancel=false;
        public DatabaseWindow()
        {
            /*窗体控件初始化*/
            InitializeComponent();
        }

        /// <summary>
        /// 窗体加载事件,从配置文件读取数据库信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DatabaseWindow_Load(object sender, EventArgs e)
        {
            if (File.Exists(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "tsconfig.json")))
            {
                String confg = File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "tsconfig.json"));
                var cf = JsonConvert.DeserializeObject<Config>(confg);
                url.MyText = cf.url;
                database.MyText = cf.database;
                userName.MyText = cf.userName;
                password.MyText = cf.password;
            }
        }

        /// <summary>
        /// 测试
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void test_Click(object sender, EventArgs e)
        {
            if (
                String.IsNullOrEmpty(url.MyText) ||
                String.IsNullOrEmpty(database.MyText) ||
                String.IsNullOrEmpty(userName.MyText) ||
                String.IsNullOrEmpty(password.MyText))
            {
                MessageBox.Show("请确认信息是否完整");
            }
            else
            {
                //SqlConnection sqlConnection = new SqlConnection($"server={url.MyText};database={database.MyText};user={userName.MyText};password={password.MyText}");
                //if (sqlConnection.State != ConnectionState.Open)
                //{
                //    sqlConnection.Open();
                //    if (sqlConnection.State == ConnectionState.Open)
                //    {
                //        MessageBox.Show("连接成功");
                //    }
                //    else
                //    {
                //        MessageBox.Show("连接失败");
                //    }
                //    sqlConnection.Close();
                //    sqlConnection.Dispose();
                //}

                try
                {
                    ISqlHelper splHelper = InitHelper.GetSqlHelper($"server={url.MyText};database={database.MyText};user={userName.MyText};password={password.MyText}");

                    if (splHelper.Connection.State == ConnectionState.Open)
                    {
                        MessageBox.Show("连接成功");
                    }
                    else
                    {
                        MessageBox.Show("连接失败");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("连接失败" + ex.Message); ;
                }
            }
        }

        /// <summary>
        /// 确认
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void submit_Click(object sender, EventArgs e)
        {
            if (
                String.IsNullOrEmpty(url.MyText) ||
                String.IsNullOrEmpty(database.MyText) ||
                String.IsNullOrEmpty(userName.MyText) ||
                String.IsNullOrEmpty(password.MyText))
            {
                MessageBox.Show("请确认信息是否完整");
            }
            else
            {
                //SqlConnection sqlConnection = new SqlConnection($"server={url.MyText};database={database.MyText};user={userName.MyText};password={password.MyText}");
                //if (sqlConnection.State != ConnectionState.Open)
                //{
                //    sqlConnection.Open();
                //    if (sqlConnection.State == ConnectionState.Open)
                //    {
                //        MessageBox.Show("连接成功");
                //        this.Close();
                //    }
                //    else
                //    {
                //        MessageBox.Show("连接失败");
                //    }
                //    sqlConnection.Close();
                //    sqlConnection.Dispose();
                //}

                ISqlHelper splHelper = InitHelper.GetSqlHelper($"server={url.MyText};database={database.MyText};user={userName.MyText};password={password.MyText}");

                if (splHelper.Connection.State == ConnectionState.Open)
                {
                    MessageBox.Show("连接成功");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("连接失败");
                }
            }
        }


        /// <summary>
        /// 取消
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancel_Click(object sender, EventArgs e)
        {
            _isCancel = true;
            this.Close();
        }

        /// <summary>
        /// 窗口关闭时，将数据库信息保存至配置文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DatabaseWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!_isCancel)
            {
                var cf = new Config();
                cf.url = url.MyText;
                cf.database = database.MyText;
                cf.userName = userName.MyText;
                cf.password = password.MyText;
                File.WriteAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "tsconfig.json"), JsonConvert.SerializeObject(cf));
            }
        }
    }
}
