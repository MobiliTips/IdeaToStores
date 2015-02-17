// --------------------------------------------------------------------------------------------------------------------
// <summary>
//    Defines the PlacesView type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace Motip.App.AroundMe.Droid.Views
{
    using Android.App;
    using Android.OS;

    /// <summary>
    /// Defines the PlacesView type.
    /// </summary>
    [Activity(Label = "View for PlacesView")]
    public class PlacesView : BaseView
    {
        /// <summary>
        /// Called when [create].
        /// </summary>
        /// <param name="bundle">The bundle.</param>
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            this.SetContentView(Resource.Layout.PlacesView);
        }
    }
}