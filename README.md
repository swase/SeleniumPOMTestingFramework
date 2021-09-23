# SeleniumPOMTestingFramework

## Project Overview

The project included in this repository involved testing of the following website: https://saucedemo.com/. The project was worked on over a week where the objective was to  further develop knowledge of Selenium(https://docs.specflow.org/en/latest/), Specflow (https://docs.specflow.org/en/latest/)  and NUnit(https://docs.nunit.org/) and simulate a real world example of setting up a testing framework. A number of packages were used and are listed at the end of this document. 

## What Was Tested?

Testing was implemented  using a BDD (Behaviour Driven Development) approach, where SpecFlow was used to facilitate this. Specflow allows for the creation of tests that are linked to user stories using Gherkin syntax (Given...When...Then). Selenium was then used to provide the Webdriver  that allows the capture of the web elements on a given page.  NUnit was used for the execution of the tests. For this specific project the aforementioned website was tested on Google Chrome browser.

 For the testing of the website the POM (Page Object Model) design pattern was used when creating the framework. Each page was represented as class that acted as an interface between the application or site under test. And the web elements on the page were represented by class variables. The approach was taken as it allows for reusability, maintainability and readability. 


## User Journeys

As the the website being tested is a mock ecommerce site, the most common user profile would be one where the user is able to purchase an item. Below is an example of such a user journey followed by the Gherkin syntax as it was written for Specflow feature. 

### User Journey: 

```
As a registered user of the sauce demo site I want to be able to purchase a a cool looking backpack so that I am able to impress all the ladies at work and finally get a girlfriend and stop disapointing my parents. 
```

### Gherkin Syntax:

```
Scenario: User buys a backpack 
Given I have the following credentials
| Email			| Password	| 
| standard_user		| secret_sauce	|
And I have the following delivery information
| FirstName	| LastName	| PostalCode	|
| Mr		|   Bean	| OX20 BDD	|
And I am on the signin page
When I enter these credentials
And I click the sign in button
And I click the add to cart button for the backpack
And I click the shopping cart image
And I click the checkout button
And I enter this delivery information
And I click the continue button
And I click the finish button
Then the page with title "checkout: complete!" is loaded
```

## Class Diagram

Below is the Class diagram for the POM's

https://github.com/swase/SeleniumPOMTestingFramework/issues/1#issue-1005853674

## LivingDoc's


The project repository contains the LivingDocs file for further detail.

## Project Retrospective

As stated before the objectives for this project were to further my understanding of setting up testing frameworks, with this the use of Selenium, Specflow and NUnit was implemented and the approach of BDD was used. This objective was fullfilled and a good understanding of the use of the tools were gained. 

If I had to undertake a similar task of setting up a testing framework, I would make use of this knowledge and would be able to better plan ahead. Designing my classes and framework in an extensible and reliable, repeatable manner. As the objective was complete it can be said that the project was a success. 
