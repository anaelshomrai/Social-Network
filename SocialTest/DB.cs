using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;

namespace Social_Network
{
    class DB
    {

        // Enum of Genres (to limit the genres selected by the user)
        public enum Genres { Hip_Hop = 1, Rock, Pop, Chill_House, RockNRoll, Reggae, General = 7 };

        //Create an object of DataBase
        protected static DB instance = new DB();

        //List of database class
        private List<AbstractUser> users = new List<AbstractUser>();
        private List<Post> posts = new List<Post>();
        private List<Message> messages = new List<Message>();

        // List of friends request
        List<FriendRequest> friendshipRequests = new List<FriendRequest>();

        // List of playlist
        private List<Playlist> Hip_Hop = new List<Playlist>();
        private List<Playlist> Rock = new List<Playlist>();
        private List<Playlist> Pop = new List<Playlist>();
        private List<Playlist> Chill_House = new List<Playlist>();
        private List<Playlist> RockNRoll = new List<Playlist>();
        private List<Playlist> Reggae = new List<Playlist>();
        private List<Playlist> General = new List<Playlist>();

        //Dictionray
        private Dictionary<AbstractUser, List<AbstractUser>> friendsPerUser = new Dictionary<AbstractUser, List<AbstractUser>>();


        // Private Constructor
        private DB() { }

        // Property
        // Only get method to permit only one instance
        public static DB GetInstance()
        {
            return instance;
        }

        ////////////Playlist methods////////////

        // Show AllPlaylist
        public List<Playlist> ShowAllPlaylist()
        {
            return General;
        }

        public void AddToPlaylist(Playlist p)
        {
            p.Singer = p.Singer.ToLower();
            p.Singer = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(p.Singer);
            p.Song = p.Song.ToLower();
            p.Song = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(p.Song);
            Genres found = Genres.Chill_House;
            Array val = Enum.GetValues(typeof(Genres));
            foreach (Genres g in val)  // Serching the right genre
            {
                if (g.ToString().Equals(p.Genre))
                {
                    found = g;
                    break;
                }
            }
            switch (found) // adding to the correct playlist
            {
                case Genres.Hip_Hop:
                    Hip_Hop.Add(p);
                    break;
                case Genres.Chill_House:
                    Chill_House.Add(p);
                    break;
                case Genres.Pop:
                    Pop.Add(p);
                    break;
                case Genres.Reggae:
                    Reggae.Add(p);
                    break;
                case Genres.Rock:
                    Rock.Add(p);
                    break;
                case Genres.RockNRoll:
                    RockNRoll.Add(p);
                    break;
            }
            General.Add(p);
            RealDataBase db = RealDataBase.Instance;
            db.AddToGeneralPlaylist(p);
        }

        public bool CheckIfPlaylistExist(string song, string singer)
        {
            string s = singer.ToLower() + song.ToLower();
            foreach (Playlist p in General)
            {
                if (s.Equals(p.Singer.ToLower() + p.Song.ToLower(), StringComparison.InvariantCultureIgnoreCase))
                    return true;
            }
            return false;
        }

