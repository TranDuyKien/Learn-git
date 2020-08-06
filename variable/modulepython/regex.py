import re

#Check if the string starts with "The" and ends with "Spain":

txt = "The rain in Spain"
x = re.search("^The.*Spain$", txt)

if x:
  print("YES! We have a match!")
else:
  print("No match")

#Hàm findall() trả về một danh sách chứa tất cả các từ khóa trong chuỗi
x = re.findall("ai", txt)
print(x)

y = re.findall("Portugal", txt)
print(y)

#Hàm trả về số khoảng trắng trong chuỗi
z = re.search("\s", txt)

print("The first white-space character is located in position:", z.start())

#Hàm split() trả về một danh sách kiểu chuỗi (các từ là các phần tử nằm trong chuỗi)
a = re.split("\s", txt)
print(a)

#hàm 
b = re.split("\s", txt, 1)
print(b)

#Hàm thay khoảng trắng bằng một chuỗi
c=  re.sub("\s",",",txt)
print(c)

#Thay thế số khoảng trắng bằng một chuỗi tính từ đầu với số lần được chỉ định
d = re.sub("\s", "9", txt, 2)
print(d)


e = re.search("ai", txt)
print(e) #this will print an object

#Hàm trả về vị trí bắt đầu và vị trí kết thúc của một từ với ký tự được chỉ định nằm trong chuỗi
f = re.search(r"\bS\w+", txt)
print(f.span())


g = re.search(r"\bS\w+", txt)
print(g.string)

#Hàm trả về một từ đầu tiên được bắt đầu với ký tự được chỉ định nằm trong chuỗi
h = re.search(r"\bS\w+", txt)
print(h.group())


#Sử dụng {} để chỉ định vị trí đưa giá trị vào trong chuỗi
valuea = 4
txta = "The price is {} dollars"
print(txta.format(valuea))


#Sử dụng chỉ số phần tử để đưa giá trị tương ứng vào vị trí {chỉ số phần tử}
quantity = 3
itemno = 567
price = 49
myorder = "I want {0} pieces of item number {1} for {2:.2f} dollars."
print(myorder.format(quantity, itemno, price))


age = 36
name = "John"
txt = "His name is {1}. {1} is {0} years old."
print(txt.format(age, name))


myorder = "I have a {carname}, it is a {model}."
print(myorder.format(carname = "Ford", model = "Mustang"))
