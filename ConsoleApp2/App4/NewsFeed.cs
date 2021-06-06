using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    ///<summary>
    /// The NewsFeed class stores news posts for the news feed in a social network 
    /// application.
    /// 
    /// Display of the posts is currently simulated by printing the details to the
    /// terminal. (Later, this should display in a browser.)
    /// 
    /// This version does not save the data to disk, and it does not provide any
    /// search or ordering functions.
    ///</summary>
    ///<author>
    ///  Ben Bricker
    ///  version 0.1
    ///</author> 
    public class NewsFeed
    {
        private List<Post> posts { get; }
        public const string AUTHOR = "Paul";

        ///<summary>
        /// Construct an empty news feed.
        ///</summary>
        public NewsFeed()
        {
            posts = new List<Post>();
        }

        ///<summary>
        /// Add a text post to the news feed.
        /// 
        /// @param text  The text post to be added.
        ///</summary>
        public void AddMessagePost(MessagePost message)
        {
            posts.Add(message);
        }

        ///<summary>
        /// Add a photo post to the news feed.
        /// 
        /// @param photo  The photo post to be added.
        ///</summary>
        public void AddPhotoPost(PhotoPost photo)
        {
            posts.Add(photo);
        }

        ///<summary>
        /// Show the news feed. Currently: print the news feed details to the
        /// terminal. (To do: replace this later with display in web browser.)
        ///</summary>
        public void Display()
        {
            // display all posts
            foreach (Post post in posts)
            {
                post.Display();
                Console.WriteLine();   // empty line between posts
            }
        }

        ///<summary>
        /// Add a comment to a post
        ///</summary>
        public void AddComment(int postID, string comment)
        {
            foreach (Post post in posts)
            {
                if (postID == post.postID)
                {
                    post.AddComment(comment);
                }
            }
        }

        ///<summary>
        /// Likes a post.
        ///</summary>
        public void LikePost(int postID)
        {
            foreach (Post post in posts)
            {
                if (postID == post.postID)
                {
                    post.Like();
                }
            }
        }

        ///<summary>
        /// Dislikes a post.
        ///</summary>
        public void UnlikePost(int postID)
        {
            foreach (Post post in posts)
            {
                if (postID == post.postID)
                {
                    post.Unlike();
                }
            }
        }

        public int selectPost()
        {
            return; 
        }
    }
}
