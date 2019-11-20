/*
 * Copyright (c) 2019 Håkan Edling
 *
 * This software may be modified and distributed under the terms
 * of the MIT license.  See the LICENSE file for details.
 *
 * https://github.com/piranhacms/piranha.core
 *
 */

using System;
using System.Collections.Generic;

namespace Piranha.Manager.Models.Content
{
    /// <summary>
    /// Edit model for block groups.
    /// </summary>
    public class GenericBlockModel : BlockItemModel
	{
		/// <summary>
		/// Gets/sets the unique id.
		/// </summary>
		public Guid Id { get; set; }

		/// <summary>
		/// Gets/sets the type of the generic block.
		/// </summary>
		public string Type { get; set; }

		/// <summary>
		/// Gets/sets the name of the property used when displaying the title.
		/// </summary>
		public string DisplayTitleProperty { get; set; }

		/// <summary>
		/// Gets/sets the available global group fields.
		/// </summary>
		public IList<FieldModel> Fields { get; set; } = new List<FieldModel>();
    }
}