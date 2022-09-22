using System;
using Xamarin.Essentials;

namespace LongoToDo
{
    public static class Constants
    {
        public static string ApiUrl = DeviceInfo.Platform == DevicePlatform.Android ? "http://10.0.2.2:8080/" : "http://localhost:8080/";

    }
}

