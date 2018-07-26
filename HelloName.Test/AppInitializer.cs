using System;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace HelloName.Test
    {
        public class AppInitializer
        {
            public static IApp StartApp(Platform platform)
            {
                if (platform == Platform.Android)
                {
                    return ConfigureApp
                           .Android
                           .EnableLocalScreenshots()
                           .ApkFile(@"../../../HelloName/HelloName.Android/bin/Debug/com.companyname.HelloName.apk")
                           .StartApp();
                }

                return ConfigureApp
                       .iOS
                       .EnableLocalScreenshots()
                       .StartApp();
            }
        }
    }
