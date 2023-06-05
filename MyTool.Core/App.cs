using MvvmCross;
using MvvmCross.ViewModels;
using MyTool.Core.Services;
using MyTool.Core.ViewModels;

namespace MyTool.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            Mvx.IoCProvider.RegisterType<ICalculationService, CalculationService>();

           RegisterAppStart<TipViewModel>();
        }
    }
}
