using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    public class Baby
    {
        //field
        private string _name;
        private string _surname;
        private DateTime _birth;

        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birth { get; set; }
        //Default Constructor
        //does not take parameters
        public Baby() 
        {
            Console.WriteLine("INGAAAAAAAAAAAAAAAA!");
            DateTime MomentBirth = DateTime.Now;
            Console.WriteLine($"Doğum Zamanı : {MomentBirth} ");
        }
        //only take name and surname parameters
        public Baby(string name,string surname)
        {
            _name = name;
            _surname = surname;
            Console.WriteLine("INGAAAAAAAAAAA!");
            DateTime MomentBirth = DateTime.Now;
            Console.WriteLine($"Doğum Zamanı : {MomentBirth} ");
            Console.WriteLine($"Bebeğin İsmi: {name} - Bebeğin Soyadı : {surname} ");

            
        }

        //Display Method
        public void DisplayBaby()
        {
            Console.WriteLine($"Bebeğin Adı : {Name} - Bebeğin Soyadı: {Surname} ");
            Console.WriteLine("********************");
        }

    }
}
