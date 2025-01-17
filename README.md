
![Logo](My%20Project/media/logo.png)
<p align=center>Robert McAnany 2023

**Contributors:**
@farfilli (aka @Fiorini), @daysanduski, @mmtrebuchet

**Beta Testers:**
@JayJay101, @Cimarian_RMP, @n0minus38, @xenia.turon, @MonkTheOCD_Engie,
@HIL

**Helpful feedback and bug reports:**
@Satyen, @n0minus38, @wku, @aredderson, @bshand, @TeeVar, @SeanCresswell, 
@Jean-Louis, @Jan_Bos, @MonkTheOCD_Engie, @[mike miller], @Fiorini, 
@[Martin Bernhard], @[Derek G], @Chris42, @Jason1607436093479, @Bob Henry, 
@JayJay101, @nate.arinta5649, @DaveG, @tempod, @64Pacific, @ben.steele6044,
@KennyG, @Alex_H, @Nosybottle, @Seva, @HIL

**Notice:**
*Portions adapted from code by Jason Newell, Tushar Suradkar, Greg Chasteen,*
*and others.  Most of the rest copied verbatim from Jason's repo or Tushar's blog.*

## DESCRIPTION

Solid Edge Housekeeper helps you find annoying little errors in your project. 
It can identify failed features in 3D models, detached dimensions in drawings, 
missing parts in assemblies, and more.  It can also update certain individual 
file settings to match those in a template you specify.

<p align="center">
  <img src="My%20Project/media/home_tab_done.png">
</p>

*Feedback from users*

> *This is the Michael Jordan of macros!  I've tried lots of them.  This is*
> *on a whole other level.  Thank you!*

> *This is going to save me SO MUCH TIME!  Thank you for sharing!*

> *Thank you for all your time and effort (...) Also thanks a lot for making it*
> *open source. I constantly reference your code for my own macros, which motivates*
> *me to make my projects open source as well.*

> *Awesome. It looks like you are still overachieving with this app, and I thank*
> *you for it. If they ever figure out how to automate me running Housekeeper, I*
> *will be out of a job!*

> *Rad, this saves a mountain of time for me. Thanks!*

Responding to the prompt *"Heard any good jokes about Solid Edge Housekeeper?"*,
Google's Bard said:

> *Why did the Solid Edge Housekeeper get a promotion?*  
> *She was the only one who could clean up the mess that Solid Edge users make.*

## GETTING HELP

Start with the Readme.  To quickly navigate, use the Table of Contents
by clicking
![Table of Contents](My%20Project/media/table_of_contents_icon.png)
as shown in the image below.

![Table of Contents](My%20Project/media/table_of_contents.png)

