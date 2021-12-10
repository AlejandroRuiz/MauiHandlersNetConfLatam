using AndroidX.AppCompat.Widget;
using Microsoft.Maui.Handlers;

namespace CustomHandlerDemo.Handlers
{
    public partial class ExtendedEntryViewHandler : EntryHandler
    {
        protected override void ConnectHandler(AppCompatEditText nativeView)
        {
            base.ConnectHandler(nativeView);

            nativeView.Background = null;
        }
    }
}
