using System;

namespace c_sharp_playground
{
    class Person
    {
        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public Person(int initialAge)
        {
            if (initialAge < 0)
            {
                age = 0;
                Console.WriteLine("Age is not valid, setting age to 0.");
            }
            else
            {
                age = initialAge;
            }
        }

        public void yearPasses()
        {
            age += 1;
        }

        public void amIOld()
        {
            if (age > 0 && age < 13)
            {
                Console.WriteLine("You are young.");
            }
            else if (age > 0 && age < 18)
            {
                Console.WriteLine("You are a teenager.");
            }
            else if (age >= 18)
            {
                Console.WriteLine("You are old.");
            }
        }

    }
}