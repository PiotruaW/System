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
            System.Console.WriteLine("MaxWindowWidth: " + ContentControlView.Width);

        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (this.WindowState == WindowState.Maximized)
            {
                double mousePosX = e.GetPosition(this).X;
                double width = this.RestoreBounds.Width;
                double left = e.GetPosition(this).X - (width / 2);

                this.WindowState = WindowState.Normal;
                this.Left = left;
                this.Top = 0;
            }

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
                double CVWidth = GridMainPanel.ActualWidth - PanelColumn.Width.Value;
                ContentControlView.Width = CVWidth;
                System.Console.WriteLine("MaxWindowWidth: " + ContentControlView.Width);
            }
            else
            {
                this.WindowState = WindowState.Normal;
                double CVWidth = GridMainPanel.ActualWidth - PanelColumn.Width.Value;
                ContentControlView.Width = CVWidth;
                System.Console.WriteLine("NormalWindowWidth: " + ContentControlView.Width);
            }
        }

        private void HidePanel(object sender, RoutedEventArgs e)
        {
            if (PanelColumn.Width.Value == 50)
            {
                PanelColumn.Width = new GridLength(160);
                double CVWidth = GridMainPanel.ActualWidth - PanelColumn.Width.Value;
                HideIcon.Icon = FontAwesome.Sharp.IconChar.ArrowAltCircleLeft;
                MainPanelSeparator.Width = 140;
                ContentControlView.Width = CVWidth;

                System.Console.WriteLine("Showd: " + ContentControlView.Width);
            }
            else
            {
                PanelColumn.Width = new GridLength(50);
                double CVWidth = GridMainPanel.ActualWidth - PanelColumn.Width.Value;
                HideIcon.Icon = FontAwesome.Sharp.IconChar.ArrowAltCircleRight;
                MainPanelSeparator.Width = 40;
                ContentControlView.Width = CVWidth;
                System.Console.WriteLine("Hidden: " + ContentControlView.Width);
            }
        }
    }
}
