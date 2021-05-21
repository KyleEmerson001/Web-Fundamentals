from flask_app.config.mysqlconnections import connectToMySQL

db = 'db_name'

class User:
    def __init__(self, data):
        self.id = data['id']

# C
    @classmethod
    def create_new_users(cls, info):
        query = 'INSERT INTO users (first_name, last_name, email) VALUES (%(first_name)s,%(last_name)s,%(email)s);'
        data = {
            "first_name": info['first_name'],
            "last_name": info['last_name'],
            "email": info['email']
        }
        newUser = connectToMySQL(db).query_db(query, data)

        query = "SELECT * FROM users WHERE id = %(new_users_id)s"
        data = {
            "new_users_id": new_users_id
        }
        new_users = connectToMySQL(db).query_db(query, data)
        return new_users
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
    def delete_user(id):
        mysql = connectToMySQL('friendships')
        query = "DELETE FROM users WHERE id = %(id)s"
        data = {
            "id": id
        }
        mysql.query_db(query, data)
        return redirect('/')