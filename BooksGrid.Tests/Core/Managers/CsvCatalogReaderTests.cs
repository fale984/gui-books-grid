using BooksGrid.Core.Managers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BooksGrid.Tests.Core.Managers
{
    [TestClass]
    public class CsvCatalogReaderTests
    {
        [TestMethod]
        public void CsvCatalogReader_ParseBookRow_ConvertsRow()
        {
            // Arrange
            var line = "Title;Author;1990;10,5;yes;Binding;Description";
            var catalogReader = new CsvCatalogReader();

            // Act
            var book = catalogReader.ParseBookRow(line);

            // Assert
            Assert.AreEqual("Title", book.Title);
            Assert.AreEqual("Author", book.Author);
            Assert.AreEqual(1990, book.Year);
            Assert.AreEqual(10.5, book.Price);
            Assert.IsTrue(book.InStock);
            Assert.AreEqual("Binding", book.Binding);
            Assert.AreEqual("Description", book.Description);
        }

        [TestMethod]
        public void CsvCatalogReader_ParseBookRow_ReturnsNullForInvalidLine()
        {
            // Arrange
            var line = string.Empty;
            var catalogReader = new CsvCatalogReader();

            // Act
            var book = catalogReader.ParseBookRow(line);

            // Assert
            Assert.IsNull(book);
        }
    }
}
