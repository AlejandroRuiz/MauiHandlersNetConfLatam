using Android.Views.Animations;
using Android.Widget;
using CustomHandlerDemo.Controls;
using Microsoft.Maui.Handlers;
using Animation = Android.Views.Animations.Animation;

//Use same namespace as the shared Handler definition
namespace CustomHandlerDemo.Handlers
{
    public partial class HeartBeatViewHandler : ViewHandler<HeartBeatView, ImageView>
    {
        protected override ImageView CreatePlatformView()
        {
            return new ImageView(Context);
        }

        protected override void ConnectHandler(ImageView nativeView)
        {
            nativeView.SetImageResource(Resource.Drawable.heart);
        }

        //Release any resource
        protected override void DisconnectHandler(ImageView nativeView)
        {
            nativeView.SetImageBitmap(null);
        }

        private static void MapIsBeating(HeartBeatViewHandler handler, HeartBeatView view)
        {
            if (view.IsBeating)
            {
                var animation = new Action(() =>
                {
                    var Ani = new ScaleAnimation(1, 1.2f, 1, 1.2f, handler.PlatformView.Width / 2, handler.PlatformView.Height / 2)
                    {
                        RepeatCount = Animation.Infinite,
                        Duration = 750,
                        Interpolator = new HeartBeatInterpolator()
                    };
                    handler.PlatformView.StartAnimation(Ani);
                });
                handler.PlatformView.Post(animation);
            }
            else
            {
                handler.PlatformView.ClearAnimation();
            }
        }

        private class HeartBeatInterpolator : Java.Lang.Object, IInterpolator
        {
            public float GetInterpolation(float input)
            {
                float x = input < 1 / 3f ? 2 * input : (1 + input) / 2;
                return (float)Math.Sin(x * Math.PI);
            }
        }
    }
}
