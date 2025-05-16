using System.Diagnostics.Eventing.Reader;
using BfevLibrary;
using Newtonsoft.Json;
using TotkRSTB;
using System.IO;
using System.Linq;
using System.Text;
using SarcLibrary;
using Revrs;

namespace TotkRandomizer
{
    public static class Events
    {
        //public static dynamic? jsonEvent;

        private static int GetEventId(dynamic jsonEvent, string eventTitle, string eventName)
        {
            foreach (dynamic a in jsonEvent["Flowcharts"][eventTitle]["Events"])
            {
                if (a["Name"] == eventName)
                {
                    return jsonEvent["Flowcharts"][eventTitle]["Events"].IndexOf(a);
                }
            }

            return -1;
        }

        public static byte[] EditOpeningEvent(string filePath, System.Int32 heartInt, System.Single staminaFloat)
        {
            BfevFile bfev = BfevFile.FromBinary(HashTable.DecompressDataOther(File.ReadAllBytes(filePath)));

            string jsonString = bfev.ToJson();
            dynamic? jsonEvent = JsonConvert.DeserializeObject(jsonString);

            if (jsonEvent != null)
            {
                // Change opening with Zelda walking to the waking up Ganondorf section
                int event75Id = GetEventId(jsonEvent, "OpeningEvent", "Event75");
                jsonEvent["Flowcharts"]["OpeningEvent"]["EntryPoints"]["IntroductionOpening"]["EventIndex"] = event75Id;

                // Remove fade-in to allow loading screen to remain black
                int event77Id = GetEventId(jsonEvent, "OpeningEvent", "Event77");
                jsonEvent["Flowcharts"]["OpeningEvent"]["Events"][event77Id]["Parameters"]["IsStartOnEvent"]["Bool"] = false;
                jsonEvent["Flowcharts"]["OpeningEvent"]["Events"][event77Id]["Parameters"]["BootEventName"]["String"] = "";

                SetHearts(jsonEvent, (System.Int32) heartInt);
                SetStamina(jsonEvent, (System.Single) staminaFloat);
            }
            jsonString = JsonConvert.SerializeObject(jsonEvent, Formatting.Indented);
            bfev = BfevFile.FromJson(jsonString);

            byte[] modifiedData = HashTable.CompressDataOther(bfev.ToBinary());
            File.WriteAllBytes(filePath, modifiedData);
            return modifiedData;
        }
        // Set MaxLife (heartsInt) x4
        public static void SetHearts(dynamic jsonEvent, System.Int32 heartsInt)
        {
            int event79Id = GetEventId(jsonEvent, "OpeningEvent", "Event79");
            jsonEvent["Flowcharts"]["OpeningEvent"]["Events"][event79Id]["Parameters"]["MaxLife"]["Int"] = (System.Int32) heartsInt*4;
        }

        // Set MaxStamina between 1000 and 3000
        public static void SetStamina(dynamic jsonEvent, System.Single staminaFloat)
        {
            if (staminaFloat <= 1000f) { staminaFloat = 1000f; } else if (staminaFloat >= 3000f) { staminaFloat = 3000f; }
            int event124Id = GetEventId(jsonEvent, "OpeningEvent", "Event124");
            jsonEvent["Flowcharts"]["OpeningEvent"]["Events"][event124Id]["Parameters"]["MaxStamina"]["Float"] = (System.Single) staminaFloat;
        }
        public static Dictionary<string, byte[]> Files { get; set; }
        public static byte[] EditPlayerPackForSpeed(string filePath, System.Int32 percent) { //ONGOING
            Console.WriteLine("EditPlayerPackForSpeed: "+percent+"%");

            SarcLibrary.Sarc pack = SarcLibrary.Sarc.FromBinary(HashTable.DecompressFile(File.ReadAllBytes(filePath)));
            string sPack = "Component/ConditionParam/Player.game__component__ConditionParam.bgyml";

            /*byte[] f2 = HashTable.DecompressFile(filePath);
            byte[] data = File.ReadAllBytes(f2);*/
            //SarcLibrary.Sarc sarc = SarcLibrary.Sarc.FromBinary(filePath);

            //var files = pack.GetFiles();
            //var targetFile = pack.Files ;//Files.FirstOrDefault(f => f.Name.Replace('\\', '/').Equals(targetPath, StringComparison.Ordinal));

            Console.WriteLine(pack.GetType());
            foreach (var property in pack.GetType().GetProperties())
            {
                Console.WriteLine($"{property.Name} : {property.PropertyType}");
            }

            if (pack.TryGetValue(sPack, out var segment))
            {
                byte[] data = segment.ToArray();

                if (Encoding.ASCII.GetString(data, 0, 4) == "Yaz0")
                {
                    data = HashTable.DecompressFile(data);
                }
                string output = Encoding.UTF8.GetString(data);
                Console.WriteLine(output);
            }
            else
            {
                Console.WriteLine($"Fichier non trouvé : {sPack}");
            }

            byte[] modifiedDataSpeed = null;
            return modifiedDataSpeed;
        }

        public static byte[] EditDungeonGoalEvent(string filePath, bool checkbox4_4)
        {
            BfevFile bfev = BfevFile.FromBinary(HashTable.DecompressDataOther(File.ReadAllBytes(filePath)));

            string jsonString = bfev.ToJson();
            dynamic? jsonEvent = JsonConvert.DeserializeObject(jsonString);

            if (jsonEvent != null)
            {
                // If ShrineReward enabled,we put randomized reward (the same) for all shrine
                if (checkbox4_4 == true) {
                    ActorList.ShrineRewards.Shuffle();
                    Console.WriteLine("Reward will be: "+ActorList.ShrineRewards[0]);
                    int event50Id = GetEventId(jsonEvent, "DmF_SY_SmallDungeonGoal", "Event50");
                    //int event52Id = GetEventId(jsonEvent, "DmF_SY_SmallDungeonGoal", "Event52");
                    jsonEvent["Flowcharts"]["DmF_SY_SmallDungeonGoal"]["Events"][event50Id]["Parameters"]["ActorName"]["String"] = ActorList.ShrineRewards[0];
                }

                // Remove giving the Light Orb to Link
                else
                {
                    int event4Id = GetEventId(jsonEvent, "DmF_SY_SmallDungeonGoal", "Event4");
                    int event52Id = GetEventId(jsonEvent, "DmF_SY_SmallDungeonGoal", "Event52");
                    jsonEvent["Flowcharts"]["DmF_SY_SmallDungeonGoal"]["Events"][event4Id]["NextEventIndex"] = event52Id;
                    jsonEvent["Flowcharts"]["DmF_SY_SmallDungeonGoal"]["Events"][event4Id]["NextEventName"] = "Event52";
                }
            }

            jsonString = JsonConvert.SerializeObject(jsonEvent, Formatting.Indented);
            bfev = BfevFile.FromJson(jsonString);

            byte[] modifiedData = HashTable.CompressDataOther(bfev.ToBinary());
            File.WriteAllBytes(filePath, modifiedData);
            return modifiedData;
        }
    }
}