        public List<Playlist> ShowPlaylistByGenres(string genre, string order)
        {
            List<Playlist> sorted = null;
            Genres found = Genres.Chill_House;
            Array val = Enum.GetValues(typeof(Genres));
            foreach (Genres g in val)
            {
                if (g.ToString().Equals(genre))
                {
                    found = g;
                    break;
                }
            }
            Console.WriteLine(genre + " :");
            switch (found)
            {
                case Genres.Hip_Hop:
                    {
                        if (Hip_Hop.Count == 0)
                        {
                            goto default;
                        }
                        if (order == "1")
                        {
                            sorted = Hip_Hop.OrderBy(o => o.Singer).ToList();
                            return sorted;
                        }
                        else if (order == "2")
                        {
                            sorted = Hip_Hop.OrderBy(o => o.Song).ToList();
                            return sorted;
                        }
                        else
                            return Hip_Hop;
                    }
                case Genres.Chill_House:
                    {
                        if (Chill_House.Count == 0)
                        {
                            goto default;
                        }
                        if (order == "1")
                        {
                            sorted = Chill_House.OrderBy(o => o.Singer).ToList();
                            return sorted;
                        }
                        else if (order == "2")
                        {
                            sorted = Chill_House.OrderBy(o => o.Song).ToList();
                            return sorted;
                        }
                        else
                            return Chill_House;
                    }
                case Genres.Pop:
                    {
                        if (Pop.Count == 0)
                        {
                            goto default;
                        }
                        if (order == "1")
                        {
                            sorted = Pop.OrderBy(o => o.Singer).ToList();
                            return sorted;
                        }
                        else if (order == "2")
                        {
                            sorted = Pop.OrderBy(o => o.Song).ToList();
                            return sorted;
                        }
                        else
                            return Pop;

                    }
                case Genres.Reggae:
                    {
                        if (Reggae.Count == 0)
                        {
                            goto default;
                        }
                        if (order == "1")
                        {
                            sorted = Reggae.OrderBy(o => o.Singer).ToList();
                            return sorted;
                        }
                        else if (order == "2")
                        {
                            sorted = Reggae.OrderBy(o => o.Song).ToList();
                            return sorted;
                        }
                        else
                            return Reggae;
                    }
                case Genres.Rock:
                    {
                        if (Rock.Count == 0)
                        {
                            goto default;
                        }
                        if (order == "1")
                        {
                            sorted = Rock.OrderBy(o => o.Singer).ToList();
                            return sorted;
                        }
                        else if (order == "2")
                        {
                            sorted = Rock.OrderBy(o => o.Song).ToList();
                            return sorted;
                        }
                        else
                            return Rock;
                    }
                case Genres.RockNRoll:
                    {
                        if (RockNRoll.Count == 0)
                        {
                            goto default;
                        }
                        if (order == "1")
                        {
                            sorted = RockNRoll.OrderBy(o => o.Singer).ToList();
                            return sorted;
                        }
                        else if (order == "2")
                        {
                            sorted = RockNRoll.OrderBy(o => o.Song).ToList();
                            return sorted;
                        }
                        else
                            return RockNRoll;
                    }
                case Genres.General:
                    {
                        if (General.Count == 0)
                        {
                            goto default;
                        }
                        if (order == "1")
                        {
                            sorted = General.OrderBy(o => o.Singer).ToList();
                            return sorted;
                        }
                        else if (order == "2")
                        {
                            sorted = General.OrderBy(o => o.Song).ToList();
                            return sorted;
                        }

                        else
                            return General;
                    }

                default:
                    return null;

            }
        }

        //=======================================================================
        //==========================User Methods=================================
        //=======================================================================
        public List<AbstractUser> Users
        {
            get { return this.users; }
        }

        public List<Message> Messages
        {
            get { return this.Messages; }
        }

        public void AddUser(AbstractUser user)
        {
            this.users.Add(user);
            CreateFriendsList(user);
            RealDataBase db = RealDataBase.Instance;
            db.AddUser(user);
        }

        public void RemoveMyAccount(AbstractUser u)
        {
            if (friendsPerUser.ContainsKey(u))
            {
                foreach (AbstractUser toRemove in users)
                {
                    if (friendsPerUser[u].Contains(toRemove))
                    {
                        this.RemoveFriend(u.UserName, toRemove.UserName);
                        //inside remove friend theres a call to datebase remove friends
                    }
                }
            }
            if (u != null)
            {
                this.users.Remove(u);
                RealDataBase db = RealDataBase.Instance;
                db.RemoveUser(u.UserName);
                this.friendsPerUser.Remove(u);
            }
        }

        public string ForgetMyUserName(string pass, string email)
        {
            foreach (AbstractUser u in users)
            {
                if (email.Equals(u.Email) == true && pass.Equals(u.Password) == true)
                {
                    return "Your user name is:" + u.UserName;

                }
            }
            return ("Incorrect password/email\n");
        }

        public string ForgetMyPassword(string name, string email)
        {
            foreach (AbstractUser u in users)
            {
                if (name.Equals(u.UserName) == true)
                {
                    return "Your password is:" + u.Password;
                }
            }
            return "Incorrect user-name/email!\n";
        }

