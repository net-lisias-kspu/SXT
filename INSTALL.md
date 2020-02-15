# SXT /L Unofficial

This is a revival of the SXT - Stock eXTension mod, originally published by Lack.


## Installation Instructions

To install, place the GameData folder inside your Kerbal Space Program folder. Optionally, you can also do the same for the PluginData (be careful to do not overwrite your custom settings):

* **REMOVE ANY OLD VERSIONS OF THE PRODUCT BEFORE INSTALLING**, including any other fork:
	+ Delete `<KSP_ROOT>/GameData/SXT `
* Extract the package's `GameData` folder into your KSP's root:
	+ `<PACKAGE>/GameData` --> `<KSP_ROOT>/`
* Extract the package's `PluginData` folder (if available) into your KSP's root, taking precautions to do not overwrite your custom settings if this is not what you want to.
	+ `<PACKAGE>/PluginData` --> `<KSP_ROOT>/`
	+ You can safely ignore this step if you already had installed it previously and didn't deleted your custom configurable files.

The following file layout must be present after installation:

```
<KSP_ROOT>
	[GameData]
		[SXT]
			[Agencies]
				...
			[Localization]
				...
			[OldAssets]
				...
			[OldParts]
				...
			[Parts]
				...
			[Patches]
				...
			[Sounds]
				...
			[Spaces]
				...
			[Squad]
				...
			CHANGE_LOG.md
			LICENSE
			NOTICE
			README.md
			BashCopyTextures.sh
			Windows_CopyTextures.bat
			SXT.version
			SXT.restockwhitelist
		000_KSPe.dll
		ModuleManager.dll
		...
	[PluginData]
		[SXT]
			...
	KSP.log
	PastDatabase.cfg
	...
```


### Dependencies

* [KSP API Extensions/L](https://github.com/net-lisias-ksp/KSPAPIExtensions)
	+ Not included
* [Firespitter /L Unofficial](https://github.com/net-lisias-kspu/Firespitter)
	+ Not included
* [RetractableLiftingSurface /L Unofficial](https://github.com/net-lisias-kspu/RetractableLiftingSurface)
	+ Not included

