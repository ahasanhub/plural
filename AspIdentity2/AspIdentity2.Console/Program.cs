using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace AspIdentity2.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName = "shobuz@yahoo.com";
            string pass = "123456";
            var userStore=new UserStore<IdentityUser>();
            var userManager=new UserManager<IdentityUser>(userStore);
            //var creationResult = userManager.Create(new IdentityUser(userName), pass);
            //System.Console.WriteLine($"Created: {creationResult.Succeeded}");
            var user=userManager.FindByName(userName);
            //var claimResult=userManager.AddClaim(user.Id, new Claim("given_name", "ahasan"));
            //System.Console.WriteLine($"Claim: {claimResult.Succeeded}");
            var result=userManager.CheckPassword(user, pass);
            System.Console.WriteLine($"Check Password: {result}");
            System.Console.ReadKey();
        }
    }
}
