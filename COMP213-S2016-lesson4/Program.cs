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

        public static void Main (string[] args)
        {
            //create instance of student
            Student Inder = new Student("Inder",18, "300874118");

            Inder._sayHello();

            Console.WriteLine();

            Inder.Studies();

            //Create instance of teacher class
            Teacher tom = new Teacher("Tom", 47, "123456789");
            tom._sayHello();
            Console.WriteLine();
            tom.Teaches();
        }
    }
}
