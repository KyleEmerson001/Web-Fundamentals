class BankAccount:

    def __init__(self, name, rate, balance = 0):
        self.name = name 
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
        print(f"User: {self.name}, Balance: {self.balance}")
        return self
    def yield_interest(self):
        amount = self.balance*self.intrestRate
        self.balance += amount
        print(f"your intrest was {amount}")
        return self
    def print_info(self):
        print(f"name: {self.name}")
        print(f"balance: {self.account_balance}")
        return self
ba1 = BankAccount("Bank account 1", 1.1, 100)
ba2 = BankAccount("Bank account 2",1.1, 200)
ba1.display_account_info().deposit(50).deposit(50).deposit(50).withdraw(50).yield_interest().display_account_info()
ba2.display_account_info().deposit(50).deposit(50).withdraw(50).withdraw(50).withdraw(50).withdraw(50).yield_interest().display_account_info()

