// WARNING: This jobs list is compatible with CityRPG 4 ALPHA 1 ONLY.
// As CityRPG 4 is still in alpha, future versions are not guaranteed to be compatible.

// Config changes
$City::EducationCap	= 6;
$City::EducationReincarnateLevel = 8;
$City::AdminJobID = 13;
$City::MayorJobID = 14;
$City::CivilianJobID = 1;

$City::JobsPath = "Add-Ons/Support_CityRPG_JobMod_Template/jobs";

package CityRPG_JobMod
{
	// No parent call because we're going to completely overwrite the job tree.
	function JobSO::loadJobFiles(%so)
	{
		$City::DefaultJobs = 0;

		echo("Loading custom jobs...");
		// NOTE: Order is incredibly important. Jobs are referenced by ID, which is determined by order.
		// Mixing up the order of these professions will cause save data to reference the wrong job.
		%so.addJobFromFile($City::JobsPath @ "/civilian.cs");               // 1
		%so.addJobFromFile($City::JobsPath @ "/miner.cs");                  // 2
		%so.addJobFromFile($City::JobsPath @ "/lumberjack.cs");             // 3
		%so.addJobFromFile($City::JobsPath @ "/grocer.cs");                 // 4
		%so.addJobFromFile($City::JobsPath @ "/armsdealer.cs");             // 5
		%so.addJobFromFile($City::JobsPath @ "/shopowner.cs");				// 6
		%so.addJobFromFile($City::JobsPath @ "/shopceo.cs");          		// 7
		%so.addJobFromFile($City::JobsPath @ "/bountyhunter.cs");           // 8
		%so.addJobFromFile($City::JobsPath @ "/bountyhunterpro.cs");        // 9
		%so.addJobFromFile($City::JobsPath @ "/policeasst.cs");             // 10
		%so.addJobFromFile($City::JobsPath @ "/policeman.cs");              // 11
		%so.addJobFromFile($City::JobsPath @ "/policechief.cs");            // 12
		%so.addJobFromFile($City::JobsPath @ "/councilmember.cs");          // 13
		%so.addJobFromFile($City::JobsPath @ "/mayor.cs");		  			// 14
	}
};


activatePackage("CityRPG_JobMod");
