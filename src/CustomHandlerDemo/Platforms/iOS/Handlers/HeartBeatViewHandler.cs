using CoreAnimation;
using CustomHandlerDemo.Controls;
using Foundation;
using Microsoft.Maui.Handlers;
using UIKit;

//Use same namespace as the shared Handler definition
namespace CustomHandlerDemo.Handlers
{
    public partial class HeartBeatViewHandler : ViewHandler<HeartBeatView, UIImageView>
    {
        protected override UIImageView CreatePlatformView()
        {
            return new UIImageView();
        }

        protected override void ConnectHandler(UIImageView nativeView)
        {
            nativeView.Image = UIImage.FromBundle("heart");
            nativeView.ContentMode = UIViewContentMode.Top | UIViewContentMode.Center;
        }

        //Release any resource
        protected override void DisconnectHandler(UIImageView nativeView)
        {
            nativeView.Image.Dispose();
            nativeView.Image = null;
        }

        private static void MapIsBeating(HeartBeatViewHandler handler, HeartBeatView view)
        {
            var hasAnimationRegistered = handler.PlatformView.Layer.AnimationForKey("HeartAnimation") != null;

            if (view.IsBeating)
            {
                if (!hasAnimationRegistered)
                {
                    var animation = CABasicAnimation.FromKeyPath("transform.scale");
                    {
                        animation.AutoReverses = true;
                        animation.From = new NSNumber(1);
                        animation.To = new NSNumber(1.08f);
                        animation.Duration = 0.4;
                        animation.RepeatCount = float.MaxValue;
                        animation.TimingFunction = CAMediaTimingFunction.FromName(CAMediaTimingFunction.EaseIn);
                    }

                    handler.PlatformView.Layer.AddAnimation(animation, "HeartAnimation");
                }
            }
            else
            {
                if (hasAnimationRegistered)
                {
                    handler.PlatformView.Layer.RemoveAnimation("HeartAnimation");
                }
            }
        }
    }
}
