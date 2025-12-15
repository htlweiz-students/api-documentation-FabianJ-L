namespace AverageCalculator;

using System;
using System.Collections.Generic;
using System.Linq;

public class Class1
{
    private readonly List<double> list = new List<double>(100);

    public Class1(double[] values)
    {
        if (values != null)
            list.AddRange(values);
    }

    public void Add(double value)
    {
        list.Add(value);
    }

    public void Add(double[] values)
    {
        if (values == null || values.Length == 0)
            return;

        list.AddRange(values);
    }

    public double GetAverage()
    {
        if (list.Count == 0)
            throw new InvalidOperationException("Keine Werte vorhanden");

        return list.Average();
    }

    public double[] GetElements()
    {
        return list.ToArray();
    }

    public int Count()
    {
        return list.Count;
    }
}
