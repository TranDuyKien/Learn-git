import database as db

mydb = db.database()
conn = mydb.connectdb()
cursor = conn.cursor()


#Create a table and show all tables in database mydatabase
# mydb.create_table(cursor)
# mydb.show_all_table(cursor)



#Drop a table
# mydb.drop_table(cursor)

#Insert a record into table infor_student database name mydatabase
# name = input("input name: ")
# age = int(input("input age: "))
# colorskin = input("input colorskin: ")
# address = input("input address: ")
# student = db.student(name,age,colorskin,address)
# data = (student.name,student.age,student.colorskin,student.address,)
# mydb.insert_a_record(conn, cursor, data)



#Update a record in table infor_student database name mydatabase
# name = input("input name: ")
# age = int(input("input age: "))
# colorskin = input("input colorskin: ")
# address = input("input address: ")
# studentid = int(input("input student id: "))
# data = (name,age,colorskin,address,studentid)
# mydb.update_a_record(conn,cursor,data)


#Delete a record in table infor_student database name mydatabase by studentid
# a = int(input("input student id: "))
# studentid = (a,)
# mydb.delete_a_record(conn,cursor,studentid)


#select all infor student where id input== studentid
# a = int(input("input student id: "))
# studentid = (a,)
# mydb.select_infor_a_student(conn,cursor,studentid)


#select all infor student
# mydb.select_all_infor_student(conn,cursor)