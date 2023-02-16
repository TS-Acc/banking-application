using banking_application;

var s1 = new SavingsComp();
var s2 = new SavingsComp();

s1.AccountId = "Trevor";
s1.Description = "My savings Account";
s1.Balance = 1000;

s1.AccountId = "Not Trevor";
s1.Description = "Not Trevor's savings Account";
s1.Balance = 1000;

s1.Transfer(100, s2);


//Console.WriteLine($"S1 paid interest of {interest:C}");

Console.WriteLine($"The balance of S1 is {s1.Balance:C}"); 

 