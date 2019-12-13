using System.Data.Entity.Core.Mapping;
using Database;
using Models.Calendar;

namespace UABot.Services
{
    public class CalenderService
    {
        private IDataBaseService _databaseService;

        public CalenderService(IDataBaseService dataBaseService)
        {
            _databaseService = dataBaseService;
        }

        public void CreateCalendarRaidEvent(CreateCalendarDto calendarDto)
        {
            var raid = new Raid();

            // map calender to raid

            _databaseService.CreateRaid(raid);
        }
    }
}
