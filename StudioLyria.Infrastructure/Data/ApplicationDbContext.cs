using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace StudioLyria.Web.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext(options)
{
}