        public AbstractUser FindUser(string username, string password)
        {
            foreach (AbstractUser u in this.users)
            {
                if (u.UserName.Equals(username) && u.Password.Equals(password))
                {
                    return u;
                }
            }
            return null;
        }

        public AbstractUser FindUser(string name)
        {
            foreach (AbstractUser u in users)
            {
                if (u.UserName == name)
                {
                    return u;
                }
            }
            return null;
        }

        public List<AbstractUser> FindUserByGenre(string genre)
        {
            List<AbstractUser> found = new List<AbstractUser>();
            foreach (AbstractUser u in users)
            {
                if (string.IsNullOrEmpty(u.FavoriteGenre) == false)
                {
                    if (u.FavoriteGenre.Equals(genre) == true)
                    {
                        found.Add(u);
                    }
                }
            }
            return found;
        }

        public string HowManyMembers()
        {
            int user = 0;
            int admin = 0;
            int premium = 0;
            foreach (AbstractUser u in users)
            {
                if (u.GetType() == typeof(Admin))
                    admin++;
                else if (u.GetType() == typeof(User))
                    user++;
                else
                    premium++;
            }
            return ("There are\n" +
            admin + " Admin\n"
            + (user + " Users\n"
            + premium + " Premium Users\n"
         + "A total of " + (admin + user + premium) + " members!\n"));
        }

        public List<Post> Posts
        {
            get { return this.posts; }
        }

        public bool SignUp(int choice, string firstName, string lastName, string email,
            string gender, string userName, string password, string fGenre)
        {
            switch (choice) // 1  Premium User, 2 User 
            {
                case 1:
                    {
                        PremiumUser premiumUser = new PremiumUser();
                        premiumUser.SignUp(firstName, lastName, email, gender, userName, password, fGenre);
                    }
                    break;
                case 2:
                    {
                        User user = new User();
                        user.SignUp(firstName, lastName, email, gender, userName, password, fGenre);
                    }
                    break;
                default:
                    Console.WriteLine("Invalid Option! Try again\n");
                    break;
            }
            return true;
        }

        ///////////////////////////Posts///////////////////

        public void AddPost(Post post)
        {
            this.posts.Add(post);
            RealDataBase db = RealDataBase.Instance;
            db.AddPost(post);

        }

        public void RemovePost(int idPost)
        {
            Post toDel = null;
            foreach (Post post in posts)
            {
                if (post.IdPost == idPost)
                {
                    toDel = post;
                }
            }
            posts.Remove(toDel);
            RealDataBase db = RealDataBase.Instance;
            db.RemovePost(idPost);
        }

        public void EditPost(Post p, string content)
        {
            if (p == null)
                return;
            else
            {
                p.Content = content;
                p.Date = DateTime.Now;
            }
            RealDataBase db = RealDataBase.Instance;
            db.EditPost(p.IdPost, p.Date, p.Content);
        }

        public List<Post> PrintAllMyPosts(string username)
        {
            List<Post> myPosts = new List<Post>();
            int count = 0;
            foreach (Post post in posts)
            {
                if (post.From == username)
                {
                    myPosts.Add(post);
                    count++;
                }
            }
            //if (count == 0)
            //{
            //    //return ("No posts to show!");
            ////}
            //else
            return myPosts;
        }

        public List<Post> ShowFeed()
        {
            List<Post> newPosts = new List<Post>();
            List<Post> sortedPosts = posts.OrderByDescending(o => o.Date).ToList();
            sortedPosts = sortedPosts.OrderBy(o => o.Priority).ToList();

            return sortedPosts;
        }

        public void LikePost(int idPost)
        {
            foreach (Post p in posts)
            {
                if (p.IdPost == idPost)
                {
                    p.AddLike();
                    RealDataBase db = RealDataBase.Instance;
                    db.AddLike(idPost, p.Like);
                    break;
                }
            }
        }

        public void UnlikePost(int idPost)
        {
            foreach (Post p in posts)
            {
                if (p.IdPost == idPost)
                {
                    p.Unlike();
                    RealDataBase db = RealDataBase.Instance;
                    db.UnlikePost(idPost, p.Like);
                    break;
                }

            }
        }

