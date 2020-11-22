using System;

namespace CoBooCore.Auth
{
    public class UserAuthorization
    {

        public UserAuthorization(Guid userId, UserPermissionLevel permission)
        {
            UserId = userId;
            UserPermission = permission;
        }

        public UserPermissionLevel UserPermission { get; }
        public Guid UserId { get; }
    }
}
