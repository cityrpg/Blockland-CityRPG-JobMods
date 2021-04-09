// Config changes
$City::EducationCap = 14;
$City::EducationReincarnateLevel = 20;
$City::MayorJobID = "mayor";
$City::CivilianJobID = "civilian";
$City::AdminJobID = "councilmember";

$City::TyJobsPath = "Add-Ons/Support_CityRPG_TyJobs/jobs";

package CityRPG_TyJobs
{
	// No parent call because we're going to completely overwrite the job tree.
	function JobSO::loadJobFiles(%so)
	{
		$City::DefaultJobs = 0;

		echo("Loading custom jobs from Ty's CityRPG...");
		%so.createJob($City::TyJobsPath @ "/civilian.cs");
		%so.createJob($City::TyJobsPath @ "/grocer.cs");
		%so.createJob($City::TyJobsPath @ "/policeman.cs");
		%so.createJob($City::TyJobsPath @ "/policelieutenant.cs");
		%so.createJob($City::TyJobsPath @ "/criminal.cs");
		%so.createJob($City::TyJobsPath @ "/bountyhunter.cs");
		%so.createJob($City::TyJobsPath @ "/policechief.cs");
		%so.createJob($City::TyJobsPath @ "/miner.cs");
		%so.createJob($City::TyJobsPath @ "/shopkeeper.cs");
		%so.createJob($City::TyJobsPath @ "/armsdealer.cs");
		%so.createJob($City::TyJobsPath @ "/lumberjack.cs");
		%so.createJob($City::TyJobsPath @ "/laborer.cs");
		%so.createJob($City::TyJobsPath @ "/tailor.cs");
		%so.createJob($City::TyJobsPath @ "/councilmember.cs");
		%so.createJob($City::TyJobsPath @ "/administrator.cs");
		%so.createJob($City::TyJobsPath @ "/mobster.cs");
		%so.createJob($City::TyJobsPath @ "/mobboss.cs");
		%so.createJob($City::TyJobsPath @ "/godfather.cs");
		%so.createJob($City::TyJobsPath @ "/shopowner.cs");
		%so.createJob($City::TyJobsPath @ "/shopceo.cs");
		%so.createJob($City::TyJobsPath @ "/professionallaborer.cs");
		%so.createJob($City::TyJobsPath @ "/medicalassistant.cs");
		%so.createJob($City::TyJobsPath @ "/medicalinturn.cs");
		%so.createJob($City::TyJobsPath @ "/doctor.cs");
		%so.createJob($City::TyJobsPath @ "/surgeon.cs");
		%so.createJob($City::TyJobsPath @ "/mayor.cs");
		%so.createJob($City::TyJobsPath @ "/private.cs");
		%so.createJob($City::TyJobsPath @ "/mastersergeant.cs");
		%so.createJob($City::TyJobsPath @ "/armylieutenant.cs");
		%so.createJob($City::TyJobsPath @ "/assistantmayor.cs");
		%so.createJob($City::TyJobsPath @ "/businessman.cs");
		%so.createJob($City::TyJobsPath @ "/undercovercop.cs");
		%so.createJob($City::TyJobsPath @ "/armygeneral.cs");
		%so.createJob($City::TyJobsPath @ "/bodyguard.cs");
		%so.createJob($City::TyJobsPath @ "/businessmanager.cs");
		%so.createJob($City::TyJobsPath @ "/businessceo.cs");
		%so.createJob($City::TyJobsPath @ "/deaagent.cs");
		%so.createJob($City::TyJobsPath @ "/deaofficer.cs");
		%so.createJob($City::TyJobsPath @ "/builder.cs");
		%so.createJob($City::TyJobsPath @ "/hitman.cs");
	}
};


activatePackage("CityRPG_TyJobs");
