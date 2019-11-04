using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SslLabsLib.Objects;

namespace TellMeMore.Interfaces
{
	public interface IQualysService
	{
		Task<Analysis> QualysReport(string domainUrl);
	}
}
