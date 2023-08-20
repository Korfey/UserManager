using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace UserManager.Areas.Identity.Data;

public class User: IdentityUser
{
    [Required]
    [Column(TypeName = "date")]
    public DateTime RegistrationDate { get; set; }

    [Required]
    [Column(TypeName = "date")]
    public DateTime LastLoginDate { get; set; }

    [Required]
    public bool IsActive { get; set; }
}

