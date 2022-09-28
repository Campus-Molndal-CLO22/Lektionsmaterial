namespace LostInMyHouse;

using System;

/// <summary>
/// ------------------------------------------------------------------------------------
/// Programmet är ett enkelt text-äventyr.
/// Author: Marcus Medina, Campus Mölndal
/// Date: 2019-09-25
/// (C) Campus Mölndal, 2022, published under the GNU General Public License v3.0
/// ------------------------------------------------------------------------------------
/// </summary>
// Info:
// Skrivet av Marcus Medina, för kursen i OOP i C# vid Campus Mölndal
// Licenserad enligt Apache License 3.0, vilket innebär att du får använda
// koden som du vill så länge du inte tar bort första blocken av kommentaren
// som är under summary taggen.
// Om du inspireras och skriver ett liknande spel med din egen kod, då är du fri
// att skippa denna kommentar.
// ------------------------------------------------------------------------------------
// Om spelet:
// Enkel text-äventyr.En person är vilse i ett hus och måste hitta en väg ut.
// Huset består av fem rum och spelaren kan flytta mellan dem.Spelaren kan också
// plocka upp föremål och använda dem.Spelaren kan också prata med husets invånare.
// Spelaren kan ladda och spara spel.Spelaren kan också avsluta spelet.Nyckeln till
// utgången är gömd i ett av rummen.Spelaren måste hitta nyckeln och använda den för
// att öppna dörren till utgången.
// ------------------------------------------------------------------------------------
//         ____________________________
//        /          VARNING           \
//        !                            !
//        !   Om du fortsätter att     !
//        !  scrolla och läsa koden    !
//        !  kommer du att komma på    !
//        !   hur man löser spelet     !
//        !  ... du fuskar väl inte?   !
//        !                            !
//        \____________________________/
//                     !  !
//                     !  !
//                     L_ !
//                    / _)!
//                   / /__L
//__________________/ (____)
//                    (____)
//__________________  (____)
//                  \_(____)
//                     !  !
//                     !  !
//                     \__/
//
// ------------------------------------------------------------------------------------
//
// Ps.Om du kollar på koden blir det alldeles för lätt att vinna, så spela spelet
//     innan du kollar på koden.
//
// ------------------------------------------------------------------------------------
//
// Fuska inte!
//
// ------------------------------------------------------------------------------------
//
// Hmm..du fuskar väl inte?
//
// ------------------------------------------------------------------------------------
//
//
//
//
//
//
//                          \||/
//                          |  @___oo
//                /\  /\   / (__,,,,|
//               ) /^\) ^\/ _)
//               )   /^\/   _)
//               )   _ /  / _)
//           /\  )/\/ ||  | )_)
//          <  >      |(,,) )__)
//           ||      /    \)___)\
//           | \____(      )___) )___
//            \______(_______;;; __;;;
//
//                HERE BE DRAGONS!
//
//
//
// ------------------------------------------------------------------------------------
//
//
//
//
//
//
//
// Stängsel för att hålla obehöriga borta!
//
// _            ,'|     _ |`,      _            ,'|     _ |`,      _
//(:\          ///     /:) \\\    (:\          ///     /:) \\\    (:\
// \:\        )//     /:/   \\(    \:\        )//     /:/   \\(    \:\
//==\:(======/:(=====):/=====):\====\:(======/:(=====):/=====):\====\:(===
//   )\\    /:/     //(       \:\    )\\    /:/     //(       \:\    )\\
//    \\\  (:/     ///         \:)    \\\  (:/     ///         \:)    \\\
//     `.|  "     |.'           "      `.|  "     |.'           "      `.|
//
//
//
//
//
//
// ------------------------------------------------------------------------------------
// Här får du en labyrint att roa dig med, så att du glömmer att fuska
//  _________________________________________________________________
// |         ___________            |   __________________________   |
// |  Mouse |   _____   |  |  |  |  |  |   ____________________   |  |
// |________|  |     |_____|  |  |_____|  |   _________________   |  |
// |___________|  |___________|  |   _____|  |   ___________   |  |  |
// |   ___________|   ___________|  |  ______|  |   ________|  |_____|
// |  |   ___________|   ___________|___________|  |___________|     |
// |  |  |   __         |   _________________   |_____   |     |  |  |
// |  |  |  |  |  |  |  |  |   ______________|_____   |  |  |  |  |  |
// |  |  |  |  |  |  |_____|  |   _____   |   __   |  |  |  |  |  |  |
// |  |  |  |  |  |___________|  |     |  |  |  |  |  |  |  |  |  |  |
// |  |  |  |  |_________________|  |  |  |  |  |  |  |  |  |  |  |  |
// |  |  |  |  |   _________________|_____|  |  |  |  |  |  |  |  |  |
// |  |  |  |  |  |   __    ______________|  |  |  |  |   __|  |  |  |
// |  |  |  |  |  |  |  |  |   ________   |  |  |  |  |  |  |  |  |  |
// |  |  |  |  |  |  |  |  |  |   _____   |  |  |  |  |  | ____|  |  |
// |  |  |  |  |  |  |  |  |  |  |  ______|  |  |  |  |   ________|  |
// |  |  |_____|  |  |  |  |  |  |_____   |  |  |  |  |  |           |
// |  |_____   |  |__|  |  |  |________|  |  |  |  |__|  |  Cheese   |
// |___________|_______________________|________|________|___________|
//
// ------------------------------------------------------------------------------------
//
//
//
//
//
//
//
//
//
//
//
//
//
// OK Då... här kommer det!
//
//
//
//
//
//
//
//
//
//
//
//
//
// Karta
// --------------------------------------------------------------------------------------
//
// Säng --> Sovrum --> Badrum
//            |
//           Kök --> Hall --> Dörr -> Game Over
//                     |
//                 Vardagsrum
//
// --------------------------------------------------------------------------------------
//
// Säng, har kudde
// Sovrum, har fönsterkarm, sängbord, klädskåp
// Badrum, har duschgolv, toalettskåp, toalettstol
// Kök, har spis, ugn, fläkt
// Hall, har städskåp, låst_dörr
// Vardagsrum, har TV, TVmöbel, soffa
// Låst_dörr, har Tittöga
// Dörr_ut, har Tittöga
//
// --------------------------------------------------------------------------------------
//
// Soffan har en soffkudde
// Soffkudden har en nyckel
// Kökskåpet har kattmat och hundmat
// Spisen har frukost
//
// --------------------------------------------------------------------------------------
//
// Måste mata hund och katt innan dörren öppnas
// Frukost måste ätas innan dörren öppnas
// Frukost kan inte ätas förrän hund och katt matats
// Om man lägger sig i sängen, missar man tentan och förlorar
// När man kommer till vardagsrum flyttar sig hund och katt dit från sängen
// Om nyckel öppnar Låst_dörr försvinner Låst_dörr och ersätts med Dörr_ut
// Om spöket inte hälsas vänligt kommer den att skrämma dig
//    då kommer det att se ut som om spelet slutat, men det är bara fejk
// Om man ger hunden kattmat kommer katten att anfalla och du förlorar
// Om man ger katten hundmat kommer hunden att anfalla och du förlorar
//
// --------------------------------------------------------------------------------------

internal static class Program
{
    private const bool GameOn = false;

    #region Alias

    private static readonly Dictionary<Command, List<string>> CommandAlias = new();
    private static readonly Dictionary<Creature, List<string>> CreatureAlias = new();
    private static readonly Dictionary<Furniture, List<string>> FurnitureAlias = new();
    private static readonly Dictionary<Item, List<string>> ItemAlias = new();
    private static readonly Dictionary<Room, List<string>> RoomAlias = new();

    #endregion Alias

    #region Descriptions

    private static readonly Dictionary<Creature, string> CreatureDescription = new();
    private static readonly Dictionary<Furniture, string> FurnitureDescription = new();
    private static readonly Dictionary<Item, string> ItemDescription = new();
    private static readonly Dictionary<Room, string> RoomsDescription = new();

