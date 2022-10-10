using System;
using System.Collections.Generic;

namespace GenericTuple
{
    public class GenericTuple<T, U>
    {
		private T firstValue;

		private U secondValue;

		public GenericTuple(T firstValue, U secondValue)
		{
			FirstValue = firstValue;
			SecondValue = secondValue;
		}

		public T FirstValue
		{
			get { return firstValue; }
			set { firstValue = value; }
		}

		public U SecondValue
		{
			get { return secondValue; }
			set { secondValue = value; }
		}

		public override string ToString()
		{
			return $"{firstValue} -> {secondValue}";
		}
	}
}
