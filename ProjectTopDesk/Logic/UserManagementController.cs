using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectTopDesk.Model;
using ProjectTopDesk.DAL;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;


namespace ProjectTopDesk.Logic
{
    class UserManagementController
    {
        userDAO user_db = new userDAO();

        public List<User> GetUsers()
        {
            return user_db.Db_Get_All_Users();
        }

        //public User GetLoggedInUser(string searchValue)
        //{
        //    return user_db.GetUser(searchValue); 
        //}
        //public User GetLoggedInUser(string searchValue)
        //{  
        //    User user = new User();
        //    BsonDocument userDocument = new BsonDocument();

        //    userDocument = user_db.GetUser(searchValue);

        //    user.firstName = userDocument.GetValue("firstName").ToString();
        //    user.lastName = userDocument.GetValue("lastName").ToString();
        //    user.type = userDocument.GetValue("userType").ToString();
        //    user.email = userDocument.GetValue("email").ToString();
        //    user.phoneNumber = int.Parse(userDocument.GetValue("phone").ToString());
        //    user.location = (Location)userDocument.GetValue("location");
        //    user.password = userDocument.GetValue("password").ToString();

        //    return user;
        //}

        public void UpdateUser(string searchValue, User user)
        {
            user_db.UpdateUser(searchValue, user);
        }

        public User CheckEmailAndPassword(string Email, string Password)
        {
            User user = user_db.GetUser(Email);
            if (user != null)
            {
                if (user.email == Email && user.password/*.ToLower()*/ == Password/*.ToLower()*/)
                {
                    return user;
                }

            }
            return null;
        }
    }
}
