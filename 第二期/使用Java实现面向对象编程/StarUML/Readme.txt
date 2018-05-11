-------------------------------------------------------------------------------
                                StarUML(TM) 5.0
                                 RELEASE NOTES
                                   2005. 12
--------------------------------------------------------------------------------

This document contains the latest information and other additional information 
which is not presented in the document of StarUML(TM). We recommend you to 
read this content. 
For more information, please visit http://www.staruml.com or
http://staruml.tigris.org

--------------------------------------------------------------------------------
Table of Contents

1. System Requirements
2. Before Installation (Important)
3. Major Features
3. Change Log
  3.1. From StarUML 5.0 Beta2
  3.2. From StarUML 5.0 Beta1
  3.3  From Agora Plastic
--------------------------------------------------------------------------------

1. System Requirements
=======================

  * Intel(R) Pentium(R) 233MHz or higher 
  * Windows(R) 2000, Windows XP(TM) or higher 
  * Microsoft(R) Internet Explorer 5.0 or higher 
  * Microsoft(R) Office XP(TM) or higher (recommended)
  * 128 MB RAM (256MB recommended) 
  * 110 MB hard disc space (150MB free space recommended) 
  * CD-ROM drive 
  * SVGA or higher resolution monitor (1024x768 recommended) 
  * Mouse or other pointing device 

2. Before Installation (Important)
==================================

  * Check whether any of the following previous versions of Plastic Software 
    products are installed on the system.
    - PLASTIC 2.0
    - PLASTIC 3.0
    - PLASTIC 3.0+
    - PLASTIC EXPRESS
    It is recommended to uninstall any of the above programs.

  * Check whether any of the following previous versions of Plastic Software 
    products are installed on the system.
    - PLASTIC 2003 Personal
    - PLASTIC 2003 Standard
    - PLASTIC 2005 Trial
    - PLASTIC 2005 Personal
    - PLASTIC 2005 Standard
    These programs must be uninstalled before installing StarUML(TM).

  * If you are using StarUML(TM) 5.0 Beta1 or Beta2, please uninstall it.

  * Microsoft(R) Internet Explorer 5.0 or above is required (Start Internet 
    Explorer and select the Help -> About Internet Explorer menu to check the 
    product version). If the version is lower than 5.0, some software functions 
    may not work properly.

3. Major Features
==================================

  * Supports UML 2.0
    UML is continuously expanding standard managed by OMG(Object Management 
    Group). Recently, UML 2.0 is released and StarUML support UML 2.0 and will 
    support lastest UML standard.
    
  * Supports MDA(Model Driven Architecture)
    MDA is a new technology introduced by OMG. To get advantages of MDA, 
    software modeling tool should support many customization variables. StarUML 
    is designed to support MDA and provides many customization variables like as
    UML profile, Approach, Model Framework, NX(notation extension), MDA code and
    document template and so on. They will help you fitting tool into your 
    organizational cultures, processes, and projects.
    
  * Plug-in Architecture
    Many users require more and more functionalities to software modeling tools. 
    To meet the requirements, the tool must have well-defined plug-in platform. 
    StarUML provides simple and powerful plug-in architecture so anyone can 
    develop plug-in modules in COM-compatible languages (C++, Delphi, C#, VB, 
    ...)
    
  * Usability
    Usability is most important issue in software development. StarUML is 
    implemented to provide many user-friend features such as Quick dialog, 
    Keyboard manipulation, Diagram overview, etc.

4. Change Log
==================================

4.1. From StarUML 5.0 Beta2
----------------------------------

