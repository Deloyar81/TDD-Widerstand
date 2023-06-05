using TDD_Widerstand;

namespace TestProject1
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("rot", "schwarz", "rot", "braun", "2 Kiloohm (1%)")]
        [InlineData("braun", "schwarz", "rot", "braun", "1 Kiloohm (1%)")]
        [InlineData("grün", "schwarz", "rot", "braun", "5 Kiloohm (1%)")]
        public void Test1(string ring1, string ring2, string ring3, string ring4, string expected)
        {
            Widerstand testWiderstand = new Widerstand();

            string result = testWiderstand.WiderstandBerechnen(ring1, ring2, ring3, ring4);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("", "schwarz", "rot", "braun", "Falsche Eingabe: ")]
        [InlineData("5", "schwarz", "rot", "braun", "Falsche Eingabe: 5")]
        public void FehlerTest(string ring1, string ring2, string ring3, string ring4, string expected)
        {
            Widerstand testWiderstand = new Widerstand();
            var ex = Assert.Throws<Exception>(() => testWiderstand.WiderstandBerechnen(ring1, ring2, ring3, ring4));

            Assert.Equal(expected, ex.Message);
        }

    }
}