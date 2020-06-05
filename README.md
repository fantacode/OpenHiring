


# Open Hiring
Are you a recent graduate / a fresher looking for a job? Complete this task and Submit for a chance to get hired by Fantacode

## Goal

To develop a two-page Xamarin.Forms Application which evaluates your ability To
- Solve Problems
- Read the documentation and develop a solution
- When stuck, the ability to find answers from Google.
- Knowledge to use Git and GitHub.

The steps might be overwhelming as a beginner, but the idea is to search and find answers. 

A good to follow documentation is Microsoft's official guide. 
https://docs.microsoft.com/en-us/xamarin/get-started/

If you have no prior C# knowledge, start here
https://channel9.msdn.com/Series/CSharp-101

A quick intro to Xamarin Forms
https://channel9.msdn.com/Series/Xamarin-101

## What you should Do

 1. Install Git Tooling and Fork this Project 
https://help.github.com/en/github/getting-started-with-github/fork-a-repo
2.  Install Xamarin Tooling
https://docs.microsoft.com/en-us/xamarin/get-started/installation/
3. Fork and Clone the repo to your Computer
https://help.github.com/en/github/getting-started-with-github/fork-a-repo
4. In Submission Folder, create a new Xamarin Forms Solution.
https://docs.microsoft.com/en-us/xamarin/get-started/first-App

> We are building an App to display List of Todo Items using HTTP GET
> and Insert Todo Items using HTTP POST, Follow the below section to find out the API details

5.  Change the Contents of MainPage.xaml to support the following
	
 - [ ] Create a `CollectionView` to Show List of Todo Item
 https://docs.microsoft.com/en-us/xamarin/xamarin-forms/user-interface/collectionview/
 - [ ]  In Code Behind (MainPage.xaml.cs) Perform HTTP GET Request in `OnAppearing` override using HttpClient
 https://docs.microsoft.com/en-us/xamarin/xamarin-forms/data-cloud/web-services/rest
 https://www.youtube.com/watch?v=xkB-cIMjXGQ /
 - [ ] Parse the JSON Content using `Newtonsoft.Json` (For using Third-Party libraries, you will have to install Nuget Packages)
 - [ ] Display it in `CollectionView` by setting ItemsSource
6.  Add New ContentPage `AddTodo.xaml` to Add new Todo Items to the List
 - [ ] Use Input Field (Entry Field) and Button to Submit Item (Make sure to validate and handle cases like empty input and show related errors)
 https://docs.microsoft.com/en-us/xamarin/xamarin-forms/user-interface/text/entry
 https://docs.microsoft.com/en-us/xamarin/xamarin-forms/user-interface/button
 - [ ] Use HttpClient POST to Submit the data.
7. In MainPage.xaml add a button to Navigate to `AddTodo.xaml` https://docs.microsoft.com/en-us/xamarin/xamarin-forms/app-fundamentals/navigation/
8.  After completing the process, test your app, once you are happy with the result, commit your code, and push the code to your repo.
https://www.earthdatascience.org/workshops/intro-version-control-git/basic-git-commands/

It's completely normal to encounter multiple issues while attempting this challenge, there is a high chance that the problem you are looking for has an existing solution on the web. Try to find a solution from sources like Stack Overflow or Google, if you are unable to find the solution even after searching, you can contact us to get help. Feel free to open an issue in this repo.

## API Docs
You can refer Swagger to Test the API from Browser 
https://fctodo.azurewebsites.net/swagger/index.html

### GET
Url
 [https://fctodo.azurewebsites.net/todo](http://fctodo.azurewebsites.net/todo/index.html)
Returns List of Todo Items

 [
 {
 "id": 1,
 "name": "Hello, Drink Water"
 }
 ]

### POST
Url
 [https://fctodo.azurewebsites.net/todo](http://fctodo.azurewebsites.net/todo/index.html)
Request Body `Content-Type` should be `"application/json"`
Request Body to Send

 {
 "name": "My To-do Task"
 }
### Todo Object

 public class Todo
 {
 public int id { get; set; }
 public string name { get; set; }
 }

## Sample Screenshots


## Submission
Once you have completed the steps, please share the link of your fork `hr@fantacode.com`

**Note**
Feel free to design the User Interface in any way you like. Experiment and try fancy stuff, you'll get more points for good looking UI's. Feel free to find inspiration from the below links or platforms like Dribble.
https://github.com/jsuarezruiz/xamarin-forms-goodlooking-UI


