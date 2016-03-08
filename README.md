wcm.io AEM Manager for Windows
==============================

Taskbar application for managing AEM instances on Windows.

There is also a version for Mac OS X:
https://github.com/wcm-io-devops/aem-manager-osx


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

After starting the AEM manager a new icon is displayed in the Windows taskbar:

![AEM Manager in Taskbar](/resources/doc-images/aem-manager-taskbar.png)

A double click on the icon opens the list of instances

![AEM Manager Instance List](/resources/doc-images/aem-manager.png)

You can define new instances:

![AEM Instance](/resources/doc-images/aem-instance.png)

The main taskbar icon offers a context menu with some global useful links, and the possible to choose for which instances a separate icon should be displayed in the taskbar:

![AEM Manager Context Menu](/resources/doc-images/aem-manager-context-menu.png)

For each instance icon a context menu offers to start/stop the instance, open log files or open a browser to jump into different entry points:

![AEM Instance Context Menu](/resources/doc-images/aem-instance-context-menu.png)

The startup/bundle status of each instances is visualized in the taskbar icon color/overlay icon color:

Icon | Overlay Icon | State
-----|--------------|-------
![Disabled](/resources/doc-images/icons/icon_disabled.png) | ![Disabled](/resources/doc-images/icons/icon_overlay_disabled.png) | AEM instances is not running
![Stopped](/resources/doc-images/icons/icon_stopped.png) | ![Stopped](/resources/doc-images/icons/icon_overlay_stopped.png) | AEM instances is currently starting or stopped, Felix console is not available, unable to get bundle status
![Starting](/resources/doc-images/icons/icon_starting.png) | ![Starting](/resources/doc-images/icons/icon_overlay_starting.png) | Some bundles in the AEM instances are currently starting/stopping or could not be started
![Running](/resources/doc-images/icons/icon_running.png) | ![Running](/resources/doc-images/icons/icon_overlay_running.png) | AEM instances is running and all bundles are started


Preferences
-----------

From the AEM Manager window you can configure preferences via File > Preferences. Currenty the log viewer application can be configured that is used by the shortcuts to log files of an AEM instance.

It is recommended to install [Otros Log Viewer](https://github.com/otros-systems/otroslogviewer) and configure it in the preference dialog.

Here you will find a customized Log-importer configuration so Otros Log Viewer will understand the default AEM log file format by default: [otros-config](https://github.com/wcm-io/wcm-io-tooling/tree/develop/misc/log-analysis/otros-config).



Issue Tracking
--------------

For bugs and enhancement requests please file a ticket at https://wcm-io.atlassian.net/projects/WDEVOP
