using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp2;
namespace ConsoleAppProject.App01
{
    class NetworkApp
    {
        private NewsFeed newsFeed;
        private string username;
        public void displayMenu()
        { 
            int choice = 0;
            while(choice != 9)
            {
                ConsoleHelper.OutputText("1. Add a message post\n" +
                                         "2. Add a photo or image post\n" +
                                         "3. Display all posts\n" +
                                         "4. Display posts by date\n" +
                                         "5. Display posts by author\n" +
                                         "6. Remove a post\n" +
                                         "7. Add comments for a post\n" +
                                         "8. like unlike posts\n" +
                                         "9. unlike posts\n" +
                                         "10. select post\n" +
                                         "11. Quit\n");
                choice = ConsoleHelper.getMark(1, 11);
                if (choice == 1)
                {
                    postMessage();
                }
                else if (choice == 2)
                {
                    postImage();
                }
                else if (choice == 3)
                {
                    displayAll();
                }
                else if (choice == 4)
                {
                    displayByDate();
                }
                else if (choice == 5)
                {
                    displayByAuthor();
                }
                else if (choice == 6)
                {
                    removePost();
                }
                else if (choice == 7)
                {
                    addComment();
                }
                else if (choice == 8)
                {
                    likePosts();
                }
                else if (choice == 9)
                {
                    unlikePosts();
                }
                else if (choice == 10)
                {
                    selectPost();
                }
            }  
        }

        ///<summary>
        /// Method likes posts.
        ///</summary>
        private void likePosts()
        {
            bool like = false;
            ConsoleHelper.OutputText("Enter Post ID: ");
            int postID = ConsoleHelper.getMark(1, 10);
            newsFeed.LikePost(postID);
        }

        ///<summary>
        /// Method dislikes posts.
        ///</summary>
        private void unlikePosts()
        {
            bool like = false;
            ConsoleHelper.OutputText("Enter Post ID: ");
            int postID = ConsoleHelper.getMark(1, 10);
            newsFeed.UnlikePost(postID);
        }

        ///<summary>
        /// Method adds comments.
        ///</summary>
        private void addComment()
        {
            ConsoleHelper.OutputText("Enter Post ID: ");
            int postID = ConsoleHelper.getMark(1, 10);
            ConsoleHelper.OutputText("Enter Comment: ");
            string comment = ConsoleHelper.InputText();
            newsFeed.AddComment(postID, comment);
        }

        ///<summary>
        /// Method displays posts by date.
        ///</summary>
        private void displayByDate()
        {
            string date = ConsoleHelper.InputText();
            newsFeed.Display();
        }
        private void displayByAuthor()
        {

        }
        private void selectPost()
        {

        }
        private void removePost()
        {

        }

        ///<summary>
        /// Method displays all posts.
        ///</summary>
        private void displayAll()
        {
            newsFeed.Display();
        }

        ///<summary>
        /// Method posts images.
        ///</summary>
        private void postImage()
        {
            ConsoleHelper.OutputText("Enter an image to post: ");
            string photo = ConsoleHelper.InputText();
            PhotoPost photoPost = new PhotoPost(username, filename, caption);
            newsFeed.AddPhotoPost(photoPost);
        }

        ///<summary>
        /// Method posts messages.
        ///</summary>
        private void postMessage()
        {
            ConsoleHelper.OutputText("Enter a message to post: ");
            string message = ConsoleHelper.InputText();
            MessagePost messagePost = new MessagePost(username, message);
            newsFeed.AddMessagePost(messagePost);
        }

        ///<summary>
        /// Method inputs name.
        ///</summary>
        private void inputName()
        {
            ConsoleHelper.OutputText("Enter a name: ");
            username = ConsoleHelper.InputText();
        }

        ///<summary>
        /// Method runs application.
        ///</summary>
        public void run()
        {
            ConsoleHelper.OutputText("---------------\n" +
                                    "    Network    \n" +
                                    "By Ben Bricker \n" +
                                    "---------------\n");
            inputName();
            newsFeed = new NewsFeed();
            displayMenu();
        }
    }
}
