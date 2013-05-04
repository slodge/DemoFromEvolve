using System.Drawing;
using Cirrious.MvvmCross.Binding.BindingContext;
using Cirrious.MvvmCross.Binding.Touch.Views;
using Cirrious.MvvmCross.Touch.Views;
using Evolved.Core.ViewModels;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace Evolved.Touch.Views
{
    [Register("SecondView")]
    public class SecondView : MvxViewController
    {
        public override void ViewDidLoad()
        {
            View = new UniversalView();

            base.ViewDidLoad();

            // Perform any additional setup after loading the view
            var textbox1 = new UITextField(new RectangleF(0, 0, 320, 50));
            Add(textbox1);
            var table = new UITableView(new RectangleF(0, 50, 320, 550));
            Add(table);
            var source = new MvxStandardTableViewSource(table, "TitleText Name; ImageUrl ImageUrl");
            table.Source = source;

            this.CreateBinding(textbox1).To<SecondViewModel>(vm => vm.Filter).Apply();
            this.CreateBinding(source).To<SecondViewModel>(vm => vm.Kittens).Apply();

            table.ReloadData();
        }
    }
}