using Data.Entities;


namespace LabPJ.Models
{
    public interface IBorrowService
    {
        Task<BorrowEntity> BorrowBookAsync(int bookId, string userId);
        Task ReturnBookAsync(int borrowId);
    }

}
