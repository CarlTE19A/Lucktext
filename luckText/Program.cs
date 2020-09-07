using System;

namespace luckText
{
    class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();
            Console.WriteLine("Var snäll och skriv in ditt namn");
            string playerName = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Tack " + playerName + ", skriv in en plats");
            string pos1 = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Tack " + playerName + "! Du är så vänlig, kan du nu skriva in >YOUR MOTHERS MAIDEN NAME<");
            string motherMaidenName = Console.ReadLine();
            Console.Clear();
            Console.WriteLine(">FIRST PETS NAME<");
            string firstPetName = Console.ReadLine();
            Console.Clear();
            Console.WriteLine(">BANK CARD EXPERATION DATE<");
            string bankExperationDate = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Hej "+playerName +". Tack för informationen du gav oss, vi kommer ta ut >MONEY< med hjälp av din data");
            Console.ReadLine(); Console.Clear();
            Console.WriteLine("Host* Host* Jag menar "+playerName+ ", att nu kommer du få en rolig historia!");
            Console.ReadLine(); Console.Clear();
            Console.WriteLine("Det var en gång en man som kallades Mr." + motherMaidenName +". Han var en lång och ståtlig man som bodde på/i "+pos1);
            Console.ReadLine(); Console.Clear();
            Console.WriteLine("Han fick ett barnbarn som nu kallas "+playerName);
            Console.ReadLine(); Console.Clear();
            Console.WriteLine(playerName+" hadde ett djur som hette "+firstPetName);
            Console.ReadLine(); Console.Clear();
            Console.WriteLine(playerName+" hadde också ett bankkort som går ut den "+bankExperationDate);
            Console.ReadLine(); Console.Clear();
            Console.WriteLine(playerName+" blev absolut aldrig lurad av en dator till att ge iväg alla sina pengar");
           Console.ReadLine(); Console.Clear();
            Console.WriteLine(playerName+" gillade verkligen boten och sa Tack");
            if(Console.ReadLine() == "Tack" || Console.ReadLine() == "tack"){
                Console.WriteLine(playerName+ " du är så snäll, förlåt att jag tänkte sno dina pengar :(");
            }
            else{
                int End = generator.Next(0,2);
                if(End == 0){
                Console.WriteLine("FUCK U");}
                else if(End == 1){
                    Console.WriteLine("Hmm yeah I kinda hate you, waaait whats your bank?");
                }}
            Console.ReadLine();
        }
    }
}
