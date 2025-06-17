namespace day_02_Assignment_Currency_convertwe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Amount");
            int amt = Convert.ToInt32(Console.ReadLine());
            if(amt%100 == 0 && amt<=50000)
            {

                Console.WriteLine("Choose the Currency Value \n1: 2000 \n2: 500 \n3: 200 \n4: 100");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice) {
                    case 1:
                        {
                            Console.WriteLine("Amt is "+ amt * 2000);

                        }
                        break;
                        case 2:
                        {
                            Console.WriteLine("Amt is " + amt * 500);

                        }
                        break;
                        case 3:
                        {
                            Console.WriteLine("Amt is " + amt * 200);

                        }
                        break;
                        case 4:
                        {
                            Console.WriteLine("Amt is " + amt * 100);

                        }
                        break;
                        default:
                        {
                            Console.WriteLine("Enter Right Choice");

                        }
                        break;

                }


            }
            else
            {
                Console.WriteLine("Enter the Multiple of 100 and less than 500000");

            }
        }
    }
}
