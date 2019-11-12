using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TellMeMore.Shared.Interfaces
{
	public interface ITellMeMoreLogger
	{
		Task<string> ReadConfiguration(string keyName);
	}
}
