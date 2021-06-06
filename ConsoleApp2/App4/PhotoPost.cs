using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    ///<summary>
    /// This class stores information about a post in a social network. 
    /// The main part of the post consists of a photo and a caption. 
    /// Other data, such as author and time, are also stored.
    ///</summary>
    /// <author>
    /// Ben Bricker
    /// @version 0.1
    /// </author>
    public class PhotoPost : Post
    {
        public PhotoPost(String author, String filename, String caption) :base(author)
        {
            this.Filename = filename;
            this.Caption = caption;
        }

        ///<summary>
        /// Name of image file.
        ///</summary>
        public String Filename { get; set; }

        ///<summary>
        /// A one line image caption.
        ///</summary>
        public String Caption { get; set; }

        private readonly List<String> comments;

        ///<summary>
        /// Constructor for objects of class PhotoPost.
        ///</summary>
        /// <param name="author">
        /// The username of the author of this post.
        /// </param>
        /// <param name="caption">
        /// A caption for the image.
        /// </param>
        /// <param name="filename">
        /// The filename of the image in this post.
        /// </param>

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
            Console.WriteLine($"    Filename: [{Filename}]");
            Console.WriteLine($"    Caption: {Caption}");
            Console.WriteLine($"    Time Elpased: {FormatElapsedTime(Timestamp)}");
            Console.WriteLine();

            ///<summary>
            /// Call base class display
            ///</summary>
            base.Display(); 
        }


       
    }
}
