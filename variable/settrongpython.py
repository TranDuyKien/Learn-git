#tạo và in ra các giá trị trong set
thisset = {"apple", "banana", "cherry"}

for x in thisset:
  print(x)
#Kiểm tra phần tử có tồn tại trong set. Nếu có trả về true nếu sai trả về false

print("banana" in thisset)
#Thêm một phần tử vào set
thisset.add("orange")
print(thisset)
#update set
thisset.update(["orange", "mango", "grapes"])

print(thisset)
#Kiểm tra số lượng phần tử trong set
print(len(thisset))
#Tẩy đi một phần tử đã biết giá trị
thisset.remove("orange")
print(thisset)
#Xóa hết các phần tử trong set
thisset.clear()
print(thisset)
#update các set
set1 = {"a", "b" , "c"}
set2 = {1, 2, 3}

set1.update(set2)
print(set1)

#
seta ={1,2,5,4,3,1}
print(type(seta))