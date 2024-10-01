//----------------------------Câu 1----------------------------//
class Shape{
    internal virtual void Draw(){}
}

class Circle : Shape{
    internal override void Draw(){
        Console.WriteLine("Vẽ hình tròn");
    }
}

class Rectangle : Shape{
    internal override void Draw(){
        Console.WriteLine("Vẽ hình chữ nhật");
    }
}
//-------------------------------------------------------------//

//----------------------------Câu 2----------------------------//
class Task{
    public event EventHandler OnCompleted;
    internal void CompleteTask(){
        OnCompleted?.Invoke(this, EventArgs.Empty);
    }
}
//-------------------------------------------------------------//
class Program{
    static void Main(string[] args){
        Console.Write("Lựa chọn: ");
        int lc = int.Parse(Console.ReadLine());
        if (lc == 1){
            Shape circle = new Circle();
            Shape rectangle = new Rectangle();
            circle.Draw();
            rectangle.Draw();
        }
        else if (lc == 2) {
            Task task = new Task();
            task.OnCompleted += (sender, e) => {
                Console.WriteLine("Task đã hoàn thành");
            };
            task.CompleteTask();
        }
    }
}