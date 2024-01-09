using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CustomerApi.Models.DataBase
{
  [Table("Customer", Schema = "dbo")]
  public partial class Customer
  {
    [Key]
    public int Id
    {
      get;
      set;
    }

    [Column("First Name")]
    public required string FirstName
    {
      get;
      set;
    }

    [Column("Last Name")]
    public required string LastName
    {
      get;
      set;
    }
    public required string Email
    {
      get;
      set;
    }

    [Column("Created Date")]
    public DateTime CreatedDate
    {
      get;
      set;
    }

    [Column("Last Updated")]
    public DateTime LastUpdated
    {
      get;
      set;
    }
  }
}
