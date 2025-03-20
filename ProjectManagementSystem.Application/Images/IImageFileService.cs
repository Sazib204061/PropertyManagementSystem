namespace ProjectManagementSystem.Application.Images
{
    public interface IImageFileService
    {
        Task<IList<ImageVM>> GetAllImagesAsync();
        Task<ImageVM> GetImageByIdAsync(int ImageId);
        Task AddImageAsync(ImageVM img);
        Task UpdateImageAsync(int ImageId, ImageVM img);
        Task DeleteImageAsync(int ImageId);
    }
}
