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

namespace IndigeneApp
{
    /// <summary>
    /// Interaction logic for WaitDialog.xaml
    /// </summary>
    public partial class WaitDialog : Window
    {
        IParentFormInteraction parentWindow;
        public WaitDialog() {
            InitializeComponent();
        }
        public WaitDialog(IParentFormInteraction parentWindow) {
            this.parentWindow = parentWindow;
            InitializeComponent();
        }

        public void SetDisplayConfiguration(String content, bool showButton) {
            InitializeComponent();
            contentBox.Text = content.Trim();
            if (showButton)
                buttonContainer.Visibility = System.Windows.Visibility.Visible;
        }

        private void closeButton_Click(object sender, RoutedEventArgs e) {
            this.Close();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e) {
            parentWindow.GetParentOverlay().Visibility = System.Windows.Visibility.Collapsed;
        }
    }
}
