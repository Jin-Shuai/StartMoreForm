using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StartMoreForm
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //注销 20190706
            //Application.Run(new ELFrm());
            //调用用于显示窗体的类
            Application.Run(new MultiFrmApplictionStart());    
        }
    }
}
