using System.Collections.Generic;
using System.Linq;
using NetAdvantageProofs.Data;
using NetAdvantageProofs.Models;

namespace NetAdvantageProofs.Mappers
{
    public static class DataEntityMappers
    {
        public static IList<ProductModel> AsProductModels(this IEnumerable<Product> products)
        {
            return products.Select(AsProductModel).ToList();
        }

        public static ProductModel AsProductModel(this Product product)
        {
            return new ProductModel
                       {
                           Id= product.ProductID,
                           Name = product.Name,
                           ProductNumber = product.ProductNumber
                       };
        }
    }
}