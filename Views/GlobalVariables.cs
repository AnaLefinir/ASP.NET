using System;
using System.Collections.Generic;

namespace TryMVC
{
    public static class GlobalVariables
    {
        public static List<TryMVC.Models.Character> Characters{ get; set; } 
                = new List<TryMVC.Models.Character>() ;
    }
}