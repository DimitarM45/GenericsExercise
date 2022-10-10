using System;
using System.Collections.Generic;
using System.Text;

namespace Threeuple
{
    public class Threeuple<T, U, P>
    {
		private T firstValue;

		private U secondValue;

		private P thirdValue;

		public Threeuple(T firstValue, U secondValue, P thirdValue)
		{
			FirstValue = firstValue;
			SecondValue = secondValue;
			ThirdValue = thirdValue;
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

		public P ThirdValue
		{
			get { return thirdValue; }
			set { thirdValue = value; }
		}

		public override string ToString()
		{
			return $"{FirstValue} -> {SecondValue} -> {ThirdValue}";
		}
	}
}
