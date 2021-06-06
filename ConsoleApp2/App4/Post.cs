using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
	public class Post
	{
		public int postID;

		///<summary>
		/// username of the post's author
		/// [StringLength(20), Required]
		///</summary>
		public string Username;
		
		public DateTime Timestamp;
		private static int instances;
		private static int nextPostID = 1;
		private int likes;
		private List<String> comments;

		public Post(String author)
		{
			instances += 1;
			postID = nextPostID;
			nextPostID += 1;
			Username = author;
			Timestamp = DateTime.Now;

			likes = 0;
			comments = new List<String>();
		}

		///<summary>
		/// Record one more 'Like' indication from a user.
		///</summary>
		public void Like()
		{
			likes += 1;
		}

		///<summary>
		/// Record that a user has withdrawn his/her 'Like' vote.
		///</summary>
		public void Unlike()
		{
			if (likes > 0)
			{
				likes-= 1;
			}
		}

		///<summary>
		/// Add a comment to this post.
		/// </summary>
		/// <param name="text">
		/// The new comment to add.
		/// </param> 
		public void AddComment(String text)
		{
			comments.Add(text);
		}

		///<summary>
		/// Displays a post's details.
		///</summary>
		public virtual void Display()
		{
			Console.WriteLine("Post ID is: " + postID);

			if (likes > 0)
			{
				Console.WriteLine($"    Likes: -  {likes}  people like this.");
			}
			else
			{
				Console.WriteLine();
			}

			if (comments.Count == 0)
			{
				Console.WriteLine("    No comments.");
			}
			else
			{
				Console.WriteLine($"    Comment(s): {comments.Count}");
				int commentID = 1;
				foreach (string comment in comments)
                {
					Console.WriteLine("Comment " + commentID + " : " + comment);
                }
			}
		}

		///<summary>
		/// Create a string describing a time point in the past in terms 
		/// relative to current time, such as "30 seconds ago" or "7 minutes ago".
		/// Currently, only seconds and minutes are used for the string.
		/// </summary>
		/// <param name="time">
		///  The time value to convert (in system milliseconds)
		/// </param> 
		/// <returns>
		/// A relative time string for the given time
		/// </returns>      
		public String FormatElapsedTime(DateTime time)
		{
			DateTime current = DateTime.Now;
			TimeSpan timePast = current - time;

			long seconds = (long)timePast.TotalSeconds;
			long minutes = seconds / 60;

			if (minutes > 0)
			{
				return minutes + " minutes ago";
			}
			else
			{
				return seconds + " seconds ago";
			}
		}
		
		public static int GetNumberOfPosts()
		{
			return instances;
		}
	}
}
