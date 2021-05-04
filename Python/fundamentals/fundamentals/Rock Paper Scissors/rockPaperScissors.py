#user_input Rock Paper Scissors
#possible choice: ["Rock", "Paper", "Scissors"]
#Random generator
#compare computer choice to user choice
#repeat until 3 user or computer wins
import random

possible_choice = ["Rock", "Paper", "Scissors"]

win = 0
lose = 0
rounds = 0
while win < 3 and lose < 3 and rounds < 5:
    user_action = input("Enter a choice (Rock, Paper, Scissors): ")
    computer_choice = random.choice(possible_choice)

    print(f"you chose {user_action} computer chose {computer_choice}.")
    if user_action == computer_choice:
        print(f"Both of you chose{user_action} it's a tie.")
    elif user_action == "Rock":
        if computer_choice == "Paper":
            lose += 1
            rounds += 1
            print("Paper covers Rock, you Lose")
        else:
            win += 1
            rounds += 1
            print("Rock Smashes Scissors, you Win")
    elif user_action == "Paper":
        if computer_choice == "Scissors":
            lose += 1
            rounds += 1
            print("Scissors cuts Paper, you Lose")
        else:
            win += 1
            rounds += 1
            print("Paper covers Rock, you Win")
    elif user_action == "Scissors":
        if computer_choice == "Rock":
            lose += 1
            rounds += 1
            print("Rock Smashes Scissors, you Lose")
        else:
            win += 1
            rounds += 1
            print("Scissors cuts Paper, you Win")
        print(f"{win} {lose}{rounds}")   
