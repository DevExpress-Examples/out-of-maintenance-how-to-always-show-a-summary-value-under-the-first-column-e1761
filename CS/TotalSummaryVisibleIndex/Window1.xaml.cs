using System.Collections.Generic;
using System.Windows;
using System.Windows.Documents;

namespace TotalSummaryVisibleIndex {
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window {
        public Window1() {
            InitializeComponent();
            List<SiteInfo> list = new List<SiteInfo>();
            list.Add(new SiteInfo() {
                Category = "Component vendor",
                Hyperlink = "http://devexpress.com", Name = "Developer Express"
            });
            list.Add(new SiteInfo() {
                Category = "Search engine",
                Hyperlink = "http://google.com", Name = "Google"
            });
            list.Add(new SiteInfo() {
                Category = "Documentation",
                Hyperlink = "http://msdn.com", Name = "MSDN"
            });
            grid.DataSource = list;
        }
    }
    public class SiteInfo {
        public string Category { get; set; }
        public string Hyperlink { get; set; }
        public string Name { get; set; }
    }

}
