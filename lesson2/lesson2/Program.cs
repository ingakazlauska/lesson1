using System;

namespace lesson2
{
    class Program
    {
        static void Main(string[] args)
        {

            // -------------------------------Datu tipi

            int myNumber = 15;  //vesels skaitlis
            char myFavouriteLetter = 'A'; //simbols
            bool isCar = true;  //true/fals
            double myConstant = 4.48; //decimālskaitlis
            float myChangingNum = 58.5f; //precīzāks decimālskaitlis
            string name = "Inga"; //teksts



            Console.WriteLine(myNumber);
            Console.WriteLine(myFavouriteLetter);
            Console.WriteLine(isCar);
            Console.WriteLine(myConstant);
            Console.WriteLine(myChangingNum);
            Console.WriteLine(name);
            Console.WriteLine(myConstant + myChangingNum);

            // --------------------------------------------------------Aritmētiskie operatori

            int mynumber1 = 4;
            int nynumber2 = 6;

            int sum1 = mynumber1 + nynumber2;

            Console.WriteLine(sum1);




            String name1 = "Hello";
            String name2 = "from Mars";

            String namesTogether = name1 + " " + name2;

            Console.WriteLine(namesTogether);




            int withPluses = 4;
            withPluses++;

            Console.WriteLine(withPluses);





            int withMin = 4;
            withMin--;

            Console.WriteLine(withMin);





            int divisionReminder1 = 5;
            int divisionReminder2 = 2;

            int divisionReminderResult = divisionReminder1 % divisionReminder2;

            Console.WriteLine(divisionReminderResult);


            // ---------------------------------------------------Relāciju operatori


            int myNumber5 = 14;
            int myNumber6 = 17;

            bool isEquelNumber = myNumber5 == myNumber6;

            Console.WriteLine(isEquelNumber);



            string myText4 = "ABC";
            string myText5 = "ABC";

            bool isEquelText = myText4 == myText5;
            Console.WriteLine(isEquelText);




            int myNumber7 = 15;
            int myNumber8 = 15;

            bool isEualNumber2 = myNumber7 > myNumber8;

            Console.WriteLine(isEualNumber2);

            bool isEqualOrBiger = myNumber7 >= myNumber8;

            Console.WriteLine(isEqualOrBiger);


            // -------------------------------------Loģiskie operatori

            bool IAmTrue = true;
            bool IAmFalse = false;

            bool both = IAmTrue && IAmFalse;
            Console.WriteLine(both);

            bool or = IAmTrue || IAmFalse;
            Console.WriteLine(or);

            bool bothReversed = !both;
            Console.WriteLine(bothReversed);


            // --------------------------------------------Piešķiršanas operatori

            int myNumber14 = 14;


            myNumber14 += 10;

            Console.WriteLine(myNumber14);

            // -----------------------------Darbības ar konsoli --- Teksta izgūšana no lietotāja

            //Console.WriteLine("Kā Tevi sauc?");

            //string userName = Console.ReadLine();

            //Console.WriteLine("Sveiks, " + userName + "!");


            // --------------------------------------Darbības ar konsoli --- Skaitļa izgūšana no lietotāja



            //Console.WriteLine("Kā Tavs vecums?");

            //string ageText = Console.ReadLine();


            //int age = int.Parse(ageText);
            //int previosusYearAge = age - 1;

            //Console.WriteLine("Sveiks, Tev pagājušogad bija" + previosusYearAge);



            // -----------------------------


            int maxNumber1 = 4;
            int maxNumber2 = 6;

            int maxResult=Math.Max(maxNumber1, maxNumber2);


            Console.WriteLine(maxResult);



            int absWithMinus = -45;

            int absAfter = Math.Abs(absWithMinus);

            Console.WriteLine(absAfter);




            double NumberToRound = 14.588899;

            double rounded = Math.Round(NumberToRound, 2);

            Console.WriteLine(rounded);




        }
    }
}
