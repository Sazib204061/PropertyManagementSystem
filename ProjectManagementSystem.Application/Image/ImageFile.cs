using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementSystem.Application.Image
{
    public class ImageFile : IImageFile
    {
        public ImageFile()
        {
            
        }
        public Task AddImageAsync(ImageVM img)
        {
            throw new NotImplementedException();
        }

        public Task DeleteImageAsync(int imageId)
        {
            throw new NotImplementedException();
        }

        public Task<IList<ImageVM>> GetAllImagesAsync()
        {
            throw new NotImplementedException();
        }

        public Task GetImageByIdAsync(int imageId)
        {
            throw new NotImplementedException();
        }

        public Task<ImageVM> GetImageByPathAsync(string path)
        {
            throw new NotImplementedException();
        }

        public Task UpdateImageAsync(int imageId, ImageVM img)
        {
            throw new NotImplementedException();
        }
    }
}
