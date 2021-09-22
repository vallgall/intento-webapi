using intento1.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace intento1.Services
{
    public class BeerService
    {
        private IMongoCollection<Beer> _beers;

        public BeerService(IBarSettings settings)
        {
            var cliente = new MongoClient(settings.Server);
            var database = cliente.GetDatabase(settings.Database);
            _beers = database.GetCollection<Beer>(settings.Collection);
        }

        public List<Beer> Get()
        {
            return _beers.Find(d => true).ToList();
        }

        public Beer Create(Beer beer)
        {
            _beers.InsertOne(beer);
            return beer;
        }

        public void Update(string id, Beer beer)
        {
            _beers.ReplaceOne(beer => beer.Id == id, beer);
        }

        public void Delete(string id)
        {
            _beers.DeleteOne(d => d.Id == id);
        }
    }
}
