using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using HES;

[ApiController]
[Route("[controller]")]
public class ProfileController : ControllerBase         
{
    private readonly IProfileService _profileService;

    public ProfileController(IProfileService profileService)
    {
        _profileService=profileService;
    }

    [HttpGet("GetAll")]
    public async Task<List<Profile>> GetAllProfiles()
    {
       var allProfiles= await _profileService.GetAllProfiles();  
       return allProfiles;
    }
    
    [HttpGet("GetByPhoneNumber")]
    public async Task<Profile> GetProfileByPhoneNumber(string phoneNumber)
    {
        var result = await _profileService.GetProfileByPhoneNumber(phoneNumber);
        return result;
    }
    [HttpPost("CreateNewProfile")]
    public async Task<Profile> CreatePNewrofile(Profile profile)
    {
        await _profileService.CreateNewProfile(profile);
        return profile;
    }
    [HttpDelete("DeleteProfile")]
    public async Task DeleteProfile (Profile profile)
    {
        await _profileService.DeleteProfile(profile);
    }
    [HttpPut("UpdateProfileByPhoneNumber")]
    public async Task<Profile> UpdateProfileByPhoneNumber(Profile profile)
    {
        var result = await _profileService.UpdateProfileByPhoneNumber(profile); 
        return result;   
    }
}