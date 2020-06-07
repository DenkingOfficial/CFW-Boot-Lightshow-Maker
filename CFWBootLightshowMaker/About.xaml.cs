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

namespace CFWBootLightshowMaker
{
    public partial class About : Window
    {
        public About()
        {
            InitializeComponent();
        }

        private void CloseEvent(object sender, MouseButtonEventArgs e)
        {
            EditorWindow.aboutShows = false;
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
    }
}
