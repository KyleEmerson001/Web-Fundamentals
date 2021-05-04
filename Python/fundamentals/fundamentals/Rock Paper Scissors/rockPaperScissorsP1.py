#user_input Rock Paper Scissors
#possible choice: ["Rock", "Paper", "Scissors"]
#Random generator
#compare computer choice to user choice
import random
possible_choice = ["Rock", "Paper", "Scissors"]
user_action = input("Enter a choice (Rock, Paper, Scissors): ")
computer_choice = random.choice(possible_choice)
print(f"you chose {user_action} computer chose {computer_choice}.")
if user_action == computer_choice:
    print(f"Both of you chose {user_action} it's a tie.")
elif user_action == "Rock":
    if computer_choice == "Paper":
        print("Paper covers Rock, you Lose")
    else:
        print("Rock Smashes Scissors, you Win")
elif user_action == "Paper":
    if computer_choice == "Scissors":
        print("Scissors cuts Paper, you Lose")
    else:
        print("Paper covers Rock, you Win")
elif user_action == "Scissors":
    if computer_choice == "Rock":
        print("Rock Smashes Scissors, you Lose")
    else:
        print("Scissors cuts Paper, you Win")
