    {
        Bank Bank1  = new Bank();
    Bank1.BankOtk(427859092, "Мельников Данил Олегович", 55700);
    Bank1.Out();
    Bank1.Dob(23423);
    Bank1.umen(34556);
    Bank1.obnul(234423);
    Bank1.Perevod(Bank1);
}


Bank user1 = new Bank ("qwasassassasasasa", 123456789, 0);
Bank user2 = new Bank ("sassasasasasa", 987654321, 100);
Bank user3 = new Bank ("saasasasasasas", 123123123, 100);

user3.Out();
user3.Syst(user1);
user1.Out();
//user1.Out();
//user2.Out();
//user1.Dob();
//user1.Umen();
//user1.Transfer(user2);
//user1.Obnul();
//user2.Obnul();
//user1.Zachem();