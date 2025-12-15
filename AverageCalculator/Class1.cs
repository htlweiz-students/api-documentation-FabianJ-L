namespace AverageCalculator;

public class Class1
{
    private readonly List<double> list = new List<double>(100);

    public Class1(double[] values)
    {
        list.AddRange(values);
    }
    public void Add(double value)
    {
        list.Add(value);
    }
    public int Add(double[] values)
    {
        if (values.Length == 0)
        {
            return 1;
        }
        else
        {
            list.AddRange(values);
            return 0;
        }
    }
    public double getAverage()
    {
        if (list.Count == 0)
            throw new InvalidOperationException("Keine Werte vorhanden");

        return list.Average();
    }
    public double[] getElemnts()
    {
        return list.ToArray();
    }
    public int count(){
        return list.Count(); 
    }
}

