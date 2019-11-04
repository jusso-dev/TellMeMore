using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TellMeMore.Models.BuiltWithModel;

namespace TellMeMore.Interfaces
{
	public interface IBuiltWithService
	{
		Task<BuiltWithModel> GetAsync(string hostUrl);
	}
}
