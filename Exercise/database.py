import mysql.connector
import constant

class person():

	def __init__(self, ten, tuoi):
		# self.gioitinh = gioitinh
		self.ten = ten
		self.tuoi = tuoi

	def getName(self):
		return self.ten

	def getClassName(self):
		return self.tuoi

	def get_Infor(self):
		print('Xin chào: ' + self.ten +' bạn '+self.tuoi +'tuổi')
class student(person):
    def __init__(self, ten, tuoi, lophoc):
        #Gọi tới constructor của lớp cha(nguoi)
        #gán giá trị thuộc tính gioitinh,ten,tuoi của lớp cha
        super().__init__(ten,tuoi)
        self.id=id
        self.lophoc=lophoc
    def set_lophoc(self,lophoc):
        return self.lophoc

    # def set_id(self):
    #     return self.id

    #ghi đè (override) phương thức cùng tên của lớp cha
    def get_Infor(self):
        print('Xin chào: ' + self.ten)


class database:
    def connectDb(self):
        return mysql.connector.connect(
            host="localhost",
            username="myname",
            password= "12345",
            database = "mydatabase"
        )

    def create_a_table(self,cursor):
        cursor.execute("CREATE TABLE thong_tin_hoc_sinh (id INT AUTO_INCREMENT PRIMARY KEY, name VARCHAR(255), age INT, class VARCHAR(255))")

    def deleteStudents(self,mydb, cursor, id):
        sql = "DELETE FROM thong_tin_hoc_sinh WHERE id = %s"
        cursor.execute(sql, id)
        mydb.commit()
        print(cursor.rowcount, "table deleted")

    def addNewStudents(self,mydb, cursor, data):
        sql = "INSERT INTO thong_tin_hoc_sinh (name, age, class) VALUES (%s, %s, %s)"
        cursor.execute(sql, data)
        mydb.commit()
        print(cursor.rowcount, "student inserted.")

    def updateStudents(self,mydb, cursor, data):
        sql = "UPDATE thong_tin_hoc_sinh SET name = %s , age = %s, class = %s WHERE id = %s"
        print(data)
        cursor.execute(sql, data)
        mydb.commit()
        print(cursor.rowcount, "student(s) affected.")

    def findStudents(self,mydb, cursor, id):
        sql = "SELECT * FROM thong_tin_hoc_sinh WHERE id = %s"
        cursor.execute(sql, id)
        results = cursor.fetchone()
        print(results)
    
    def selectallstudent(self,mydb, cursor):
        sql = "SELECT * FROM thong_tin_hoc_sinh"
        cursor.execute(sql)
        result = cursor.fetchall()
        for x in result:
            print(x)




