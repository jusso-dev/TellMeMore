namespace TellMeMore.Models.BuiltWithModel
{
	public class BuiltWithModel
	{
		public int first { get; set; }
		public int last { get; set; }
		public string domain { get; set; }
		public Group[] groups { get; set; }
	}

	public class Group
	{
		public string name { get; set; }
		public int live { get; set; }
		public int dead { get; set; }
		public int latest { get; set; }
		public int oldest { get; set; }
		public Category[] categories { get; set; }
	}

	public class Category
	{
		public int live { get; set; }
		public int dead { get; set; }
		public int latest { get; set; }
		public int oldest { get; set; }
		public string name { get; set; }
	}
}
