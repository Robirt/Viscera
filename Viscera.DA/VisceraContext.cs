namespace Viscera.DA;

using Microsoft.EntityFrameworkCore;

public class VisceraContext : DbContext
{
    public VisceraContext(DbContextOptions<VisceraContext> options) : base(options)
    {

    }
}
