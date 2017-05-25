using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using KegbotDotNetCore.API.Models;
using MongoDB.Driver;

namespace KegbotDotNetCore.API.Repositories.MongoDB
{
    public class BaseMongoDBRepository 
    {
        internal IMongoClient _client;
        protected IMongoDatabase _db;
        public BaseMongoDBRepository() 
        {
            string connectionString = @"mongodb://kegbot-dotnetcore:vCd3SimxJl5bI6r0YBPYFnYa7OSrEFWsExs06H890I2SEXIVs0Ug3fCj3iaMdzcBNY7trJ2q2awdjOmERmuo0Q==@kegbot-dotnetcore.documents.azure.com:10255/?ssl=true&replicaSet=globaldb";
            MongoClientSettings settings = MongoClientSettings.FromUrl(new MongoUrl(connectionString));
            settings.SslSettings = new SslSettings() { EnabledSslProtocols = SslProtocols.Tls12 };
            _client = new MongoClient(settings);
            _db = _client.GetDatabase("keggy");
        }

        internal IMongoCollection<Tap> Taps
        {
            get
            {
                return _db.GetCollection<Tap>("Taps");
            }
        }
        internal IMongoCollection<Keg> Kegs
        {
            get
            {
                return _db.GetCollection<Keg>("Kegs");
            }
        }
        internal IMongoCollection<KegSize> KegSizes
        {
            get
            {
                return _db.GetCollection<KegSize>("KegSizes");
            }
        }
        internal IMongoCollection<Beer> Beers
        {
            get
            {
                return _db.GetCollection<Beer>("Beers");
            }
        }
        internal IMongoCollection<Brewery> Breweries
        {
            get
            {
                return _db.GetCollection<Brewery>("Breweries");
            }
        }
        private IMongoCollection<PourEvent> PourEvents
        {
            get
            {
                return _db.GetCollection<PourEvent>("PourEvents");
            }
        }
        #region Beer - Attach Entities
        internal IEnumerable<Beer> AttachEntities(IEnumerable<Beer> beerList) {
            //Load Breweries
            var breweryIdsToLoad = beerList.Select(b => b.breweryId).Distinct().ToList();
            var breweries = Breweries.Find(b => breweryIdsToLoad.Contains(b.id)).ToList();

            beerList.ToList().ForEach(b => {
                if(b.breweryId != null) 
                {
                    b.brewery = breweries.FirstOrDefault(br => br.id == b.breweryId);
                }
            });
            return beerList;
        }

        internal Beer AttachEntities(Beer beerItem) {
            if (beerItem != null && beerItem.breweryId != null) {
                var brewery = Breweries.Find(b => b.id == beerItem.breweryId).FirstOrDefault();
                beerItem.brewery = brewery;
            }
            return beerItem;
        }
        #endregion
        #region Keg - Attach Entites
        internal IEnumerable<Keg> AttachEntities(IEnumerable<Keg> kegList) {
            //Load KegSizes
            var kegSizeIdsToLoad = kegList.Select(k => k.kegSizeId).Distinct().ToList();
            var kegSizes = KegSizes.Find(ks => kegSizeIdsToLoad.Contains(ks.id)).ToList();
            //Load Beers
            var beerIdsToLoad = kegList.Select(k => k.beerId).Distinct().ToList();
            var beers = Beers.Find(b => beerIdsToLoad.Contains(b.id)).ToList();
            beers = AttachEntities(beers).ToList();

            kegList.ToList().ForEach(k => {
                if(k.beerId != null)
                {
                    var beer = beers.FirstOrDefault(b => b.id == k.beerId);
                    k.beer = beer;
                }
                if(k.kegSizeId != null) {
                    k.kegSize = kegSizes.FirstOrDefault(ks => ks.id == k.kegSizeId);
                }
            });
            return kegList;
        }

        internal Keg AttachEntities(Keg kegItem) {
            if (kegItem != null && kegItem.kegSizeId != null) {
                var kegSize = KegSizes.Find(ks => ks.id == kegItem.kegSizeId).FirstOrDefault();
                kegItem.kegSize = kegSize;
            }
            if (kegItem != null && kegItem.beerId != null) {
                var beer = Beers.Find(b => b.id == kegItem.beerId).FirstOrDefault();
                beer = AttachEntities(beer);
                kegItem.beer = beer;
            }
            return kegItem;
        }
        #endregion
        #region PourEvent - Attach Entities
        internal IEnumerable<PourEvent> AttachEntities(IEnumerable<PourEvent> pourEventList) {
            //Load Kegs
            var kegIdsToLoad = pourEventList.Select(p => p.kegId).Distinct().ToList();
            var kegs = Kegs.Find(k => kegIdsToLoad.Contains(k.id)).ToList();
            kegs = AttachEntities(kegs).ToList();
            //Load Taps
            var tapIdsToLoad = pourEventList.Select(p => p.tapId).Distinct().ToList();
            var taps = Taps.Find(t => tapIdsToLoad.Contains(t.id)).ToList();
            taps = AttachEntities(taps).ToList();

            pourEventList.ToList().ForEach(p => {
                if (p.kegId != null) {
                    p.keg = kegs.FirstOrDefault(k => k.id == p.kegId);
                }
                if (p.tapId != null) {
                    p.tap = taps.FirstOrDefault(t => t.id == p.tapId);
                }
            });
            return pourEventList;
        }

        internal PourEvent AttachEntities(PourEvent pourEventItem) {
            if (pourEventItem != null && pourEventItem.kegId != null) {
                var keg = Kegs.Find(k => k.id == pourEventItem.kegId).FirstOrDefault();
                keg = AttachEntities(keg);
                pourEventItem.keg = keg;
            }
            if (pourEventItem != null && pourEventItem.tapId != null) {
                var tap = Taps.Find(t => t.id == pourEventItem.tapId).FirstOrDefault();
                tap = AttachEntities(tap);
                pourEventItem.tap = tap;
            }
            return pourEventItem;
        }
        #endregion
        #region Tap - Attach Entities
        internal IEnumerable<Tap> AttachEntities(IEnumerable<Tap> tapList) {
            //Load Kegs
            var kegIdsToLoad = tapList.Select(t => t.current_keg_id).Distinct().ToList();
            var kegs = Kegs.Find(k => kegIdsToLoad.Contains(k.id)).ToList();
            kegs = AttachEntities(kegs).ToList();

            tapList.ToList().ForEach(t => {
                if(t.current_keg_id != null) {
                    var current_keg = kegs.FirstOrDefault(k => k.id == t.current_keg_id);
                    t.current_keg = current_keg;
                }
            });
            return tapList;
        }

        internal Tap AttachEntities(Tap tapItem) {
            if (tapItem != null && tapItem.current_keg_id != null) {
                var keg = Kegs.Find(k => k.id == tapItem.current_keg_id).FirstOrDefault();
                keg = AttachEntities(keg);
                tapItem.current_keg = keg;
            }
            return tapItem;
        }
        #endregion
    }
}