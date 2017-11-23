using Microsoft.Practices.Prism.UnityExtensions;
using MVPVM_with_Unity_WPF_Application1.Infrastructure;

namespace MVPVM_with_Unity_WPF_Application1
{
    public partial class App
    {
        protected override UnityBootstrapper GetBootstrapper()
        {
            return new Bootstrapper();
        }
    }
}
