using CoBooCore.Auth;
using System;
using System.Collections.Generic;

namespace CoBooCore.Common.Structure
{
    /// <summary>
    /// Represents a top-level item in the CoBoo hierarchy.
    /// </summary>
    public sealed class CoBoo : ICoBoo
    {
        public List<ILibrary> GetAllLibraries()
        {
            throw new NotImplementedException();
        }

        public List<ILibrary> GetAuthorizedLibraries(ICoBooUser user)
        {
            throw new NotImplementedException();
        }
    }
}
