using JobPortal;
using JobPortal.iOS.Renderers;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(AppShell), typeof(ShellCustomRenderer))]
namespace JobPortal.iOS.Renderers
{
    public class ShellCustomRenderer : ShellRenderer
    {
        protected override IShellTabBarAppearanceTracker CreateTabBarAppearanceTracker()
        {
            return new TabBarAppearance();
        }

    }

    public class TabBarAppearance : IShellTabBarAppearanceTracker
    {
        public void Dispose()
        {

        }

        public void ResetAppearance(UITabBarController controller)
        {

        }

        public void SetAppearance(UITabBarController controller, ShellAppearance appearance)
        {
        }

        public void UpdateLayout(UITabBarController controller)
        {
        }
    }
}
