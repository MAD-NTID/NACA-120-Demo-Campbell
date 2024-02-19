public class CalculationTest
{
    [Test]
    [Category("Testing Add Method")]
    public void TestAdd()
    {
        //create object instance
        Calculation calculation  = new Calculation();

        //setup
        int number1 = 2;
        int number2 = 3;

        double expect = 5.0;

        //invoke
        double actual = calculation.Add(number1, number2);

        //analyze
        Assert.AreEqual(actual, 2.0);
    }
}