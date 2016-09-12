# Question and Answer App

#### Ember JS skill demonstration project:  Week 4 - August, 2016

#### By Jim Klein

## Description

Question and Answer App is a sample application for demonstrating basic proficiency in Ember JS and related build tools used to create simple web apps.

A user can add, edit and view question items, which include the author's name, their question, and notes.   Additional functionality allows other users to add and edit answers to questions.

Ember functionality in the app:
Helper functionality:  Question detail component conditionally adds note about being the first to answer a question.
Computed Property: Answer-Detail component sorts answers by the number of votes each has.
Service:  Favorites functionality implemented using Ember service.


## App Installation

* Clone this repository: `git clone https://github.com/JimKlein325/EmberProject1.git` this repository
* Change into the new directory
* Install Node package manager: `npm install`
* Install Bower: `bower install`
* Install EmberFire: ember install emberfire
* Install ember-cli-windows: npm install ember-cli-windows -g
* Enter this command:  ember-cli-windows

## Running the application

* To run the ember server on a local machine, in terminal type: `ember serve`
* Visit this app at [http://localhost:4200](http://localhost:4200).

## Technologies Used
* Ember JS MVC:  Views implemented the following technologies:
Router: maps url to a route, Route handler: loads corresponding template and model; Templates:  Loads components, accesses model data provided by route handler, displays component content; Components: displays component content(components consist of two files: A template written in Handlebars, and a source file written in JavaScript);  Models: persistent data source;  
* Node.js
* Node Package Manager to manage build dependencies.
* Bower to manage front-end dependencies (optimized for frontend packages like Bootstrap and jQuery).
* HTML, JavaScript, CSS
* Bootstrap

### License
MIT License  Copyright (c) 2016 **Jim Klein**
