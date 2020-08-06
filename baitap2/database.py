import mysql.connector
class database:
    def connectDb(self):
        return mysql.connector.connect(
            host="localhost",
            username="myname",
            password="12345",
            database="mydatabase"
        )
    #Tạo một bảng trong csdl
    def create_table(self, cursor):
        sql = "CREATE TABLE student (id INT AUTO_INCREMENT PRIMARY KEY, name VARCHAR(25), age INT, gioitinh VARCHAR(8), classname INT)"
        cursor.execute(sql)

    #Show table đã tạo
    def show_table(self, cursor):
        sql = "SHOW TABLES"
        cursor.execute(sql)
        for x in cursor:
            print(x)


    #Xóa một bảng trong csdl
    def delete_table(self, cursor):
        sql = "DROP TABLE student"
        cursor.execute(sql)
    
    #Thêm một bản ghi trong một bảng (bảng student)
    def insert_a_record(self,conn, cursor, data):
        sql = "INSERT INTO student (name,age,gioitinh,classname) VALUES (%s,%s,%s,%s)"
        cursor.execute(sql,data)
        conn.commit()
        print(cursor.rowcount,"record inserted")

    #Sửa một bản ghi trong một bảng (bảng student)
    def update_a_record(self,conn, cursor,data):
        sql="UPDATE student SET name=%s, age=%s, gioitinh=%s, classname=%s WHERE id = %s"
        cursor.execute(sql,data)
        conn.commit()
        print(cursor.rowcount,"record affected")

    #Xóa một bản ghi trong một bảng (bảng student)
    def delete_a_record(self, conn, cursor,id):
        sql="DELETE FROM student WHERE id=%s"
        cursor.execute(sql,id)
        conn.commit()
        print(cursor.rowcount, "record deleted")
    
    #Lấy ra một bản ghi trong một bảng (bảng student)
    def select_a_record(self,conn,cursor,id):
        sql= "SELECT * FROM student WHERE  id = %s"
        cursor.execute(sql,id)
        result = cursor.fetchone()
        print(result)

    #Hàm lấy ra tất cả thông tin bảng student
    def select_all_data(self,cursor):
        sql = "SELECT * FROM student"
        cursor.execute(sql)
        result = cursor.fetchall()
        for x in result:
            print(x)
class person:
    def __init__(self,ten,tuoi,gioitinh):
        self.ten=str(ten)
        self.tuoi=int(tuoi)
        self.gioitinh=str(gioitinh)
    def set_infor(self):
        print("Xin chào ",self.ten, " bạn ",self.tuoi," tuổi")
class student(person):
    def __init__(self,ten,tuoi,gioitinh,lophoc):
        super().__init__(ten,tuoi,gioitinh)
        self.id = id
        self.lophoc=lophoc
    def get_lophoc(self,lophoc):
        return self.lophoc
    def get_all_infor(self):
        return print("Sinh viên: ",self.ten," tuoi ",self.tuoi," gioi tinh ",self.gioitinh," học lớp ",self.lophoc)
