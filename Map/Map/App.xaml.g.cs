using System;
using System.Collections.Generic;
using System.Text;

[assembly: global::Xamarin.Forms.Xaml.XamlResourceIdAttribute("MapApp.App.xaml", "App.xaml", typeof(global::MapApp.App))]

namespace MapApp
{


    [global::Xamarin.Forms.Xaml.XamlFilePathAttribute("App.xaml")]
    public partial class App : global::Xamarin.Forms.Application
    {

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private void InitializeComponent()
        {
            global::Xamarin.Forms.Xaml.Extensions.LoadFromXaml(this, typeof(App));
        }
    }
}
