using System;

namespace AgileCoding.Extentions.Interfaces
{
	public static class InterfaceExtentions
	{
		public static void CopyToInterfaceByRefTo<T>(this T from, T to)
		{
			if (typeof(T).IsInterface)
			{
				to = from;
				return;
			}
			throw new ArgumentException("Was expecting a Interface typehere");
		}
	}
}
