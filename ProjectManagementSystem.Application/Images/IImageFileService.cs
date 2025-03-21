namespace ProjectManagementSystem.Application.Images
{
    public interface IImageFileService
    {
        Task<IList<ImageVM>> GetAllImagesAsync();
        Task<ImageVM> GetImageByIdAsync(int id);
        Task AddImageAsync(ImageVM img);
        Task UpdateImageAsync(int id, ImageVM img);
        Task DeleteImageAsync(int id);
    }
}
