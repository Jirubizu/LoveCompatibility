using System;
using System.Collections.Generic;
using System.Linq;

namespace LoveCompatibility.Utils
{
    public static class LoveUtils
    {
        public static float GetPercentage(string nameOne, string nameTwo, CalculationModes mode)
        {
            float score;
            
            nameOne += string.Concat(Enumerable.Repeat("a",
                nameOne.Length < nameTwo.Length ? nameTwo.Length - nameOne.Length : 0));
            nameTwo += string.Concat(Enumerable.Repeat("a",
                nameOne.Length > nameTwo.Length ? nameOne.Length - nameTwo.Length : 0));



            switch (mode)
            {
                case CalculationModes.Basic:
                    float nameOneScore = GetScore(nameOne);
                    float nameTwoScore = GetScore(nameTwo);
            
                    score = (nameOneScore <= nameTwoScore ? nameOneScore / nameTwoScore : nameTwoScore / nameOneScore) * 100;
                    break;
                
                case CalculationModes.Neighbour:
                    float temp = NeiScore(nameOne, nameTwo);
                    score = temp / (nameOne.Length * 2) * 100;
                    break;
                
                default:
                    throw new ArgumentOutOfRangeException(nameof(mode), mode, null);
            }

            return score;
        }

        private static int GetScore(string name)
        {
            return name.Sum(c => letters[c]);
        }

        private static int NeiScore(string nameOne, string nameTwo)
        {
            int score = 0;
            
            for (int i = 0; i < nameOne.Length; i++)
            {
                if (nameOne[i] == nameTwo[i])
                {
                    score += 2;
                }
                else switch (nameOne[i])
                {
                    case 'a' when nameTwo[i] == 'z' || nameTwo[i] == 'b':
                    case 'z' when nameTwo[i] == 'a' || nameTwo[i] == 'y':
                        score += 1;
                        break;
                    default:
                    {
                        if (nameOne[i] == nameTwo[i] + 1 || nameOne[i] == nameTwo[i] - 1)
                        {
                            score += 1;
                        }

                        break;
                    }
                }
            }

            return score;
        }

        private static readonly Dictionary<char, int> letters = new()
        {
            {'e', 1},
            {'a', 2},
            {'r', 3},
            {'i', 4},
            {'o', 5},
            {'t', 6},
            {'n', 7},
            {'s', 8},
            {'l', 9},
            {'c', 10},
            {'u', 11},
            {'d', 12},
            {'p', 13},
            {'m', 14},
            {'h', 15},
            {'g', 16},
            {'b', 17},
            {'f', 18},
            {'y', 19},
            {'w', 20},
            {'k', 21},
            {'v', 22},
            {'x', 23},
            {'z', 24},
            {'j', 25},
            {'q', 26},
        };
    }
}