namespace AverageCalculator.Tests;
using AverageCalculator; 

public class AddOneValue
{
    [Fact]
    public void TestAddPositiv()
    {
        double[] startValues = {1, 2, 3};
        Class1 calc = new Class1(startValues);

        calc.Add(8);
        Assert.Equal(4, calc.Count());
    }
    [Fact]
    public void TestAddNegativ(){
        double[] startValues = {1, 2, 3};
        Class1 calc = new Class1(startValues);

        calc.Add(-8);
        Assert.Equal(4, calc.Count());

        double[] values = calc.GetElements();

        Assert.Equal(-8, values[3]);
    }
    [Fact]
    public void TestAddToEmptyList(){
        double[] startValues = {};
        Class1 calc = new Class1(startValues);

        calc.Add(2);
        Assert.Equal(1, calc.Count());
    }
}

public class AddMoreValues{
    [Fact]
    public void TestAddPositiv()
    {
        double[] startValues = {1, 2, 3};
        Class1 calc = new Class1(startValues);

        double[] values = {1, 2, 3};

        calc.Add(values);
        Assert.Equal(6, calc.Count());
        
    }
}