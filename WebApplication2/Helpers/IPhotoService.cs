using CloudinaryDotNet.Actions;

namespace WebApplication2.Helpers
{
    public interface IPhotoService
    {
        Task<ImageUploadResult> AddPhotoAsync(IFormFile file);
        Task<DeletionResult> DeletePhotoAsync(string publicId);
        Task<ImageUploadResult> UpdatePhotoAsync(IFormFile file);

    }
}
