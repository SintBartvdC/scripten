using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1._2_classes
{
    class students
    {
        private string name;

        public void Birth()
        {
            Console.WriteLine("{0} birth {1}",
                name, birth);
        }

        public students()
        : this("No Name") { }

        public students(string name)
            : this(name, "no year of birth") { }


        public students(string name, string birth)
        {
            SetName(name);
        }


        public void SetName(string name)
        {
            if (!name.Any(char.IsDigit))
            {
                this.name = name;
            }
            else
            {
                this.name = "No Name";
                Console.WriteLine("Name can't contain numbers");
            }
        }

        public string GetName()
        {
            return name;
        }

        public string hobby { get; set; } = "No hobby";

        public string birth { get; set; } = "No birth";

        public string alive { get; set; } = "not alive";

        public string yearofbirth()
        {
            return birth;
        }

        public string AliveOrNOt()
        {
            return alive;
        }
    }
}
