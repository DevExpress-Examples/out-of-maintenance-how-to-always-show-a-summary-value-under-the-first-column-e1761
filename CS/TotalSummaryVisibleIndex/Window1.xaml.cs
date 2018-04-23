using System.Collections.Generic;
using System.Windows;

namespace TotalSummaryVisibleIndex {
    public partial class Window1 : Window {
        public Window1() {
            InitializeComponent();
            List<SiteInfo> list = new List<SiteInfo>();
            list.Add(new SiteInfo() {
                Category = "Component vendor",
                Hyperlink = "http://devexpress.com",
                Name = "Developer Express"
            });
            list.Add(new SiteInfo() {
                Category = "Search engine",
                Hyperlink = "http://google.com",
                Name = "Google"
            });
            list.Add(new SiteInfo() {
                Category = "Documentation",
                Hyperlink = "http://msdn.com",
                Name = "MSDN"
            });
            grid.ItemsSource = list;
        }
    }
    public class SiteInfo {
        public string Category { get; set; }
        public string Hyperlink { get; set; }
        public string Name { get; set; }
    }
}