    #endregion Descriptions

    #region Thing's location

    private static readonly Dictionary<Room, List<Creature>> creaturePosition = new();
    private static readonly Dictionary<Room, List<Tuple<Room, string, string>>> exits = new();
    private static readonly Dictionary<Room, List<Furniture>> FurnitureInRoom = new();
    private static readonly Dictionary<Room, List<Item>> ItemLocations = new();

    #endregion Thing's location

    #region Item's location

    private static readonly Dictionary<Furniture, List<Item>> ItemsInFurniture = new();
    private static readonly Dictionary<Item, List<Item>> ItemsInItems = new();

    #endregion Item's location

    #region GameVariables

    private static bool breakfastHasBeenEaten = false;
    private static bool catHasBeenFed = false;
    private static bool angryGhost = false;
    private static bool dogHasBeenFed = false;
    private static bool fail = false;
    private static Room location = Room.Säng;
    private static int time = 45;
    private static readonly StringComparer NoCase = StringComparer.InvariantCultureIgnoreCase;
    private static readonly StringComparison NoCase2 = StringComparison.InvariantCultureIgnoreCase;
    #endregion GameVariables

    private static bool CheckIfLocationIsAvailable(Room input_location)
    {
        // Loopa igenom exits för att verifiera att rummet finns
        foreach (var room in exits[location])
        {
            if (room.Item1 == input_location) return true;
        }
        return false;
    }

    private static void FeedTheCat(Item input_item)
    {
        if (input_item == Item.Kattmat)
        {
            if (ItemsInFurniture[Furniture.Inventory].Contains(input_item))
            {
                Assistent("Du har matat katten");
                catHasBeenFed = true;
                ItemsInFurniture[Furniture.Inventory].Remove(input_item);
            }
            else
            {
                Assistent("Du har ingen kattmat :'(");
            }
        }
        else if (input_item == Item.Hundmat)
        {
            if (ItemsInFurniture[Furniture.Inventory].Contains(input_item))
            {
                Assistent("Du har matat katten med hundmat. Det var inte så smart.");
                Assistent("Katten smakade på det men fnös sedan äcklat och vandrade iväg");
                Assistent("Hunden fick panik i tanken på att bli av med sin mat och hoppade");
                Assistent("på dig och fick dig att tappa balansen.");
                Assistent("Du föll och bröt armen i fallet");
                Assistent("Du har nu en arm bruten och kan inte gå ut.");
                fail = true;
            }
            else
            {
                Assistent("Du har ingen hundmat :'(");
            }
        }
        else
        {
            Assistent("Du kan inte mata katten med det.");
        }
    }

    private static void FeedTheDog(Item input_item)
    {
        if (input_item == Item.Hundmat)
        {
            if (ItemsInFurniture[Furniture.Inventory].Contains(input_item))
            {
                Assistent("Du har matat hunden");
                dogHasBeenFed = true;
                ItemsInFurniture[Furniture.Inventory].Remove(input_item);
            }
            else
            {
                Assistent("Du har ingen hundmat :'(");
            }
        }
        else if (input_item == Item.Kattmat)
        {
            if (ItemsInFurniture[Furniture.Inventory].Contains(input_item))
            {
                Assistent("Du har matat hunden med kattmat. Det var inte så smart.");
                Assistent("Hunden åt glatt upp kattmaten");
                Assistent("Katten blev arg och anföll hunden, hunden hoppade upp i");
                Assistent("famnen på dig och ni föll båda baklänges.");
                Assistent("Du föll och bröt armen i fallet");
                Assistent("Du har nu en arm bruten och kan inte gå ut.");
                fail = true;
            }
            else
            {
                Assistent("Du har ingen kattmat :'(");
            }
        }
        else
        {
            Assistent("Du kan inte mata vovven med det.");
        }
    }

    private static void FeedTheGhost()
    {
        Assistent("Spöket är inte hungrig på mat...");
    }

    /// <summary>
    /// Här händer det saker!
    /// </summary>
    private static void GameAction()
    {
        Console.Clear();
        Assistent(RoomsDescription[location]);
        ShowTimeLeft();

        Info("Här finns: " + GetItemLists(location));
        Console.WriteLine();

        Info("Du kan gå : ");
        Info(GetExits(location));
        Console.WriteLine();

        if (IsCarrying())
        {
            Info("Du bär på: ");
            Info(Inventory());
        }
        Console.WriteLine();

        Info("Vad vill du göra?");
        TolkaKommando(Console.ReadLine());
        Console.WriteLine();
    }

    private static bool IsCarrying()
    {
        return ItemsInFurniture[Furniture.Inventory].Count > 0;
    }

    private static Room GetARoom(string input)
    {
        var retVal = Room.None;
        var words = GetWordArray(input);
        // Loopa igenom alla ord
        foreach (var word in words)
        {
            if (Enum.TryParse(word, out Room item))
            {
                retVal = item;
                break;
            }
            // Loopa igenom alla Room ifall de finns i input
            foreach (Room room in Enum.GetValues(typeof(Room)))
            {
                if (room.ToString().ToLower().StartsWith(word, StringComparison.InvariantCultureIgnoreCase) ||
                    word.StartsWith(room.ToString().ToLower(), StringComparison.InvariantCultureIgnoreCase))
                {
                    retVal = room;
                    break;
                }
            }

            if (retVal == Room.None)
            {
                // item1 = Room
                // item2 = Riktning
                // item3 = beskrivning
                foreach (var dir in exits[location])
                {
                    if (dir.Item2.StartsWith(word, StringComparison.InvariantCultureIgnoreCase) ||
                        word.StartsWith(dir.Item2, StringComparison.InvariantCultureIgnoreCase))
                    {
                        retVal = dir.Item1;
                        break;
                    }
                }
            }

            foreach (var dir in exits[location])
            {
                if (dir.Item1 == retVal)
                    return dir.Item1;
            }

            return Room.None;
        }

        return Room.None;
    }

    private static Command GetCommand(string input)
    {
        var words = GetWordArray(input);
        foreach (var word in words)
        {
            if (Enum.TryParse(word, out Command command)) return command;

            // Loopa igenom alla Command om de finns i input
            foreach (Command cmd in Enum.GetValues(typeof(Command)))
            {
                if (cmd != Command.None)
                {
                    bool matchAlias = CommandAlias[cmd].Contains(word, NoCase);
                    if (matchAlias) return cmd;

                    bool matchEnum = cmd.ToString().ToLower().StartsWith(word, NoCase2);
                    bool matchWord = word.StartsWith(cmd.ToString().ToLower(), NoCase2);
                    if (matchEnum || matchWord) return cmd;
                }
            }
        }

        return Command.None;
    }

    private static string GetCommandList()
    {
        int count = 60;
        string cmd = "";
        foreach (string command in Enum.GetNames(typeof(Command)))
        {
            if (command != "None")
            {
                cmd += command + ", ";
                if (cmd.Length > count)
                {
                    cmd += Environment.NewLine;
                    count += 60;
                }
            }
        }

        return cmd.TrimEnd(',');
    }

    private static Creature GetCreature(string input)
    {
        var retVal = Creature.None;
        var words = GetWordArray(input);
        foreach (var word in words)
        {
            if (Enum.TryParse(word, out Creature item))
            {
                retVal = item;
                break;
            }

            // Loopa igenom alla Creature ifall de finns i input
            foreach (Creature creature in Enum.GetValues(typeof(Creature)))
            {
                if (creature != Creature.None)
                {
                    bool matchAlias = CreatureAlias[creature].Contains(word);
                    bool isHere = VerifyCreature(creature, location);
                    if (matchAlias && isHere) return creature;

                    bool matchEnum = creature.ToString().ToLower().StartsWith(word, NoCase2);
                    bool matchWord = word.StartsWith(creature.ToString().ToLower(), NoCase2);

                    if (matchEnum || matchWord)
                    {
                        retVal = creature;
                        break;
                    }
                }
            }

            if (retVal != Creature.None) break;
        }

        if (creaturePosition[location].Contains(retVal))
            return retVal;
        else
            return Creature.None;
    }

