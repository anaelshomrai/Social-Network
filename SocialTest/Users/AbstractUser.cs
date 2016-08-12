using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Social_Network
{

    abstract class AbstractUser: UserActions
    {

        // Data fields
        private string firstName;
        private string lastName;
        private string email;
        private string gender;
        private string userName;
        private string password;
        private int permission;
        private string favoriteGenres;

        //===========================================================================
        //==========================Constructors=====================================
        //===========================================================================

        public AbstractUser() { }

        public AbstractUser(string firstName, string lastName, string email,
            string gender, string userName, string password, string favoriteGenere)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            UserName = userName;
            Password = password;
            Gender = gender;
            FavoriteGenre = favoriteGenere;
            this.permission = 1;
        }

        public AbstractUser(string firstName, string lastName, string email,
    string gender, string userName, string password, string favoriteGenere,int permission)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            UserName = userName;
            Password = password;
            Gender = gender;
            FavoriteGenre = favoriteGenere;
            this.permission = permission;
        }

        //=======================================================================
        //==========================Property=====================================
        //==========================Get/Set======================================
        public string FirstName
        {
            get { return firstName; }
            set
            {
                firstName = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(value);
            }
        }

        public string LastName
        {
            get { return lastName; }
            set
            {

                lastName = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(value);
            }
        }

        public string Email
        {
            get { return email; }
            set
            {
                if (string.IsNullOrEmpty(value) == true)
                    email = FirstName + "_" + LastName + "@gmail.com";
                    email = value;
            }
        }

        public string Gender
        {
            get { return gender; }
            set
            {
                gender = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(value);
            }
        }

        public string UserName
        {
            get { return userName; }
            set
            {

                userName = value;
            }
        }

        public string Password
        {
            get { return password; }
            set
            {

                password = value;
            }
        }

        public int Permission
        {
            get { return permission; }
            set { permission = value; }
        }

        public string FavoriteGenre
        {
            get { return favoriteGenres; }
            set { favoriteGenres = value; }
        }

        // Methods

        public override string ToString()
        {
            return string.Format("Name: {0}\nEmail: {1}\nGender:" +
           "{2}\nUser Name: {3}\nFavorite Genere: ", (FirstName + " " + LastName), Email, Gender, UserName, favoriteGenres);
        }

        public string ChangeEmail(string oldEmail, string newEmail)
        {
            if (oldEmail.Equals(Email) == true)
            {
                Email = newEmail;
                return("Email Changed!");
            }
            else
            {
               return("Wrong Email!");
            }
        }

        public string ChangePassword(string oldPassword,string newPassword)
        {
            if (oldPassword.Equals(Password) == true)
            {
                Password = newPassword;
                return("Password Changed!");
            }
            else
            {
                return("Wrong password!!!");
            }
        }


        //=======================================================================
        //==========================Abstract user Methods========================
        //=======================================================================

        public abstract void SharePlaylist(string singer, string song, string genre);
        public abstract List<Playlist> ShowPlaylistByGenres(string genre,string order);

        public abstract void RemoveMyAccount();
        public abstract void SignUp(string firstName, string lastName, string email, string gender, string userName, string password, string fGenre);

        public abstract string AddFriend(string friendUserName);
        public abstract bool RemoveFriend(string friendUserName);

        public abstract void AddPost(string content);
        public abstract bool RemovePost(int idPost);
        public abstract bool EditPost(int idPost, string content);
        public abstract List<Post> PrintAllMyPosts(string username);

        public abstract void SendMessage(string title, string content,string to);
        public abstract List<Message> ShowMessagesWithFriend(string friendUserName);

    }
}
