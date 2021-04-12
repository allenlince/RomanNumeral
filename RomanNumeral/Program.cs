using System;

namespace RomanNumeral {
    class Program {
        static void Main(string[] args) {
            
            //Variables
            double userNumber;

            Console.WriteLine("Please enter a number, in numeric form, within the range of 1 and 10 to display the Roman numeral version of the entered number:  ");
            userNumber = double.Parse(Console.ReadLine());

            CheckNumberConversion(userNumber);
        }//End Main

        static void CheckNumberConversion(double numberConversion) {
                switch (numberConversion) {
                    case 1  : { Console.WriteLine("The conversion is I.")    ; break;}
                    case 2  : { Console.WriteLine("The conversion is II.")   ; break;}
                    case 3  : { Console.WriteLine("The conversion is III.")  ; break;}
                    case 4  : { Console.WriteLine("The conversion is IV.")   ; break;}
                    case 5  : { Console.WriteLine("The conversion is V.")    ; break;}
                    case 6  : { Console.WriteLine("The conversion is VI.")   ; break;}
                    case 7  : { Console.WriteLine("The conversion is VII.")  ; break;}
                    case 8  : { Console.WriteLine("The conversion is VIII.") ; break;}
                    case 9  : { Console.WriteLine("The conversion is IX.")   ; break;}
                    case 10 : { Console.WriteLine("The conversion is X.")    ; break;}
                    default : {Console.WriteLine("The number you entered is not within the range of 1 through 10.") ; break;}

                }//End Switch
            }//End Function
    }//End Class
}//End Namespace