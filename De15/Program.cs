//----------------------------Câu 1----------------------------//
class Cau1{
    public double Divide(int a, int b){
        if (b == 0) throw new DivideByZeroException();
        return a * 1.0 / b;
    }
    
}
//-------------------------------------------------------------//

//----------------------------Câu 2----------------------------//
class Task {
    public event EventHandler<string> OnTaskCompleted;
    public void CompleteTask(string task){
        Console.WriteLine("Task completing...");
        OnTaskCompleted?.Invoke(this, task);
    }
}
//-------------------------------------------------------------//
class Program{
    static void Main(string[] args){
        Console.Write("Lựa chọn: ");
        int lc = int.Parse(Console.ReadLine());
        if (lc == 1){
            Cau1 c1 = new Cau1();
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());
            try{
                Console.WriteLine("a / b = " + c1.Divide(a, b));
            }
            catch(DivideByZeroException e){
                Console.WriteLine("Lỗi chia cho 0");
            }
            finally{
                Console.WriteLine("Kết thúc chương trình");
            }
        }
        else if (lc == 2) {
            Task task = new Task();
            task.OnTaskCompleted += (sender, task) => {
                Console.WriteLine("Task completed: " + task);
            };
            task.CompleteTask("Task 1");
        }
    }
}