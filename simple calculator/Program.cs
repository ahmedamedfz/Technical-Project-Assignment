using System;
using System.Globalization;
namespace TechnicalProjectAssignment{
    class OperasiAritmatika{
        static void Main(string[] args){
            string s = "enter the action to be performed \n press 1 for addition \n press 2 for substration \n press 3 for multiplication \n press 4 for division";
            Console.WriteLine(s);
            int Operasi= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter 1st input");
            float angka1 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("enter 2nd input");
            float angka2 = Convert.ToSingle(Console.ReadLine());
    
            if (Operasi == 1){
                Console.WriteLine(angka1 + angka2);
            }
            else if ( Operasi == 2){
                Console.WriteLine(angka1 - angka2);
            }
            else if(Operasi == 3){
                Console.WriteLine(angka1 * angka2);
            }
            else if(Operasi == 4){
                Console.WriteLine(angka1 / angka2);
            }
            else {
                Console.WriteLine("error");
            }
         }
     }

}
