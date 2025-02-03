using System.Windows;

[assembly:ThemeInfo(
    ResourceDictionaryLocation.None,            //where theme specific resource dictionaries are located
                                                //(used if a resource is not found in the page,
                                                // or application resource dictionaries)
    ResourceDictionaryLocation.SourceAssembly   //where the generic resource dictionary is located
                                                //(used if a resource is not found in the page,
                                                // app, or any theme specific resource dictionaries)
)]

[assembly:ArmDot.Client.HideStrings]
[assembly:ArmDot.Client.ObfuscateControlFlow]
[assembly:ArmDot.Client.ObfuscateNames]
