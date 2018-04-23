using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;

namespace WindowsApplication45 {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
		}

		private void listBoxControl1_MouseMove(object sender, MouseEventArgs e) {
			ListBoxControl listBoxControl = sender as ListBoxControl;
			int index = listBoxControl.IndexFromPoint(new Point(e.X, e.Y));
			if(index != -1) {
				string item = listBoxControl.GetItem(index) as string;
				toolTipController1.ShowHint(item, listBoxControl.PointToScreen(new Point(e.X, e.Y)));
			} else {
				toolTipController1.HideHint();
			}

		}

		private void listBoxControl1_MouseLeave(object sender, EventArgs e) {
			toolTipController1.HideHint();
		}
	}
}