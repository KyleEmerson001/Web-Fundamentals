class User():
    def __init__(self, name, balance):
        self.name = name
        self.account_balance = 0

    def display_user_balance(self):
        print(f"User: {self.name}, Balance: {self.account_balance}")
        return self
        
    def make_deposit(self, amount):
        self.account_balance += amount
        return self

    def make_withdrawal(self, amount):
        self.account_balance -= amount
        return self

    def print_info(self):
        print(f"name: {self.name}")
        print(f"balance: {self.account_balance}")


Naruto = User("Naruto Uzumaki", "0")
Luffy = User("Luffy Monkey", "0")
Ichigo = User("Ichigo Kurosaki", "0")

Naruto.print_info()
Naruto.make_deposit(50)
Naruto.make_deposit(50)
Naruto.make_deposit(50)
Naruto.make_withdrawal(50)
Naruto.display_user_balance()
Luffy.print_info()
Luffy.make_deposit(50)
Luffy.make_deposit(50)
Luffy.make_withdrawal(1000)
Luffy.make_withdrawal(50)
Luffy.display_user_balance()
Ichigo.print_info()
Ichigo.make_deposit(100)
Ichigo.make_withdrawal(10)
Ichigo.make_withdrawal(10)
Ichigo.make_withdrawal(50)
Ichigo.display_user_balance()


