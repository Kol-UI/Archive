using System;
using System.Collections.Generic;

namespace Trees
{
    public class Chapter{
        public int ChapterID { get; set; }
        public string ChapterName { get; set; }
        public int Points { get; set; }

        public static List<Chapter> GetAllChaptersLegions()
        {
            return new List<Chapter>()
            {
                new Chapter(){ ChapterID = 1, ChapterName = "Dark Angels", Points = 0} ,
                new Chapter(){ ChapterID = 2, ChapterName = "Ultramarines", Points = 0} ,
                new Chapter(){ ChapterID = 3, ChapterName = "Blood Angels", Points = 0} ,
                new Chapter(){ ChapterID = 4, ChapterName = "Iron Hands", Points = 0} ,
                new Chapter(){ ChapterID = 5, ChapterName = "Imperial Fists", Points = 0} ,
                new Chapter(){ ChapterID = 6, ChapterName = "Raven Guard", Points = 0} ,
                new Chapter(){ ChapterID = 7, ChapterName = "Salamanders", Points = 0} ,
                new Chapter(){ ChapterID = 8, ChapterName = "Space Wolves", Points = 0} ,
                new Chapter(){ ChapterID = 9, ChapterName = "White Scars", Points = 0} ,
            };
        }

        public static List<Chapter> GetAllDarkAngelsSucessors()
        {
            return new List<Chapter>()
            {
                new Chapter(){ ChapterID = 1, ChapterName = "DarkAngelsSucessor1", Points = 0} ,
                new Chapter(){ ChapterID = 2, ChapterName = "DarkAngelsSucessor2", Points = 0} ,
            };
        }

        public static List<Chapter> GetAllUltramarinesSucessors()
        {
            return new List<Chapter>()
            {
                new Chapter(){ ChapterID = 1, ChapterName = "UltramarinesSucessor1", Points = 0} ,
                new Chapter(){ ChapterID = 2, ChapterName = "UltramarinesSucessor2", Points = 0} ,
            };
        }

        public static List<Chapter> GetAllBloodAngelsSucessors()
        {
            return new List<Chapter>()
            {
                new Chapter(){ ChapterID = 1, ChapterName = "BloodAngelsSucessor1", Points = 0} ,
                new Chapter(){ ChapterID = 2, ChapterName = "BloodAngelsSucessor2", Points = 0} ,
            };
        }

        public static List<Chapter> GetAllIronHandsSucessors()
        {
            return new List<Chapter>()
            {
                new Chapter(){ ChapterID = 1, ChapterName = "IronHandsSucessor1", Points = 0} ,
                new Chapter(){ ChapterID = 2, ChapterName = "IronHandsSucessor2", Points = 0} ,
            };
        }

        public static List<Chapter> GetAllImperialFistsSucessors()
        {
            return new List<Chapter>()
            {
                new Chapter(){ ChapterID = 1, ChapterName = "ImperialFistsSucessor1", Points = 0} ,
                new Chapter(){ ChapterID = 2, ChapterName = "ImperialFistsSucessor2", Points = 0} ,
            };
        }

        public static List<Chapter> GetAllRavenGuardSucessors()
        {
            return new List<Chapter>()
            {
                new Chapter(){ ChapterID = 1, ChapterName = "RavenGuardSucessor1", Points = 0} ,
                new Chapter(){ ChapterID = 2, ChapterName = "RavenGuardSucessor2", Points = 0} ,
            };
        }

        public static List<Chapter> GetAllSalamandersSucessors()
        {
            return new List<Chapter>()
            {
                new Chapter(){ ChapterID = 1, ChapterName = "SalamandersSucessor1", Points = 0} ,
                new Chapter(){ ChapterID = 2, ChapterName = "SalamandersSucessor2", Points = 0} ,
            };
        }

        public static List<Chapter> GetAllSpaceWolvesSucessors()
        {
            return new List<Chapter>()
            {
                new Chapter(){ ChapterID = 1, ChapterName = "SpaceWolvesSucessor1", Points = 0} ,
                new Chapter(){ ChapterID = 2, ChapterName = "SpaceWolvesSucessor2", Points = 0} ,
            };
        }

        public static List<Chapter> GetAllWhiteScarsSucessors()
        {
            return new List<Chapter>()
            {
                new Chapter(){ ChapterID = 1, ChapterName = "WhiteScarsSucessor1", Points = 0} ,
                new Chapter(){ ChapterID = 2, ChapterName = "WhiteScarsSucessor2", Points = 0} ,
            };
        }

        public static List<Chapter> GetAllUnknownSucessors()
        {
            return new List<Chapter>()
            {
                new Chapter(){ ChapterID = 1, ChapterName = "UnknownSucessor1", Points = 0} ,
                new Chapter(){ ChapterID = 2, ChapterName = "UnknownSucessor2", Points = 0} ,
            };
        }

