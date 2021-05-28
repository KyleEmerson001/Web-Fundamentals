from flask_app.config.mysqlconnection import connectToMySQL
from flask import flash, session

db = 'ufc'

class fighter:
    def __init__(self, data):
        self.id = data['id']
        self.first_name = data['first_name']
        self.last_name = data['last_name']
        self.strength = data['strength']
        self.accuracy = data['accuracy']
        self.age = data['age']
        self.td_offense = data['td_offense']
        self.td_defense = data['td_defense']
        self.Users_id = data['Users_id']
        self.created_at = data['created_at']
        self.updated_at = data['updated_at']

    def display_title(self):
        display_name = f"{self.first_name} - {self.last_name}"
        return display_name

# C
    @classmethod
    def create_one(cls, info):
        query = 'insert into ufc.my_ufc_fighters (first_name, last_name, strength, accuracy, age, td_defense, td_offense, Base_UFC_Fighters_id, Users_id) values (%(first_name)s, %(last_name)s, %(strength)s, %(accuracy)s, %(age)s, %(td_defense)s, %(td_offense)s, %(Base_UFC_Fighters_id)s, %(Users_id)s)'
        data = {
            "first_name": info['first_name'],
            "last_name": info['last_name'],
            "strength": info['strength'],
            "accuracy": info['accuracy'],
            "age": info['age'],
            "td_offense": info['td_offense'],
            "td_defense": info['td_defense'],
            "Base_UFC_Fighters_id": info['Base_UFC_Fighters_id'],
            "Users_id": session['uuid']
        }
        return connectToMySQL(db).query_db(query, data)
    @classmethod
    def get_all(cls):
        query = 'SELECT * FROM my_ufc_fighters'

        my_ufc_fighters = connectToMySQL(db).query_db(query)

        all_my_ufc_fighters = []
        for fighter in my_ufc_fighters:
            all_my_ufc_fighters.append(cls(fighter))

        return all_my_ufc_fighters

    @classmethod
    def get_one(cls, id):
        query = 'SELECT * FROM my_ufc_fighters WHERE id = %(id)s'
        data = {
            "id": id
        }
        return connectToMySQL(db).query_db(query, data)[0]
# U
    @classmethod
    def update_one(cls, id, info):
        query = 'UPDATE my_ufc_fighters SET first_name=%(first_name)s, last_name=%(last_name)s, stength=%(stength)s, accuracy=%(accuracy)s, age=%(age)s, td_offense=%(td_offense)s, td_defense=%(td_defense)s, WHERE id = %(id)s'
        data = {
            "first_name": info['first_name'],
            "last_name": info['last_name'],
            "strength": info['strength'],
            "accuracy": info['accuracy'],
            "age": info['age'],
            "td_offense": info['td_offense'],
            "td_defense": info['td_defense'],
            "id": id
        }
        return connectToMySQL(db).query_db(query, data)

# D
    @classmethod
    def delete_one(cls, id):
        query = 'DELETE FROM my_ufc_fighters WHERE id = %(id)s'
        data = {
            "id": id
        }
        return connectToMySQL(db).query_db(query, data)

# fighter Validation
    @staticmethod
    def validate_my_ufc_fighters(form_info):
        is_valid = True
        
        if len(form_info['first_name']) == 0:
            is_valid = False
            flash("must have a first_name")
        if len(form_info['last_name']) == 0:
            is_valid = False
            flash("must have a last_name")
        age = int(form_info['age'])
        if len(form_info['age']) == 0 or type(age) != int:
            is_valid = False
            flash("must have a age")
        strength = int(form_info['strength'])
        if len(form_info['strength']) == 0 or type(strength) != int:
            is_valid = False
            flash("must have a strength")
        accuracy = int(form_info['accuracy'])
        if len(form_info['accuracy']) == 0 or type(accuracy) != int:
            is_valid = False
            flash("must have a accuracy")
        td_offense = int(form_info['td_offense'])
        if len(form_info['td_offense']) == 0 or type(td_offense) != int:
            is_valid = False
            flash("must have a td_offense")
        td_defense = int(form_info['td_defense'])
        if len(form_info['td_defense']) == 0 or type(td_defense) != int:
            is_valid = False
            flash("must have a td_defense")


        return is_valid