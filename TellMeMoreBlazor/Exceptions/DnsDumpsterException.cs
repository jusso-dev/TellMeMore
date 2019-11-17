using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TellMeMoreBlazor.Exceptions
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
