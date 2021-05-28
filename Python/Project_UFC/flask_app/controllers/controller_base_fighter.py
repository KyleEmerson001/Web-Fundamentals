from flask_app import app
from flask import render_template, redirect, request, session
from flask_app.models.model_base_fighter import base_fighter


# This is a ACTION route
@app.route('/base_fighter/update',  methods=['POST'])
def create_my_fighter():
    print(request.form)
    fighter= base_fighter.get_one(request.form['Base_UFC_Fighters_id'])
    print(fighter)
    info = {
        "first_name": fighter["first_name"],
        "last_name": fighter["last_name"],
        "strength": fighter['strength'],
        "accuracy": fighter['accuracy'],
        "age": fighter['age'],
        "td_offense": fighter['td_offense'],
        "td_defense": fighter['td_defense'],
        "Base_UFC_Fighters_id": fighter['id'],
        "Users_id": session['uuid']
    }

    base_fighter.create_one(info)

    return redirect('/')



@app.route('/base_fighter/<int:base_fighter_id>/view')
def view_base_fighter(base_fighter_id):
    # get TV
    context = {
        "base_fighter": base_fighter.get_one(base_fighter_id)
    }
    # render
    return render_template('view_one_base_fighter.html', **context)

@app.route('/TV/<int:tv_shows_id>/delete')
def delete_TV(tv_shows_id):
    base_fighter.delete_one(tv_shows_id)
    return redirect('/')