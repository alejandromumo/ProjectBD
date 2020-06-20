# ProjectBD
This project refers to the course Databases from the Universidade de Aveiro in 2017/2018. It was implemented in the scope of the laboratory classes.
In this project, a database containing football entities (i.e. players, clubs, leagues, etc) is desgined and implemented. 

## DB design
The database's design starts by analysing a set of requirements simulating a real world's process that begins with stakeholders. 
The design takes in to consideration a set of practices to reduce redundancy such as normalization.


## DB implementation
The implementation's provides features such as:

* Access control mechanisms, namely stored procedures.
* Defensive programming in the stored procedures to ensure database's robustness.
* Transactions that guarantee the database's integrity.
* Authentication.
* Indexes to improve efficiency and provide faster response to common queries.

The database was implemented using SQL and it was hosted in a Univeristy's cluster running SQL Server. 

## DB's .NET interface

In order to connect to the database and access it, a .NET interface was implemented. Its main function is to expose the database's public stored procedures to the visual application that the user is running.

## Visualization
The visual application developed for this project is not in the scope of this repository. Nonetheless, it was built using a Model-view-viewmodel pattern in C#. Refer to the project https://github.com/rodrigogonegit/ihcprojectUI 
