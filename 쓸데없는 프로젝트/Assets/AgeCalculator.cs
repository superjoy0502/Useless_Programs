﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Globalization;
using UnityEngine.UI;

public class AgeCalculator : MonoBehaviour
{
    public double age = 0;
    public Text ageText;
    public int YearInput;
    public int MonthInput;
    public int DayInput;
    // 도연님 선물용 public DateTime BD = new DateTime(2004, 5, 19, 15, 30, 0);
    // mine public DateTime BD = new DateTime(2005, 10, 2, 11, 45, 0);
    // public DateTime BD = new DateTime(2004, 8, 19, 12, 30, 0);
    public DateTime BD = new DateTime(YearInput, 8, 19, 12, 30, 0);

    public static double ConvertToUnixTimestamp(DateTime date)
    {
        DateTime origin = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
        TimeSpan diff = date.ToUniversalTime() - origin;
        return Math.Floor(diff.TotalMilliseconds);
    }

    // Update is called once per frame
    public void Update()
    {
        DateTime localDate = DateTime.Now;
        double tempDate = ConvertToUnixTimestamp(localDate) - ConvertToUnixTimestamp(BD);
        age = tempDate / 31536000000;
        ageText.text = age.ToString();
        Debug.Log(age);
    }


}
