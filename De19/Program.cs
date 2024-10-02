//----------------------------Câu 1----------------------------//
abstract class Appliance {
    public abstract void TurnOn();
}

class Fan : Appliance {
    public override void TurnOn() {
        Console.WriteLine("Fan is turning on");
    }
}

class AirConditioner : Appliance {
    public override void TurnOn() {
        Console.WriteLine("Air conditioner is turning on");
    }
}
//-------------------------------------------------------------//

//----------------------------Câu 2----------------------------//
class Uploader {
    public event Action<string> OnFileUploaded;
    public void UploadFile(){
        OnFileUploaded?.Invoke("File is uploaded");
    }
}
//-------------------------------------------------------------//
class Program{
    static void Main(string[] args){
        Console.Write("Choose: ");
        int lc = int.Parse(Console.ReadLine());
        if (lc == 1){
            Appliance fan = new Fan();
            Appliance airConditioner = new AirConditioner();
            fan.TurnOn();
            airConditioner.TurnOn();
        }
        else if (lc == 2) {
            Uploader uploader = new Uploader();
            uploader.OnFileUploaded += name => Console.WriteLine($"{name}");
            uploader.UploadFile();
        }
    }
}