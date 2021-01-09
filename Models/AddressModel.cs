using System;

namespace AutoMapperFlattening.Models
{
    public class AddressModel
    {
        private Guid _id;

        public Guid id
        {
            get
            {
                Console.WriteLine("GET AddressModel.id");
                return _id;
            }
            set => _id = value;
        }

        public string zip { get; set; }

        // [..]
    }
}
