namespace AutoMapperFlattening.DTO
{
  public class CustomerDTO
  {
    public string Id { get; set; }

    public string AddressId { get; set; }

    public AddressDTO Address { get; set; }

    public string Name { get; set; }

    // [..]
  }
}
