using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Social_Network
{
    class Message
    {

        private string to;
        private string from;
        private string title;
        private string content;
        private DateTime date;
        private static int count = 0;
        private int messageId = 0;

        public static void CurrentCountOfMessages()
        {
            RealDataBase db = RealDataBase.Instance;
            count = db.GetMessagesCount();
        }

        public Message(string to, string from, string title,string content)
        {
            this.to = to;
            this.from = from;
            this.title = title;
            this.content = content;
            this.messageId = ++count;
            this.date = DateTime.Now;
        }

        public Message(int messageID, string to, string from, string title, string content,DateTime date)
        {
            this.to = to;
            this.from = from;
            this.title = title;
            this.messageId = messageID;
            this.content = content;
            this.date = date;
        }

        public int MessageId
        {
            get { return messageId; }
        }

        public string To
        {
            get { return to; }
            set { to = value; }
        }

        public string From
        {
            get { return from; }
            set { from = value; }
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Content
        {
            get { return content; }
            set { content = value; }
        }

        public DateTime Date
        {
            get { return date; }
        }

        public override string ToString()
        {
            return "Sent at: " + this.date + "\n" + "From: " + this.from + "\nTitle: " + this.title + "\n" + this.content + "\n";
        }

    }
}
