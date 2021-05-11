from flask import Flask
app = Flask(__name__)
@app.route("/")
def hello():
    return "Hello World!"
@app.route('/dojo')
def dojo():
    return "Dojo!"
@app.route("/say <sting:name>")
def hi():
    return "Hi + name"
@app.route('/hello')
def success():
    for i in range(0,35)
        print(i)
    return "hello"
@app.route('/bye')
def success():
    for i in range(0,80)
        print(i)
    return "bye"  
@app.route('/dogs')
def success():
    for i in range(0,99)
        print(i)
    return "dogs"  


if __name__ =="__main__":
    app.run(debug=True)