using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace IndigeneApp
{
    public class PanelManager
    {
        private StackPanel panel;
        public PanelManager(StackPanel panel){
            this.panel = panel;
        }

        public void LoadControl(Control control) {
            this.panel.Children.RemoveRange(0, this.panel.Children.Count);
            this.panel.Children.Add(control);
        }
    }
}
