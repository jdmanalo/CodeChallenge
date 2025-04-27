namespace CodeChallenge
{
    public class Program
    {
        //Declaring global 
        private KeyPad _keypad = new KeyPad();
        static void Main(string[] args)
        {
            var _program = new Program();
            _program.Maintask();
        }
        public void Maintask()
        {
            try
            {
                //Initialize data gathering from USER
                Console.Write("Input: ");

                //User input Stored in variable
                string input = Console.ReadLine();

                //Apply Some Condition
                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Please input correct data.");
                }
                else if (!IsValidInput(input))
                {
                    Console.WriteLine("Input must only contain digits 2-9, '*' or '#'.");
                }
                else
                {
                    var _keypad = new KeyPad();
                    //After validation , if input is Correct then the data will process inside
                    string result = _keypad.ProcessInput(input);
                    Console.WriteLine("Output: " + result);
                }

                Maintask();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Internal Error :"+ex.Message);
                Maintask();
            }
        }
        private bool IsValidInput(string input)
        {
            return input.All(c => (c >= '2' && c <= '9') || c == '*' || c == '#' || c == ' ');
        }
    }

}
