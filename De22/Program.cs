//----------------------------Câu 1----------------------------//
class BankAccount { 
    private double balance;
    internal void Deposit(double amount) {
        balance += amount;
        Console.WriteLine($"Deposit: {amount}\nBalance: {balance}");
    }
    internal void Withdraw(double amount) {
        balance -= amount;
        Console.WriteLine($"Withdraw: {amount}\nBalance: {balance}");
    }
}
//-------------------------------------------------------------//

//----------------------------Câu 2----------------------------//
class Thermometer{
    public event Action<string> OnTemperatureChanged;
    public void UpdateTemperature(){
        OnTemperatureChanged?.Invoke("Temperature has changed");
    }
}
//-------------------------------------------------------------//
class Program{
    static void Main(string[] args){
        Console.Write("Choose: ");
        int lc = int.Parse(Console.ReadLine());
        if (lc == 1){
            BankAccount bankAccount = new BankAccount();
            bankAccount.Deposit(1000);
            bankAccount.Withdraw(550);
        }
        else if (lc == 2) {
            Thermometer thermometer = new Thermometer();
            thermometer.OnTemperatureChanged += message => Console.WriteLine($"{message}");
            thermometer.UpdateTemperature();
        }
    }
}