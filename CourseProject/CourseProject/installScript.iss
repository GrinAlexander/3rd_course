; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

[Setup]
; NOTE: The value of AppId uniquely identifies this application. Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{D17F8ACC-4B5F-43BE-BF86-7BA1307DBCEF}
AppName=Curves
AppVersion=1.0
;AppVerName=Curves 1.0
AppPublisher=BetaCookies
AppPublisherURL=https://vk.com/elirhard
AppSupportURL=https://vk.com/elirhard
AppUpdatesURL=https://vk.com/elirhard
DefaultDirName={autopf}\Curves
DisableProgramGroupPage=yes
; Uncomment the following line to run in non administrative install mode (install for current user only.)
;PrivilegesRequired=lowest
PrivilegesRequiredOverridesAllowed=dialog
OutputDir=C:\Users\Alexander\Desktop
OutputBaseFilename=curvesSetup
SetupIconFile=C:\Users\Alexander\Documents\GitHub\3rd_course\CourseProject\CourseProject\icon.ico
Compression=lzma
SolidCompression=yes
WizardStyle=modern

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"
Name: "russian"; MessagesFile: "compiler:Languages\Russian.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "C:\Users\Alexander\Documents\GitHub\3rd_course\CourseProject\CourseProject\bin\x64\Debug\CourseProject.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Alexander\Desktop\Manual\Manual.chm"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Alexander\Documents\GitHub\3rd_course\CourseProject\CourseProject\icon.ico"; DestDir: "{app}"; Flags: ignoreversion
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Icons]
Name: "{autoprograms}\Curves"; Filename: "{app}\CourseProject.exe"; IconFilename: "{app}\icon.ico" 
Name: "{autodesktop}\Curves"; Filename: "{app}\CourseProject.exe"; IconFilename: "{app}\icon.ico"; Tasks: desktopicon

[Run]
Filename: "{app}\CourseProject.exe"; Description: "{cm:LaunchProgram,Curves}"; Flags: nowait postinstall skipifsilent

