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

        public async Task<Guid> CreatePropertyAsync(CreatePropertyDto dto)
        {
            var property = new Property(dto.LandlordId, dto.Title, dto.Price);

            await _propertyRepository.AddAsync(property);

            return property.Id;
        }

        public async Task<IEnumerable<PropertyDto>> GetAllAsync()
        {
            var properties = await _propertyRepository.GetAllAsync();

            return properties.Select(p => new PropertyDto
            {
                Id = p.Id,
                Title = p.Title,
                Price = p.Price,
                Status = p.Status
            });
        }
    }
}
