namespace BlazorApp.StateManager.Services
{
    public interface IStateManager<T> where T : class, new()
    {
        T Model { get; set; }
    }
}