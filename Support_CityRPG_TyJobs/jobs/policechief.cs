// ============================================================
// Project				:	CityRPG
// Author				:	/Ty
// Description			:	Policeman Code file
// ============================================================

$CityRPG::jobs::name = "Police Chief";
$CityRPG::jobs::initialInvestment = 100;
$CityRPG::jobs::pay = 100;
$CityRPG::jobs::tools = "TacticalVestItem CityRPGBatonItem akimboGunItem";
$CityRPG::jobs::datablock = Player9SlotPlayer;
$CityRPG::jobs::education = 4;

$CityRPG::jobs::sellItems = false;
$CityRPG::jobs::sellFood = false;
$CityRPG::jobs::sellServices = false;

$CityRPG::jobs::law = true;
$CityRPG::jobs::usepolicecars = true;
$CityRPG::jobs::canPardon = false;

$CityRPG::jobs::thief = false;
$CityRPG::jobs::hideJobName = false;

$CityRPG::jobs::offerer = true;
$CityRPG::jobs::claimer = true;

$CityRPG::jobs::labor = false;

$CityRPG::jobs::tmHexColor = "0000CC";
$CityRPG::jobs::helpline = "\c6Police Chiefs can arrest criminals, claim and place bounties, and bust down doors, but require a clean record.";

$CityRPG::jobs::outfit = "none copHat none none copShirt copShirt skin blackPants blackShoes default Mod-Police";