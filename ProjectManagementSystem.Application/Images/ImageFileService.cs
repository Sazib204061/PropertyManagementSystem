using AutoMapper;
using ProjectManagementSystem.Application.Images;
using ProjectManagementSystem.Application.Owner;
using ProjectManagementSystem.Application.Repository;
using ProjectManagementSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementSystem.Application.Images
{
    public class ImageFileService : IImageFileService
    {
        private readonly IBaseRepository<Image> _imageRepository;
        private readonly IMapper _mapper;
        
        public ImageFileService(IBaseRepository<Image> imageRepository, IMapper mapper)
        {
            _imageRepository = imageRepository;
            _mapper = mapper;
        }
        public async Task<IList<ImageVM>> GetAllImagesAsync()
        {
            var images = await _imageRepository.GetAllAsync();
            return _mapper.Map<IList<ImageVM>>(images);
        }

        public async Task<ImageVM> GetImageByIdAsync(int ImageId)
        {
            var image = await _imageRepository.GetByIdAsync(ImageId);
            return _mapper.Map<ImageVM>(image);
        }

        public async Task AddImageAsync(ImageVM img)
        {
            var addImage = _mapper.Map<ImageVM>(img);
            await _imageRepository.AddAsync(addImage);
        }

        public async Task UpdateImageAsync(int ImageId, ImageVM img)
        {
            var exist_image = await _imageRepository.GetByIdAsync(ImageId);
            if (exist_image == null)
            {
                throw new KeyNotFoundException($"Image with Id {ImageId} not found");
            }
            _mapper.Map(img, exist_image);
            await _imageRepository.UpdateAsync(exist_image);
        }

        public async Task DeleteImageAsync(int ImageId)
        {
            var exist_image = await _imageRepository.GetByIdAsync(ImageId);
            if (exist_image == null)
            {
                throw new KeyNotFoundException($"Image with Id {ImageId} not found");
            }
            await _imageRepository.DeleteAsync(ImageId);
        }
    }
}
