using Android.Content;
using Android.Graphics.Drawables;
using Google.Android.Material.BottomNavigation;
using JobPortal;
using JobPortal.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(AppShell), typeof(ShellCustomRenderer))]
namespace JobPortal.Droid.Renderers
{
    class ShellCustomRenderer : ShellRenderer
    {

        public ShellCustomRenderer(Context context) : base(context)
        {
        }

        protected override IShellBottomNavViewAppearanceTracker CreateBottomNavViewAppearanceTracker(ShellItem shellItem)
        {
            return new CustomBottomNavAppearance();
        }
    }

    public class CustomBottomNavAppearance : IShellBottomNavViewAppearanceTracker
    {
        public void Dispose()
        {

        }

        public void ResetAppearance(BottomNavigationView bottomView)
        {
        }

        public void SetAppearance(BottomNavigationView bottomView, IShellAppearanceElement appearance)
        {
            //// Create a Gradient Stroke as the new top border. (Set alpha if needed.)
            //GradientStrokeDrawable topBorderLine = new GradientStrokeDrawable { Alpha = 0x33 };

            //// Change it to the color you want.
            //topBorderLine.SetStroke(1, Color.FromRgb(0x00, 0x00, 0x00).ToAndroid());

            //LayerDrawable layerDrawable = new LayerDrawable(new Drawable[] { topBorderLine });
            //layerDrawable.SetLayerInset(0, 0, 0, 0, bottomView.Height - 2);

            //bottomView.SetBackground(layerDrawable);
        }
    }
}