    private static bool VerifyCreature(Creature creature, Room location)
    {
        return creaturePosition[location].Contains(creature);
    }

    private static string GetExits(Room location)
    {
        var response = "";
        foreach (var exit in exits[location])
            response += "   [ " + exit.Item2 + " ]  - " + exit.Item3 + Environment.NewLine;

        return response;
    }

    private static Furniture GetFurniture(string input)
    {
        var retVal = Furniture.None;
        var words = GetWordArray(input);
        foreach (var word in words)
        {
            if (Enum.TryParse(word, out Furniture furniture))
            {
                retVal = furniture;
                break;
            }

            // Loopa igenom alla Furniture om de finns i input
            foreach (Furniture thingy in Enum.GetValues(typeof(Furniture)))
                if (thingy != Furniture.None && thingy != Furniture.Inventory)
                {
                    bool matchAlias = FurnitureAlias[thingy].Contains(word, NoCase);
                    bool isHere = VerifyFurniture(thingy, location);
                    if (matchAlias && isHere) return thingy;
                    bool matchEnum = thingy.ToString().ToLower().StartsWith(word, NoCase2);
                    bool matchWord = word.StartsWith(thingy.ToString().ToLower(), NoCase2);
                    if ((matchEnum || matchWord) && isHere)
                    {
                        retVal = thingy;
                        break;
                    }
                }

            if (retVal != Furniture.None) break;
        }

        if (FurnitureInRoom[location].Contains(retVal))
            return retVal;
        else
            return Furniture.None;
    }

    /// <summary>
    /// Bekräfta att möbeln finns i rummet
    /// </summary>
    private static bool VerifyFurniture(Furniture thingy, Room location)
    {
        return FurnitureInRoom[location].Contains(thingy);
    }

    private static Item GetItem(string input)
    {
        var retVal = Item.None;
        var words = GetWordArray(input);
        foreach (var word in words)
        {
            if (Enum.TryParse(word, out Item item))
            {
                retVal = item;
                break;
            }

            // Loopa igenom alla critter ifall de finns i input
            foreach (Item stuff in Enum.GetValues(typeof(Item)))
            {
                if (stuff != Item.None)
                {
                    bool matchAlias = ItemAlias[stuff].Contains(word, NoCase);
                    bool isHere = VerifyItem(stuff, location);
                    bool isCarrying = ItemsInFurniture[Furniture.Inventory].Contains(stuff);

                    if (matchAlias && (isHere || isCarrying)) return stuff;

                    bool matchEnum = stuff.ToString().ToLower().StartsWith(word, NoCase2);
                    bool matchWord = word.StartsWith(stuff.ToString().ToLower(), NoCase2);

                    if (matchEnum || matchWord)
                    {
                        retVal = stuff;
                        break;
                    }
                }
            }

            if (retVal != Item.None) break;
        }

        foreach (Furniture f in FurnitureInRoom[location])
        {
            foreach (var i in ItemsInFurniture[f])
            {
                if (i == retVal) return retVal;
            }
        }

        if (ItemLocations[location].Contains(retVal))
            return retVal;

        if (ItemsInFurniture[Furniture.Inventory].Contains(retVal))
            return retVal;
        else
            return Item.None;
    }

    private static bool VerifyItem(Item item, Room location)
    {
        if (ItemLocations[location].Contains(item)) return true;
        foreach (Furniture forniture in FurnitureInRoom[location])
            if (ItemsInFurniture[forniture].Contains(item)) return true;
        foreach (Item thing in ItemsInFurniture[Furniture.Inventory])
            if (ItemsInItems.ContainsKey(thing))
                if (ItemsInItems[thing].Contains(item)) return true;
        return false;
    }

    private static string[] GetWordArray(string input)
    {
        // Dela upp input i ord och ordna orden från den längsta först
        // detta för att söka på de längsta orden först, så att vi inte
        // hamnar i problem med att söka på "gå" och få ut "trädgården"
        // istället för "gång".
        return input.Split(' ').OrderByDescending(x => x.Length).ToArray();
    }

    private static void ListItemsAvailable(Furniture input_furniture, List<Item> items)
    {
        ListItemsAvailable(items);
    }

    private static void ListItemsAvailable(Item input_item, List<Item> items)
    {
        ListItemsAvailable(items);
    }

    private static void ListItemsAvailable(List<Item> items)
    {
        foreach (Item item in items)
        {
            Assistent("* " + item.ToString());
        }
    }

    private static void Main()
    {
        Console.Clear();
        Console.Title = "Tentaspelet";
        Info("-------------------------------------------------------------");
        Info("Välkommen till spelet 'Tenta'!");
        Info("-------------------------------------------------------------");
        Info("Du är en student som ska till skolan för att skriva tenta.");
        Info("Du har sovit bort dig och måste nu ta dig till skolan.");
        Info("Det tar dig 15 minuter att ta dig till skolan.");
        Info("Vilket betyder att du har 45 minuter på dig att göra dig");
        Info("klar för att ta dig till skolan.");
        Info("");
        Info("Du kan använda kommandon som 'gå', 'titta', 'ta', 'släng'");
        Info("och 'använd'. Du kan även skriva Hjälp för att få en längre");
        Info("lista av kommandon.");
        Info("Tänk på att om en sak befinner sig i en anna sak, måste du skriva");
        Info("till exempel 'titta i lådan' för att titta i lådan.");
        Info("eller 'ta ägget från stekpannan' för att ta ägget från stekpannan.");
        Info("-------------------------------------------------------------");
        Info("Din assistent skriver i gult");
        Info("Vanlig info är i vitt");
        Wait();
        GameInit();
        GameIntro();

        location = Room.Kök;
        while (location != Room.Utgång)
        {
            GameAction();
            if (fail) ShowFailMessage();
            if (angryGhost) ShowGhostMessage();
        }

        Assistent(RoomsDescription[Room.Utgång]);
        Assistent("....Game Over");
    }

    private static void ShowGhostMessage()
    {
        Assistent("Du hör ett blodisande skrik");
        Assistent("Rummet fylls av en mystisk dimma");
        Assistent("Du ser en varelse i dimman som kommer mot dig");
        Assistent("i hög hastighet. Du blundar, men känner dödens");
        Assistent("kyla när sig allt mer...");
        time -= 15;
        Wait();
        Console.BackgroundColor = (ConsoleColor)Colors.Warning;
        Console.ForegroundColor = (ConsoleColor)Colors.Info;
        Console.Clear();
        Console.WriteLine("                      :::!~!!!!!:.");
        Console.WriteLine("                  .xUHWH!! !!?M88WHX:.");
        Console.WriteLine("                .X*#M@$!!  !X!M$$$$$$WWx:.");
        Console.WriteLine("               :!!!!!!?H! :!$!$$$$$$$$$$8X:");
        Console.WriteLine("              !!~  ~:~!! :~!$!#$$$$$$$$$$8X:");
        Console.WriteLine("             :!~::!H!<   ~.U$X!?R$$$$$$$$MM!");
        Console.WriteLine("             ~!~!!!!~~ .:XW$$$U!!?$$$$$$RMM!");
        Console.WriteLine(@"               !:~~~ .:!M""T#$$$$WX??#MRRMMM!");
        Console.WriteLine(@"               ~?WuxiW*`   `""#$$$$8!!!!??!!!");
        Console.WriteLine(@"             :X- M$$$$       `""T#$T~!8$WUXU~");
        Console.WriteLine("            :%`  ~#$$$m:        ~!~ ?$$$$$$");
        Console.WriteLine(@"          :!`.-   ~T$$$$8xx.  .xWW- ~""""##*""");
        Console.WriteLine(".....   -~~:<` !    ~?T#$$@@W@*?$$      /`");
        Console.WriteLine(@"W$@@M!!! .!~~ !!     .:XUW$W!~ `""~:    :");
        Console.WriteLine(@"#""~~`.:x%`!!  !H:   !WM$$$$Ti.: .!WUn+!`");
        Console.WriteLine(@":::~:!!`:X~ .: ?H.!u ""$$$B$$$!W:U!T$$M~");
        Console.WriteLine(@".~~   :X@!.-~   ?@WTWo(""*$$$W$TH$! `");
        Console.WriteLine(@"Wi.~!X$?!-~    : ?$$$B$Wu(""**$RM!");
        Console.WriteLine("$R@i.~~ !     :   ~$$$$$B$$en:``");
        Console.WriteLine(@"?MXT@Wx.~    :     ~""##*$$$$M~");
        Console.ForegroundColor = (ConsoleColor)Colors.Assistant;
        Assistent("Du har failat :(");
        Assistent("Du missade tentan på grund av att du retade upp spöket.");
        Wait();
        Assistent("Game over!");
        Wait();
        Assistent("Dimman lättar och du hör spöket skratta");
        Assistent("- Ha Ha! Lurad! Vad skakis du blev! ha ha haaa");

        Assistent("Du flyr ut ur rummet");
        location = GetRandomRoom();
        MoveCreature(Creature.Spöke, GetRandomRoom());

        Console.BackgroundColor = (ConsoleColor)Colors.Background;
    }

