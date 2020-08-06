class student:
    def __init__(self,id, name, age):
        print("Đây là ví dụ về các hàm dựng có sẵn trong python")
        self.id = id
        self.name = name
        self.age = age
    #phương thức hủy constructor sau khi khởi tạo một class, mục đích để giải phóng tài nguyên
    def __del__(self):
        print("Class student được hủy")
st1 = student(1,"john",21)
#Các hàm dựng có sẵn trong python sẽ sử dụng

#hàm dựng getattr sử dụng để truy cập thuộc tính của đối tượng (ở ví dụ này là thuộc tính id)
print(getattr(st1,'age'))

#hàm dựng setattr sử dụng để đặt một giá trị cụ thể cho thuộc tính của đối tượng
#trong ví dự về setattr gán lại giá trị name là nathan
setattr(st1,'name','nathan')
print(getattr(st1,'name','nathan'))

#hàm dựng delattr 
#delattr(st1, 'age')
#print(st1.age)


#hàm dựng hasattr trả về true nếu một đối tượng chứa thuộc tính cụ thể
print(hasattr(st1,'name'))


    