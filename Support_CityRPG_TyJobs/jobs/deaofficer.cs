// ============================================================
// Project				:	CityRPG
// Author				:	/Ty
// Description			:	Policeman Code file
// ============================================================

$CityRPG::jobs::name = "DEA Officer";
$CityRPG::jobs::initialInvestment = 10000;
$CityRPG::jobs::pay = 300;
$CityRPG::jobs::tools = "TacticalVestItem CityRPGBatonItem akimboGunItem crowbarItem";
$CityRPG::jobs::datablock = Player9SlotPlayer;
$CityRPG::jobs::education = 18;

$CityRPG::jobs::sellItems = true;
$CityRPG::jobs::sellFood = true;
$CityRPG::jobs::sellServices = true;

$CityRPG::jobs::law = true;
$CityRPG::jobs::usepolicecars = true;
$CityRPG::jobs::canPardon = true;

$CityRPG::jobs::thief = false;
$CityRPG::jobs::hideJobName = true;

$CityRPG::jobs::offerer = false;
$CityRPG::jobs::claimer = true;

$CityRPG::jobs::labor = false;

$CityRPG::jobs::tmHexColor = "99FF00";
$CityRPG::jobs::helpline = "\c6The DEA Officer Cop can arrest criminals, kill wanted men, drug busts, but requires a clean record.";

$CityRPG::jobs::outfit = "none none none none blackShirt blackShirt skin blackPants blueShoes BrownSmiley Mod-Police";