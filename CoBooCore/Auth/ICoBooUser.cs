using System;

namespace CoBooCore.Auth
{
    public interface ICoBooUser
    {
        /// <summary>
        /// Unique ID for the user.
        /// </summary>
        /// <returns>User ID</returns>
        Guid GetId();
    }
}
