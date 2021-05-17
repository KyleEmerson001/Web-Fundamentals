  
from flask import Flask, render_template
app = Flask(__name__)
@app.route("/")
def initial_render():
    return render_template('index.html')


@app.route("/<number>")
def block_repeat(number):
    repeat = int(number)
    return render_template('index.html', repeat = repeat)

@app.route("/<number>/<color_change>")
def box_color(number_of_boxes, color_change):
    repeat = (int(number_of_boxes))
    colorChange = color_change
    return render_template('index.html', repeat = repeat, colorChange = colorChange )


if __name__ == "__main__":
    app.run(debug = True)