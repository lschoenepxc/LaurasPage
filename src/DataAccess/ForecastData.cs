using LaurasPage.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LaurasPage.DataAccess
{
    public class ForecastData : IForecastData
    {
        private readonly ISqlDataAccess _db;

        public ForecastData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<List<ForecastModel>> GetForecasts()
        {
            //string sql = "select top 5 * from dbo.forecast";
            //string sql = "select* from dbo.forecast order by id desc limit 5;";
            string sql = "SELECT top 5 * FROM dbo.forecast Order By id DESC";

            return _db.LoadData<ForecastModel, dynamic>(sql, new { });
        }

        public Task InsertForecast(ForecastModel forecast)
        {
            string sql = @"insert into dbo.forecast (Bz, Density, Speed, Kp1Hour, Kp4Hour, Kp, colourBz, colourDensity, colourSpeed, colourKp1Hour, colourKp4Hour, colourKp)
                           values (@Bz, @Density, @Speed, @Kp1Hour, @Kp4Hour, @Kp, @colourBz, @colourDensity, @colourSpeed, @colourKp1Hour, @colourKp4Hour, @colourKp);";

            return _db.SaveData(sql, forecast);
        }
    }
}
