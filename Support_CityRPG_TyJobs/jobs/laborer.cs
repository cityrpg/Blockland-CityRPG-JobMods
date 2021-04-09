// ============================================================
// Project				:	CityRPG
// Author				:	/Ty
// Description			:	Laborer Code file
// ============================================================

$CityRPG::jobs::name = "Laborer";
$CityRPG::jobs::track = "Labor";
$CityRPG::jobs::initialInvestment = 50;
$CityRPG::jobs::pay = 0;
$CityRPG::jobs::tools = "CityRPGPickaxeItem CityRPGLumberjackItem";
$CityRPG::jobs::datablock = Player9SlotPlayer;
$CityRPG::jobs::education = 0;

$CityRPG::jobs::sellItems = false;
$CityRPG::jobs::sellFood = false;
$CityRPG::jobs::sellServices = false;

$CityRPG::jobs::law = false;
$CityRPG::jobs::canPardon = false;

$CityRPG::jobs::thief = false;
$CityRPG::jobs::hideJobName = false;

$CityRPG::jobs::offerer = false;
$CityRPG::jobs::claimer = false;

$CityRPG::jobs::labor = true;

$CityRPG::jobs::tmHexColor = "802A2A";
$CityRPG::jobs::helpline = "\c6Laborers do not have a base salary and earn based on how hard they work. They carry both Picks and Lumberjack Axes.";

$CityRPG::jobs::outfit = "none none none none blackShirt blackShirt skin bluePants brownShoes memePBear Archer";