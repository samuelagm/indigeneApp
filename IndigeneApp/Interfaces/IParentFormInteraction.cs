using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace IndigeneApp
{
    public interface IParentFormInteraction
    {
        void LoadControl(UserControl control);
        void ShowBackButton();
        void ShowDialog(String content, bool showButton);
        void HideDialog();
        void SetBackButtonPressedListener(IBackNavigationListener listener);
        void SetIndigeneChangeListener(IIndigeneUpdate listener);
        void IndigeneUpdate();
        Grid GetParentOverlay();
        void setHeaderTitle(String title);
        Boolean HasPermission();
        void HideBackButton();
    }
}
