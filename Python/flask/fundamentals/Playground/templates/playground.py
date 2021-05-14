  
from flask import Flask, render_template
app = Flask(__name__)
@app.route("/")
def initial_render():
    return "Home page"

@app.route("/play")
def block_render():
    return render_template("index.html")

@app.route("/play/<number_of_boxes>")
def block_repeat(number_of_boxes):
    repeat = int(number_of_boxes)
    return render_template('index1.html', repeat=repeat)

@app.route("/play/<number_of_boxes>/<color_change>")
def box_color(number_of_boxes,color_change):
    repeat = (int(number_of_boxes))
    colorChange = color_change
    return render_template('index2.html', repeat = repeat, colorChange = colorChange )


if __name__ == "__main__":
    app.run(debug = True)