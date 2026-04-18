using Application.Interfaces;
using Application.Property_DTO;
using Domin.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Services
{
    public class PropertyService
    {
        private readonly IPropertyRepository _propertyRepository;

        public PropertyService(IPropertyRepository propertyRepository)
        {
            _propertyRepository = propertyRepository;
        }

        public async Task CreatePropertyAsync(CreatePropertyDto dto)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<PropertyDto>> GetAllAsync()
        {
            var properties = await _propertyRepository.GetAllAsync();

            return properties.Select(p => new PropertyDto
            {
                Id = p.Id,
                Title = p.Title,
               
            });
        }
    }
}
