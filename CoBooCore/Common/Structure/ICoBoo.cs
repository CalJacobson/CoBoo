using CoBooCore.Auth;
using System.Collections.Generic;

namespace CoBooCore.Common.Structure
{
    public interface ICoBoo
    {
        List<ILibrary> GetAllLibraries();

        List<ILibrary> GetAuthorizedLibraries(ICoBooUser user);
    }
}
