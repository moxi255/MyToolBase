using MvvmCross.Platforms.Wpf.Presenters.Attributes;
using MvvmCross.Platforms.Wpf.Views;
using MvvmCross.ViewModels;
using MyTool.Core.ViewModels;

namespace MyTool.Pages
{
    [MvxContentPresentation]
    [MvxViewFor(typeof(TipViewModel))]
    public partial class HomePage : MvxWpfView
    {
        public HomePage()
        {
            InitializeComponent();
        }
    }
}
