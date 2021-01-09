using System;
using AutoMapper;
using AutoMapperFlattening.DTO;
using AutoMapperFlattening.Models;

namespace AutoMapperFlattening
{
  internal class Program
  {
    public static void Main(string[] args)
    {
      var configuration = new MapperConfiguration(cfg =>
      {
        cfg.CreateMap<AddressModel, AddressDTO>();
        cfg.CreateMap<CustomerModel, CustomerDTO>()
          // .ForMember(x => x.AddressId, c => c.MapFrom(x => x.address_id))
          ;
      });
      var mapper = configuration.CreateMapper();

      var customerModel = new CustomerModel
      {
        address = new AddressModel
        {
          id = Guid.Parse("094027e0-60b6-4ed7-8077-1d5431d19211"),
          zip = "424242"
        },
        address_id = Guid.Parse("094027e0-60b6-4ed7-8077-1d5431d19211"),
        id = Guid.Parse("094027e0-60b6-4ed7-8077-1d5431d19200"),
        name = "Smith"
      };

      var customerDTO = mapper.Map<CustomerDTO>(customerModel);

      Console.WriteLine($"Customer Id:           {customerDTO?.Id}");
      Console.WriteLine($"Customer Name:         {customerDTO?.Name}");
      Console.WriteLine($"Customer AddressId:    {customerDTO?.AddressId}");
      Console.WriteLine($"Customer Address.Id:   {customerDTO?.Address?.Id}");
      Console.WriteLine($"Customer Address.Zip:  {customerDTO?.Address?.Zip}");
    }
  }
}
