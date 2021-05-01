using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace WPF_Final_Exercies
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            widthText = new Label();
            heightText = new Label();
            InitializeComponent();
           
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void slider1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
        
            if (slider1.Value < 200 )
                widthText.Content = "small";
            else if(slider1.Value >= 200 && slider1.Value < 300)
                widthText.Content = "medium";
            else if (slider1.Value >= 300 && slider1.Value < 400)
                widthText.Content = "large";
            else
                widthText.Content = "extra large";

        }

        private void slider2_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (slider2.Value < 60)
                heightText.Content = "small";
            else if (slider2.Value >= 60 && slider2.Value < 90)
                heightText.Content = "medium";
            else if (slider2.Value >= 90 && slider2.Value < 120)
                heightText.Content = "large";
            else
                heightText.Content = "extra large";
        }

        private void submitBtn_Click(object sender, RoutedEventArgs e)
        {
            UserText ut = new UserText();
            ut.userBt.Content = tex.Text;
            ut.userBt.Width = slider1.Value;
            ut.userBt.Height = slider2.Value;
            ut.Show();
            this.Close();
        }
    }
}
