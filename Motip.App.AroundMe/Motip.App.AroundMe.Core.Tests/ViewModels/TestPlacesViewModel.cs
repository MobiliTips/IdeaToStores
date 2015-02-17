// --------------------------------------------------------------------------------------------------------------------
// <summary>
//    Defines the TestPlacesViewModel type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace Motip.App.AroundMe.Core.Tests.ViewModels
{
    using Core.ViewModels;

    using NUnit.Framework;

    /// <summary>
    /// Defines the TestPlacesViewModel type.
    /// </summary>
    [TestFixture]
    public class TestPlacesViewModel : BaseTest
    {
        /// <summary>
        /// The PlacesViewModel.
        /// </summary>
        private PlacesViewModel placesViewModel;

        /// <summary>
        /// Creates an instance of the object to test.
        /// To allow Ninja automatically create the unit tests
        /// this method should not be changed.
        /// </summary>
        public override void CreateTestableObject()
        {
            this.placesViewModel = new PlacesViewModel();
        }
    }
}
