using System.Collections.Generic;
using System.Windows;
using DevExpress.Xpf.Core;

namespace DXSample {
    public partial class App : Application {
        protected override void OnStartup(StartupEventArgs e) {            
            HideClassicThemes();            
            base.OnStartup(e);
        }
        void HideClassicThemes() {
            List<string> ModernThemeCaterogies = new List<string>() { 
                Theme.Office2016Category, 
                Theme.Office2016SECategory, 
                Theme.Office2019Category,
                Theme.VisualStudioCategory, 
                Theme.MetropolisCategory 
            };

            foreach (Theme theme in Theme.Themes) {               
                theme.ShowInThemeSelector = ModernThemeCaterogies.Contains(theme.Category);
            }
        }
    }
}
