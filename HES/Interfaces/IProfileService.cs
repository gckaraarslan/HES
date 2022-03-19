using HES;
public interface IProfileService
{
     Task<List<Profile>> GetAllProfiles();
     Task<Profile> GetProfileByPhoneNumber(string phoneNumber);
     Task<Profile> CreateNewProfile(Profile profile);
     Task<Profile> DeleteProfile(Profile profile);
     Task<Profile> UpdateProfileByPhoneNumber(Profile profile);  //profile.phoneNumber yaptım metodun içine, böyle çalışıyor diye hatırlıyorum
}