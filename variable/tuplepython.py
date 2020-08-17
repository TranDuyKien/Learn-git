#Đặc điểm của kiểu dữ liệu tuples: sử dụng cặp ngoặc tròn để chứa các phân tử của tuples, 
# các phần tử phân cách nhau bởi dấu phẩy, kiểu dữ liệu tuple nhẹ hơn list do sử dụng ít ram hơn
#Kiểu tuple không thể thay đổi giá trị
tuplea= ("a","some","b","some","b")
print(tuplea)
#in ra phần tử ở vị trí đã biết trong tuples
print(tuplea[2])
#lấy các phần tử của tuple trong khoảng đã biết
print(tuplea[2:5])
#Kiểm tra phần tử có tồn tại trong tuples
if "b" in tuplea:
    print ("exist here")
#Gộp hai tuple
tuple1 = ("a", "b" , "c")
tuple2 = (1, 2, 3)

tuple3 = tuple1 + tuple2
print(tuple3)

#Một ngoại lệ
tuple4=(1)
print(tuple4)
#tuple4 lúc này không phải là kiểu tuple mà là kiểu int
#khắc phục thành kiểu tuple bằng cách thêm dấu chấm phẩy: ví dụ
tuple4=(1,)
print(tuple4)
#Chuỗi something sẽ được tách thành các ký tự là các phần tử của tuple với cách khai báo như sau
tuple5=tuple("something")
print(tuple5)

#Tạo ra một genarator expression
tup  = (i for i in range(20))
print(tup)
#Để show ra một genarator expression cần phải có bước trung gian khởi tạo qua constructor tuple
c = tuple(tup)
print(c)


#tuple có các toán tử của kiểu chuỗi
tup = (1,2,3,4,5)
tup += (6,7,8,9)
print(tup[::-1])
