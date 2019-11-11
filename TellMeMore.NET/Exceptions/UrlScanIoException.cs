using System;

namespace TellMeMore.Exceptions
{
	public class UrlScanIoException : Exception
	{
		public UrlScanIoException()
		{

		}
		public UrlScanIoException(string message) : base(message)
		{

		}
		public UrlScanIoException(string message, Exception ex) : base(message, ex)
		{

		}
	}
}
