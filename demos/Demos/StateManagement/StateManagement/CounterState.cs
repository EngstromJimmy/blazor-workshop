namespace Demos.StateManagement
{
    public class CounterState
    {
        public int CurrentCount { get; set; }

        public event Action? CountIncremented;

        public Task IncrementCount()
        {
            CurrentCount++;
            CountIncremented?.Invoke();
            return Task.CompletedTask;
        }
    }
}
