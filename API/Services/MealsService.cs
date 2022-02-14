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

    public async Task<List<Meal>> GetAsync()
    {
        return await _mealsCollection.Find(_ => true).ToListAsync();
    }

    public async Task<Meal?> GetAsync(string id)
    {
        return await _mealsCollection.Find(x => x.Id == id).FirstOrDefaultAsync();
    }

    public async Task<Meal> CreateAsync(Meal newMeal)
    {
        await _mealsCollection.InsertOneAsync(newMeal);
        return newMeal;
    }

    public async Task<Meal> UpdateAsync(string id, Meal updatedMeal)
    {
        await _mealsCollection.ReplaceOneAsync(x => x.Id == id, updatedMeal);
        return updatedMeal;
    }

    public async Task RemoveAsync(string id) =>
        await _mealsCollection.DeleteOneAsync(x => x.Id == id);
}