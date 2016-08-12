using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Social_Network
{

    class Admin : AbstractUser, AdminActions
    {
        // Data fields  

        //Instance of DataBase.
        DB dataBase = DB.GetInstance();

        // Constructors
        public Admin() : base() { }

        public Admin(string firstName, string lastName, string email,
             string gender, string userName, string password, string favoriteGenre)
            : base(firstName, lastName, email, gender, userName, password, favoriteGenre)
        {
            Permission = 1;
        }

        // Methods

        //=======================================================================
        //==========================Admin Methods================================
        //=======================================================================

        public override void SignUp(string firstName, string lastName, string email, string gender, string userName, string password, string fGenre)
        {
            Admin curr = new Admin(firstName, lastName, email, gender, userName, password, fGenre);
            dataBase.AddUser(curr);
        }

        public override void RemoveMyAccount()
        {
           dataBase.RemoveMyAccount(this);
        }
        
        public string DeleteUser(AbstractUser u)
        {
            if (u == null)
                return("User does not exist");
            if (u.Permission == 1)
            {
                return("You can't delete an admin!");
            }
            dataBase.RemoveMyAccount(u);
            return("Deleted!");
            
        }

        public string ChangePermission(int permission,AbstractUser u)
        {
            if (u.GetType() == typeof(Admin))
            {
                return("You cant change admin permission!");
            }
            else
            {
                switch (permission)
                {
                    case 1: Admin temp1 = new Admin(u.FirstName, u.LastName, u.Email, u.Gender, u.UserName, u.Password, u.FavoriteGenre);
                        dataBase.RemoveMyAccount(u);
                        dataBase.AddUser(temp1);
                        break;
                    case 2: PremiumUser temp3 = new PremiumUser(u.FirstName, u.LastName, u.Email, u.Gender, u.UserName, u.Password, u.FavoriteGenre);
                        dataBase.RemoveMyAccount(u);
                        dataBase.AddUser(temp3);
                        break;
                    case 3: User temp2 = new User(u.FirstName, u.LastName, u.Email, u.Gender, u.UserName, u.Password, u.FavoriteGenre);
                        dataBase.RemoveMyAccount(u);
                        dataBase.AddUser(temp2);
                        break;
                }
                return("Permission changed!");
            }
        }

        // Posts
        public override void AddPost(string content)
        {
            Post post = new Post(content, this.UserName,1);
            dataBase.AddPost(post);
        }

        public override bool RemovePost(int idPost)
        {
            foreach (Post post in dataBase.Posts)
            {
                if (post.IdPost == idPost)
                {
                    dataBase.RemovePost(idPost);
                    return true;
                }
            }
            return false;
        }

        public override bool EditPost(int idPost, string content)
        {
            foreach (Post post in dataBase.Posts)
            {
                if (idPost == post.IdPost)
                {
                    dataBase.EditPost(post, content);
                    return true;
                }
            }
            return false;
        }

        public override List<Post> PrintAllMyPosts(string username)
        {
            return dataBase.PrintAllMyPosts(username);
        }

        //Message
        public override void SendMessage(string title, string content,string to)
        {
            Message message = new Message(to, this.UserName, title, content);
            dataBase.SendMessage(message);
        }

        public override List<Message> ShowMessagesWithFriend(string friendUserName)
        {
            return dataBase.PrintAllMyMessages(this.UserName, friendUserName);
        }

        // Friend

        public override string AddFriend(string friendUserName)
        {
            return dataBase.SearchFriendshipRequest(this.UserName, friendUserName);
        }

        public override bool RemoveFriend(string friendUserName)
        {
            return dataBase.RemoveFriend(this.UserName, friendUserName);
        }

        public override void SharePlaylist(string singer, string song, string genre)
        {
            Playlist p = new Playlist(singer, song, genre);
            dataBase.AddToPlaylist(p);
        }

        public override List<Playlist> ShowPlaylistByGenres(string genre, string order)
        {
            if (order != "2" || order != "1")
                return dataBase.ShowPlaylistByGenres(genre, order);
            else
                return dataBase.ShowPlaylistByGenres(genre, order);
        }
    }
}