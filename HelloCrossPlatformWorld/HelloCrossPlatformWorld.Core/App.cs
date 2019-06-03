using MvvmCross.Platform.IoC;

namespace HelloCrossPlatformWorld.Core
{
    public class App : MvvmCross.Core.ViewModels.MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            //when the app starts up, the first thing to show is the FirstViewModel.
            //navigation—the view model is registered as the app starts, so it’s the first thing shown on launch. To show this 
            //view model, MvvmCross will look for the corresponding view and show that.
            //By convention, the view and view model have the same names except for the suffix, and MvvmCross uses this to determine 
            //which view to show for each view model.


            RegisterNavigationServiceAppStart<ViewModels.FirstViewModel>();
        }
    }
}
