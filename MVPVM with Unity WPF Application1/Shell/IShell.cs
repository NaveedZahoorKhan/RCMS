using MVPVM_with_Unity_WPF_Application1;

namespace MVPVM_with_Unity_WPF_Application1
{
    interface IShell : IShellInteraction
    {
        Shell2 View { get; }
    }
}