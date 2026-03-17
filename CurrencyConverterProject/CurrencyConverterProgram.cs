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


            //Creating the condition in case the user has chosen the dollar currency.
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




            //Creating the condition in case the user has chosen first the euro currency
            if (type_initial_user_currency == euro_input)
            {

                //Question2 (Euro)
                Console.WriteLine("\nWhat amount would you like to convert?");

                Console.Write(euro_symb); //euro sign for response block2
                decimal value_type_initial_user_currency = decimal.Parse(Console.ReadLine()); //Input response block 2


                //Question 3 (looking for a new input)
                Console.WriteLine("\nWhich currency would you like to convert to Euro? \n \n --Dollar (USD)-- \n --Yuan (CNY)-- \n --Real (BRL)-- \n");
                string type_last_currency_to_convert = Console.ReadLine(); //Waiting for a input from question 3


                //Creating a condition for when the last currency chosen is the dollar.
                if (type_last_currency_to_convert == dollar_input)
                {
                    //Creating the operation
                    decimal final_value = value_type_initial_user_currency * 1.15m;

                    //Showing the result of the operation for the user
                    Console.WriteLine("\nToday, when converting " + euro_symb + value_type_initial_user_currency +
                                      " to the current exchange rate value in Dollar, the result will be = " + dollar_symb + final_value);

                }


                //Creating a condition for when the last currency chosen is the Yuan.
                if (type_last_currency_to_convert == yuan_input)
                {
                    //Creating the operation
                    decimal final_value = value_type_initial_user_currency * 8.01m;

                    //Showing the result of the operation for the user
                    Console.WriteLine("\nToday, when converting " + euro_symb + value_type_initial_user_currency +
                                      " to the current exchange rate value in Yuan, the result will be = " + yuan_symb + final_value);

                }


                //Creating a condition for when the last currency chosen is the real.
                if (type_last_currency_to_convert == real_input)
                {
                    //Creating the operation
                    decimal final_value = value_type_initial_user_currency * 6.00m;

                    //Showing the result of the operation for the user
                    Console.WriteLine("\nToday, when converting " + euro_symb + value_type_initial_user_currency +
                                      " to the current exchange rate value in Brazilian Real, the result will be = " + real_symb + final_value);

                }


            }











        }
    }
}


//solve the problem with the euro symbol
//criar condicao caso o usuario escolha euro, real ou yuan como primeiro input currency