Ask questions, report bugs, or suggest improvements on the 
[**Solid Edge Forum**](https://community.sw.siemens.com/s/topic/0TO4O000000MihiWAC/solid-edge)


## HELPING OUT

If you want to make Housekeeper better, join us as a beta tester! 
Beta testing is nothing more than conducting your own workflow on your own 
files and telling me if you run into problems. 
It isn't meant to be a lot of work. 
The big idea is to make the program better for you and me and everyone else!

To sign up, message me, RobertMcAnany, on the forum. 
(The `Messages` button is hidden under your profile picture,
at the very top right of the page). 
Unsubscribe the same way. 
To combat bots and spam, I will probably 
ignore requests from `User16612341234...`. 
(Change you nickname in `My Profile`,
also under your profile picture). 

If you know .NET, or want to learn, there's more
to do!  To get started on GitHub collaboration, head over to
[**ToyProject**](https://github.com/rmcanany/ToyProject). 
There are instructions and links to get you up to speed.


## INSTALLATION

There is no installation *per se*.  The preferred method is to download or clone 
the project and compile it yourself.

The other option is to use the 
[**Latest Release**](https://github.com/rmcanany/SolidEdgeHousekeeper/releases). 
It will be the top entry on the page. 


<p align="center">
  <img src="My%20Project/media/release_page.png">
</p>

Click the 
file `SolidEdgeHousekeeper-VYYYY.N.zip` 
(sometimes hidden under the Assets dropdown). 
It should prompt you to save it. 
Choose a convenient location on your machine. 
Extract the zip file (probably by right-clicking and selecting Extract All). 
Double-click the `.exe` file to run.

The first time you run it, you may encounter the following dialog.  You can click 
`More Info` followed by `Run Anyway` to launch the program.
![Run Anyway](My%20Project/media/run_anyway.png)

If you are upgrading from a previous release, you should be able to copy 
the settings files from the old version to the new. 
The files are `defaults.txt`, `property_filters.txt`, and `filename_charmap.txt`. 
If you haven't used Property Filter, `property_filters.txt` won't be there. 
Versions prior to 0.1.10 won't have `filename_charmap.txt` either.

## OPERATION

![Tabs](My%20Project/media/tabs.png)

On each file type's tab, select which tasks to perform. 
On the Home tab, select which files to process. 
You can select files by folder, subfolder, top-level assembly,
top-level folder, list, or drag-and-drop.
There can be any number of each, in any combination.
You can refine the search using a property filter, a wildcard filter, or both. 
See **FILE SELECTION AND FILTERING** below for details. 

If any errors are found, a log file will be written 
to your temp folder. 
It will identify each error and the file in which it occurred. 
When processing is complete, the log file is opened in Notepad for review.

The first time you use the program, some site-specific information is needed. 
This includes the location of your templates, material table, etc. 
These are populated on the **Configuration Tab**.

![Status Bar](My%20Project/media/status_bar_ready.png)

To start execution, click the `Process` button.  The status
bar provides feedback to help you monitor progress. 
You can also stop execution if desired.
See **STARTING, STOPPING, AND MONITORING EXECUTION** for details.




## FILE SELECTION AND FILTERING

### Selection

The **Home Tab** is where you select which files to process.  As mentioned above,
using the Selection Toolbar, you can select by folder, subfolder, top-level 
assembly, top-level folder, or list.
There can be any number of each, in any combination.  

Another option is to drag and drop files from Windows File Explorer. 
You can use drag and drop and the toolbar in combination.

An alternative method is to select files with errors from a previous run. 

![Toolbar](My%20Project/media/selection_toolbar_labeled.png)

#### 1. Select by Folder

Choose this option to select files within a single folder, 
or a folder and its subfolders. 
Referring to the diagram, 
click ![Folder](Resources/icons8_Folder_16.png)
to select a single folder, 
click ![Folders](Resources/icons8_folder_tree_16.png)
for a folder and sub folders.

#### 2. Select by Top-Level Assembly

Choose this option to select files linked to an assembly.
Click ![Assembly](Resources/ST9%20-%20asm.png)
to choose the assembly, 
click ![Assembly Folders](Resources/icons8_Folders_16.png)
to choose the search path for *where used* files. 

You would be asking for trouble specifying more than one
top-level assembly.  However, you can have any number of folders.
Note the program always includes subfolders for *where used* files.

![Top level assembly options](My%20Project/media/top_level_assy_options.png)

A top level assembly search can optionally report files with no links to the 
assembly.  Set this option on the **Configuration Tab**.

When selecting a top-level assembly, you can 
automatically include the folder in which it resides.
This `auto include` option in on by default. 
Set it on the **Configuration Tab**.

If `auto include` is turned off, 
you do not have to specify any folders. 
In that case, Housekeeper simply finds
files directly linked to the specified assembly and subassemblies. 
Note this means that no draft files will be found.
For that reason, a warning is displayed.
Disable the warning on the **Configuration Tab**.

If you *do* specify one or more folders, there are two options for performing 
*where used*, **Top Down** or **Bottom Up** (see next).  Make 
this selection on the **Configuration Tab**.  Guidelines are given below,
however it's not a bad idea to try both methods to see which works best
for you.

**Bottom Up**

Bottom up is meant for general purpose (hopefully indexed) directories 
(e.g., `\\BIG_SERVER\all_parts\`), where the number of files 
in the folder(s) far exceed the number of files in the assembly. 
The program gets links by recursion, then 
finds draft files with *where used*. 
If your draft files have the same name as the model they depict, 
you can bypass *where used*.  Set this option on the **Configuration Tab**.

A bottom up search requires a valid Fast Search Scope filename, 
(e.g., `C:\Program Files\...\Preferences\FastSearchScope.txt`), 
which tells the program if the specified folder is on an indexed drive. 
Set the Fast Search Scope filename on the **Configuration Tab**.

**Top Down**

Top down is meant for self-contained project directories 
(e.g., `C:\Projects\Project123\`), where most of the files 
in the folder(s) are related to the assembly. 
The program launches Design Manager to open every file within and below the 
top-level assembly folder(s). 
As it does, it creates a graph of the links. 
The graph is subsequently traversed to find related files. 
I don't know how it works; my son did that part. 

**Include parents of part copies option**

![Top level assembly options](My%20Project/media/top_level_assy_diagram.png)

This option may be confusing.  Referring to the diagram, 
note that `C.par` is a parent of `B.par`.  `B.par` is in `top.asm`,
while `C.par` is not.
Enabling the option means that 
`C.par` would be included in the search results.

#### 3. Select by list

Referring to the diagram, 
click ![Import List](Resources/icons8_Import_16.png)
to import a list, 
click ![Export List](Resources/icons8_Export_16.png)
to export one.  

If you are importing a list from another source, be aware that the 
file names must contain the full path.  E.g.,
`D:\Projects\Project123\Partxyz.par`, not just `Project123\Partxyz.par`.

#### 4. Tools

**Select files with errors from the previous run**

Click ![Errors](Resources/icons8_Error_16.png)
to select only files that encountered an error. 
All other files will be removed from the list.  To reproduce the 
TODO list functionality from previous versions, you can export the 
resultant list if desired.

**Remove all**

Click ![Remove All](Resources/icons8_trash_16.png)
to remove all folders and files from the list.

**Shortcut menu**

If you select one or more files on the list, you can click the right 
mouse button for more options.  

![Shortcut Menu](My%20Project/media/shortcut_menu.png)

- **Open:** Opens the files in Solid Edge.
- **Open folder:** Opens the files in Windows File Explorer.
- **Find linked files:** Populates the list with files linked to 
a top-level assembly.  Similar to **Update** but no other File Sources
are processed.
- **Process selected:** Runs selected Tasks on the selected files. 
Same as clicking **Process** at the bottom of the **Home Tab**.
- **Remove from list:** Moves the files to the *Excluded files* 
section of the list.

#### 5. Update

The update button 
![Update](Resources/Synch_16.png)
populates the file list from the File Sources and Filters.
If any Sources are added or removed, or a change is made to a Filter (see **Filtering** below), 
an update is required.

#### 6. File Type

You can limit the search to return only selected types of Solid Edge files.
To do so, check/uncheck the appropriate File Type
![Assembly](Resources/ST9%20-%20asm.png)
![Part](Resources/ST9%20-%20par.png)
![Sheet Metal](Resources/ST9%20-%20psm.png)
![Draft](Resources/ST9%20-%20dft.png) 

### Sorting

![File list sorting options](My%20Project/media/file_sort_options.png)

You can choose sorting options of `Unsorted`, `Alphabetic`, 
`Dependency`, or `Random sample`.  These options are set on the 
**Configuration** Tab.

The `Unsorted` option is primarily 
intended to preserve the order of imported lists.

The `Dependency` option is useful in conjunction with
the `Update part copy` commands.  It is intended to help eliminate
the tedious `model out-of-date` (dark gray corners) on drawings. 

The dependency ordering is not fool proof.  It has trouble with
mutual dependencies, such as Interpart copies.  I've had some luck
simply running the process two times in a row.

The `Random sample` option randomly selects and shuffles
 a fraction of the total files found.  The `Sample fraction`
is a decimal number between `0.0` and `1.0`.

This option is primarily intended for software testing, 
but can be used for any purpose.

### Filtering

![Filter Toolbar](My%20Project/media/filter_toolbar.png)

Filters are a way to refine the list of files to process.  You can filter 
on file properties, or filenames (with a wildcard search). 
They can be used alone or in combination.

#### 1. Property Filter

The property filter allows you to select files by their property values.
To configure a property filter, 
click the tool icon ![Configure](Resources/icons8_Tools_16.png)
to the right of
the Property filter checkbox. 

The Property Filter checks Draft files, but they
often don't have properties of their own.
So for those files, Housekeeper also searches 
any models in the drawing for the specified properties. 

This is a powerful tool with a lot
of options. These are detailed below.

**Composing a Filter**

<p align="center">
  <img src="My%20Project/media/property_filter.png">
</p>

Compose a filter by defining one or more **Conditions**, and adding them 
one-by-one to the list.
A **Condition** consists of a **Property**, a **Comparison**, and a **Value**.
For example, `Material contains Steel`, where `Material` is the **Property**, 
`contains` is the **Comparison**, and `Steel` is the **Value**.

Up to six Conditions are allowed for a filter.
The filters can be named, saved, modified, and deleted as desired.

**Property Set**

In addition to entering the `Property name`, you must also 
select the `Property set`, either `System` or `Custom`.

`System` properties are in every Solid Edge file.
They include `Material`, `Project`, etc.
Note, at this time, they must be in English.

`Custom` properties are ones that you create, probably in a template.
Solid Edge also creates some Custom properties for you.
These include `Exposed Variables` and output from 
the `Inspect > Physical Properties` command.
The custom property names can be in any language. 
(In theory, at least -- not tested at this time.
Not sure about the Solid Edge entries either.)

**Comparison**

Select the Comparison from its dropdown box.
The choices are `contains`, `is_exactly`, `is_not`, 
`wildcard_match`, `regex_match`, `>`, or `<`.
The options `is_exactly`, `is_not`, `>`, and `<` are hopefully 
self explanatory.

`Contains` means the Value can appear anywhere in the property.
For example, if you specify `Aluminum` and a part file has 
`Aluminum 6061-T6`, you will get a match.
Note, at this time, all Values (except see below for dates and numbers) 
are converted to lower case text before comparison.
So `ALUMINUM`, `Aluminum`, and `aluminum` would all match.

`Wildcard_match` searches for a match with a wildcard pattern.
For example `[bfj]ake` would match `bake`, `fake`, and `jake`. 
A more familiar example might be `Aluminum*`,
which would match `Aluminum 6061-T6`, `Aluminum 2023`, etc.
Unlike with `contains`, in this example, 
`Cast Aluminum Jigplate` would *not* match.

Internally the 
[**VB Like Operator**](https://docs.microsoft.com/en-us/dotnet/visual-basic/language-reference/operators/like-operator)
is used to make the wildcard comparison.  Visit the link for details and examples.

`Regex_match` uses Regular Expressions.  They are flexible and powerful, but explaining them is beyond the scope of this document.
For more information see 
[**REGEX in .NET**](https://learn.microsoft.com/en-us/dotnet/standard/base-types/regular-expression-language-quick-reference)

**Default Filter Formula**

Each Condition is assigned a variable name, (`A`, `B`, `...`).
The default filter formula is to match all conditions (e.g., `A AND B AND C`).

![Property Filter Detail](My%20Project/media/property_filter_detail.png)

In the image above, 
the default formula means you will get all parts in project 7481 
made out of Stainless and engineered by Fred,
i.e., `A AND B AND C`.

**Editing the Formula**

You can optionally change the formula.
Click the Edit button and type the desired expression.
For example, if you wanted all parts from Project 7481, 
**either** made out of Stainless, 
**or** engineered by Fred, you would enter the formula shown, 
i.e., `A AND (B OR C)`.

**Dates and Numbers**

Dates and numbers are converted to their native format when possible.
This is done to obtain commonsense results for `<` and `>`.
Note the conversion is attempted even if the property type is
`TEXT`, rather than `NUMBER`, `DATE`, or `YES/NO`.

Dates take the form `YYYYMMDD` when converted.
This is the format that must be used in the `Value` field.
So if you wanted all files dated before January 1, 2022, your condition would be
`Custom.Date < 20220101`.
The conversion is supposed to be locale-aware, however this has not been tested.
Please ask on the Solid Edge Forum if it is not working correctly for you.

Numbers are converted to floating point decimals.
In Solid Edge many numbers, in particular those from the variable table, 
include units.
These must be stripped off by the program to make comparisons.
Currently only distance and mass units are checked (`in`, `mm`, `lbm`, `kg`).
It`s easy to add more, so please ask on the Forum if you need others.

**Saved Settings**

The filters are saved in `property_filters.txt` in the same directory as 
`Housekeeper.exe`.
If desired, you can create a master copy of the file and share it with others.
You can manually edit the file, 
however, note that the field delimiter is the TAB character.
This was done so that the property name and value fields could contain 
spaces.

#### 2. Wildcard Filter

The wildcard filter operates on file names.
Simply enter the wildcard pattern in the 
provided combobox.  Wildcard patterns are automatically saved for 
future use.  Delete a pattern that is no longer needed by selecting it 
and clicking ![Draft](Resources/icons8_Close_Window_16.png). 

As suggested above, see
[**VB Like Operator**](https://docs.microsoft.com/en-us/dotnet/visual-basic/language-reference/operators/like-operator)
for details and examples.

## STARTING, STOPPING, AND MONITORING EXECUTION

![Tabs](My%20Project/media/status_bar_running.png)

Press the Process button to start executing the chosen tasks.
If one or more files on the list were selected, only those are processed.
Otherwise, all files are processed.

A checkbox
![Error](Resources/icons8_unchecked_checkbox_16.png) to the left of
the file name indicates it has yet to be processed. Afterwards, if no errors were
detected, a checkmark 
![Error](Resources/icons8_Checked_Checkbox_16.png) is shown. 
Otherwise, an error indicator 
![Error](Resources/icons8_Error_16.png) is displayed.

You can monitor progress on the status bar.  It shows the number of files
processed, the current file, and an estimate of time remaining.
 
You can also interrupt the program before it finishes. 
As shown above, while processing, 
the Cancel button changes to a Stop button.  Just click that to halt 
execution.  It may take several seconds to register the request.  It 
doesn't hurt to click it a couple of times.


## CAVEATS

Since the program can process a large number of files in a short amount of time, 
it can be very taxing on Solid Edge. 
To maintain a clean environment, the program restarts Solid Edge periodically. 
(Set the frequency on the **Configuration Tab**.)
This is by design and does not necessarily indicate a problem.

However, problems can arise. 
Those cases will be reported in the log file with the message 
`Error processing file`. 
A stack trace will be included, which may help debugging. 
If four of these errors are detected in a run, the programs halts with the 
Status Bar message `Processing aborted`.

Please note this is not a perfect program.  It is not guaranteed not to mess 
up your work.  Back up any files before using it.

## KNOWN ISSUES

**Does not support managed files**  
*Cause*: Unknown.  
*Possible workaround*: Process the files in an unmanaged workspace.  
*Update 10/10/2021* Some users have reported success with BiDM managed files.  
*Update 1/25/2022* One user has reported success with Teamcenter 'cached' files. 

**Older Solid Edge versions**  
Some tasks cannot be run on older versions.  
*Cause*: Probably an API call not available in previous versions.  
*Possible workaround*: Use the latest version, or avoid use of the
task causing problems. 

**May not support multiple installed Solid Edge versions**  
*Cause*: Unknown.  
*Possible workaround*: Use the version that was 'silently' installed. 

**Printer settings**  
Does not support all printer settings, e.g., duplexing, collating, etc.  
*Cause*: Not exposed in the `DraftPrintUtility()` API.  
*Possible workaround*: Create a new Windows printer with the desired settings. 
Refer to the **Draft Tasks -- Print Topic** below for more details. 

**Pathfinder sometimes blank during Interactive Edit**  
*Cause*: Unknown.  
*Possible workaround*: Refresh the screen by minimizing and maximizing the 
Solid Edge window. 

## TASK DESCRIPTIONS

<p align="center">
  <img src="My%20Project/media/sheetmetal_done.png">
</p>

<!-- Everything below this line is auto-generated.  Do not edit. -->
<!-- Start -->

### Assembly

#### Open/Save
Open a document and save in the current version.

#### Activate and update all
Loads all assembly occurrences' geometry into memory and does an update. Used mainly to eliminate the gray corners on assembly drawings. 

Can run out of memory for very large assemblies.

#### Property find replace
Searches for text in a specified property and replaces it if found. The property, search text, and replacement text are entered on the **Task Tab**, below the task list. 

![Find_Replace](My%20Project/media/property_find_replace.png)

A `Property set`, either `System` or `Custom`, is required. For more information, see the **Property Filter** section above. 

There are three search modes, `PT`, `WC`, and `RX`.  

- `PT` stands for 'Plain Text'.  It is simple to use, but finds literal matches only.  
- `WC` stands for 'Wild Card'.  You use `*`, `?`  `[charlist]`, and `[!charlist]` according to the VB Like syntax.  
- `RX` stands for 'Regex'.  It is a more comprehensive (and notoriously cryptic) method of matching text.  Check the [**.NET Regex Guide**](https://learn.microsoft.com/en-us/dotnet/standard/base-types/regular-expression-language-quick-reference) for more information.

The search *is not* case sensitive, the replacement *is*. For example, say the search is `aluminum`, the replacement is `ALUMINUM`, and the property value is `Aluminum 6061-T6`. Then the new value would be `ALUMINUM 6061-T6`. 

![Property Formula](My%20Project/media/property_formula.png)

In addition to plain text and pattern matching, you can also use a property formula.  The formula has the same syntax as the Callout command, except preceeded with 'System.' or 'Custom.' as above.  

#### Expose variables missing
Checks to see if all the variables listed in `Variables to expose` are present in the document.

#### Expose variables
Exposes entries from the variable table, making them available as a Custom property. Enter the names as a comma-delimited list in the `Variables to expose` textbox. Optionally include a different Expose Name, set off by the colon `:` character. 

For example `var1, var2, var3`

Or `var1: Length, var2: Width, var3: Height`

Or a combination `var1: Length, var2, var3`

Note: You cannot use either a comma `,` or a colon `:` in the Expose Name. Actually there's nothing stopping you, but it will not do what you want. 

#### Remove face style overrides
Face style overrides change a part's appearance in the assembly. This command causes the part to appear the same in the part file and the assembly.

#### Update face and view styles from template
Updates the file with face and view styles from a file you specify on the **Configuration Tab**. 

Note, the view style must be a named style.  Overrides are ignored. To create a named style from an override, open the template in Solid Edge, activate the `View Overrides` dialog, and click `Save As`.

#### Hide constructions
Hides all non-model elements such as reference planes, PMI dimensions, etc.

#### Fit pictorial view
Maximizes the window, sets the view orientation, and does a fit. Select the desired orientation on the **Configuration Tab**.

#### Part number does not match file name
Checks if a file property, that you specify on the **Configuration Tab**, matches the file name.

#### Missing drawing
Assumes drawing has the same name as the model, and is in the same directory

#### Broken links
Checks to see if any assembly occurrence is pointing to a file not found on disk.

#### Links outside input directory
Checks to see if any assembly occurrence resides outside the top level directories specified on the **Home Tab**. 

#### Failed relationships
Checks if any assembly occurrences have conflicting or otherwise broken relationships.

#### Underconstrained relationships
Checks if any assembly occurrences have missing relationships.

#### Run external program
Runs an `\*.exe` or `\*.vbs` file.  Select the program with the `Browse` button. It is located on the **Task Tab** below the task list. 

If you are writing your own program, be aware several interoperability rules apply. See [**HousekeeperExternalPrograms**](https://github.com/rmcanany/HousekeeperExternalPrograms) for details and examples. 

#### Interactive edit
Brings up files one at a time for manual processing. A dialog box lets you tell Housekeeper when you are done. 

Some rules for interactive editing apply. It is important to leave Solid Edge in the state you found it when the file was opened. For example, if you open another file, such as a drawing, you need to close it. If you add or modify a feature, you need to click Finish. 

Also, do not Close the file or do a Save As on it. Housekeeper maintains a `reference` to the file. Those two commands cause the reference to be lost, resulting in an exception. 

#### Save As
Exports the file to either a non-Solid Edge format, or the same format in a different directory. 

Select the file type using the `Save As` combobox. Select the directory using the `Browse` button, or check the `Original Directory` checkbox. These controls are on the **Task Tab** below the task list. 

Images can be saved with the aspect ratio of the model, rather than the window. The option is called `Save as image -- crop to model size`. It is located on the **Configuration Tab**. 

You can optionally create subdirectories using a formula similar to the Property Text Callout. For example `Material %{System.Material} Thickness %{Custom.Material Thickness}`. 

A `Property set`, either `System` or `Custom`, is required. For more information, see the **Property Filter** section above. 

It is possible that a property contains a character that cannot be used in a file name. If that happens, a replacement is read from filename_charmap.txt in the same directory as Housekeeper.exe. You can/should edit it to change the replacement characters to your preference. The file is created the first time you run Housekeeper.  For details, see the header comments in that file. 

### Part

#### Open/Save
Same as the Assembly command of the same name.

#### Property find replace
Same as the Assembly command of the same name.

#### Expose variables missing
Same as the Assembly command of the same name.

#### Expose variables
Same as the Assembly command of the same name.

#### Update face and view styles from template
Same as the Assembly command of the same name.

#### Update material from material table
Checks to see if the part's material name and properties match any material in a file you specify on the **Configuration Tab**. 

If the names match, but their properties (e.g., face style) do not, the material is updated. If the names do not match, or no material is assigned, it is reported in the log file.

#### Hide constructions
Same as the Assembly command of the same name.

#### Fit pictorial view
Same as the Assembly command of the same name.

#### Update part copies
In conjuction with `Assembly Activate and update all`, used mainly to eliminate the gray corners on assembly drawings.  You can optionally update the parent files recursively.  That option is on the Configuration Tab -- Miscellaneous Group.

#### Broken links
Same as the Assembly command of the same name.

#### Part number does not match file name
Same as the Assembly command of the same name.

#### Missing drawing
Same as the Assembly command of the same name.

#### Failed or warned features
Checks if any features of the model are in the Failed or Warned status.

#### Suppressed or rolled back features
Checks if any features of the model are in the Suppressed or Rolledback status.

#### Underconstrained profiles
Checks if any profiles are not fully constrained.

#### Part copies out of date
If the file has any insert part copies, checks if they are up to date.

#### Material not in material table
Checks the file's material against the material table. The material table is chosen on the **Configuration Tab**. 

#### Run external program
Same as the Assembly command of the same name.

#### Interactive edit
Same as the Assembly command of the same name.

#### Save As
Same as the Assembly command of the same name.

### Sheetmetal

#### Open/Save
Same as the Assembly command of the same name.

#### Property find replace
Same as the Assembly command of the same name.

#### Expose variables missing
Same as the Assembly command of the same name.

#### Expose variables
Same as the Assembly command of the same name.

#### Update face and view styles from template
Same as the Part command of the same name.

#### Update material from material table
Same as the Part command of the same name.

#### Hide constructions
Same as the Assembly command of the same name.

#### Fit pictorial view
Same as the Assembly command of the same name.

#### Update part copies
Same as the Part command of the same name.

#### Update design for cost
Updates DesignForCost and saves the document.

An annoyance of this command is that it opens the DesignForCost Edgebar pane, but is not able to close it. The user must manually close the pane in an interactive Sheetmetal session. The state of the pane is system-wide, not per-document, so closing it is a one-time action. 

#### Broken links
Same as the Assembly command of the same name.

#### Part number does not match file name
Same as the Part command of the same name.

#### Missing drawing
Same as the Assembly command of the same name.

#### Failed or warned features
Same as the Part command of the same name.

#### Suppressed or rolled back features
Same as the Part command of the same name.

#### Underconstrained profiles
Same as the Part command of the same name.

#### Part copies out of date
Same as the Part command of the same name.

#### Flat pattern missing or out of date
Checks for the existence of a flat pattern. If one is found, checks if it is up to date. 

#### Material not in material table
Same as the Part command of the same name.

#### Run external program
Same as the Assembly command of the same name.

#### Interactive edit
Same as the Assembly command of the same name.

#### Save As
Same as the Assembly command of the same name, except two additional options -- `DXF Flat (\*.dxf)` and `PDF Drawing (\*.pdf)`. 

The `DXF Flat` option saves the flat pattern of the sheet metal file. 

The `PDF Drawing` option saves the drawing of the sheet metal file. The drawing must have the same name as the model, and be in the same directory. A more flexible option may be to use the Draft `Save As`, using a `Property Filter` if needed. 

### Draft

#### Open/Save
Same as the Assembly command of the same name.

#### Property find replace
Same as the Assembly command of the same name.

#### Update drawing views
Checks drawing views one by one, and updates them if needed.

#### Update styles from template
Updates styles and background sheets from a template you specify on the **Configuration Tab**. 

These styles are processed: DimensionStyles, DrawingViewStyles, LinearStyles, TableStyles, TextCharStyles, TextStyles.  These are not: FillStyles, HatchPatternStyles, SmartFrame2dStyles.  The latter group encountered errors with the current implementation.  The errors were not thoroughtly investigated.  If you need one or more of those styles updated, please ask on the Forum.  

#### Update drawing border from template
Replaces the background border with that of the Draft template specified on the **Configuration Tab**.

In contrast to `UpdateStylesFromTemplate`, this command only replaces the border. It does not attempt to update styles or anything else.

#### Drawing view on background sheet
Checks background sheets for the presence of drawing views.

#### Fit view
Same as the Assembly command of the same name.

#### File name does not match model file name
Same as the Assembly command of the same name.

#### Broken links
Same as the Assembly command of the same name.

#### Drawing views out of date
Checks if drawing views are not up to date.

#### Detached dimensions or annotations
Checks that dimensions, balloons, callouts, etc. are attached to geometry in the drawing.

#### Parts list missing or out of date
Checks is there are any parts list in the drawing and if they are all up to date.

#### Run external program
Same as the Assembly command of the same name.

#### Interactive edit
Same as the Assembly command of the same name.

#### Print
Print settings are accessed on the **Configuration Tab**.

Note, the presence of the Printer Settings dialog is somewhat misleading. The only settings taken from it are the printer name, page height and width, and the number of copies. Any other selections revert back to the Windows defaults when printing. A workaround is to create a new Windows printer with the desired defaults. 

Another quirk is that, no matter the selection, the page width is always listed as greater than or equal to the page height. In most cases, checking `Auto orient` should provide the desired result. 

#### Save As
Same as the Assembly command of the same name, except as follows.

Optionally includes a watermark image on the output.  For the watermark, set X/W and Y/H to position the image, and Scale to change its size. The X/W and Y/H values are fractions of the sheet's width and height, respectively. So, (`0,0`) means lower left, (`0.5,0.5`) means centered, etc. Note some file formats may not support bitmap output.

The option `Use subdirectory formula` can use an Index Reference designator to select a model file contained in the draft file. This is similar to Property Text in a Callout, for example, `%{System.Material|R1}`. To refer to properties of the draft file itself, do not specify a designator, for example, `%{Custom.Last Revision Date}`. 


## CODE ORGANIZATION

Processing starts in Form1.vb.  A short description of the code's organization can be found there.

