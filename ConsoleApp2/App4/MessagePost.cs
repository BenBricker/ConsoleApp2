using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    ///<summary>
    /// This class stores information about a post in a social network. 
    /// The main part of the post consists of a (possibly multi-line)
    /// text message. Other data, such as author and time, are also stored.
    /// </summary>
    /// <author>
    /// Ben Bricker
    /// version 0.1
    /// </author>
    public class MessagePost : Post
    {
        private int likes;

        private readonly List<String> comments;

        ///<summary>
        /// an arbitrarily long, multi-line message.
        ///</summary>
        public String Message { get; }

        /// <summary>
        /// Constructor for objects of class MessagePost.
        /// </summary>
        /// <param name="author">
        /// The username of the author of this post.
        /// </param>
        /// <param name="text">
        /// The text of this post.
        /// </param>
        public MessagePost(String author, String text): base(author) 
        {
            Message = text;
            
        }
       
        ///<summary>
        /// Display the details of this post.
        /// 
        /// (Currently: Print to the text terminal. This is simulating display 
        /// in a web browser for now.)
        ///</summary>
        public override void Display()
        {
            Console.WriteLine();
            Console.WriteLine($"    Author: {Username}");
            Console.WriteLine($"    Message: {Message}");

            ///<summary>
            /// Call base class display.
            ///</summary>
            base.Display();
        }  
    }
}
