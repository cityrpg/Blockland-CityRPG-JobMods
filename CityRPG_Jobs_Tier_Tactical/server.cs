%error = ForceRequiredAddOn("GameMode_CityRPG4");
if(%error == $Error::AddOn_NotFound)
{
  error("ERROR: CityRPG_Jobs_Tier_Tactical - required add-on GameMode_CityRPG4 not found");
  return;
}

%error = ForceRequiredAddOn("Weapon_Package_Tier1");
if(%error == $Error::AddOn_NotFound)
{
  error("ERROR: CityRPG_Jobs_Tier_Tactical - required add-on Weapon_Package_Tier1 not found");
  return;
}

exec("./CityRPG_Jobs_Tier_Tactical.cs");