    private static Room GetRandomRoom()
    {
        Random random = new Random();
        Room newRoom = Room.None;
        while (newRoom == Room.None || newRoom == Room.Utgång)
            newRoom = (Room)random.Next(1, Enum.GetValues(typeof(Room)).Length - 1);

        return newRoom;
    }

    private static void GameIntro()
    {
        Console.ForegroundColor = (ConsoleColor)Colors.Info;
        Console.WriteLine("Ring Ring Ring");
        if (GameOn) Thread.Sleep(1000);
        Console.Clear();
        Assistent("Godmorgon!");
        Assistent("Detta är din assistent som talar...");
        Assistent("Du har försovit dig! Och du måste ta dig till skolan genast.");
        Assistent("Det är Tentadag idag ju!");
        Assistent("");
    }

    /// <summary>
    /// Du har failat dude!
    /// </summary>
    private static void ShowFailMessage()
    {
        Console.BackgroundColor = (ConsoleColor)Colors.Warning;
        Console.ForegroundColor = (ConsoleColor)Colors.Info;
        Console.Clear();
        Console.WriteLine("                      :::!~!!!!!:.");
        Console.WriteLine("                  .xUHWH!! !!?M88WHX:.");
        Console.WriteLine("                .X*#M@$!!  !X!M$$$$$$WWx:.");
        Console.WriteLine("               :!!!!!!?H! :!$!$$$$$$$$$$8X:");
        Console.WriteLine("              !!~  ~:~!! :~!$!#$$$$$$$$$$8X:");
        Console.WriteLine("             :!~::!H!<   ~.U$X!?R$$$$$$$$MM!");
        Console.WriteLine("             ~!~!!!!~~ .:XW$$$U!!?$$$$$$RMM!");
        Console.WriteLine(@"               !:~~~ .:!M""T#$$$$WX??#MRRMMM!");
        Console.WriteLine(@"               ~?WuxiW*`   `""#$$$$8!!!!??!!!");
        Console.WriteLine(@"             :X- M$$$$       `""T#$T~!8$WUXU~");
        Console.WriteLine("            :%`  ~#$$$m:        ~!~ ?$$$$$$");
        Console.WriteLine(@"          :!`.-   ~T$$$$8xx.  .xWW- ~""""##*""");
        Console.WriteLine(".....   -~~:<` !    ~?T#$$@@W@*?$$      /`");
        Console.WriteLine(@"W$@@M!!! .!~~ !!     .:XUW$W!~ `""~:    :");
        Console.WriteLine(@"#""~~`.:x%`!!  !H:   !WM$$$$Ti.: .!WUn+!`");
        Console.WriteLine(@":::~:!!`:X~ .: ?H.!u ""$$$B$$$!W:U!T$$M~");
        Console.WriteLine(@".~~   :X@!.-~   ?@WTWo(""*$$$W$TH$! `");
        Console.WriteLine(@"Wi.~!X$?!-~    : ?$$$B$Wu(""**$RM!");
        Console.WriteLine("$R@i.~~ !     :   ~$$$$$B$$en:``");
        Console.WriteLine(@"?MXT@Wx.~    :     ~""##*$$$$M~");
        Console.ForegroundColor = (ConsoleColor)Colors.Assistant;
        Assistent("Du har failat :(");
        Assistent("Du missade tentan på grund av att du dummade dig.");
        Wait();
        Environment.Exit(0);
    }

    private static void ShowTimeLeft()
    {
        Info("Klockan är 8:" + (45 - time).ToString("00") + ".... Du har " + time + " minuter kvar");
        Console.Title = "Tentaspelet - Klockan är 8:" + (45 - time).ToString("00") + ".... Du har " + time + " minuter kvar";
        time--;
        fail = time <= 0;
    }

    /// <summary>
    /// Tolkar de kommandon som kommer in
    /// </summary>
    private static void TolkaKommando(string input)
    {
        CheckSudo(input);
        if (input == "") input = "help";
        var input_command = GetCommand(input); // Här tolkas kommandot
        var input_furniture = GetFurniture(input); // Här tolkas möbeln
        var input_item = GetItem(input); // Här tolkas föremålet
        var input_creature = GetCreature(input); // Här tolkas varelsen
        var input_location = GetARoom(input); // Här tolkas rummet

        switch (input_command)
        {
            case Command.WhereIs:
                if (input_creature == Creature.None)
                {
                    foreach (Creature critter in Enum.GetValues(typeof(Creature)))
                    {
                        Console.Write(critter + " är i ");
                        foreach (Room room in Enum.GetValues(typeof(Room)))
                        {
                            if (creaturePosition.ContainsKey(room) && creaturePosition[room].Contains(critter))
                                Console.WriteLine(room);
                        }
                    }
                }
                break;
            case Command.Beskriv:
                WatchThings(input_furniture, input_item, input_creature, input_location);
                break;

            case Command.Öppna:
                UnlockThings(input_furniture);
                break;

            case Command.Ge:
            case Command.Mata:
                FeedCreatures(input_item, input_creature);
                break;

            case Command.Lägg:
                if (ItemsInFurniture[Furniture.Inventory].Contains(input_item))
                {
                    DropStuff(input_furniture, input_item, input_location);
                }
                // Annars utgår vi från att personen vill lägga sig och sova
                else if (location is Room.Sovrum or Room.Säng)
                {
                    WentToBed();
                }
                else if (location == Room.Vardagsrum)
                {
                    FellAsleepInTheSofa();
                }
                else if (location == Room.Hall)
                {
                    Assistent("Hallgolvet är inte skön... Du ställer dig upp igen");
                }
                else
                {
                    Assistent("Du kan inte lägga dig där.");
                }
                break;

            case Command.Gå:
                // Om rummet (input_room) finns i exits, byt location dit
                MoveCreature(Creature.Spöke, GetRandomRoom());
                if (CheckIfLocationIsAvailable(input_location))
                {
                    if (input_location == Room.Säng)
                    {
                        WentToBedFromBedroom();
                    }
                    else
                    {
                        WentToAnotherRoom(input_location);
                    }
                }
                else
                {
                    Assistent("Duh! Du kan inte gå dit!");
                }
                break;

            case Command.Gosa:
            case Command.Rör:
                PetTheCreatures(input_furniture, input_creature);
                break;

            case Command.None:
                Assistent("Ärligt, jag förstår inte vad du menar!");
                break;

            case Command.Skrik:
                Assistent("AAAAAAAAGGGGGGGGGGGHHHHHHHHHHHHhhhhhhhhhhhh");
                angryGhost = true;
                break;

            case Command.Ta:
                TakeStuff(input_furniture, input_item);
                break;

            case Command.Hälsa:
                if (input_creature == Creature.Spöke)
                {
                    Assistent("Du hälsar glatt på spöket");
                    Info(" - Tjena spöket!");
                    Info(" - Tjena! svarade spöket");
                    angryGhost = false;
                }
                break;

            case Command.Vråla:
                break;

            case Command.Hjälp:
                break;
            case Command.Ät:
                break;
            default:
                Assistent("Försök att omformulera det du skrev");
                break;
        }
        Wait();
    }

