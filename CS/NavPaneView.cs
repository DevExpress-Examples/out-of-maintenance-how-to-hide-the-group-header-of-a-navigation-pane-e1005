using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.Utils.Drawing;
using DevExpress.XtraNavBar;
using DevExpress.XtraNavBar.ViewInfo;

namespace CustomNavigation {
	public class CustomNavPaneViewInfo : NavigationPaneViewInfo {
		public CustomNavPaneViewInfo(NavBarControl navBar) : base(navBar) { }
		protected override NavigationPaneHeaderPainter CreateNavPaneHeaderPainter() {
			return new CustomNavPaneHeaderPainter(this);
		}
	}
	public class CustomNavPaneHeaderPainter : NavigationPaneHeaderPainter {
        public CustomNavPaneHeaderPainter(NavigationPaneViewInfo npvi) : base(npvi) { }

		public override Rectangle CalcObjectMinBounds(ObjectInfoArgs e) { 
			return Rectangle.Empty;
		}
	}
	public class CustomNavPaneViewInfoRegistrator : NavigationPaneViewInfoRegistrator {
		public override string ViewName { get { return "CustomNavPaneView"; } }
		public override NavBarViewInfo CreateViewInfo(NavBarControl navBar) {
			return new CustomNavPaneViewInfo(navBar);
		}

	}
}
