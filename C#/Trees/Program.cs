using System;
using System.Collections.Generic;
using System.Linq;

namespace Trees
{
    public static class Program
    {
        static void Main()
        {
            int random = 0;
            bool endElim = false;
            int numberOfEncounter = 0;
            int returnedInt = 2;
            int value1 = 0;
            int value2 = 0;
            bool[] arrChapBool = new bool[24]; // False by default

            // Loading All
            // Chapters Legions
            List<Chapter> Legions = Chapter.GetAllChaptersLegions();
            // Chapters Sucessors
            List<Chapter> DarkAngelsSucessors = Chapter.GetAllDarkAngelsSucessors();
            List<Chapter> UltramarinesSucessors = Chapter.GetAllUltramarinesSucessors();
            List<Chapter> BloodAngelsSucessors = Chapter.GetAllBloodAngelsSucessors();
            List<Chapter> IronHandsSucessors = Chapter.GetAllIronHandsSucessors();
            List<Chapter> ImperialFistsSucessors = Chapter.GetAllImperialFistsSucessors();
            List<Chapter> RavenGuardSucessors = Chapter.GetAllRavenGuardSucessors();
            List<Chapter> SalamandersSucessors = Chapter.GetAllSalamandersSucessors();
            List<Chapter> SpaceWolvesSucessors = Chapter.GetAllSpaceWolvesSucessors();
            List<Chapter> WhiteScarsSucessors = Chapter.GetAllWhiteScarsSucessors();
            // Chapters Other
            List<Chapter> UnknownSucessors = Chapter.GetAllUnknownSucessors();
            List<Chapter> SpecificSucessors = Chapter.GetAllSpecificSucessors();
            // Homebrew Chapters Sucessors
            List<Chapter> HomebrewDarkAngelsSucessors = Chapter.GetAllHomebrewDarkAngelsSucessors();
            List<Chapter> HomebrewUltramarinesSucessors = Chapter.GetAllHomebrewUltramarinesSucessors();
            List<Chapter> HomebrewBloodAngelsSucessors = Chapter.GetAllHomebrewBloodAngelsSucessors();
            List<Chapter> HomebrewIronHandsSucessors = Chapter.GetAllHomebrewIronHandsSucessors();
            List<Chapter> HomebrewImperialFistsSucessors = Chapter.GetAllHomebrewImperialFistsSucessors();
            List<Chapter> HomebrewRavenGuardSucessors = Chapter.GetAllHomebrewRavenGuardSucessors();
            List<Chapter> HomebrewSalamandersSucessors = Chapter.GetAllHomebrewSalamandersSucessors();
            List<Chapter> HomebrewSpaceWolvesSucessors = Chapter.GetAllHomebrewSpaceWolvesSucessors();
            List<Chapter> HomebrewWhiteScarsSucessors = Chapter.GetAllHomebrewWhiteScarsSucessors();
            // Homebrew Other
            List<Chapter> HomebrewUnknownSucessors = Chapter.GetAllHomebrewUnknownSucessors();
            List<Chapter> HomebrewSpecificSucessors = Chapter.GetAllHomebrewSpecificSucessors();

            // Without Foundings:
            // Legions
            // Sucessor (x9)
            // Unknown Sucessor
            // Specific Sucessor
            // Homebrew Sucessor (x10)
            // Homebrew Unknown Sucessor
            // Homebrew Specific Sucessor

            // Shuffling Lists
            // Chapter Legion Shuffle
            Legions.ShuffleMe();
            // Sucessors Chapters Shuffle
            DarkAngelsSucessors.ShuffleMe();
            UltramarinesSucessors.ShuffleMe();
            BloodAngelsSucessors.ShuffleMe();
            IronHandsSucessors.ShuffleMe();
            ImperialFistsSucessors.ShuffleMe();
            RavenGuardSucessors.ShuffleMe();
            SalamandersSucessors.ShuffleMe();
            SpaceWolvesSucessors.ShuffleMe();
            WhiteScarsSucessors.ShuffleMe();
            // Sucessors Other
            UnknownSucessors.ShuffleMe();
            SpecificSucessors.ShuffleMe();
            // Homebrew Chapters Sucessors
            HomebrewDarkAngelsSucessors.ShuffleMe();
            HomebrewUltramarinesSucessors.ShuffleMe();
            HomebrewBloodAngelsSucessors.ShuffleMe();
            HomebrewIronHandsSucessors.ShuffleMe();
            HomebrewImperialFistsSucessors.ShuffleMe();
            HomebrewRavenGuardSucessors.ShuffleMe();
            HomebrewSalamandersSucessors.ShuffleMe();
            HomebrewSpaceWolvesSucessors.ShuffleMe();
            HomebrewWhiteScarsSucessors.ShuffleMe();
            // Homebrew Other
            HomebrewUnknownSucessors.ShuffleMe();
            HomebrewSpecificSucessors.ShuffleMe();


            // Main Loop
            while (!endElim)
            {
                if (arrChapBool[0] == false)
                {
                    if (Legions.Count > 1)
                    {
                        numberOfEncounter = GroupElim(random, Legions.Count, Legions, numberOfEncounter);
                    }
                    else
                    {
                        Console.WriteLine("--- NORMALY NB = 1 ---");
                        arrChapBool[0] = true;
                    }
                }

                if (arrChapBool[1] == false)
                {
                    if (DarkAngelsSucessors.Count > 1)
                    {
                        numberOfEncounter = GroupElim(random, DarkAngelsSucessors.Count, DarkAngelsSucessors, numberOfEncounter);
                    }
                    else
                    {
                        arrChapBool[1] = true;
                    }
                }

                if (arrChapBool[2] == false)
                {
                    if (UltramarinesSucessors.Count > 1)
                    {
                        numberOfEncounter = GroupElim(random, UltramarinesSucessors.Count, UltramarinesSucessors, numberOfEncounter);
                    }
                    else
                    {
                        arrChapBool[2] = true;
                    }
                }

                if (arrChapBool[3] == false)
                {
                    if (BloodAngelsSucessors.Count > 1)
                    {
                        numberOfEncounter = GroupElim(random, BloodAngelsSucessors.Count, BloodAngelsSucessors, numberOfEncounter);
                    }
                    else
                    {
                        arrChapBool[3] = true;
                    }
                }

                if (arrChapBool[4] == false)
                {
                    if (IronHandsSucessors.Count > 1)
                    {
                        numberOfEncounter = GroupElim(random, IronHandsSucessors.Count, IronHandsSucessors, numberOfEncounter);
                    }
                    else
                    {
                        arrChapBool[4] = true;
                    }
                }

                if (arrChapBool[5] == false)
                {
                    if (ImperialFistsSucessors.Count > 1)
                    {
                        numberOfEncounter = GroupElim(random, ImperialFistsSucessors.Count, ImperialFistsSucessors, numberOfEncounter);
                    }
                    else
                    {
                        arrChapBool[5] = true;
                    }
                }

                if (arrChapBool[6] == false)
                {
                    if (RavenGuardSucessors.Count > 1)
                    {
                        numberOfEncounter = GroupElim(random, RavenGuardSucessors.Count, RavenGuardSucessors, numberOfEncounter);
                    }
                    else
                    {
                        arrChapBool[6] = true;
                    }
                }

                if (arrChapBool[7] == false)
                {
                    if (SalamandersSucessors.Count > 1)
                    {
                        numberOfEncounter = GroupElim(random, SalamandersSucessors.Count, SalamandersSucessors, numberOfEncounter);
                    }
                    else
                    {
                        arrChapBool[7] = true;
                    }
                }

                if (arrChapBool[8] == false)
                {
                    if (SpaceWolvesSucessors.Count > 1)
                    {
                        numberOfEncounter = GroupElim(random, SpaceWolvesSucessors.Count, SpaceWolvesSucessors, numberOfEncounter);
                    }
                    else
                    {
                        arrChapBool[8] = true;
                    }
                }

                if (arrChapBool[9] == false)
                {
                    if (WhiteScarsSucessors.Count > 1)
                    {
                        numberOfEncounter = GroupElim(random, WhiteScarsSucessors.Count, WhiteScarsSucessors, numberOfEncounter);
                    }
                    else
                    {
                        arrChapBool[9] = true;
                    }
                }

                if (arrChapBool[10] == false)
                {
                    if (UnknownSucessors.Count > 1)
                    {
                        numberOfEncounter = GroupElim(random, UnknownSucessors.Count, UnknownSucessors, numberOfEncounter);
                    }
                    else
                    {
                        arrChapBool[10] = true;
                    }
                }

                if (arrChapBool[11] == false)
                {
                    if (SpecificSucessors.Count > 1)
                    {
                        numberOfEncounter = GroupElim(random, SpecificSucessors.Count, SpecificSucessors, numberOfEncounter);
                    }
                    else
                    {
                        arrChapBool[11] = true;
                    }
                }

                if (arrChapBool[12] == false)
                {
                    if (HomebrewDarkAngelsSucessors.Count > 1)
                    {
                        numberOfEncounter = GroupElim(random, HomebrewDarkAngelsSucessors.Count, HomebrewDarkAngelsSucessors, numberOfEncounter);
                    }
                    else
                    {
                        arrChapBool[12] = true;
                    }
                }

                if (arrChapBool[13] == false)
                {
                    if (HomebrewUltramarinesSucessors.Count > 1)
                    {
                        numberOfEncounter = GroupElim(random, HomebrewUltramarinesSucessors.Count, HomebrewUltramarinesSucessors, numberOfEncounter);
                    }
                    else
                    {
                        arrChapBool[13] = true;
                    }
                }

                if (arrChapBool[14] == false)
                {
                    if (HomebrewBloodAngelsSucessors.Count > 1)
                    {
                        numberOfEncounter = GroupElim(random, HomebrewBloodAngelsSucessors.Count, HomebrewBloodAngelsSucessors, numberOfEncounter);
                    }
                    else
                    {
                        arrChapBool[14] = true;
                    }
                }

                if (arrChapBool[15] == false)
                {
                    if (HomebrewIronHandsSucessors.Count > 1)
                    {
                        numberOfEncounter = GroupElim(random, HomebrewIronHandsSucessors.Count, HomebrewIronHandsSucessors, numberOfEncounter);
                    }
                    else
                    {
                        arrChapBool[15] = true;
                    }
                }

                if (arrChapBool[16] == false)
                {
                    if (HomebrewImperialFistsSucessors.Count > 1)
                    {
                        numberOfEncounter = GroupElim(random, HomebrewImperialFistsSucessors.Count, HomebrewImperialFistsSucessors, numberOfEncounter);
                    }
                    else
                    {
                        arrChapBool[16] = true;
                    }
                }

                if (arrChapBool[17] == false)
                {
                    if (HomebrewRavenGuardSucessors.Count > 1)
                    {
                        numberOfEncounter = GroupElim(random, HomebrewRavenGuardSucessors.Count, HomebrewRavenGuardSucessors, numberOfEncounter);
                    }
                    else
                    {
                        arrChapBool[17] = true;
                    }
                }

                if (arrChapBool[18] == false)
                {
                    if (HomebrewSalamandersSucessors.Count > 1)
                    {
                        numberOfEncounter = GroupElim(random, HomebrewSalamandersSucessors.Count, HomebrewSalamandersSucessors, numberOfEncounter);
                    }
                    else
                    {
                        arrChapBool[18] = true;
                    }
                }

                if (arrChapBool[19] == false)
                {
                    if (HomebrewSpaceWolvesSucessors.Count > 1)
                    {
                        numberOfEncounter = GroupElim(random, HomebrewSpaceWolvesSucessors.Count, HomebrewSpaceWolvesSucessors, numberOfEncounter);
                    }
                    else
                    {
                        arrChapBool[19] = true;
                    }
                }

                if (arrChapBool[20] == false)
                {
                    if (HomebrewDarkAngelsSucessors.Count > 1)
                    {
                        numberOfEncounter = GroupElim(random, HomebrewDarkAngelsSucessors.Count, HomebrewDarkAngelsSucessors, numberOfEncounter);
                    }
                    else
                    {
                        arrChapBool[20] = true;
                    }
                }

                if (arrChapBool[21] == false)
                {
                    if (HomebrewWhiteScarsSucessors.Count > 1)
                    {
                        numberOfEncounter = GroupElim(random, HomebrewWhiteScarsSucessors.Count, HomebrewWhiteScarsSucessors, numberOfEncounter);
                    }
                    else
                    {
                        arrChapBool[21] = true;
                    }
                }

                if (arrChapBool[22] == false)
                {
                    if (HomebrewUnknownSucessors.Count > 1)
                    {
                        numberOfEncounter = GroupElim(random, HomebrewUnknownSucessors.Count, HomebrewUnknownSucessors, numberOfEncounter);
                    }
                    else
                    {
                        arrChapBool[22] = true;
                    }
                }

                if (arrChapBool[23] == false)
                {
                    if (HomebrewSpecificSucessors.Count > 1)
                    {
                        numberOfEncounter = GroupElim(random, HomebrewSpecificSucessors.Count, HomebrewSpecificSucessors, numberOfEncounter);
                    }
                    else
                    {
                        arrChapBool[23] = true;
                    }
                }


                // END LOOP
                if (arrChapBool.All(x => x == true))
                {
                    endElim = true;
                    break;
                }
            }

            List<Chapter> Rest = Legions.Concat(DarkAngelsSucessors)
                                        .Concat(UltramarinesSucessors)
                                        .Concat(BloodAngelsSucessors)
                                        .Concat(IronHandsSucessors)
                                        .Concat(ImperialFistsSucessors)
                                        .Concat(RavenGuardSucessors)
                                        .Concat(SalamandersSucessors)
                                        .Concat(SpaceWolvesSucessors)
                                        .Concat(WhiteScarsSucessors)
                                        .Concat(UnknownSucessors)
                                        .Concat(SpecificSucessors)
                                        .Concat(HomebrewDarkAngelsSucessors)
                                        .Concat(HomebrewUltramarinesSucessors)
                                        .Concat(HomebrewBloodAngelsSucessors)
                                        .Concat(HomebrewIronHandsSucessors)
                                        .Concat(HomebrewImperialFistsSucessors)
                                        .Concat(HomebrewRavenGuardSucessors)
                                        .Concat(HomebrewSalamandersSucessors)
                                        .Concat(HomebrewSpaceWolvesSucessors)
                                        .Concat(HomebrewWhiteScarsSucessors)
                                        .Concat(HomebrewUnknownSucessors)
                                        .Concat(HomebrewSpecificSucessors)
                                        .ToList();

            // Start of Season
            Console.WriteLine("--- SEASON ---");
            Console.ReadLine();
            Console.WriteLine("Number of Encounter (before season): {0}", numberOfEncounter);
            int numberOfEncounterAfterSeason = Season(Rest, numberOfEncounter);
            numberOfEncounter += numberOfEncounterAfterSeason;
            Console.WriteLine("Number of Encounter (after season): {0}", numberOfEncounter);
            Console.ReadLine();

            // Remove Last Chapters
            List<Chapter> OrderRest = Rest.OrderBy(c => c.Points).ToList();
            RemoveAfterSeason(OrderRest);

            // Qualif
            Console.WriteLine("--- QUALIF ---");
            OrderRest.ShuffleMe();
            List<Chapter> Group1 = OrderRest.Take(3).ToList();
            List<Chapter> Group2 = OrderRest.Skip(3).Take(3).ToList();
            List<Chapter> Group3 = OrderRest.Skip(6).Take(3).ToList();
            List<Chapter> Group4 = OrderRest.Skip(9).Take(3).ToList();
            //

            GroupsPrint(Group1, Group2, Group3, Group4);
            Console.WriteLine("Number of Encounter: {0}", numberOfEncounter);
            numberOfEncounter = Qualif(Group1, numberOfEncounter);
            numberOfEncounter = Qualif(Group2, numberOfEncounter);
            numberOfEncounter = Qualif(Group3, numberOfEncounter);
            numberOfEncounter = Qualif(Group4, numberOfEncounter);
            ResultsQualif(Group1, Group2, Group3, Group4);

            // Quarter Finals
            Console.WriteLine("--- QUARTER FINALS ---");
            Console.WriteLine("Number of Encounter: {0}", numberOfEncounter);
            List<Chapter> QuarterFinals = (from Chapter in Group1
                                          orderby Chapter.Points descending
                                          select Chapter).Take(2)
                                          .Concat(Group2.OrderByDescending(c => c.Points).Take(2))
                                          .Concat(Group3.OrderByDescending(c => c.Points).Take(2))
                                          .Concat(Group4.OrderByDescending(c => c.Points).Take(2)).ToList();

            PrintChapters(QuarterFinals);
            QuarterFinals.ShuffleMe();
            List<Chapter> First = (from Chapter in QuarterFinals select Chapter).Take(2).ToList();
            List<Chapter> Second = (from Chapter in QuarterFinals select Chapter).Skip(2).Take(2).ToList();
            List<Chapter> Third = (from Chapter in QuarterFinals select Chapter).Skip(4).Take(2).ToList();
            List<Chapter> Fourth = (from Chapter in QuarterFinals select Chapter).Skip(6).Take(2).ToList();
            Console.WriteLine("---- First :");
            PrintFirstQuarter(First);
            Console.WriteLine("---- Second :");
            PrintSecondQuarter(Second);
            Console.WriteLine("---- Third :");
            PrintThirdQuarter(Third);
            Console.WriteLine("---- Fourth :");
            PrintFourthQuarter(Fourth);

            returnedInt = Match(value1, value2, returnedInt);
            First.RemoveAt(returnedInt);
            returnedInt = Match(value1, value2, returnedInt);
            Second.RemoveAt(returnedInt);
            returnedInt = Match(value1, value2, returnedInt);
            Third.RemoveAt(returnedInt);
            returnedInt = Match(value1, value2, returnedInt);
            Fourth.RemoveAt(returnedInt);
            numberOfEncounter += 4;

            Console.ReadLine();
            // Semi Finals
            Console.WriteLine("--- SEMI FINALS ---");
            List<Chapter> FirstSemi = (from Chapter in First select Chapter).Take(1).Concat(Second.Take(1)).ToList();
            List<Chapter> SecondSemi = (from Chapter in Third select Chapter).Take(1).Concat(Fourth.Take(1)).ToList();
            Console.WriteLine("---- First Semi Final:");
            PrintFirstSemiFinal(FirstSemi);
            Console.WriteLine("---- Second Semi Final:");
            PrintSecondSemiFinal(SecondSemi);
            returnedInt = Match(value1, value2, returnedInt);
            FirstSemi.RemoveAt(returnedInt);
            returnedInt = Match(value1, value2, returnedInt);
            SecondSemi.RemoveAt(returnedInt);
            numberOfEncounter += 2;

            Console.ReadLine();
            // Final
            Console.WriteLine("--- FINAL ---");
            PrintFirstChapFinal(FirstSemi);
            PrintSecondChapFinal(SecondSemi);
            returnedInt = Match(value1, value2, returnedInt);
            numberOfEncounter += 1;
            Console.WriteLine("Number of Encounter : {0}", numberOfEncounter);
            Console.WriteLine("-- Winner : ");
            if (returnedInt == 0)
            {
                PrintFirstChapFinal(FirstSemi);
            }
            else
            {
                PrintSecondChapFinal(SecondSemi);
            }
        }