    private static void CheckSudo(string input)
    {
        if (input.StartsWith("sudo"))
        {
            if (input == "sudo show rooms")
            {
                foreach (Room item in Enum.GetValues(typeof(Room)))
                    if (RoomsDescription.ContainsKey(item))
                        Console.WriteLine(item + " " + RoomsDescription[item]);
            }
            else if (input == "sudo show items")
            {
                foreach (Item item in Enum.GetValues(typeof(Item)))
                    if (ItemDescription.ContainsKey(item))
                        Console.WriteLine(item + " " + ItemDescription[item]);
            }
            else if (input == "sudo show furniture")
            {
                foreach (Furniture item in Enum.GetValues(typeof(Furniture)))
                    if (FurnitureDescription.ContainsKey(item))
                        Console.WriteLine(item + " " + FurnitureDescription[item]);
            }
            else if (input == "sudo show creatures")
            {
                foreach (Creature item in Enum.GetValues(typeof(Creature)))
                    if (CreatureDescription.ContainsKey(item))
                        Console.WriteLine(item + " " + CreatureDescription[item]);
            }
            else
            {
                Console.WriteLine("Unknown command");
            }
            time++;
            return;
        }

    }

    private static void TakeStuff(Furniture input_furniture, Item input_item)
    {
        if (input_item != Item.None)
        {
            if (VerifyItem(input_item, location))
            {
                Assistent("Du tog " + input_item);
                ItemLocations[location].Remove(input_item);
                ItemsInFurniture[Furniture.Inventory].Add(input_item);
            }
            else if (VerifyItem(input_item, location))
            {
                Assistent("Du tog " + input_item);
                ItemsInFurniture[input_furniture].Remove(input_item);
                ItemsInFurniture[Furniture.Inventory].Add(input_item);
            }
            else
            {
                Assistent("Du kan inte ta det");
            }
        }
        else
        {
            Assistent("Jag förstår inte vad du vill göra");
        }
    }

    private static void PetTheCreatures(Furniture input_furniture, Creature input_creature)
    {
        if (input_creature == Creature.Katt)
        {
            Assistent("Du klappade katten och den kurrade glatt");
        }
        else if (input_creature == Creature.Hund)
        {
            Assistent("Du klappade hunden som glatt viftade på svansen");
        }
        else if (input_creature == Creature.Spöke)
        {
            Assistent("Spöket viftade bort din hand");
        }
        else if (input_furniture == Furniture.Kudde)
            Assistent("Fin kudde... du klappade på den... fin kudde...");
        else
        {
            Assistent("Jag förstår inte vad du menar");
        }
    }

    private static void WentToAnotherRoom(Room input_location)
    {
        Assistent("Du gick till " + input_location.ToString());
        location = input_location;
        if (location == Room.Säng || location == Room.Vardagsrum)
        {
            MoveCreature(Creature.Katt, location);
            MoveCreature(Creature.Hund, location);
        }
        else
        {
            // hunden springer överallt
            MoveCreature(Creature.Hund, GetRandomRoom());
        }
    }

    private static void WentToBedFromBedroom()
    {
        Assistent("Din säng är väldigt skön att sova i.");
        Assistent("Du somnade och missade tentan :(");
        fail = true;
    }

    private static void FellAsleepInTheSofa()
    {
        Assistent("Du la dig i soffan...");
        Assistent("Satte på TVn och kollade på en mysig skräckfilm");
        Assistent("När filmen var klar insåg du att du hade missat");
        Assistent("tentan :(");
        fail = true;
    }

    private static void WentToBed()
    {
        Assistent("Du la dig i sängen...");
        Assistent("Din säng är väldigt skön att sova i.");
        Assistent("Du somnade snabbt...");
        Assistent("... och missade tentan :(");
        fail = true;
    }

    private static void DropStuff(Furniture input_furniture, Item input_item, Room input_location)
    {
        // Om man har saken kan man lägga det i en möbel
        if (input_furniture != Furniture.None)
        {
            ItemsInFurniture[Furniture.Inventory].Remove(input_item);
            ItemsInFurniture[input_furniture].Add(input_item);
        }
        // Om man har saken kan man lägga det i ett rum
        else if (input_location != Room.None)
        {
            ItemsInFurniture[Furniture.Inventory].Remove(input_item);
            ItemLocations[location].Add(input_item);
        }
    }

    private static void FeedCreatures(Item input_item, Creature input_creature)
    {
        if (input_creature == Creature.Katt)
        {
            FeedTheCat(input_item);
        }
        else if (input_creature == Creature.Hund)
        {
            FeedTheDog(input_item);
        }
        else if (input_creature == Creature.Spöke)
        {
            FeedTheGhost();
        }
        else
        {
            Assistent("Du kan inte mata den med det.");
        }
    }

    private static void MoveCreature(Creature critter, Room location)
    {
        // Sök alla rum efter djuret

        foreach (Room room in Enum.GetValues(typeof(Room)))
        {
            while (creaturePosition.ContainsKey(room) && creaturePosition[room].Contains(critter))
                creaturePosition[room].Remove(critter);
        }

        if (creaturePosition.ContainsKey(location))
            creaturePosition[location].Add(critter);
    }

    private static void UnlockThings(Furniture input_furniture)
    {
        if (location == Room.Hall)
        {
            if (input_furniture == Furniture.Låst_dörr)
            {
                if (!catHasBeenFed)
                {
                    Assistent("Du måste ha matat katten innan du får gå! :(");
                }
                else if (!dogHasBeenFed)
                {
                    Assistent("Du måste ha matat hunden innan du får gå! :(");
                }
                else if (!breakfastHasBeenEaten)
                {
                    Assistent("Du måste ha ätit frukost innan du får gå! :(");
                }
                else if (ItemsInFurniture[Furniture.Inventory].Contains(Item.Nyckel))
                {
                    Assistent("Du öppnar dörren och går ut.");
                    location = Room.Utgång;
                }
                else
                {
                    Assistent("Du har ingen nyckel. :(");
                }
            }
        }
        else
        {
            Assistent("Det går inte att öppna något här.");
        }
    }

    private static void WatchCreature(Creature input_creature)
    {
        Assistent(CreatureDescription[input_creature]);
    }

    private static void WatchFurniture(Furniture input_furniture)
    {
        Assistent(FurnitureDescription[input_furniture]);
        if (ItemsInFurniture.Count > 0)
        {
            Assistent("Det finns något i " + input_furniture.ToString());
            ListItemsAvailable(input_furniture, ItemsInFurniture[input_furniture]);
        }
    }

    private static void WatchItemInFurniture(Furniture input_furniture, Item input_item)
    {
        if (ItemsInFurniture[input_furniture].Count > 0)
        {
            if (ItemsInFurniture[input_furniture].Contains(input_item))
            {
                Assistent(ItemDescription[input_item]);
                if (ItemsInItems[input_item].Count > 0)
                {
                    Assistent("Den innehåller");
                    ListItemsAvailable(input_item, ItemsInItems[input_item]);
                }
            }
            else
            {
                Assistent("Det finns inget " + input_item.ToString() + " i " + input_furniture.ToString());
            }
        }
    }

