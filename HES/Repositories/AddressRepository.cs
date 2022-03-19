using HES;
using Microsoft.EntityFrameworkCore;
public class AddressRepository : IAddressRepository
{
    private readonly HESContext _context;
    public AddressRepository(HESContext context)
    {
        _context = context;
    }
    public AddressRepository()
    {

    }

  

    public async Task<Address> DeleteAddress(int id)
    {
        var findedAddress= await _context.Addresses.FindAsync(id);  //address.id ye çevrilecek
         _context.Remove(findedAddress);
         _context.SaveChanges();
        return findedAddress;
    }


  

    public async Task<Address> GetAddressByID(int id)   //address.id liye çevirilip bakılacak
    {
        return  await _context.Addresses.FindAsync(id);
    }

    public async Task<List<Address>> GetAllAddress()
    {
        return await _context.Addresses.ToListAsync();
        }

   

    public async Task<Address> CreateAddress(Address address)
    {
        try
        {
            await _context.Set<Address>().AddAsync(address);
            await _context.SaveChangesAsync();
            return address;
        }
        catch (Exception e)
        {
            return null;

        }
    }

    public async Task<Address> UpdateAddress(int id)
    {
        var findedAddress= await _context.Addresses.FindAsync(id);//address.id li yapmalıyız bence
         _context.Addresses.Update(findedAddress);
         _context.SaveChanges();
        return findedAddress;
    }

   

  

    public async Task<List<Address>> GetAllAddresses()
    {
        return await _context.Addresses.ToListAsync();
    }

    public async Task<Address> GetAddressByProfileID(int id)
    {
        var existedAddress= await _context.Set<Address>().FindAsync(id);//Where(x=>x.profile.Id==id);
        if(existedAddress!=null)
        {
            return existedAddress;
        }
        else
        {
            return null;
        }
    }

}