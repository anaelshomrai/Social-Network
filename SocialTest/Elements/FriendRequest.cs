using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Social_Network
{
    class FriendRequest
    {
        private string sentFrom;
        private string sentTo;
        private DateTime date;

        public FriendRequest(string sentFrom, string sentTo)
        {
            this.sentFrom = sentFrom;
            this.sentTo = sentTo;
            this.date = DateTime.Now;
        }

        public FriendRequest(string sentFrom, string sentTo, DateTime date)
        {
            this.sentFrom = sentFrom;
            this.sentTo = sentTo;
            this.date = date;
        }

        public string SentFrom
        {
            get { return sentFrom; }
            set { sentFrom = value; }
        }

        public string SentTo
        {
            get { return sentTo; }
            set { sentTo = value; }
        }

        public DateTime Date
        {
            get { return date; }
        }

        public override string ToString()
        {
            return "Friend Request from " + this.sentFrom + " at " + date;
        }
    }
}
