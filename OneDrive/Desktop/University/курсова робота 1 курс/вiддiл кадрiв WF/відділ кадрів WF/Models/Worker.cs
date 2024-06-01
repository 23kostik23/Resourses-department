using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace відділ_кадрів_WF.Models
{
    public class Worker
    {
        private string name;
        private string surname;
        private int age;
        private int salary;
        private string sex;
        private string education;
        private string position;
        private string division;
        private DateTime dateOfAppearence;
        private DateTime dateOfLastAppointment;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public int Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        public string Sex
        {
            get { return sex; }
            set { sex = value; }
        }
        public string Education
        {
            get { return education; }
            set { education = value; }
        }
        public string Position
        {
            get { return position; }
            set { position = value; }
        }
        public string Division
        {
            get { return division; }
            set { division = value; }
        }
        public DateTime DateOfAppearence
        {
            get { return dateOfAppearence; }
            set { dateOfAppearence = value; }
        }
        public DateTime DateOfLastAppointment
        {
            get { return dateOfLastAppointment; }
            set { dateOfLastAppointment = value; }
        }

        public Worker(string _name, string _surname, int _age, int _salary, string _sex, string _education, string _position, string _division)
        {
            name = _name;
            surname = _surname;
            age = _age;
            salary = _salary;
            sex = _sex;
            education = _education;
            position = _position;
            division = _division;
            dateOfAppearence = DateTime.Now;
            dateOfLastAppointment = DateTime.Now;
        }
        public Worker(string _name, string _surname, int _age, int _salary, string _sex, string _education, string _position, string _division, DateTime _dateOfAppearence, DateTime _dateOfLastAppointment)
        {
            name = _name;
            surname = _surname;
            age = _age;
            salary = _salary;
            sex = _sex;
            education = _education;
            position = _position;
            division = _division;
            dateOfAppearence = _dateOfAppearence;
            dateOfLastAppointment = _dateOfLastAppointment;
        }
        public override string ToString()
        {
            return $"Name: {name}, Surname: {surname}, Age: {age}, Salary: {salary}, Sex: {sex}, Education: {education}, Position: {position}, Division: {division}, Date Of Appearence: {dateOfAppearence}, Date Of Last Edit: {dateOfLastAppointment}";
        }
        //public void 
    }
}
