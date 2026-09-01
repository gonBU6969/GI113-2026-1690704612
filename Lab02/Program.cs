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


            // Lab02 Part B
            Console.WriteLine("=====Struggle World =====");
            //ชื่อตัวละคร
            string humanName = "Zephyr";
            string dwarfName = "Morwen";
            string elfName = "Krynn";
            string orcName = "Vesper";
            // ระดับของตัวละคร
            char humanRank = 'A';
            char dwarfRank = 'B';
            char elfRank = 'C';
            char orcRank = 'C';
            // เผ่าพันธุ์ของตัวละคร
            string raceZephyr = "The Sylvan";
            string raceMorwen = "The Iron";
            string raceKrynn = "The Solari";
            string raceVesper = "The Abyssal";
            // อาชีพของตัวละคร
            string classZephyr = "Glass Blower";
            string classMorwen = "Broker";
            string classKrynn = "Cartographer";
            string classVesper = "Sculptor";
            // เลเวลของตัวละคร
            int levelZephyr = 5;
            int levelMorwen = 4;
            int levelKrynn = 3;
            int levelVesper = 3;
            // ค่าพลังโจมตีของตัวละคร
            float attackPowerZephyr = 16.5f;
            float attackPowerMorwen = 10.0f;
            float attackPowerKrynn = 20.6f;
            float attackPowerVesper = 12.5f;
            // ค่าพลังชีวิตของตัวละคร
            int maxHpZephyr = 100;
            int maxHpMorwen = 140;
            int maxHpKrynn = 70;
            int maxHpVesper = 100;
            // ค่าตัวคูณคริติคอลของตัวละคร
            double critMultiplierZephyr = 1.4;
            double critMultiplierMorwen = 1.2;
            double critMultiplierKrynn = 1.8;
            double critMultiplierVesper = 1.3;
            // สถานะการเป็นสมาชิกปาร์ตี้ของตัวละคร
            bool isPartyMemberZephyr = true;
            bool isPartyMemberMorwen = true;
            bool isPartyMemberKrynn = true;
            bool isPartyMemberVesper = true;


            Console.WriteLine("=====CHARACTER STATUS: INITIAL =====");
            Console.WriteLine($"Name: {humanName}");
            Console.WriteLine($"Rank: {humanRank}");
            Console.WriteLine($"Race: {raceZephyr}");
            Console.WriteLine($"Class: {classZephyr}");
            Console.WriteLine($"Level: {levelZephyr}");
            Console.WriteLine($"Max HP: {maxHpZephyr}");
            Console.WriteLine($"Attack Power: {attackPowerZephyr}");
            Console.WriteLine($"Critical Multiplier: {critMultiplierZephyr}");
            Console.WriteLine($"Is Party Member: {isPartyMemberZephyr}");
            Console.WriteLine();
            Console.WriteLine($"Name: {dwarfName}");
            Console.WriteLine($"Rangk: {dwarfRank}");
            Console.WriteLine($"Race: {raceMorwen}");
            Console.WriteLine($"Class: {classMorwen}");
            Console.WriteLine($"Level: {levelMorwen}");
            Console.WriteLine($"Max HP: {maxHpMorwen}");
            Console.WriteLine($"Attack Power: {attackPowerMorwen}");
            Console.WriteLine($"Critical Multiplier: {critMultiplierMorwen}");
            Console.WriteLine($"Is Party Member: {isPartyMemberMorwen}");
            Console.WriteLine();
            Console.WriteLine($"Name: {elfName}");
            Console.WriteLine($"Rank: {elfRank}");
            Console.WriteLine($"Race: {raceKrynn}");
            Console.WriteLine($"Class: {classKrynn}");
            Console.WriteLine($"Level: {levelKrynn}");
            Console.WriteLine($"Max HP: {maxHpKrynn}");
            Console.WriteLine($"Attack Power: {attackPowerKrynn}");
            Console.WriteLine($"Critical Multiplier: {critMultiplierKrynn}");
            Console.WriteLine($"Is Party Member: {isPartyMemberKrynn}");
            Console.WriteLine();
            Console.WriteLine($"Name: {orcName}");
            Console.WriteLine($"Rank: {orcRank}");
            Console.WriteLine($"Race: {raceVesper}");
            Console.WriteLine($"Class: {classVesper}");
            Console.WriteLine($"Level: {levelVesper}");
            Console.WriteLine($"Max HP: {maxHpVesper}");
            Console.WriteLine($"Attack Power: {attackPowerVesper}");
            Console.WriteLine($"Critical Multiplier: {critMultiplierVesper}");
            Console.WriteLine($"Is Party Member: {isPartyMemberVesper}");
            Console.WriteLine();




        }
    }
}