from flask import Flask
app = Flask(__name__)
@app.route("/")
def success():
    return "Hello World!"
@app.route('/dojo')
def success():
    return "Dojo!"
@app.route("/<sting:name>")
def success():
    return "Hi + name"
@app.route('/int')
def success():
    return "Hi Flask!"


if __name__ =="__main__":
    app.run(debug=True)