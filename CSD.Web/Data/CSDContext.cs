using Microsoft.EntityFrameworkCore;

namespace CSD.Web.Data;

public class CSDContext : DbContext
{
    public CSDContext(DbContextOptions options) : base(options)
    {

    }
}

