using Application.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Services
{
    public class BuildingService : IBuildingService
    {
        public List<Building> GetBuildings()
            => new()
            {
                new() {Id= 1,Name="Poc", Height=10,Width=10,CreateTime=DateTime.UtcNow}
            };
    }
}
