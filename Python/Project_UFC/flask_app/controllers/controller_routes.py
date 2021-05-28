from flask_app import app
from flask import render_template, redirect, request, session
from flask_app.models.model_user import User
from flask_app.models.model_fighter import fighter
from flask_app.models.model_base_fighter import base_fighter
from flask_app.config.mysqlconnection import connectToMySQL

@app.route('/')
def index():
    if 'uuid' in session:
        return redirect('/dashboard')
    return render_template("login.html")

@app.route('/dashboard')
def dashboard():
    if 'uuid' not in session:
        return redirect('/')

    
    context = {
        "logged_in_user": User.get_one(session['uuid']),
        "all_fighter": fighter.get_all()
    }
    return render_template('dashboard.html', **context)
@app.route('/fighter/view')

def view():
    if 'uuid' not in session:
        return redirect('/')

    
    context = {
        "logged_in_user": User.get_one(session['uuid']),
        "all_fighter": fighter.get_all()
    }
    return render_template('view_my_fighters.html', **context)

@app.route('/fighter/view_base')

def view_base():
    if 'uuid' not in session:
        return redirect('/')

    
    context = {
        "logged_in_user": User.get_one(session['uuid']),
        "all_fighter": base_fighter.get_all()
    }
    return render_template('buy_new_fighters.html', **context)