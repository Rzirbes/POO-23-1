using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AS.Domain.Entities;
using AS.Domain.Interfaces.RepositoryInterfaces;

namespace AS.Services
{
    public class PublisherService
    {
        private readonly IBaseRepository<Publisher> _publisherRepository;

        public PublisherService(IBaseRepository<Publisher> publisherRepository)
        {
            _publisherRepository = publisherRepository;
        }

        public async Task<Publisher> GetPublisherByIdAsync(int id)
        {
            return await _publisherRepository.GetByIdAsync(id);
        }

        public async Task<List<Publisher>> GetAllPublishersAsync()
        {
            return await _publisherRepository.GetAllAsync();
        }

        public async Task CreatePublisherAsync(Publisher publisher)
        {
            await _publisherRepository.AddAsync(publisher);
        }

        public async Task UpdatePublisherAsync(Publisher publisher)
        {
            await _publisherRepository.UpdateAsync(publisher);
        }

        public async Task DeletePublisherAsync(int id)
        {
            await _publisherRepository.DeleteAsync(id);
        }
    }
}
