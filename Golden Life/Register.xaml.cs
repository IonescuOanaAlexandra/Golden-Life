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
    public partial class Register : Window
    {
        public string name { get; set; } = "playerName.text";
        public Register()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, RoutedEventArgs e)
        {
            //if (playerName.Text == "Abcd")
            //{
                LevelSelect levelSelect = new LevelSelect();
                Visibility = Visibility.Hidden;
                levelSelect.Show();
            //}
            //else
           // {
            //    MessageBox.Show($"Nume incorect");
           // }
        }
    }
}
