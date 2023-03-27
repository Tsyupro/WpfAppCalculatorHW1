using System;
using System.Collections.Generic;
using System.Data;
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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool mycheker = false;
        public MainWindow()
        {
            InitializeComponent();

            foreach(UIElement uI in Xmain.Children)
            {
                if(uI is Button)
                {
                    ((Button)uI).Click += Button_Click; 
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
          
            
            string str = (string)((Button)e.OriginalSource).Content;
            if(str == "AC")
            {
                str = "";

                TextBox1.Text = str;
                TextBox2.Text = str;

            }
           else if(str == "*")
            {
                mycheker= true;
            }
           else if (str == "/")
            {
                mycheker = true;
            }
            else if (str == "+")
            {
                mycheker = true;
            }
            else if (str == "-")
            {
                mycheker = true;
            }
            else if (str == "=")
            {
                string value = new DataTable().Compute(TextBox1.Text,null).ToString();
                TextBox2.Text = value;
                TextBox1.Text = "";
                str = "";
            }

            TextBox1.Text += str;
            TextBox2.Text += str;
            if (mycheker)
            {
                TextBox2.Text = "";
                mycheker = false;
            }


        }
    }
}
