using AutoMapper;
using ProjectManagementSystem.Application.Repository;
using ProjectManagementSystem.Domain.Entities;

namespace ProjectManagementSystem.Application.Owners
{
    public class OwnerService : IOwnerService
    {
        private readonly IBaseRepository<Owner> _ownerRepository;
        private readonly IMapper _mapper;

        public OwnerService(IBaseRepository<Owner> ownerRepository, IMapper mapper)
        {
            _ownerRepository = ownerRepository;
            _mapper = mapper;
        }

        public async Task<IList<OwnerVM>> GetAllOwnersAsync()
        {
            var owners = await _ownerRepository.GetAllAsync();
            return _mapper.Map<IList<OwnerVM>>(owners);
        }

        public async Task AddOwnerAsync(OwnerVM owner)
        {
            var ownerToCreate = _mapper.Map<Owner>(owner);
            await _ownerRepository.AddAsync(ownerToCreate);
        }
        public async Task<OwnerVM> GetOwnerByIdAsync(int id)
        {
            var owner = await _ownerRepository.GetByIdAsync(id);
            if (owner == null)
            {
                throw new KeyNotFoundException($"Owner with ID {id} not found.");
            }
            return _mapper.Map<OwnerVM>(owner);
        }

        public async Task UpdateOwnerAsync(int id, OwnerVM owner)
        {
            var existingOwner = await _ownerRepository.GetByIdAsync(id);
            if (existingOwner == null)
            {
                throw new KeyNotFoundException($"Owner with ID {id} not found.");
            }
            _mapper.Map(owner, existingOwner);
            await _ownerRepository.UpdateAsync(existingOwner);
        }

        public async Task DeleteOwnerAsync(int id)
        {
            var existingOwner = await _ownerRepository.GetByIdAsync(id);
            if (existingOwner == null)
            {
                throw new KeyNotFoundException($"Owner with ID {id} not found.");
            }
            await _ownerRepository.DeleteAsync(id);
        }

    }
}
