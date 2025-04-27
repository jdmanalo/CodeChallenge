using CodeChallenge;

namespace KeypadTest
{
    public class Testing
    {
        [Theory]
        [InlineData("2#", "A")]
        [InlineData("22#", "B")]
        [InlineData("222#", "C")]
        [InlineData("223#", "BD")]
        [InlineData("33#", "E")]
        [InlineData("227*#", "B")]
        [InlineData("4433555 555666#", "HELLO")]
        [InlineData("8 88777444666*664#", "TURINNG")]
        public void KeypadTesting(string input, string expected)
        {
            var processor = new KeyPad();
            string output = processor.ProcessInput(input);
            Assert.Equal(expected, output);
        }
    }
}