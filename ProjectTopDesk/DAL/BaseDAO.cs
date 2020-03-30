using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace ProjectTopDesk.DAL
{
    abstract class BaseDAO
    {
        protected IMongoDatabase database;

        //connection setup
        public BaseDAO()
        {
            MongoClient dbClient = new MongoClient("mongodb+srv://mongoAdmin:iljWUuoRi40fFFcE@clusterprojecttopdesk-kcnv7.azure.mongodb.net/test?retryWrites=true&w=majority");
            this.database = dbClient.GetDatabase("TopDesk");
        }


    }
}
