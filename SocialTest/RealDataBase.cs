using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Social_Network
{
    class RealDataBase
    {
        private static string dbAddress = "Data Source=DataBase.sqlite; Version=3;";
        private SQLiteConnection dbConnection = new SQLiteConnection(dbAddress);

        private static RealDataBase instance = new RealDataBase();

        public static RealDataBase Instance { get { return instance; } }

        private RealDataBase()
        {
            if (File.Exists("DataBase.sqlite"))
            {
                dbConnection.Open();
            }
            else
            {
                CreateDB();
            }
        }

        private void CreateDB()
        {
            dbConnection.Open();

            string usersTable = "CREATE TABLE users (userName TEXT PRIMARY KEY NOT NULL, password TEXT NOT NULL,"
                + "firstName TEXT NOT NULL, lastName TEXT NOT NULL, email TEXT,"
                + "gender TEXT, favoriteGenre TEXT, permission INTEGER NOT NULL);";
            SQLiteCommand cmnd = new SQLiteCommand(usersTable, dbConnection);
            cmnd.ExecuteNonQuery();

            string postsTable = "CREATE TABLE posts ('idPost' INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT," +
                "'from' TEXT NOT NULL,'content' TEXT,'date' datetime NOT NULL,'like' INTEGER NOT NULL,'share' INTEGER NOT NULL,'priority' INTEGER NOT NULL)";
            cmnd = new SQLiteCommand(postsTable, dbConnection);
            cmnd.ExecuteNonQuery();

            string messagesTable = "CREATE TABLE messages ('messageID' INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT," +
                " 'to' TEXT NOT NULL,'from' TEXT NOT NULL,'title' TEXT,'content' TEXT,'date' datetime NOT NULL);";
            cmnd = new SQLiteCommand(messagesTable, dbConnection);
            cmnd.ExecuteNonQuery();

            string friendsTable = "CREATE TABLE friends ('id' INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,'user' TEXT NOT NULL,'friend' TEXT NOT NULL);";
            cmnd = new SQLiteCommand(friendsTable, dbConnection);
            cmnd.ExecuteNonQuery();

            string frienshipdRequestTable = "CREATE TABLE friendshipRequests ('id' INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,'SentFrom' TEXT NOT NULL,'SentTo' TEXT NOT NULL,'date' datetime NOT NULL);";
            cmnd = new SQLiteCommand(frienshipdRequestTable, dbConnection);
            cmnd.ExecuteNonQuery();

            string generalPlaylist = "CREATE TABLE General ('id' INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,'singer' TEXT NOT NULL,'song' TEXT NOT NULL,'genre' TEXT NOT NULL);";
            cmnd = new SQLiteCommand(generalPlaylist, dbConnection);
            cmnd.ExecuteNonQuery();

            FillUsersTable();
            FillPostsTable();
            FillMessagesTable();
            FillFriendsTable();
            FillFrienshipdRequest();
            FillPlaylists();
        }

        //===========================================================================
        //========================== User Queries ===================================
        //===========================================================================

        private void FillUsersTable()
        {
            // Admin
            List<AbstractUser> addToDB = new List<AbstractUser>();
            Admin admin = new Admin("Anael", "Shomrai", "ashomrai@gmail.com", "Female", "anael", "123456", "Chill_House");
            addToDB.Add(admin);
            admin = new Admin("Nadav", "Zalman", "nd.zalman@gmail.com", "Male", "nadav", "123456", "RockNRoll");
            addToDB.Add(admin);
            admin = new Admin("Idan", "Zalman", "idan@gmail.com", "Male", "idan", "123456", "Hip_Hop");
            addToDB.Add(admin);
            admin = new Admin("Naor", "Haguli", "naor@gmail.com", "Male", "naor", "123456", "Reggae");
            addToDB.Add(admin);

            // Standard User
            User user = new User("Eyal", "Levi", "Eyal_Levi@gmail.com", "Male", "eyal", "123456", "Chill_House");
            addToDB.Add(user);
            user = new User("Dana", "Cohen", "Dana_Cohen@gmail.com", "Female", "dana", "123456", "Pop");
            addToDB.Add(user);
            user = new User("Shir", "Shimer", "Shir_Shimer@gmail.com", "Female", "shir", "123456", "Reggae");
            addToDB.Add(user);

            // Premium User
            PremiumUser premiumUser = new PremiumUser("Rotem", "Alon", "Rotem_Alon@gmail.com", "Female", "rotem", "123456", "Pop");
            addToDB.Add(premiumUser);
            premiumUser = new PremiumUser("Yoni", "Granit", "Yoni_Granit@gmail.com", "Male", "yoni", "123456", "General");
            addToDB.Add(premiumUser);

            foreach (AbstractUser u in addToDB)
            {
                string addUser = "INSERT INTO users VALUES(@userName,@password,@firstName,@lastName,@email,@gender,@favoriteGenre,@permission);";
                SQLiteCommand cmd = new SQLiteCommand(addUser, dbConnection);
                cmd.Parameters.Add(new SQLiteParameter("@userName", u.UserName));
                cmd.Parameters.Add(new SQLiteParameter("@password", u.Password));
                cmd.Parameters.Add(new SQLiteParameter("@firstName", u.FirstName));
                cmd.Parameters.Add(new SQLiteParameter("@lastName", u.LastName));
                cmd.Parameters.Add(new SQLiteParameter("@email", u.Email));
                cmd.Parameters.Add(new SQLiteParameter("@gender", u.Gender));
                cmd.Parameters.Add(new SQLiteParameter("@favoriteGenre", u.FavoriteGenre));
                cmd.Parameters.Add(new SQLiteParameter("@permission", u.Permission));
                cmd.ExecuteNonQuery();
            }

        }

        public void AddUser(AbstractUser u)
        {
            string addUser = "INSERT INTO users VALUES(@userName,@password,@firstName,@lastName,@email,@gender,@favoriteGenre,@permission);";
            SQLiteCommand cmd = new SQLiteCommand(addUser, dbConnection);
            cmd.Parameters.Add(new SQLiteParameter("@userName", u.UserName));
            cmd.Parameters.Add(new SQLiteParameter("@password", u.Password));
            cmd.Parameters.Add(new SQLiteParameter("@firstName", u.FirstName));
            cmd.Parameters.Add(new SQLiteParameter("@lastName", u.LastName));
            cmd.Parameters.Add(new SQLiteParameter("@email", u.Email));
            cmd.Parameters.Add(new SQLiteParameter("@gender", u.Gender));
            cmd.Parameters.Add(new SQLiteParameter("@favoriteGenre", u.FavoriteGenre));
            cmd.Parameters.Add(new SQLiteParameter("@permission", u.Permission));
            cmd.ExecuteNonQuery();
        }

        public List<AbstractUser> GetUsers()
        {
            List<AbstractUser> users = new List<AbstractUser>();
            string sql = "SELECT * FROM users;";
            SQLiteCommand cmd = new SQLiteCommand(sql, dbConnection);
            SQLiteDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string userName = reader["userName"].ToString();
                string password = reader["password"].ToString();
                string firstName = reader["firstName"].ToString();
                string lastName = reader["lastName"].ToString();
                string email = reader["email"].ToString();
                string gender = reader["gender"].ToString();
                string favoriteGenre = reader["favoriteGenre"].ToString();
                int permission = Int32.Parse(reader["permission"].ToString());

                if (permission == 1) //means its an admin
                    users.Add(new Admin(firstName, lastName, email, gender, userName, password, favoriteGenre));
                else if (permission == 2) // means its premium user
                    users.Add(new PremiumUser(firstName, lastName, email, gender, userName, password, favoriteGenre));
                else
                    users.Add(new User(firstName, lastName, email, gender, userName, password, favoriteGenre));
            }
            return users;
        }

        public void RemoveUser(string userName)
        {
            string removeUser = "DELETE FROM users WHERE userName = '" + userName + "';";
            SQLiteCommand cmd = new SQLiteCommand(removeUser, dbConnection);
            cmd.ExecuteNonQuery();
        }

        //===========================================================================
        //========================== Messages Queries================================
        //===========================================================================

        private void FillMessagesTable()
        {
            List<Message> messages = new List<Message>();
            Message message = new Message("anael", "nadav", "Hello", "How are you?");
            messages.Add(message);
            message = new Message("nadav", "anael", "Good", "and you?");
            messages.Add(message);
            message = new Message("anael", "nadav", "Great!", "Lets here some music");
            messages.Add(message);
            message = new Message("anael", "eyal", "Hi anael", "Nice to meet you");
            messages.Add(message);

            foreach (Message m in messages)
            {
                string addMessage = "INSERT INTO messages ([from],[to],title,content,date) VALUES(@from,@to,@title,@content,@date);";
                SQLiteCommand cmd = new SQLiteCommand(addMessage, dbConnection);
                cmd.Parameters.Add(new SQLiteParameter("@from", m.From));
                cmd.Parameters.Add(new SQLiteParameter("@to", m.To));
                cmd.Parameters.Add(new SQLiteParameter("@title", m.Title));
                cmd.Parameters.Add(new SQLiteParameter("@content", m.Content));
                cmd.Parameters.Add(new SQLiteParameter("@date", m.Date));
                cmd.ExecuteNonQuery();
            }
        }

        public void AddMessage(Message m)
        {
            string addMessage = "INSERT INTO messages ([from],[to],title,content,date) VALUES(@from,@to,@title,@content,@date);";
            SQLiteCommand cmd = new SQLiteCommand(addMessage, dbConnection);
            cmd.Parameters.Add(new SQLiteParameter("@from", m.From));
            cmd.Parameters.Add(new SQLiteParameter("@to", m.To));
            cmd.Parameters.Add(new SQLiteParameter("@title", m.Title));
            cmd.Parameters.Add(new SQLiteParameter("@content", m.Content));
            cmd.Parameters.Add(new SQLiteParameter("@date", m.Date));
            cmd.ExecuteNonQuery();
        }

        public List<Message> GetMessages()
        {
            List<Message> messages = new List<Message>();
            string sql = "SELECT messageID,[to],[from],title,content,strftime([date],5) as [date] FROM messages;";
            SQLiteCommand cmd = new SQLiteCommand(sql, dbConnection);
            SQLiteDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int messageID = Int32.Parse(reader["messageID"].ToString());
                string to = reader["to"].ToString();
                string from = reader["from"].ToString();
                string title = reader["title"].ToString();
                string content = reader["content"].ToString();
                string d = reader["date"].ToString();
                DateTime date = Convert.ToDateTime(d);

                messages.Add(new Message(messageID, to, from, title, content, date));
                Message.CurrentCountOfMessages();
            }
            return messages;
        }

        public int GetMessagesCount()
        {
            string tableName = "messages";
            string sql = "SELECT seq from sqlite_sequence where name = '" + tableName + "';";
            SQLiteCommand cmd = new SQLiteCommand(sql, dbConnection);
            SQLiteDataReader reader = cmd.ExecuteReader();
            reader.Read();
            int count = Int32.Parse(reader["seq"].ToString());
            return count;
        }

        //===========================================================================
        //==========================Post Queries=====================================
        //===========================================================================

        private void FillPostsTable()
        {
            List<Post> addPosts = new List<Post>();
            Post post = new Post("Hello World", "anael", 1);
            addPosts.Add(post);
            post = new Post("Im regular user", "eyal", 3);
            addPosts.Add(post);
            post = new Post("Im premuium user", "rotem", 2);
            addPosts.Add(post);
            post = new Post("Im admin", "nadav", 1);
            addPosts.Add(post);
            post = new Post("How is everybody?", "dana", 3);
            addPosts.Add(post);
            foreach (Post p in addPosts)
            {
                string addPost = "INSERT INTO posts ([from],content,date,[like],share,priority) VALUES(@from,@content,@date,@like,@share,@priority);";
                SQLiteCommand cmd = new SQLiteCommand(addPost, dbConnection);
                cmd.Parameters.Add(new SQLiteParameter("@from", p.From));
                cmd.Parameters.Add(new SQLiteParameter("@content", p.Content));
                cmd.Parameters.Add(new SQLiteParameter("@date", p.Date));
                cmd.Parameters.Add(new SQLiteParameter("@like", p.Like));
                cmd.Parameters.Add(new SQLiteParameter("@share", p.Share));
                cmd.Parameters.Add(new SQLiteParameter("@priority", p.Priority));
                cmd.ExecuteNonQuery();

            }
        }

        public void EditPost(int idPost, DateTime date, string content)
        {
            string sql = "UPDATE posts " +
                      "SET date = '" + date + "'" +
                      ",content = (@content)" +
                      " WHERE idPost = '" + idPost + "'";
            SQLiteCommand command = new SQLiteCommand(sql, dbConnection);
            command.Parameters.Add(new SQLiteParameter("@content", content));
            command.ExecuteNonQuery();
        }

        public void AddLike(int idPost, int like)
        {
            string sql = "UPDATE posts " +
          "SET [like] = '" + (like + 1) + "'" +
          " WHERE idPost = '" + idPost + "'";
            SQLiteCommand command = new SQLiteCommand(sql, dbConnection);
            command.ExecuteNonQuery();
        }

        public void AddShare(int idPost, int share)
        {

            string sql = "UPDATE posts " +
          "SET share = '" + (share + 1) + "'" +
          " WHERE idPost = '" + idPost + "'";
            SQLiteCommand command = new SQLiteCommand(sql, dbConnection);
            command.ExecuteNonQuery();
        }

        public void UnlikePost(int idPost, int like)
        {
            string sql = "UPDATE posts " +
          "SET [like] = '" + (like - 1) + "'" +
          " WHERE idPost = '" + idPost + "'";
            SQLiteCommand command = new SQLiteCommand(sql, dbConnection);
            command.ExecuteNonQuery();
        }

        public void AddPost(Post p)
        {
            string addPost = "INSERT INTO posts VALUES(@idPost,@from,@content,@date,@like,@share,@priority);";
            SQLiteCommand cmd = new SQLiteCommand(addPost, dbConnection);
            cmd.Parameters.Add(new SQLiteParameter("@idPost", p.IdPost));
            cmd.Parameters.Add(new SQLiteParameter("@from", p.From));
            cmd.Parameters.Add(new SQLiteParameter("@content", p.Content));
            cmd.Parameters.Add(new SQLiteParameter("@date", p.Date));
            cmd.Parameters.Add(new SQLiteParameter("@like", p.Like));
            cmd.Parameters.Add(new SQLiteParameter("@share", p.Share));
            cmd.Parameters.Add(new SQLiteParameter("@priority", p.Priority));
            cmd.ExecuteNonQuery();

        }

        public void RemovePost(int idPost)
        {
            string removePost = "DELETE FROM posts WHERE idPost = '" + idPost + "';";
            SQLiteCommand cmd = new SQLiteCommand(removePost, dbConnection);
            cmd.ExecuteNonQuery();
        }

        public List<Post> GetPosts()
        {
            List<Post> posts = new List<Post>();
            string sql = "SELECT idPost,[from],content,strftime([date],2) as [date],[like],share,priority FROM posts;";
            SQLiteCommand cmd = new SQLiteCommand(sql, dbConnection);
            SQLiteDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int idPost = Int32.Parse(reader["idPost"].ToString());
                string from = reader["from"].ToString();
                string content = reader["content"].ToString();
                string d = reader["date"].ToString();
                DateTime date = Convert.ToDateTime(d);
                int like = Int32.Parse(reader["like"].ToString());
                int share = Int32.Parse(reader["share"].ToString());
                int priority = Int32.Parse(reader["priority"].ToString());

                posts.Add(new Post(idPost, content, from, priority, like, share, date));
            }
            Post.CurrentCountOfPosts();
            return posts;

        }

        public int GetPostsCount()
        {
            string tableName = "posts";
            string sql = "SELECT seq from sqlite_sequence where name = '" + tableName + "';";
            SQLiteCommand cmd = new SQLiteCommand(sql, dbConnection);
            SQLiteDataReader reader = cmd.ExecuteReader();
            reader.Read();
            int count = Int32.Parse(reader["seq"].ToString());
            return count;
        }

        //===========================================================================
        //==========================Playlist Queries=================================
        //===========================================================================

        private void FillPlaylists()
        {  
            List<Playlist> General = new List<Playlist>();

            Playlist p = new Playlist("The Betales", "Help", "Rock");
            General.Add(p);
            p = new Playlist("Queen", "Love Of My Life", "Pop");
            General.Add(p);
            p = new Playlist("Bob Marley", "I Shot The Sheriff", "Reggae");
            General.Add(p);
            p = new Playlist("Alt-J", "Breezblock", "General");
            General.Add(p);
            p = new Playlist("Beyonce", "Who runs the world", "Pop");
            General.Add(p);
            p = new Playlist("Metallica", "Nothing Else Matters", "Rock");
            General.Add(p);
            p = new Playlist("Twenty One Pilots", "Lane Boy", "Hip_Hop");
            General.Add(p);
            p = new Playlist("Faul & Wad Ad", "Changes", "Chill_House");
            General.Add(p);
            p = new Playlist("DNCE", "Cake By The Ocean", "Pop");
            General.Add(p);
            p = new Playlist("Coldplay", "Shiver", "Rock");
            General.Add(p);
            p = new Playlist("Bob Marely", "One Love", "Reggae");
            General.Add(p);
            p = new Playlist("Jimmy Cliff", "I Can See Clearly Now", "Reggae");
            General.Add(p);
            p = new Playlist("Elvis Presley", "Love Me Tender", "RockNRoll");
            General.Add(p);
            p = new Playlist("Rolling Stones", "Wild Horses", "Rock");
            General.Add(p);
            p = new Playlist("Jimi Hendrix", "Hey Joe", "RockNRoll");
            General.Add(p);
            p = new Playlist("Asaf Avidan", "One day / Reckoning Song (Wankelmut Remix)", "Chill_House");
            General.Add(p);


            foreach (Playlist g in General)
            {
                string addgeneral = "INSERT INTO General (singer,song,genre) VALUES(@singer,@song,@genre);";
                SQLiteCommand cmd = new SQLiteCommand(addgeneral, dbConnection);
                cmd.Parameters.Add(new SQLiteParameter("@singer", g.Singer));
                cmd.Parameters.Add(new SQLiteParameter("@song", g.Song));
                cmd.Parameters.Add(new SQLiteParameter("@genre", g.Genre));
                cmd.ExecuteNonQuery();
            }
        }

        public void AddToGeneralPlaylist(Playlist p)
        {
            string addgeneral = "INSERT INTO General (singer,song,genre) VALUES(@singer,@song,@genre);";
            SQLiteCommand cmd = new SQLiteCommand(addgeneral, dbConnection);
            cmd.Parameters.Add(new SQLiteParameter("@singer", p.Singer));
            cmd.Parameters.Add(new SQLiteParameter("@song", p.Song));
            cmd.Parameters.Add(new SQLiteParameter("@genre", p.Genre));
            cmd.ExecuteNonQuery();
        }

        public List<Playlist> GetGeneralPlaylist()
        {
            List<Playlist> General = new List<Playlist>();
            string sql = "SELECT * FROM General;";
            SQLiteCommand cmd = new SQLiteCommand(sql, dbConnection);
            SQLiteDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string singer = reader["singer"].ToString();
                string song = reader["song"].ToString();
                string genre = reader["genre"].ToString();

                General.Add(new Playlist(singer, song, genre));
            }
            return General;
        }

        //===========================================================================
        //==========================Friendship Request Queries=======================
        //===========================================================================

        private void FillFrienshipdRequest()
        {
            List<FriendRequest> friendshipRequests = new List<FriendRequest>();
            FriendRequest f = new FriendRequest("idan", "anael");
            friendshipRequests.Add(f);
            f = new FriendRequest("dana", "anael");
            friendshipRequests.Add(f);
            f = new FriendRequest("eyal", "nadav");
            friendshipRequests.Add(f);
            f = new FriendRequest("rotem", "idan");
            friendshipRequests.Add(f);

            foreach (FriendRequest fr in friendshipRequests)
            {
                string addFriendshipRequest = "INSERT INTO friendshipRequests (SentFrom,SentTo,date) VALUES(@user,@friend,@date);";
                SQLiteCommand cmd = new SQLiteCommand(addFriendshipRequest, dbConnection);
                cmd.Parameters.Add(new SQLiteParameter("@user", fr.SentFrom));
                cmd.Parameters.Add(new SQLiteParameter("@friend", fr.SentTo));
                cmd.Parameters.Add(new SQLiteParameter("@date", fr.Date));
                cmd.ExecuteNonQuery();
            }

        }

        public void AddFriendshipRequest(string userName, string friendUserName)
        {
            string addFriendshipRequest = "INSERT INTO friendshipRequests (SentFrom,SentTo,date) VALUES(@user,@friend,@date);";
            SQLiteCommand cmd = new SQLiteCommand(addFriendshipRequest, dbConnection);
            cmd.Parameters.Add(new SQLiteParameter("@user", userName));
            cmd.Parameters.Add(new SQLiteParameter("@friend", friendUserName));
            cmd.Parameters.Add(new SQLiteParameter("@date", DateTime.Now));
            cmd.ExecuteNonQuery();
        }

        public void RemoveFriendshipRequest(string sentFrom, string sentTo)
        {
            string removeFriendshipRequest = "DELETE FROM friendshipRequests WHERE SentFrom = (@userName) AND SentTo = (@sentTo);";
            SQLiteCommand cmd = new SQLiteCommand(removeFriendshipRequest, dbConnection);
            cmd.Parameters.Add(new SQLiteParameter("@userName", sentFrom));
            cmd.Parameters.Add(new SQLiteParameter("@sentTo", sentTo));
            cmd.ExecuteNonQuery();
        }

        public List<FriendRequest> GetfriendshipRequests()
        {
            List<FriendRequest> friendRequest = new List<FriendRequest>();
            string sql = "SELECT SentFrom,SentTo,strftime([date],3) as [date] FROM friendshipRequests;";
            SQLiteCommand cmd = new SQLiteCommand(sql, dbConnection);
            SQLiteDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string sentFrom = reader["SentFrom"].ToString();
                string sentTo = reader["SentTo"].ToString();
                string d = reader["date"].ToString();
                DateTime date = Convert.ToDateTime(d);

                friendRequest.Add(new FriendRequest(sentFrom, sentTo, date));
            }
            return friendRequest;

        }

        //===========================================================================
        //==========================Friends Queries=====================================
        //===========================================================================

        private void FillFriendsTable()
        {
            string addFriend = "INSERT INTO friends (user,friend) VALUES ('anael','nadav')";
            SQLiteCommand cmd = new SQLiteCommand(addFriend, dbConnection);
            cmd.ExecuteNonQuery();

            addFriend = "INSERT INTO friends (user,friend) VALUES ('nadav','anael')";
            cmd = new SQLiteCommand(addFriend, dbConnection);
            cmd.ExecuteNonQuery();

            addFriend = "INSERT INTO friends (user,friend) VALUES ('rotem','anael')";
            cmd = new SQLiteCommand(addFriend, dbConnection);
            cmd.ExecuteNonQuery();

            addFriend = "INSERT INTO friends (user,friend) VALUES ('anael','rotem')";
            cmd = new SQLiteCommand(addFriend, dbConnection);
            cmd.ExecuteNonQuery();

            addFriend = "INSERT INTO friends (user,friend) VALUES ('eyal','anael')";
            cmd = new SQLiteCommand(addFriend, dbConnection);
            cmd.ExecuteNonQuery();

            addFriend = "INSERT INTO friends (user,friend) VALUES ('anael','eyal')";
            cmd = new SQLiteCommand(addFriend, dbConnection);
            cmd.ExecuteNonQuery();

            addFriend = "INSERT INTO friends (user,friend) VALUES ('nadav','dana')";
            cmd = new SQLiteCommand(addFriend, dbConnection);
            cmd.ExecuteNonQuery();

            addFriend = "INSERT INTO friends (user,friend) VALUES ('dana','nadav')";
            cmd = new SQLiteCommand(addFriend, dbConnection);
            cmd.ExecuteNonQuery();

            addFriend = "INSERT INTO friends (user,friend) VALUES ('idan','nadav')";
            cmd = new SQLiteCommand(addFriend, dbConnection);
            cmd.ExecuteNonQuery();

            addFriend = "INSERT INTO friends (user,friend) VALUES ('idan','eyal')";
            cmd = new SQLiteCommand(addFriend, dbConnection);
            cmd.ExecuteNonQuery();

            addFriend = "INSERT INTO friends (user,friend) VALUES ('nadav','idan')";
            cmd = new SQLiteCommand(addFriend, dbConnection);
            cmd.ExecuteNonQuery();

            addFriend = "INSERT INTO friends (user,friend) VALUES ('eyal','idan')";
            cmd = new SQLiteCommand(addFriend, dbConnection);
            cmd.ExecuteNonQuery();
        }

        public void AddFriend(string userName, string friendUserName)
        {
            string addFriend = "INSERT INTO friends (user,friend) VALUES (@userName,@friendUserName)";
            SQLiteCommand cmd = new SQLiteCommand(addFriend, dbConnection);
            cmd.Parameters.Add(new SQLiteParameter("@userName", userName));
            cmd.Parameters.Add(new SQLiteParameter("@friendUserName", friendUserName));
            cmd.ExecuteNonQuery();

            cmd.Parameters.Clear();
            cmd.Parameters.Add(new SQLiteParameter("@userName", friendUserName));
            cmd.Parameters.Add(new SQLiteParameter("@friendUserName", userName));
            cmd.ExecuteNonQuery();

        }

        public void RemoveFriend(string userName, string friendUserName)
        {
            string removeFriend = "DELETE FROM friends WHERE user = (@userName) AND friend = (@friendUserName);";
            SQLiteCommand cmd = new SQLiteCommand(removeFriend, dbConnection);
            cmd.Parameters.Add(new SQLiteParameter("@userName", userName));
            cmd.Parameters.Add(new SQLiteParameter("@friendUserName", friendUserName));
            cmd.ExecuteNonQuery();

            cmd.Parameters.Clear();
            cmd.Parameters.Add(new SQLiteParameter("@userName", friendUserName));
            cmd.Parameters.Add(new SQLiteParameter("@friendUserName", userName));
            cmd.ExecuteNonQuery();
        }

        public Dictionary<AbstractUser,List<AbstractUser>> GetFriends()
        {
            DB dataBase = DB.GetInstance();
            Dictionary<AbstractUser, List<AbstractUser>> friendsPerUser = new Dictionary<AbstractUser, List<AbstractUser>>();
            string sql = "SELECT user,friend FROM friends;";
            SQLiteCommand cmd = new SQLiteCommand(sql, dbConnection);
            SQLiteDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string u = reader["user"].ToString();
                string f = reader["friend"].ToString();

                AbstractUser user = dataBase.FindUser(u);
                AbstractUser friend = dataBase.FindUser(f);

                if (!friendsPerUser.ContainsKey(user))
                {
                    friendsPerUser.Add(user, new List<AbstractUser>());
                }
                friendsPerUser[user].Add(friend);
            }
            return friendsPerUser;
        }
}
}
