using static System.Net.Mime.MediaTypeNames;
using System.Threading;
using System;

namespace dz_7
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<ElvenFighter> heroes = new List<ElvenFighter>
            {
                new ElvenKnight("Elven Knight", 100, 50, 20, "Меч"),
                new ElvenScout("Elven Scout", 80, 60, 40, "Лук")
            };

            List<ElvenKnight> heroes2 = new List<ElvenKnight>
            {
                new TempleKnight("Temple Knight", 100, 50, 20, "Меч"),
                new SwordSinger("Sword Singer", 100, 50, 20, "Меч")
            };

            List<ElvenScout> heroes3 = new List<ElvenScout>
            {
                new PlainsWalker("Plains Walker", 70, 30, 100, "Копьё"),
                new SilverRanger("Silver Ranger", 80, 60, 40, "Арбалет")
            };

            List<TempleKnight> heroes4 = new List<TempleKnight>
            {
                new GuasTemplar("Guas Templar", 70, 30, 100, "Топор")
            };

            List<SwordSinger> heroes5 = new List<SwordSinger>
            {
                new SwordMuse("Sword Muse", 100, 50, 20, "Меч")
            };

            List<PlainsWalker> heroes6 = new List<PlainsWalker>
            {
                new WindRider("Wind Rider", 80, 60, 40, "Арбалет")
            };

            List<SilverRanger> heroes7 = new List<SilverRanger>
            {
                new MoonlightSentimel("Moonlight Sentimel", 70, 30, 100, "Копьё")
            };

            foreach (var hero in heroes)
            {
                hero.showStatus();
                hero.Attack();
                hero.MakeSound();
                Console.WriteLine();
            }

            foreach (var hero2 in heroes2)
            {
                hero2.showStatus();
                hero2.Attack();
                hero2.MakeSound();
                Console.WriteLine();
            }

            foreach (var hero3 in heroes3)
            {
                hero3.showStatus();
                hero3.Attack();
                hero3.MakeSound();
                Console.WriteLine();
            }

            foreach (var hero4 in heroes4)
            {
                hero4.showStatus();
                hero4.Attack();
                hero4.MakeSound();
                Console.WriteLine();
            }

            foreach (var hero5 in heroes5)
            {
                hero5.showStatus();
                hero5.Attack();
                hero5.MakeSound();
                Console.WriteLine();
            }

            foreach (var hero6 in heroes6)
            {
                hero6.showStatus();
                hero6.Attack();
                hero6.MakeSound();
                Console.WriteLine();
            }

            foreach (var hero7 in heroes7)
            {
                hero7.showStatus();
                hero7.Attack();
                hero7.MakeSound();
                Console.WriteLine();
            }
        }
    }
}