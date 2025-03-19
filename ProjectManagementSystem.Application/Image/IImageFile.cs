using ProjectManagementSystem.Application.City;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementSystem.Application.Image
{
    public interface IImageFile
    {
        Task<IList<ImageVM>> GetAllImagesAsync();
        Task GetImageByIdAsync(int imageId);
        Task AddImageAsync(ImageVM img);
        Task UpdateImageAsync(int imageId, ImageVM img);
        Task DeleteImageAsync(int imageId);
        Task<ImageVM> GetImageByPathAsync(string path);
    }
}
