namespace LilaSoft.Templates.Architectures.Domains.Domain.AggregateModels.ExampleAggregate
{
    using LilaSoft.Architectures.Domains.Domain.SeedWork;

    public class Example : Entity, IAggregateRoot
    {
        public string Name { get; set; }
    }
}
