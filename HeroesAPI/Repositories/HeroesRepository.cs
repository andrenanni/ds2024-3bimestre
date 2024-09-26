using HeroesAPI.Collections;
using MongoDB.Driver;

namespace HeroesAPI.Repositories;

public class HeroesRepository : IHeroesRepository
{
    private readonly IMongoCollection<Heroes> _collection;
    public HeroesRepository(IMongoDatabase mongoDatabase)
    {
        _collection = mongoDatabase.GetCollection<Heroes>("heroes");
    }

    public async Task CreateAsync(Heroes heroes) =>
        await _collection.InsertOneAsync(heroes);

    public async Task DeleteAsync(string id) =>
        await _collection.DeleteOneAsync(h => h.Id == id);

    public async Task<List<Heroes>> GetHeroesAsync() =>
        await _collection.Find(h => true).ToListAsync();

    public async Task<Heroes> GetByIdAsync(string id) =>
        await _collection.Find(h => h.Id == id).FirstOrDefaultAsync();

    public async Task UpdateAsync(Heroes heroes) =>
        await _collection.ReplaceOneAsync(h => h.Id == heroes.Id, heroes);
}