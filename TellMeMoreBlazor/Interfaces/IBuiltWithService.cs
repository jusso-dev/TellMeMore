using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TellMeMoreBlazor.Models;

namespace TellMeMoreBlazor.Interfaces
{
	public interface IBuiltWithService
	{
		Task<BuiltWithModel> GetAsync(string hostUrl);
	}
}
