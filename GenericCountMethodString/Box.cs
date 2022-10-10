using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace GenericCountMethodString
{
    public class Box<T> where T : IComparable<T>
    {
        private List<T> list;

        public Box()
        {
            List = new List<T>();
        }

        public List<T> List { get; set; }
         
        public int CountElementsGreaterThanValue(T comparisonElement)
        {
            int countOfGreaterElements = 0;

            foreach (T element in List)
            {
                if (element.CompareTo(comparisonElement) > 0)
                    countOfGreaterElements++;
            }

            return countOfGreaterElements;
        }

        public void Add(T value)
        {
            List.Add(value);
        }
    }
}