        private static int Match(int random1, int random2, int returnedInt)
        {
            while (random1 == random2)
            {
                random1 = CreateRandom(0, 100);
                random2 = CreateSecondaryRandom(0, 100);
            }
            if (random1 >= random2)
            {
                returnedInt = 0;
            }
            if (random1 <= random2)
            {
                returnedInt = 1;
            }
            return returnedInt;
        }


        private static void ShuffleMe<T>(this IList<T> list)
        {
            Random random = new();
            int n = list.Count;

            for (int i = n - 1; i > 1; i--)
            {
                int rnd = random.Next(i + 1);

                T value = list[rnd];
                list[rnd] = list[i];
                list[i] = value;
            }
        }


        private static int CreateRandom(int random, int maxSize)
        {
            Random rnd = new();
            random = rnd.Next(random, maxSize);
            return random;
        }


        private static int CreateSecondaryRandom(int random2, int maxSize)
        {
            Random rnd2 = new();
            random2 = rnd2.Next(random2, maxSize);
            return random2;
        }


        private static int GroupElim(int random, int maxSize, List<Chapter> ChapList, int numberOfEncounter)
        {
            int random2 = random;
            int idSearcher1 = CreateRandom(random, maxSize);
            int idSearcher2 = CreateSecondaryRandom(random2, maxSize);

            while (idSearcher1 > maxSize)
            {
                idSearcher1 = CreateRandom(random, maxSize);
            }
            while ((idSearcher2 >= maxSize) || (idSearcher2 == idSearcher1))
            {
                idSearcher2 = CreateSecondaryRandom(random2, maxSize);
            }

            Console.WriteLine("ID1: {0} / ID2: {1}", idSearcher1, idSearcher2);

            Console.ForegroundColor = ConsoleColor.Blue;
            var filteredResult1 = ChapList.ElementAt(idSearcher1);
            Console.WriteLine("Winner Chapter: " + filteredResult1.ChapterName);

            Console.ForegroundColor = ConsoleColor.Red;
            var filteredResult2 = ChapList.ElementAt(idSearcher2);
            Console.WriteLine("Looser Chapter: " + filteredResult2.ChapterName);
            Console.ResetColor();

            ChapList.RemoveAt(idSearcher2);

            Console.WriteLine("--- Stay ---");
            foreach (Chapter c in ChapList)
            {
                Console.WriteLine("\t {0} {1}", c.ChapterID, c.ChapterName);
            }

            numberOfEncounter = IncrementByOne(numberOfEncounter);
            return numberOfEncounter;
        }

