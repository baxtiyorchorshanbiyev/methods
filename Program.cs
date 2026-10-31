namespace Methods
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // ========== 1 ==========
            ShowWelcome();

            // ========== 2 ==========
            ShowGreeting(name: "Ali");

            // ========== 3 ==========
            Console.WriteLine($"Passing score: {GetPassingScore()}");

            // ========== 4 ==========
            Console.WriteLine($"Result: {Add(first: -3, second: 3)}");

            // ========== 5 ==========
            Console.WriteLine($"Result: {CreateOrderMessage(product: "Book", quantity: 2)}");

            // ========== 6 ==========
            ProcessTicket(7, false);

            // ========== 7 ==========
            bool isSuccess = TryDivide(8, 0, out int quotient, out int remainder);

            if (isSuccess)
            {
                Console.WriteLine($"Qoutient: {quotient}; Remainder: {remainder}");
            }
            else
            {
                Console.WriteLine("Cannot divide by zero.");
            }

            // ========== 8 ==========
            int score = 105;
            int bonus = 5;

            AddBonus(ref score, bonus);

            // ========== 9 ==========
            int stock = 5;
            int quantity = -1;

            bool isSuccess2 = TrySellItems(ref stock, quantity);

            Console.WriteLine($"Success: {isSuccess2}; Stock: {stock}");

            // ========== 10 ==========
            GetNumberStats(4, 4, 1, out int min, out int middle, out int max);
            Console.WriteLine($"Min: {min}, Middle: {middle}, Max: {max}");

            // ========== 11 ==========

            bool success = TryCalculateAverage(80, 90, 100, out int avg);

            Console.WriteLine($"Success: {success}, Average: {avg}");
        }

        static void ShowWelcome()
        {
            Console.WriteLine("Welcome to C# methods!");
        }

        static void ShowGreeting(string name)
        {
            Console.WriteLine($"Hello {name}");
        }

        static int GetPassingScore()
        {
            return 60;
        }

        static int Add(int first, int second)
        {
            return first + second;
        }

        static string CreateOrderMessage(string product, int quantity)
        {
            return $"Order:{quantity} {product}";
        }

        static void ProcessTicket(int age, bool isWeekend)
        {
            int result = GetTicketPrice(age, isWeekend);

            if (result == -1)
            {
                Console.WriteLine($"Yosh: {age} -> Invalid age");
            }
            else if (result == 0)
            {
                Console.WriteLine($"Yosh: {age} -> Free");
            }
            else
            {
                Console.WriteLine($"Yosh: {age} => {result} so'm");
            }
        }

        static int GetTicketPrice(int age, bool isWeekend)
        {
            if (age < 0 || age > 120) { return -1; }

            if (age < 7) { return 0; }

            if (age >= 60 && isWeekend) { return 12000; }

            if (isWeekend) { return 15000; }
            return 10000;
        }

        static bool TryDivide(int number, int divisor, out int quotient, out int remainder)
        {
            if (divisor == 0)
            {
                quotient = 0;
                remainder = 0;
                return false;
            }

            quotient = number / divisor;
            remainder = number % divisor;
            return true;
        }

        static void AddBonus(ref int score, int bonus)
        {
            if (score < 0 || score > 100 || bonus < 0 || bonus > 30)
            {
                Console.WriteLine($"Before: {score}; After: {score}");
                return;
            }

            int oldScore = score;
            score += bonus;
            Console.WriteLine($"Before: {oldScore}; After: {score}");
        }

        static bool TrySellItems(ref int stock, int quantity)
        {
            if (stock < 0 || quantity < 0 || quantity > stock)
            {
                return false;
            }
            stock -= quantity;

            return true;
        }

        static void GetNumberStats(int first, int second, int third, out int min, out int middle, out int max)
        {
            if (first <= second && first <= third)
            {
                min = first;
                if (second <= third) { middle = second; max = third; }
                else { middle = third; max = second; }
            }
            else if (second <= first && second <= third)
            {
                min = second;
                if (first <= third) { middle = first; max = third; }
                else { middle = third; max = first; }
            }
            else
            {
                min = third;
                if (first <= second) { middle = first; max = second; }
                else { middle = second; max = first; }
            }
        }

        static bool TryCalculateAverage(int first, int second, int third, out int average)
        {
            if (first < 0 || first > 100 ||
                    second < 0 || second > 100 ||
                    third < 0 || third > 100)
            {
                average = 0;
                return false;
            }

            average = (first + second + third) / 3;
            return true;
        }
    }
}
