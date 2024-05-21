using System.Dynamic;

namespace ConsoleApp;

//dotNet templates come with "Program" class built in
class Program
{

    //This is the first method run when program starts (at "run time")
    static void Main(string[] args)
    {
        PrintMessages();
    }

    //This is the PrintMessages method referred to above
    //This method refers to "WhatILikeMessages" method and the "TheWeatherMessages" method, both within the "Message" public class
    static void PrintMessages()
    {
        Message message = new Message();

        message.WhatILikeMessages();

        message.TheWeatherMessages();
    }

    //This is the PrintMessages2 method
    //This method refers to the "PrintMessages2" method within "Message" class

}