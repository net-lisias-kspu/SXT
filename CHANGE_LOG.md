SXT - Stock eXTension :: Change Log

* 2019-0120: 0.3.25 (linuxgurugamer) for KSP 1.6.1
	+ Added missing bulkheadProfiles
* 2019-0109: 0.3.24.3 (linuxgurugamer) for KSP 1.6.0
	+ No changelog provided
* 2018-1208: 0.3.24.2 (linuxgurugamer) for KSP 1.5.1
	+ Thanks to @tjdeckard:
		- Updated part configs to reflect changes made to converters in USITools
	+ Removed KSP_MaxVersion from version file
* 2018-1118: 0.3.24.1 (linuxgurugamer) for KSP 1.5.1
	+ Updated transforms in the Alouette probe, fixes the blind spots above and below
* 2018-1116: 0.3.24 (linuxgurugamer) for KSP 1.5.1
	+ Fixed Meadowlark for 1.5.1
	+ Disabled the science experiment and container in Meadowlark
	+ Thanks to @JadeOfMaar:
		- Updated the model for the Alouette probe
	+ Added scripts to copy missing texture files
	+ Updated parts which referenced missing texture files to use new location
	+ Thanks to @Taniwha for the following:
		- Fixed hatch and ladder colliders for the Buzzerd
for KSP 1.5.1
* 2018-0622: 0.3.23.7 (linuxgurugamer) for KSP 1.4.1
	+ Custom Drag Cube for SXTCargoBay1 (2.5m Cargo Bay)
* 2018-0408: 0.3.23.6 (linuxgurugamer) for KSP 1.4.1
	+ Made the OX-HEX invulnerable to aero damage
	+ Localization and German translation by @LeLeon
	+ Updated .version file to allow all of 1.4.1+
* 2018-0328: 0.3.23.5 (linuxgurugamer) for KSP 1.4.1
	+ Changed name of MEMLander to MEMLanderSXT to avoid conflict with stock
* 2018-0327: 0.3.23.4 (linuxgurugamer) for KSP 1.4.1
	+ Fixed build to include missing DLLs
* 2018-0327: 0.3.23.3 (linuxgurugamer) for KSP 1.4.1
	+ Updated version file
* 2018-0326: 0.3.23.2 (linuxgurugamer) for KSP 1.4.1
	+ Thanks to forum user @Munar Industries, the Buzzard is fixed
	+ Updated for 1.4.1
	+ Reorganized ModuleBounce
	+ Updated build scripts & Jenkins
* 2018-0328: 0.3.23.1 (linuxgurugamer) for KSP 1.3.1
	+ Reupload of last version for 1.3.1
* 2018-0223: 0.3.22 (linuxgurugamer) for KSP 1.3.1
	+ Updated mass and lift for the wings to bring them more
		- in line with stock
* 2018-0215: 0.3.21 (linuxgurugamer) for KSP 1.3.1
	+ Nerva CoM offset
	+ Wing CoM
	+ Wing fuel & lift
	+ 2.5m LF tank volume
	+ Update fuelTank.cfg
		- missing s at the end of bulkheadProfiles
* 2017-1211: 0.3.20 (linuxgurugamer) for KSP 1.3.1
	+ Fixed following patches for updated ModuleManager 3.0.*
		- Patches/ModCompatibility/CLS/CLS_Aviation.cfg
		- Patches/ModCompatibility/RemoteTech/RemoteTech_Probes.cfg
		- Patches/ModCompatibility/RPM/Window.cfg
		- Patches/ModCompatibility/SXT_BDArmoury.cfg
		- Patches/ModCompatibility/SXT_Firespitter.cfg
		- Patches/ModCompatibility/SXT_KIS.cfg
		- Patches/ModCompatibility/SXT_KSPI.cfg
		- Patches/ModCompatibility/WIP/RealPlume/NuclearRamJet.cfg
		- Patches/SquadPartTweaks/Engines/Ion/IonFairing.cfg
		- Patches/SquadPartTweaks/StayputnikRX.cfg
		- Patches/SquadPartTweaks/SXT_GenericTweaks.cfg
		- Patches/SquadPartTweaks/SXT_StartingTech.cfg
* 2017-1205: 0.3.19 (linuxgurugamer) for KSP 1.3.1
	+ Updated FAR patch for compatibility with updated ModuleManager 3.0.0
