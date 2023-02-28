using System;
using System.Windows;
using System.Windows.Input;

namespace CMS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }
        private void ExitButton(object sender, MouseButtonEventArgs e)
        {
            System.Environment.Exit(1);
        }
        private void MinButton(object sender, MouseButtonEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }
        private void MaxButton(object sender, MouseButtonEventArgs e)
        {
            if (this.WindowState == WindowState.Normal)
            {
                this.WindowState = WindowState.Maximized;
            }
            else
            {
                this.WindowState = WindowState.Normal;
            }
        }

        private void HidePanel(object sender, RoutedEventArgs e)
        {
            if (PanelColumn.Width.Value == 50)
            {
                PanelColumn.Width = new GridLength(160);
                HideIcon.Icon = FontAwesome.Sharp.IconChar.ArrowAltCircleLeft;
                MainPanelSeparator.Width = 140;
            }
            else
            {
                PanelColumn.Width = new GridLength(50);
                HideIcon.Icon = FontAwesome.Sharp.IconChar.ArrowAltCircleRight;
                MainPanelSeparator.Width = 40;
            }
        }
    }
}
