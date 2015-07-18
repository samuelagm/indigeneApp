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
using IndigeneApp.Forms;

namespace IndigeneApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IParentFormInteraction
    {
        IndigeneListControl indigeneList;
        IndigeneFormControl indigeneForm;
        IBackNavigationListener backButtonPressedListener = null;
        List<IIndigeneUpdate> indigeneUpdateListeners;
        public PanelManager panelManager;
        WaitDialog waitDialog;

        private String accountType;

        public void SetAccountType(String type) {
            accountType = type;
        }

        public MainWindow() {
            InitializeComponent();
            indigeneUpdateListeners = new List<IIndigeneUpdate>();
            panelManager = new PanelManager(this.ControlsPanel);
            initializeUserControls();
        }

        private void initializeUserControls() {
            indigeneForm = new IndigeneFormControl(this);
            indigeneList = new IndigeneListControl(this);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e) {
            panelManager.LoadControl(indigeneList);

        }

        private void newIndigeneButton_Click(object sender, RoutedEventArgs e) {
            panelManager.LoadControl(indigeneForm);
        }

        private void homeButtom_Click(object sender, RoutedEventArgs e) {
            panelManager.LoadControl(indigeneList);
        }

        private void configurationButton_Click(object sender, RoutedEventArgs e) {
            AccountForm accountForm = new AccountForm();
            accountForm.ShowDialog();
        }


        public void LoadControl(UserControl control) {
            panelManager.LoadControl(control);
        }

        public void ShowBackButton() {
            mainNavigation.Visibility = System.Windows.Visibility.Collapsed;
            backNavigation.Visibility = System.Windows.Visibility.Visible;
        }

        public void ShowDialog(string content, bool showButton) {
            waitDialog = new WaitDialog(this);
            waitDialog.SetDisplayConfiguration(content, showButton);
            Overlay.Visibility = System.Windows.Visibility.Visible;
            waitDialog.ShowDialog();
        }


        public void HideDialog() {
            waitDialog.Close();
        }


        public void SetBackButtonPressedListener(IBackNavigationListener listener) {
            backButtonPressedListener = listener;
        }

        private void backNavigationButton_Click(object sender, RoutedEventArgs e) {
            if (backButtonPressedListener != null)
                backButtonPressedListener.OnBackButtonPressed();
        }

        public Grid GetParentOverlay() {
            return Overlay;
        }

        public void HideBackButton() {
            mainNavigation.Visibility = System.Windows.Visibility.Visible;
            backNavigation.Visibility = System.Windows.Visibility.Hidden;
        }

        public void SetIndigeneChangeListener(IIndigeneUpdate listener) {
            indigeneUpdateListeners.Add(listener);
        }

        public void IndigeneUpdate() {
            foreach(var listener in indigeneUpdateListeners){
                listener.reload();
            }
        }


        public void setHeaderTitle(string title) {
            headerTitle.Content = title.Trim();
        }


        public bool HasPermission() {
            if (accountType == "Administrator")
                return true;
            return false;
        }
    }
}
