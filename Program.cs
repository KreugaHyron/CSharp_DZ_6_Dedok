namespace CSharp_DZ_6_Dedok
{
    //1
    namespace Namespace1
    {
        public class MyClass
        {
            public void PrintMessage()
            {
                Console.WriteLine("Hello from Namespace1");
            }
        }
    }
    namespace Namespace2
    {
        public class MyClass
        {
            public void PrintMessage()
            {
                Console.WriteLine("Hello from Namespace2");
            }
        }
    }
    //2
    namespace Company
    {
        namespace Department
        {
            public class Employee
            {
                public void ShowDepartment()
                {
                    Console.WriteLine("Employee belongs to Sales Department");
                }
            }
        }
    }
    //3
    namespace MathOperations
    {
        public class Operations
        {
            public int Add(int a, int b)
            {
                return a + b;
            }
        }
    }
    namespace StringOperations
    {
        public class Operations
        {
            public string Concatenate(string a, string b)
            {
                return a + b;
            }
        }
    }
    //4
    namespace Country1
    {
        public class Capital
        {
            public string Name { get; set; }
            public int Population { get; set; }

            public Capital(string name, int population)
            {
                Name = name;
                Population = population;
            }
        }
    }
    namespace Country2
    {
        public class Capital
        {
            public string Name { get; set; }
            public int Population { get; set; }

            public Capital(string name, int population)
            {
                Name = name;
                Population = population;
            }
        }
    }
    namespace Country3
    {
        public class Capital
        {
            public string Name { get; set; }
            public int Population { get; set; }

            public Capital(string name, int population)
            {
                Name = name;
                Population = population;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task_1 - Создайте два пространства имен, каждое с одним классом. Один класс должен содержать метод, который печатает сообщение
            //"Hello from Namespace1", а другой — метод, который печатает "Hello from Namespace2".
            //Названия этих классов должны быть одинаковыми.В основном классе вызовите эти методы.
            Namespace1.MyClass obj1 = new Namespace1.MyClass();
            obj1.PrintMessage();
            Namespace2.MyClass obj2 = new Namespace2.MyClass();
            obj2.PrintMessage();
            Console.WriteLine();
            //Task_2 - Создайте пространство имен Company, внутри него создайте вложенное пространство имен Department, содержащее класс Employee.
            //Класс Employee должен иметь метод ShowDepartment, который выводит "Employee belongs to Sales Department".
            Company.Department.Employee employee = new Company.Department.Employee();
            employee.ShowDepartment();
            Console.WriteLine();
            //Task_3 - Создайте 2 пространства имен MathOperations и StringOperations, каждое с одним классом,
            //содержащим метод для выполнения соответствующей операции (например, сложение чисел, конкатенация строк).
            //В основном классе используйте эти методы.
            MathOperations.Operations mathOps = new MathOperations.Operations();
            int sum = mathOps.Add(5, 3);
            Console.WriteLine("Sum: " + sum);

            StringOperations.Operations stringOps = new StringOperations.Operations();
            string result = stringOps.Concatenate("Hello, ", "World!");
            Console.WriteLine("Concatenated String: " + result);
            Console.WriteLine();
            //Task_4 - Разработать приложение, в котором бы сравнивалось население трёх столиц из разных стран.
            //Причём страна бы обозначалась пространством имён, а город — классом в данном пространстве.
            Country1.Capital capital1 = new Country1.Capital("Capital1", 8000000);
            Country2.Capital capital2 = new Country2.Capital("Capital2", 12000000);
            Country3.Capital capital3 = new Country3.Capital("Capital3", 9000000);

            Console.WriteLine($"{capital1.Name} from Country1 has a population of {capital1.Population}");
            Console.WriteLine($"{capital2.Name} from Country2 has a population of {capital2.Population}");
            Console.WriteLine($"{capital3.Name} from Country3 has a population of {capital3.Population}");
            dynamic largestCapital = capital1;

            if (capital2.Population > largestCapital.Population)
            {
                largestCapital = capital2;
            }

            if (capital3.Population > largestCapital.Population)
            {
                largestCapital = capital3;
            }

            Console.WriteLine($"\nThe capital with the largest population is {largestCapital.Name} with a population of {largestCapital.Population}");
        }
    }
}
