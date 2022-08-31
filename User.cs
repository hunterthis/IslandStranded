using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography; // secures the password

namespace IslandStranded;

public class User
{
    public const string CREAM = "User"; // used to hash

    public User() // EFCore needs this empty constructor
    {

    }
    public User(string username, string passwordHash, int currentStoryEvent)
    {

        UserName = username;
        Password = GenerateSha256Hash(passwordHash, CREAM); // Hashes the users password for security.
        CurrentStoryEventValue = currentStoryEvent;
    }

    [Key]
    public int Id { get; set; }

    [Required]



    public string UserName { get; set; } // must match what is in the database collumn names. Or waste a ton of time. It will not work.

    [Required]
    public string Password { get; set; }

    [Required] // need to make default value 0
    public int CurrentStoryEventValue { get; set; } // int always defaults to zero

    public static string GenerateSha256Hash(string input, string cream)
    {
        byte[] bytes = System.Text.Encoding.UTF8.GetBytes(input + cream);
        var shaString = SHA256.Create();
        byte[] hash = shaString.ComputeHash(bytes);

        return BitConverter.ToString(hash);
    }

}