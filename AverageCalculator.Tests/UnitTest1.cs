using Xunit;
using AverageCalculator;

namespace AverageCalculator.Tests
{
    public class AddOneValueTests
    {
        [Fact]
        public void AddPositiveValue()
        {
            double[] start = {1, 2, 3};
            Class1 calc = new Class1(start);

            calc.Add(5);

            Assert.Equal(4, calc.Count());
            Assert.Equal(5, calc.GetElements()[3]);
        }

        [Fact]
        public void AddNegativeValue()
        {
            double[] start = {1, 2, 3};
            Class1 calc = new Class1(start);

            calc.Add(-5);

            Assert.Equal(4, calc.Count());
            Assert.Equal(-5, calc.GetElements()[3]);
        }

        [Fact]
        public void AddToEmptyList()
        {
            double[] start = {};
            Class1 calc = new Class1(start);

            calc.Add(7);

            Assert.Equal(1, calc.Count());
            Assert.Equal(7, calc.GetElements()[0]);
        }
    }

    public class AddMoreValuesTests
    {
        [Fact]
        public void AddMultiplePositiveValues()
        {
            double[] start = {1, 2};
            Class1 calc = new Class1(start);

            double[] values = {3, 4};
            calc.Add(values);

            Assert.Equal(4, calc.Count());
            Assert.Equal(new double[] {1,2,3,4}, calc.GetElements());
        }

        [Fact]
        public void AddMultipleNegativeValues()
        {
            double[] start = {-1, -2};
            Class1 calc = new Class1(start);

            double[] values = {-3, -4};
            calc.Add(values);

            Assert.Equal(4, calc.Count());
            Assert.Equal(new double[] {-1,-2,-3,-4}, calc.GetElements());
        }

        [Fact]
        public void AddToEmptyListMultipleValues()
        {
            double[] start = {};
            Class1 calc = new Class1(start);

            double[] values = {1, -2, 3};
            calc.Add(values);

            Assert.Equal(3, calc.Count());
            Assert.Equal(values, calc.GetElements());
        }
    }

    public class GetAverageTests
    {
        [Fact]
        public void AveragePositiveNumbers()
        {
            double[] start = {2, 4, 6};
            Class1 calc = new Class1(start);

            Assert.Equal(4, calc.GetAverage());
        }

        [Fact]
        public void AverageNegativeNumbers()
        {
            double[] start = {-2, -4, -6};
            Class1 calc = new Class1(start);

            Assert.Equal(-4, calc.GetAverage());
        }

        [Fact]
        public void AverageMixedNumbers()
        {
            double[] start = {-1, 0, 1};
            Class1 calc = new Class1(start);

            Assert.Equal(0, calc.GetAverage());
        }
    }

    public class GetElementsTests
    {
        [Fact]
        public void ReturnsAllElements()
        {
            double[] start = {1, 2, 3};
            Class1 calc = new Class1(start);

            Assert.Equal(start, calc.GetElements());
        }

        [Fact]
        public void ReturnsEmptyArrayForEmptyList()
        {
            double[] start = {};
            Class1 calc = new Class1(start);

            Assert.Empty(calc.GetElements());
        }

        [Fact]
        public void ReturnsCorrectAfterAddingValues()
        {
            double[] start = {1};
            Class1 calc = new Class1(start);
            calc.Add(2);
            calc.Add(new double[] {3,4});

            Assert.Equal(new double[] {1,2,3,4}, calc.GetElements());
        }
    }

    public class CountTests
    {
        [Fact]
        public void CountAfterInitialization()
        {
            double[] start = {1,2,3};
            Class1 calc = new Class1(start);

            Assert.Equal(3, calc.Count());
        }

        [Fact]
        public void CountAfterAddingOneValue()
        {
            double[] start = {1};
            Class1 calc = new Class1(start);
            calc.Add(5);

            Assert.Equal(2, calc.Count());
        }

        [Fact]
        public void CountAfterAddingMultipleValues()
        {
            double[] start = {};
            Class1 calc = new Class1(start);
            calc.Add(new double[] {1,2,3});

            Assert.Equal(3, calc.Count());
        }
    }
}
