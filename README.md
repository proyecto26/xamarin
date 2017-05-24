# Xamarin

# Structure
Each type of project has its own structure:

* ## Xamarin Forms Project Structure (Cross-platform)
Path                           | Explanation
--------------- | -------------
`./App.xaml`    | Global resources in the app.
`./App.xaml.cs` | Extend the app.

* ## Android Project Structure
Path                           | Explanation
------------------------------ | -------------
`./MainActivity.cs`            | Main Class.
`./Resources/layout/Main.axml` | Graphic Interface using XAML.
`./Components`                 | Add new features and third-party services.

* ## iOS Project Structure
Path                        | Explanation
--------------------------- | -------------
`./ViewController.cs`       | Main Class. We can configure alerts about Memory, Storage, etc.
`./Main.storyboard`         | Create screens like default.
`./LaunchScreen.storyboard` | Boot screen.
`./Info.plist`              | Permissions.
`./AppDelegate.cs`          | Validate the status of the application to know when the application is active, running or finished.
`./Components`              | Add new features and third-party services.

# Sharing Code
There are some strategies for sharing code between platforms:
* **Shared Asset Project (SAP)**: Files and source code that are combined at compile time.
* **Portable Class Library (PCL)**: A **DLL** library that encapsulates common code and can be referenced from other projects.

# XAML
The design of the views is usually developed in XAML:
```xaml
<ContentPage xmlns="..." xmlns:x="..." x:Class="App.MainPage" Title="My App">
  <Label Text="Hello World!" VerticalOptions="Center" HorizontalOptions="Center" FontSize="Large">
    <OnPlatform x:TypeArguments="Text"
                iOS="Hello iOS World!"
                Android="Hello Android World!"
                WinPhone="Hello Windows World!" />
  </Label>
</ContentPage>
```
Also you can modify the views from classes:
```csharp
if(Device.OS == TargetPlatform.iOS){
  label.Text = "Hello iOS World!";
}
```

# Tips

## Remote Login for Mac

- Enable **Remote Login** option on Mac:

  **System Preferences** => **Sharing** => **Remote Login** (Configure access)

- Connect to Mac:
  
  **Visual Studio** => **Tools** => **Options** => **Xamarin** => **iOS Settings** => **Find Xamarin Mac Agent**
  
> **Note:** A **SSH key** will be created and registered in the file **authorized_keys** on the **Mac**.

# Happy coding
Made with <3

<img width="150px" src="http://phaser.azurewebsites.net/assets/nicholls.png" align="right">
