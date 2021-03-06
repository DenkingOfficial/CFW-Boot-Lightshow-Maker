﻿using System;
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

namespace CFWBootLightshowMaker
{
    public partial class EditorWindow : Window
    {
        public static bool aboutShows=false;
        public EditorWindow()
        {
            InitializeComponent();
        }

        private void MinimizeEvent(object sender, MouseButtonEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void CloseEvent(object sender, MouseButtonEventArgs e)
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            this.Close();
        }

        private void TopDrag(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
            e.Handled = true;
        }

        private void AboutEvent(object sender, MouseButtonEventArgs e)
        {
            if (aboutShows == false)
            {
                Window about = new About();
                about.Show();
                about.Topmost = true;
                aboutShows = true;
            }
        }
    }
}
