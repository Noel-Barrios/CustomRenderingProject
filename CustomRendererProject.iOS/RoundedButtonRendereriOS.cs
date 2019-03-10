using System;
using CoreGraphics;
using CustomRendererProject;
using CustomRendererProject.iOS;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(RoundedButton), typeof(RoundedButtonRendereriOS))]
namespace CustomRendererProject.iOS
{
    public class RoundedButtonRendereriOS : ButtonRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged(e);

            if (e.OldElement == null)
            {
                Control.Layer.CornerRadius = 20;
                Control.Layer.BorderWidth = 3f;
                Control.Layer.BorderColor = Color.DarkOliveGreen.ToCGColor();
                Control.Layer.BackgroundColor = Color.LightGray.ToCGColor();

                //Control.LeftView = new UIKit.UIView(new CGRect(0, 0, 10, 0));
                //Control.LeftViewMode = UIKit.UITextFieldViewMode.Always;
            }
        }
    }
}
