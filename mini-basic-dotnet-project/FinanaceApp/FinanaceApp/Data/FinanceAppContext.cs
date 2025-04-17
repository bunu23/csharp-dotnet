using FinanaceApp.Models;
using Microsoft.EntityFrameworkCore;


public class FinanceAppContext : DbContext
{

    public FinanceAppContext(DbContextOptions<FinanceAppContext> options) : base(options) { }

    public DbSet<Expense> Expenses { get; set; } = null!;
}