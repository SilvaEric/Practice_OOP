using Aula01HerancaEPolimorfismo.entities;

Account acc = new Account(1001, "Alex", 0.0);
BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 5000.0);

// Upcasting

Account bacc2 = bacc;
Account bacc3 = new BusinessAccount(1003, "Eric", 0.0, 7000.0);
Account sacc1 = new SavingsAccount(1004, "Rafael", 0.0, 0.02);

// Downcasting

BusinessAccount acc2 = (BusinessAccount)bacc3;
acc2.Loan(100.0);


