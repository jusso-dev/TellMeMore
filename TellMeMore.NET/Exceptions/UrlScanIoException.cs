using System;

namespace TellMeMore.Exceptions
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
