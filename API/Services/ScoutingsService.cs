using GlucoseControl.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace GlucoseControl.Services;

public class ScoutingsService
{
    private readonly IMongoCollection<Scouting> _scoutingsCollection;


    public ScoutingsService(
        IOptions<GlucoseControlDatabaseSettings> glucoseControlDatabaseSettings)
    {
        var mongoClient = new MongoClient(
            glucoseControlDatabaseSettings.Value.ConnectionString);

        var mongoDatabase = mongoClient.GetDatabase(
            glucoseControlDatabaseSettings.Value.DatabaseName);

        _scoutingsCollection = mongoDatabase.GetCollection<Scouting>(
            glucoseControlDatabaseSettings.Value.ScoutingsCollectionName);
    }

    public async Task<List<Scouting>> GetAsync()
    {
        return await _scoutingsCollection.Find(_ => true).ToListAsync();
    }

    public async Task<Scouting?> GetAsync(string id)
    {
        return await _scoutingsCollection.Find(x => x.Id == id).FirstOrDefaultAsync();
    }

    public async Task<Scouting> CreateAsync(Scouting newScouting)
    {
        await _scoutingsCollection.InsertOneAsync(newScouting);
        return newScouting;
    }

    public async Task<Scouting> UpdateAsync(string id, Scouting updatedScouting)
    {
        await _scoutingsCollection.ReplaceOneAsync(x => x.Id == id, updatedScouting);
        return updatedScouting;
    }

    public async Task RemoveAsync(string id) =>
        await _scoutingsCollection.DeleteOneAsync(x => x.Id == id);
}