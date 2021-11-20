using CustomHandlerDemo.Controls;
using Microsoft.Maui;
using Microsoft.Maui.Handlers;

namespace CustomHandlerDemo.Handlers
{
    public partial class ExtendedEntryViewHandler
    {
        public static PropertyMapper<ExtendedEntry, ExtendedEntryViewHandler> ExtendedEntryViewMapper =
            //Map default view handler
            new(EntryHandler.ViewMapper)
            {
            };
    }
}
