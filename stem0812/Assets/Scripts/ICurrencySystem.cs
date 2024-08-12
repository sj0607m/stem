public interface ICurrencySystem
{
    int GetBalance();
    void AddCurrency(int amount);
    bool SpendCurrency(int amount);
}
