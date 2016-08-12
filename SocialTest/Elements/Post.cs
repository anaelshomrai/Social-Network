using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Social_Network
{
    class Post
    {
        private string from;
        private string content;
        private DateTime date;
        private int like = 0;
        private int share = 0;
        private static int count = 0;
        private int idPost;
        private int priority;

        public static void CurrentCountOfPosts()
        {
            RealDataBase db = RealDataBase.Instance;
            count = db.GetPostsCount();
        }


        public Post(string content,string from,int priority)
        {
            Content = content;
            this.date = DateTime.Now;
            this.from = from;
            this.idPost = ++count;
            Priority = priority;
        }

        public Post(int idPost,string content, string from, int priority,int like,int share,DateTime date)
        {
            Content = content;
            this.date = date;
            this.from = from;
            this.idPost = idPost;
            Priority = priority;
            this.like = like;
            this.share = share;
            
        }

        public int Priority
        {
            get { return priority; }
            set { priority = value; }
        }

        public string Content
        {
            get { return content; }
            set { content = value; }
            }

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        public int Like
        {
            get { return like; }
            set { like = value; }
        }

        public int Share
        {
            get { return share; }
            set { share = value; }
        }

        public int IdPost
        {
            get { return idPost; }
        }

        public string From
        {
            get { return from; }
            set { from = value; }
        }

        public override string ToString()
        {
            return "Posted at: " + this.date + "\t\t" + "Post id: "+ idPost + "\n" + this.content + "\n" + "Likes: " + this.like + "\t" + "Shares: " + this.share + "\n";
        } 

        public void ShowPost()
        {
            Console.WriteLine(this.from + " posted at: " + this.date + "\n" + this.content + "\n" + "Press 1 to like - Likes: " + this.like + "\t" + "Press 2 to share - Shares: " + this.share + "\n");

        }

        public void AddLike()
        {
            this.like++;
        }

        public void  Unlike()
        {
            this.like--;
        }

        public Post AddShare(Post shared,AbstractUser user)
        {
            Post p = new Post("I'm sharing post of " + shared.from +"..\n" + shared.content, user.UserName,user.Permission);
            this.share++;
            return p;
        }

    }
}
