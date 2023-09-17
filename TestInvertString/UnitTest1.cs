using InvertString;

namespace TestInvertString
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("otxet", "texto")]
        [InlineData("bob", "bob")]
        [InlineData("gnirts", "string")]
        [InlineData("", "")]
        [InlineData("202", "202")]
        [InlineData("tsal", "last")]
        public void Test_GetInvertedString(string expectedString, string data)
        {
            string invertedString = Program.GetInvertedString(data);
            Assert.Equal(expectedString, invertedString);
        }
    }
}