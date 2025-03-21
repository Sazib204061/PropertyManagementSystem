using AutoMapper;
using ProjectManagementSystem.Application.Repository;
using ProjectManagementSystem.Domain.Entities;

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
        public async Task AddImageAsync(ImageVM img)
        {
            var addImage = _mapper.Map<Image>(img);
            await _imageRepository.AddAsync(addImage);
        }
        public async Task<ImageVM> GetImageByIdAsync(int id)
        {
            var image = await _imageRepository.GetByIdAsync(id);
            if(image == null)
            {
                throw new KeyNotFoundException($"Image with Id {id} not found");
            }
            return _mapper.Map<ImageVM>(image);
        }

        public async Task UpdateImageAsync(int id, ImageVM img)
        {
            var existImage = await _imageRepository.GetByIdAsync(id);
            if (existImage == null)
            {
                throw new KeyNotFoundException($"Image with Id {id} not found");
            }
            _mapper.Map(img, existImage);
            await _imageRepository.UpdateAsync(existImage);
        }

        public async Task DeleteImageAsync(int id)
        {
            var existImage = await _imageRepository.GetByIdAsync(id);
            if (existImage == null)
            {
                throw new KeyNotFoundException($"Image with Id {id} not found");
            }
            await _imageRepository.DeleteAsync(id);
        }
    }
}
