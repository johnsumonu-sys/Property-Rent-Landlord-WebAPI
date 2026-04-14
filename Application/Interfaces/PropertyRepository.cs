using Domin.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Interfaces
{
    public interface IPropertyRepository
    {
        Task<Property> GetByIdAsync(Guid id);
        Task<IEnumerable<Property>> GetAllAsync();
        Task AddAsync(Property property);
        Task UpdateAsync(Property property);
    }
}
