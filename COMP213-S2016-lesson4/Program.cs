using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP213_S2016_lesson4
{
    /**
     * this class is the "driver" class for our program
     */
    public class Program
    {
        /**
         * the main method for driver class
         * 
         * @method main
         * @parm {string[]} args
         */
        public static void Main(string[] args)
        {
            // Create a new instance(object) of the person class

            Person Abhinav = new Person();
            Abhinav.Name = "Tanya";
            Abhinav.Age = 28;
            Abhinav._sayHello();
            Abhinav.ShowAge();

            Console.WriteLine();


            Person Inder = new Person("Inder");
            Inder.Age = 18;
            Inder._sayHello();
            Inder.ShowAge();

            Console.WriteLine();

            Person Iqbal = new Person(30);
            Iqbal.Name = "Iqbal";
            Iqbal._sayHello();
            Iqbal.ShowAge();

            Console.WriteLine();

            Person Khushi = new Person("Khusi", 23);

            Khushi._sayHello();
            Khushi.ShowAge();

        }
    }
}
