using System;
using System.Collections.Generic; // allows use of Lists

namespace EducationProject {
    class Program {
        static void Main(string[] args) {

            List<Major> majors = new List<Major>(); // A Collection of data/properties, named majors variable, Major is a data type

            Major business = new Major("Business", 1000); // Added business major variable using Major data type and added minSAT to it
            majors.Add(business); // added to our collection majors
            Major nursing = new Major("Nursing", 1200);
            majors.Add(nursing);
            Major theater = new Major("Theater", 1100);
            majors.Add(theater);
            
            foreach(Major major in majors) { // foreach goes thru collection IN majors, (IN must be used before the collection) and takes each one and plops the value into the major variable and you can use the variable in the body to print out the result set
                Console.WriteLine($"{major.Id}|{major.Description}|{major.MinSAT}");
            }

            List<Student> students = new List<Student>(); // list of students
            Student alex = new Student("Alex", "Alex", 1350, 3.4m); //put m after number if decimal number
            alex.Major = alex.GetMajorByDescription("Business", majors);
            Student drew = new Student("Drew", "Drew", 1350, 3.45m);
            drew.Major = drew.GetMajorByDescription("Business", majors);
            Student steven = new Student("Steven", "Steven", 1350, 3.4m);
            
            students.Add(alex); // adds student to list of students
            students.Add(drew);
            students.Add(steven);

            foreach(Student student in students) { //for each student in students writeline for student data information
                string MajorDescription = student.Major == null // ternary operator, true false, if true display undecided and student.major.description
                    ? "Undecided" : student.Major.Description;
                Console.WriteLine($"{student.FirstName} {student.LastName} " + //displays the majordescription condition
                                $"Major: {MajorDescription}");
            }

        }
    }
}
