wcm.io AEM Manager
==================

Taskbar application for managing AEM instances on Windows.


Overview
---------

The AEM manager is a Windows application that allows to manage local AEM instances for AEM developers. It allows to start, stop instances and monitor their bundles statuses in the taskbar. Via context menu quick links are available to the most important entry points.


Installation
------------

* Download the latest release from the [Releases](https://github.com/wcm-io-devops/aem-manager/releases) section.
* Execute the Windows installer `AEMManagerSetup.msi`
* The AEM manager installs automatically an places an "AEM Manager" shortcut in the Startup folder of the start menu

Tested with Windows 7 and Windows 8.


Features
--------

After starting the AEM manager a new icon is displayed in the Windows Taskbar:

![AEM Manager in Taskbar](/resources/doc-images/aem-manager-taskbar.png)

A double click on the icon opens the list of instances

![AEM Manager Instance List](/resources/doc-images/aem-manager.png)

You can define new instances:

![AEM Instance](/resources/doc-images/aem-instances.png)

The main taskbar icon offers a context menu with some global useful links, and the possible to choose for which instances a separate icon should be displayed in the taskbar:

![AEM Manager Context Menu](/resources/doc-images/aem-manager-context-menu.png)

For each instance icon a context menu offers to start/stop the instance, open log files or open a browser to jump into different entry points:

![AEM Instance Context Menu](/resources/doc-images/aem-instance-context-menu.png)

The startup/bundle status of each instances is visualized in the taskbar icon color/overlay icon color:

Icon | Overlay Icon | State
-----|--------------|-------
![Disabled](/resources/doc-images/icons/icon_disabled.gif) | ![Disabled](/resources/doc-images/icons/icon_overlay_disabled.gif) | AEM instances is not running
![Stopping](/resources/doc-images/icons/icon_stopping.gif) | ![Stopping](/resources/doc-images/icons/icon_overlay_stopping.gif) | AEM instances is currently starting or stopping, Felix console is not available, unable to get bundel status
![Starting](/resources/doc-images/icons/icon_starting.gif) | ![Starting](/resources/doc-images/icons/icon_overlay_starting.gif) | Some bundles in the AEM instances are starting/stopping or could not be started
![Running](/resources/doc-images/icons/icon_running.gif) | ![Running](/resources/doc-images/icons/icon_overlay_running.gif) | AEM instances is running and all bundles are started
