using System;
using System.ComponentModel;
using System.Windows.Input;


namespace MVPVM_with_Unity_WPF_Application1
{

    public interface IShellInteraction
    {
        event CancelEventAction OnShellClosing;
        event Action OnShellClosed;
    }

    public delegate void CancelEventAction(CancelEventArgs e);
}
