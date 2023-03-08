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
            }
            else
            {
                this.WindowState = WindowState.Normal;
            }
        }
                        
        private void HidePanel(object sender, RoutedEventArgs e)
        {
            if (PanelColumn.Width.Value == 160)
            {
                PanelColumn.Width = new GridLength(55);
                HideIcon.Icon = FontAwesome.Sharp.IconChar.ArrowAltCircleLeft;
                MainPanelSeparator.Width = 40;
            }
            else
            {
                PanelColumn.Width = new GridLength(160);
                HideIcon.Icon = FontAwesome.Sharp.IconChar.ArrowAltCircleRight;
                MainPanelSeparator.Width = 140;
            }
        }
    }
}
