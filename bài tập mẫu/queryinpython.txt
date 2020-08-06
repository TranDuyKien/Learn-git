import database

studentName = input("Enter student name:")
studentAge = input("Enter student age:")
# while studentAge<6:
#     print(int(input("Enter student age:")))
studentClassName = input("Enter student class name:")
# while studentClassName<1 or studentClassName>12:
#     print(int(input("Enter student class name:")))
print("Username is: " + studentName)

db = database.database()
conn = db.connectDb()

cur = conn.cursor()
# db.create_a_table(cur)



# data = ("nam", 19, 12)
# db.addNewStudents(conn, cur, data)

#THÊM SINH VIÊN
student = database.student(studentName, studentAge, studentClassName)
student.get_Infor()
data = (student.ten, student.tuoi, student.lophoc)
db.addNewStudents(conn, cur, data)
cur.close()




#LẤY RA THÔNG TIN SINH VIÊN THEO ID
# a = input("Enter student id:")
# studentId=(a,)
# print(tuple(studentId))
# db.findStudents(conn, cur, studentId)




#CẬP NHẬT THÔNG TIN SINH VIÊN THEO ID
studentId = input("Nhập id: ")
tuple(studentId,)
data = (studentName, studentAge, studentClassName, studentId,)
db.updateStudents(conn,cur,data)




#XÓA SINH VIÊN THEO ID
# db.deleteStudents(conn, cur, studentId)



# LẤY RA TẤT CẢ CÁC THÔNG TIN SINH VIÊN
# print("Tất cả các thông tin học sinh")
# db.selectallstudent(conn, cur)