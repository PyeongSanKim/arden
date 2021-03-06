﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class curTime : MonoBehaviour
{
    void Start()
    {
        System.DateTime.Now.ToString("yyyy");

        System.DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss");

        /* 예 */
        System.DateTime.Now.ToString("yyyy");
        // 2012년

        System.DateTime.Now.ToString("MM");
        // 10월

        System.DateTime.Now.ToString("dd");
        // 15일

        System.DateTime.Now.ToString("hh");
        // 15시

        System.DateTime.Now.ToString("yyyyMMdd");
        // 2012년 10월 15일

        System.DateTime.Now.ToString("HHmmss");
        //15시 02분 00초

        //Debug.Log(System.DateTime.Now.ToString("yyyy-MM-dd"));

        System.DateTime StartDate = System.Convert.ToDateTime("2019/03/01 08:00"); // 시작시간
        System.TimeSpan timeCal = System.DateTime.Now - StartDate; // 시간차 계산

        int timeCalDay = timeCal.Days;//날짜 차이
        int timeCalHour = timeCal.Hours; //시간차이
        int timeCalMinute = timeCal.Minutes;// 분 차이

        Debug.Log("날짜 차 " + timeCalDay);
        Debug.Log("시간 차 " + timeCalHour);
        Debug.Log("분 차 " + timeCalMinute);
    }
}
