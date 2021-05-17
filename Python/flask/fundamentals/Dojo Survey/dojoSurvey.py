  
from flask import Flask, render_template, request, redirect
app = Flask(__name__)
@app.route('/')
def index():
    return render_template("index.html")

@app.route('/users', methods=['POST'])
def create_user():
    print("Got Post Info")
    print(request.form)
    name_from_form = request.form['name']
    Dojo_from_form = request.form['Dojo']
    Language_from_form = request.form['Language']
    Comment_from_form = request.form['Comment']
    return render_template("show.html", name_on_template=name_from_form, Dojo_on_template=Dojo_from_form, Language_on_template=Language_from_form, Comment_on_template=Comment_from_form)
@app.route('/result')
def result():
    return render_template("show.html")

if __name__ == "__main__":
    app.run(debug = True)