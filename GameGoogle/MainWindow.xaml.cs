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

namespace GameGoogle
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void OpenButton_Click(object sender, RoutedEventArgs e)
        {
            OpenUrl();
        }

        private void UrlTextBox_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            UrlTextBox.Text = string.Empty;
        }

        private void UrlTextBox_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter) OpenUrl();
        }


        private void OpenUrl()
        {
            var text = UrlTextBox.Text;
            var tab1 = $"https://www.google.com/search?q={text}";
            var tab2 = $"https://www.google.com/search?q={text} gameplay&tbm=vid";
            var tab3 = $"https://www.google.com/search?q={text} gameplay&tbm=isch";
            var tab4 = $"https://www.google.com/search?q={text} gameplay gif&tbm=isch";
            var tab5 = $"https://www.google.com/search?q={text} 트레이너";
            var tab6 = $"https://www.google.com/search?q={text} 한글패치";

            System.Diagnostics.Process.Start(tab1);
            System.Diagnostics.Process.Start(tab2);
            System.Diagnostics.Process.Start(tab3);
            System.Diagnostics.Process.Start(tab4);
            System.Diagnostics.Process.Start(tab5);
            System.Diagnostics.Process.Start(tab6);
        }
    }
}
