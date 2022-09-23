﻿using MatchDataManager.Application.Common.Interfaces.Persistence;
using MatchDataManager.Domain.Entities;

namespace MatchDataManager.Infrastructure.Repositories;

public static class LocationsRepository
{
    private static readonly List<Location> _locations = new();

    internal static void Add(Location location)
    {
        _locations.Add(location);
    }

    public static bool GetLocationByName(string name)
    {
        var location = _locations.FirstOrDefault(x =>
            x.Name.Trim().ToLower() == name.Trim().ToLower());

        return location != null;
    }

    public static void DeleteLocation(Guid locationId)
    {
        var location = _locations.FirstOrDefault(x => x.Id == locationId);
        if (location is not null)
        {
            _locations.Remove(location);
        }
    }

    public static IEnumerable<Location> GetAllLocations()
    {
        return _locations;
    }

    public static Location GetLocationById(Guid id)
    {
        return _locations.FirstOrDefault(x => x.Id == id);
    }

    public static void UpdateLocation(Location location)
    {
        var existingLocation = _locations.FirstOrDefault(x => x.Id == location.Id);
        if (existingLocation is null || location is null)
        {
            throw new ArgumentException("Location doesn't exist.", nameof(location));
        }

        existingLocation.City = location.City;
        existingLocation.Name = location.Name;
    }
}