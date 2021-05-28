from flask_app import app
from flask_app.controllers import controller_routes, controller_user, controller_fighter, controller_base_fighter

if __name__=="__main__":
    app.run(debug=True)