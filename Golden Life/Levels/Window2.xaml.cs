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
using System.IO;
using Path = System.IO.Path;

namespace Golden_Life
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        bool AnimationPlaying = false;
        public Window2()
        {
            InitializeComponent();
        }
        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;

            if (Keyboard.IsKeyDown(Key.S) && AnimationPlaying == false)
            {
                MePlayer.Source = new System.Uri(baseDirectory + "\\Animations\\egypt.center.mov");
                AnimationPlaying = true;
            }
            if (Keyboard.IsKeyDown(Key.D) && AnimationPlaying == false)
            {
                MePlayer.Source = new System.Uri(baseDirectory + "\\Animations\\egypt.right.mov");
                AnimationPlaying = true;
            }
            if (Keyboard.IsKeyDown(Key.A) && AnimationPlaying == false)
            {
                MePlayer.Source = new System.Uri(baseDirectory + "\\Animations\\egypt.left.mov");
                AnimationPlaying = true;
            }
        }
        private void MePlayer_Initialized(object sender, EventArgs e)
        {
            MePlayer.Pause();
        }
        private void MePlayer_MediaEnded(object sender, RoutedEventArgs e)
        {
            AnimationPlaying = false;
        }

        private void MePlayer_MediaOpened(object sender, RoutedEventArgs e)
        {
            MePlayer.Play();
        }
    }
}
