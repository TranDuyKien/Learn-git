a = "Hello"
print(a)
#in ra ký tự ở vị trí thứ nhất
print(a[1])

#in ra ký tự ở trong khoảng từ 2 đến 5
b = "Hello, World!"
print(b[2:5])
#in các ký tự từ vị trí thứ 5 đến 2 tính từ cuối chuỗi
print(b[-5:-2])
#in ra độ dài của một chuỗi
print(len(b))

#bỏ đi khoảng trắng ở đầu và cuối
c = "  some whitespace  "
print(c.strip())

#In hoa
print(c.upper())
#in thường
print(c.lower())

#Sử dụng hàm replace để thay thế một chuỗi thành một chuỗi khác
print(c.replace("some","a"))

#Hàm tách các từ trong chuỗi
print(c.split(","))

#Check chuỗi con trong chuỗi
x = "me" in c
print(x)