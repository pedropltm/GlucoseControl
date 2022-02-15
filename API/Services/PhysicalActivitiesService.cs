using GlucoseControl.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace GlucoseControl.Services;

public class PhysicalActivitiesService
{
    private readonly IMongoCollection<PhysicalActivity> _physicalActivitiesCollection;

    public PhysicalActivitiesService(
        IOptions<GlucoseControlDatabaseSettings> glucoseControlDatabaseSettings)
    {
        var mongoClient = new MongoClient(
            glucoseControlDatabaseSettings.Value.ConnectionString);

        var mongoDatabase = mongoClient.GetDatabase(
            glucoseControlDatabaseSettings.Value.DatabaseName);

        _physicalActivitiesCollection = mongoDatabase.GetCollection<PhysicalActivity>(
            glucoseControlDatabaseSettings.Value.PhysicalActivitiesCollectionName);
    }

    public async Task<List<PhysicalActivity>> GetAsync()
    {
        return await _physicalActivitiesCollection.Find(_ => true).ToListAsync();
    }

    public async Task<PhysicalActivity?> GetAsync(string id)
    {
        return await _physicalActivitiesCollection.Find(x => x.Id == id).FirstOrDefaultAsync();
    }

    public async Task<PhysicalActivity> CreateAsync(PhysicalActivity newPhysicalActivity)
    {
        await _physicalActivitiesCollection.InsertOneAsync(newPhysicalActivity);
        return newPhysicalActivity;
    }

    public async Task<PhysicalActivity> UpdateAsync(string id, PhysicalActivity updatedPhysicalActivity)
    {
        await _physicalActivitiesCollection.ReplaceOneAsync(x => x.Id == id, updatedPhysicalActivity);
        return updatedPhysicalActivity;
    }

    public async Task RemoveAsync(string id) =>
        await _physicalActivitiesCollection.DeleteOneAsync(x => x.Id == id);
}