﻿using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("wcm.io AEM Manager")]
[assembly: AssemblyDescription("Taskbar application for managing AEM instances")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("wcm.io")]
[assembly: AssemblyProduct("wcm.io AEM Manager")]
[assembly: AssemblyCopyright("©2010-2015 pro!vision GmbH, wcm.io")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible
// to COM components.  If you need to access a type in this assembly from
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("7eb3bb90-a3f2-4a71-aee0-fbc04cabfb32")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version
//      Build Number
//      Revision
//
[assembly: AssemblyVersion("2.0.0.0")]
[assembly: AssemblyFileVersion("2.0.0.0")]

// Configure log4net using the .config file
[assembly: log4net.Config.XmlConfiguratorAttribute(Watch = true)]
