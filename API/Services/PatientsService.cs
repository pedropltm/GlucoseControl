using GlucoseControl.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace GlucoseControl.Services;

public class PatientsService
{
    private readonly IMongoCollection<Patient> _patientsCollection;

    public PatientsService(
        IOptions<GlucoseControlDatabaseSettings> glucoseControlDatabaseSettings)
    {
        var mongoClient = new MongoClient(
            glucoseControlDatabaseSettings.Value.ConnectionString);

        var mongoDatabase = mongoClient.GetDatabase(
            glucoseControlDatabaseSettings.Value.DatabaseName);

        _patientsCollection = mongoDatabase.GetCollection<Patient>(
            glucoseControlDatabaseSettings.Value.PatientsCollectionName);
    }

    public async Task<List<Patient>> GetAsync()
    {
        return await _patientsCollection.Find(_ => true).ToListAsync();
    }

    public async Task<Patient?> GetAsync(string id)
    {
        return await _patientsCollection.Find(x => x.Id == id).FirstOrDefaultAsync();
    }

    public async Task<Patient> CreateAsync(Patient newPatient)
    {
        await _patientsCollection.InsertOneAsync(newPatient);
        return newPatient;
    }

    public async Task<Patient> UpdateAsync(string id, Patient updatedPatient)
    {
        await _patientsCollection.ReplaceOneAsync(x => x.Id == id, updatedPatient);
        return updatedPatient;
    }

    public async Task RemoveAsync(string id) =>
        await _patientsCollection.DeleteOneAsync(x => x.Id == id);
}