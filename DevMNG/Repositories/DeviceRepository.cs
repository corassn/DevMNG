using DevMNG.Entities;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevMNG.Repositories
{
    public class DeviceRepository
    {
        private readonly IMongoCollection<Device> _devices;

        public DeviceRepository(IDevMNGDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _devices = database.GetCollection<Device>(settings.DevicesCollectionName);
        }

        public List<Device> GetAll() =>
            _devices.Find(device => true).ToList();

        public Device GetById(string id) =>
            _devices.Find<Device>(device => device.Id == id).FirstOrDefault();

        public Device Create(Device device)
        {
            _devices.InsertOne(device);
            return device;
        }

        public void Update(string id, Device deviceIn) =>
            _devices.ReplaceOne(device => device.Id == id, deviceIn);

        public void Remove(string id) =>
            _devices.DeleteOne(device => device.Id == id);

    }
}
