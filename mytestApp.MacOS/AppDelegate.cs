using AppKit;
using Foundation;
using myTestApp;
using Xamarin.Forms;

namespace mytestApp.MacOS
{
    [Register("AppDelegate")]
    public class AppDelegate : global::Xamarin.Forms.Platform.MacOS.FormsApplicationDelegate
    {
        NSWindow window;

        public AppDelegate()
        {
            var style = NSWindowStyle.Closable | NSWindowStyle.Resizable | NSWindowStyle.Titled;
            var rect = new CoreGraphics.CGRect(200, 1000, 1024, 768);

            window = new NSWindow(rect, style, NSBackingStore.Buffered, false);
            window.Title = "Xamarin.Forms On Mac";
            window.TitleVisibility = NSWindowTitleVisibility.Hidden;
        }

        public override NSWindow MainWindow
        {
            get { return window; }
        }
        public override void DidFinishLaunching(NSNotification notification)
        {
            Forms.Init();
            LoadApplication(new App());
            base.DidFinishLaunching(notification);
        }
    }
}
