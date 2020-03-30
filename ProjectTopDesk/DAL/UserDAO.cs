using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using ProjectTopDesk.Model;

namespace ProjectTopDesk.DAL
{
    class userDAO : BaseDAO
    {
        IMongoCollection<BsonDocument> usersCollection;

        public userDAO() : base()
        {
            this.database = base.database;
            this.usersCollection = database.GetCollection<BsonDocument>("Users");
        }
        public List<User> Db_Get_All_Users()
        {
            var userDocuments = usersCollection.Find(new BsonDocument()).ToList();

            List<User> userList = new List<User>();

            foreach (BsonDocument doc in userDocuments)
            {
                User user = new User()
                {
                    firstName = doc.GetValue("firstName").ToString(),
                    lastName = doc.GetValue("lastName").ToString(),
                    type = (UserType)int.Parse(doc.GetValue("userType").ToString()),
                    email = doc.GetValue("email").ToString(),
                    phoneNumber = doc.GetValue("phone").ToString(),
                    location = (Location)int.Parse(doc.GetValue("location").ToString()),
                    password = doc.GetValue("password").ToString(),
                };
                userList.Add(user);
            }
            return userList;
        }

        /*public List<BsonDocument> GetUsers()
        {
            var userDocuments = usersCollection.Find(new BsonDocument()).ToList();
            
            return userDocuments;

            
             * GEBRUIK DIT IN LOGIC LAAG OM NAAR LIST VAN USERS OM TE ZETTEN
             * 
             List<User> userList = new List<User>();

            foreach(BsonDocument doc in userDocuments)
            {
                User user = new User();

                user.firstName = doc.GetValue("firstName").ToString();
                user.lastName = doc.GetValue("lastName").ToString();
                user.type = doc.GetValue("userType").ToString();
                user.email = doc.GetValue("email").ToString();
                user.phoneNumber = int.Parse(doc.GetValue("email").ToString());
                user.location = doc.GetValue("location").ToString();
                user.password = doc.GetValue("password").ToString();

                userList.Add(user);

            }
             
        }*/

        public User GetUser(string searchValue)
        {
            User user = new User();
            try
            {
                //var filter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(searchValue));
                var filter = Builders<BsonDocument>.Filter.Eq("email", searchValue);
                var userDocument = usersCollection.Find(filter).FirstOrDefault();

                user.firstName = userDocument.GetValue("firstName").ToString();
                user.lastName = userDocument.GetValue("lastName").ToString();
                user.type = (UserType)int.Parse(userDocument.GetValue("userType").ToString());
                user.email = userDocument.GetValue("email").ToString();
                user.phoneNumber = userDocument.GetValue("phone").ToString();
                user.location = (Location)int.Parse(userDocument.GetValue("location").ToString());
                user.password = userDocument.GetValue("password").ToString();
            }
            catch (Exception)
            {

            }
            
            return user;
        }

        public void UpdateUser(string searchValue, User user)
        {
            var updateFilter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(searchValue));

            var update = Builders<BsonDocument>.Update.Set("firstName", user.firstName).Set("lastName", user.lastName).Set("email", user.email).Set("phone", user.phoneNumber);

            usersCollection.UpdateOne(updateFilter, update);
        }

        public void DeleteUser(string searchValue)
        {
            var deleteFilter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(searchValue));

            usersCollection.DeleteOne(deleteFilter);
        }
    }
}
