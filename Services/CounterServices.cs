public class CounterService
{
    private readonly Dictionary<string, int> _counters = new();
    public int GetCount(string key)
    {
        return _counters.TryGetValue(key, out var count) ? count : 0;
    }

    public void SetCount(string key , int step)
    {
            _counters[key] = step;
    }

    public void IncrementCount(string key, int step)
    {
        if (_counters.ContainsKey(key))
        {
            _counters[key] += step;
        }
        else
        {
            _counters[key] = step;
        }
    }

}
