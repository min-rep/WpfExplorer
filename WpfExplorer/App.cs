using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Jamesnet.Wpf.Controls;
using WpfExplorer.Support.UI.Units;

namespace WpfExplorer
{
    internal class App : JamesApplication
    {
        protected override Window CreateShell()
        {
            // Temporary Window instance
            //return new Window();
            return new DarkWindow();
        }
    }
}
