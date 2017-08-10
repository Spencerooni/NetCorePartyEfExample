﻿using PartyData.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PartyData.Repositories
{
    public interface IPartyRespository
    {
        Task<List<Party>> GetPartiesWithRegistrations();

        Task<List<CustomService>> GetCustomServices();

        Task AddOrganisation(Organisation organisation);

        Task AddPerson(Person person);

        Task RegisterPartyWithService(int partyId, int customServiceId);
    }
}