        private static int Season(List<Chapter> SeasonChap, int numberOfEncounter)
        {
            int num;
            int secondNum;
            int maxNum = SeasonChap.Count;

            for (num = 0; num < maxNum; num++)
            {
                for (secondNum = 0; secondNum < maxNum; secondNum++)
                {
                    if (num == secondNum)
                    {
                        // Nothing because same value
                    }
                    else
                    {
                        int value1 = CreateRandom(0, 2);
                        int value2 = CreateSecondaryRandom(0, 2);

                        if (value1 >= value2)
                        {
                            SeasonChap.ElementAt(num).Points += 1;
                        }
                        if (value1 <= value2)
                        {
                            // No Point
                        }
                        if (value1 == value2)
                        {
                            // No Point
                        }
                        numberOfEncounter++;
                    }
                } 
            }
            PrintSeason(SeasonChap);
            return numberOfEncounter;
        }


        private static void PrintSeason(List<Chapter> SeasonChap)
        {
            var orderByResult = from c in SeasonChap
                                orderby c.Points
                                select c;
            foreach (Chapter c in orderByResult)
            {
                Console.WriteLine("\t {0} Points: {1}", c.ChapterName, c.Points);
            }
        }


        private static void RemoveAfterSeason(List<Chapter> OrderRest)
        {
            Console.WriteLine("Remove...");
            Console.ReadLine();
            int divide = OrderRest.Count / 2;

            OrderRest.RemoveRange(0, divide);
            foreach (Chapter c in OrderRest)
            {
                Console.WriteLine("\t {0} Points: {1}", c.ChapterName, c.Points);
            }
            Console.ReadLine();
        }


