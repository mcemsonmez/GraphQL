using aspnetcoregraphql.Data;
using GraphQL.Types;

namespace aspnetcoregraphql.Models
{
    public class ProductType: ObjectGraphType<Product>
    {
        public ProductType(ICategoryRepository categoryRepository){
            Field(x => x.Id).Description("Product Id");
            Field(x => x.Name).Description("Product Name");
            Field(x => x.Description, nullable:true).Description("Product Description");
            Field(x => x.Price).Description("Product Price");

            Field<CategoryType>(
                "category",
                resolve: context => categoryRepository.GetCategoryAsync(context.Source.CategoryId).Result
            );
        }
    }
}