        public static List<Chapter> GetAllSpecificSucessors()
        {
            return new List<Chapter>()
            {
                new Chapter(){ ChapterID = 1, ChapterName = "SpecificSucessor1", Points = 0} ,
                new Chapter(){ ChapterID = 2, ChapterName = "SpecificSucessor2", Points = 0} ,
            };
        }

        public static List<Chapter> GetAllHomebrewDarkAngelsSucessors()
        {
            return new List<Chapter>()
            {
                new Chapter(){ ChapterID = 1, ChapterName = "HomebrewDarkAngelsSucessor1", Points = 0} ,
                new Chapter(){ ChapterID = 2, ChapterName = "HomebrewDarkAngelsSucessor2", Points = 0} ,
            };
        }

        public static List<Chapter> GetAllHomebrewUltramarinesSucessors()
        {
            return new List<Chapter>()
            {
                new Chapter(){ ChapterID = 1, ChapterName = "HomebrewUltramarinesSucessor1", Points = 0} ,
                new Chapter(){ ChapterID = 2, ChapterName = "HomebrewUltramarinesSucessor2", Points = 0} ,
            };
        }

        public static List<Chapter> GetAllHomebrewBloodAngelsSucessors()
        {
            return new List<Chapter>()
            {
                new Chapter(){ ChapterID = 1, ChapterName = "HomebrewBloodAngelsSucessor1", Points = 0} ,
                new Chapter(){ ChapterID = 2, ChapterName = "HomebrewBloodAngelsSucessor2", Points = 0} ,
            };
        }

        public static List<Chapter> GetAllHomebrewIronHandsSucessors()
        {
            return new List<Chapter>()
            {
                new Chapter(){ ChapterID = 1, ChapterName = "HomebrewIronHandsSucessor1", Points = 0} ,
                new Chapter(){ ChapterID = 2, ChapterName = "HomebrewIronHandsSucessor2", Points = 0} ,
            };
        }

        public static List<Chapter> GetAllHomebrewImperialFistsSucessors()
        {
            return new List<Chapter>()
            {
                new Chapter(){ ChapterID = 1, ChapterName = "HomebrewImperialFistsSucessor1", Points = 0} ,
                new Chapter(){ ChapterID = 2, ChapterName = "HomebrewImperialFistsSucessor2", Points = 0} ,
            };
        }

        public static List<Chapter> GetAllHomebrewRavenGuardSucessors()
        {
            return new List<Chapter>()
            {
                new Chapter(){ ChapterID = 1, ChapterName = "HomebrewRavenGuardSucessor1", Points = 0} ,
                new Chapter(){ ChapterID = 2, ChapterName = "HomebrewRavenGuardSucessor2", Points = 0} ,
            };
        }

        public static List<Chapter> GetAllHomebrewSalamandersSucessors()
        {
            return new List<Chapter>()
            {
                new Chapter(){ ChapterID = 1, ChapterName = "HomebrewSalamandersSucessor1", Points = 0} ,
                new Chapter(){ ChapterID = 2, ChapterName = "HomebrewSalamandersSucessor2", Points = 0} ,
            };
        }

        public static List<Chapter> GetAllHomebrewSpaceWolvesSucessors()
        {
            return new List<Chapter>()
            {
                new Chapter(){ ChapterID = 1, ChapterName = "HomebrewSpaceWolvesSucessor1", Points = 0} ,
                new Chapter(){ ChapterID = 2, ChapterName = "HomebrewSpaceWolvesSucessor2", Points = 0} ,
            };
        }

        public static List<Chapter> GetAllHomebrewWhiteScarsSucessors()
        {
            return new List<Chapter>()
            {
                new Chapter(){ ChapterID = 1, ChapterName = "HomebrewWhiteScarsSucessor1", Points = 0} ,
                new Chapter(){ ChapterID = 2, ChapterName = "HomebrewWhiteScarsSucessor2", Points = 0} ,
            };
        }

        public static List<Chapter> GetAllHomebrewUnknownSucessors()
        {
            return new List<Chapter>()
            {
                new Chapter(){ ChapterID = 1, ChapterName = "HomebrewUnknownSucessor1", Points = 0} ,
                new Chapter(){ ChapterID = 2, ChapterName = "HomebrewUnknownSucessor2", Points = 0} ,
            };
        }

        public static List<Chapter> GetAllHomebrewSpecificSucessors()
        {
            return new List<Chapter>()
            {
                new Chapter(){ ChapterID = 1, ChapterName = "HomebrewSpecificSucessor1", Points = 0} ,
                new Chapter(){ ChapterID = 2, ChapterName = "HomebrewSpecificSucessor2", Points = 0} ,
            };
        }
    }
    
}