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
                
                //Question2 (Dollar)
                Console.WriteLine("\nWhat amount would you like to convert?");

                Console.Write(dollar_symb); //Dolar sign for response block2
                decimal value_type_initial_user_currency = decimal.Parse(Console.ReadLine()); //Input response block 2

                
                //Question 3 (looking for a new input)
                Console.WriteLine("\nWhich currency would you like to convert to Dollar? \n \n --Euro (EUR)-- \n --Yuan (CNY)-- \n --Real (BRL)-- \n");
                string type_last_currency_to_convert = Console.ReadLine(); //Waiting for a input from question 3


                //Creating a condition for when the last currency chosen is the euro.
                if (type_last_currency_to_convert == euro_input) 
                {
                    //Creating the operation
                    decimal final_value = value_type_initial_user_currency * 0.87m;
                    
                    //Showing the result of the operation for the user
                    Console.WriteLine("\nToday, when converting " + dollar_symb + value_type_initial_user_currency + 
                                      " to the current exchange rate value in Euro, the result will be = " + euro_symb + final_value);
                
                }


                //Creating a condition for when the last currency chosen is the Yuan.
                if (type_last_currency_to_convert == yuan_input)
                {
                    //Creating the operation
                    decimal final_value = value_type_initial_user_currency * 6.96m;

                    //Showing the result of the operation for the user
                    Console.WriteLine("\nToday, when converting " + dollar_symb + value_type_initial_user_currency +
                                      " to the current exchange rate value in Yuan, the result will be = " + yuan_symb + final_value);

                }


                //Creating a condition for when the last currency chosen is the real.
                if (type_last_currency_to_convert == real_input)
                {
                    //Creating the operation
                    decimal final_value = value_type_initial_user_currency * 5.20m;

                    //Showing the result of the operation for the user
                    Console.WriteLine("\nToday, when converting " + dollar_symb + value_type_initial_user_currency +
                                      " to the current exchange rate value in Brazilian Real, the result will be = " + real_symb + final_value);

                }











            }











        }
    }
}


//solve the problem with the euro symbol