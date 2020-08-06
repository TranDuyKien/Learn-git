import re


# #regex là biểu thức chính quy



# txt = "The rain in Spain"
# x = re.search("^The.*Spain$", txt)
# if x:
#   print("YES! We have a match!")
# else:
#   print("No match")




# #Trả về danh sách chứa các từ trong chuỗi
# txt = "The rain in Spain"
# x = re.findall("ai", txt)
# print(x)


# #Check if "Portugal" is in the string:
# x =  re.findall("Portugal",txt)
# if (x):
#   print("Yes, there is at least one match!")
# else:
#   print("No match")

# #Tìm kiếm ký tự white-space đầu tiên trong chuỗi
# y = re.search("\s", txt)

# print("The first white-space character is located in position:", y.start()) 
# z= re.split("\s",txt)
# print(z)


# #Đưa ra từ đầu tiên trong chuỗi
# r1=  re.findall(r"^\w+",txt)
# print(r1)

# #Đưa ra ký tự đầu tiên trong chuỗi
# r2=re.findall(r"^\w",txt)
# print(r2)


# #Tách chuỗi ở khoảng trắng đầu tiên
# a = re.split("\s", txt, 1)
# print(a)

# #Thay tất cả các khoảng trắng bằng một chuỗi được chỉ định
# b = re.sub("\s", " no ", txt)
# print(b)


# #Thay khoảng trắng bằng một chuỗi tính từ đầu chuỗi đến chỉ số khoảng trắng được chỉ định trong chuỗi
# c = re.sub("\s"," a_white_space ",txt,2)
# print(c)


# #Search for an upper case "S" character in the beginning of a word, and print its position:

# x = re.search(r"\bS\w+", txt)
# print(x.span())