    private static void WatchItemInInventory(Item input_item)
    {
        Assistent(ItemDescription[input_item]);
        if (ItemsInItems.ContainsKey(input_item))
            if (ItemsInItems[input_item].Count > 0)
                ListItemsAvailable(input_item, ItemsInItems[input_item]);
    }

    private static void WatchItemInLocation(Item input_item)
    {
        Assistent(ItemDescription[input_item]);
        if (ItemsInItems[input_item].Count > 0)
        {
            Assistent("Det finns något i " + input_item.ToString());
            foreach (Item i1 in ItemsInItems[input_item])
            {
                Assistent("Det är " + i1.ToString());
                if (ItemsInItems[i1].Count > 0)
                {
                    Console.WriteLine("Den innehåller");
                    foreach (Item i2 in ItemsInItems[i1])
                        Console.WriteLine("* " + i2);
                }
            }
        }
    }

    private static void WatchLocation()
    {
        Assistent(RoomsDescription[location]);
        // list forniture in location
        if (FurnitureInRoom[location].Count > 0)
        {
            foreach (Furniture f in FurnitureInRoom[location])
                Console.WriteLine(f);
        }
    }

    private static void WatchThings(Furniture input_furniture, Item input_item, Creature input_creature, Room input_location)
    {
        if (FurnitureInRoom[location].Contains(input_furniture) && input_item == Item.None)
        {
            WatchFurniture(input_furniture);
        }
        else if (FurnitureInRoom[location].Contains(input_furniture) && input_item != Item.None)
        {
            WatchItemInFurniture(input_furniture, input_item);
        }
        else if (ItemLocations[location].Contains(input_item))
        {
            WatchItemInLocation(input_item);
        }
        else if (ItemsInFurniture[Furniture.Inventory].Contains(input_item))
        {
            WatchItemInInventory(input_item);
        }
        else if (creaturePosition[location].Contains(input_creature))
        {
            WatchCreature(input_creature);
        }
        else if (input_location == location)
        {
            WatchLocation();
        }
        else // Ye njet comprendez what you speako om
        {
            Assistent("Jag kan inte se det här. :(");
        }
    }

    #region Game tools

    private static void Assistent(string message = "")
    {
        Console.ForegroundColor = (ConsoleColor)Colors.Assistant;
        WriteLine(message);
        Console.ForegroundColor = (ConsoleColor)Colors.Info;
    }

    private static string GetItemLists(Room location)
    {
        var response = "";
        foreach (var thingy in FurnitureInRoom[location])
            response += thingy.ToString() + ", ";

        foreach (var creature in creaturePosition[location])
            response += creature.ToString() + ", ";

        return response.Trim().TrimEnd(',').Trim();
    }

    private static void Info(string message = "")
    {
        Console.ForegroundColor = (ConsoleColor)Colors.Info;
        Console.WriteLine(message);
    }

