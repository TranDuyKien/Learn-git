import numpy as np


#Sử dụng hàm copy()
# arr = np.array([1,2,3,4,5,6])
# x= arr.copy()
# arr[0] = 42
# print(x)
# print(arr)


#Sử dụng hàm view()
# arr = np.array([1,2,3,4,5,6])
# x= arr.view()
# arr[0] = 42
# print(x)
# print(arr)


#So sánh sự khác biệt khi sử dụng hàm copy() và view() 
# arr = np.array([1,2,3,4,5,6])
# x= arr.view()
# x[0] = 42
# print(x)
# print(arr)


#In ra giá trị base attribute nếu một mảng thật và một mảng được view từ một mảng khác
arr = np.array([1,2,3,4,5,6])
x=arr.copy()
y=arr.view()

print(x)
print(y)

print(x.base)
print(y.base)
