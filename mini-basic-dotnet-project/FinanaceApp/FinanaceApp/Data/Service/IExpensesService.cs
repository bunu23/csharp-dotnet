using FinanaceApp.Models;
public interface IExpensesService

{
    Task<IEnumerable<Expense>> GetAll();

    Task Add(Expense expense);

    IQueryable GetChartData();

}