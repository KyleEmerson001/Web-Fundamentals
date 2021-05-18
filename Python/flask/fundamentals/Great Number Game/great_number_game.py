from flask import Flask, render_template, request, redirect, session, Markup
import random
app = Flask(__name__)
app.secret_key = "NotGonnaGetIt"

@app.route("/")
def num_game():
    guess_number = random.randrange(0,101)
    if "guess" not in session:
        session["guess"] = guess_number
    return render_template("index.html")

@app.route("/check", methods=["POST"] )
def check_input_value():
    input_value = int(request.form["input_guess"])
    random_guess = session["guess"]
    box_color = ""
    box_text = ""

    if input_value == random_guess:
        input_value = input_value
        box_color = "green"
        box_text = " was the number!"
        session.clear()
        return render_template("index.html",box_color=box_color, box_text=box_text, input_value=input_value)
    
    if input_value > random_guess:
        box_color = "red"
        box_text = " Too high!"
        return render_template("index.html",box_color=box_color, box_text=box_text)

    if input_value < random_guess:
        box_color = "red"
        box_text = " Too low!"
        return render_template("index.html",box_color=box_color, box_text=box_text)

    
if __name__=="__main__":
    app.run(debug=True) 