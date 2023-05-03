using Practice___Static_Class__Methods__and_Constructor;

class Program
{
    static void Main(string[] args)
    {
        DailyTransactions.AddTransaction(new Transaction("Big  Brand", 100.0));
        DailyTransactions.AddTransaction(new Transaction("Big  Brand", 50.0));
        DailyTransactions.AddTransaction(new Transaction("Big  Brand", 75.0));
        DailyTransactions.AddTransaction(new Transaction("Big  Brand", 125.0));
        DailyTransactions.AddTransaction(new Transaction("Big  Brand", 90.0));

        DailyTransactions.DisplayAllInfo();
    }
}
