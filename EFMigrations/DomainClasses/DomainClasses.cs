using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DomainClasses
  {
    public class TwitterRevenue
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public string Source { get; set; }
    }

    public class Alias : IValidatableObject
    {
      public Alias()
      {
        Tweets = new List<Tweet>();
      }
      public int Id { get; set; }
      [Required]
      public string Name { get; set; }
      public string NewProp { get; set; }
  
      [StringLength(10)]
      public string Experience { get; set; }

      [Range(1,5)]
      public int Rating { get; set; }

      [StringLength(30, MinimumLength=5)]
      public string UserName { get; set; }

      [RegularExpression(@"(\w[-._\w]*\w@\w[-._\w]*\w\.\w{2,3})")]
      public string Email { get; set; }


      public string Bio { get; set; }
      public DateTime CreateDate { get; set; }
      public byte[] Avatar { get; set; }
      public ICollection<Tweet> Tweets { get; set; }

      [Timestamp]
      public byte[] RowVersion { get; set; }

      public string AliasPlusName
      { get { return Name + "(" + UserName + ")"; } }


      public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
      {
        if (Name == Email)
        {
          yield return new ValidationResult
           ("Alias name cannot match email",
             new[] { "Name", "Email" });
        }
      }
    }

    public class Tweet
    {
      public int Id { get; set; }
      public DateTime CreateDate { get; set; }
      public string Content { get; set; }
      public Alias Alias { get; set; }
      public int AliasId { get; set; }
    }

  }


