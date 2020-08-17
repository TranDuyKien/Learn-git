import mysql.connector
class database:
    def connectdb(self):
        return mysql.connector.connect(
            host="localhost",
            username="myname",
            password="12345",
            database = "mydatabase"
        )