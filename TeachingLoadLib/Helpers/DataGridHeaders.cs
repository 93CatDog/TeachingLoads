using System;
using System.Collections.Generic;
using System.Text;

namespace TeachingLoadLib.Helpers
{
    internal static class DataGridHeaders
    {
        public static List<String> DisciplinesHeaders;
        public static List<String> GroupsHeaders;
        public static List<String> TeachersHeaders;

        static DataGridHeaders()
        {
            DisciplinesHeaders = new List<string>();
            GroupsHeaders = new List<string>();
            TeachersHeaders = new List<string>();
        }
    }
}
