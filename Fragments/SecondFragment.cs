using Android.Graphics;
using Android.OS;
using Android.Views;
using Android.Widget;
using AndroidX.Fragment.App;

namespace com.companyname.CustomNavigatorIssue.Fragments
{
    public class SecondFragment : Fragment
    {
        public SecondFragment() { }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            base.OnCreateView(inflater, container, savedInstanceState);

            var view = new FrameLayout(Context);
            view.SetBackgroundColor(Color.Yellow);
            return view;
        }
    }
}
