/*
 * Filename: Assignment.cs
 * Description: Assignment object. It contains the properties and constructors
 *              characterizing an object of type Assignment.
 * 
 */

using System;

namespace GradeBook.Model
{
    public class Assignment
    {
        public long Id { get; set; }        // Database ID
        public String Name { get; set; }    // Name of the assignment
        public double Score { get; set; }   // Score recevied gor assignment

        /*
         * Default constructor
         */
        public Assignment()
        {
            Name = "";
            Score = 0.0;
        }

        public Assignment(String name, double score)
        {
            Name = name;
            Score = score;
        }

    } // End of class Assignment

} // End of namespace GradeBook.Model 
