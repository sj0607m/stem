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
        // ���⿡ �̺�Ʈ�� �߰��Ͽ� UI ������Ʈ�� �α� ��� ���� �� �� ����
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
