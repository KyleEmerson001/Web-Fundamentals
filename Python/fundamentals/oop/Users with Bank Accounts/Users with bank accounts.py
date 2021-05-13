
class BankAccount():

    def __init__(self, AccountNumber, rate, balance = 0):
        self.AccountNumber = AccountNumber
        self.intrestRate = rate
        self.balance = balance
    def deposit(self, amount):
        self.balance += amount
        self.display_account_info()
        return self
    def withdraw(self, amount):
        self.balance -= amount
        self.display_account_info()
        return self
    def display_account_info(self):
        print(f"Account: {self.AccountNumber}, Balance: {self.balance}")
        return self
    def yield_interest(self):
        amount = self.balance*self.intrestRate
        self.balance += amount
        print(f"your intrest was {amount}")
        return self
    def print_info(self):
        print(f"name: {selfccountNumber}")
        print(f"balance: {self.account_balance}")
        return self

class User():
    def __init__(self, name, AccountNumber, rate, balance):
        self.name = name
        BankAccount.__init__(self, AccountNumber, rate, balance)

    def display_user_balance(self):
        print(f"User: {self.name}, Balance: {BankAccount.balance}")
        return self
        
    def make_deposit(self, amount):
        self.balance += amount
        return self

    def make_withdrawal(self, amount):
        self.balance -= amount
        return self

    def print_info(self):
        print(f"name: {self.name}")
        print(f"balance: {self.balance}")




ba1 = BankAccount("Bank account 1", 1.1, 100)
ba2 = BankAccount("Bank account 2",1.1, 200)

Naruto = User("Naruto Uzumaki", "Bank Account 1", 1.1, 100)
Luffy = User("Luffy Monkey", "Bank Account 2", 1.2, 200)
Ichigo = User("Ichigo Kurosaki","Bank Account 3", 1.3, 300)

Naruto.make_deposit(100).make_deposit(100).make_deposit(100).yield_interest().print_info().yield_interest()