using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Jamesnet.Wpf.Controls;
using WpfExplorer.Forms.UI.Views;

namespace WpfExplorer
{
    internal class App : JamesApplication
    {
        protected override Window CreateShell()
        {
            // Temporary Window instance
            //return new Window();          초기 생성 테스트
            //return new DarkWindow();        두번째 테스트
            return new ExplorerWindow();
        }
    }
}