    private static void GameInit()
    {
        Console.ForegroundColor = (ConsoleColor)Colors.Info;
        Console.BackgroundColor = (ConsoleColor)Colors.Background;
        Console.Clear();
        Console.Write(" ");
        if (GameOn) Thread.Sleep(1500);
        Console.Clear();
        Console.Write(" ");
        if (GameOn) Thread.Sleep(1500);
        Console.Clear();
        Console.Write(" ");
        if (GameOn) Thread.Sleep(1500);
        Console.Clear();

        #region Alias info

        RoomAlias[Room.Sovrum] = new List<string> { "sovrum", "Sovrummet", "rummet" };
        RoomAlias[Room.Kök] = new List<string> { "Köket", "matsal", "matsalen" };
        RoomAlias[Room.Vardagsrum] = new List<string> { "Vardagsrummet", "TVrummet" };
        RoomAlias[Room.Badrum] = new List<string> { "Badrummet", "toan", "toa" };
        RoomAlias[Room.Hall] = new List<string> { "Hallen" };
        RoomAlias[Room.Säng] = new List<string> { "Sängen" };
        RoomAlias[Room.Utgång] = new List<string> { "ut", "skolan" };
        foreach (Room alias in Enum.GetValues(typeof(Room)))
            if (alias != Room.None) RoomAlias[alias].Add(alias.ToString());

        FurnitureAlias[Furniture.Säng] = new List<string> { "sängen", "säng" };
        FurnitureAlias[Furniture.Diskmaskin] = new List<string> { "disken", "maskin", "diskmaskinen" };
        FurnitureAlias[Furniture.Duschgolv] = new List<string> { "golv", "golvet", "duschgolvet" };
        FurnitureAlias[Furniture.Dörr_ut] = new List<string> { "dörren", "ut", "frihet", "skolan" };
        FurnitureAlias[Furniture.Spisfläkt] = new List<string> { "fläkt", "fläkten", "spisfläkt" };
        FurnitureAlias[Furniture.Fönsterkarm] = new List<string> { "karm", "karmen", "fönsterkarmen" };
        FurnitureAlias[Furniture.Klädskåp] = new List<string> { "skåp", "skåpet", "klädskåp", "kläder" };
        FurnitureAlias[Furniture.Kudde] = new List<string> { "kudden" };
        FurnitureAlias[Furniture.Kökskåp] = new List<string> { "skåp", "skåpet", "köksskåpet" };
        FurnitureAlias[Furniture.Låst_dörr] = new List<string> { "dörren", "låst", "låsta" };
        FurnitureAlias[Furniture.Soffa] = new List<string> { "soffa", "soffan" };
        FurnitureAlias[Furniture.Spis] = new List<string> { "spis", "spisen" };
        FurnitureAlias[Furniture.Städskåp] = new List<string> { "städskåpet", "skåp" };
        FurnitureAlias[Furniture.Säng] = new List<string> { "sängen", "bädd" };
        FurnitureAlias[Furniture.Sängbord] = new List<string> { "bord", "sängbordet", "bordet" };
        FurnitureAlias[Furniture.Tittöga] = new List<string> { "öga", "ögat", "tittögat" };
        FurnitureAlias[Furniture.Toalettskåp] = new List<string> { "skåp", "skåpet", "toalettskåp" };
        FurnitureAlias[Furniture.Toalettstol] = new List<string> { "dass", "tronen", "toa", "toalettstolen", "stol", "stolen" };
        FurnitureAlias[Furniture.TV] = new List<string> { "tv", "tvn" };
        FurnitureAlias[Furniture.TVmöbel] = new List<string> { "tvmöbel", "möbeln", "tvmöbeln" };
        FurnitureAlias[Furniture.Ugn] = new List<string> { "ugnen", "ugn" };
        foreach (Furniture alias in Enum.GetValues(typeof(Furniture)))
            if (alias != Furniture.None && alias != Furniture.Inventory) FurnitureAlias[alias].Add(alias.ToString());

        ItemAlias[Item.Frukost] = new List<string> { "frukost", "frukosten", "mat", "kaffe" };
        ItemAlias[Item.Hundmat] = new List<string> { "maten", "hundmaten" };
        ItemAlias[Item.Kattmat] = new List<string> { "maten", "kattmaten" };
        ItemAlias[Item.Lås] = new List<string> { "låset" };
        ItemAlias[Item.Nyckel] = new List<string> { "nyckeln" };
        ItemAlias[Item.Soffkudde] = new List<string> { "kudde", "soffkudden", "kudden" };
        foreach (Item alias in Enum.GetValues(typeof(Item)))
            if (alias != Item.None) ItemAlias[alias].Add(alias.ToString());

        CreatureAlias[Creature.Spöke] = new List<string> { "spöket", "ghost", "spöke" };
        CreatureAlias[Creature.Hund] = new List<string> { "hunden", "hund", "vovve", "vovven", "fido", "jycke", "jycken", "byracka" };
        CreatureAlias[Creature.Katt] = new List<string> { "katten", "katt", "miau", "misse", "missen", "kattkräk", "kattfan", "måns" };
        foreach (Creature alias in Enum.GetValues(typeof(Creature)))
            if (alias != Creature.None) CreatureAlias[alias].Add(alias.ToString());

        CommandAlias[Command.Beskriv] = new List<string> { "se", "titta", "kolla" };
        CommandAlias[Command.Ge] = new List<string> { "ge", "langa" };
        CommandAlias[Command.Gosa] = new List<string> { "kela", "smek", "klappa" };
        CommandAlias[Command.Gå] = new List<string> { "gåtill" };
        CommandAlias[Command.Hjälp] = new List<string> { "halp", "kommandon", "/?", "-?", "?", "help" };
        CommandAlias[Command.Hälsa] = new List<string> { "vinka" };
        CommandAlias[Command.Lägg] = new List<string> { "släpp", "läggner", "släng" };
        CommandAlias[Command.Mata] = new List<string> { "mata" };
        CommandAlias[Command.Öppna] = new List<string> { "låsupp" };
        CommandAlias[Command.Rör] = new List<string> { "" };
        CommandAlias[Command.Skrik] = new List<string> { "" };
        CommandAlias[Command.Ta] = new List<string> { "plocka" };
        CommandAlias[Command.Ät] = new List<string> { "käka", "drick" };
        CommandAlias[Command.Vråla] = new List<string> { "growla" };
        CommandAlias[Command.WhereIs] = new List<string> { "var", "where", "varär", "whois" };
        foreach (Command alias in Enum.GetValues(typeof(Command)))
            if (alias != Command.None) CommandAlias[alias].Add(alias.ToString());

        #endregion Alias info

        #region Description info

        RoomsDescription.Add(Room.Hall, "Du är i hallen. Det är en liten hall med skåp på väggarna.");
        RoomsDescription.Add(Room.Kök, "Du är i köket. Det är ett litet kök med en liten matbord och ett litet kylskåp.");
        RoomsDescription.Add(Room.Säng, "Du är i sängen. Det är en liten men gosig säng.");
        RoomsDescription.Add(Room.Sovrum, "Du är i sovrummet. Det är en liten säng och ett litet nattduksbord, och ett litet klädskåp.");
        RoomsDescription.Add(Room.Badrum, "Du är i badrummet. Det är en liten toalett och en liten dusch.");
        RoomsDescription.Add(Room.Utgång, "Du lyckades ta dig ut ur lägenheten. Rusa nu till skolan! Lycka till med tentan.");
        RoomsDescription.Add(Room.Vardagsrum, "Du är i vardagsrummet. Det är en liten soffa och en liten TV.");

        ItemDescription.Add(Item.Frukost, "Det är en liten frukost med en liten kopp kaffe.");
        ItemDescription.Add(Item.Hundmat, "Det är en liten burk med hundmat.");
        ItemDescription.Add(Item.Kattmat, "Det är en liten burk med kattmat.");
        ItemDescription.Add(Item.Lås, "Det är ett litet lås gjort för ett litet nyckel.");
        ItemDescription.Add(Item.Nyckel, "Det är en liten nyckel.");
        ItemDescription.Add(Item.Soffkudde, "Soffkudden är fluffig och har en bild av en fet och hårig katt.");

        CreatureDescription.Add(Creature.Hund, "Fido! Din snälla och glada hund som spenderar dagarna med att sova och nätterna med att jaga katten");
        CreatureDescription.Add(Creature.Katt, "Måns! Din slöa håriga katt, som spenderar dagarna med att sova och nätterna med att studsa på dig, plus att han håller spöken borta");
        CreatureDescription.Add(Creature.Spöke, "Det är spöket av någon som bott i lägenheten innan");

        FurnitureDescription.Add(Furniture.Diskmaskin, "Diskmaskinen är tömd och väntar på att fyllas med disk");
        FurnitureDescription.Add(Furniture.Dörr_ut, "Dörren är olåst");
        FurnitureDescription.Add(Furniture.Duschgolv, "Duschgolvet är blött. Har du duschat i sömnen?");
        FurnitureDescription.Add(Furniture.Spisfläkt, "Köksfläkten står och väntar på att du ska börja laga mat.");
        FurnitureDescription.Add(Furniture.Klädskåp, "Här finns dina kläder... en hel del kläder... massor med kläder... herregud vad mycket kläder!!!");
        FurnitureDescription.Add(Furniture.Kökskåp, "Här finns tallrikar, koppar, muggar, glas och annat.");
        FurnitureDescription.Add(Furniture.Kudde, "Kudden är mjuk och fluffig");
        FurnitureDescription.Add(Furniture.Låst_dörr, "Dörren är låst");
        FurnitureDescription.Add(Furniture.Säng, "Sängen är liten men gosig.");
        FurnitureDescription.Add(Furniture.Sängbord, "På sängbordet finns en trasig väckarklocka som var bra tills du slängde den i väggen :-/");
        FurnitureDescription.Add(Furniture.Soffa, "Soffan är liten men gosig och lätt att somna i.");
        FurnitureDescription.Add(Furniture.Spis, "Spisen känns varm, som om någon redan lagat mat.");
        FurnitureDescription.Add(Furniture.Städskåp, "Städskåpet är fylld med redskap, flaskor med rengöringsmedel och annat mysko.");
        FurnitureDescription.Add(Furniture.Tittöga, "Utanför dörren kan du se: §");
        FurnitureDescription.Add(Furniture.Toalettskåp, "I toalettskåpet finns ett parfymer, aftershave, tandborstar och ... vänta lite nu... hur många tandborstar använder du egentligen? WTF?");
        FurnitureDescription.Add(Furniture.Toalettstol, "Toastolen ser ut som en toastol brukar se ut");
        FurnitureDescription.Add(Furniture.TV, "Din lilla TV fungerar bra för Netflux, Xbix eller PlejStation (ingen dold reklam här inte!)");
        FurnitureDescription.Add(Furniture.TVmöbel, "TV möbeln har sett bättre dagar... du borde damma den!");
        FurnitureDescription.Add(Furniture.Ugn, "Ugnen är stor nog att rymma en kyckling eller en purjolök om man lägger den vertikalt. Varför vill man lägga pujorlök vertikalt i en ugn egenligen? Vad är det för fel på dig?");
        FurnitureDescription.Add(Furniture.Fönsterkarm, "På fönsterkarmen står det blommor som är helt ointressanta för swn här storyn");
        #endregion Description info

        #region Thing's location info

        FurnitureInRoom.Add(Room.Säng, new List<Furniture> { Furniture.Kudde });
        FurnitureInRoom.Add(Room.Sovrum, new List<Furniture> { Furniture.Fönsterkarm, Furniture.Sängbord, Furniture.Klädskåp });
        FurnitureInRoom.Add(Room.Vardagsrum, new List<Furniture> { Furniture.TV, Furniture.TVmöbel, Furniture.Soffa });
        FurnitureInRoom.Add(Room.Badrum, new List<Furniture> { Furniture.Duschgolv, Furniture.Toalettskåp, Furniture.Toalettstol });
        FurnitureInRoom.Add(Room.Kök, new List<Furniture> { Furniture.Spis, Furniture.Ugn, Furniture.Spisfläkt, Furniture.Kökskåp });
        FurnitureInRoom.Add(Room.Hall, new List<Furniture> { Furniture.Städskåp });
        FurnitureInRoom.Add(Room.Utgång, new List<Furniture> { Furniture.Låst_dörr, Furniture.Tittöga });

        creaturePosition.Add(Room.Säng, new List<Creature> { Creature.Katt, Creature.Hund });
        creaturePosition.Add(Room.Sovrum, new List<Creature> { });
        creaturePosition.Add(Room.Vardagsrum, new List<Creature> { });
        creaturePosition.Add(Room.Badrum, new List<Creature> { Creature.Spöke });
        creaturePosition.Add(Room.Kök, new List<Creature> { });
        creaturePosition.Add(Room.Hall, new List<Creature> { });

        ItemLocations.Add(Room.Hall, new List<Item> { });
        ItemLocations.Add(Room.Kök, new List<Item> { });
        ItemLocations.Add(Room.Sovrum, new List<Item> { });
        ItemLocations.Add(Room.Säng, new List<Item> { });
        ItemLocations.Add(Room.Badrum, new List<Item> { });
        ItemLocations.Add(Room.Utgång, new List<Item> { });
        ItemLocations.Add(Room.Vardagsrum, new List<Item> { });

        #endregion Thing's location info

        #region Item's location info

        ItemsInFurniture.Add(Furniture.Diskmaskin, new List<Item> { });
        ItemsInFurniture.Add(Furniture.Duschgolv, new List<Item> { });
        ItemsInFurniture.Add(Furniture.Spisfläkt, new List<Item> { });
        ItemsInFurniture.Add(Furniture.Fönsterkarm, new List<Item> { });
        ItemsInFurniture.Add(Furniture.Klädskåp, new List<Item> { });
        ItemsInFurniture.Add(Furniture.Kudde, new List<Item> { });
        ItemsInFurniture.Add(Furniture.Kökskåp, new List<Item> { Item.Kattmat, Item.Hundmat });
        ItemsInFurniture.Add(Furniture.Spis, new List<Item> { Item.Frukost });
        ItemsInFurniture.Add(Furniture.Städskåp, new List<Item> { });
        ItemsInFurniture.Add(Furniture.Säng, new List<Item> { });
        ItemsInFurniture.Add(Furniture.Sängbord, new List<Item> { });
        ItemsInFurniture.Add(Furniture.Toalettskåp, new List<Item> { });
        ItemsInFurniture.Add(Furniture.Toalettstol, new List<Item> { });
        ItemsInFurniture.Add(Furniture.TVmöbel, new List<Item> { });
        ItemsInFurniture.Add(Furniture.Ugn, new List<Item> { });
        ItemsInFurniture.Add(Furniture.Soffa, new List<Item> { Item.Soffkudde });
        ItemsInFurniture.Add(Furniture.TV, new List<Item> { });
        ItemsInFurniture.Add(Furniture.Dörr_ut, new List<Item> { });
        ItemsInFurniture.Add(Furniture.Låst_dörr, new List<Item> { });
        ItemsInFurniture.Add(Furniture.Tittöga, new List<Item> { });
        ItemsInFurniture.Add(Furniture.Inventory, new List<Item> { });
        ItemsInItems.Add(Item.Soffkudde, new List<Item> { Item.Nyckel });

        #endregion Item's location info

        exits.Add(Room.Säng, new List<Tuple<Room, string, string>>
        {
            new Tuple<Room, string, string>(Room.Sovrum, "Upp", "Gå upp ur sängen"),
        });
        exits.Add(Room.Sovrum, new List<Tuple<Room, string, string>>
        {
            new Tuple<Room, string, string>(Room.Säng, "Säng", "Lägg dig i sängen igen"),
            new Tuple<Room, string, string>(Room.Badrum, "Toa", "Gå till badrummet"),
            new Tuple<Room, string, string>(Room.Kök, "Kök", "Gå till köket"),
        });
        exits.Add(Room.Badrum, new List<Tuple<Room, string, string>>
        {
            new Tuple<Room, string, string>(Room.Sovrum, "Sovrummet", "Gå tillbaka till sovrummet"),
            new Tuple<Room, string, string>(Room.Hall, "Hall", "Gå tillbaka till hallen"),
        });
        exits.Add(Room.Kök, new List<Tuple<Room, string, string>>
        {
            new Tuple<Room, string, string>(Room.Sovrum, "Sovrummet", "Gå tillbaka till sovrummet"),
            new Tuple<Room, string, string>(Room.Hall, "Hall", "Gå till hallen"),
        });
        exits.Add(Room.Hall, new List<Tuple<Room, string, string>>
        {
            new Tuple<Room, string, string>(Room.Kök, "Kök", "Gå tillbaka till köket"),
            new Tuple<Room, string, string>(Room.Badrum, "Dass", "Gå på dass"),
            new Tuple<Room, string, string>(Room.Vardagsrum, "Vardagsrum", "Gå till vardagsrummet"),

        });
        exits.Add(Room.Vardagsrum, new List<Tuple<Room, string, string>>
        {
            new Tuple<Room, string, string>(Room.Hall, "Hall", "Gå tillbaka till hallen"),
        });
        exits.Add(Room.Utgång, new List<Tuple<Room, string, string>>
        {
            new Tuple<Room, string, string>(Room.Utgång, "Dörr", "Lås upp dörren"),
        });
    }

