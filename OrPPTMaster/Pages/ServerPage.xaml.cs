using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
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
    public sealed partial class ServerPage : Page
    {
        public ServerPage()
        {
            this.InitializeComponent();
        }
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            MainPage.Instance.AppFrame.GoBack();
        }

        private void SearchField_TextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
        {
            if (args.Reason == AutoSuggestionBoxTextChangeReason.UserInput)
            {
                string text = sender.Text;
                if ("1145141919810".Contains(text))
                {
                    sender.ItemsSource = new List<string> { "114514191810" };
                }
                else
                {
                    sender.ItemsSource = new List<string> { "未找到" };
                }
            }
        }

        private void JoinServer_Click(object sender, RoutedEventArgs e)
        {
            MainPage.FrameNavigate(typeof(InGame));
        }

        private async void WriteInfo_Click(object sender, RoutedEventArgs e)
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
    }
}
