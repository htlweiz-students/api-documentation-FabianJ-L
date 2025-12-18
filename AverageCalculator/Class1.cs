namespace AverageCalculator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Berechnet den Durchschnitt von einer Sammlung von Zahlen und verwaltet die Elemente.
    /// </summary>
    public class Class1
    {
        private readonly List<double> list = new List<double>(100);

        /// <summary>
        /// Erstellt eine neue Instanz von <see cref="Class1"/> und fügt optional vorhandene Werte hinzu.
        /// </summary>
        /// <param name="values">Ein Array von Anfangswerten, das der Liste hinzugefügt werden soll. Kann <c>null</c> sein.</param>
        public Class1(double[] values)
        {
            if (values != null)
                list.AddRange(values);
        }

        /// <summary>
        /// Fügt einen einzelnen Wert zur Sammlung hinzu.
        /// </summary>
        /// <param name="value">Der Wert, der hinzugefügt werden soll.</param>
        public void Add(double value)
        {
            list.Add(value);
        }

        /// <summary>
        /// Fügt mehrere Werte zur Sammlung hinzu.
        /// </summary>
        /// <param name="values">Ein Array von Werten, die hinzugefügt werden sollen. Kann <c>null</c> oder leer sein.</param>
        public void Add(double[] values)
        {
            if (values == null || values.Length == 0)
                return;

            list.AddRange(values);
        }

        /// <summary>
        /// Berechnet den Durchschnitt aller in der Sammlung enthaltenen Werte.
        /// </summary>
        /// <returns>Der Durchschnittswert der Sammlung.</returns>
        /// <exception cref="InvalidOperationException">Wird geworfen, wenn keine Werte in der Sammlung vorhanden sind.</exception>
        public double GetAverage()
        {
            if (list.Count == 0)
                throw new InvalidOperationException("Keine Werte vorhanden");

            return list.Average();
        }

        /// <summary>
        /// Gibt alle Elemente der Sammlung als Array zurück.
        /// </summary>
        /// <returns>Ein Array aller Elemente der Sammlung.</returns>
        public double[] GetElements()
        {
            return list.ToArray();
        }

        /// <summary>
        /// Gibt die Anzahl der in der Sammlung enthaltenen Elemente zurück.
        /// </summary>
        /// <returns>Anzahl der Elemente in der Sammlung.</returns>
        public int Count()
        {
            return list.Count;
        }
    }
}
