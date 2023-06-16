using AndroidX.Navigation;
using AndroidX.Navigation.Fragment;

namespace com.companyname.CustomNavigatorIssue
{
    public class CustomNavHostFragment : NavHostFragment
    {
        protected override void OnCreateNavHostController(NavHostController navHostController)
        {
            base.OnCreateNavHostController(navHostController);

            var navigator = new CustomFragmentNavigator();
            navHostController.NavigatorProvider.AddNavigator(navigator);
        }
    }
}
