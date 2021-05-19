from flask import Flask, render_template, redirect, request, session
from connections import connectToMySQL    # import the function that will return an instance of a connection
app = Flask(__name__)
app.secret_ket = 'whowhowhowhowho'
@app.route('/')
def index():
    mysql = connectToMySQL("first_flask")
    friends = mysql.query_db("SELECT * FROM friends;")
    print(friends)
    return render_template("index.html", all_friends = friends)
@app.route("/create_friend", methods=["POST"])
def add_friend_to_db():
    mysql = connectToMySQL('friendships')
    query = 'INSERT INTO users (first_name, last_name, occupation) VALUES (%(first_name)s,%(last_name)s,%(occupation)s);'
    data = {
        "first_name": request.form['first_name'],
        "last_name": request.form['last_name'],
        "occupation": request.form['occupation']
    }
    newUser = mysql.query_db(query, data)
    return redirect("/")

if __name__ == "__main__":
    app.run(debug=True)