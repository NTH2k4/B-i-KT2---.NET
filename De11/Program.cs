//----------------------------Câu 1----------------------------//
interface IDrawable{
    void Draw();
}

class Shape : IDrawable{
    public virtual void Draw(){
        throw new NotImplementedException();
    }
}

class Circle : Shape{
    public override void Draw(){
        Console.WriteLine("Drawing Circle");
    }
}
//-------------------------------------------------------------//

//----------------------------Câu 2----------------------------//
public delegate T CalculationHandler<T>(T a, T b);
class Cau2 {
    public int Add(int a, int b){
        return a + b;
    }
}
//-------------------------------------------------------------//
class Program{
    static void Main(string[] args){
        Console.Write("Lựa chọn: ");
        int lc = int.Parse(Console.ReadLine());
        if (lc == 1){
            IDrawable circle = new Circle();
            circle.Draw();
        }
        else if (lc == 2) {
            Console.Write("a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b: ");
            int b = int.Parse(Console.ReadLine());
            CalculationHandler<int> cal = new CalculationHandler<int>(new Cau2().Add);
            Console.WriteLine("a + b = " + cal(a, b));
        }
    }
}