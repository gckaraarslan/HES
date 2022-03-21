using System.Collections.Generic;

public interface IAddressRepository
{

     Task<List<Address>> GetAllAddresses();
    Task<Address> GetAddressByID(int id);
    Task<Address> GetAddressByProfileID(int id);
    Task<Address> CreateAddress(Address address);
    Task<Address> DeleteAddress(int id);
    Task<Address> UpdateAddress(int id);
    
}