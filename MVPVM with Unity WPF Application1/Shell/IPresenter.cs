namespace MVPVM_with_Unity_WPF_Application1
{
    /// <summary>
    /// Базовый интерфейс для презентаторов
    /// </summary>
    public interface IPresenter<out TView>
    {
        TView View { get; }
    }
}
