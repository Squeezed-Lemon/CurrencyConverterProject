namespace CurrencyConverter 
{
    public class Program
    {
        public static void Main()
        {
            //Creating a variable for each currency.
            string dollar_input, euro_input, yuan_input, real_input;

            dollar_input = "dollar";
            euro_input = "euro";
            yuan_input = "yuan";
            real_input = "real";

            //Criando sinais referente a cada currency
            string dollar_symb, euro_symb, yuan_symb, real_symb;

            dollar_symb ="$";
            euro_symb = "€";
            yuan_symb = "¥";
            real_symb = "R$";

            
            //Creating the question1
            Console.WriteLine("Which currency would you like to convert? \n \n --Dollar (USD)-- \n --Euro (EUR)-- \n --Yuan (CNY)-- \n --Real (BRL)-- \n");
            string type_initial_user_currency = Console.ReadLine(); //Creating a variable to store the user input.


            //Criando a condicao para caso o usuario tenha escolhido a moeda dolar
            if (type_initial_user_currency == dollar_input) 
            {
                //Question2 Dollar
                Console.WriteLine("\nWhat amount would you like to convert?");

                Console.Write(dollar_symb); //Dolar sign for response block2
                decimal value_type_initial_user_currency = decimal.Parse(Console.ReadLine()); //Input response block 2






            }











        }
    }
}