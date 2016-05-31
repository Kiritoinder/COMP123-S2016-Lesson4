using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP213_S2016_lesson4
{
    /**
     * <summary>
     * This is student class. It is derivrd from person class
     * </summary>
     * 
     * @class student
     * @extends person
     */
    class Student : Person
    {
        // PRIVATE INSTANCE VARIABLES ++++++++++++++++++++++
        private string _studentID;


        // PUBLIC PROPERTIES +++++++++++++++++++++++++++++++
        public string StudentID
        {

            get
            {
                return this._studentID;
            }
            set
            {
                this._studentID = value;
            }

        }
        // CONSTRUCTOR +++++++++++++++++++++++++++++++++++++

        /**
         *<summary>
         * This constructor takes 3 paramaters: name, age and studentID
         * </summary> 
         * 
         * @constructor student
         * @extends person
         * @pram {string} name
         * @pram {int} age
         * @pram {string} studentID
         */
        public Student(string name, int age, string studentID):base(name,age)
        {
            this.StudentID = studentID;
        }
        // PUBLIC METHODS
        /**
         *<summary>
         * This method enables studies behaviour for the student
         * </summary>
         * 
         * @Method studies
         * @return {vois}
         */
        public void Studies()
        {
            Console.WriteLine(this.Name+" studies.");
        }
    }
}
