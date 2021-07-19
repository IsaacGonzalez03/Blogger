using System.Collections.Generic;
using System.Data;
using System.Linq;
using Blogger.Models;
using Dapper;

namespace Blogger.Data
{
  public class ProfilesRepository
  {
    private readonly IDbConnection _db;
    public ProfilesRepository(IDbConnection db)
    {
      _db = db;
    }
    public List<Profile> GetAll()
    {
      var sql = "SELECT * FROM profiles";
      return _db.Query<Profile>(sql).ToList();
    }
    public Profile GetById(string Id)
    {
      string sql = "SELECT * FROM Profiles WHERE id = @Id";
      return _db.QueryFirstOrDefault<Profile>(sql, new { Id });
    }
    // public Profile Create(Profile newProfile)
    // {
    //   string sql = @"
    //   INSERT INTO profiles
    //   (id, name, email, picture)
    //   VALUES
    //   (@Id, @Name, @Email, @Picture)";
    //   _db.Execute(sql, newProfile);
    //   return newProfile;
    // }
    public Profile Edit(Profile updatedProf)
    {
      string sql = @"
      UPDATE Profiles
      SET
      name = @Name
      picture = @Picture
      WHERE id = @id
      ";
      _db.Execute(sql, updatedProf);
      return updatedProf;
    }
  }
}