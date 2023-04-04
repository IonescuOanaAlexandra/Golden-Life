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
using System.Windows.Shapes;

namespace Golden_Life
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class LevelSelect : Window
    {
        public LevelSelect()
        {
            InitializeComponent();
            this.DataContext = this;
        }
        public LevelSelect(string text) : this()
        {
            label.Content = text;

        private void lvl1_Click(object sender, RoutedEventArgs e)
        {
            Window2 firstlevel = new Window2();
            Visibility = Visibility.Hidden;
            firstlevel.Show();
        }

        private void lvl2_Click(object sender, RoutedEventArgs e)
        {
            Window3 secondlevel = new Window3();
            Visibility = Visibility.Hidden;
            secondlevel.Show();
        }

        private void lvl3_Click(object sender, RoutedEventArgs e)
        {
            Window4 thirdlevel = new Window4();
            Visibility = Visibility.Hidden;
            thirdlevel.Show();
        }

        private void lvl4_Click(object sender, RoutedEventArgs e)
        {
            Window5 fourthlevel = new Window5();
            Visibility = Visibility.Hidden;
            fourthlevel.Show();
        }

        private void lvl5_Click(object sender, RoutedEventArgs e)
        {
            Window6 fifthlevel = new Window6();
            Visibility = Visibility.Hidden;
            fifthlevel.Show();
        }
    }
}
