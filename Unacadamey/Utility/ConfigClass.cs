using OpenQA.Selenium;


namespace Unacademy
{
    public class ConfigClass
    {

        public static IWebDriver driver;
        public static string chromeDriverPath = @"C:\Users\SANJANA\source\repos\Unacadamey\Unacadamey\Drivers\";
        public static string geckoDriverPath = @"C:\Users\SANJANA\source\repos\Unacadamey\Unacadamey\Drivers\";

        public static string url = "https://unacademy.com/";

        public static string filePath = @"C:\Users\SANJANA\source\repos\Unacadamey\Unacadamey\screenshots\";

        public static int PAGE_LOAD_TIMEOUT = 10;
        public static int IMPLICIT_WAIT = 10;


    }
}
