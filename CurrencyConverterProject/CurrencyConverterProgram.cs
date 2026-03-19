using System.Security.Cryptography;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CurrencyConverter 
{
    public class Program
    {
        public static void Main()
        {
            //Using program UTF8 because im dumb and i forgot to at the beginning of my project.
            Console.OutputEncoding = Encoding.UTF8;

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


            //Creating a List String with all currency inputs to aplicate in the conditional
            List<string> currency_inputs = new List<string> { "dollar", "euro", "yuan", "real"};

            //starting like a true value and than to a false value inside of my conditional if else
            bool currency_error = true;


            //Creating a while for 
            while (currency_error)
            {
                //Creating the question1
                Console.WriteLine("Which currency would you like to convert? \n \n --Dollar (USD)-- \n --Euro (EUR)-- \n --Yuan (CNY)-- \n --Real (BRL)-- \n");
                string type_initial_user_currency = Console.ReadLine().ToLower(); //Creating a variable to store the user input.


                //apllying the conditional for my String List
                if (currency_inputs.Contains(type_initial_user_currency))
                {
                    currency_error = false;

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



                    //Creating the condition in case the user has chosen first the yuan currency
                    if (type_initial_user_currency == yuan_input)
                    {

                        //Question2 (Yuan)
                        Console.WriteLine("\nWhat amount would you like to convert?");

                        Console.Write(yuan_symb); //yuan sign for response block2
                        decimal value_type_initial_user_currency = decimal.Parse(Console.ReadLine()); //Input response block 2


                        //Question 3 (looking for a new input)
                        Console.WriteLine("\nWhich currency would you like to convert to Yuan? \n \n --Dollar (USD)-- \n --Euro (EUR)-- \n --Real (BRL)-- \n");
                        string type_last_currency_to_convert = Console.ReadLine(); //Waiting for a input from question 3


                        //Creating a condition for when the last currency chosen is the dollar.
                        if (type_last_currency_to_convert == dollar_input)
                        {
                            //Creating the operation
                            decimal final_value = value_type_initial_user_currency * 0.14m;

                            //Showing the result of the operation for the user
                            Console.WriteLine("\nToday, when converting " + yuan_symb + value_type_initial_user_currency +
                                              " to the current exchange rate value in Dollar, the result will be = " + dollar_symb + final_value);

                        }


                        //Creating a condition for when the last currency chosen is the euro.
                        if (type_last_currency_to_convert == euro_input)
                        {
                            //Creating the operation
                            decimal final_value = value_type_initial_user_currency * 0.12m;

                            //Showing the result of the operation for the user
                            Console.WriteLine("\nToday, when converting " + yuan_symb + value_type_initial_user_currency +
                                              " to the current exchange rate value in euro, the result will be = " + euro_symb + final_value);

                        }


                        //Creating a condition for when the last currency chosen is the real.
                        if (type_last_currency_to_convert == real_input)
                        {
                            //Creating the operation
                            decimal final_value = value_type_initial_user_currency * 0.75m;

                            //Showing the result of the operation for the user
                            Console.WriteLine("\nToday, when converting " + yuan_symb + value_type_initial_user_currency +
                                              " to the current exchange rate value in Brazilian Real, the result will be = " + real_symb + final_value);

                        }


                    }



                    // Creating the condition in case the user has chosen first the real currency
                    if (type_initial_user_currency == real_input)
                    {

                        //Question2 (Real)
                        Console.WriteLine("\nWhat amount would you like to convert?");

                        Console.Write(real_symb); //real sign for response block2
                        decimal value_type_initial_user_currency = decimal.Parse(Console.ReadLine()); //Input response block 2


                        //Question 3 (looking for a new input)
                        Console.WriteLine("\nWhich currency would you like to convert to Real? \n \n --Dollar (USD)-- \n --Euro (EUR)-- \n --Yuan (CNY)-- \n");
                        string type_last_currency_to_convert = Console.ReadLine(); //Waiting for a input from question 3


                        //Creating a condition for when the last currency chosen is the dollar.
                        if (type_last_currency_to_convert == dollar_input)
                        {
                            //Creating the operation
                            decimal final_value = value_type_initial_user_currency * 0.19m;

                            //Showing the result of the operation for the user
                            Console.WriteLine("\nToday, when converting " + real_symb + value_type_initial_user_currency +
                                              " to the current exchange rate value in Dollar, the result will be = " + dollar_symb + final_value);

                        }


                        //Creating a condition for when the last currency chosen is the euro.
                        if (type_last_currency_to_convert == euro_input)
                        {
                            //Creating the operation
                            decimal final_value = value_type_initial_user_currency * 0.17m;

                            //Showing the result of the operation for the user
                            Console.WriteLine("\nToday, when converting " + real_symb + value_type_initial_user_currency +
                                              " to the current exchange rate value in euro, the result will be = " + euro_symb + final_value);

                        }


                        //Creating a condition for when the last currency chosen is the yuan.
                        if (type_last_currency_to_convert == yuan_input)
                        {
                            //Creating the operation
                            decimal final_value = value_type_initial_user_currency * 1.34m;

                            //Showing the result of the operation for the user
                            Console.WriteLine("\nToday, when converting " + real_symb + value_type_initial_user_currency +
                                              " to the current exchange rate value in Yuan, the result will be = " + yuan_symb + final_value);

                        }


                    }


                }
                else
                {
                    //Create a message 
                    Console.WriteLine("\nPlease enter a valid currency!\n");


                }
            }

        }
    }
}




//To-do
//Prevent the user from entering anything other than what is being requested, and return a message (“enter a valid value”) or (“enter a valid currency”).
//Realtime currency exchange rate

//Se a resposta nao for igual com a que estou pedindo, retorne uma mensagem e peca que o if seja executado novamente.
