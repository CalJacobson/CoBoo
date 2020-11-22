using CoBooCore.Auth;
using System;
using System.Collections.Generic;

namespace CoBooCore.Common.Structure
{
    public interface ILibrary
    {
        /// <summary>
        /// Returns the unique ID of the library.
        /// </summary>
        /// <returns>Unique ID of the library</returns>
        Guid GetId();

        /// <summary>
        /// Returns a list of specified user permissions for the library.
        /// </summary>
        /// <returns>Specific user permissions for the library</returns>
        List<UserAuthorization> GetUserAuthorizations();
    }
}
