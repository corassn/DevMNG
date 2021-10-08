using DevMNG.Entities;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevMNG.Repositories
{
    public class UserRepository
    {
        private readonly IMongoCollection<User> _users;

        public UserRepository(IDevMNGDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _users = database.GetCollection<User>(settings.UsersCollectionName);
        }

        //get all users
        public List<User> Get() =>
            _users.Find(user => true).ToList();

        //get users by ID
        public User Get(string id) =>
            _users.Find<User>(user => user.Id == id).FirstOrDefault();

        //CREATE user
        public User Create(User user)
        {
            _users.InsertOne(user);
            return user;
        }

        //UPDATE user
        public void Update(string id, User userIn) =>
            _users.ReplaceOne(user => user.Id == id, userIn);

        //DELETE user
        public void Remove(string id) =>
            _users.DeleteOne(user => user.Id == id);
    }
}
