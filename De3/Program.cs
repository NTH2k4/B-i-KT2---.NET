//----------------------------Câu 1----------------------------//
class Account{
    private int Balance;
    public void Deposit(int val){
        this.Balance += val;
        Console.WriteLine("Balance: " + Balance);
    }
    public void WithDraw(int val){
        this.Balance -= val;
        Console.WriteLine("Balance: " + Balance);
    }
}
//-------------------------------------------------------------//

//----------------------------Câu 2----------------------------//
public delegate T MathOperation<T>(T x, T y);
class Advance{
    public int Subtract(int a, int b){
        return a - b;
    }
}
//-------------------------------------------------------------//
class Program{
    static void Main(string[] args){
        Console.Write("Lựa chọn: ");
        int lc = int.Parse(Console.ReadLine());
        if (lc == 1){
            Account acc = new Account();
            acc.Deposit(10000); 
            acc.WithDraw(2500);
        }
        else if (lc == 2) {
            Advance c2 = new Advance();
            MathOperation<int> opera = new MathOperation<int>(c2.Subtract);
            Console.Write("a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("a - b = " + opera(a, b));
        }
    }
}