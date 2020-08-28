using System;

namespace Post
{
    class Program
    {
        static void Main(string[] args)
        {
            var post = new Post("test", "this is a test post");
            post.Upvote();
            post.Upvote();
            post.Upvote();
            post.Downvote();
            post.Downvote();
            post.Downvote();
            post.Downvote();
            post.Downvote();
            Console.WriteLine($"Current votes: {post.GetVoteValue()}");
        }
    }
}
