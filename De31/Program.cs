//----------------------------Câu 1----------------------------//
class Account {
    private double Balance;
    public double getBalance(){
        return Balance;
    }
    public void Deposit(double amount) {
        if (amount > 0) {
            Balance += amount;
            Console.WriteLine("Deposit " + amount + " successfully");
        } else {
            Console.WriteLine("Deposit amount must be positive.");
        }
    }

    public void Withdraw(double amount) {
        if (amount > Balance) {
            Console.WriteLine("Withdraw " + amount + " failed");
        } else if (amount > 0) {
            Balance -= amount;
            Console.WriteLine("Withdraw " + amount + " successfully");
        } else {
            Console.WriteLine("Withdraw amount must be positive.");
        }
    }

}
//-------------------------------------------------------------//

//----------------------------Câu 2----------------------------//
public delegate T CalculationHandler<T>(T a, T b);
class Calculator {
    public int Substract(int a, int b) {
        return a - b;
    }
}
//-------------------------------------------------------------//
class Program{
    static void Main(string[] args){
        Console.Write("Choose: ");
        int lc = int.Parse(Console.ReadLine());
        if (lc == 1){
            Account acc = new Account();
            acc.Deposit(1000);
            Console.WriteLine("Balance: " + acc.getBalance());
            acc.Withdraw(550);
            Console.WriteLine("Balance: " + acc.getBalance());
        }
        else if (lc == 2) {
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());
            CalculationHandler<int> cal = new CalculationHandler<int>(new Calculator().Substract);
            Console.WriteLine("a - b = " + cal(a, b));
        }
    }
}