        private static int Qualif(List<Chapter> QualifGroup, int numberOfEncounter)
        {
            int num;
            int secondNum;
            int maxNum = QualifGroup.Count;

            for (num = 0; num < maxNum; num++)
            {
                for (secondNum = 0; secondNum < maxNum; secondNum++)
                {
                    if (num == secondNum)
                    {
                        // Nothing because same value
                    }
                    else
                    {
                        int value1 = CreateRandom(0, 2);
                        int value2 = CreateSecondaryRandom(0, 2);

                        if (value1 >= value2)
                        {
                            QualifGroup.ElementAt(num).Points += 5;
                        }
                        if (value1 <= value2)
                        {
                            // No Point
                        }
                        if (value1 == value2)
                        {
                            // No Point
                        }
                        numberOfEncounter++;
                    }
                }
            }
            return numberOfEncounter;
        }

        private static void GroupsPrint(List<Chapter> Group1, List<Chapter> Group2, List<Chapter> Group3, List<Chapter> Group4)
        {
            Console.WriteLine("-- Creating Groups for Qualif --");
            Console.WriteLine("Group 1:");
            SortingGroups(Group1);
            Console.WriteLine("Group 2:");
            SortingGroups(Group2);
            Console.WriteLine("Group 3:");
            SortingGroups(Group3);
            Console.WriteLine("Group 4:");
            SortingGroups(Group4);
            Console.WriteLine("");
            Console.ReadLine();
        }

