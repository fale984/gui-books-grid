using BooksGrid.Core.Models;

namespace BooksGrid.Core.Managers
{
    /// <summary>
    /// Reads a catalog from a source
    /// </summary>
    public interface ICatalogReader
    {
        /// <summary>
        /// Reads the catalog information from the specified file
        /// </summary>
        /// <param name="source">Catalog source</param>
        /// <returns></returns>
        Catalog ReadCatalog(string source);
    }
}
