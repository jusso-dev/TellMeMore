using System;

namespace TellMeMore.Exceptions
{
	public class DnsDumpsterException : Exception
	{
		public DnsDumpsterException()
		{

		}
		public DnsDumpsterException(string message) : base(message)
		{

		}
		public DnsDumpsterException(string message, Exception ex) : base(message, ex)
		{

		}
	}
}
