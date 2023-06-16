using AndroidX.Navigation;
using Java.Lang;

namespace com.companyname.CustomNavigatorIssue
{
    public class CustomFragmentNavigator : Navigator, Navigator.IName
    {
        public string Value()
        {
            return "customFragment";
        }

        public Class AnnotationType()
        {
            return Class;
        }

        public CustomFragmentNavigator() : base() { }

        public override Object CreateDestination()
        {
            return new NavDestination(this);
        }
    }
}
