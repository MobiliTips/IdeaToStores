// --------------------------------------------------------------------------------------------------------------------
// <summary>
//    Defines the PlacesView type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace Motip.App.AroundMe.iOS.Views
{
    using Core.ViewModels;
    using Foundation;
    using UIKit;

    /// <summary>
    /// Defines the PlacesView type.
    /// </summary>
    [Register("PlacesView")]
    public class PlacesView : BaseView
    {
        /// <summary>
        /// Views the did load.
        /// </summary>
        /// <summary>
        /// Called when the View is first loaded
        /// </summary>
        public override void ViewDidLoad()
        {
            this.View = new UIView { BackgroundColor = UIColor.White };

            base.ViewDidLoad();

            UITapGestureRecognizer tap = new UITapGestureRecognizer(() => this.View.ResignFirstResponder());
            this.View.AddGestureRecognizer(tap);
        }
    }
}
