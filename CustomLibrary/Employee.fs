namespace CustomLibrary

open System

type Employee =

    val age : int
    val mutable department : string

    new (age) = Employee(age, "Default Department")

    new (age, department) as emp = 
        {
            age = age;
            department = department
        }
        then
            emp.department <- "my other one"