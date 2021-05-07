class User():
    def __init__(self, name):
        self.name = name
        self.account_balance = 0

    def display_user_balance(self):
        print(f"User: {self.name}, Balance: {self.account_balance}")
        return self
        
    def make_deposit(self, amount):
        self.account_balance += amount
        self.display_user_balance()
        return self

    def make_withdrawal(self, amount):
        self.account_balance -= amount
        self.display_user_balance()
        return self

    def print_info(self):
        print(f"name: {self.name}")
        print(f"balance: {self.account_balance}")
        return self


Naruto = User("Naruto Uzumaki")
Luffy = User("Luffy Monkey")
Ichigo = User("Ichigo Kurosaki")

class BankAccount:
    # don't forget to add some default values for these parameters!
    def __init__(self, int_rate, balance): 
        self.int_rate = int_rate
        self.balance = balance
    def deposit(self, amount):
        self.account_balance += amount
        self.display_user_balance()
        return self
    def withdraw(self, amount):
        self.account_balance -= amount
        self.display_user_balance()
        return self
    def display_account_info(self):
        print(f"User: {self.name}, Balance: {self.account_balance}")
        return self
    def yield_interest(self):
        self.account_balance *= int_rate
        self.display_user_balance()
        return self


