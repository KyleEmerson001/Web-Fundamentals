from flask import Flask, render_template, redirect, request, session
from connections import connectToMySQL    # import the function that will return an instance of a connection
app = Flask(__name__)
app.secret_ket = 'whowhowhowhowho'

@app.route("/")
def index():
    mysql = connectToMySQL('friendships')	        # call the function, passing in the name of our db
    users = mysql.query_db('SELECT * FROM users;')  # call the query_db function, pass in the query as a string
    print(users)
    return render_template("Read.html", users=users)

@app.route("/users")
def created():
    mysql = connectToMySQL('friendships')	        # call the function, passing in the name of our db
    users = mysql.query_db('SELECT * FROM users;')  # call the query_db function, pass in the query as a string
    print(users)
    return render_template("Create.html", users=users)

@app.route("/users/create", methods=['POST'])
def create_new_users():
    mysql = connectToMySQL('friendships')
    query = 'INSERT INTO users (first_name, last_name, email) VALUES (%(first_name)s,%(last_name)s,%(email)s);'
    data = {
        "first_name": request.form['first_name'],
        "last_name": request.form['last_name'],
        "email": request.form['email']
    }
    newUser = mysql.query_db(query, data)
    return redirect("/")

@app.route("/user/<int:id>/delete")
def delete_user(id):
    mysql = connectToMySQL('friendships')
    query = "DELETE FROM users WHERE id = %(id)s"
    data = {
        "id": id
    }
    mysql.query_db(query, data)
    return redirect('/')

if __name__ == "__main__":
    app.run(debug=True)