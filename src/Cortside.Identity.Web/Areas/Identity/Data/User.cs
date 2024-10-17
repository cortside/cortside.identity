using Microsoft.AspNetCore.Identity;

namespace Cortside.Identity.Web.Areas.Identity.Data;

/// <summary>
/// Add profile data for application users by adding properties to the User class
/// -- first, last, display, lastlogin, logincount, last login ip
///
///
///
///
/// https://learn.microsoft.com/en-us/aspnet/core/security/authentication/add-user-data?view=aspnetcore-8.0&tabs=net-cli
///
///
///
/// 
/// </summary>
public class User : IdentityUser {
    [PersonalData]
    public string FirstName { get; set; }
    [PersonalData]
    public string LastName { get; set; }
    [PersonalData]
    public string DisplayName { get; set; }
}
