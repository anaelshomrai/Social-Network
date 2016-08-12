using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Social_Network
{
    interface UserActions
    {
        string ChangeEmail(string oldEmail, string newEmail);
        string ChangePassword(string oldPassword, string newPassword);
        void RemoveMyAccount();
        void SignUp(string firstName, string lastName, string email, string gender, string userName, string password, string fGenre);
        void SharePlaylist(string singer,string song,string genre);
        List<Playlist> ShowPlaylistByGenres(string genre,string order);
        string AddFriend(string friendUserName);
        bool RemoveFriend(string friendUserName);
        void SendMessage(string title, string content, string to);
        List<Message> ShowMessagesWithFriend(string friendUserName);
        void AddPost(string content);
        bool EditPost(int idPost, string content);
        bool RemovePost(int idPost);
    }
}
