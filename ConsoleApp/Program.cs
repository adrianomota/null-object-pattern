using System;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Program
    {
        private static async Task Main(string[] args)
        {
            PlayerCharacter sarah = new PlayerCharacter(new DiamondSkinDefense());
            sarah.SetName("Sarah");

            PlayerCharacter amrit = new PlayerCharacter(SpecialDefense.Null);
            amrit.SetName("Amrit");

            PlayerCharacter gentry = new PlayerCharacter(SpecialDefense.Null);
            gentry.SetName("Gentry");

            sarah.Hit(10);
            amrit.Hit(10);
            gentry.Hit(10);

            Console.ReadLine();

            await Task.FromResult(0);
        }
    }
}