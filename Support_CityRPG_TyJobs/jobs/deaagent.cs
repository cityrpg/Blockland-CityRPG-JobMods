// ============================================================
// Project				:	CityRPG
// Author				:	/Ty
// Description			:	Policeman Code file
// ============================================================

$CityRPG::jobs::name = "DEA Agent";
$CityRPG::jobs::initialInvestment = 10000;
$CityRPG::jobs::pay = 290;
$CityRPG::jobs::tools = "TacticalVestItem CityRPGBatonItem akimboGunItem";
$CityRPG::jobs::datablock = Player9SlotPlayer;
$CityRPG::jobs::education = 17;

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
$CityRPG::jobs::helpline = "\c6The DEA Agent can arrest criminals, kill wanted men, go on drug busts, but requires a clean record.";

$CityRPG::jobs::outfit = "none none none none greyShirt greyShirt skin greyPants blueShoes smileyBlonde Mod-suit";