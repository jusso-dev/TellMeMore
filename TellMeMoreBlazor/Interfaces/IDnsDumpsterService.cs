using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TellMeMoreBlazor.Models;

namespace TellMeMoreBlazor.Interfaces
{
	public interface IDnsDumpsterService
	{
		Task<DnsDumpsterModel> GetAsync(string hostUrl);
	}
}
