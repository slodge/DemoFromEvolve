using System;
using System.Drawing;
using Cirrious.MvvmCross.Binding.BindingContext;
using Cirrious.MvvmCross.Touch.Views;
using Evolved.Core.ViewModels;
using MonoTouch.CoreFoundation;
using MonoTouch.UIKit;
using MonoTouch.Foundation;

namespace Evolved.Touch.Views
{
    [Register("UniversalView")]
    public class UniversalView : UIView
    {
        public UniversalView()
        {
            Initialize();
        }

        public UniversalView(RectangleF bounds)
            : base(bounds)
        {
            Initialize();
        }

        void Initialize()
        {
            BackgroundColor = UIColor.White;
        }
    }

    [Register("FirstView")]
    public class FirstView : MvxViewController
    {
        public override void ViewDidLoad()
        {
            View = new UniversalView();

            base.ViewDidLoad();

            // Perform any additional setup after loading the view
            var label1 = new UILabel(new RectangleF(0, 0, 320, 50));
            Add(label1);
            var textbox1 = new UITextField(new RectangleF(0, 50, 320, 50));
            Add(textbox1);
            var button1 = new UIButton(UIButtonType.RoundedRect);
            button1.Frame = new RectangleF(0, 100, 320, 50);
            button1.SetTitle("Go", UIControlState.Normal);
            Add(button1);

            this.CreateBinding(label1).To<FirstViewModel>(vm => vm.Name).Apply();
            this.CreateBinding(textbox1).To<FirstViewModel>(vm => vm.Name).Apply();
            this.CreateBinding(button1).To<FirstViewModel>(vm => vm.GoCommand).Apply();
        }
    }
}