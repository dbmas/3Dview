using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp30
{
    public static class ControlHelper
    {
        /// <summary>
        /// 判断子窗体是否打开
        /// </summary>
        /// <param name="formName"></param>
        /// <returns></returns>
        public static bool MdiChildWinIsOpened(this Form parentFrm, string frmName)
        {
            bool isOpen = false;
            foreach (Form childrenForm in parentFrm.MdiChildren)
            {
                // 检测是不是当前子窗口名称
                if (childrenForm.Name == frmName)
                {
                    // 是，显示
                    childrenForm.Visible = true;
                    // 激活
                    childrenForm.Activate();
                    isOpen = true;
                }
            }
            return isOpen;
        }

        /// <summary>
        /// 根据窗口名称打开Mdi子窗口
        /// </summary>
        /// <param name="parentFrm">父窗口，默认this</param>
        /// <param name="frmClassFullName">Form类的全名称：命名空间名.类名   </param>
        /// <param name="assembly">程序集</param>
        public static void MdiChildWinOpen(this Form parentFrm, string frmName, Assembly assembly)
        {

            // 判断子窗体是否打开, 如果没有打开
            if (MdiChildWinIsOpened(parentFrm, frmName) == false)
            {

                // 拼接成class的全名称：命名空间名.类名
                // 通过，分割，取第一个字符串strList[0]为"命名空间名" 
                string[] strList = assembly.FullName.Split(',');
                string frmFullName = string.Format("{0}.{1}", strList[0], frmName);

                // 根据class的全名称，实例化窗体
                Form frm = assembly.CreateInstance(frmFullName) as Form;
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.Show();
            }
        }
    }
}
