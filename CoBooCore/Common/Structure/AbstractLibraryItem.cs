using CoBooCore.Auth;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CoBooCore.Common.Structure
{
    public class AbstractLibraryItem : ILibraryItem
    {
        protected string itemDescription;
        protected Guid itemId;
        protected string itemName;
        protected Guid itemOwnerId;
        protected Guid? itemParentId;
        protected LibraryItemType itemParentType;
        protected LibraryItemType itemType;
        protected List<UserAuthorization> authorizedUsers = new List<UserAuthorization>();
        

        public string GetDescription()
        {
            return itemDescription;
        }

        public Guid GetId()
        {
            return itemId;
        }

        public LibraryItemType GetItemType()
        {
            return itemType;
        }

        public string GetName()
        {
            return itemName;
        }

        public ICoBooUser GetOwner()
        {
            throw new NotImplementedException();
        }

        public Guid? GetParentId()
        {
            return itemParentId;
        }

        public LibraryItemType GetParentItemType()
        {
            return (itemParentId == null) ? LibraryItemType.Unknown : itemParentType;
        }

        public List<UserAuthorization> GetUserAuthorizations()
        {
            // ensure owner is in this list, with full permission
            var owner = authorizedUsers.Where(auth => auth.UserId == itemOwnerId).FirstOrDefault();
            if (owner == null)
                authorizedUsers.Add(new UserAuthorization(itemOwnerId, UserPermissionLevel.Full));

            return authorizedUsers;
        }
    }
}
