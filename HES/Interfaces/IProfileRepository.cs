using HES;
public interface IProfileRepository
{
     Task<List<Profile>> GetAllProfiles();
    Task<Profile> CreateProfile(Profile profile);
    Task<Profile> GetProfileByPhoneNumber(string phoneNumber);
    Task<Profile> UpdateProfileByID(int ID);
     Task<Profile> DeleteProfile(int ID);

     //ekleme yapılacak



}