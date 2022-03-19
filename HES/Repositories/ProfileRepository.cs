using HES;
using Microsoft.EntityFrameworkCore;

public class ProfileRepository : IProfileRepository
{


    private readonly HESContext _context;
    public ProfileRepository(HESContext context)
    {
        _context = context;
    }
    public ProfileRepository()
    {

    }
    public async Task<Profile> CreateProfile(Profile profile)
    {
        try
        {
            await _context.Set<Profile>().AddAsync(profile);
            await _context.SaveChangesAsync();
            return profile;
        }
        catch (Exception e)
        {
            return null;

        }
    }

    public async Task<Profile> DeleteProfile(int ID)
    {
         try
        {
            var findedProfile=await _context.Set<Profile>().FirstOrDefaultAsync(f=>f.Id==ID);
            _context.Profiles.Remove(findedProfile);
            await _context.SaveChangesAsync();
            return findedProfile;
        }
        catch (Exception e)
        {
            return null;

        }
    }

    public async Task<List<Profile>> GetAllProfiles()
    { try{
return  await _context.Set<Profile>().ToListAsync();
    }
    catch(Exception e)
    {
        return null;
    }
       
    }

    public async Task<Profile> GetProfileByPhoneNumber(string phoneNumber)
    {
         try
        {
            return  await _context.Set<Profile>().FirstOrDefaultAsync(f=>f.PhoneNumber==phoneNumber);
           
        }
        catch (Exception e)
        {
            return null;

        }
    }

    public async Task<Profile> UpdateProfileByID(int ID)
    {
       /*  try
        {
            var findedProfile= await _context.Set<Profile>().FirstOrDefaultAsync(f=>f.ID==ID);
            findedProfile.HESCode=profile.HESCode;
            findedProfile.PhoneNumber=profile.PhoneNumber;
            findedProfile.FirstName=profile.FirstName;
            findedProfile.LastName=profile.LastName;
            findedProfile.BirtDay=profile.BirtDay;
            findedProfile.IsSick=profile.IsSick;
            findedProfile.gender=profile.gender;
            findedProfile.Adress=profile.Adress;
            await _context.SaveChangesAsync();
            return findedProfile;
           
        }
        catch (Exception e)
        {
            return null;

        }*/
        var findedProfile=await _context.Set<Profile>().FirstOrDefaultAsync(f=>f.Id==ID);
         _context.Profiles.Update(findedProfile);
        return findedProfile;
    }
}