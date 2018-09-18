﻿using UnityEngine;
using System;

namespace EnergySuite
{
    public class TimeServer
    {
        const string LastClosedTimeKey = "LastClosedTime";

        public TimeServer()
        {
            ZPlayerPrefs.Initialize(EnergySuiteConfig.Password, EnergySuiteConfig.PasswordSalt);
        }

        public void SetLastClosedTime()
        {
            SetLastClosedTimeHandle();
        }

        public long GetLastClosedTime()
        {
            return GetLastClosedTimeHandle();
        }

        void SetLastClosedTimeHandle()
        {
            ZPlayerPrefs.SetString(LastClosedTimeKey, EnergySuiteBehaviour.CurrentTimeSec.ToString());
        }

        long GetLastClosedTimeHandle()
        {
            string timeString = ZPlayerPrefs.GetString(LastClosedTimeKey, EnergySuiteBehaviour.CurrentTimeSec.ToString());
            return (long)Convert.ToDouble(timeString);
        }
    }
}
