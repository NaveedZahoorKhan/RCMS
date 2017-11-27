using Prism.Regions;

namespace RCMS.Commons.HelperClasses
{
    public class Navigation
    {
        private IRegionManager _regionManager;
        public Navigation(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }
        public void Navigate(string path)
        {
            if (path != null)
            {
                _regionManager.RequestNavigate("MainRegion", path);
            }
        }
    }
}
