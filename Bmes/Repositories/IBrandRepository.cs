using Bmes.Models.Product;
using System;
using System.Collections.Generic;

namespace Bmes.Repositories
{
    public interface IBrandRepository
    {
        Brand FindBrandById(Guid id);
        IEnumerable<Brand> GetAllBrands();
        void SaveBrand(Brand brand);
        void UpdateBrand(Brand brand);
        void DeleteBrand(Brand brand);
    }
}
