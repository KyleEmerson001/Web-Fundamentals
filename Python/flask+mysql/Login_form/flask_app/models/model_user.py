from flask_app.config.mysqlconnection import connectToMySQL

db = 'db_name'

class User:
    def __init__(self, data):
        self.id = data['id']

# C
    @classmethod
    def new(cls, info):
        pass
# R
    @classmethod
    def get_all(cls):
        pass

    @classmethod
    def get_one(cls, id):
        query = 'SELECT * FROM table_name Where id = %(users_id)s;'
        data = {
        "users_id": id
        }
        one_user = connectToMySQL(db).query_db(query, data)[0]
        return one_user
# U
    @classmethod
    def update_one():
        pass
# D
    @classmethod
    def delete_one():
        pass