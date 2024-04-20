namespace dyrmyshi.leo._5h.ECommerce.Models;
using Microsoft.EntityFrameworkCore;

public class CreateDbContext : DbContext
{
    public DbSet<Utente> Utenti { get; set; }
}
