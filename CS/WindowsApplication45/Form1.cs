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
			listBoxControl1.ToolTipController = toolTipController1;
			toolTipController1.GetActiveObjectInfo+=toolTipController1_GetActiveObjectInfo;
		}

		private void toolTipController1_GetActiveObjectInfo(object sender, DevExpress.Utils.ToolTipControllerGetActiveObjectInfoEventArgs e) {  
			ListBoxControl listBoxControl = e.SelectedControl as ListBoxControl;  
			if(listBoxControl == null)  
				return;  
			int index = listBoxControl.IndexFromPoint(e.ControlMousePosition);  
			if(index != -1) {  
				string item = listBoxControl.GetItem(index) as string;  
				object obj = index.ToString() + item;  
				e.Info = new DevExpress.Utils.ToolTipControlInfo(obj, item);  
			}  
		}
	}
}