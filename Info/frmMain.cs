using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Outlook = Microsoft.Office.Interop.Outlook;

namespace Computer_Info
{
    public partial class FrmMain : Form
    {
        static bool IsMinimized = true;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            SetDesktopLocation(Screen.PrimaryScreen.WorkingArea.Width * 70 / 100, Screen.PrimaryScreen.WorkingArea.Bottom * 80 / 100);
        }

        public static string GetLocalIPAddress()
        {
            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
            foreach (NetworkInterface nic in nics)
            {
                if (nic.NetworkInterfaceType != NetworkInterfaceType.Loopback
                    && nic.NetworkInterfaceType != NetworkInterfaceType.Tunnel
                    && nic.OperationalStatus == OperationalStatus.Up
                    && nic.Name.StartsWith("Ethernet") == true
                    && nic.Description.Contains("Hyper-v") == false)
                {

                    foreach (UnicastIPAddressInformation ip in nic.GetIPProperties().UnicastAddresses)
                    {
                        if (ip.Address.AddressFamily == AddressFamily.InterNetwork)
                        {
                            return ip.Address.ToString();
                        }
                    }
                }
            }
            return "";
        }

        private void Notify_Icon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (IsMinimized)
            {
                ShowWindow();
                IsMinimized = false;
            }
            else
            {
                HideWindow();
                IsMinimized = true;
            }

            //if (WindowState == FormWindowState.Normal)
            //{
            //    HideWindow();
            //}
            //else if (WindowState == FormWindowState.Minimized)
            //{
            //    ShowWindow();
            //}
            //else if (WindowState == FormWindowState.Maximized)
            //{
            //    HideWindow();
            //}
        }

        private void ShowWindow()
        {
            Visible = true;
            WindowState = FormWindowState.Normal;
            lblInfo.Text = Environment.MachineName + " " + GetLocalIPAddress();
            //SetDesktopLocation(Screen.PrimaryScreen.WorkingArea.Width - 300, Screen.PrimaryScreen.WorkingArea.Bottom - 100);

            SetDesktopLocation(Screen.PrimaryScreen.WorkingArea.Width * 75 / 100, Screen.PrimaryScreen.WorkingArea.Bottom * 80 / 100);

            Activate();
            TopMost = true;
            Show();

            IsMinimized = false;
        }

        private void HideWindow()
        {
            Visible = false;
            IsMinimized = true;
            TopMost = false;
            Hide();
        }

        private void SendMail()
        {
            try
            {
                Outlook.Application outlook = new Outlook.Application();

                Outlook.MailItem mailItem = (Outlook.MailItem)outlook.CreateItem(Outlook.OlItemType.olMailItem);
                mailItem.Subject = "Please type the subject From " + Environment.MachineName + " IP " + GetLocalIPAddress();
                mailItem.To = "EG195-IT";
                mailItem.HTMLBody = "<html><body><p>Kindly Provide more details about your problem</p><img src='" + TakeScreenShot + "' /></body></html>";
                mailItem.Recipients.ResolveAll();
                mailItem.Display(true);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void MnuItemError_Click(object sender, EventArgs e)
        {
            SendMail();
        }

        private void RunCommand(string Arguments)
        {
            Process.Start("CMD.exe", "/C " + Arguments);
        }

        private void MnuItemIbox_Click(object sender, EventArgs e)
        {
            RunCommand(@"net use z: \\10.72.240.10\ibox");

            RunCommand(@"net use y: \\10.72.240.160\ftpedi");
        }

        private void MnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnClose_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HideWindow();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            HideWindow();
        }

        #region Helper
        private string TakeScreenShot
        {
            get
            {
                Bitmap memoryImage;
                //Set full width, height for image
                memoryImage = new Bitmap(Screen.PrimaryScreen.Bounds.Width,
                                       Screen.PrimaryScreen.Bounds.Height,
                                       PixelFormat.Format32bppArgb);
                Size size = new Size(memoryImage.Width, memoryImage.Height);
                Graphics memoryGraphics = Graphics.FromImage(memoryImage);
                memoryGraphics.CopyFromScreen(0, 0, 0, 0, size);
                string path = "";
                try
                {
                    path = string.Format(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\" + Environment.MachineName + ".jpeg");//Set folder to save image
                    memoryImage.Save(path, ImageFormat.Jpeg);
                }
                catch { };

                return path;
            }
        }

        Outlook.Application GetOutlook
        {
            get
            {
                Outlook.Application application = null;

                // Check whether there is an Outlook process running.
                if (Process.GetProcessesByName("OUTLOOK").Count() > 0)
                {
                    // If so, use the GetActiveObject method to obtain the process and cast it to an Application object.
                    application = Marshal.GetActiveObject("Outlook.Application") as Outlook.Application;
                }
                else
                {

                    // If not, create a new instance of Outlook and sign in to the default profile.
                    application = new Outlook.Application();
                    Outlook.NameSpace nameSpace = application.GetNamespace("MAPI");
                    nameSpace.Logon("", "", Missing.Value, Missing.Value);
                    nameSpace = null;
                }

                // Return the Outlook Application object.
                return application;
            }
        }
        #endregion
    }
}
