public class AddressService : IAddressService
{
     private IAddressRepository _addressRepository;

    public AddressService(IAddressRepository addressRepository)
    {
        _addressRepository = addressRepository;
    }



    public async Task<Address> DeleteAddress(int id)
    {
        var existedAddress = await _addressRepository.GetAddressByID(id);
        if (existedAddress != null)
        {
            return await _addressRepository.DeleteAddress(id);
        }
        else
        {
            throw new Exception();
        }
    }

   

  

    public async Task<Address> GetAddressByID(int id)
    {
        
        if (id != null)
        {
            return await _addressRepository.GetAddressByID(id);
        }
        else
        {
            return null;
        }
    }

    public async Task<List<Address>> GetAllAddresses()
    {
        return await _addressRepository.GetAllAddresses();
    }

    



   

    public async Task<Address> CreateAddress(Address address)
    {
        return await _addressRepository.CreateAddress(address); 
    }

    public async Task<Address> UpdateAddress(int id)
    {
      return await _addressRepository.UpdateAddress(id);


    }

    public async Task<Address> GetAddressByProfileID(int id)
    {
        if(id!=null)
        {
            return await _addressRepository.GetAddressByID(id);
        }
        else
        {
            return null;
        }
    }
}