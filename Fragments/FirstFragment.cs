using Android.Graphics;
using Android.OS;
using Android.Views;
using Android.Widget;
using AndroidX.Fragment.App;
using AndroidX.Navigation;

namespace com.companyname.CustomNavigatorIssue.Fragments
{
    public class FirstFragment : Fragment
    {
        public FirstFragment() { }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            base.OnCreateView(inflater, container, savedInstanceState);

            var view = new FrameLayout(Context);
            view.SetBackgroundColor(Color.Red);

            var btn = new Button(Context)
            {
                LayoutParameters = new FrameLayout.LayoutParams(ViewGroup.LayoutParams.WrapContent, ViewGroup.LayoutParams.WrapContent)
                {
                    Gravity = GravityFlags.Center
                },
                Text = "go to second"
            };
            btn.SetOnClickListener(Navigation.CreateNavigateOnClickListener(Resource.Id.next_action));
            view.AddView(btn);

            return view;
        }
    }
}
