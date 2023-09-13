using System;
using System.Collections.Generic;
using System.Text;

namespace Dailyapp.Logic
{
    public class ActiviDaily
    {
        public int DailyId { get; set; }
        public string DailyName { get; set; }
        public string DailyDate { get; set; }
        public string DailyTime { get; set; }
        public string DailyDescrip { get; set; }

        public ActiviDaily(int dailyId, string dailyName, string dailyDate, string dailyTime, string dailyDescrip)
        {
            DailyId = dailyId;
            DailyName = dailyName;
            DailyDate = dailyDate;
            DailyTime = dailyTime;
            DailyDescrip = dailyDescrip;
        }
    }
}
