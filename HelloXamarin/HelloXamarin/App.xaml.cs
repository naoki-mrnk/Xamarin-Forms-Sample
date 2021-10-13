using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloXamarin
{
    // このクラスがエントリポイント
    // Single Activityなので、このクラスはActivityと考えて良い (泥likeな考え方)
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        // アプリケーションの起動時に呼び出される
        protected override void OnStart()
        {
            Console.WriteLine("OnStart");
        }

        // アプリケーションがバックグラウンドに移行した時に呼び出される
        protected override void OnSleep()
        {
            Console.WriteLine("OnSleep");
        }

        // 
        protected override void OnResume()
        {
            Console.WriteLine("OnResume");
        }
        // アプリケーションの終了
    }
}
