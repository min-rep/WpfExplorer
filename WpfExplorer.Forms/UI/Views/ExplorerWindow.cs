using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfExplorer.Support.UI.Units;

namespace WpfExplorer.Forms.UI.Views
{
    public class ExplorerWindow : DarkWindow
    {
        static ExplorerWindow()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ExplorerWindow), new FrameworkPropertyMetadata(typeof(ExplorerWindow)));
            //DefaultStyleKeyProperty는 WPF에서 스타일의 기본 키를 정의하는 데 사용됩니다. 이를 통해 특정 컨트롤의 기본 스타일을 지정할 수 있습니다.
            //반면, BasedOn 속성은 스타일이 다른 스타일을 기반으로 확장될 때 사용됩니다.
        }
    }
}
