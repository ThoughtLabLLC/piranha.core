using System;

namespace Piranha.Extend
{
	/// <summary>
	/// Metadata for classes that inherit from <see cref="T:Piranha.Extend.Block"/> that should be rendered generically.
	/// </summary>
	[AttributeUsage(AttributeTargets.Class)]
	public class GenericBlockTypeAttribute : BlockTypeAttribute
	{
		/// <summary>
		/// Gets/sets the name of the property used when displaying the title.
		/// </summary>
		public string DisplayTitleProperty { get; set; }
	}
}
