using System;

namespace AutoMapperFlattening.Models
{
  public class CustomerModel
  {
    private Guid _addressId;
    public Guid id { get; set; }

    public Guid address_id
    {
      get
      {
        Console.WriteLine("GEt CustomerModel.address_id");
        return _addressId;
      }
      set => _addressId = value;
    }

    public AddressModel address { get; set; }

    public string name { get; set; }

    // [..]
  }
}
