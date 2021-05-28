from flask_app.config.mysqlconnection import connectToMySQL
from flask import flash, session

db = 'ufc'

class base_fighter:
    def __init__(self, data):
        self.id = data['id']
        self.first_name = data['first_name']
        self.last_name = data['last_name']
        self.strength = data['strength']
        self.accuracy = data['accuracy']
        self.age = data['age']
        self.td_offense = data['td_offense']
        self.td_defense = data['td_defense']
        self.price = data['price']
        self.created_at = data['created_at']
        self.updated_at = data['updated_at']

# C
    @classmethod
    def get_all(cls):
        query = 'SELECT * FROM base_ufc_fighters'

        base_ufc_fighters = connectToMySQL(db).query_db(query)

        all_base_ufc_fighters = []
        for fighter in base_ufc_fighters:
            all_base_ufc_fighters.append(cls(fighter))

        return all_base_ufc_fighters

    @classmethod
    def get_one(cls, id):
        query = 'SELECT * FROM base_ufc_fighters WHERE id = %(id)s'
        data = {
            "id": id
        }
        return connectToMySQL(db).query_db(query, data)[0]
# U
    @classmethod
    def update_one(cls, info):
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
        base_fighter_id = connectToMySQL(db).query_db(query, data)
        return base_fighter_id

