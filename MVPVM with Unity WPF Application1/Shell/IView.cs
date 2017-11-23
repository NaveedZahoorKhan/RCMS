namespace MVPVM_with_Unity_WPF_Application1
{
    /// <summary>
    /// Base interface for Views
    /// </summary>
    public interface IView
    {
        object DataContext { get; set; }
    }
}
