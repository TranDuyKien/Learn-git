import database
import json

mydb = database.database()
conn = mydb.connectDb()
cursor = conn.cursor()



#Tạo một bảng 
# student = database.student(studentName,studentAge,studentGT,studentClassName)
# student.get_all_infor()
# data = (student.ten, student.tuoi, student.gioitinh, student.lophoc)




#HÀM TẠO MỘT BẢNG (bảng student)
# mydb.create_table(cursor)

#SHOW CÁC TABLE TRONG BẢNG  (bảng student)
# mydb.show_table(cursor)


#HÀM XÓA MỘT BẢNG
# mydb.delete_table(cursor)


#THÊM MỘT BẢN GHI VÀO BẢNG student
# studentName =str(input("Tên sinh viên: "))
# studentAge = int(input("Tuổi sinh viên: "))
# studentGT = str(input("Giới tính: "))
# studentClassName = int(input("Lớp: "))
# student= database.student(studentName,studentAge,studentGT,studentClassName)
# data = (student.ten,student.tuoi,student.gioitinh,student.lophoc,)
# mydb.insert_a_record(conn,cursor,data)


#Nhập dữ liệu từ định dạng json
with open('datajson.json') as data_file:
    data = json.load(data_file)
    for x in data["students"]:
        student = database.student(x["name"], x["age"], x["gender"], x["class"])
        data = (student.ten,student.tuoi,student.gioitinh,student.lophoc,)
        mydb.insert_a_record(conn,cursor,data)

# student = database.student(x for x in range(len(data["students"])): data["name"], x["age"], x["gender"], x["class"])
# data = (student.ten,student.tuoi,student.gioitinh,student.lophoc,)
# mydb.insert_a_record(conn,cursor,data)
data_file.close()



#CẬP NHẬT MỘT BẢN GHI THEO ID student TRONG BẢNG (student)
# studentName =str(input("Tên sinh viên: "))
# studentAge = int(input("Tuổi sinh viên: "))
# studentGT = str(input("Giới tính: "))
# studentClassName = int(input("Lớp: "))
# studentId = int(input("Id sinh viên: "))
# data =  (studentName,studentAge,studentGT,studentClassName,studentId)
# mydb.update_a_record(conn,cursor,data)


#HÀM XÓA MỘT BẢN GHI THEO ID sinh viên
# a = input("Id sinh viên cần xóa: ")
# studentId = tuple(a)
# print(type(studentId))
# mydb.delete_a_record(conn,cursor,studentId)


#HÀM LẤY RA MỘT BẢN GHI TRONG (bảng student)
# a = input("Nhập ID sinh viên cần lấy thông tin: ")
# studentId = tuple(a,)
# # print(studentId)
# mydb.select_a_record(conn,cursor,studentId)


#HÀM LẤY RA TẤT CẢ CÁC THÔNG TIN SINH VIÊN
# mydb.select_all_data(cursor)





#XÓA MỘT BẢNG TRONG CSDL (bảng tên student)
# mydb.delete_table(cursor)
