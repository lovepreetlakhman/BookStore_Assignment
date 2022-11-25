# Topan das

2022/11/11
01:21pm - created github repo, cloned it and crated a new MVC project, added read me and now writing it, Heading to the first commit
01:26pm - Commented Sign in required flag in startup file
01:29pm - Checked debugging feature by adding some breakpoints in controller.
01:30pm - Giving ssl error on running project.
01:31pm - Commented ssl port line in json settings, try to runn it now.
01:32pm - opening perfectly in the browser now with different port.
01:34pm - looking for a bootswatch theme, i'll head back here after choosing one.
01:35pm - selected the lux theme and replaced its bootstrap file.
01:38pm - replaced site.css with the one that was given on blackboard.
01:43pm - Changed bootstrap file name in head tag, editied some nav bootstrap classes to reflect the theme.

2022/11/14
02:11pm - run the application , working all good 
01:15pm - added the css and javascript code in _Layout.cshtml  
02:21pm - added the dropdown menu ran the application , everything is working 
02:25pm - created 3 new project names Topansbooks.DataAcess,TopansBooks.Models and TopansBooks.Utility
02:32pm - moved the data folder into dataccess folder , deleted the migration folder , added the new pakages in the dataAccess folder
02:36pm - deleted the class1.cs files 
02:41pm - ran the application got so many reference error , 
solved it by renaming the namespace and adding the reference for it 
02:46pm - added the models in the .Models folder , changed the name of errorviewmodel to view model , added refernce and changed the namespace of .ViewModels 
02:53pm - updated the Error.cshtml 
03:06pm - added an SD.cs  class in the .Utility and added customers area in the Areas folder and changed the layout path for area 
03:20pm - added a new admin area in areas and  deleted the data and model folder 

2022/11/15
07:31pm - open the visual studio code in the visual studio community 2019 version.
to run the application first build it and make sure there are no errors...
open the .appsettings.json file and edit the line 3 for the creating the migrations.
open nuGet Package console to add default migration.
- added the new migration file in the .DataAccesss project named : "20221116003614_AddDefaultIdentityMigration.cs"
another migration file name: "20221116025454_AddCategoryToDb.cs" was created !!!
update the migration file for updating the database !
once the migration is created it was time to update it using the same package console.
- check the database table by visiting the SQL server object explorer commit all to github...
07:55pm 2.1 create Db completed commit to Github repo...
08:15pm - add the Repository folder to the .DataAccess project and 
- created the IRepository.cs class file and modify it...
create ISP_Call.cs interface file in the IRepository folder
modify the code by creating the Dapper version..
now for the category repository folder
- Create the SP_Call.cs in the Repository folder and then edit the given code...
- make one IUnitOfWork in the Ireposiroty folder for the implementation of the Categoryt class
edit eh code and add some using statement in the following class.
after all this modification comit the code to git hub repos...
- save the content given and move forward after commiting the code 
09:08pm - open the startup.cs file of the main project and edit the code from the provided pptx.
 edit the line number 40 in the Startup.cs class file.
09:24pm - create the controller in the Area > Admin > Controller folder name: CategoryController.cs
- modify the code using the provided code in the pptx...
add the using statements as needed in the code
- add new category folder in the Area > admin > View > Category.
- created the Index razor page view and edited the code provided in the black-board
- save and run the application...
 Application run sucessfully,
  add the Category button in the drop-down menu and save the code...
  Add two buttons in the Index file from fontawsome file...
  save the code
  - add the category.js code in the wwwroot > js > category.js
  - edit the code from the provided form in the blackboard
  - add migtration again to create the database and update it again...
  - build the application again and run the application to see the required output...
  moving forward to the create category page...
  - To enable the edit and delete button in the web application 
  add the AI dependency in the CategoryController.cs page and create the partial razorrview.cshtml pages
  in View > Shared > _CreateAbdBackToListButton.cshtml and _EditAndBackToListButton.cshtml
  after createing both the pages add the code provided in the pptx.
  - add the modifier in the upsert.cs class file in the top section...
10:03pm - add the upsert model statement in the inex.cshtml file...
finally to add the delete functionallity,
you need to edit three pages one CategoryControllers.cs to add the delete API for the page 
- Edit the Category,js file for twice by editing the button and add the modifies code in the following applicationa 
- commit the whole code after making this changes and save the code for next part...
10:08pm - rebuild the application and run the project
- End of 2nd part...

24/11/2022
9:00 Created Model class for coverType
9:11 inerface for CoverType repository
9:18 coverType Class implementing CoverTypeRepository
9:22 Dbset of Cover Type added
9:27 Connected CoverType Inside UnitOfWork class and interface
9:33 migration for new CoverType model
9:37 Added new save method
9:45 Controller for CoverTypes
9:57 save method implemented
10:10 index view for coverType
10:17 Upsert View for CoverType
10:21 javascript file for coverType
10:25 linked cover type in navbar
10:29 Created products class for models
10:35 added dbset for products
10:40 Added migration for new products table
10:48 Added migration for products validation
10:52 created ProductRepository interface and its class implementing it
10:59 inked Product inside of both UnitOfWork files
11:05 controller for products
11:12 view model for products
11:15 installed View featues
11:20 Completed the controller for producs
11:25 linked Products index view to navbar
end of assignment 2 third part 
