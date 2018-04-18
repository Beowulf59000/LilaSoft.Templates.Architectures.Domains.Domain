namespace LilaSoft.Templates.Architectures.Domains.Domain.AggregateModels.ExampleAggregate
{
    using LilaSoft.Architectures.Domains.Domain.SeedWork;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IExampleRepository : IRepository<Example>
    {
        Task<IEnumerable<Example>> GetExamplesAsync();

        Task<Example> GetExampleAsync(int id);
    }
}
