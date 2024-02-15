using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    public sealed partial class FriendPage : Page
    {
        public FriendPage()
        {
            this.InitializeComponent();
        }
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            MainPage.Instance.AppFrame.GoBack();
        }

        private async void Offline_Click(object sender, RoutedEventArgs e)
        {
            ContentDialog dialog = new ContentDialog
            {
                Title = "用户不在线",
                PrimaryButtonText = "关闭",
                DefaultButton = ContentDialogButton.Primary,
                Content = new TextBlock { Text = "建议联系 GRW 团队以获取帮助" }
            };
            await dialog.ShowAsync();
        }

        private async void Otto_Click(object sender, RoutedEventArgs e)
        {
            await Launcher.LaunchUriAsync(new Uri("https://www.bilibili.com/video/BV1JB4y1s7Dk/"));
        }

        private async void AddButton_Click(object sender, RoutedEventArgs e)
        {
            // （只是整活，实际开发不会这么做
            ContentDialog dialog = new ContentDialog
            {
                Title = "是的，我们没有服务器。",
                PrimaryButtonText = "确定",
                SecondaryButtonText = "取消",
                DefaultButton = ContentDialogButton.Primary,
                Content = new TextBlock { Text = "是否前往基岩版 MC" }
            };
            var result = await dialog.ShowAsync();
            if (result == ContentDialogResult.Primary)
            {
                try
                {
                    await Launcher.LaunchUriAsync(new Uri("minecraft://"));
                }
                catch
                {
                    dialog = new ContentDialog
                    {
                        Title = "啊？",
                        PrimaryButtonText = "确定",
                        SecondaryButtonText = "取消",
                        DefaultButton = ContentDialogButton.Primary,
                        Content = new TextBlock { Text = "您连个国际版 MC 都不装的吗？点击确定即可前往演示页面" }
                    };
                    await dialog.ShowAsync();
                    if (result == ContentDialogResult.Primary)
                    {
                        await Launcher.LaunchUriAsync(new Uri("https://www.bilibili.com/video/BV1C4421F7jS/"));
                    }
                }
            }
        }
    }
}
