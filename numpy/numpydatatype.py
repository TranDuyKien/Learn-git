import numpy as np
#Kiểm tra kiểu dữ liệu của một mảng
arr =  np.array([1,2,3,4,5,6], dtype='S')
print(arr)
print(arr.dtype)




#Cách 1:  Thay đổi dữ liệu từ kiểu float sang kiểu int bằng hàm astype('i')
# arrf= np.array([1.1,2.1,3.1])
# arri= arrf.astype('i')
# print(arri)
# print(arri.dtype)


#Cách 2:  Thay đổi dữ liệu từ kiểu float sang kiểu int bằng hàm astype(int)
# arrf= np.array([1.1,2.1,3.1])
# arri= arrf.astype(int)
# print(arri)
# print(arri.dtype)

#Khi thay đổi kiểu dữ liệu sang
arrf= np.array([1,0,3])
arri= arrf.astype(bool)
print(arri)
print(arri.dtype) 
