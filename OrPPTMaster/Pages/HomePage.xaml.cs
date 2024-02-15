using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.ViewManagement;
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
    public sealed partial class HomePage : Page
    {
        public HomePage()
        {
            this.InitializeComponent();
        }

        private void SinglePlayer_Click(object sender, RoutedEventArgs e)
        {
            MainPage.FrameNavigate(typeof(SinglePlayer));
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Exit();
        }

        private void AccountButton_Click(object sender, RoutedEventArgs e)
        {
            MainPage.FrameNavigate(typeof(Account));
        }

        private void FriendButton_Click(object sender, RoutedEventArgs e)
        {
            MainPage.FrameNavigate(typeof(FriendPage));
        }

        private void ShopButton_Click(object sender, RoutedEventArgs e)
        {
            MainPage.FrameNavigate(typeof(ShopPage));
        }

        private void Multiplayer_Click(object sender, RoutedEventArgs e)
        {
            MainPage.FrameNavigate(typeof(MultiPlayer));
        }

        private void ServerButton_Click(object sender, RoutedEventArgs e)
        {
            MainPage.FrameNavigate(typeof(ServerPage));
        }
    }
}
