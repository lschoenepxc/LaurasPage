using LaurasPage.DataAccess.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LaurasPage.DataAccess
{
    public interface IForecastData
    {
        Task<List<ForecastModel>> GetForecasts();
        Task InsertForecast(ForecastModel forecast);
    }
}