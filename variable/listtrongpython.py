#Đặc điểm của list: Sử dụng cặp dấu ngoặc vuông, các phần tử trong list cách nhau bằng dấu phẩy, 
# list có thể chứa các kiểu dữ liệu trong python, kiểu dữ liệu list có thể thay đổi giá trị
lista= [[123,45,6],"k","a","h"]
print(lista)
#Lấy ra phần tử trong list theo chỉ số phần tử
print(lista[0])
#Lấy ra các phần tử trong list trong khoảng giới hạn
print(lista[1:3])
#lấy ra số lượng phần tử trong khoảng đã biết
print(lista[:3])
#Kiểm tra phần tử có tồn tại trong danh sách
if "k" in lista:
    print("this is existed")
else:
    print("Not exist")
#Thêm phần tử vào chuỗi
lista.append("l")
for x in lista:
    print(x)
print(lista)
#Thêm phần tử vào một vị trí đã biết.
#Sử dụng lệnh insert(vị trí phần tử muốn thêm, giá trị phần tử)
#Tẩy một phần tử khỏi danh sách
lista.remove("k")
print(lista)
#xóa đi phần tử được chỉ định ở trong list. Nếu không chỉ định vị trí sẽ bỏ đi phần tử cuối cùng trong list
lista.pop()
print(lista)
#Xóa list
lista.clear()
print(lista)
#Gộp nhiều list 
listb = [[123,45,6],"k","a","h"]
listc = ["k","a","h"]
listc.extend(listb)
print(listc)
#Phương thức insert(vị trí cần thêm, giá trị) trong list dùng để giá trị vào vị trí được chỉ định trong list 
#CHÚ Ý: Nếu vị trí được thêm lớn hơn vị trí cuối thì sẽ thêm phần tử vào cuối list
lista.insert(2,"u")
print(lista)
#
listb = [i for i in range(20)]
print(listb)

#Đối với một chuỗi có kiểu list thì các ký tự sẽ được coi là phần tử của list
a = list("something")
print(a)


#CÁC HÀM CƠ BẢN TRONG LIST
#hàm count() trong python dùng để đếm số lần xuất hiện của phần tử được chỉ định trong list
c= listb.count(50)
print(c)
#hàm index trả về vị trí của phần tử được chỉ định nằm trong list
#chú ý nếu không có phần tử được chỉ định nằm trong list trình biên dịch sẽ báo lỗi
d = listb.index(5)
print(d)

#Phương thức sort() sắp xếp phần tử trong chuỗi theo thứ tự tăng dần
#CHÚ Ý: phương thức sort chỉ được sử dụng khi các phần tử trong list phải cùng kiểu
listd= list([5,8,4,1,9,6,7,2,3])
print("listd trước khi gọi hàm sort(): ",listd)
listd.sort()
print("List sau khi gọi hàm sort(): ",listd)
print("listd trước khi gọi hàm sort() và đảo ngược: ",listd.sort(reverse=True))
print(listd)

