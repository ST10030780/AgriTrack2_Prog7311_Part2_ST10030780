Introduction: 
As a prototype model of the finished application, this prototype is a component of the ArgiEnergy Connect Platform project. It models how farmers and workers will interact with a central system for managing agricultural products and user information. 

Setup Instructions: 
To set up the development environment: 
1.	Install Visual Studio with ASP.Net and web development workload. 
2.	Clone or download the source code files from the provided zip package. 
3.	Open the solution file in Visual Studio (AgriEnergyConnect.sln). 
4.	Restore NuGet packages if prompted. 
5.	Set the startup project and run the application locally using IIS Express. 
How to build and run the prototype: 
1.	Open solution in Visual Studio. 
2.	Press Ctrl + f5 to build and launch application. 
3.	Navigate through the login page to access user specific dashboard. 
4.	Use the pre populated sample database to test functionality. 
System functionalities: 
1.	Database development: 
•	A relational database is integrated to handle farmer profiles and their goods. 
•	To replicate actual situations, sample data is provided. 
2.	Functional features: 
For farmers: 
•	Include details like the products name, category and manufacture date when adding it. 
•	See their product listings. 
For employees: 
•	Include new farmer profiles with crucial details. 
•	Examine and classify items according to parameters such as product category and date range. 

User roles:
Farmers: 
•	May sign in safely. 
•	They may upload and manage their own goods. 
Employees: 
•	Has the ability to log in safely. 
•	Produce fresh farmer profiles. 
•	See and sort items from all farmers. 
Using role-based access control, users are only able to see data that is pertinent to their role. 
Data accuracy and validation: 
•	Input fields are subject to validation tests in order to maintain data integrity. 
•	To avoid system failures or corruption, error handling procedures are in place. 
Development and testing process: 
•	The prototype was created iteratively, with functionality tested at every step. 
•	The systems usability and navigation were assessed using user experience (UX) testing. 
•	Responsive design was employed to guarantee compatibility with desktops, tablets and smartphones. 
