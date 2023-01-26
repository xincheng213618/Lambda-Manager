using ACE;
using ACE.Global;
using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Forms;
using System.Xml.Linq;
using MessageBox = System.Windows.MessageBox;

namespace ToolHash
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        AESHelper AESHelper;
        public MainWindow()
        {
            InitializeComponent();

            AESHelper = new AESHelper();
            AESHelper.iRegisterInfo = new RegisterInfoReg();
            var registerInfo = AESHelper.iRegisterInfo.Get() ?? new RegisterInfo();
            this.DataContext = registerInfo;
        }

        string BasePath;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (this.DataContext is RegisterInfo registerInfo)
            {
                if (!Regex.IsMatch(registerInfo.RegistrationDate, "^(?<year>\\d{2,4})-(?<month>\\d{1,2})-(?<day>\\d{1,2})$"))
                {
                    MessageBox.Show("请输入正确的注册日期");
                    return;
                }
                if (!Regex.IsMatch(registerInfo.ExpirationDate, "^(?<year>\\d{2,4})-(?<month>\\d{1,2})-(?<day>\\d{1,2})$"))
                {
                    MessageBox.Show("请输入正确的过期日期");
                    return;
                }
                if (!Regex.IsMatch(registerInfo.Email, @"^[A-Za-z0-9]+([_\.][A-Za-z0-9]+)*@([A-Za-z0-9\-]+\.)+[A-Za-z]{2,6}$"))
                {
                    MessageBox.Show("请输入正确的邮箱地址");
                    return;
                }
                if (!Regex.IsMatch(registerInfo.PhoneNumber, @"^1(3[0-9]|5[0-9]|7[6-8]|8[0-9])[0-9]{8}$"))
                {
                    MessageBox.Show("请输入正确的手机号");
                    return;
                }

                FolderBrowserDialog dialog = new FolderBrowserDialog();
                dialog.Description = "请选择application路径";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    BasePath = dialog.SelectedPath;
                    if (XmlHelper.AddHash(BasePath))
                    {
                        AESHelper.EncryptFileName = BasePath + "\\application.xml";

                        AESHelper.iRegisterInfo.Set(registerInfo);
                        AESHelper.Encrypt();
                        MessageBox.Show("加密成功");
                        //File.Delete(AESHelper.EncryptFileName);
                        File.Move("application.sys", BasePath + "\\application.sys", true);

                        if (Checkbox1.IsChecked == true)
                        {
                            FolderBrowserDialog dialog1 = new FolderBrowserDialog();
                            dialog1.Description = "请选择保存路径";
                            if (dialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                            {
                                File.WriteAllText(dialog1.SelectedPath + "\\default.json", registerInfo.ToBase64());
                            }
                        }

                    };
                }
            }
        }
        SNCode sNCode = new SNCode();
        private void Button_Click1(object sender, RoutedEventArgs e)
        {

            SNTextBolck.Text = Regex.Replace(sNCode.GetSN(), @"(\w{4}(?=[^$]))", "$1-");
        }




        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText(SNTextBolck.Text);


            MessageBox.Show("复制成功");
        }



        private void Button_Click0(object sender, RoutedEventArgs e)
        {
            sNCode = new SNCode() { AreaCode = "0000", DistributorCode = "2210", EquipIdentify = "0000-xxx-xxx-x", ValidityPeriod = DateTime.Now.ToString("yyyyMMdd") };
            StackPanelSN.DataContext = sNCode;
        }
    }

    public static class Clipboard
    {
        [DllImport("User32")]
        public static extern bool OpenClipboard(IntPtr hWndNewOwner);

        [DllImport("User32")]
        public static extern bool CloseClipboard();

        [DllImport("User32")]
        public static extern bool EmptyClipboard();

        [DllImport("User32")]
        public static extern bool IsClipboardFormatAvailable(int format);

        [DllImport("User32")]
        public static extern IntPtr GetClipboardData(int uFormat);

        [DllImport("User32", CharSet = CharSet.Unicode)]
        public static extern IntPtr SetClipboardData(int uFormat, IntPtr hMem);

        public static void SetText(string text)
        {
            if (!OpenClipboard(IntPtr.Zero))
            {
                System.Windows.Clipboard.SetText(text);
                MessageBox.Show("复制成功");
                return;
            }
            EmptyClipboard();
            SetClipboardData(13, Marshal.StringToHGlobalUni(text));
            CloseClipboard();
        }
    }



    public static class Hash
    {
        public static MD5 hash = MD5.Create();
        public static string GetMD5(string path)
        {
            if (File.Exists(path))
            {
                using var stream = new FileStream(path, FileMode.Open);
                byte[] hashByte = hash.ComputeHash(stream);
                return BitConverter.ToString(hashByte).Replace("-", "");
            }
            return string.Empty;
        }
    }
}
