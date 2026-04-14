using Domin.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Interfaces
{
    public interface ILeaseRepositorty
    {
        Task<Lease> GetByIdAsync(Guid id);
        Task AddAsync(Lease lease);
    }
}

