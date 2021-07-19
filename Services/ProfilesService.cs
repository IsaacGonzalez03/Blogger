using System.Collections.Generic;
using Blogger.Data;
using Blogger.Models;

namespace Blogger.Services
{
  public class ProfilesService
  {
    private readonly ProfilesRepository _profilesRepo;
    public ProfilesService(ProfilesRepository profilesRepo)
    {
      _profilesRepo = profilesRepo;
    }
    public List<Profile> GetAll()
    {
      return _profilesRepo.GetAll();
    }
    public Profile GetById(string id)
    {
      return _profilesRepo.GetById(id);
    }
  }
}