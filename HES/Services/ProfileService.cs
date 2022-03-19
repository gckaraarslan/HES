using HES;

public class ProfileService : IProfileService
{
     private readonly IProfileRepository _profileRepository;

    public ProfileService(IProfileRepository profileRepository)
    {
        _profileRepository = profileRepository;
    }
    public async Task<Profile> CreateNewProfile(Profile profile)
    {
        return await _profileRepository.CreateProfile(profile);
    }

    public async Task<Profile> DeleteProfile(Profile profile)
    {
        var findedProfile= await _profileRepository.GetProfileByPhoneNumber(profile.PhoneNumber);
        await _profileRepository.DeleteProfile(profile.Id);
        return findedProfile;
    }

    public async Task<List<Profile>> GetAllProfiles()
    {
        return await _profileRepository.GetAllProfiles();
    }

    public async Task<Profile> GetProfileByPhoneNumber(string phoneNumber)
    {
       return await _profileRepository.GetProfileByPhoneNumber(phoneNumber);
    }

    public async Task<Profile> UpdateProfileByPhoneNumber(Profile profile)
    {
        var findedProfile= await _profileRepository.GetProfileByPhoneNumber(profile.PhoneNumber);
        await _profileRepository.UpdateProfileByID(profile.Id);
        return findedProfile;
    }
}