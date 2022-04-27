using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    public static class Settings// não sao passiveis de serem construidas por ja tem seu valor estabelecido na delaracao
    {
        public static string API_URL { get; set; }
    
    }
}