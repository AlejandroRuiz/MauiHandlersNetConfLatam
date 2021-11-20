using CustomHandlerDemo.Controls;
using Microsoft.Maui;
using Microsoft.Maui.Handlers;

namespace CustomHandlerDemo.Handlers
{
    public partial class HeartBeatViewHandler
    {
        public static PropertyMapper<HeartBeatView, HeartBeatViewHandler> HeartBeatViewMapper =
            //Map default view handler
            new(ViewHandler.ViewMapper)
            {
                [nameof(HeartBeatView.IsBeating)] = MapIsBeating
            };

        public HeartBeatViewHandler(IPropertyMapper mapper,
            CommandMapper commandMapper = null) : base(mapper, commandMapper)
        {
        }

        public HeartBeatViewHandler() : base(HeartBeatViewMapper, null)
        {
        }
    }
}