        public void SharePost(int idPost, AbstractUser user)
        {
            RealDataBase db = RealDataBase.Instance;
            Post newPost = null;
            foreach (Post p in posts)
            {
                if (p.IdPost == idPost)
                {
                    db.AddShare(idPost, p.Share);
                    newPost = p.AddShare(p, user);
                }
            }
            posts.Add(newPost);
            db.AddPost(newPost);
        }

        //////////////////Message/////////////////

        public void SendMessage(Message message)
        {
            this.messages.Add(message);
            RealDataBase db = RealDataBase.Instance;
            db.AddMessage(message);
        }

        public List<Message> PrintAllMyMessages(string username, string friendeUsername)
        {
            List<Message> userMessage = new List<Message>();
            foreach (Message message in messages)
            {
                if (message.From == username && message.To == friendeUsername || message.To == username && message.From == friendeUsername)
                {
                    userMessage.Add(message);
                }
            }
            List<Message> sortUserMessage = userMessage.OrderBy(o => o.Date).ToList();
            return sortUserMessage;
        }

        //////////////////Friendship Requests/////////////////

        public List<AbstractUser> Friendconversations(string username)
        {
            string friendUserName = "";
            List<AbstractUser> myConversations = new List<AbstractUser>();
            foreach (Message m in messages)
            {
                if (m.From == username && !myConversations.Any(item => item.UserName == m.To)) // searching  for messages that i sent, but do not exist alreday in the list
                {
                    friendUserName = m.To;
                    myConversations.Add(this.FindUser(friendUserName));
                }
                else if (m.To == username && !myConversations.Any(item => item.UserName == m.From)) // same, but this time searching for messages that sent to me
                {
                    friendUserName = m.From;
                    myConversations.Add(this.FindUser(friendUserName));
                }
            }
            return myConversations;
        }

        public void RequestFriendship(string userName, string friendUserName)
        {
            AbstractUser thisUser = null;
            AbstractUser friend = null;
            foreach (AbstractUser user in users)
            {
                if (userName == user.UserName)
                {
                    thisUser = user;
                }
                if (user.UserName == friendUserName)
                {
                    friend = user;
                }
                if (thisUser != null && friend != null) // when we found both the user, and the friend
                {
                    friendshipRequests.Add(new FriendRequest(userName, friendUserName));
                    RealDataBase db = RealDataBase.Instance;
                    db.AddFriendshipRequest(userName, friendUserName);
                    break;
                }
            }
        }

        public string SearchFriendshipRequest(string userName, string friendUserName)
        {
            AbstractUser u = FindUser(friendUserName);
            if (u == null)
                return "User doesn't exist!";
            u = FindUser(userName);
            bool alreadyFriend = this.friendsPerUser[u].Contains(FindUser(friendUserName));
            if (alreadyFriend == true)
                return friendUserName + " is already your friend!";

            foreach (FriendRequest f in friendshipRequests)
            {
                if (f.SentFrom == userName && f.SentTo == friendUserName)
                {
                    return ("Friend Request already sent to " + f.SentTo);
                }
            }
            this.RequestFriendship(userName, friendUserName);
            return "Request sent to " + friendUserName + " !";
        }

        public List<FriendRequest> ShowPendingRequest(string userName)
        {
            List<FriendRequest> pending = new List<FriendRequest>(); // creating a list with the friendship requests that didnt approved/deny yet
            foreach (FriendRequest f in friendshipRequests)
            {
                if (f.SentFrom == userName)
                    pending.Add(f);
            }
            return pending;
        }

        public bool NewFriendshipRequests(string userName)
        {
            foreach (FriendRequest f in friendshipRequests)
            {
                if (f.SentTo == userName)
                    return true;
            }
            return false;
        }

        public List<FriendRequest> SeeFriendshipRequests(string userName)
        {
            List<FriendRequest> myFriendshipRequest = new List<FriendRequest>();

            foreach (FriendRequest f in friendshipRequests)
            {
                if (f.SentTo == userName) // if the request sent to me, add to the list
                {
                    myFriendshipRequest.Add(f);
                }
            }
            return myFriendshipRequest;
        }