* 2017-1115: 0.3.18 (linuxgurugamer) for KSP 1.3.1
* 2017-1107: 0.3.17 (linuxgurugamer) for KSP 1.3.1
* 2017-1109: 0.3.17.-1 (linuxgurugamer) for KSP 1.3.1 PRE-RELEASE
	+ Cut whitespace slightly, replaced spaces with proper tab spacing and removed superfluous lines across all parts making the configs slightly smaller and easier to follow (unless it's converted into some godawful horizontal format).
	+ Some of the more relevant changes include extending float curves for all engines that didn't have them already to beyond 1atm (sorry, Eve landers, as per #35 ), correcting a few descriptions (grammar, spelling, old references etc.) and increasing the fuel capacity (and dry cost/mass to match) of the Oscar-C, since its fuel capacity was terrible for its size.
* 2017-1011: 0.3.16 (linuxgurugamer) for KSP 1.3.1
	+ No changelog provided
* 2017-0616: 0.3.14 (linuxgurugamer) for KSP 1.3
	+ Recompiled ModuleBounce for 1.3
	+ Added additional CLS compatibliity, thanks @LemonSkin
	+ Fixed bad character in  Mystery goo description, thanks @LemonSkin
* 2017-0529: 0.3.13 (linuxgurugamer) for KSP 1.3
	+ Updated for 1.3
	+ Replaced missing model for the Clyde
* 2017-0514: 0.3.12.1 (linuxgurugamer) for KSP 1.2
	+ Updated USI-LS compat, thanks @voicey99
		- Reworked the patch to bring it into line with the USI Balance
			- Guidelines. Also added a cfg for the centrifuge hab, with a little
			- extra included for those who use MKS.
* 2017-0504: 0.3.12 (linuxgurugamer) for KSP 1.2
	+ Added USI-LS compat, thanks @voicey99
			- Adds Habitation values to the cabin modules and turns the non-tank
			- service modules into recyclers (inc. the MIA SM250).
* 2017-0410: 0.3.11.1 (linuxgurugamer) for KSP 1.2
	+ Updated patch for tweakscale, setting defaultScale = 1.25 where it is
		- currently set = 1 for those patches where type = surface
* 2017-0410: 0.3.11 (linuxgurugamer) for KSP 1.2
	+ Updated description of wheels
	+ Update Clyde internals with fixed textures, converted remaining png to dds, thanks to @Drew Kerman
* 2017-0330: 0.3.10 (linuxgurugamer) for KSP 1.2
	+ New rellease thanks to @EberKain
* 2017-0325: 0.3.9.1 (linuxgurugamer) for KSP 1.2
	+ Adjust TT06-A launch clamp pivot point
* 2017-0324: 0.3.9 (linuxgurugamer) for KSP 1.2
	+ Thanks to @RealKolago for the following:
		- Update part10degree.cfg
		- Update part225degree.cfg
	+ Thanks to @eberkain for the following:
		- added oscar-c fuel tank to tweakscale
* 2017-0226: 0.3.8 (linuxgurugamer) for KSP 1.2
	+ Adjust DTS-R4 and Komm-16 to match stock, thanks @WuphonsReach
	+ Moved all truck parts to general engineering 101
* 2017-0205: 0.3.7.1 (linuxgurugamer) for KSP 1.2
	+ Deleted unnecessary directory
		- Updated buildRelease.bat
* 2017-0204: 0.3.7 (linuxgurugamer) for KSP 1.2
	+ Added Experimental Rocketry to tech tree
	+ **BINARY OMMITED DUE SIZE**
* 2017-0113: 0.3.6 (linuxgurugamer) for KSP 1.2
	+ Fixed nodes in truck
* 2016-1213: 0.3.5 (linuxgurugamer) for KSP 1.2
	+ Removed old unnecessary file: GameData/SXT/Patches/ModCompatibility/WIP/KIS/SXT_KIS.cfg
* 2016-1213: 0.3.4 (linuxgurugamer) for KSP 1.2
	+ Removed unnecessary and duplicated patch files, thanks @BureauJaeger
	+ Fixed typo in SXT/Patches/ModCompatibility/CCT/SXT-CCT.cfg, thanks @CaribeanSoul
* 2016-1113: 0.3.3 (linuxgurugamer) for KSP 1.2
	+ No more beta
	+ Removed duplicated tech tree nodes
* 2016-1104: 0.3.2-beta (linuxgurugamer) for KSP 1.2 PRE-RELEASE
	+ No changelog provided
* 2016-1105: 0.3.2.1-beta (linuxgurugamer) for KSP 1.2 PRE-RELEASE
	+ Recompiled Firespitter for 1.2.1
* 2016-1101: 0.3.1-beta (linuxgurugamer) for KSP 1.2 PRE-RELEASE
```
    Finished merging all fixes and removed old MM cfg files 
    Got habitat ring working, but needs modified version of Firespitter to work right now
    Fixed the Lancer Shock Cone animation
Changes from PhineasFreak:
    Fix model path for the nuclear RAM jet engine.
    Fix the surface attachment node of the OX-HEX Photovoltaic Panel.
    Fix the displayed names for the FL-S3 Petal Adapter.
    Fix some texture paths.
    Remove the 0.625m heat shield (now a stock part).
    Fix the name of the 5m procedural fairing base.
    Move the cargo bays, the payload fairing bases and the Mk3 ramp to the "Payload" category.
    Move the antenna parts to the "Communication" category.
    Remove a duplicate of the ModuleDataTransmitter module from the Communotron DTS-R4.
    Move the crewed fuselage parts to the "Utility" category.
    Move the Mk0 & Mk1 fuselages to the "FuelTank" category.
    Move the landing airbags and wheels to the "Ground" category.
    Add missing decoupler FX where applicable.
    Move the N1 and Saturn V decouplers to the "Coupling" category
```
* 2016-1030: 0.3.0-beta (linuxgurugamer) for KSP 1.2 PRE-RELEASE
	+ Initial beta release for 1.2
* 2016-0410: 25.2 (Signatum) for KSP 1.0
	+ Updated inbuilt Firespitter module and MM to official 1.1 release compatible versions.. Though that mightn't work via CKAN.
	+ There's still a number of issues, hatches aren't behaving properly and the truck wheels are broken for now. These will be fixed in next series of patches. As will things like the IVA overlay.
* 2015-1210: 24 (Signatum) for KSP 1.0
	+ Major:
	+ Overhauled Osual parts. Textures now match Porkjet's style better and fixed the collsion meshes for the parts.
	+ Added ability to tweak deployment state of both Osual cockpit and loading ramp.
	+ Tweaked animation of ramp for more control over deployment state.
	+ Added Mk3-3.75m hollow adaptor.
	+ Added 3.75m Docking Port.
	+ Added 5m fairings and heatshield (re-sizes of stock parts, parameters).
	+ Minor:
	+ Finished updating part names, descriptions and manufacturers.
	+ Fixed nodes for 2.5m Cargo Bay.
	+ Further minor cfg fixes (thanks to Aivoh for pointing them out) - Correct name for ModuleCrossFeed and tabbing out of competitive agent mentality.
	+ Neatening up parts list. Deletion of defunct parts (old float cfgs).
	+ Fixes to heat tolerance for some plane parts.
* 2015-1202: 23.2 (Signatum) for KSP 1.0
	+ Added 3.75m Docking Ring.
	+ Fixed Size 2 Cargo Bay nodes.
	+ Tweaks to part temperatures. Adding Skin/Int temps to some of the crew caps.
	+ Fixed Mk0 Barrel texture.
	+ Filled in a few missing part descriptions.
* 2015-1111: 23.1 (Signatum) for KSP 1.0
	+ Added Electronic Fan (based off Airbus e-Fan).
	+ Added Small folding wing.
	+ Added Jumo 213 style Prop engine (KO-213 "Wolf").
	+ Added IVA for 5m Duna Hab and Clyde.
	+ Added 'Off-set' and 'Long XB-70' style 2.5m to Mk2 adaptor.
	+ Added 2.5m liquid-fuel tanks in similar style to Mk2/3 parts added.
	+ New model and stat tweaks for SXT 0.625m jet engine.
	+ Swapped configs/models for older parts that have been replaced with higher quality versions by Porkjet (e.g. 2.5m turbofan, Mk3 Ramp, Mk0 fuselage, Mk1 passenger cabin). Old craft using those parts should now replace them with the new stock equivalent.
	+ R-2800 prop will now look better when prop switches to blur (no more horrid blade mounts).
	+ Props will have altered stats/fuel requirements based on the presence or absence of FAR to account for different atmospheric properties (x1.8 static thrust without FAR).
	+ NK-12M spin-up time altered to fit real-life start-up better.
	+ NK-12M thrust curve altered. Should perform a bit closer to reality.
	+ RPM support added for Kossak & Entente.
	+ Edits to descriptions, crash-tolerances.
	+ Tweaks to stock aero-parts surface attachment settings.
	+ Fixes to stack node directions.
	+ Changed some part names to fit part order in list better (grouping with similar stock parts).
	+ Mystery Good can now satisfy satellite contracts (Kerbas-ad-astra).
* 2015-0911: 22.3 (Signatum) for KSP 1.0
	+ Adding and updating part descriptions
	+ Fix to Clyde's attachment node
	+ Tweaks and fixes to cargo bays and inflatable crash pads.
* 2015-0906: 22.1 (Signatum) for KSP 1.0
	+ New props, new blur for props, many tweaks to existing ones.
	+ New 1.25m cockpit 'Clyde', new model for Bonny.
	+ Sea-plane floats and fixes for existing inflatable balloons.
	+ FAR tweaks and fixes.
* 2015-0804: 21 (Signatum) for KSP 1.0
	+ Engines balanced to KSP 1.0+ values+attributes and given nick-names
	+ New prop engines (Powerful turboprop (NK-12M) and radial engine PW R-2800).
	+ Existing prop engine's efficiency balanced to match real-world fuel consumption (roughly, based off provided values of fuel consumption, converted into kg using gasoline's density and then into Liquid Fuel units) and fuel requirements at maximum throttle per hour flight listed in description
* 2015-0727: 20.8 (Signatum) for KSP 1.0
	+ Updating engine configs, add missing nicknams as well.
	+ Cargobays (Kerbas-ad-astra)
	+ Fixed agency flag issues (NathanKell)
	+ Fixed nodes for airintakes,
* 2015-0724: 20.7 (Signatum) for KSP 1.0
	+ Airbrakes updated (not sure about balance here)
	+ Beginning engine rebalances.
	+ Fixing inflatable balloons (1.0 doesn't like the old landing leg module).
	+ 8 thrustTransforms on the BA-8.
* 2015-0705: 20.6 (Signatum) for KSP 1.0
	+ No changelog provided
