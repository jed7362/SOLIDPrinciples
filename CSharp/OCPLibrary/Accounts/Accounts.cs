﻿namespace OCPLibrary;

public class Accounts : IAccounts
{
    public EmployeeModel Create(IApplicantModel person)
    {
        EmployeeModel output = new();

        output.FirstName = person.FirstName;
        output.LastName = person.LastName;
        output.EmailAddress = $"{person.FirstName.Substring(0, 1)}.{person.LastName}@cb.com";

        return output;
    }
}