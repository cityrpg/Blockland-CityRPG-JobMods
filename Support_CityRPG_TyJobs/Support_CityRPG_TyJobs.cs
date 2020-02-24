// Config changes
$City::EducationCap = 14;
$City::EducationReincarnateLevel = 20;
$City::MayorJobID = 26;
$City::CivilianJobID = 26;

$City::TyJobsPath = "Add-Ons/Support_CityRPG_TyJobs/jobs";

package CityRPG_TyJobs
{
	// No parent call because we're going to completely overwrite the job tree.
	function JobSO::loadJobFiles(%so)
	{
		$City::DefaultJobs = 0;

    echo("Loading custom jobs from Ty's CityRPG...");
		%so.addJobFromFile($City::TyJobsPath @ "/civilian.cs");             // 1
		%so.addJobFromFile($City::TyJobsPath @ "/grocer.cs");               // 2
		%so.addJobFromFile($City::TyJobsPath @ "/policeman.cs");            // 3
		%so.addJobFromFile($City::TyJobsPath @ "/policelieutenant.cs");     // 4
		%so.addJobFromFile($City::TyJobsPath @ "/criminal.cs");             // 5
		%so.addJobFromFile($City::TyJobsPath @ "/bountyhunter.cs");         // 6
		%so.addJobFromFile($City::TyJobsPath @ "/policechief.cs");          // 7
		%so.addJobFromFile($City::TyJobsPath @ "/miner.cs");                // 8
		%so.addJobFromFile($City::TyJobsPath @ "/shopkeeper.cs");           // 9
		%so.addJobFromFile($City::TyJobsPath @ "/armsdealer.cs");           // 10
		%so.addJobFromFile($City::TyJobsPath @ "/lumberjack.cs");           // 11
		%so.addJobFromFile($City::TyJobsPath @ "/laborer.cs");              // 12
		%so.addJobFromFile($City::TyJobsPath @ "/tailor.cs");               // 13
		%so.addJobFromFile($City::TyJobsPath @ "/councilmember.cs");        // 14
		%so.addJobFromFile($City::TyJobsPath @ "/administrator.cs");        // 15
		%so.addJobFromFile($City::TyJobsPath @ "/mobster.cs");              // 16
		%so.addJobFromFile($City::TyJobsPath @ "/mobboss.cs");              // 17
		%so.addJobFromFile($City::TyJobsPath @ "/godfather.cs");            // 18
		%so.addJobFromFile($City::TyJobsPath @ "/shopowner.cs");            // 19
		%so.addJobFromFile($City::TyJobsPath @ "/shopceo.cs");              // 20
		%so.addJobFromFile($City::TyJobsPath @ "/professionallaborer.cs");  // 21
		%so.addJobFromFile($City::TyJobsPath @ "/medicalassistant.cs");     // 22
		%so.addJobFromFile($City::TyJobsPath @ "/medicalinturn.cs");        // 23
		%so.addJobFromFile($City::TyJobsPath @ "/doctor.cs");               // 24
		%so.addJobFromFile($City::TyJobsPath @ "/surgeon.cs");              // 25
		%so.addJobFromFile($City::TyJobsPath @ "/mayor.cs");		  	        // 26
		%so.addJobFromFile($City::TyJobsPath @ "/private.cs");		    			// 27
		%so.addJobFromFile($City::TyJobsPath @ "/mastersergeant.cs");				// 28
		%so.addJobFromFile($City::TyJobsPath @ "/armylieutenant.cs");				// 29
		%so.addJobFromFile($City::TyJobsPath @ "/assistantmayor.cs");				// 30
		%so.addJobFromFile($City::TyJobsPath @ "/businessman.cs");					// 31
		%so.addJobFromFile($City::TyJobsPath @ "/undercovercop.cs");				// 32
		%so.addJobFromFile($City::TyJobsPath @ "/armygeneral.cs");					// 33
		%so.addJobFromFile($City::TyJobsPath @ "/bodyguard.cs");						// 34
		%so.addJobFromFile($City::TyJobsPath @ "/businessmanager.cs");			// 35
		%so.addJobFromFile($City::TyJobsPath @ "/businessceo.cs");					// 36
		%so.addJobFromFile($City::TyJobsPath @ "/deaagent.cs");							// 37
		%so.addJobFromFile($City::TyJobsPath @ "/deaofficer.cs");						// 38
		%so.addJobFromFile($City::TyJobsPath @ "/builder.cs");							// 39
		%so.addJobFromFile($City::TyJobsPath @ "/hitman.cs");								// 40
	}
};


activatePackage("CityRPG_TyJobs");
