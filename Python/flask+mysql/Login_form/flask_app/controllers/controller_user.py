from flask_app import app
from flask import render_template, redirect, request, session
from flask_app.models.model_user import User
from flask import flash

@app.route('/user/create', methods=['POST'])
def create_user():
    is_valid = User.validate_user(request.form)
    if is_valid:
        list_of_users = User.get_one_email(request.form['email'])
        if len(list_of_users) > 0:
            flash('email already exists')
            return redirect('/')
        info = {
            "first_name": request.form['first_name'],
            "last_name": request.form['last_name'],
            "email": request.form['email'],
            "pw": request.form['pw'],
        }
        new_user = User.new(info)
        print(new_user)
        session['uuid'] = new_user[0]['id']
        return redirect('/dashboard')
    return redirect('/')

@app.route('/user/exit')
def logout():
    session.clear()
    return redirect('/')

@app.route('/user/login', methods=['POST'])
def login_user():
    list_of_users = User.get_one_email(request.form['email'])
    if len(list_of_users) == 0:
        print("email not found")
        flash("invalid credentials")
        return redirect('/')
    else:
        print('email found')
        user = list_of_users[0]
        if request.form['pw'] == user['pw']:
            session['uuid'] = user['id']
            return redirect('/dashboard')