[New Features]
 - Appended stereotype display button in the model explorer. It's states are 
   stores in system registry. [Browser]-"Show stereotype" option item doesn't 
   exist any more. (Issue #44)
 - Approach supports diagram type. (Issue #45)

[Changes]
 - Displays the lock mark when double click a palette item button. (Issue #1)
 - Modified style of palette slightly.
 - When double click element-typed attachement, the target element is selected 
   and the diagram which contains the target element is activated. (Issue #38)
 - Forms of StarUML and it's core modules are changed slightly. (Issue #9, #43,
   #59, #65, #68)
 - Removed [Properties] menu item. (Issue #51)
 - Modified not to generate ';' character at the end of function when generate 
   C++ code. (Issue #25)
 - Project tree node is expanded when project is created or loaded. (Issue #52)
 - Help file of StarUML are installed in local basically. 
 - IHashTable interface supported by generator provides functions for 
   enumerating hash table. (Issue #67)
 - Changed file ecoding of text generation engine.
 - Added "Wordwrap" option item. (Issue #15)

[Bug Fixes]
 - Fixed the bug that wordwrap property is not affected after reloading.
   (Issue #2)
 - Fixed the bug that message window is not activated after finding elements.
   (Issue #45)
 - Fixed the bug that the change of element's documentation is ignored when 
   saving the model file without delay after writing documentation. (Issue #13) 
 - Fixed several bugs which are related with docking windows. (Issue #29, #35)
 - Fixed the bug element name label in the property editor is too big in windows 
   XP. But it doesn't show in multi-line by size of the property editor any
   more. (Issue #56)
 - Corrected the order of "Reference Data Member Creation" group box items in 
   the C++ reverse engineering dialog. (Issue #58)
 - Fixed the bug that main window is maximized with incomplete size when
   starting of program in windows XP. (Issue #66)
   
4.2. From StarUML 5.0 Beta1
----------------------------------

[New Feature]
 - Shows the name of contributors as initial name of element when creating 
   elements. (Issue #17)

[Changes]
 - Changed item list of "Show stereotype" option in Environment.opt file. 
   (Issue #12)
 - Changed the namespace on xmlns of <XPD:PROJECT> element of StarUML model file
   (.UML) from "www.plasticsoftware.com" to "www.staruml.com". (Issue #19)
 - Modified to show read only state icon on element node of model explorer.
   (Issue #20)
 - Modified Stereotype applied element to show icon of the stereotype in model 
   explorer. (Issue #30)

[Bug Fixes]
 - Fixed the bug that icons of message has been invisible in the message. 
   (Issue #4)
 - Fixed the bug that an "Access violation" error occures when rename activity 
   diagram after copying of ActivityGraph. (Issue #10)
 - Fixed the bug that sub menu of the [Views] menu did't represent window states
   exactly. (Issue #16)
 - Modified to show english from Font dialog in Korean.(Issue #26)

4.2. From Agora Plastic
----------------------------------

[New Features]
 - Supports UML 2.0.
 - Geneates MS Word/Excel/Powerpoint documents and code from model. 
   (Generator Module)
 - Pallette extension (Configuring Add Menu, Notation, and Tool Button Icon).
 - Notation extension (User defined Notation, ex. ER Diagram Notation).
 - Registers and Load Extension Modules Automatically (AddIn, Profile, 
   Framework, Option, and Approach)
 - Supports Short Creation Textual Syntax in QuickDialog.
 - Supports Decoration View.
 - General Shape Added (Rectangle, Rounded Rect, Ellipse).
 - SignalAccept/SignalSend notation added.
 - Displays Raised Signal at Operation.
 - Displays UMLAttributeLink.
 - Supports Classifier Name WordWrap.
 - Includes Model Fragment in Approach.
 - Moves Selection and Resizes View using Arrow Keys.
 - Supports Docking UI Panes.
 - Copies Diagram to Bitmap Image.

[Bug Fixes and Changes]
 - Changes Project Name (Plastic -> StarUML).
 - Supports Real Number Style in European OS. (ex. 0.01 -> 0,001).
 - Sets Stereotype to Model in Approach.
 - Applies Classifer Element's Stereotype to its Object Element automatically.
 - Fixes error when reading unit or project file including Multilanguage unit 
   file.
 - Pops up Suggestions Hint while typing in QuickDialog.
 - Changes Layout Direction for StateChart/Activity Diagram(from Top to Bottom).
 - Displays Message name without parentheses in Sequence Diagram.
 - Shows Instance of Classifier in TreeView.
 - Shows Usecase in Iconic Style.
 - ObjectFlowState View Added.
 - Shows SlotCompartment View for Object Elemement.
 - Shows ExtensionPoint Compartment for Usecase Element.
 - Removes "Import Unit" Menu.
 - Removes UML Adivisor and Embedded WebBrower from UI.
 - Moves Diagram Tab to Popup Menu.
 
 * Issue number(Issue #) means registering number of the issue in the StarUML 
  issue tracker(http://staruml.tigris.com).

