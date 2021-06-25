namespace Generics
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Generics class phải cho các lớp kế thừa từ animal
            //Giúp quản lí danh sách các animal với các phương thức Add và Remove
            //cũng như ShowInformation
            // -Add: cho phép thêm phần từ
            // -Remove: xoá phần tử khỏi danh sách
            // -ShowInformation: gọi hàm ToString() của Animal và Speak để hiển thị thông tin
            //cũng như tiếng của các con vật.
            AnimalConnection<Animal> animalConnection = new AnimalConnection<Animal>();
            animalConnection.Add(new Dog() {Id = 1, Name = "Kathy", Dob = "2010"});
            animalConnection.Add(new Cat() {Id = 2, Name = "Meow", Dob = "2011"});
            animalConnection.Add(new Dog() {Id = 3, Name = "LyLy", Dob = "2012"});
            animalConnection.Remove(2);
            animalConnection.ShowInformation();
        }
    }
}