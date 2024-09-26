using HeroesAPI.Collections;

namespace HeroesAPI.Repositories;

public interface IHeroesRepository
{
    Task<List<Heroes>> GetAllAsync();
    Task<Heroes> GetByIdAsync(string id);
    Task CreateAsync(Heroes heroes);
    Task UpdateAsync(Heroes heroes);
    Task DeleteAsync(string id);
}
