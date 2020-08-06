thisdict = {
  "brand": "Ford",
  "model": "Mustang",
  "year": 1964
}
print(thisdict)
#Lấy ra giá trị của một phần tử trong dictionary
x =thisdict["model"]
print(x)
#Cập nhật giá trị cho một phần tử đã biết
thisdict["year"]=2020
print(thisdict)
#Lấy ra các giá trị của các phần ử trong dictionary
for x in thisdict.values():
    print(x)
#Bỏ đi một phần tử khi biết tên phần tử
thisdict.pop("model")
print(thisdict)
#Kiểm tra phần tử có tồn tại trong dictionary
if "model" in thisdict:
    print("Yes, this element existed in dictionary")
#Thêm một phân tử vào trong dictionary
thisdict["color"] = "red"
print(thisdict)




#Sử dụng hàm pop để xóa đi phần tử thông qua tên của nó
thisdict.pop("color")
print(thisdict)
#Xóa phần tử thông qua tên và chỉ số phần tử
del thisdict["brand"]
print(thisdict)


#Sử dụng hàm popitem để xóa phần tử ở vị trí cuối cùng 
thisdict.popitem()
print(thisdict)