//----------------------------Câu 1----------------------------//
interface IDriveable{
    void Drive();
}

interface IFlyable{
    void Fly();
}

class CarPlane : IDriveable, IFlyable {
    public void Drive(){
        Console.WriteLine("Driving a car");
    }

    public void Fly(){
        Console.WriteLine("Flying a plane");
    }
}
//-------------------------------------------------------------//

//----------------------------Câu 2----------------------------//
class Downloader {
    public event EventHandler<string> OnDownloadCompleted;
    public void FinishingDownload(string value){
        OnDownloadCompleted?.Invoke(this, value);
    }
}
//-------------------------------------------------------------//
class Program{
    static void Main(string[] args){
        Console.Write("Lựa chọn: ");
        int lc = int.Parse(Console.ReadLine());
        if (lc == 1){
            CarPlane cp = new CarPlane();
            cp.Drive();
            cp.Fly();
        }
        else if (lc == 2) {
            Downloader d = new Downloader();
            d.OnDownloadCompleted += (sender, value) => Console.WriteLine("Download completed: " + value);
            d.FinishingDownload("file.zip");
        }
    }
}