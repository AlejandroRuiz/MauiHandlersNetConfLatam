using Microsoft.Maui.Handlers;
using Microsoft.Maui.Platform.iOS;
using UIKit;

namespace CustomHandlerDemo.Handlers
{
    public partial class ExtendedEntryViewHandler : EntryHandler
    {
        protected override void ConnectHandler(MauiTextField nativeView)
        {
            base.ConnectHandler(nativeView);

            nativeView.BorderStyle = UITextBorderStyle.None;
        }
    }
}
