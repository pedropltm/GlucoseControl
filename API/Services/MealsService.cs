using GlucoseControl.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace GlucoseControl.Services;

public class MealsService
{
    private readonly IMongoCollection<Meal> _mealsCollection;

    public MealsService(
        IOptions<GlucoseControlDatabaseSettings> glucoseControlDatabaseSettings)
    {
        var mongoClient = new MongoClient(
            glucoseControlDatabaseSettings.Value.ConnectionString);

        var mongoDatabase = mongoClient.GetDatabase(
            glucoseControlDatabaseSettings.Value.DatabaseName);

        _mealsCollection = mongoDatabase.GetCollection<Meal>(
            glucoseControlDatabaseSettings.Value.MealsCollectionName);
    }

    public async Task<List<Meal>> GetAsync() =>
        await _mealsCollection.Find(_ => true).ToListAsync();

    public async Task<Meal?> GetAsync(long id) =>
        await _mealsCollection.Find(x => x.Id == id).FirstOrDefaultAsync();

    public async Task CreateAsync(Meal newMeal) =>
        await _mealsCollection.InsertOneAsync(newMeal);

    public async Task UpdateAsync(long id, Meal updatedMeal) =>
        await _mealsCollection.ReplaceOneAsync(x => x.Id == id, updatedMeal);

    public async Task RemoveAsync(long id) =>
        await _mealsCollection.DeleteOneAsync(x => x.Id == id);
}