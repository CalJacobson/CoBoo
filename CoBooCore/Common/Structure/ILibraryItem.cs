using CoBooCore.Auth;
using System;
using System.Collections.Generic;

namespace CoBooCore.Common.Structure
{
    public interface ILibraryItem
    {
        /// <summary>
        /// Returns a longer description of the item.
        /// </summary>
        /// <returns>Description of the item</returns>
        string GetDescription();

        /// <summary>
        /// Returns the unique ID of the item.
        /// </summary>
        /// <returns>Unique ID of the item</returns>
        Guid GetId();

        /// <summary>
        /// Returns the general type of the item.
        /// </summary>
        /// <returns>General type of the item</returns>
        LibraryItemType GetItemType();

        /// <summary>
        /// Returns the name of the item.
        /// </summary>
        /// <returns>Name of the item</returns>
        string GetName();

        /// <summary>
        /// Returns the individual who owns the item.
        /// </summary>
        /// <returns>User who owns the item</returns>
        ICoBooUser GetOwner();

        /// <summary>
        /// Returns the unique ID of the item's parent, if applicable.
        /// </summary>
        /// <returns>Unique ID of the item's parent, if applicable</returns>
        Guid? GetParentId();

        /// <summary>
        /// Returns the general type of the item's parent, if applicable.
        /// </summary>
        /// <returns>General type of the item's parent</returns>
        LibraryItemType GetParentItemType();

        /// <summary>
        /// Returns a list of specific user authorizations for this item.
        /// </summary>
        /// <returns>A list of specific user authorizations for this item</returns>
        List<UserAuthorization> GetUserAuthorizations();
    }
}
