using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examples
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.PerMonitorV2);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());
        }
    }
}
/*
 * System.ArgumentException
  HResult=0x80070057
  Message=Control does not support transparent background colors.
  Source=System.Windows.Forms
  StackTrace:
   at System.Windows.Forms.Control.set_BackColor(Color value)
   at AcrylicUI.Controls.AcrylicListView..ctor() in C:\Developer\GitHub\colhountech\AcrylicUI\AcrylicUI\Controls\AcrylicListView.cs:line 136
   at Examples.Form7_ListItems.InitializeComponent() in C:\Developer\GitHub\colhountech\AcrylicUI\Examples\Form7_ListItems.Designer.cs:line 33
   at Examples.Form7_ListItems..ctor() in C:\Developer\GitHub\colhountech\AcrylicUI\Examples\Form7_ListItems.cs:line 29
   at Examples.MainWindow.acrylicButton7_Click(Object sender, EventArgs e) in C:\Developer\GitHub\colhountech\AcrylicUI\Examples\MainWindow.cs:line 69
   at System.Windows.Forms.Control.OnClick(EventArgs e)
   at System.Windows.Forms.Button.OnClick(EventArgs e)
   at System.Windows.Forms.Button.OnMouseUp(MouseEventArgs mevent)
   at AcrylicUI.Controls.AcrylicButton.OnMouseUp(MouseEventArgs e) in C:\Developer\GitHub\colhountech\AcrylicUI\AcrylicUI\Controls\AcrylicButton.cs:line 270
   at System.Windows.Forms.Control.WmMouseUp(Message& m, MouseButtons button, Int32 clicks)
   at System.Windows.Forms.Control.WndProc(Message& m)
   at System.Windows.Forms.ButtonBase.WndProc(Message& m)
   at System.Windows.Forms.Button.WndProc(Message& m)
   at System.Windows.Forms.Control.ControlNativeWindow.OnMessage(Message& m)
   at System.Windows.Forms.Control.ControlNativeWindow.WndProc(Message& m)
   at System.Windows.Forms.NativeWindow.Callback(IntPtr hWnd, WM msg, IntPtr wparam, IntPtr lparam)
   at Interop.User32.DispatchMessageW(MSG& msg)
   at System.Windows.Forms.Application.ComponentManager.Interop.Mso.IMsoComponentManager.FPushMessageLoop(UIntPtr dwComponentID, msoloop uReason, Void* pvLoopData)
   at System.Windows.Forms.Application.ThreadContext.RunMessageLoopInner(msoloop reason, ApplicationContext context)
   at System.Windows.Forms.Application.ThreadContext.RunMessageLoop(msoloop reason, ApplicationContext context)
   at System.Windows.Forms.Application.Run(Form mainForm)
   at Examples.Program.Main() in C:\Developer\GitHub\colhountech\AcrylicUI\Examples\Program.cs:line 20

  This exception was originally thrown at this call stack:
    System.Windows.Forms.Control.BackColor.set(System.Drawing.Color)
    AcrylicUI.Controls.AcrylicListView.AcrylicListView() in AcrylicListView.cs
    Examples.Form7_ListItems.InitializeComponent() in Form7_ListItems.Designer.cs
    Examples.Form7_ListItems.Form7_ListItems() in Form7_ListItems.cs
    Examples.MainWindow.acrylicButton7_Click(object, System.EventArgs) in MainWindow.cs
    System.Windows.Forms.Control.OnClick(System.EventArgs)
    System.Windows.Forms.Button.OnClick(System.EventArgs)
    System.Windows.Forms.Button.OnMouseUp(System.Windows.Forms.MouseEventArgs)
    AcrylicUI.Controls.AcrylicButton.OnMouseUp(System.Windows.Forms.MouseEventArgs) in AcrylicButton.cs
    System.Windows.Forms.Control.WmMouseUp(ref System.Windows.Forms.Message, System.Windows.Forms.MouseButtons, int)
    ...
    [Call Stack Truncated]
*/