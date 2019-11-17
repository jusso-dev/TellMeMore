using System;

namespace TellMeMoreBlazor.Exceptions
{
	public class BuiltWithException : Exception
	{
		public BuiltWithException()
		{

		}
		public BuiltWithException(string message) : base(message)
		{

		}
		public BuiltWithException(string message, Exception ex) : base(message, ex)
		{

		}
	}
}
