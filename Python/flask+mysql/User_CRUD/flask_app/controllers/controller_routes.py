from flask_app import app
from flask import render_template, redirect, request, session
from flask_app.models.model_user import User
from flask_app.config.mysqlconnections import connectToMySQL

@app.route("/")
def index():
    mysql = connectToMySQL('friendships')	        # call the function, passing in the name of our db
    users = mysql.query_db('SELECT * FROM users;')  # call the query_db function, pass in the query as a string
    print(users)
    return render_template("index.html", users=users)

@app.route("/users/create")
def created():
    mysql = connectToMySQL('friendships')	        # call the function, passing in the name of our db
    users = mysql.query_db('SELECT * FROM users;')  # call the query_db function, pass in the query as a string
    print(users)
    return render_template("create.html", users=users)

@app.route("/users/view")
def view():
    mysql = connectToMySQL('friendships')	        # call the function, passing in the name of our db
    users = mysql.query_db('SELECT * FROM users;')  # call the query_db function, pass in the query as a string
    print(users)
    return render_template("view.html", users=users)

@app.route("/edit")
def edit():
    mysql = connectToMySQL('friendships')	        # call the function, passing in the name of our db
    users = mysql.query_db('SELECT * FROM users;')  # call the query_db function, pass in the query as a string
    print(users)
    return render_template("edit.html", users=users)