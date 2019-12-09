using Microsoft.AspNetCore.Identity;
using System;

namespace WebApp1.Areas.Identity.Data
{
    public class WebApp1User : IdentityUser
    {
        //Watch out the name of the class NEEDS TO BE THE SAME AS THE NAME OF TEH PROJECT = WebApp1User = is referenced in usermanager
        //**************
        //private readonly UserManager<WebApp1User> _userManager;
        //private readonly SignInManager<WebApp1User> _signInManager;
        //private readonly IEmailSender _emailSender;

        //public IndexModel(
        //    UserManager<WebApp1User> userManager,
        //    SignInManager<WebApp1User> signInManager,
        //    IEmailSender emailSender)

        //*******************




        [PersonalData]
        public string Name { get; set; }
        [PersonalData]
        public DateTime DOB { get; set; }
        [PersonalData]
        public String City { get; set; }
        [PersonalData]
        public string Street { get; set; }
        [PersonalData]
        public int ZipCode { get; set; }
    }
}