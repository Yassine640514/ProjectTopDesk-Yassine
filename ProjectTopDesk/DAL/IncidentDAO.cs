using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace ProjectTopDesk.DAL
{
    class incidentDAO : BaseDAO
    {
        public incidentDAO() : base()
        {
            this.database = base.database;
        }

        public void getIncidents()
        {
            var incidentsCollection = database.GetCollection<BsonDocument>("Incidents");

            var incidentDocuments = incidentsCollection.Find(new BsonDocument()).ToList();
        }

        public int getAmountUnresolvedIncidents()
        {
            var incidentsCollection = database.GetCollection<BsonDocument>("Incidents");

            var filter = Builders<BsonDocument>.Filter.Eq("Resolved", false);
            var count = incidentsCollection.Find(filter).CountDocuments();

            int amountUnresolved = Convert.ToInt32(count);

            return amountUnresolved;
        }

        public int getAmountTotalIncidents()
        {
            var incidentsCollection = database.GetCollection<BsonDocument>("Incidents");

            var count = incidentsCollection.Find(new BsonDocument()).CountDocuments();

            int totalIncidents = Convert.ToInt32(count);

            return totalIncidents;
        }

        public int getAmountLateIncidents()
        {
            var incidentsCollection = database.GetCollection<BsonDocument>("Incidents");

            var filter = Builders<BsonDocument>.Filter.Gt("Deadline", DateTime.Now);
            var count = incidentsCollection.Find(filter).CountDocuments();

            int lateIncidents = Convert.ToInt32(count);

            return lateIncidents;
        }
    }
}
