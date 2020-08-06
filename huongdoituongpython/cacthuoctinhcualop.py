class student:
    def __init__(self,id,name):
        print("Các thuộc tính cơ bản của lớp")
        self.id = id
        self.name = name
    def showinfor(self):
        print("ID: %d, \nName %s "% (self.id,self.name))
st1 = student(1,'nathan')

#Chứa một chuỗi tài liệu về lớp
print(st1.__doc__)


#Trả về các dictionary chứa namespace của lớp
print(st1.__dict__)

#Truy cập modul trong lớp được định nghĩa
print(st1.__module__)

