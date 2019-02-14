using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public static class World
    {
        // All lists for storing
        public static readonly List<Item> Items = new List<Item>();
        public static readonly List<Monster> Monsters = new List<Monster>();
        public static readonly List<Quest> Quests = new List<Quest>();
        public static readonly List<Location> Locations = new List<Location>();

        // Creating all items
        public const int ITEM_ID_RUSTY_SWORD = 1;
        public const int ITEM_ID_RAT_TAIL = 2;
        public const int ITEM_ID_PIECE_OF_FUR = 3;
        public const int ITEM_ID_SNAKE_FANG = 4;
        public const int ITEM_ID_SNAKESKIN = 5;
        public const int ITEM_ID_CLUB = 6;
        public const int ITEM_ID_HEALING_POTION = 7;
        public const int ITEM_ID_SPIDER_FANG = 8;
        public const int ITEM_ID_SPIDER_SILK = 9;
        public const int ITEM_ID_ADVENTURER_PASS = 10;
        public const int ITEM_ID_BRONZE_SWORD = 11;
        public const int ITEM_ID_IRON_SWORD = 12;
        public const int ITEM_ID_MITHRIL_SWORD = 13;
        public const int ITEM_ID_ADAMANTITE_SWORD = 14;
        public const int ITEM_ID_RUNITE_SWORD = 15;
        public const int ITEM_ID_SWORD_OF_GREATNESS = 16;
        public const int ITEM_ID_WORLD_BREAKER = 17;
        public const int ITEM_ID_UNIVERSE_CONQUEROR = 18;
        public const int ITEM_ID_BRONZE_AXE = 19;
        public const int ITEM_ID_SPIKED_CLUB = 20;
        public const int ITEM_ID_STEEL_AXE = 21;
        public const int ITEM_ID_SKULL_BREAKER = 22;
        public const int ITEM_ID_BLOOD_THIRSTY_AXE = 23;
        public const int ITEM_ID_OVERDRIVE_CLUB = 24;
        public const int ITEM_ID_DRAGON_SLAYER = 25;
        public const int ITEM_ID_MOUNTAIN_LEVELING_WARAXE = 26;
        public const int ITEM_ID_DREAD_AXE = 27;
        public const int ITEM_ID_THORS_HAMMER = 28;
        public const int ITEM_ID_DRACULAS_HEAD = 29;
        public const int ITEM_ID_BIG_GOBLIN_EMERALDS = 30;
        public const int ITEM_ID_SUPER_HEALING_POTION = 31;
        public const int ITEM_ID_MAX_HEALING_POTION = 32;
        public const int ITEM_ID_BANSHEE_SOUL = 33;
        public const int UNSELLABLE_ITEM_PRICE = -1;

        // Creating all monsters
        public const int MONSTER_ID_RAT = 1;
        public const int MONSTER_ID_SNAKE = 2;
        public const int MONSTER_ID_GIANT_SPIDER = 3;
        public const int MONSTER_ID_GHOST = 4;
        public const int MONSTER_ID_BANSHEE = 5;
        public const int MONSTER_ID_DRACULA = 6;
        public const int MONSTER_ID_GOBLIN = 7;
        public const int MONSTER_ID_GOBLIN_HORD = 8;
        public const int MONSTER_ID_GOBLIN_WARCHIEF = 9;
        public const int MONSTER_ID_GOBLIN_BOSS = 10;
        public const int MONSTER_ID_GIANT_GOBLIN = 11;

        // Creating all quests
        public const int QUEST_ID_CLEAR_ALCHEMIST_GARDEN = 1;
        public const int QUEST_ID_CLEAR_FARMERS_FIELD = 2;
        public const int QUEST_ID_CLEAR_CAMPSITE_DANGER = 3;
        public const int QUEST_ID_CLEAR_GOBLIN_ATTACK_ON_THE_CAPITAL = 4;

        // Creating all locations
        public const int LOCATION_ID_HOME = 1;
        public const int LOCATION_ID_TOWN_SQUARE = 2;
        public const int LOCATION_ID_GUARD_POST = 3;
        public const int LOCATION_ID_ALCHEMIST_HUT = 4;
        public const int LOCATION_ID_ALCHEMISTS_GARDEN = 5;
        public const int LOCATION_ID_FARMHOUSE = 6;
        public const int LOCATION_ID_FARM_FIELD = 7;
        public const int LOCATION_ID_BRIDGE = 8;
        public const int LOCATION_ID_SPIDER_FIELD = 9;
        public const int LOCATION_ID_CAMPSITE = 10;
        public const int LOCATION_ID_GRAVEYARD = 11;
        public const int LOCATION_ID_RUINS = 12;
        public const int LOCATION_ID_CASTLE_RUINS = 13;
        public const int LOCATION_ID_LARGE_FIELD = 14;
        public const int LOCATION_ID_CAPITAL_OF_OZANGURA_ENTRANCE = 15;
        public const int LOCATION_ID_CENTRAL_OF_THE_CAPITAL = 16;
        public const int LOCATION_ID_SHOPPING_DISTRICT = 17;
        public const int LOCATION_ID_LIVING_DISTRICT = 18;
        public const int LOCATION_ID_CHURCH_DISTRICT = 19;
        public const int LOCATION_ID_CATLE_OF_THE_CAPITAL = 20;
        public const int LOCATION_ID_BACK_GATE_OF_THE_CAPITAL = 21;
        public const int LOCATION_ID_GOBLIN_WOODS = 22;
        public const int LOCATION_ID_GOBLIN_CAVE = 23;
        public const int LOCATION_ID_GOBLIN_CAVE_DINING_HALL = 24;
        public const int LOCATION_ID_GOBLIN_CAVE_MAIN_QUARTERS = 25;
        public const int LOCATION_ID_GOBLIN_CAVE_EXIT = 26;

        // Calling all functions needed for the game world
        static World()
        {
            PopulateItems();
            PopulateMonsters();
            PopulateQuests();
            PopulateLocations();
        }

        private static void PopulateItems()
        {
            // All swords are added into the game
            Items.Add(new Weapon(ITEM_ID_RUSTY_SWORD, "Rusty Sword", "Rusty Swords", 1, 5, 1));
            Items.Add(new Weapon(ITEM_ID_BRONZE_SWORD, "Bronze Sword", "Bronze Swords", 3, 13, 10));
            Items.Add(new Weapon(ITEM_ID_IRON_SWORD, "Iron Sword", "Iron Swords", 5, 20, 15));
            Items.Add(new Weapon(ITEM_ID_MITHRIL_SWORD, "Mithril Sword", "Mithril Swords", 10, 25, 50));
            Items.Add(new Weapon(ITEM_ID_ADAMANTITE_SWORD, "Adamantite Sword", "Adamantite Swords", 12, 30, 100));
            Items.Add(new Weapon(ITEM_ID_RUNITE_SWORD, "Runite Sword", "Runite Swords", 20, 45, 500));
            Items.Add(new Weapon(ITEM_ID_SWORD_OF_GREATNESS, "Sword of Greatness", "Swords of Greatness", 45, 75, 1000));
            Items.Add(new Weapon(ITEM_ID_WORLD_BREAKER, "World Breaker", "World Breakers", 100, 180, 6000));
            Items.Add(new Weapon(ITEM_ID_UNIVERSE_CONQUEROR, "Universe Conqueror", "Universe Conquerors", 200, 400, 1000000));

            // All rat items are added into the game
            Items.Add(new Item(ITEM_ID_RAT_TAIL, "Rat Tail", "Rat Tails", 3));
            Items.Add(new Item(ITEM_ID_PIECE_OF_FUR, "Piece of Fur", "Pieces of Fur", 15));

            // All snake items are added into the game
            Items.Add(new Item(ITEM_ID_SNAKE_FANG, "Snake Fang", "Snake Fangs", 3));
            Items.Add(new Item(ITEM_ID_SNAKESKIN, "Snakeskin", "Snakeskins", 20));

            // All blunt weapons are added into the game
            Items.Add(new Weapon(ITEM_ID_CLUB, "Club", "Clubs", 5, 20, 10));
            Items.Add(new Weapon(ITEM_ID_BRONZE_AXE, "Bronze Axe", "Bronze Axes", 5, 40, 20));
            Items.Add(new Weapon(ITEM_ID_SPIKED_CLUB, "Spiked Club", "Spiked Clubs", 5, 25, 20));
            Items.Add(new Weapon(ITEM_ID_STEEL_AXE, "Steel Axe", "Steel Axes", 10, 60, 100));
            Items.Add(new Weapon(ITEM_ID_SKULL_BREAKER, "Skull Breaker", "Skull Breakers", 10, 50, 30));
            Items.Add(new Weapon(ITEM_ID_BLOOD_THIRSTY_AXE, "Blood Thirsty Axe", "Blood Thirsty Axes", 20, 60, 120));
            Items.Add(new Weapon(ITEM_ID_OVERDRIVE_CLUB, "Overdrive Club", "Overdrive Clubs", 60, 60, 120));
            Items.Add(new Weapon(ITEM_ID_DRAGON_SLAYER, "Dragon Slayer", "Dragon Slayers", 35, 100, 500));
            Items.Add(new Weapon(ITEM_ID_MOUNTAIN_LEVELING_WARAXE, "Mountain Leveling Waraxe", "Mountain Leveling Waraxes", 45, 180, 700));
            Items.Add(new Weapon(ITEM_ID_DREAD_AXE, "Dread Axe", "Dread Axes", 180, 250, 1000));
            Items.Add(new Weapon(ITEM_ID_THORS_HAMMER, "Thor's Hammer", "Thor's Hammers", 150, 500, 1000000));

            // All healing potions are added into the game
            Items.Add(new HealingPotion(ITEM_ID_HEALING_POTION, "Healing Potion", "Healing Potions", 20, 10));
            Items.Add(new HealingPotion(ITEM_ID_SUPER_HEALING_POTION, "Super Healing Potion", "Super Healing Potions", 100, 250));
            Items.Add(new HealingPotion(ITEM_ID_MAX_HEALING_POTION, "Max Healing Potion", "Max Healing Potions", 250, 1000));

            // All spider items are added into the game
            Items.Add(new Item(ITEM_ID_SPIDER_FANG, "Spider Fang", "Spider Fangs", 20));
            Items.Add(new Item(ITEM_ID_SPIDER_SILK, "Spider Silk", "Spider Silks", 30));

            // Adventurer Pass for passing through the first town is added into the game
            Items.Add(new Item(ITEM_ID_ADVENTURER_PASS, "Adventurer Pass", "Adventurer Passes", UNSELLABLE_ITEM_PRICE));

            // Banshee Soul is added into the game
            Items.Add(new Item(ITEM_ID_BANSHEE_SOUL, "Banshee Soul", "Banshee Souls", 150));

            // Dracula's Head is added into the game to get through to the main city
            Items.Add(new Item(ITEM_ID_DRACULAS_HEAD, "Dracula's Head", "Dracula's Heads", 1000));

            // The Big Goblin Emeralds are added into the game to get the second strongest sword in the game
            Items.Add(new Item(ITEM_ID_BIG_GOBLIN_EMERALDS, "Big Goblin Emeralds", "Big Goblin Emeralds", 100000));
        }

        // Adding in all monsters with their specific loot to the game
        private static void PopulateMonsters()
        {
            Monster rat = new Monster(MONSTER_ID_RAT, "Rat", 15, 8, 10, 10, 10);
            rat.LootTable.Add(new LootItem(ItemByID(ITEM_ID_RAT_TAIL), 75, false));
            rat.LootTable.Add(new LootItem(ItemByID(ITEM_ID_PIECE_OF_FUR), 75, true));
            rat.LootTable.Add(new LootItem(ItemByID(ITEM_ID_HEALING_POTION), 50, true));

            Monster snake = new Monster(MONSTER_ID_SNAKE, "Snake", 15, 8, 10, 10, 10);
            snake.LootTable.Add(new LootItem(ItemByID(ITEM_ID_SNAKE_FANG), 75, false));
            snake.LootTable.Add(new LootItem(ItemByID(ITEM_ID_SNAKESKIN), 75, true));
            snake.LootTable.Add(new LootItem(ItemByID(ITEM_ID_BRONZE_SWORD), 20, true));
            snake.LootTable.Add(new LootItem(ItemByID(ITEM_ID_HEALING_POTION), 50, true));

            Monster giantSpider = new Monster(MONSTER_ID_GIANT_SPIDER, "Giant Spider", 70, 40, 40, 100, 100);
            giantSpider.LootTable.Add(new LootItem(ItemByID(ITEM_ID_SPIDER_FANG), 75, true));
            giantSpider.LootTable.Add(new LootItem(ItemByID(ITEM_ID_SPIDER_SILK), 25, false));
            giantSpider.LootTable.Add(new LootItem(ItemByID(ITEM_ID_IRON_SWORD), 40, true));
            giantSpider.LootTable.Add(new LootItem(ItemByID(ITEM_ID_HEALING_POTION), 75, true));
            giantSpider.LootTable.Add(new LootItem(ItemByID(ITEM_ID_SUPER_HEALING_POTION), 40, true));

            Monster ghost = new Monster(MONSTER_ID_GHOST, "Ghost", 50, 40, 50, 50, 50);
            ghost.LootTable.Add(new LootItem(ItemByID(ITEM_ID_HEALING_POTION), 80, true));
            ghost.LootTable.Add(new LootItem(ItemByID(ITEM_ID_SUPER_HEALING_POTION), 50, true));

            Monster banshee = new Monster(MONSTER_ID_BANSHEE, "Banshee", 70, 40, 80, 60, 60);
            banshee.LootTable.Add(new LootItem(ItemByID(ITEM_ID_MITHRIL_SWORD), 25, true));
            banshee.LootTable.Add(new LootItem(ItemByID(ITEM_ID_HEALING_POTION), 80, true));
            banshee.LootTable.Add(new LootItem(ItemByID(ITEM_ID_SUPER_HEALING_POTION), 70, true));
            banshee.LootTable.Add(new LootItem(ItemByID(ITEM_ID_BANSHEE_SOUL), 60, true));

            Monster dracula = new Monster(MONSTER_ID_DRACULA, "Dracula", 120, 200, 500, 400, 400);
            dracula.LootTable.Add(new LootItem(ItemByID(ITEM_ID_DRACULAS_HEAD), 40, true));
            dracula.LootTable.Add(new LootItem(ItemByID(ITEM_ID_HEALING_POTION), 80, true));
            dracula.LootTable.Add(new LootItem(ItemByID(ITEM_ID_SUPER_HEALING_POTION), 80, true));
            dracula.LootTable.Add(new LootItem(ItemByID(ITEM_ID_MAX_HEALING_POTION), 40, true));
            dracula.LootTable.Add(new LootItem(ItemByID(ITEM_ID_ADAMANTITE_SWORD), 40, true));

            Monster goblin = new Monster(MONSTER_ID_GOBLIN, "Goblin", 60, 60, 100, 50, 50);
            goblin.LootTable.Add(new LootItem(ItemByID(ITEM_ID_MITHRIL_SWORD), 60, true));
            goblin.LootTable.Add(new LootItem(ItemByID(ITEM_ID_HEALING_POTION), 100, true));
            goblin.LootTable.Add(new LootItem(ItemByID(ITEM_ID_SUPER_HEALING_POTION), 70, true));

            Monster goblinHord = new Monster(MONSTER_ID_GOBLIN_HORD, "Goblin Hord", 120, 200, 200, 100, 100);
            goblinHord.LootTable.Add(new LootItem(ItemByID(ITEM_ID_RUNITE_SWORD), 40, true));
            goblinHord.LootTable.Add(new LootItem(ItemByID(ITEM_ID_HEALING_POTION), 100, true));
            goblinHord.LootTable.Add(new LootItem(ItemByID(ITEM_ID_SUPER_HEALING_POTION), 80, true));
            goblinHord.LootTable.Add(new LootItem(ItemByID(ITEM_ID_MAX_HEALING_POTION), 50, true));

            Monster goblinWarchief = new Monster(MONSTER_ID_GOBLIN_WARCHIEF, "Goblin Warchief", 120, 200, 200, 150, 150);
            goblinWarchief.LootTable.Add(new LootItem(ItemByID(ITEM_ID_RUNITE_SWORD), 50, true));
            goblinWarchief.LootTable.Add(new LootItem(ItemByID(ITEM_ID_SWORD_OF_GREATNESS), 10, true));
            goblinWarchief.LootTable.Add(new LootItem(ItemByID(ITEM_ID_SUPER_HEALING_POTION), 100, true));
            goblinWarchief.LootTable.Add(new LootItem(ItemByID(ITEM_ID_MAX_HEALING_POTION), 60, true));

            Monster goblinBoss = new Monster(MONSTER_ID_GOBLIN_BOSS, "Goblin Boss", 150, 250, 250, 200, 200);
            goblinBoss.LootTable.Add(new LootItem(ItemByID(ITEM_ID_RUNITE_SWORD), 68, true));
            goblinBoss.LootTable.Add(new LootItem(ItemByID(ITEM_ID_SWORD_OF_GREATNESS), 40, true));
            goblinBoss.LootTable.Add(new LootItem(ItemByID(ITEM_ID_SUPER_HEALING_POTION), 100, true));
            goblinBoss.LootTable.Add(new LootItem(ItemByID(ITEM_ID_MAX_HEALING_POTION), 75, true));

            Monster giantGoblin = new Monster(MONSTER_ID_GIANT_GOBLIN, "Giant Goblin", 200, 400, 800, 1000, 1000);
            giantGoblin.LootTable.Add(new LootItem(ItemByID(ITEM_ID_BIG_GOBLIN_EMERALDS), 40, true));
            giantGoblin.LootTable.Add(new LootItem(ItemByID(ITEM_ID_SUPER_HEALING_POTION), 100, true));
            giantGoblin.LootTable.Add(new LootItem(ItemByID(ITEM_ID_MAX_HEALING_POTION), 90, true));

            Monsters.Add(rat);
            Monsters.Add(snake);
            Monsters.Add(giantSpider);
            Monsters.Add(ghost);
            Monsters.Add(banshee);
            Monsters.Add(dracula);
            Monsters.Add(goblin);
            Monsters.Add(goblinHord);
            Monsters.Add(goblinWarchief);
            Monsters.Add(goblinBoss);
            Monsters.Add(giantGoblin);
        }

        // Adding in all quests for the game
        private static void PopulateQuests()
        {
            Quest clearAlchemistGarden =
                new Quest(
                    QUEST_ID_CLEAR_ALCHEMIST_GARDEN,
                    "Clear the Alchemist's Garden",
                    "Kill Rats in the Alchemist's Garden and bring back 3 Rat Tails. You will receive a Healing Potion and 10 Gold Pieces.", 20, 10);

            clearAlchemistGarden.QuestCompletionItems.Add(new QuestCompletionItem(ItemByID(ITEM_ID_RAT_TAIL), 3));

            clearAlchemistGarden.RewardItem = ItemByID(ITEM_ID_HEALING_POTION);

            Quest clearFarmersField =
                new Quest(
                    QUEST_ID_CLEAR_FARMERS_FIELD,
                    "Clear the Farmer's Field",
                    "Kill snakes in the Farmer's Field and bring back 3 Snake Fangs. You will receive an Adventurer's Pass and 20 Gold Pieces.", 20, 20);

            clearFarmersField.QuestCompletionItems.Add(new QuestCompletionItem(ItemByID(ITEM_ID_SNAKE_FANG), 3));

            clearFarmersField.RewardItem = ItemByID(ITEM_ID_ADVENTURER_PASS);

            Quest clearCampsiteDanger =
                new Quest(
                    QUEST_ID_CLEAR_CAMPSITE_DANGER,
                    "Get 15 Banshee Souls",
                    "Bring back 15 Banshee Souls from the Ruins. You will receive 200 Gold and a Super Healing Potions.", 200, 200);

            clearCampsiteDanger.QuestCompletionItems.Add(new QuestCompletionItem(ItemByID(ITEM_ID_BANSHEE_SOUL), 15));

            clearCampsiteDanger.RewardItem = ItemByID(ITEM_ID_SUPER_HEALING_POTION);

            Quest clearGoblinAttackOnCaptial =
                new Quest(
                    QUEST_ID_CLEAR_GOBLIN_ATTACK_ON_THE_CAPITAL,
                    "Bring the Big Goblin Emeralds back.",
                    "Kill the Giant Goblin in the Goblin Cave to get the Big Goblin Emeralds. You will receive a special sword made from my personal blacksmith.", 1000, 5000);

            clearGoblinAttackOnCaptial.QuestCompletionItems.Add(new QuestCompletionItem(ItemByID(ITEM_ID_BIG_GOBLIN_EMERALDS), 1));

            clearGoblinAttackOnCaptial.RewardItem = ItemByID(ITEM_ID_WORLD_BREAKER);

            Quests.Add(clearAlchemistGarden);
            Quests.Add(clearFarmersField);
            Quests.Add(clearCampsiteDanger);
            Quests.Add(clearGoblinAttackOnCaptial);
        }

        private static void PopulateLocations()
        {
            // Create each location
            Location home = new Location(LOCATION_ID_HOME, "Home", "Your house. You really need to clean up the place.");

            Location townSquare = new Location(LOCATION_ID_TOWN_SQUARE, "Town square", "You see a fountain.");

            Vendor bobTheRatCatcher = new Vendor("Bob the Rat-Catcher");
            bobTheRatCatcher.AddItemToInventory(ItemByID(ITEM_ID_PIECE_OF_FUR), 5);
            bobTheRatCatcher.AddItemToInventory(ItemByID(ITEM_ID_RAT_TAIL), 3);

            townSquare.VendorWorkingHere = bobTheRatCatcher;

            Location alchemistHut = new Location(LOCATION_ID_ALCHEMIST_HUT, "Alchemist's hut", "There are many strange plants on the shelves.");
            alchemistHut.QuestAvailableHere = QuestByID(QUEST_ID_CLEAR_ALCHEMIST_GARDEN);

            Vendor igorTheAlchemist = new Vendor("Igor the Alchemist");
            igorTheAlchemist.AddItemToInventory(ItemByID(ITEM_ID_HEALING_POTION), 999);
            igorTheAlchemist.AddItemToInventory(ItemByID(ITEM_ID_SUPER_HEALING_POTION), 999);
            igorTheAlchemist.AddItemToInventory(ItemByID(ITEM_ID_MAX_HEALING_POTION), 999);

            alchemistHut.VendorWorkingHere = igorTheAlchemist;

            Location alchemistsGarden = new Location(LOCATION_ID_ALCHEMISTS_GARDEN, "Alchemist's garden", "Many plants are growing here.");
            alchemistsGarden.MonsterLivingHere = MonsterByID(MONSTER_ID_RAT);

            Location farmhouse = new Location(LOCATION_ID_FARMHOUSE, "Farmhouse", "There is a small farmhouse, with a farmer in front.");
            farmhouse.QuestAvailableHere = QuestByID(QUEST_ID_CLEAR_FARMERS_FIELD);

            Location farmersField = new Location(LOCATION_ID_FARM_FIELD, "Farmer's field", "You see rows of vegetables growing here.");
            farmersField.MonsterLivingHere = MonsterByID(MONSTER_ID_SNAKE);

            Location guardPost = new Location(LOCATION_ID_GUARD_POST, "Guard post", "There is a large, tough-looking guard here.", ItemByID(ITEM_ID_ADVENTURER_PASS));

            Location bridge = new Location(LOCATION_ID_BRIDGE, "Bridge", "A stone bridge crosses a wide river.");

            Location spiderField = new Location(LOCATION_ID_SPIDER_FIELD, "Forest", "You see spider webs covering covering the trees in this forest.");
            spiderField.MonsterLivingHere = MonsterByID(MONSTER_ID_GIANT_SPIDER);

            Location campsite = new Location(LOCATION_ID_CAMPSITE, "Campsite", "There are some rough looking mercenaries here.");
            campsite.QuestAvailableHere = QuestByID(QUEST_ID_CLEAR_CAMPSITE_DANGER);

            Vendor krokovTheMercenary = new Vendor("Krokov the Mercenary");
            krokovTheMercenary.AddItemToInventory(ItemByID(ITEM_ID_SUPER_HEALING_POTION), 999);
            krokovTheMercenary.AddItemToInventory(ItemByID(ITEM_ID_RUNITE_SWORD), 1);

            campsite.VendorWorkingHere = krokovTheMercenary;

            Location graveyard = new Location(LOCATION_ID_GRAVEYARD, "Graveyard", "You see many Ghosts here.");
            graveyard.MonsterLivingHere = MonsterByID(MONSTER_ID_GHOST);

            Location ruins = new Location(LOCATION_ID_RUINS, "Ruins", "Spooky, there seems to be nothing here... BANSHEE!!!");
            ruins.MonsterLivingHere = MonsterByID(MONSTER_ID_BANSHEE);

            Location castleRuins = new Location(LOCATION_ID_CASTLE_RUINS, "Caslte Ruins", "Looks like a typical horror castle, wait a minute... is that a Vampire?");
            castleRuins.MonsterLivingHere = MonsterByID(MONSTER_ID_DRACULA);

            Location largeField = new Location(LOCATION_ID_LARGE_FIELD, "Large Field", "So beautiful, so much green... also some green snakes.");
            largeField.MonsterLivingHere = MonsterByID(MONSTER_ID_SNAKE);

            Location capitalOfOzangura = new Location(LOCATION_ID_CAPITAL_OF_OZANGURA_ENTRANCE, "Capital of Ozangura Entrance", "Such a huge city and so shiny... the gate isn't exactly small either.", ItemByID(ITEM_ID_DRACULAS_HEAD));

            Location centerOfCapital = new Location(LOCATION_ID_CENTRAL_OF_THE_CAPITAL, "Capital Central", "So much to see in this large city.");

            Location shoppingDistrict = new Location(LOCATION_ID_SHOPPING_DISTRICT, "Shopping District", "I wonder what kinds of shops there are here.");

            Vendor shadyCharacter = new Vendor("Shady Character");
            shadyCharacter.AddItemToInventory(ItemByID(ITEM_ID_SUPER_HEALING_POTION), 999);
            shadyCharacter.AddItemToInventory(ItemByID(ITEM_ID_MAX_HEALING_POTION), 999);
            shadyCharacter.AddItemToInventory(ItemByID(ITEM_ID_UNIVERSE_CONQUEROR), 1);
            shadyCharacter.AddItemToInventory(ItemByID(ITEM_ID_THORS_HAMMER), 1);

            shoppingDistrict.VendorWorkingHere = shadyCharacter;

            Location livingDistrict  = new Location(LOCATION_ID_LIVING_DISTRICT, "Living District", "So many huge houses, maybe one day, I can buy one myself.");

            Location churchDistrict = new Location(LOCATION_ID_CHURCH_DISTRICT, "Church District", "The only god we should count on is Thor.");

            Location mainCastle = new Location(LOCATION_ID_CATLE_OF_THE_CAPITAL, "Castle of the Capital", "There is a huge statue of Thor here, I like that.");
            mainCastle.QuestAvailableHere = QuestByID(QUEST_ID_CLEAR_GOBLIN_ATTACK_ON_THE_CAPITAL);

            Location backGatesOfCapital = new Location(LOCATION_ID_BACK_GATE_OF_THE_CAPITAL, "Back Gates of the Capital", "Another huge set of gates, that lead to a very dark and evil place.");

            Location goblinWoods = new Location(LOCATION_ID_GOBLIN_WOODS, "Goblin Woods", "I feel something very evil lurking in these woods.");
            goblinWoods.MonsterLivingHere = MonsterByID(MONSTER_ID_GOBLIN);

            Location goblinCave = new Location(LOCATION_ID_GOBLIN_CAVE, "Goblin Caves", "That was a nasty monster, but now there is a whole group of them!");
            goblinCave.MonsterLivingHere = MonsterByID(MONSTER_ID_GOBLIN_HORD);

            Location goblinCaveDiningHall = new Location(LOCATION_ID_GOBLIN_CAVE_DINING_HALL, "Goblin Cave Dining Hall", "That was the toughest fight yet! That goblin looks pretty scarry, I wonder if he'll share his food with me.");
            goblinCaveDiningHall.MonsterLivingHere = MonsterByID(MONSTER_ID_GOBLIN_WARCHIEF);

            Location goblinCaveMainQuarters = new Location(LOCATION_ID_GOBLIN_CAVE_MAIN_QUARTERS, "Goblin Cave Main Quarters", "WOW, that goblin was about as tough as the whole hord that attacked me... well not time to sleep yet, there is another mean looking goblin in front of me...");
            goblinCaveMainQuarters.MonsterLivingHere = MonsterByID(MONSTER_ID_GOBLIN_BOSS);

            Location goblinCaveExit = new Location(LOCATION_ID_GOBLIN_CAVE_EXIT, "Goblin Cave Exit", "I'm happy I slept after that fight... is that light? Finally an exit! Nevermind there is a huge... wait no GIGANTIC goblin in front of me.");
            goblinCaveExit.MonsterLivingHere = MonsterByID(MONSTER_ID_GIANT_GOBLIN);

            // Link the locations together
            home.LocationToNorth = townSquare;

            townSquare.LocationToNorth = alchemistHut;
            townSquare.LocationToSouth = home;
            townSquare.LocationToEast = guardPost;
            townSquare.LocationToWest = farmhouse;

            farmhouse.LocationToEast = townSquare;
            farmhouse.LocationToWest = farmersField;

            farmersField.LocationToEast = farmhouse;

            alchemistHut.LocationToSouth = townSquare;
            alchemistHut.LocationToNorth = alchemistsGarden;

            alchemistsGarden.LocationToSouth = alchemistHut;

            guardPost.LocationToEast = bridge;
            guardPost.LocationToWest = townSquare;

            bridge.LocationToWest = guardPost;
            bridge.LocationToEast = spiderField;

            spiderField.LocationToWest = bridge;
            spiderField.LocationToNorth = campsite;

            campsite.LocationToNorth = graveyard;
            campsite.LocationToEast = largeField;
            campsite.LocationToSouth = spiderField;

            graveyard.LocationToNorth = ruins;
            graveyard.LocationToSouth = campsite;

            ruins.LocationToNorth = castleRuins;
            ruins.LocationToSouth = graveyard;

            castleRuins.LocationToSouth = ruins;

            largeField.LocationToEast = capitalOfOzangura;
            largeField.LocationToWest = campsite;

            capitalOfOzangura.LocationToEast = centerOfCapital;
            capitalOfOzangura.LocationToWest = largeField;

            centerOfCapital.LocationToNorth = churchDistrict;
            centerOfCapital.LocationToEast = livingDistrict;
            centerOfCapital.LocationToWest = capitalOfOzangura;
            centerOfCapital.LocationToSouth = shoppingDistrict;

            livingDistrict.LocationToWest = centerOfCapital;

            shoppingDistrict.LocationToNorth = centerOfCapital;

            churchDistrict.LocationToSouth = centerOfCapital;
            churchDistrict.LocationToNorth = mainCastle;

            mainCastle.LocationToSouth = churchDistrict;
            mainCastle.LocationToNorth = backGatesOfCapital;

            backGatesOfCapital.LocationToSouth = mainCastle;
            backGatesOfCapital.LocationToEast = goblinWoods;

            goblinWoods.LocationToWest = backGatesOfCapital;
            goblinWoods.LocationToNorth = goblinCave;

            goblinCave.LocationToSouth = goblinWoods;
            goblinCave.LocationToNorth = goblinCaveDiningHall;

            goblinCaveDiningHall.LocationToSouth = goblinCave;
            goblinCaveDiningHall.LocationToNorth = goblinCaveMainQuarters;

            goblinCaveMainQuarters.LocationToSouth = goblinCaveDiningHall;
            goblinCaveMainQuarters.LocationToNorth = goblinCaveExit;

            goblinCaveExit.LocationToSouth = goblinCaveMainQuarters;

            // Add the locations to the static list
            Locations.Add(home);
            Locations.Add(townSquare);
            Locations.Add(guardPost);
            Locations.Add(alchemistHut);
            Locations.Add(alchemistsGarden);
            Locations.Add(farmhouse);
            Locations.Add(farmersField);
            Locations.Add(bridge);
            Locations.Add(spiderField);
            Locations.Add(campsite);
            Locations.Add(graveyard);
            Locations.Add(ruins);
            Locations.Add(castleRuins);
            Locations.Add(largeField);
            Locations.Add(capitalOfOzangura);
            Locations.Add(centerOfCapital);
            Locations.Add(shoppingDistrict);
            Locations.Add(livingDistrict);
            Locations.Add(churchDistrict);
            Locations.Add(mainCastle);
            Locations.Add(backGatesOfCapital);
            Locations.Add(goblinWoods);
            Locations.Add(goblinCave);
            Locations.Add(goblinCaveDiningHall);
            Locations.Add(goblinCaveMainQuarters);
            Locations.Add(goblinCaveExit);
        }

        public static Item ItemByID(int id)
        {
            foreach (Item item in Items)
            {
                if (item.ID == id)
                {
                    return item;
                }
            }

            return null;
        }

        public static Monster MonsterByID(int id)
        {
            foreach (Monster monster in Monsters)
            {
                if (monster.ID == id)
                {
                    return monster;
                }
            }

            return null;
        }

        public static Quest QuestByID(int id)
        {
            foreach (Quest quest in Quests)
            {
                if (quest.ID == id)
                {
                    return quest;
                }
            }

            return null;
        }

        public static Location LocationByID(int id)
        {
            foreach (Location location in Locations)
            {
                if (location.ID == id)
                {
                    return location;
                }
            }

            return null;
        }
    }
}
