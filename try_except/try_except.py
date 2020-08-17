try:
    print(x)
except: 
    print("An except occurred")

try:
  print(x)
except NameError:
  print("Variable x is not defined")
except:
  print("Something else went wrong")

#Nếu khối except không đưa ra được ngoại lệ nào thì những khối khác được thực thi
try:
  print("Hello")
except:
  print("Something went wrong")
else:
  print("Nothing went wrong")


#khối finally luôn được thực thi dù khối trước đó có chạy được hay không
try:
  print(x)
except:
  print("Something went wrong")
finally:
  print("The 'try except' is finished")

#Chương trình có thể chạy mà không có file được mở, sử dụng hàm close để đóng chương trình 
try:
  f = open("try_except/demofile.txt","w")
  f.write("Lorum Ipsum")
except:
  print("Something went wrong when writing to the file")
finally:
  print("successfull")
  f.close()
# x = "hello"

# if not type(x) is int:
#   raise TypeError("Only integers are allowed")

# #
# x = -1

# if x < 0:
  # raise Exception("Sorry, no numbers below zero")