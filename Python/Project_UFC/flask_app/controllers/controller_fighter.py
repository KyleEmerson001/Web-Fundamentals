from flask_app import app
from flask import render_template, redirect, request, session
from flask_app.models.model_fighter import fighter

# This is a ACTION route
@app.route('/fighter/<int:base_fighter_id>/create',  methods=['POST'])
def create_fighter(id):
    # process TV info
    fighter.create_one(id, request.form)
    # return to dashboard   
    return redirect('/')

@app.route('/fighter/view')
def view_fighters():
    # get fighter
    context = {
        "all_fighter": fighter.get_all()
    }
    # render
    return render_template('view_my_fighters.html', **context)

@app.route('/fighter/<int:fighter_id>/view')
def view_fighter(fighter_id):
    # get TV
    fighter_one= fighter.get_one(fighter_id)
    image_url = f"images/{fighter_one['last_name']}.jpg"
    context = {
        "fighter": fighter_one,
        "image_url": image_url
    }
    # render
    return render_template('view_one_fighter.html', **context)

@app.route('/fighter/<int:fighter_id>/delete')
def delete_fighter(fighter_id):
    fighter.delete_one(fighter_id)
    return redirect('/')