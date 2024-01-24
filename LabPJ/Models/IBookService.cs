using LabPJ.Models;
using Data.Entities;

namespace LabPJ.Models;

    public interface IBookService
    {
        int Add(Book book);
        void Delete(int id);
        void Update(Book book);
        List<Book> FindAll(int page, int pageSize);
        Book? FindById(int id);
        List<LibraryEntity> FindAllOrganizations();
        int CountBooks();
        List<Book> GetBooksByLibraryId(int libraryId);
        IEnumerable<Book> GetBooks();
    }