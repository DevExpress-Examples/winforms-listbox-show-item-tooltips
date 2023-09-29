<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128622331/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1195)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# WinForms ListBoxControl - Display item tooltips

This example handles the [ToolTipController.GetActiveObjectInfo](https://docs.devexpress.com/WindowsForms/DevExpress.Utils.ToolTipController.GetActiveObjectInfo) event to configure and display a tooltip for a list item on mouse hover. The example uses the [ListBoxControl.IndexFromPoint](https://docs.devexpress.com/WindowsForms/DevExpress.XtraEditors.BaseListBoxControl.IndexFromPoint(System.Drawing.Point)) method to get the item under the mouse pointer.

```csharp
public Form1() {
    InitializeComponent();
    listBoxControl1.ToolTipController = toolTipController1;
    toolTipController1.GetActiveObjectInfo += toolTipController1_GetActiveObjectInfo;
}

private void toolTipController1_GetActiveObjectInfo(object sender, DevExpress.Utils.ToolTipControllerGetActiveObjectInfoEventArgs e) {
    ListBoxControl listBoxControl = e.SelectedControl as ListBoxControl;
    if (listBoxControl == null)
        return;
    int index = listBoxControl.IndexFromPoint(e.ControlMousePosition);
    if (index != -1) {
        string item = listBoxControl.GetItem(index) as string;
        object obj = index.ToString() + item;
        e.Info = new DevExpress.Utils.ToolTipControlInfo(obj, item);
    }
}
```


## Files to Review

* [Form1.cs](./CS/WindowsApplication45/Form1.cs) (VB: [Form1.vb](./VB/WindowsApplication45/Form1.vb))


## Documentation

* [How to: Display a Tooltip for a Particular Visual Element](https://docs.devexpress.com/WindowsForms/1964/common-features/tooltip-management/how-to-display-a-tooltip-for-a-particular-visual-element)
