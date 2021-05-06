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


Naruto = User("Naruto Uzumaki")
Luffy = User("Luffy Monkey")
Ichigo = User("Ichigo Kurosaki")

Naruto.print_info().make_deposit(50).make_deposit(50).make_deposit(50).make_withdrawal(50).display_user_balance()
Luffy.print_info().make_deposit(50).make_deposit(50).make_withdrawal(1000).make_withdrawal(50).display_user_balance()
Ichigo.print_info().make_deposit(100).make_withdrawal(10).make_withdrawal(10).make_withdrawal(50).display_user_balance()


