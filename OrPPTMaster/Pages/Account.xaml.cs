using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// https://go.microsoft.com/fwlink/?LinkId=234238 上介绍了“空白页”项模板

namespace OrPPTMaster.Pages
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class Account : Page
    {
        public Account()
        {
            this.InitializeComponent();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            MainPage.Instance.AppFrame.GoBack();
        }

        private async void Logout_Click(object sender, RoutedEventArgs e)
        {
            ContentDialog dialog = new ContentDialog
            {
                Title = "您不会真觉得这个是能用的吧？",
                PrimaryButtonText = "关闭",
                DefaultButton = ContentDialogButton.Primary,
                Content = new TextBlock { Text = "这是整活，不是 MC" }
            };
            await dialog.ShowAsync();
        }

        private async void Rename_Click(object sender, RoutedEventArgs e)
        {
            ContentDialog dialog = new ContentDialog
            {
                Title = "输入新的名称",
                PrimaryButtonText = "确定",
                DefaultButton = ContentDialogButton.Primary,
                Content = new TextBox
                {
                    Text = "Never gonna give you up",
                    IsEnabled = false,
                }
            };
            await dialog.ShowAsync();
        }

        private async void UserTip_Click(object sender, RoutedEventArgs e)
        {
            await Launcher.LaunchUriAsync(new Uri("https://github.com/CreeperMPG/OrPPTMaster"));
            MainPage.Instance.Width = 960;
            MainPage.Instance.Height = 480;
            MainPage.Instance.AppFrame.GoBack();
            ContentDialog dialog = new ContentDialog
            {
                Title = "Tip",
                PrimaryButtonText = "OK",
                DefaultButton = ContentDialogButton.Primary,
                Content = new TextBlock { Text = "不要惊慌，也不要反馈 Bug。这是刻意设计的，因为应用在这个分辨率下工作的更好，所以就做了这个功能" }
            };
            await dialog.ShowAsync();
        }
    }
}
