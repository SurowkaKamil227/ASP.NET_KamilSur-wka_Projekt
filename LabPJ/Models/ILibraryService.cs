using LabPJ.Models;
using System.Collections.Generic;


namespace LabPJ.Models
{
    public interface ILibraryService
    {
        List<Library> GetAllLibraries();
        Library GetLibraryById(int id);
        void AddLibrary(Library library);
        void UpdateLibrary(Library library);
        void DeleteLibrary(int id);
    }
}
