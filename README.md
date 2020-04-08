# ValueLabProject
Codes for Interview 

**Tools used**
1) MS visual Studio
2) C#
3) Specflow
4) Selenium webdriver
5) ExtentReport

**Framework design BDD, Page Object Model**

**Details**
BDD scenarios were writen using specflow. This targeted 5 candidates from the list of candidates. They were deemed to be among the most visited modules on a web page. They included:
- Sign in
- Contact Us
- Customer 70-% discount page
- Customer search
- Women module

The first four module (Sign in, Contact us, Customer 70% and Customer search) were grouped under one page called ControlBoard. 
Women Module was grouped under a page on its own as it has a good number of functionalities which can be developed into test scenarios. 

The BDD scenarios were developed into StepDefinitions for their respective classes using Specflow. 
Code was written using C# and selenium to execute the scenarios. These can be seen in Pages folder/classes, StepDefinition folder/classes, Hooks folder/content class.

**CommonSteps Class**
The commonSteps class was used to host methods which could be shared within all classes. This was to reduce repetion of code and to facilitate code maintenace if need be. These included function(s) to Launch a brouser and AUT url, and to close an Application under test after test has been executed. It also included a function to take screen shots if any test fails. There was also a method to generate a report after test completion, which can be shareed with all parties concerned. 

**Deliverables**
1) A HTML extentReport file has been emailed to everyone involved wich contains the test report. This can be open using any webbrowser of your choice
2) Source code and solution file for completed exercise has been sent via a GIT link for review


