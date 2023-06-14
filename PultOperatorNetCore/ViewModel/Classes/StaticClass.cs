using PultOperatorNetCore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PultOperatorNetCore.ViewModel.Classes
{
    public static class StaticClass
    {
        public static string? IpAddress { get; set; }
        public static int WindowNumber { get; set; }
        public static bool IsCheck { get; set; }
        public static string Login { get; set; }
        public static IEnumerable<Options>? Options { get; set; }
        public static User? user {get;set;}
        public delegate void ButtonStyle();
        public static event ButtonStyle styleMethod;
        public static event ButtonStyle styleEndMethod;
        public static void EventMethod()
        {
            styleMethod();
        }
        public static void EventStyleEndMethod()
        {
            styleEndMethod();
        }
    }
}