        private static void SortingGroups(List<Chapter> Group)
        {
            var orderByResult = from c in Group
                                orderby c.Points
                                select c;
            foreach (Chapter c in orderByResult)
            {
                Console.WriteLine("\t {0} Points: {1}", c.ChapterName, c.Points);
            }
        }


        private static void ResultsQualif(List<Chapter> Group1, List<Chapter> Group2, List<Chapter> Group3, List<Chapter> Group4)
        {
            Console.WriteLine("Group1 Results:");
            PrintSeason(Group1);
            Console.WriteLine("Group2 Results:");
            PrintSeason(Group2);
            Console.WriteLine("Group3 Results:");
            PrintSeason(Group3);
            Console.WriteLine("Group4 Results:");
            PrintSeason(Group4);
        }


        private static int IncrementByOne(int numberOfEncounter)
        {
            return ++numberOfEncounter;
        }


        private static void PrintFirstQuarter(List<Chapter> ChapToPrint)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            foreach (Chapter c in ChapToPrint)
            {
                Console.WriteLine("\t {0}", c.ChapterName);
            }
            Console.ResetColor();
        }


        private static void PrintSecondQuarter(List<Chapter> ChapToPrint)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            foreach (Chapter c in ChapToPrint)
            {
                Console.WriteLine("\t {0}", c.ChapterName);
            }
            Console.ResetColor();
        }


        private static void PrintThirdQuarter(List<Chapter> ChapToPrint)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            foreach (Chapter c in ChapToPrint)
            {
                Console.WriteLine("\t {0}", c.ChapterName);
            }
            Console.ResetColor();
        }


        private static void PrintFourthQuarter(List<Chapter> ChapToPrint)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            foreach (Chapter c in ChapToPrint)
            {
                Console.WriteLine("\t {0}", c.ChapterName);
            }
            Console.ResetColor();
        }


        private static void PrintFirstSemiFinal(List<Chapter> ChapToPrint)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            foreach (Chapter c in ChapToPrint)
            {
                Console.WriteLine("\t {0}", c.ChapterName);
            }
            Console.ResetColor();
        }


        private static void PrintSecondSemiFinal(List<Chapter> ChapToPrint)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            foreach (Chapter c in ChapToPrint)
            {
                Console.WriteLine("\t {0}", c.ChapterName);
            }
            Console.ResetColor();
        }


        private static void PrintFirstChapFinal(List<Chapter> ChapToPrint)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            foreach (Chapter c in ChapToPrint)
            {
                Console.WriteLine("\t {0}", c.ChapterName);
            }
            Console.ResetColor();
        }


        private static void PrintSecondChapFinal(List<Chapter> ChapToPrint)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            foreach (Chapter c in ChapToPrint)
            {
                Console.WriteLine("\t {0}", c.ChapterName);
            }
            Console.ResetColor();
        }


        private static void PrintChapters(List<Chapter> ChapToPrint)
        {
            foreach (Chapter c in ChapToPrint)
            {
                Console.WriteLine("\t {0} {1}", c.ChapterName, c.Points);
            }
        }


    }
}