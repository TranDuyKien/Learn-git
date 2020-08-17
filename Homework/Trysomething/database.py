import mysql.connector


class database:
    def connectdb(self):
        return mysql.connector.connect(
            host="localhost",
            username="myname",
            password="12345",
            database="mydatabase",)

    def create_table(self, cursor):
        sql = "CREATE TABLE infor_student (id INT AUTO_INCREMENT PRIMARY KEY, name VARCHAR(30), age INT, colorskin VARCHAR(10), address VARCHAR(50))"
        cursor.execute(sql)
        print("1 table created")

    def show_all_table(self, cursor):
        sql = "SHOW TABLES"
        cursor.execute(sql)
        result = cursor.fetchall()
        for x in result:
            print(x)

    def drop_table(self, cursor):
        sql = "DROP TABLE infor_student"
        cursor.execute(sql)
        print("1 table droped")

    def insert_a_record(self, conn, cursor, data):
        sql = "INSERT INTO infor_student (name, age, colorskin, address) VALUES (%s,%s,%s,%s)"
        cursor.execute(sql, data)
        conn.commit()
        print(cursor.rowcount, " record inserted")

    def update_a_record(self, conn, cursor, data):
        sql = "UPDATE infor_student SET name=%s, age=%s, colorskin=%s, address=%s WHERE id=%s"
        cursor.execute(sql,data)
        conn.commit()
        print(cursor.rowcount," record affected")
    
    def delete_a_record(self, conn, cursor, studentid):
        sql = "DELETE FROM infor_student WHERE id=%s"
        cursor.execute(sql,studentid)
        conn.commit()
        print(cursor.rowcount," record deleted")

    def select_infor_a_student(self,conn,cursor,studentid):
        sql = "SELECT * FROM infor_student WHERE id=%s"
        cursor.execute(sql,studentid)
        result = cursor.fetchone()
        print(result)

    def select_all_infor_student(self,conn,cursor):
        sql = "SELECT * FROM infor_student"
        cursor.execute(sql)
        result = cursor.fetchall()
        for x in result:
            print(x)

class student():
    def __init__(self, name, age, colorskin, address):
        self.name = str(name)
        self.age = int(age)
        self.colorskin = str(colorskin)
        self.address = str(address)

    def get_name(self, name):
        return self.name

    def get_age(self, age):
        return self.age

    def get_colorskin(self, colorskin):
        return self.colorskin

    def get_address(self, address):
        return self.address
