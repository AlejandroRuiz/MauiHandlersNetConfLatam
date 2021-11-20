using Microsoft.Maui.Controls;

namespace CustomHandlerDemo.Controls
{
    public class HeartBeatView : View
    {
        public static readonly BindableProperty IsBeatingProperty =
            BindableProperty.Create(nameof(IsBeating),
                typeof(bool),
                typeof(HeartBeatView),
                default(bool));

        public bool IsBeating
        {
            get => (bool)GetValue(IsBeatingProperty);
            set => SetValue(IsBeatingProperty, value);
        }
    }
}
