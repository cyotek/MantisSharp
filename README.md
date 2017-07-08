MantisSharp
===========

MantisSharp is a .NET client for the [Mantis Bug Tracker](https://mantisbt.org/) REST API.

> Important! This project is very much at the "Work In Progress" stage. You probably don't want to rely on it for anything important. Contributions welcome!

## Installation

> You need to enable pre-release in order to see this package from the NuGet package manager

    install-package MantisSharp -IncludePrerelease
    
The package currently includes .NET 3.5, 4.0, 4.5 and 4.6 binaries. I was going to include 4.7 until I realised I'd defered the Creators Content update and Microsoft won't let you target 4.7 without upgrading. And I definitely want to include .NET Standard support but I'll need to fumble around a bit more first.

If you just want to use the source, `MantisSharp.sln` can be opened using Visual Studio 2017, `MantisSharp.csproj` is using the new format and does all the multi-targeting and the Nuget packing. `MantisSharp_vs2015.sln` uses the slightly more old school format and can be opened using Visual Studio 2015. All projects with a `_vs2015` suffix are for development purposes only and shouldn't be used to create release binaries.

## Requirements

MantisSharp is currently self contained and doesn't depend on any third party libraries - ideally I'd like to keep it that way, even if it does require some wheel re-inventing.

To use the client, you're going to need a Mantis installation with the REST API enabled (it is disabled by default). In addition, you're going to need to have created a token for use with the API. I'd recommend creating a dedicated "restuser" type of account with no write permissions. Impersonate that user, generate a token to use, then switch by to an admin account and protect the user.

The REST client was introduced into MantisBT in version 2.3, however I have only tested using 2.5.1 (at the time of writing, this is the current version).

## Limitations

At this stage of the libraries existence, there are plenty of limitations - see the **Todo** section below for details.

The REST API offered by MantisBT is bit limited at the moment. It doesn't provide access to all information, and while you can create or delete issues (neither of which are offered by this library at the current time), you cannot update issues.

## Usage

First you need to create a `MantisClient` object and pass in the base URI where your MantisBT installation is hosted, along with an API key.

    MantisClient client = new MantisClient("YOUR_MANTIS_URI", "YOUR_API_KEY");
    
### Listing Projects

The `GetProjects` method will return the projects available to the API user

    foreach (Project project in client.GetProjects())
    {
      Console.WriteLine(project.Name);
    }
    
### Listing Issues

The `GetIssues` method returns issues. You can return all issues, or pass in project information to filter by project.

    foreach (Issue issue in client.GetIssues())
    {
      Console.WriteLine(issue.Summary);
    }
    
Or, you can grab issues for a specific project

    var issues = client.GetIssues(4); // or pass in a Project reference
    
> There are also overloads which let you page results, but given there doesn't seem to be a simple way to get an upfront count this functionality is a little useless right now
    
You can also grab a single issue

    Issue issue = client.GetIssue(52);

### User Accounts

Currently the only supported feature of the MantisBT REST API is to return details of the user associated with the API token.

    User user = client.GetCurrentUser();
    
## Todo

[ ] Documentation  
[ ] Async support
[ ] Use something a *little* more modern than `HttpWebRequest`
[ ] .NET Standard support  
[ ] Ability to write back to MantisBT  
[ ] Caching  
[ ] Add .NET 4.7 target  
[ ] Figure out Nuget woes  
[ ] Tests  
[ ] Thread safety  
[ ] Performance  
[ ] Finalize API  
[ ] Rework serialization to be lessy hacky  
[ ] Error handling - asking for issues that don't exist for example  

## Credits

* Uses Topten Software's utterly awesome [PetaJson](https://github.com/toptensoftware/PetaJson) in a not so awesome fashion.

## Further Reading

* <https://www.cyotek.com/blog/restoring-missing-authorization-header-when-using-php>