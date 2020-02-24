// ============================================================
// Project				:	CityRPG
// Author				:	/Ty
// Description			:	Policeman Code file
// ============================================================

$CityRPG::jobs::name = "Policeman";
$CityRPG::jobs::initialInvestment = 25;
$CityRPG::jobs::pay = 50;
$CityRPG::jobs::tools = "CityRPGBatonItem grappleRope gunItem";
$CityRPG::jobs::datablock = Player9SlotPlayer;
$CityRPG::jobs::education = 2;

$CityRPG::jobs::sellItems = false;
$CityRPG::jobs::sellFood = false;
$CityRPG::jobs::sellServices = false;

$CityRPG::jobs::law = true;
$CityRPG::jobs::usepolicecars = true;
$CityRPG::jobs::canPardon = false;

$CityRPG::jobs::thief = false;
$CityRPG::jobs::hideJobName = false;

$CityRPG::jobs::offerer = false;
$CityRPG::jobs::claimer = true;

$CityRPG::jobs::labor = false;

$CityRPG::jobs::tmHexColor = "99FF00";
$CityRPG::jobs::helpline = "\c6Police can arrest criminals, kill wanted men, and bust down doors, but require a clean record.";

$CityRPG::jobs::outfit = "none copHat none none copShirt copShirt skin blackPants blackShoes default Mod-Police";