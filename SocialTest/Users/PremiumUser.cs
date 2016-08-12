using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;

namespace Social_Network
{
    class PremiumUser : AbstractUser
    {
        // Data fields

        //Instance of DataBase.
        DB dataBase = DB.GetInstance();

        // Constructors
        public PremiumUser() : base() { }

        public PremiumUser(string firstName, string lastName, string email,
          string gender, string userName, string password, string favoriteGenere)
            : base(firstName, lastName, email, gender, userName, password, favoriteGenere)
        {
            Permission = 2;
        }

        // Methods

        //=======================================================================
        //======================Premuim User Methods=============================
        //=======================================================================

        public override void RemoveMyAccount()
        {
            dataBase.RemoveMyAccount(this);
        }

        public override void SignUp(string firstName, string lastName, string email, string gender, string userName, string password, string fGenre)
        {
            PremiumUser curr = new PremiumUser(firstName, lastName, email, gender, userName, password, fGenre);
            dataBase.AddUser(curr);
        }

        // Posts
        public override void AddPost(string content)
        {
            Post post = new Post(content, this.UserName,2);
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
        public override void SendMessage(string title, string content, string to)
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

        public override void SharePlaylist(string singer,string song,string genre)
        {
            Playlist p = new Playlist(singer, song, genre);
            dataBase.AddToPlaylist(p);
        }

        public override List<Playlist> ShowPlaylistByGenres(string genre,string order)
        {
            if (order != "2" || order != "1")
             return dataBase.ShowPlaylistByGenres(genre, order);
            else
            return dataBase.ShowPlaylistByGenres(genre,order);
        }
  
    }
}
