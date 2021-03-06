using CustomHandlerDemo.Controls;
using Microsoft.Maui.Handlers;

namespace CustomHandlerDemo.Handlers
{
    public partial class ExtendedEntryViewHandler
    {
        public static PropertyMapper<ExtendedEntry, ExtendedEntryViewHandler> ExtendedEntryViewMapper =
            //Map default entry handler
            new(EntryHandler.Mapper)
            {
                //Map any custom property
                //[nameof(HeartBeatView.IsBeating)] = MapIsBeating
            };

        public ExtendedEntryViewHandler(IPropertyMapper mapper) : base(mapper)
        {
        }

        public ExtendedEntryViewHandler() : base(ExtendedEntryViewMapper)
        {
        }
    }
}
