cars = ["Ford", "Volvo", "BMW"]

print(cars)
#truy cập theo index
print(cars[0])
#modify value theo index
cars[0]="nissan"
print(cars[0])
#trả về số phần tử trong mảng
x = len(cars)
print(x)
for x in cars:
    print(x)
#thêm phần tử mảng bằng phương thức append (tự động thêm phần tử vào vị trí cuối của mảng)
cars.append("honda")
print(cars)


#XÓA PHẦN TỬ
#Xóa phần tử theo index của phần tử trong mảng
cars.pop(2)
print(cars)
#Xóa phần tử theo value 
cars.remove("honda")
print(cars)