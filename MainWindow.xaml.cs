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

namespace Login
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void txtEnter_Click(object sender, RoutedEventArgs e)
        {
            if(txtAccount.Text == "abc" && txtPassword.Text == "123")
            {
                txtInfo.Text = "登入成功";
            }
            else
            {
                txtInfo.Text = "登入失敗";
            }
        }
    }
}