    private static string Inventory()
    {
        var response = "";
        foreach (var thingy in ItemsInFurniture[Furniture.Inventory])
            response += thingy.ToString() + ", ";

        return response.Trim().TrimEnd(',').Trim();
    }

    private static void Wait()
    {
        Console.ForegroundColor = (ConsoleColor)Colors.Info;
        Console.Write("Tryck [");
        Console.ForegroundColor = (ConsoleColor)Colors.Wait;
        Console.Write("ENTER");
        Console.ForegroundColor = (ConsoleColor)Colors.Info;
        Console.Write("] för att fortsätta.");
        Console.ReadLine();
    }

    private static void Write(string text)
    {
        WriteLine(text, false);
    }

    private static void WriteLine(string text = "", bool newLine = true)
    {
        Random random = new();
        if (text?.Length == 0)
        {
            Console.WriteLine();
        }
        else
        {
            // Simulate typewriter by pausing randomly and writing one or two chars
            var lastSymbol = ' ';
            foreach (var symbol in text)
            {
                var paus = random.Next(10, 200); // Hur många millisekunder pausen ska vara
                if (lastSymbol == symbol) // om tecknet upprepas
                {
                    if (GameOn) Thread.Sleep(10); // pausa i 10 millisekunder
                    else if (random.Next(0, 100) > 40) // 50% chans att pausen skippas
                        if (GameOn) Thread.Sleep(paus); // gör en paus
                }

                lastSymbol = symbol;
                Console.Write(symbol); // skriv ut ett tecken
            }
            if (GameOn) Thread.Sleep(400);
            if (newLine) Console.WriteLine(); // skriv ut en tomrad
        }
    }

    #endregion Game tools

    #region Game items

    private enum Colors
    {
        Assistant = ConsoleColor.Yellow,
        Background = ConsoleColor.DarkBlue,
        Creature = ConsoleColor.DarkMagenta,
        Furniture = ConsoleColor.DarkGray,
        Important = ConsoleColor.Green,
        Info = ConsoleColor.White,
        Player = ConsoleColor.Cyan,
        Wait = ConsoleColor.DarkYellow,
        Warning = ConsoleColor.Red,
    }

    private enum Command
    {
        Beskriv,
        Gå,
        Ge,
        Gosa,
        Hjälp,
        Hälsa,
        Lägg,
        Mata,
        Öppna,
        Rör,
        Skrik,
        Ta,
        Vråla,
        Ät,
        WhereIs,
        None = 99,
    }

    private enum Creature
    {
        Hund, Katt, Spöke,
        None = 99
    }

    private enum Furniture
    {
        Inventory = -1,
        Diskmaskin, Dörr_ut, Duschgolv, Spisfläkt,
        Fönsterkarm, Klädskåp, Kökskåp, Kudde,
        Låst_dörr, Säng, Sängbord, Soffa,
        Spis, Städskåp, Tittöga,
        Toalettskåp, Toalettstol, TV, TVmöbel, Ugn,
        None = 99
    }

    private enum Item
    {
        Frukost, Hundmat, Kattmat,
        Lås, Nyckel, Soffkudde,
        None = 99
    }

    private enum Room
    {
        Hall, Kök, Säng, Sovrum,
        Badrum, Utgång, Vardagsrum,
        None = 99
    }

    #endregion Game items
}