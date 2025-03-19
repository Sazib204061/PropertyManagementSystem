using ProjectManagementSystem.Application.Owner;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
