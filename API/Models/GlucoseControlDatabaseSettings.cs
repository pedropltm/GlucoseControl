namespace GlucoseControl.Models;

public class GlucoseControlDatabaseSettings
{
    public string ConnectionString { get; set; } = null!;

    public string DatabaseName { get; set; } = null!;

    public string MealsCollectionName { get; set; } = null!;
    public string MedicinesCollectionName { get; set; } = null!;
}