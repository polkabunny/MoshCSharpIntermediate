using System;

namespace Post
{
    public class Post
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime PostDateTime { get; set; }
        private int _vote = 0;

        public Post() { }

        public Post(string title, string description)
        {
            Title = title;
            Description = description;
            PostDateTime = DateTime.Now;
        }

        public void Upvote()
        {
            _vote++;
        }

        public void Downvote()
        {
            _vote--;
        }

        public int GetVoteValue()
        {
            return _vote;
        }
    }
}