        public void RemoveFriendshipRequest(string sentTo, string sentFrom, bool status)
        {
            RealDataBase db = RealDataBase.Instance;
            FriendRequest todel = null;
            foreach (FriendRequest f in friendshipRequests)
            {
                if (f.SentFrom == sentFrom && f.SentTo == sentTo)
                {
                    todel = f;
                    if (status)
                    {
                        this.AddFriend(f.SentTo, f.SentFrom);
                    }
                    break;
                }
            }
            friendshipRequests.Remove(todel);
            db.RemoveFriendshipRequest(sentFrom, sentTo);

        }

        //////////////////Friends/////////////////

        public void AddFriend(string userName, string userNameFriend)
        {
            AbstractUser thisUser = null;
            AbstractUser friend = null;
            foreach (AbstractUser user in users)
            {
                if (userName == user.UserName)
                {
                    thisUser = user;
                }
                if (user.UserName == userNameFriend)
                {
                    friend = user;
                }
                if (thisUser != null && friend != null)
                {
                    this.friendsPerUser[thisUser].Add(friend); // adding friend to my list of friends
                    this.friendsPerUser[friend].Add(thisUser); // adding myself to the friend list
                    RealDataBase db = RealDataBase.Instance;
                    db.AddFriend(thisUser.UserName, friend.UserName);
                    Console.WriteLine("Friend Added!");
                    break;
                }
            }
        }

        public bool RemoveFriend(string userName, string userNameFriend)
        {
            AbstractUser thisUser = null;
            AbstractUser friend = null;
            foreach (AbstractUser user in users)
            {
                if (userName == user.UserName)
                {
                    thisUser = user;
                }
                if (user.UserName == userNameFriend)
                {
                    friend = user;
                }
                if (thisUser != null && friend != null)
                {
                    this.friendsPerUser[thisUser].Remove(friend); // removing the friend from my list of friends
                    this.friendsPerUser[friend].Remove(thisUser); // removing myself from his list
                    RealDataBase db = RealDataBase.Instance;
                    db.RemoveFriend(thisUser.UserName, friend.UserName);
                    return true;
                }
            }
            return false;
        }

        public List<AbstractUser> ShowFriends(string userName)
        {
            bool found = false;
            List<AbstractUser> userFriends = null;
            foreach (var u in friendsPerUser)
            {
                if (u.Key.UserName == userName)
                {
                    found = true;
                    userFriends = u.Value;
                    break;
                }
            }
            if (!found)
            {
                return null;
            }
            return userFriends;
        }

        public void CreateFriendsList(AbstractUser user)
        {
            if (!friendsPerUser.ContainsKey(user))
            {
                this.friendsPerUser.Add(user, new List<AbstractUser>());
            }
        }

        public void InitLists()
        {
            RealDataBase db = RealDataBase.Instance;

            General.AddRange(db.GetGeneralPlaylist()); // initialize playlist general
            SeprateToGenres(General); // separate to specific genres
            users.AddRange(db.GetUsers()); // intialize users list
            messages.AddRange(db.GetMessages()); // intialize messages list
            posts.AddRange(db.GetPosts()); // intialize post list
            friendshipRequests.AddRange(db.GetfriendshipRequests()); // intialize friendship Requests list
            friendsPerUser = new Dictionary<AbstractUser, List<AbstractUser>>(db.GetFriends()); // creating a copy of the dictionary sent from db
            foreach (AbstractUser u in users)
            {
                CreateFriendsList(u);
            }
        }

        public void SeprateToGenres(List<Playlist> general)
        {
            Genres found = Genres.Chill_House;
            Array val = Enum.GetValues(typeof(Genres));
            foreach (Playlist p in general)
            {
                foreach (Genres g in val) // searching for the right genre 
                {
                    if (g.ToString().Equals(p.Genre))
                    {
                        found = g;
                        switch (found)
                        {
                            case Genres.Hip_Hop:
                                Hip_Hop.Add(p);
                                break;
                            case Genres.Chill_House:
                                Chill_House.Add(p);
                                break;
                            case Genres.Pop:
                                Pop.Add(p);
                                break;
                            case Genres.Reggae:
                                Reggae.Add(p);
                                break;
                            case Genres.Rock:
                                Rock.Add(p);
                                break;
                            case Genres.RockNRoll:
                                RockNRoll.Add(p);
                                break;
                        }

                    }
                }
            }

        }

    }
}
