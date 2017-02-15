// Download the twilio-csharp library from twilio.com/docs/libraries/csharp
using System;
using Twilio;


class Program
{
    static void Main(string[] args)
    {
        var accountSid = "ACb91d8ab47615c5427a16e779d255b831"; // Your Account SID from www.twilio.com/console
        var authToken = "c7a2db5d5b744c030c5f56439539a52e";  // Your Auth Token from www.twilio.com/console
        try
        {
            var twilio = new TwilioRestClient(accountSid, authToken);
            var message = twilio.SendMessage(
                "+13212412345", // From (Replace with your Twilio number)
                "+919703471377", // To (Replace with your phone number)
                "Hello from team nutayanat ", new string[] { "http://demo.cloudimg.io/s/resize/300/sample.li/boat.jpg" });

            Console.WriteLine(message.Sid);
            Console.Write("Press any key to continue.");

        }
        catch (Exception ex)
        {

            Console.Write("Exception occured." + ex.Message);
        }


        Console.ReadKey();
    }
}