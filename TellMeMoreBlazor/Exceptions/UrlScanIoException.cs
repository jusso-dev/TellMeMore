using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TellMeMoreBlazor.Exceptions
{
	public class urlScanIoException : Exception
	{
		public urlScanIoException()
		{

		}
		public urlScanIoException(string message) : base(message)
		{

		}
		public urlScanIoException(string message, Exception ex) : base(message, ex)
		{

		}
	}
}
