// using System;
// using System.Text;
//
// namespace lab05
// {
//     class Customer
//     {
//         public string strName;
//         public void AcceptsCustomerName()
//         {
//             Console.OutputEncoding = Encoding.Unicode;
//             Console.InputEncoding = Encoding.Unicode;
//             Console.WriteLine("Vui lòng nhập tên của bạn :");
//             strName = Console.ReadLine();
//         }
//     }
//
//     internal class GroceryItems
//     {
//         public void Ord_grocery()
//         {
//             Console.OutputEncoding = Encoding.Unicode;
//             Console.InputEncoding = Encoding.Unicode;
//             var objCust1 = new Customer();
//             objCust1.AcceptsCustomerName();
//             Console.WriteLine("Xin chào {0}", objCust1.strName);
//             Console.WriteLine("Bạn đã đặt hàng tạp hoá");
//         }
//     }
//
//     internal class BakeryItems
//     {
//         public void Ord_bakery()
//         {
//             Console.OutputEncoding = Encoding.Unicode;
//             Console.InputEncoding = Encoding.Unicode;
//             var objCust2 = new Customer();
//             objCust2.AcceptsCustomerName();
//             Console.WriteLine("Xin chào {0}", objCust2.strName);
//             Console.WriteLine("Bạn đã đặt các sản phẩm bánh mì.");
//         }
//     }
//
//     class OrderTest
//     {
//         public static void Main()
//         {
//             while (true)
//             { 
//                 Console.OutputEncoding = Encoding.Unicode;
//                 Console.InputEncoding = Encoding.Unicode;
//                 Console.WriteLine("Bạn muốn đặt món gì?");
//                 Console.WriteLine("1. Các mặt hàng của một cửa hàng tạp hoá.");
//                 Console.WriteLine("2. Các sản phẩm bánh mì.");
//                 Console.WriteLine("3. Thoát.");
//                 Console.WriteLine("Lựa chọn của bạn (1-3) : ");
//                 var choice = int.Parse(Console.ReadLine());
//                 switch (choice)
//                 {
//                     case 1:
//                         var groceryItems = new GroceryItems();
//                         groceryItems.Ord_grocery();
//                         break;
//                     case 2:
//                         var bakeryItems = new BakeryItems();
//                         bakeryItems.Ord_bakery();
//                         break;
//                 }
//
//                 Console.WriteLine("Enter để tiếp tục!");
//                 Console.ReadLine();
//                 if (choice == 3)
//                 {
//                     Console.WriteLine("Thoát.");
//                     break;
//                 }
//             }
//         }
//     }
// }