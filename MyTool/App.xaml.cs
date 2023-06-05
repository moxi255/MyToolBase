﻿using MvvmCross.Core;
using MvvmCross.Platforms.Wpf.Views;

namespace MyTool
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : MvxApplication
    {
        protected override void RegisterSetup()
        {
            this.RegisterSetupType<Setup>();
        }


    }
}
