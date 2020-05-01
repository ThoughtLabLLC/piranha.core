/*
 * Copyright (c) .NET Foundation and Contributors
 *
 * This software may be modified and distributed under the terms
 * of the MIT license.  See the LICENSE file for details.
 *
 * https://github.com/piranhacms/piranha.core
 *
 */

using System;

namespace Piranha.Extend
{
	/// <summary>
	/// Metadata for white-listing specific <see cref="T:Piranha.Extend.Block"/> types that can be added to classes that inherit from <see cref="T:Piranha.Extend.BlockGroup"/>.
	/// </summary>
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    public class BlockItemTypeAttribute : Attribute
    {
        /// <summary>
        /// Gets/sets the type of the accepted child item.
        /// </summary>
        public Type Type { get; set; }
    }
}
