from flask_app import app
from flask import Flask, render_template, redirect, request, session
from flask_app.models.model_user import User
from flask_app.config.mysqlconnection import connectToMySQL

@app.route('/')
def index():
    return render_template('index.html')