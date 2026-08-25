/*
 * Student ID : 1690704612
 * Name       : Lab02
 * Section    : 129D
 * No.        : N/A
 * Course     : GI113 Computer Programming (GI)
 */

namespace Lab02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bossName = "kirin";
            char rank = 'S';
            int level = 7;
            int maxHP = 240;
            int currentHP = 175;
            float attackPower = 42.5f;
            double criMultiplier = 1.75;
            bool isBoss = true;

            // Lab02 Part A
            Console.WriteLine("===== BOSS STATUS : INITAL =====");
            Console.WriteLine($"Name: {bossName}");
            Console.WriteLine($"Rank: {rank}");
            Console.WriteLine($"Level: {level}");
            Console.WriteLine($"HP: {currentHP} / {maxHP}");
            Console.WriteLine($"Attack Power: {attackPower}");
            Console.WriteLine($"Crit Multiplier: {criMultiplier}");
            Console.WriteLine($"isboos: {isBoss}");
            Console.WriteLine();
            int hpPercent = currentHP * 100 / maxHP;
            Console.WriteLine($"HP Percent: {hpPercent}");
            Console.WriteLine();
            Console.WriteLine($"Kirin take 60 damage!");
            currentHP = currentHP - 60;
            Console.WriteLine();
            Console.WriteLine("===== BOSS STATUS: AFTER DAMAGE =====");
            Console.WriteLine($"HP: { currentHP} / { maxHP}");
            hpPercent = currentHP * 100/ maxHP;
            Console.WriteLine($"HP Percentage: {hpPercent}%");

        }
    }
}
