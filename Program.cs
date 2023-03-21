namespace Part_8___Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name1 = "aldworth";
            string name2 = "Aldworth";
            if (name1.Equals(name2))
                Console.WriteLine("Same");
            else
                Console.WriteLine("Different");


            string firstName, lastName, username, email, studentNumberString;
            int studentNumber;

            Console.Write("Enter your first name:  ");
            firstName = Console.ReadLine().ToLower();
            Console.Write("Enter your last name:  ");
            lastName = Console.ReadLine().ToLower();
            Console.Write("Enter your student number:  ");
            studentNumber = Convert.ToInt32(Console.ReadLine());

            studentNumberString = studentNumber + "";

            username = lastName.Substring(0, 3) + firstName.Substring(0, 3) + studentNumberString.Substring(6,3);
            email = firstName.Substring(0, 1) + lastName + "@parkside.ca";

            Console.WriteLine(username);
            Console.WriteLine(email);
        }
    }
}