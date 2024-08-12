public class GoldCurrencySystem : ICurrencySystem
{
    private int _balance;

    public GoldCurrencySystem(int initialBalance)
    {
        _balance = initialBalance;
    }

    public int GetBalance()
    {
        return _balance;
    }

    public void AddCurrency(int amount)
    {
        _balance += amount;
        // 여기에 이벤트를 추가하여 UI 업데이트나 로그 기록 등을 할 수 있음
        OnCurrencyChanged?.Invoke(_balance);
    }

    public bool SpendCurrency(int amount)
    {
        if (_balance >= amount)
        {
            _balance -= amount;
            OnCurrencyChanged?.Invoke(_balance);
            return true;
        }
        return false;
    }

    public event Action<int> OnCurrencyChanged;
}
