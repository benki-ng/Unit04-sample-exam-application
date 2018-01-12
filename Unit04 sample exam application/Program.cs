using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit04_sample_exam_application
{
    class Program
    {
        static void Main(string[] args)
        {
            //input the height and check its in the range
            double height = 0;
            do
            {
                Console.WriteLine("Input your height in centimeters");
                var input = Console.ReadLine();
                try
                {
                    height = double.Parse(input);
                }
                catch
                {
                    Console.WriteLine("Please try again");
                }
            } while ((120 > height) | (height > 210));

            //input the weight and check its in the range
            double weight = 0;
            do
            {
                Console.WriteLine("Input your weight in kg");
                var input = Console.ReadLine();
                try
                {
                    weight = double.Parse(input);
                }
                catch
                {
                    Console.WriteLine("Please try again");
                }
            } while ((30 > weight) | (weight > 250));

            //input the age and check its in the range
            int age = 0;
            do
            {
                Console.WriteLine("Input your age in years");
                var input = Console.ReadLine();
                try
                {
                    age = Int32.Parse(input);
                }
                catch
                {
                    Console.WriteLine("Please try again");
                }
            } while ((14 > age) | (age > 100));

            //input the gender and check its valid
            var gender = "cow";
            do
            {
                Console.WriteLine("Input your gender");
                gender = Console.ReadLine();
            } while ( !((gender == "male") | (gender == "female")) );

           
            //calculate the bmr based on the persons gender
            double bmr = 0;
            if (gender == "male")
            {
                bmr = 88.362 + (13.397 * weight) + (4.799 * height) - (5.677 * age);
            }
            if (gender == "female") {
                bmr = 447.593 + (9.247 * weight) + (3.098 * height) - (4.330 * age);
            }
            
            //round the bmr to 2dp
            bmr = Math.Round(bmr, 2);
            
            //print the persons bmr
            Console.Write("Your BMR is: ");
            Console.WriteLine(bmr);


            //calculate bmi
            double bmi = weight / Math.Pow((height/100), 2);
            bmi = Math.Round(bmi, 1);
            Console.Write("Your BMI is: ");
            Console.WriteLine(bmi);
            Console.WriteLine("Your target BMI is: 22");
            Console.WriteLine();


            //input the level of exercise
            int exercise = 0;
            do
            {
                //ask the user how much exercise they do
                Console.WriteLine("How much exercise do you do?");
                Console.WriteLine("1 is little to no exercise");
                Console.WriteLine("2 is light exercise");
                Console.WriteLine("3 is moderate exercise");
                Console.WriteLine("4 is heavy exercise");
                Console.WriteLine("5 is very heavy exercise");
                var input = Console.ReadLine();
                try
                {
                    exercise = Int32.Parse(input);
                }
                catch
                {
                    Console.WriteLine("Please try again");
                }
            } while ( !((6 < exercise) | (exercise > 0)) );

            //calculate the calorie intake based off exercise
            double cal = 0;
            switch (exercise)
            {
                case 1:
                    cal = bmr * 1.2;
                    break;
                case 2:
                    cal = bmr * 1.375;
                    break;
                case 3:
                    cal = bmr * 1.55;
                    break;
                case 4:
                    cal = bmr * 1.725;
                    break;
                case 5:
                    cal = bmr * 1.9;
                    break;
            }

            //print calories
            Console.Write("You should consume ");
            Console.Write(cal);
            Console.WriteLine(" calories per day.");
            Console.WriteLine();


            //wait for user input to terminate program
            Console.WriteLine("Press enter to exit program.");
            Console.ReadKey();
        }
    }
}
