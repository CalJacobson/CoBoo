using System.Collections.Generic;

namespace CoBooCore.Common.Structure
{
    public interface ILibraryCollection : ILibraryItem
    {
        List<ILibraryItem> GetChildren();
    }
}
