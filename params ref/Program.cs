namespace params_ref;

class Program
{
    static void Main(string[] args)
    {
        void Increment (int n)
        {
            n++;
            Console.WriteLine($"Число после инкремента:{n}");
        }

        Increment(5);
        int number = 3;
        Increment(number);

        void Person(ref string name)
        {
            name = "Bred";
            Console.WriteLine($"Your name is {name} now");
        }
        string person1 = "alex";

        Person(ref person1);
        Console.WriteLine(person1);


        void Sum (int a, int b, out int result)
        {
            result = a + b;
        }

        int numbers;
        Sum(3, 4,  out numbers);

        Console.WriteLine(numbers);


        void GetRectangleData(in int width, in int height, out int rectArea, out int rectPerimetr)
        {
            rectArea = width * height;
            rectPerimetr = (width + height) * 2;
            
        }

        GetRectangleData(52, 23, out int area, out int perimetr);
        Console.WriteLine($"Площадь прямоугольника:{area} Периметр прямоугольника:{perimetr}");

        void Decrement(ref readonly int n)
        {
            Console.WriteLine(n);
        }
        int x = 4;
        Increment(ref x);
    }


    
    
}

