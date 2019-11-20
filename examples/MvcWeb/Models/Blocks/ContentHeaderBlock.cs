using Piranha.Extend;
using Piranha.Extend.Fields;
using Piranha.Models;

namespace MvcWeb.Models.Blocks
{
	public enum ContentHeadingLevel
	{
		None = 0,
		H1 = 1,
		H2 = 2,
		H3 = 3,
		H4 = 4,
		H5 = 5,
		H6 = 6
	}

	[GenericBlockType(Name = "Header", Category = "TL", Icon = "fa fa-heading", DisplayTitleProperty = nameof(Text))]
	public class ContentHeaderBlock : Block
	{
		[Field(Options = FieldOption.HalfWidth, Title = "Heading Level")]
		public SelectField<ContentHeadingLevel> HeadingLevel { get; set; }

		[Field(Options = FieldOption.HalfWidth)]
		public StringField Text { get; set; }

		public override string GetTitle()
		{
			return Text.Value;
		}
	}
}
