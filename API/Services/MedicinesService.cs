using GlucoseControl.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace GlucoseControl.Services;

public class MedicinesService
{
    private readonly IMongoCollection<Medicine> _medicinesCollection;

    public MedicinesService(
        IOptions<GlucoseControlDatabaseSettings> glucoseControlDatabaseSettings)
    {
        var mongoClient = new MongoClient(
            glucoseControlDatabaseSettings.Value.ConnectionString);

        var mongoDatabase = mongoClient.GetDatabase(
            glucoseControlDatabaseSettings.Value.DatabaseName);

        _medicinesCollection = mongoDatabase.GetCollection<Medicine>(
            glucoseControlDatabaseSettings.Value.MedicinesCollectionName);
    }

    public async Task<List<Medicine>> GetAsync()
    {
        return await _medicinesCollection.Find(_ => true).ToListAsync();
    }

    public async Task<Medicine?> GetAsync(string id)
    {
        return await _medicinesCollection.Find(x => x.Id == id).FirstOrDefaultAsync();
    }

    public async Task<Medicine> CreateAsync(Medicine newMedicine)
    {
        await _medicinesCollection.InsertOneAsync(newMedicine);
        return newMedicine;
    }

    public async Task<Medicine> UpdateAsync(string id, Medicine updatedMedicine)
    {
        await _medicinesCollection.ReplaceOneAsync(x => x.Id == id, updatedMedicine);
        return updatedMedicine;
    }

    public async Task RemoveAsync(string id) =>
        await _medicinesCollection.DeleteOneAsync(x => x.Id == id);
}